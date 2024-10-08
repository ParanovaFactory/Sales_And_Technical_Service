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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        Db_TechnicalServiceEntities entities = new Db_TechnicalServiceEntities();

        private void FrmHome_Load(object sender, EventArgs e)
        {
            var value1 = entities.TblProducts.Where(x => x.ProductStatus == true).Select(y => new
            {
                y.ProductId,
                y.ProductName,
                y.ProductStock
            }).ToList();

            gridControl1.DataSource = value1;

            var value2 = entities.TblCurrents.Select(x => new
            {
                x.CurrentName,
                x.CurrentSurname,
                x.CurrentPhone
            }).ToList();
            gridControl2.DataSource = value2;

            var value3 = entities.listcatpro().ToList();
            gridControl3.DataSource = value3;

            var value4 = entities.TblNotes.ToList();
            gridControl4.DataSource = value4;

            List<string> personList = new List<string>();
            List<string> titleList = new List<string>();

            var value5 = entities.TBl_Contact.OrderByDescending(x=> x.ContactId).Take(13).ToList();
            foreach (var item in value5)
            {
                personList.Add(item.ContactNameSurname);
                titleList.Add(item.ContactTitle);
            }
            labelControl1.Text = $"{personList[0]} - {titleList[0]}";
            labelControl2.Text = $"{personList[1]} - {titleList[1]}";
            labelControl3.Text = $"{personList[2]} - {titleList[2]}";
            labelControl4.Text = $"{personList[3]} - {titleList[3]}";
            labelControl5.Text = $"{personList[4]} - {titleList[4]}";
            labelControl6.Text = $"{personList[5]} - {titleList[5]}";
            labelControl7.Text = $"{personList[6]} - {titleList[6]}";
            labelControl8.Text = $"{personList[7]} - {titleList[7]}";
            labelControl9.Text = $"{personList[8]} - {titleList[8]}";
            labelControl10.Text = $"{personList[9]} - {titleList[9]}";
            labelControl11.Text = $"{personList[10]} - {titleList[10]}";
            labelControl12.Text = $"{personList[11]} - {titleList[11]}";
            labelControl13.Text = $"{personList[12]} - {titleList[12]}";
        }
    }
}
