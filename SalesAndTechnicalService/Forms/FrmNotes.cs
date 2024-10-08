using DevExpress.Drawing;
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
using System.Xml.Linq;

namespace SalesAndTechnicalService.Forms
{
    public partial class FrmNotes : Form
    {
        Db_TechnicalServiceEntities entities = new Db_TechnicalServiceEntities();
        public FrmNotes()
        {
            InitializeComponent();
        }

        void listUnread()
        {
            var values = entities.TblNotes.Where(x => x.NoteStatus == false).ToList();
            gridControl1.DataSource = values;
        }

        void listRead()
        {
            var values = entities.TblNotes.Where(x => x.NoteStatus == true).ToList();
            gridControl2.DataSource = values;
        }

        private void FrmNotes_Load(object sender, EventArgs e)
        {
            listUnread();
            listRead();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                TblNote note = new TblNote();
                note.NoteTitle = txtTitle.Text;
                note.NoteContext = rchContext.Text;
                note.NoteStatus = false;
                entities.TblNotes.Add(note);
                entities.SaveChanges();
                MessageBox.Show("Note Saved in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var value = entities.TblNotes.Find(id);
                value.NoteTitle = txtTitle.Text;
                value.NoteContext = rchContext.Text;
                if (chlRead.Checked)
                {
                    value.NoteStatus = true;
                }
                entities.SaveChanges();
                MessageBox.Show("Note Updated in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var value = entities.TblNotes.Find(id);
                entities.TblNotes.Remove(value);
                entities.SaveChanges();
                MessageBox.Show("Note Deleted in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Chech the Entered Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtTitle.Clear();
            chlRead.Checked = false;
            rchContext.Clear();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            listUnread();
            listRead();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtId.Text = gridView1.GetFocusedRowCellValue("NoteId").ToString();
                txtTitle.Text = gridView1.GetFocusedRowCellValue("NoteTitle").ToString();
                rchContext.Text = gridView1.GetFocusedRowCellValue("NoteContext").ToString();
                if (
                gridView1.GetFocusedRowCellValue("NoteStatus").ToString() == "True")
                {
                    chlRead.Checked = true;
                }
                else
                {
                    chlRead.Checked = false;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
