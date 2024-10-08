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
    public partial class FrmAddProduct : Form
    {
        Db_TechnicalServiceEntities entities = new Db_TechnicalServiceEntities();

        public FrmAddProduct()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                TblProduct product = new TblProduct();
                product.ProductName = txtAddName.Text;
                product.ProductBrand = txtAddBrand.Text;
                product.ProductBuyingPrice = decimal.Parse(txtAddBuy.Text);
                product.ProductSellingPrice = decimal.Parse(txtAddSell.Text);
                product.ProductStock = short.Parse(txtAddStock.Text);
                product.ProductCathegory = byte.Parse(cmbAddCathegory.EditValue.ToString());
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
