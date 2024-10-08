using DevExpress.Data.ODataLinq.Helpers;
using SalesAndTechnicalService.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesAndTechnicalService.Forms
{
    public partial class FrmCurrentStatistic : Form
    {
        public FrmCurrentStatistic()
        {
            InitializeComponent();
        }

        Db_TechnicalServiceEntities entity = new Db_TechnicalServiceEntities();
        SqlConnection conn = new SqlConnection(@"Data Source=PREDATOR;Initial Catalog=Db_TechnicalService;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void FrmCurrentStatistic_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = entity.TblCurrents
                .OrderBy(x => x.CurrentCountry)
                .GroupBy(t => t.CurrentCountry)
                .Select(z => new
                {
                    Country = z.Key,
                    Total = z.Count()
                }).ToList();

            conn.Open();
            SqlCommand command = new SqlCommand("select CurrentCountry,count(*) from TblCurrent group by CurrentCountry", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                chartControl1.Series["County"].Points.AddPoint(Convert.ToString(reader[0]), Convert.ToUInt32(reader[1]));
            }
            conn.Close();
        }
    }
}
