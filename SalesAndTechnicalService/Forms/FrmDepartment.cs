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
    public partial class FrmDepartment : Form
    {
        Db_TechnicalServiceEntities entities = new Db_TechnicalServiceEntities();

        public FrmDepartment()
        {
            InitializeComponent();
        }

        void list()
        {
            var values = entities.TblDepartments.Select(x => new
            {
                x.DepartmentId,
                x.DepartmentName,
                x.DepartmentDescription
            }).ToList();

            gridControl1.DataSource = values;
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            list();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                TblDepartment department = new TblDepartment();
                department.DepartmentName = txtName.Text;
                department.DepartmentDescription = rchDescription.Text;
                entities.TblDepartments.Add(department);
                entities.SaveChanges();
                MessageBox.Show("Department Saved in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var value = entities.TblDepartments.Find(id);
                value.DepartmentName = txtName.Text;
                value.DepartmentDescription = rchDescription.Text;
                entities.SaveChanges();
                MessageBox.Show("Department Updated in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var value = entities.TblDepartments.Find(id);
                entities.TblDepartments.Remove(value);
                entities.SaveChanges();
                MessageBox.Show("Department Saved in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Chech the Entered Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtId.Text = gridView1.GetFocusedRowCellValue("DepartmentId").ToString();
                txtName.Text = gridView1.GetFocusedRowCellValue("DepartmentName").ToString();
                rchDescription.Text = gridView1.GetFocusedRowCellValue("DepartmentDescription").ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}
