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
    public partial class FrmEmployee : Form
    {
        Db_TechnicalServiceEntities entity = new Db_TechnicalServiceEntities();
        public FrmEmployee()
        {
            InitializeComponent();
        }

        void list()
        {
            var values = entity.TblEmployees.Select(x => new
            {
                x.EmployeeId,
                x.EmployeeName,
                x.EmployeeSurname,
                x.TblDepartment.DepartmentName,
                x.EmployeeMail,
                x.EmployeePhone,
                x.EmployeeImage
            }).ToList();

            gridControl1.DataSource = values;
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            list();

            cmbDepartment.DataSource = entity.TblDepartments.ToList();
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "DepartmentId";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                TblEmployee employee = new TblEmployee();
                employee.EmployeeName = txtName.Text;
                employee.EmployeeSurname = txtSurname.Text;
                employee.EmployeeDepartment = cmbDepartment.SelectedIndex + 1;
                employee.EmployeeMail = txtMail.Text;
                employee.EmployeePhone = txtPhone.Text;
                employee.EmployeeImage = txtImage.Text;
                entity.TblEmployees.Add(employee);
                entity.SaveChanges();
                MessageBox.Show("Employee Saved in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var velue = entity.TblEmployees.Find(id);
                velue.EmployeeName = txtName.Text;
                velue.EmployeeSurname = txtSurname.Text;
                velue.EmployeeDepartment = cmbDepartment.SelectedIndex + 1;
                velue.EmployeeMail = txtMail.Text;
                velue.EmployeePhone = txtPhone.Text;
                velue.EmployeeImage = txtImage.Text;
                entity.SaveChanges();
                MessageBox.Show("Employee Updated in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var velue = entity.TblEmployees.Find(id);
                entity.TblEmployees.Remove(velue);
                entity.SaveChanges();
                MessageBox.Show("Employee Deleted in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Chech the Entered Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtSurname.Clear();
            cmbDepartment.SelectedIndex = 0;
            txtMail.Clear();
            txtPhone.Clear();
            txtImage.Clear();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtId.Text = gridView1.GetFocusedRowCellValue("EmployeeId").ToString();
                txtName.Text = gridView1.GetFocusedRowCellValue("EmployeeName").ToString();
                txtSurname.Text = gridView1.GetFocusedRowCellValue("EmployeeSurname").ToString();
                cmbDepartment.Text = gridView1.GetFocusedRowCellValue("DepartmentName").ToString();
                txtImage.Text = gridView1.GetFocusedRowCellValue("EmployeeImage").ToString();
                txtMail.Text = gridView1.GetFocusedRowCellValue("EmployeeMail").ToString();
                txtPhone.Text = gridView1.GetFocusedRowCellValue("EmployeePhone").ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}
