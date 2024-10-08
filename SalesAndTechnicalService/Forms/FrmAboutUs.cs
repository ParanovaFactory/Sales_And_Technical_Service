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
    public partial class FrmAboutUs : Form
    {
        public FrmAboutUs()
        {
            InitializeComponent();
        }

        Db_TechnicalServiceEntities entities = new Db_TechnicalServiceEntities();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                TblAbout us = new TblAbout();
                us.Context = rchAbout.Text;
                entities.SaveChanges();
                MessageBox.Show("About Us State Updated in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

            }
        }

        private void FrmAboutUs_Load(object sender, EventArgs e)
        {

        }
    }
}
