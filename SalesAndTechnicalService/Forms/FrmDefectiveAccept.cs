using SalesAndTechnicalService.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SalesAndTechnicalService.Forms
{
    public partial class FrmDefectiveAccept : Form
    {
        public FrmDefectiveAccept()
        {
            InitializeComponent();
        }

        Db_TechnicalServiceEntities entities = new Db_TechnicalServiceEntities();

        void list()
        {
            var values = from x in entities.TblProductAcceptances
                          select  new
                          {
                              x.AcceptId,
                              x.TblEmployee.EmployeeName,
                              x.TblEmployee.EmployeeSurname,
                              x.TblCurrent.CurrentName,
                              x.TblCurrent.CurrentSurname,
                              x.AcceptComingDate,
                              x.AcceptGointDate,
                              x.AcceptSerieNo
                          };

            gridControl1.DataSource = values.ToList();
        }

        private void FrmDefectiveAccept_Load(object sender, EventArgs e)
        {
            list();

            cmbCustomer.DataSource = entities.TblCurrents.ToList();
            cmbCustomer.DisplayMember = "CurrentId";
            cmbCustomer.ValueMember = "CurrentId";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                TblProductAcceptance acceptance = new TblProductAcceptance();
                acceptance.AcceptEmployee = Convert.ToInt32(cmbEmployee.Text);
                acceptance.AcceptCurrentId = Convert.ToInt32(cmbCustomer.SelectedIndex+1);
                acceptance.AcceptComingDate = txtComingDate.Text;
                acceptance.AcceptGointDate = txtGoingDate.Text;
                acceptance.AcceptSerieNo = txtSeriNo.Text;
                entities.TblProductAcceptances.Add(acceptance);
                entities.SaveChanges();
                MessageBox.Show("Defective Product Saved in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Chech the Entered Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                var acceptance = entities.TblProductAcceptances.Find(id);
                acceptance.AcceptEmployee = Convert.ToInt32(cmbEmployee.Text);
                acceptance.AcceptCurrentId = Convert.ToInt32(cmbCustomer.SelectedIndex + 1);
                acceptance.AcceptComingDate = txtComingDate.Text;
                acceptance.AcceptGointDate = txtGoingDate.Text;
                acceptance.AcceptSerieNo = txtSeriNo.Text;
                entities.SaveChanges();
                MessageBox.Show("Defective Product Updated in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Chech the Entered Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                var acceptance = entities.TblProductAcceptances.Find(id);
                entities.TblProductAcceptances.Remove(acceptance);
                entities.SaveChanges();
                MessageBox.Show("Defective Product Deleted in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Chech the Entered Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtComingDate.Clear();
            txtGoingDate.Clear();
            txtSeriNo.Clear();
            cmbCustomer.SelectedIndex = 0;
            cmbEmployee.Clear();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtId.Text = gridView1.GetFocusedRowCellValue("AcceptId").ToString();
                txtComingDate.Text = gridView1.GetFocusedRowCellValue("AcceptComingDate").ToString();
                txtGoingDate.Text = gridView1.GetFocusedRowCellValue("AcceptGointDate").ToString();
                cmbCustomer.Text = gridView1.GetFocusedRowCellValue("CurrentName").ToString();
                cmbEmployee.Text = gridView1.GetFocusedRowCellValue("EmployeeName").ToString();
                txtSeriNo.Text = gridView1.GetFocusedRowCellValue("AcceptSerieNo").ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}
