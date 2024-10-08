using SalesAndTechnicalService.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesAndTechnicalService.Forms
{
    public partial class FrmPhoneBook : Form
    {
        public FrmPhoneBook()
        {
            InitializeComponent();
        }

        Db_TechnicalServiceEntities entities = new Db_TechnicalServiceEntities();

        private void FrmPhoneBook_Load(object sender, EventArgs e)
        {
            var values = entities.TblCurrents.Select(x => new
            {
                x.CurrentName,
                x.CurrentSurname,
                x.CurrentMail,
                x.CurrentPhone
            }).ToList();

            gridControl1.DataSource = values;
        }
    }
}
