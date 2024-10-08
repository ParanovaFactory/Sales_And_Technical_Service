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
    public partial class FrmContact : Form
    {
        public FrmContact()
        {
            InitializeComponent();
        }

        Db_TechnicalServiceEntities entity = new Db_TechnicalServiceEntities();

        private void FrmContact_Load(object sender, EventArgs e)
        {
            var values = entity.TBl_Contact.ToList();
            gridControl1.DataSource = values;
        }
    }
}
