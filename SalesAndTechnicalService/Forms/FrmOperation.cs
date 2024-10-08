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
    public partial class FrmOperation : Form
    {
        public FrmOperation()
        {
            InitializeComponent();
        }

        Db_TechnicalServiceEntities entities = new Db_TechnicalServiceEntities();

        void list()
        {
            var values = entities.TblProcesses.Select(x =>  new
            {
                x.ProcessId,
                x.ProcessTitle,
                x.ProcessDescription
            }).ToList();
            gridControl1.DataSource = values;
        }

        private void FrmOperation_Load(object sender, EventArgs e)
        {
            list();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                TblProcess process = new TblProcess();
                process.ProcessTitle = txtTitle.Text;
                process.ProcessDescription = rchDescription.Text;
                entities.TblProcesses.Add(process);
                entities.SaveChanges();
                MessageBox.Show("Operation Saved in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var process = entities.TblProcesses.Find(id);
                process.ProcessTitle = txtTitle.Text;
                process.ProcessDescription = rchDescription.Text;
                entities.SaveChanges();
                MessageBox.Show("Operation Updated in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var process = entities.TblProcesses.Find(id);
                entities.TblProcesses.Remove(process);
                entities.SaveChanges();
                MessageBox.Show("Operation Updated in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtTitle.Clear();
            rchDescription.Clear();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ProcessId").ToString();
            txtTitle.Text = gridView1.GetFocusedRowCellValue("ProcessTitle").ToString();
            rchDescription.Text = gridView1.GetFocusedRowCellValue("ProcessDescription").ToString();
        }
    }
}
