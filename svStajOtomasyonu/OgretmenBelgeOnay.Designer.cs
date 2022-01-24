
namespace svStajOtomasyonu
{
    partial class OgretmenBelgeOnay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretmenBelgeOnay));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.stajdbogr1 = new svStajOtomasyonu.stajdbogr();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOgrenciId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgreciIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrenciSoyisim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pdfViewer2 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.pdfViewer3 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.pdfViewer4 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.stajdbisyr1 = new svStajOtomasyonu.stajdbisyr();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsyeriId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsyeriNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsyeriIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ogrenciTableAdapter1 = new svStajOtomasyonu.stajdbogrTableAdapters.OgrenciTableAdapter();
            this.ısYeriTableAdapter1 = new svStajOtomasyonu.stajdbisyrTableAdapters.IsYeriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajdbogr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            this.xtraTabPage5.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajdbisyr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xtraTabControl1.Location = new System.Drawing.Point(7, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl1.Size = new System.Drawing.Size(1526, 731);
            this.xtraTabControl1.TabIndex = 7;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3,
            this.xtraTabPage1});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gridControl1);
            this.xtraTabPage3.Controls.Add(this.xtraTabControl2);
            this.xtraTabPage3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage3.ImageOptions.SvgImage")));
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1524, 677);
            this.xtraTabPage3.Text = "Öğrenci Belge Onaylama";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Ogrenci";
            this.gridControl1.DataSource = this.stajdbogr1;
            this.gridControl1.Location = new System.Drawing.Point(4, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(769, 663);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stajdbogr1
            // 
            this.stajdbogr1.DataSetName = "stajdbogr";
            this.stajdbogr1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOgrenciId,
            this.colOgreciIsim,
            this.colOgrenciSoyisim});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // colOgrenciId
            // 
            this.colOgrenciId.FieldName = "OgrenciId";
            this.colOgrenciId.MinWidth = 25;
            this.colOgrenciId.Name = "colOgrenciId";
            this.colOgrenciId.Visible = true;
            this.colOgrenciId.VisibleIndex = 0;
            this.colOgrenciId.Width = 94;
            // 
            // colOgreciIsim
            // 
            this.colOgreciIsim.FieldName = "OgreciIsim";
            this.colOgreciIsim.MinWidth = 25;
            this.colOgreciIsim.Name = "colOgreciIsim";
            this.colOgreciIsim.Visible = true;
            this.colOgreciIsim.VisibleIndex = 1;
            this.colOgreciIsim.Width = 94;
            // 
            // colOgrenciSoyisim
            // 
            this.colOgrenciSoyisim.FieldName = "OgrenciSoyisim";
            this.colOgrenciSoyisim.MinWidth = 25;
            this.colOgrenciSoyisim.Name = "colOgrenciSoyisim";
            this.colOgrenciSoyisim.Visible = true;
            this.colOgrenciSoyisim.VisibleIndex = 2;
            this.colOgrenciSoyisim.Width = 94;
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Location = new System.Drawing.Point(779, 3);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl2.Size = new System.Drawing.Size(741, 664);
            this.xtraTabControl2.TabIndex = 1;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage4,
            this.xtraTabPage5});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.simpleButton2);
            this.xtraTabPage2.Controls.Add(this.pdfViewer1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(739, 634);
            this.xtraTabPage2.Text = "Staj Başvuru Formu";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(323, 591);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(135, 36);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Onayla";
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Location = new System.Drawing.Point(3, 0);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(742, 585);
            this.pdfViewer1.TabIndex = 0;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.simpleButton1);
            this.xtraTabPage4.Controls.Add(this.pdfViewer2);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(739, 634);
            this.xtraTabPage4.Text = "Staj Kabul Formu";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(318, 595);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(135, 36);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Onayla";
            // 
            // pdfViewer2
            // 
            this.pdfViewer2.Location = new System.Drawing.Point(-2, 4);
            this.pdfViewer2.Name = "pdfViewer2";
            this.pdfViewer2.Size = new System.Drawing.Size(742, 585);
            this.pdfViewer2.TabIndex = 4;
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.simpleButton3);
            this.xtraTabPage5.Controls.Add(this.pdfViewer3);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(739, 634);
            this.xtraTabPage5.Text = "Staj Taahütname";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(318, 595);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(135, 36);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "Onayla";
            // 
            // pdfViewer3
            // 
            this.pdfViewer3.Location = new System.Drawing.Point(-2, 4);
            this.pdfViewer3.Name = "pdfViewer3";
            this.pdfViewer3.Size = new System.Drawing.Size(742, 585);
            this.pdfViewer3.TabIndex = 4;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.simpleButton4);
            this.xtraTabPage1.Controls.Add(this.pdfViewer4);
            this.xtraTabPage1.Controls.Add(this.gridControl2);
            this.xtraTabPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage1.ImageOptions.SvgImage")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1524, 677);
            this.xtraTabPage1.Text = "İş Yeri Belge Onaylama";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            this.simpleButton4.Location = new System.Drawing.Point(1098, 640);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(135, 36);
            this.simpleButton4.TabIndex = 5;
            this.simpleButton4.Text = "Onayla";
            // 
            // pdfViewer4
            // 
            this.pdfViewer4.Location = new System.Drawing.Point(778, 49);
            this.pdfViewer4.Name = "pdfViewer4";
            this.pdfViewer4.Size = new System.Drawing.Size(742, 585);
            this.pdfViewer4.TabIndex = 4;
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "IsYeri";
            this.gridControl2.DataSource = this.stajdbisyr1;
            this.gridControl2.Location = new System.Drawing.Point(4, 7);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(769, 660);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // stajdbisyr1
            // 
            this.stajdbisyr1.DataSetName = "stajdbisyr";
            this.stajdbisyr1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsyeriId,
            this.colIsyeriNo,
            this.colIsyeriIsim});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView2_FocusedRowObjectChanged);
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
            // ogrenciTableAdapter1
            // 
            this.ogrenciTableAdapter1.ClearBeforeFill = true;
            // 
            // ısYeriTableAdapter1
            // 
            this.ısYeriTableAdapter1.ClearBeforeFill = true;
            // 
            // OgretmenBelgeOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 734);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "OgretmenBelgeOnay";
            this.Text = "OgretmenBelgeOnay";
            this.Load += new System.EventHandler(this.OgretmenBelgeOnay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajdbogr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage5.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajdbisyr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private stajdbogr stajdbogr1;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrenciId;
        private DevExpress.XtraGrid.Columns.GridColumn colOgreciIsim;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrenciSoyisim;
        private stajdbogrTableAdapters.OgrenciTableAdapter ogrenciTableAdapter1;
        private stajdbisyr stajdbisyr1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsyeriId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsyeriNo;
        private DevExpress.XtraGrid.Columns.GridColumn colIsyeriIsim;
        private stajdbisyrTableAdapters.IsYeriTableAdapter ısYeriTableAdapter1;
    }
}