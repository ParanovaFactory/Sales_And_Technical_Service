using SalesAndTechnicalService.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesAndTechnicalService
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        FrmProduct product;
        private void btnProductList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (product == null || product.IsDisposed)
            {
                product = new FrmProduct();
                product.MdiParent = this;
                product.Show();
            }
        }

        FrmAddProduct addProduct;
        private void btnNewProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (addProduct == null)
            {
                addProduct = new FrmAddProduct();
                addProduct.Show();
            }
        }

        FrmCathegory cathegory;
        private void btnCathegoryList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cathegory == null || cathegory.IsDisposed)
            {
                cathegory = new FrmCathegory();
                cathegory.MdiParent = this;
                cathegory.Show();
            }
        }

        FrmCathegoryAdd cathegoryAdd;
        private void btnAddCathegory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cathegoryAdd == null)
            {
                cathegoryAdd = new FrmCathegoryAdd();
                cathegoryAdd.Show();
            }
        }

        FrmProductProductStatistics statistics;
        private void btnProducStatistic_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (statistics == null || statistics.IsDisposed)
            {
                statistics = new FrmProductProductStatistics();
                statistics.MdiParent = this;
                statistics.Show();
            }
        }

        FrmProductBrandStatistics brandStatistics;
        private void btnBrandStatistic_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (brandStatistics == null || brandStatistics.IsDisposed)
            {
                brandStatistics = new FrmProductBrandStatistics();
                brandStatistics.MdiParent = this;
                brandStatistics.Show();
            }
        }

        FrmCurrent current;
        private void btnCurrentList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (current == null || current.IsDisposed)
            {
                current = new FrmCurrent();
                current.MdiParent = this;
                current.Show();
            }
        }

        FrmCurrentStatistic currentStatistic;
        private void btnCurrentStatistics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (currentStatistic == null || currentStatistic.IsDisposed)
            {
                currentStatistic = new FrmCurrentStatistic();
                currentStatistic.MdiParent = this;
                currentStatistic.Show();
            }
        }

        private void btnCalculator_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        FrmEmployee employee;
        private void btnEmloyeeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (employee == null || employee.IsDisposed)
            {
                employee = new FrmEmployee();
                employee.MdiParent = this;
                employee.Show();
            }
        }

        FrmDepartment employeeDepartment;
        private void btnDepartmentList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (employeeDepartment == null || employeeDepartment.IsDisposed)
            {
                employeeDepartment = new FrmDepartment();
                employeeDepartment.MdiParent = this;
                employeeDepartment.Show();
            }
        }

        FrmCurrency currency;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (currency == null || currency.IsDisposed)
            {
                currency = new FrmCurrency();
                currency.MdiParent = this;
                currency.Show();
            }
        }

        FrmYoutube youtube;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (youtube == null || youtube.IsDisposed)
            {
                youtube = new FrmYoutube();
                youtube.MdiParent = this;
                youtube.Show();
            }
        }

        FrmDefective defective;
        private void btnDefectiveProductList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (defective == null || defective.IsDisposed)
            {
                defective = new FrmDefective();
                defective.MdiParent = this;
                defective.Show();
            }
        }

        FrmDefectiveAccept defectiveAccept;
        private void btnNewDefectiveProductList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (defectiveAccept == null || defectiveAccept.IsDisposed)
            {
                defectiveAccept = new FrmDefectiveAccept();
                defectiveAccept.MdiParent = this;
                defectiveAccept.Show();
            }
        }

        FrmNotes notes;
        private void btnNewNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (notes == null || notes.IsDisposed)
            {
                notes = new FrmNotes();
                notes.MdiParent = this;
                notes.Show();
            }
        }

        FrmSale sale;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sale == null || sale.IsDisposed)
            {
                sale = new FrmSale();
                sale.MdiParent = this;
                sale.Show();
            }
        }

        FrmQRCode qRCode;
        private void btnCreateQRCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (qRCode == null)
            {
                qRCode = new FrmQRCode();
                qRCode.Show();
            }
        }

        FrmOperation operation;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (operation == null || operation.IsDisposed)
            {
                operation = new FrmOperation();
                operation.MdiParent = this;
                operation.Show();
            }
        }

        FrmInvoiceBase ins;
        private void btnNewInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ins == null || ins.IsDisposed)
            {
                ins = new FrmInvoiceBase();
                ins.MdiParent = this;
                ins.Show();
            }
        }

        FrmPhoneBook book;
        private void btnPhoneBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (book == null || book.IsDisposed)
            {
                book = new FrmPhoneBook();
                book.MdiParent = this;
                book.Show();
            }
        }

        FrmContact contact;
        private void btnMailBox_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (contact == null || contact.IsDisposed)
            {
                contact = new FrmContact();
                contact.MdiParent = this;
                contact.Show();
            }
        }

        FrmAboutUs aboutUs;
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (aboutUs == null)
            {
                aboutUs = new FrmAboutUs();
                aboutUs.Show();
            }
        }

        FrmGauge gauge;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gauge == null || gauge.IsDisposed)
            {
                gauge = new FrmGauge();
                gauge.MdiParent = this;
                gauge.Show();
            }
        }

        FrmMap map;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (map == null || map.IsDisposed)
            {
                map = new FrmMap();
                map.MdiParent = this;
                map.Show();
            }
        }

        FrmReport report;
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (report == null)
            {
                report = new FrmReport();
                //report.MdiParent = this;
                report.Show();
            }
        }

        FrmHome home;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (home == null || home.IsDisposed)
            {
                home = new FrmHome();
                home.MdiParent = this;
                home.Show();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (home == null || home.IsDisposed)
            {
                home = new FrmHome();
                home.MdiParent = this;
                home.Show();
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        FrmSendMail mail;
        private void btnSendMail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mail == null)
            {
                mail = new FrmSendMail();
                mail.Show();
            }
        }
    }
}
