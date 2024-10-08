using SalesAndTechnicalService.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesAndTechnicalService.Forms
{
    public partial class FrmProduct : Form
    {
        Db_TechnicalServiceEntities entities = new Db_TechnicalServiceEntities();

        public FrmProduct()
        {
            InitializeComponent();
        }

        void clearAdd()
        {
            txtAddName.Clear();
            txtAddBrand.Clear();
            txtAddBuy.Clear();
            txtAddSell.Clear();
            txtAddStock.Clear();
            cmbAddCathegory.Text = "";
            rhcAddDescription.Clear();
        }

        void clearUp()
        {
            txtId.Clear();
            txtUpName.Clear();
            txtUpBrand.Clear();
            txtUpBuy.Clear();
            txtUpSell.Clear();
            txtUpStock.Clear();
            cmbUppCategory.Text = "";
            rhcUpDescription.Clear();
        }

        void listProduct()
        {
            var items = from p in entities.TblProducts
                        select new
                        {
                            p.ProductId,
                            p.ProductName,
                            p.ProductBrand,
                            p.ProductBuyingPrice,
                            p.ProductSellingPrice,
                            p.ProductStock,
                            p.TblCathegory.CathegoryName,
                            p.ProductStatus,
                            p.ProductDescription,
                        };
            gridControl1.DataSource = items.ToList();
        }

        private void FrmProductList_Load(object sender, EventArgs e)
        {
            listProduct();

            cmbAddCathegory.DataSource = entities.TblCathegories.ToList();
            cmbAddCathegory.DisplayMember = "CathegoryName";
            cmbAddCathegory.ValueMember = "CathegoryId";

            cmbUppCategory.DataSource = entities.TblCathegories.ToList();
            cmbUppCategory.DisplayMember = "CathegoryName";
            cmbUppCategory.ValueMember = "CathegoryId";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                TblProduct product = new TblProduct();
                product.ProductName = txtAddName.Text;
                product.ProductBrand = txtAddBrand.Text;
                product.ProductBuyingPrice = decimal.Parse(txtAddBuy.Text);
                product.ProductSellingPrice = decimal.Parse(txtAddSell.Text);
                product.ProductStock = short.Parse(txtAddStock.Text);
                product.ProductCathegory = cmbAddCathegory.SelectedIndex + 1;
                if (int.Parse(txtAddStock.Text) < 20)
                {
                    product.ProductStatus = true;
                }
                else
                {
                    product.ProductStatus = false;
                }
                product.ProductDescription = rhcAddDescription.Text;
                entities.TblProducts.Add(product);
                entities.SaveChanges();
                MessageBox.Show("Product Saved in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var value = entities.TblProducts.Find(id);
                entities.TblProducts.Remove(value);
                entities.SaveChanges();
                MessageBox.Show("Product Deleted in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var value = entities.TblProducts.Find(id);
                value.ProductName = txtUpName.Text;
                value.ProductBrand = txtUpBrand.Text;
                value.ProductBuyingPrice = decimal.Parse( txtUpBuy.Text);
                value.ProductSellingPrice = decimal.Parse( txtUpSell.Text);
                value.ProductStock = short.Parse(txtUpStock.Text);
                value.ProductCathegory = cmbUppCategory.SelectedIndex + 1;
                value.ProductDescription = rhcUpDescription.Text;
                entities.SaveChanges();
                MessageBox.Show("Product Updated in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Chech the Entered Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            listProduct();
        }

        private void btnUppList_Click(object sender, EventArgs e)
        {
            listProduct();
        }

        private void btnAddClear_Click(object sender, EventArgs e)
        {
            clearAdd();
        }

        private void btnUpdClear_Click(object sender, EventArgs e)
        {
            clearUp();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtAddName.Text = gridView1.GetFocusedRowCellValue("ProductName").ToString();
                txtAddBrand.Text = gridView1.GetFocusedRowCellValue("ProductBrand").ToString();
                txtAddBuy.Text = gridView1.GetFocusedRowCellValue("ProductBuyingPrice").ToString();
                txtAddSell.Text = gridView1.GetFocusedRowCellValue("ProductSellingPrice").ToString();
                rhcAddDescription.Text = gridView1.GetFocusedRowCellValue("ProductDescription").ToString();
                cmbAddCathegory.SelectedText = gridView1.GetFocusedRowCellValue("ProductCathegory").ToString();
                txtAddStock.Text = gridView1.GetFocusedRowCellValue("ProductStock").ToString();



                txtId.Text = gridView1.GetFocusedRowCellValue("ProductId").ToString();
                txtUpName.Text = gridView1.GetFocusedRowCellValue("ProductName").ToString();
                txtUpBrand.Text = gridView1.GetFocusedRowCellValue("ProductBrand").ToString();
                txtUpBuy.Text = gridView1.GetFocusedRowCellValue("ProductBuyingPrice").ToString();
                txtUpSell.Text = gridView1.GetFocusedRowCellValue("ProductSellingPrice").ToString();
                rhcUpDescription.Text = gridView1.GetFocusedRowCellValue("ProductDescription").ToString();
                cmbUppCategory.SelectedText = gridView1.GetFocusedRowCellValue("ProductCathegory").ToString();
                txtUpStock.Text = gridView1.GetFocusedRowCellValue("ProductStock").ToString();
            }
            catch (Exception)
            {
            }
            
        }
    }
}
