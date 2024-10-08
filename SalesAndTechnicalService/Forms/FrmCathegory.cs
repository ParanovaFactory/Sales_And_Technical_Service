using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FrmCathegory : Form
    {
        Db_TechnicalServiceEntities entities = new Db_TechnicalServiceEntities();

        public FrmCathegory()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtCathegoryId.Clear();
            txtCathegoryName.Clear();
        }

        void listCathegory()
        {
            var items = entities.TblCathegories.Select(x => new
            {
                x.CathegoryId,
                x.CathegoryName
            }).ToList();
            gridControl1.DataSource = items;
        }

        private void FrmCathegory_Load(object sender, EventArgs e)
        {
            listCathegory();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                TblCathegory cathegory = new TblCathegory();
                cathegory.CathegoryName = txtCathegoryName.Text;
                entities.TblCathegories.Add(cathegory);
                entities.SaveChanges();
                MessageBox.Show("Cathegory Saved in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                int id = int.Parse(txtCathegoryId.Text);
                var item = entities.TblCathegories.Find(id);
                item.CathegoryName = txtCathegoryName.Text.Trim();
                entities.SaveChanges();
                MessageBox.Show("Cathegory Updated in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                int id = int.Parse(txtCathegoryId.Text);
                var item = entities.TblCathegories.Find(id);
                entities.TblCathegories.Remove(item);
                entities.SaveChanges();
                MessageBox.Show("Cathegory Deleted in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Chech the Entered Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            listCathegory();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtCathegoryId.Text = gridView1.GetFocusedRowCellValue("CathegoryId").ToString();
                txtCathegoryName.Text = gridView1.GetFocusedRowCellValue("CathegoryName").ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}
