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
    public partial class FrmCathegoryAdd : Form
    {
        Db_TechnicalServiceEntities entities = new Db_TechnicalServiceEntities();

        public FrmCathegoryAdd()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                TblCathegory cathegory = new TblCathegory();
                cathegory.CathegoryName = txtCathegoryName.Text;
                entities.TblCathegories.Add(cathegory);
                entities.SaveChanges();
                MessageBox.Show("Cathegory Saved in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Chech the Entered Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
