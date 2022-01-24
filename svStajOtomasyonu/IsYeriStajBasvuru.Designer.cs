
namespace svStajOtomasyonu
{
    partial class IsYeriStajBasvuru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsYeriStajBasvuru));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.pdfViewer2 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.stajdbIsYeriBelge1 = new svStajOtomasyonu.stajdbIsYeriBelge();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOgrenciId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgreciIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrenciSoyisim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrenciIsYeriId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.pdfViewer3 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.ogrenciTableAdapter2 = new svStajOtomasyonu.stajdbIsYeriBelgeTableAdapters.OgrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajdbIsYeriBelge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xtraTabControl1.Location = new System.Drawing.Point(7, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1526, 731);
            this.xtraTabControl1.TabIndex = 6;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.pdfViewer1);
            this.xtraTabPage1.Controls.Add(this.simpleButton1);
            this.xtraTabPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage1.ImageOptions.SvgImage")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1524, 677);
            this.xtraTabPage1.Text = "Belge Yükle";
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Location = new System.Drawing.Point(526, 0);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(995, 678);
            this.pdfViewer1.TabIndex = 15;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(96, 350);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(215, 52);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "İş Yeri Personel Bilgi Formu";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.pdfViewer2);
            this.xtraTabPage2.Controls.Add(this.simpleButton8);
            this.xtraTabPage2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage2.ImageOptions.SvgImage")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1524, 677);
            this.xtraTabPage2.Text = "Belgelerim";
            // 
            // pdfViewer2
            // 
            this.pdfViewer2.Location = new System.Drawing.Point(519, 3);
            this.pdfViewer2.Name = "pdfViewer2";
            this.pdfViewer2.Size = new System.Drawing.Size(1006, 674);
            this.pdfViewer2.TabIndex = 18;
            // 
            // simpleButton8
            // 
            this.simpleButton8.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton8.ImageOptions.SvgImage")));
            this.simpleButton8.Location = new System.Drawing.Point(93, 379);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(220, 52);
            this.simpleButton8.TabIndex = 14;
            this.simpleButton8.Text = "İş Yeri Personel Bilgi Formu";
            this.simpleButton8.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gridControl1);
            this.xtraTabPage3.Controls.Add(this.simpleButton2);
            this.xtraTabPage3.Controls.Add(this.pdfViewer3);
            this.xtraTabPage3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTabPage3.ImageOptions.SvgImage")));
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1524, 677);
            this.xtraTabPage3.Text = "Öğrenci Belge Onaylama";
            this.xtraTabPage3.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage3_Paint);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Ogrenci";
            this.gridControl1.DataSource = this.stajdbIsYeriBelge1;
            this.gridControl1.Location = new System.Drawing.Point(14, 15);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(712, 652);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            // 
            // stajdbIsYeriBelge1
            // 
            this.stajdbIsYeriBelge1.DataSetName = "stajdbIsYeriBelge";
            this.stajdbIsYeriBelge1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOgrenciId,
            this.colOgreciIsim,
            this.colOgrenciSoyisim,
            this.colOgrenciIsYeriId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged_1);
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
            // colOgrenciIsYeriId
            // 
            this.colOgrenciIsYeriId.FieldName = "OgrenciIsYeriId";
            this.colOgrenciIsYeriId.MinWidth = 25;
            this.colOgrenciIsYeriId.Name = "colOgrenciIsYeriId";
            this.colOgrenciIsYeriId.Visible = true;
            this.colOgrenciIsYeriId.VisibleIndex = 3;
            this.colOgrenciIsYeriId.Width = 94;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(1303, 503);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(153, 48);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Onayla";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // pdfViewer3
            // 
            this.pdfViewer3.Location = new System.Drawing.Point(732, 15);
            this.pdfViewer3.Name = "pdfViewer3";
            this.pdfViewer3.Size = new System.Drawing.Size(507, 663);
            this.pdfViewer3.TabIndex = 1;
            // 
            // ogrenciTableAdapter2
            // 
            this.ogrenciTableAdapter2.ClearBeforeFill = true;
            // 
            // IsYeriStajBasvuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 734);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "IsYeriStajBasvuru";
            this.Text = "IsYeriStajBasvuru";
            this.Load += new System.EventHandler(this.IsYeriStajBasvuru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajdbIsYeriBelge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer2;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private stajdbIsYeriBelge stajdbIsYeriBelge1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrenciId;
        private DevExpress.XtraGrid.Columns.GridColumn colOgreciIsim;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrenciSoyisim;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrenciIsYeriId;
        private stajdbIsYeriBelgeTableAdapters.OgrenciTableAdapter ogrenciTableAdapter2;
   
    }
}