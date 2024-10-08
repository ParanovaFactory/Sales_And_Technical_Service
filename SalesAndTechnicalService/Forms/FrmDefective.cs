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
    public partial class FrmDefective : Form
    {
        public FrmDefective()
        {
            InitializeComponent();
        }

        Db_TechnicalServiceEntities entities = new Db_TechnicalServiceEntities();

        void list()
        {
            var values = entities.TblDefectiveProducts.Where(X => X.FaultNetPrice == null).Select(x => new
            {
                x.FaultId,
                x.TblProcess.ProcessTitle,
                x.FaultProblem,
                x.FaultNote,
                x.FaultEstimatedPrice,
                x.FaultTransactionsMade,
                x.FaultNetPrice,
                x.FaultSerieNo
            }).ToList();
            gridControl1.DataSource = values;

            var values1 = entities.TblDefectiveProducts.Where(X => X.FaultNetPrice != null).Select(x => new
            {
                x.FaultId,
                x.TblProcess.ProcessTitle,
                x.FaultProblem,
                x.FaultNote,
                x.FaultEstimatedPrice,
                x.FaultTransactionsMade,
                x.FaultNetPrice,
                x.FaultSerieNo
            }).ToList();
            gridControl2.DataSource = values1;
        }

        private void FrmDefective_Load(object sender, EventArgs e)
        {
            list();

            cmbProcess.DataSource = entities.TblProcesses.ToList();
            cmbProcess.DisplayMember = "ProcessTitle";
            cmbProcess.ValueMember = "ProcessId";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                TblDefectiveProduct product = new TblDefectiveProduct();
                product.FaultProcess = cmbProcess.SelectedIndex + 1;
                product.FaultProblem = txtProblem.Text;
                product.FaultNote = rchNote.Text;
                product.FaultEstimatedPrice = decimal.Parse(txtEstimeted.Text);
                entities.TblDefectiveProducts.Add(product);
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
                var product = entities.TblDefectiveProducts.Find(id);
                product.FaultProcess = cmbProcess.SelectedIndex + 1;
                product.FaultProblem = txtProblem.Text;
                product.FaultNote = rchNote.Text;
                product.FaultEstimatedPrice = decimal.Parse(txtEstimeted.Text);
                product.FaultNetPrice = decimal.Parse(txtNet.Text);
                product.FaultTransactionsMade = rchTransaction.Text;
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
                var product = entities.TblDefectiveProducts.Find(id);
                entities.TblDefectiveProducts.Remove(product);
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
            cmbProcess.Text = "";
            txtProblem.Clear();
            rchNote.Clear();
            txtEstimeted.Clear();
            txtSeriNo.Clear();
            rchTransaction.Clear();
            txtNet.Clear();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtId.Text = gridView1.GetFocusedRowCellValue("FaultId").ToString();
                cmbProcess.Text = gridView1.GetFocusedRowCellValue("ProcessTitle").ToString();
                txtProblem.Text = gridView1.GetFocusedRowCellValue("FaultProblem").ToString();
                rchNote.Text = gridView1.GetFocusedRowCellValue("FaultNote").ToString();
                txtEstimeted.Text = gridView1.GetFocusedRowCellValue("FaultEstimatedPrice").ToString();
                txtSeriNo.Text = gridView1.GetFocusedRowCellValue("FaultSerieNo").ToString();
                rchTransaction.Clear();
                txtNet.Clear();
            }
            catch (Exception)
            {
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtId.Text = gridView2.GetFocusedRowCellValue("FaultId").ToString();
                cmbProcess.Text = gridView2.GetFocusedRowCellValue("ProcessTitle").ToString();
                txtProblem.Text = gridView2.GetFocusedRowCellValue("FaultProblem").ToString();
                rchNote.Text = gridView2.GetFocusedRowCellValue("FaultNote").ToString();
                txtEstimeted.Text = gridView2.GetFocusedRowCellValue("FaultEstimatedPrice").ToString();
                rchTransaction.Text = gridView2.GetFocusedRowCellValue("FaultTransactionsMade").ToString();
                txtNet.Text = gridView2.GetFocusedRowCellValue("FaultNetPrice").ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}
