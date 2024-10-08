using DevExpress.XtraEditors.Controls;
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
    public partial class FrmSale : Form
    {
        public FrmSale()
        {
            InitializeComponent();
        }

        Db_TechnicalServiceEntities entities = new Db_TechnicalServiceEntities();

        void list()
        {
            var values = from x in entities.TblSales
                         select new
                         {
                             x.SaleId,
                             x.TblProduct.ProductName,
                             x.TblCurrent.CurrentName,
                             x.TblCurrent.CurrentSurname,
                             x.TblEmployee.EmployeeName,
                             x.TblEmployee.EmployeeSurname,
                             x.SaleDate,
                             x.SalePiece,
                             x.SalePrice,
                             x.SaleTotalPrice,
                             x.SaleProdutSerieNo
                         };

            gridControl1.DataSource = values.ToList();
        }

        private void FrmSale_Load(object sender, EventArgs e)
        {
            list();

            cmbCustomer.DataSource = entities.TblCurrents.ToList();
            cmbCustomer.DisplayMember = "CurrentId";
            cmbCustomer.ValueMember = "CurrentId";

            cmbProduct.DataSource = entities.TblProducts.ToList();
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductId";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            short piece = short.Parse(txtPiece.Text);
            decimal price = decimal.Parse(txtPrice.Text);
            TblSale sale = new TblSale();
            sale.SaleProduct = cmbProduct.SelectedIndex + 1;
            sale.SaleCustomer = cmbCustomer.SelectedIndex + 1;
            sale.SaleEmployee = int.Parse(cmbEmployee.Text);
            sale.SaleDate = txtDate.Text;
            sale.SalePiece = short.Parse(txtPiece.Text);
            sale.SalePrice = decimal.Parse(txtPrice.Text);
            sale.SaleTotalPrice = piece * price;
            entities.TblSales.Add(sale);
            entities.SaveChanges();
            MessageBox.Show("Sale Operation Saved in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
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
                int piece = int.Parse(txtPiece.Text);
                decimal price = decimal.Parse(txtPrice.Text);
                var sale = entities.TblSales.Find(id);
                sale.SaleProduct = cmbProduct.SelectedIndex + 1;
                sale.SaleCustomer = cmbCustomer.SelectedIndex + 1;
                sale.SaleEmployee = int.Parse(cmbEmployee.Text);
                sale.SaleDate = txtDate.Text;
                sale.SalePiece = short.Parse(txtPiece.Text);
                sale.SalePrice = decimal.Parse(txtPrice.Text);
                sale.SaleTotalPrice = piece * price;
                entities.SaveChanges();
                MessageBox.Show("Sale Operation Updated in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var sale = entities.TblSales.Find(id);
                entities.TblSales.Remove(sale);
                entities.SaveChanges();
                MessageBox.Show("Sale Operation Deleted in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Chech the Entered Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtPiece.Clear();
            txtPrice.Clear();
            cmbProduct.SelectedIndex = 0;
            cmbCustomer.SelectedIndex = 0;
            cmbEmployee.Clear();
            txtDate.Clear();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtId.Text = gridView1.GetFocusedRowCellValue("SaleId").ToString();
                txtPiece.Text = gridView1.GetFocusedRowCellValue("SalePiece").ToString();
                txtPrice.Text = gridView1.GetFocusedRowCellValue("SalePrice").ToString();
                cmbProduct.Text = gridView1.GetFocusedRowCellValue("ProductName").ToString();
                cmbEmployee.Text = gridView1.GetFocusedRowCellValue("EmployeeName").ToString();
                cmbCustomer.Text = gridView1.GetFocusedRowCellValue("CurrentName").ToString();
                txtDate.Text = gridView1.GetFocusedRowCellValue("SaleDate").ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}
