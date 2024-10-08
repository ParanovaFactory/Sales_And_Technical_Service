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
    public partial class FrmProductProductStatistics : Form
    {
        Db_TechnicalServiceEntities entities = new Db_TechnicalServiceEntities();

        public FrmProductProductStatistics()
        {
            InitializeComponent();
        }

        private void FrmProductProductStatistics_Load(object sender, EventArgs e)
        {
            lblbNumOfProduct.Text = entities.TblProducts.Count().ToString();

            lblNumOfCathegory.Text = entities.TblCathegories.Count().ToString();

            lblTotalStock.Text = entities.TblProducts.Sum(x => x.ProductStock).ToString();

            lblCriticStock.Text = entities.TblProducts.Count(x => x.ProductStatus == true).ToString();

            lblMostStock.Text = (from x in entities.TblProducts
                                 orderby x.ProductStock descending
                                 select x.ProductName).FirstOrDefault();

            lblLEastStock.Text = (from x in entities.TblProducts
                                  orderby x.ProductStock ascending
                                  select x.ProductName).FirstOrDefault();


            lblHighPrice.Text = (from x in entities.TblProducts
                                 orderby x.ProductSellingPrice descending
                                 select x.ProductName).FirstOrDefault();

            lblLowPrice.Text = (from x in entities.TblProducts
                                orderby x.ProductSellingPrice ascending
                                select x.ProductName).FirstOrDefault();

            lblBrand.Text = (from x in entities.TblProducts
                             select x.ProductBrand).Distinct().Count().ToString();

            lblCrovdedCathegory.Text = (from p in entities.TblProducts
                                        join c in entities.TblCathegories on p.ProductCathegory equals c.CathegoryId
                                        group p by new { c.CathegoryId, c.CathegoryName } into g
                                        select new
                                        {
                                            CategoryName = g.Key.CathegoryName,
                                            TotalStock = g.Sum(p => p.ProductStock)
                                        })
              .OrderByDescending(g => g.TotalStock).Select(g => g.CategoryName).FirstOrDefault().ToString();

            lblCrovdedBrand.Text = entities.TblProducts
                                   .GroupBy(p => p.ProductBrand).
                                   Select(g => new
                                   {
                                       ProductBrand = g.Key,
                                       TotalStock = g.Sum(p => p.ProductStock)
                                   }).OrderByDescending(g => g.TotalStock)
                                   .Select(g=>g.ProductBrand)
                                   .FirstOrDefault().ToString();

            string today = Convert.ToString(DateTime.Today);

            lblSales.Text = entities.TblSales
                .Sum(y => y.SaleTotalPrice).ToString()+"$";

            lblDefective.Text = entities.TblDefectiveProducts.Count().ToString();

            lblService.Text = entities.TblDefectiveProducts
                .Where(x => x.FaultNetPrice == null)
                .Count().ToString();

            lblCargoPsduct.Text = entities.TblDefectiveProducts.Where(x => x.FaultNetPrice != null).Count().ToString();
        }
    }
}
