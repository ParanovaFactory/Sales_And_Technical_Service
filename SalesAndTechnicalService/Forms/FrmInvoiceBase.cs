using SalesAndTechnicalService.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesAndTechnicalService.Forms
{
    public partial class FrmInvoiceBase : Form
    {
        public FrmInvoiceBase()
        {
            InitializeComponent();
        }

        Db_TechnicalServiceEntities entities = new Db_TechnicalServiceEntities();

        void listBase()
        {
            var values = entities.TblInvoiceBases.Select(x => new
            {
                x.InvoiceBaseId,
                x.InvoiceBaseSerie,
                x.InvoiceBaseOrderNo,
                x.InvoiceBaseDate,
                x.InvoiceBaseHour,
                x.InvoiceBaseTaxOffice,
                x.TblCurrent.CurrentName,
                x.TblCurrent.CurrentSurname,
                x.TblEmployee.EmployeeName,
                x.TblEmployee.EmployeeSurname
            }).ToList();
            gridControl2.DataSource = values;
        }

        int id;
        void listDetail()
        {
            var values2 = entities.TblInvoiceDetails.Where(y => y.InvoiceId == id).Select(x => new
            {
                x.InvoiceDetailsId,
                x.InvoiceDetailsProduct,
                x.InvoiceDetailsPiece,
                x.InvoiceDetailsPrice,
                x.InvoiceDetailsTotalPrice,
                x.InvoiceId
            }).ToList();
            gridControl1.DataSource = values2;
        }

        private void FrmInvoiceBase_Load(object sender, EventArgs e)
        {
            listBase();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInvoiceId.Text == "")
                {
                    TblInvoiceBas tbl = new TblInvoiceBas();
                    tbl.InvoiceBaseSerie = txtSerie.Text;
                    tbl.InvoiceBaseOrderNo = txtOrderNo.Text;
                    tbl.InvoiceBaseDate = mskDate.Text;
                    tbl.InvoiceBaseHour = mskHour.Text;
                    tbl.InvoiceBaseTaxOffice = txtTax.Text;
                    tbl.InvoiceBaseCurrentId = int.Parse(txtCustomer.Text);
                    tbl.InvoiceBaseEmployee = int.Parse(txtEmployee.Text);
                    entities.TblInvoiceBases.Add(tbl);
                    entities.SaveChanges();
                    MessageBox.Show("Invoice Save in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listBase();
                }
                if (txtInvoiceId.Text != "")
                {
                    int piece = int.Parse(txtPiece.Text);
                    decimal price = decimal.Parse(txtPrice.Text);
                    decimal total = piece * price;
                    TblInvoiceDetail tbl = new TblInvoiceDetail();
                    tbl.InvoiceDetailsProduct = txtProduct.Text;
                    tbl.InvoiceDetailsPiece = short.Parse(txtPiece.Text);
                    tbl.InvoiceDetailsPrice = decimal.Parse(txtPrice.Text);
                    tbl.InvoiceDetailsTotalPrice = total;
                    tbl.InvoiceId = int.Parse(txtInvoiceId.Text);
                    entities.TblInvoiceDetails.Add(tbl);
                    entities.SaveChanges();
                    MessageBox.Show("Invoice Save in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listDetail();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Check the entered values", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInvoiceId.Text == "")
                {
                    int id = int.Parse(txtId.Text);
                    var tbl = entities.TblInvoiceBases.Find(id);
                    tbl.InvoiceBaseSerie = txtInvoiceId.Text;
                    tbl.InvoiceBaseOrderNo = txtOrderNo.Text;
                    tbl.InvoiceBaseDate = mskDate.Text;
                    tbl.InvoiceBaseHour = mskHour.Text;
                    tbl.InvoiceBaseTaxOffice = txtTax.Text;
                    tbl.InvoiceBaseCurrentId = int.Parse(txtCustomer.Text);
                    tbl.InvoiceBaseEmployee = int.Parse(txtEmployee.Text);
                    entities.SaveChanges();
                    MessageBox.Show("Invoice Updated in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listBase();
                }
                if (txtInvoiceId.Text != "")
                {
                    int piece = int.Parse(txtPiece.Text);
                    decimal price = decimal.Parse(txtPrice.Text);
                    decimal total = piece * price; 
                    int id = int.Parse(txtDID.Text);
                    var tbl = entities.TblInvoiceDetails.Find(id);
                    tbl.InvoiceDetailsProduct = txtProduct.Text;
                    tbl.InvoiceDetailsPiece = short.Parse(txtPiece.Text);
                    tbl.InvoiceDetailsPrice = decimal.Parse(txtPrice.Text);
                    tbl.InvoiceDetailsTotalPrice = total;
                    tbl.InvoiceId = int.Parse(txtInvoiceId.Text);
                    entities.SaveChanges();
                    MessageBox.Show("Invoice Updated in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listDetail();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Check the entered values", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtSerie.Clear();
            txtOrderNo.Clear();
            mskDate.Clear();
            mskHour.Clear();
            txtTax.Clear();
            txtCustomer.Clear();
            txtEmployee.Clear();
            txtDID.Clear();
            txtProduct.Clear();
            txtPiece.Clear();
            txtPrice.Clear();
            txtInvoiceId.Clear();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var value = entities.TblProducts.Where(x => x.ProductId == id).ToList();

            foreach (var item in value)
            {
                txtProduct.Text = item.ProductName;
                txtPrice.Text = item.ProductSellingPrice.ToString();
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtId.Text = gridView2.GetFocusedRowCellValue("InvoiceBaseId").ToString();
                txtSerie.Text = gridView2.GetFocusedRowCellValue("InvoiceBaseSerie").ToString();
                txtOrderNo.Text = gridView2.GetFocusedRowCellValue("InvoiceBaseOrderNo").ToString();
                mskDate.Text = gridView2.GetFocusedRowCellValue("InvoiceBaseDate").ToString();
                mskHour.Text = gridView2.GetFocusedRowCellValue("InvoiceBaseHour").ToString();
                txtTax.Text = gridView2.GetFocusedRowCellValue("InvoiceBaseTaxOffice").ToString();
                txtCustomer.Text = gridView2.GetFocusedRowCellValue("CurrentName").ToString() + " " + gridView2.GetFocusedRowCellValue("CurrentSurname").ToString();
                txtEmployee.Text = gridView2.GetFocusedRowCellValue("EmployeeName").ToString() + " " + gridView2.GetFocusedRowCellValue("EmployeeSurname").ToString();

                id = int.Parse(txtId.Text);
                listDetail();
            }
            catch (Exception)
            {

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtDID.Text = gridView1.GetFocusedRowCellValue("InvoiceDetailsId").ToString();
                txtProduct.Text = gridView1.GetFocusedRowCellValue("InvoiceDetailsProduct").ToString();
                txtPiece.Text = gridView1.GetFocusedRowCellValue("InvoiceDetailsPiece").ToString();
                txtPrice.Text = gridView1.GetFocusedRowCellValue("InvoiceDetailsPrice").ToString();
                txtInvoiceId.Text = gridView1.GetFocusedRowCellValue("InvoiceId").ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            listDetail();
        }

        private void bntListt_Click(object sender, EventArgs e)
        {
            listBase();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            string path = txtCustomer.Text+".pdf";
            gridControl1.ExportToPdf(path);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string path = txtCustomer.Text + ".xlsx";
            gridControl1.ExportToXlsx(path);
        }
    }
}
