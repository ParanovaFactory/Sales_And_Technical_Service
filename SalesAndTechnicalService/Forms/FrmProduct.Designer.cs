namespace SalesAndTechnicalService.Forms
{
    partial class FrmProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnAddList = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.rhcAddDescription = new System.Windows.Forms.RichTextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddStock = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddSell = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddBuy = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddBrand = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.btnUppList = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.rhcUpDescription = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtUpStock = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtUpSell = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtUpBuy = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtUpBrand = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtUpName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.cmbAddCathegory = new System.Windows.Forms.ComboBox();
            this.cmbUppCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddSell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddBuy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddName.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpSell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpBuy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1575, 817);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.Red;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.AppearancePrint.Row.BackColor = System.Drawing.Color.Yellow;
            this.gridView1.AppearancePrint.Row.BorderColor = System.Drawing.Color.Red;
            this.gridView1.AppearancePrint.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.AppearancePrint.Row.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.Row.Options.UseBorderColor = true;
            this.gridView1.AppearancePrint.Row.Options.UseForeColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.xtraTabControl1);
            this.groupControl1.Location = new System.Drawing.Point(1593, 13);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(319, 816);
            this.groupControl1.TabIndex = 1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 23);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(315, 791);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.cmbAddCathegory);
            this.xtraTabPage1.Controls.Add(this.btnAddList);
            this.xtraTabPage1.Controls.Add(this.btnAddClear);
            this.xtraTabPage1.Controls.Add(this.btnSave);
            this.xtraTabPage1.Controls.Add(this.rhcAddDescription);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.txtAddStock);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.txtAddSell);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.txtAddBuy);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtAddBrand);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtAddName);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(313, 747);
            this.xtraTabPage1.Text = "Add Product";
            // 
            // btnAddList
            // 
            this.btnAddList.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddList.Appearance.Options.UseFont = true;
            this.btnAddList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddList.ImageOptions.Image")));
            this.btnAddList.Location = new System.Drawing.Point(3, 400);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(301, 38);
            this.btnAddList.TabIndex = 10;
            this.btnAddList.Text = "LIST";
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // btnAddClear
            // 
            this.btnAddClear.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddClear.Appearance.Options.UseFont = true;
            this.btnAddClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddClear.ImageOptions.Image")));
            this.btnAddClear.Location = new System.Drawing.Point(3, 356);
            this.btnAddClear.Name = "btnAddClear";
            this.btnAddClear.Size = new System.Drawing.Size(301, 38);
            this.btnAddClear.TabIndex = 9;
            this.btnAddClear.Text = "CLEAR";
            this.btnAddClear.Click += new System.EventHandler(this.btnAddClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(3, 312);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(301, 38);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rhcAddDescription
            // 
            this.rhcAddDescription.Location = new System.Drawing.Point(3, 210);
            this.rhcAddDescription.Name = "rhcAddDescription";
            this.rhcAddDescription.Size = new System.Drawing.Size(301, 96);
            this.rhcAddDescription.TabIndex = 7;
            this.rhcAddDescription.Text = "";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(3, 186);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(70, 18);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Description";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(3, 162);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(67, 18);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Cathegory";
            // 
            // txtAddStock
            // 
            this.txtAddStock.Location = new System.Drawing.Point(124, 129);
            this.txtAddStock.Name = "txtAddStock";
            this.txtAddStock.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddStock.Properties.Appearance.Options.UseFont = true;
            this.txtAddStock.Size = new System.Drawing.Size(180, 24);
            this.txtAddStock.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(3, 132);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 18);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Stock";
            // 
            // txtAddSell
            // 
            this.txtAddSell.Location = new System.Drawing.Point(124, 99);
            this.txtAddSell.Name = "txtAddSell";
            this.txtAddSell.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddSell.Properties.Appearance.Options.UseFont = true;
            this.txtAddSell.Size = new System.Drawing.Size(180, 24);
            this.txtAddSell.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(3, 102);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 18);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Selling Pirce";
            // 
            // txtAddBuy
            // 
            this.txtAddBuy.Location = new System.Drawing.Point(124, 69);
            this.txtAddBuy.Name = "txtAddBuy";
            this.txtAddBuy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddBuy.Properties.Appearance.Options.UseFont = true;
            this.txtAddBuy.Size = new System.Drawing.Size(180, 24);
            this.txtAddBuy.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(3, 72);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 18);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Buying Pirce";
            // 
            // txtAddBrand
            // 
            this.txtAddBrand.Location = new System.Drawing.Point(124, 39);
            this.txtAddBrand.Name = "txtAddBrand";
            this.txtAddBrand.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddBrand.Properties.Appearance.Options.UseFont = true;
            this.txtAddBrand.Size = new System.Drawing.Size(180, 24);
            this.txtAddBrand.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(3, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 18);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Brand";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(124, 9);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddName.Properties.Appearance.Options.UseFont = true;
            this.txtAddName.Size = new System.Drawing.Size(180, 24);
            this.txtAddName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 18);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Product Name";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.cmbUppCategory);
            this.xtraTabPage2.Controls.Add(this.txtId);
            this.xtraTabPage2.Controls.Add(this.labelControl15);
            this.xtraTabPage2.Controls.Add(this.btnUppList);
            this.xtraTabPage2.Controls.Add(this.btnUpdClear);
            this.xtraTabPage2.Controls.Add(this.btnDelete);
            this.xtraTabPage2.Controls.Add(this.btnUpdate);
            this.xtraTabPage2.Controls.Add(this.rhcUpDescription);
            this.xtraTabPage2.Controls.Add(this.labelControl8);
            this.xtraTabPage2.Controls.Add(this.labelControl9);
            this.xtraTabPage2.Controls.Add(this.txtUpStock);
            this.xtraTabPage2.Controls.Add(this.labelControl10);
            this.xtraTabPage2.Controls.Add(this.txtUpSell);
            this.xtraTabPage2.Controls.Add(this.labelControl11);
            this.xtraTabPage2.Controls.Add(this.txtUpBuy);
            this.xtraTabPage2.Controls.Add(this.labelControl12);
            this.xtraTabPage2.Controls.Add(this.txtUpBrand);
            this.xtraTabPage2.Controls.Add(this.labelControl13);
            this.xtraTabPage2.Controls.Add(this.txtUpName);
            this.xtraTabPage2.Controls.Add(this.labelControl14);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(313, 747);
            this.xtraTabPage2.Text = "Edit Product";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(123, 9);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Size = new System.Drawing.Size(180, 24);
            this.txtId.TabIndex = 0;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(2, 12);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(68, 18);
            this.labelControl15.TabIndex = 30;
            this.labelControl15.Text = "Product Id";
            // 
            // btnUppList
            // 
            this.btnUppList.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUppList.Appearance.Options.UseFont = true;
            this.btnUppList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUppList.ImageOptions.Image")));
            this.btnUppList.Location = new System.Drawing.Point(2, 474);
            this.btnUppList.Name = "btnUppList";
            this.btnUppList.Size = new System.Drawing.Size(301, 38);
            this.btnUppList.TabIndex = 11;
            this.btnUppList.Text = "LIST";
            this.btnUppList.Click += new System.EventHandler(this.btnUppList_Click);
            // 
            // btnUpdClear
            // 
            this.btnUpdClear.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdClear.Appearance.Options.UseFont = true;
            this.btnUpdClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdClear.ImageOptions.Image")));
            this.btnUpdClear.Location = new System.Drawing.Point(2, 430);
            this.btnUpdClear.Name = "btnUpdClear";
            this.btnUpdClear.Size = new System.Drawing.Size(301, 38);
            this.btnUpdClear.TabIndex = 10;
            this.btnUpdClear.Text = "CLEAR";
            this.btnUpdClear.Click += new System.EventHandler(this.btnUpdClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(2, 386);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(301, 38);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(2, 342);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(301, 38);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rhcUpDescription
            // 
            this.rhcUpDescription.Location = new System.Drawing.Point(2, 240);
            this.rhcUpDescription.Name = "rhcUpDescription";
            this.rhcUpDescription.Size = new System.Drawing.Size(301, 96);
            this.rhcUpDescription.TabIndex = 7;
            this.rhcUpDescription.Text = "";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(2, 216);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(70, 18);
            this.labelControl8.TabIndex = 28;
            this.labelControl8.Text = "Description";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(2, 192);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(67, 18);
            this.labelControl9.TabIndex = 27;
            this.labelControl9.Text = "Cathegory";
            // 
            // txtUpStock
            // 
            this.txtUpStock.Location = new System.Drawing.Point(123, 159);
            this.txtUpStock.Name = "txtUpStock";
            this.txtUpStock.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpStock.Properties.Appearance.Options.UseFont = true;
            this.txtUpStock.Size = new System.Drawing.Size(180, 24);
            this.txtUpStock.TabIndex = 5;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(2, 162);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(36, 18);
            this.labelControl10.TabIndex = 25;
            this.labelControl10.Text = "Stock";
            // 
            // txtUpSell
            // 
            this.txtUpSell.Location = new System.Drawing.Point(123, 129);
            this.txtUpSell.Name = "txtUpSell";
            this.txtUpSell.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpSell.Properties.Appearance.Options.UseFont = true;
            this.txtUpSell.Size = new System.Drawing.Size(180, 24);
            this.txtUpSell.TabIndex = 4;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(2, 132);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(73, 18);
            this.labelControl11.TabIndex = 23;
            this.labelControl11.Text = "Selling Pirce";
            // 
            // txtUpBuy
            // 
            this.txtUpBuy.Location = new System.Drawing.Point(123, 99);
            this.txtUpBuy.Name = "txtUpBuy";
            this.txtUpBuy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpBuy.Properties.Appearance.Options.UseFont = true;
            this.txtUpBuy.Size = new System.Drawing.Size(180, 24);
            this.txtUpBuy.TabIndex = 3;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(2, 102);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(78, 18);
            this.labelControl12.TabIndex = 21;
            this.labelControl12.Text = "Buying Pirce";
            // 
            // txtUpBrand
            // 
            this.txtUpBrand.Location = new System.Drawing.Point(123, 69);
            this.txtUpBrand.Name = "txtUpBrand";
            this.txtUpBrand.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpBrand.Properties.Appearance.Options.UseFont = true;
            this.txtUpBrand.Size = new System.Drawing.Size(180, 24);
            this.txtUpBrand.TabIndex = 2;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(2, 72);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(38, 18);
            this.labelControl13.TabIndex = 19;
            this.labelControl13.Text = "Brand";
            // 
            // txtUpName
            // 
            this.txtUpName.Location = new System.Drawing.Point(123, 39);
            this.txtUpName.Name = "txtUpName";
            this.txtUpName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpName.Properties.Appearance.Options.UseFont = true;
            this.txtUpName.Size = new System.Drawing.Size(180, 24);
            this.txtUpName.TabIndex = 1;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(2, 42);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(93, 18);
            this.labelControl14.TabIndex = 17;
            this.labelControl14.Text = "Product Name";
            // 
            // cmbAddCathegory
            // 
            this.cmbAddCathegory.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAddCathegory.FormattingEnabled = true;
            this.cmbAddCathegory.ItemHeight = 18;
            this.cmbAddCathegory.Location = new System.Drawing.Point(124, 159);
            this.cmbAddCathegory.Name = "cmbAddCathegory";
            this.cmbAddCathegory.Size = new System.Drawing.Size(180, 26);
            this.cmbAddCathegory.TabIndex = 14;
            // 
            // cmbUppCategory
            // 
            this.cmbUppCategory.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUppCategory.FormattingEnabled = true;
            this.cmbUppCategory.Location = new System.Drawing.Point(123, 189);
            this.cmbUppCategory.Name = "cmbUppCategory";
            this.cmbUppCategory.Size = new System.Drawing.Size(180, 26);
            this.cmbUppCategory.TabIndex = 6;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 841);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmProduct";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.FrmProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddSell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddBuy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddName.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpSell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpBuy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.TextEdit txtAddName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.RichTextBox rhcAddDescription;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtAddStock;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtAddSell;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtAddBuy;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAddBrand;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnAddClear;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnUpdClear;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.RichTextBox rhcUpDescription;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtUpStock;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtUpSell;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtUpBuy;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtUpBrand;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtUpName;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.SimpleButton btnAddList;
        private DevExpress.XtraEditors.SimpleButton btnUppList;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private System.Windows.Forms.ComboBox cmbAddCathegory;
        private System.Windows.Forms.ComboBox cmbUppCategory;
    }
}