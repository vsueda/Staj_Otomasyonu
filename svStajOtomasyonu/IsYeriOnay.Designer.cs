
namespace svStajOtomasyonu
{
    partial class IsYeriOnay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsYeriOnay));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.stajdbDataSet81 = new svStajOtomasyonu.stajdbDataSet8();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsyeriId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsyeriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsyeriIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsyeriIl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsyeriAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsyeriMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsyeriTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsyeriOnay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.stajdbDataSet7 = new svStajOtomasyonu.stajdbDataSet7();
            this.stajdbDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ısYeriTableAdapter1 = new svStajOtomasyonu.stajdbDataSet8TableAdapters.IsYeriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajdbDataSet81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stajdbDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajdbDataSet7BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridControl1.DataMember = "IsYeri";
            this.gridControl1.DataSource = this.stajdbDataSet81;
            this.gridControl1.Location = new System.Drawing.Point(18, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(998, 710);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stajdbDataSet81
            // 
            this.stajdbDataSet81.DataSetName = "stajdbDataSet8";
            this.stajdbDataSet81.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsyeriId,
            this.colIsyeriNo,
            this.colIsyeriIsim,
            this.colIsyeriIl,
            this.colIsyeriAdres,
            this.colIsyeriMail,
            this.colIsyeriTel,
            this.colIsyeriOnay});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // colIsyeriId
            // 
            this.colIsyeriId.FieldName = "IsyeriId";
            this.colIsyeriId.MinWidth = 25;
            this.colIsyeriId.Name = "colIsyeriId";
            this.colIsyeriId.Visible = true;
            this.colIsyeriId.VisibleIndex = 0;
            this.colIsyeriId.Width = 94;
            // 
            // colIsyeriNo
            // 
            this.colIsyeriNo.FieldName = "IsyeriNo";
            this.colIsyeriNo.MinWidth = 25;
            this.colIsyeriNo.Name = "colIsyeriNo";
            this.colIsyeriNo.Visible = true;
            this.colIsyeriNo.VisibleIndex = 1;
            this.colIsyeriNo.Width = 94;
            // 
            // colIsyeriIsim
            // 
            this.colIsyeriIsim.FieldName = "IsyeriIsim";
            this.colIsyeriIsim.MinWidth = 25;
            this.colIsyeriIsim.Name = "colIsyeriIsim";
            this.colIsyeriIsim.Visible = true;
            this.colIsyeriIsim.VisibleIndex = 2;
            this.colIsyeriIsim.Width = 94;
            // 
            // colIsyeriIl
            // 
            this.colIsyeriIl.FieldName = "IsyeriIl";
            this.colIsyeriIl.MinWidth = 25;
            this.colIsyeriIl.Name = "colIsyeriIl";
            this.colIsyeriIl.Visible = true;
            this.colIsyeriIl.VisibleIndex = 3;
            this.colIsyeriIl.Width = 94;
            // 
            // colIsyeriAdres
            // 
            this.colIsyeriAdres.FieldName = "IsyeriAdres";
            this.colIsyeriAdres.MinWidth = 25;
            this.colIsyeriAdres.Name = "colIsyeriAdres";
            this.colIsyeriAdres.Visible = true;
            this.colIsyeriAdres.VisibleIndex = 4;
            this.colIsyeriAdres.Width = 94;
            // 
            // colIsyeriMail
            // 
            this.colIsyeriMail.FieldName = "IsyeriMail";
            this.colIsyeriMail.MinWidth = 25;
            this.colIsyeriMail.Name = "colIsyeriMail";
            this.colIsyeriMail.Visible = true;
            this.colIsyeriMail.VisibleIndex = 5;
            this.colIsyeriMail.Width = 94;
            // 
            // colIsyeriTel
            // 
            this.colIsyeriTel.FieldName = "IsyeriTel";
            this.colIsyeriTel.MinWidth = 25;
            this.colIsyeriTel.Name = "colIsyeriTel";
            this.colIsyeriTel.Visible = true;
            this.colIsyeriTel.VisibleIndex = 6;
            this.colIsyeriTel.Width = 94;
            // 
            // colIsyeriOnay
            // 
            this.colIsyeriOnay.FieldName = "IsyeriOnay";
            this.colIsyeriOnay.MinWidth = 25;
            this.colIsyeriOnay.Name = "colIsyeriOnay";
            this.colIsyeriOnay.Visible = true;
            this.colIsyeriOnay.VisibleIndex = 7;
            this.colIsyeriOnay.Width = 94;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xtraTabControl1.Location = new System.Drawing.Point(1022, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(494, 710);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.labelControl9);
            this.xtraTabPage1.Controls.Add(this.labelControl10);
            this.xtraTabPage1.Controls.Add(this.labelControl11);
            this.xtraTabPage1.Controls.Add(this.labelControl12);
            this.xtraTabPage1.Controls.Add(this.simpleButton3);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.simpleButton1);
            this.xtraTabPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage1.ImageOptions.SvgImage")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(492, 656);
            this.xtraTabPage1.Text = "Öğrenci Onay";
            // 
            // labelControl7
            // 
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(25, 408);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(137, 23);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "İşyeri Tel:";
            // 
            // labelControl8
            // 
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Location = new System.Drawing.Point(25, 379);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(137, 23);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "İşyeri Mail:";
            // 
            // labelControl9
            // 
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Location = new System.Drawing.Point(25, 350);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(137, 23);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "İşyeri Adres:";
            // 
            // labelControl10
            // 
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.Location = new System.Drawing.Point(25, 321);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(137, 23);
            this.labelControl10.TabIndex = 11;
            this.labelControl10.Text = "İşyeri İl:";
            // 
            // labelControl11
            // 
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.Location = new System.Drawing.Point(25, 299);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(137, 16);
            this.labelControl11.TabIndex = 10;
            this.labelControl11.Text = "İşyeri İsim:";
            // 
            // labelControl12
            // 
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.Location = new System.Drawing.Point(25, 270);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(137, 23);
            this.labelControl12.TabIndex = 9;
            this.labelControl12.Text = "Personel TC:";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(290, 526);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(151, 50);
            this.simpleButton3.TabIndex = 8;
            this.simpleButton3.Text = "Reddet";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(202, 408);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(239, 23);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "labelControl6";
            // 
            // labelControl5
            // 
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(202, 379);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(239, 23);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "labelControl5";
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(202, 350);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(239, 23);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "labelControl4";
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(202, 321);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(239, 23);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "labelControl3";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(202, 299);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(239, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "labelControl2";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(202, 270);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(239, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "labelControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(40, 526);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(151, 50);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Onayla";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // stajdbDataSet7
            // 
            this.stajdbDataSet7.DataSetName = "stajdbDataSet7";
            this.stajdbDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stajdbDataSet7BindingSource
            // 
            this.stajdbDataSet7BindingSource.DataSource = this.stajdbDataSet7;
            this.stajdbDataSet7BindingSource.Position = 0;
            this.stajdbDataSet7BindingSource.CurrentChanged += new System.EventHandler(this.stajdbDataSet7BindingSource_CurrentChanged);
            // 
            // ısYeriTableAdapter1
            // 
            this.ısYeriTableAdapter1.ClearBeforeFill = true;
            // 
            // IsYeriOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 734);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "IsYeriOnay";
            this.Text = "IsYeriOnay";
            this.Load += new System.EventHandler(this.IsYeriOnay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajdbDataSet81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stajdbDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajdbDataSet7BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsyeriId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsyeriNo;
        private DevExpress.XtraGrid.Columns.GridColumn colIsyeriIsim;
        private DevExpress.XtraGrid.Columns.GridColumn colIsyeriIl;
        private DevExpress.XtraGrid.Columns.GridColumn colIsyeriAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colIsyeriMail;
        private DevExpress.XtraGrid.Columns.GridColumn colIsyeriTel;
        private DevExpress.XtraGrid.Columns.GridColumn colIsyeriOnay;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource stajdbDataSet7BindingSource;
        private stajdbDataSet7 stajdbDataSet7;
        private stajdbDataSet8 stajdbDataSet81;
        private stajdbDataSet8TableAdapters.IsYeriTableAdapter ısYeriTableAdapter1;
    }
}