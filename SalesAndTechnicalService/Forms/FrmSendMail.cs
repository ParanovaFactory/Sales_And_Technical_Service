using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace SalesAndTechnicalService.Forms
{
    public partial class FrmSendMail : Form
    {
        public FrmSendMail()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            string fromMail = "Sender e-mail";
            string password = "Sender Password";
            string toMail = txtMail.Text;
            string subject = txtTitle.Text;
            string content = rchContext.Text;

            mail.From = new MailAddress(fromMail);
            mail.To.Add(toMail);
            mail.Subject = subject;
            mail.Body = content;
            mail.IsBodyHtml = true;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com",587);
            smtpClient.Credentials = new NetworkCredential(fromMail,password);
            smtpClient.EnableSsl = true;
            smtpClient.Send(mail);
            MessageBox.Show("Mail Has Been Send", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
