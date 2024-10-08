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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        Db_TechnicalServiceEntities entities = new Db_TechnicalServiceEntities();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ParanovaFactory");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/sad%C4%B1k-berkay-karaduman-7407621a7/");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var query = from x in entities.TblAdmins where x.UserName == txtUsername.Text & x.Password == txtPassword.Text select x;
            if (query.Any())
            {
                FrmMain main = new FrmMain();
                main.Show();
                this.Hide();
                MessageBox.Show("Welcome To System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Check Your Username And Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
