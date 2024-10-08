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
    public partial class FrmCurrent : Form
    {
        Db_TechnicalServiceEntities entity = new Db_TechnicalServiceEntities();

        public FrmCurrent()
        {
            InitializeComponent();
        }

        void listCurrent()
        {
            var values = from p in entity.TblCurrents
                         select new
                         {
                             p.CurrentId,
                             p.CurrentName,
                             p.CurrentSurname,
                             p.CurrentPhone,
                             p.CurrentMail,
                             p.CurrentCountry,
                             p.CurrentCity,
                             p.CurrentProvince,
                             p.CurrentBank,
                             p.CurrentTaxOffice,
                             p.CurrentTaxNumber,
                             p.CurrentStatus,
                             p.CurrentAddress
                         };
            gridControl1.DataSource = values.ToList();
        }

        void listCountry()
        {
            cmbCountry.DataSource = entity.Tbl_Countries.ToList();
            cmbCountry.ValueMember = "Id";
            cmbCountry.DisplayMember = "Name";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtId.Text = gridView1.GetFocusedRowCellValue("CurrentId").ToString();
                txtName.Text = gridView1.GetFocusedRowCellValue("CurrentName").ToString();
                txtSurname.Text = gridView1.GetFocusedRowCellValue("CurrentSurname").ToString();
                txtPhone.Text = gridView1.GetFocusedRowCellValue("CurrentPhone").ToString();
                txtMail.Text = gridView1.GetFocusedRowCellValue("CurrentMail").ToString();
                cmbCountry.Text = gridView1.GetFocusedRowCellValue("CurrentCountry").ToString();
                cmbCity.Text = gridView1.GetFocusedRowCellValue("CurrentCity").ToString();
                cmbProvince.Text = gridView1.GetFocusedRowCellValue("CurrentProvince").ToString();
                txtIBAN.Text = gridView1.GetFocusedRowCellValue("CurrentBank").ToString();
                txtTaxOffice.Text = gridView1.GetFocusedRowCellValue("CurrentTaxOffice").ToString();
                txtTaxNo.Text = gridView1.GetFocusedRowCellValue("CurrentTaxNumber").ToString();
                txtStatus.Text = gridView1.GetFocusedRowCellValue("CurrentStatus").ToString();
                rhcAddress.Text = gridView1.GetFocusedRowCellValue("CurrentAddress").ToString();
            }
            catch (Exception)
            {
            }
            
        }

        private void FrmCurrent_Load(object sender, EventArgs e)
        {
            listCurrent();
            listCountry();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                TblCurrent p = new TblCurrent();
                p.CurrentName = txtName.Text;
                p.CurrentSurname = txtSurname.Text;
                p.CurrentPhone = txtPhone.Text;
                p.CurrentMail = txtMail.Text;
                p.CurrentCountry = cmbCountry.SelectedItem.ToString();
                p.CurrentCity = cmbCity.SelectedItem.ToString();
                p.CurrentProvince = cmbProvince.SelectedItem.ToString();
                p.CurrentBank = txtIBAN.Text;
                p.CurrentTaxOffice = txtTaxOffice.Text;
                p.CurrentTaxNumber = txtTaxNo.Text;
                p.CurrentStatus = txtStatus.Text;
                p.CurrentAddress = rhcAddress.Text;
                entity.TblCurrents.Add(p);
                entity.SaveChanges();
                MessageBox.Show("Current Saved in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var id = int.Parse(txtId.Text);
                var p = entity.TblCurrents.Find(id);
                p.CurrentName = txtName.Text;
                p.CurrentSurname = txtSurname.Text;
                p.CurrentPhone = txtPhone.Text;
                p.CurrentMail = txtMail.Text;
                p.CurrentCountry = cmbCountry.SelectedItem.ToString();
                p.CurrentCity = cmbCity.SelectedItem.ToString();
                p.CurrentProvince = cmbProvince.SelectedItem.ToString();
                p.CurrentBank = txtIBAN.Text;
                p.CurrentTaxOffice = txtTaxOffice.Text;
                p.CurrentTaxNumber = txtTaxNo.Text;
                p.CurrentStatus = txtStatus.Text;
                p.CurrentAddress = rhcAddress.Text;
                entity.SaveChanges();
                MessageBox.Show("Current Updated in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var id = int.Parse(txtId.Text);
                var values = entity.TblCurrents.Find(id);
                entity.TblCurrents.Remove(values);
                entity.SaveChanges();
                MessageBox.Show("Current Deleted in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Chech the Entered Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtSurname.Clear();
            txtPhone.Clear();
            txtMail.Clear();
            cmbCountry.Text = "";
            cmbCity.Text = "";
            cmbProvince.Text = "";
            txtIBAN.Clear();
            txtTaxOffice.Clear();
            txtTaxNo.Clear();
            txtStatus.Clear();
            rhcAddress.Clear();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            listCurrent();
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = cmbCountry.SelectedIndex + 1;
            cmbCity.DataSource = entity.Tbl_Cities.Where(x => x.CountryId == id).ToList();
            cmbCity.ValueMember = "Id";
            cmbCity.DisplayMember = "Name";
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = cmbCity.SelectedIndex + 1;
            cmbProvince.DataSource = entity.Tbl_Provinces.Where(x => x.City_Id == id).ToList();
            cmbProvince.ValueMember = "Id";
            cmbProvince.DisplayMember = "Name";
        }
    }
}