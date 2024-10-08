using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
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
    public partial class FrmProductBrandStatistics : Form
    {
        public FrmProductBrandStatistics()
        {
            InitializeComponent();
        }

        Db_TechnicalServiceEntities entities = new Db_TechnicalServiceEntities();

        private void FrmProductBrandStatistics_Load(object sender, EventArgs e)
        {
            var values = entities.TblProducts.OrderBy(x => x.ProductBrand).GroupBy(y => y.ProductBrand)
                .Select(z => new
                {
                    ProductBrand = z.Key,
                    Total = z.Count()
                }).ToList();

            gridControl1.DataSource = values;

            lblNumOfProduct.Text = entities.TblProducts.Count().ToString();

            lblBrand.Text = (from x in entities.TblProducts
                                    select x.ProductBrand
                                    ).Distinct().Count().ToString();

            lblCrovdedBrand.Text = entities.TblProducts
                                   .GroupBy(p => p.ProductBrand).
                                   Select(g => new
                                   {
                                       ProductBrand = g.Key,
                                       TotalProduct = g.Sum(p => p.ProductId)
                                   }).OrderByDescending(g => g.TotalProduct)
                                   .Select(g => g.ProductBrand)
                                   .FirstOrDefault().ToString();

            lblExpensiveBrand.Text = (from x in entities.TblProducts
                                      orderby x.ProductSellingPrice descending
                                      select x.ProductBrand
                                      ).FirstOrDefault().ToString();

            var values1 = entities.TblProducts
                                   .GroupBy(p => p.ProductBrand).
                                   Select(g => new
                                   {
                                       ProductBrand = g.Key,
                                       TotalStock = g.Sum(p => p.ProductStock)
                                   }).ToList();

            foreach (var item in values1)
            {
                chartControl1.Series["Brands"].Points.AddPoint(Convert.ToString(item.ProductBrand),Convert.ToUInt32(item.TotalStock));
            }

            var values2 = entities.TblProducts
                .GroupBy(p => p.TblCathegory.CathegoryName)
                .Select(g => new
                {
                CategoryName = g.Key,
                TotalProducts = g.Count()
                }).ToList();

            foreach (var item in values2)
            {
                chartControl2.Series["Category"].Points.AddPoint(Convert.ToString(item.CategoryName), Convert.ToUInt32(item.TotalProducts));
            }

        }
    }
}
