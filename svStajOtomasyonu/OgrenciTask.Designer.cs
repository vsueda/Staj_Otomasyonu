
namespace svStajOtomasyonu
{
    partial class OgrenciTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciTask));
            this.stajdbbelge = new svStajOtomasyonu.stajdbbelge();
            this.stajdbbelgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.stajdbDataSetgorevler1 = new svStajOtomasyonu.stajdbDataSetgorevler();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGorevId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrenciId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrenIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrenciSoyisim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGorevKonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGorevYapildi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.taskTableAdapter1 = new svStajOtomasyonu.stajdbDataSetgorevlerTableAdapters.TaskTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.stajdbbelge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajdbbelgeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajdbDataSetgorevler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // stajdbbelge
            // 
            this.stajdbbelge.DataSetName = "stajdbbelge";
            this.stajdbbelge.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stajdbbelgeBindingSource
            // 
            this.stajdbbelgeBindingSource.DataSource = this.stajdbbelge;
            this.stajdbbelgeBindingSource.Position = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridControl1.DataMember = "Task";
            this.gridControl1.DataSource = this.stajdbDataSetgorevler1;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(611, 710);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stajdbDataSetgorevler1
            // 
            this.stajdbDataSetgorevler1.DataSetName = "stajdbDataSetgorevler";
            this.stajdbDataSetgorevler1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGorevId,
            this.colOgrenciId,
            this.colOgrenIsim,
            this.colOgrenciSoyisim,
            this.colGorevKonu,
            this.colGorevYapildi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // colGorevId
            // 
            this.colGorevId.FieldName = "GorevId";
            this.colGorevId.MinWidth = 25;
            this.colGorevId.Name = "colGorevId";
            this.colGorevId.Visible = true;
            this.colGorevId.VisibleIndex = 0;
            this.colGorevId.Width = 94;
            // 
            // colOgrenciId
            // 
            this.colOgrenciId.FieldName = "OgrenciId";
            this.colOgrenciId.MinWidth = 25;
            this.colOgrenciId.Name = "colOgrenciId";
            this.colOgrenciId.Visible = true;
            this.colOgrenciId.VisibleIndex = 1;
            this.colOgrenciId.Width = 94;
            // 
            // colOgrenIsim
            // 
            this.colOgrenIsim.FieldName = "OgrenIsim";
            this.colOgrenIsim.MinWidth = 25;
            this.colOgrenIsim.Name = "colOgrenIsim";
            this.colOgrenIsim.Visible = true;
            this.colOgrenIsim.VisibleIndex = 2;
            this.colOgrenIsim.Width = 94;
            // 
            // colOgrenciSoyisim
            // 
            this.colOgrenciSoyisim.FieldName = "OgrenciSoyisim";
            this.colOgrenciSoyisim.MinWidth = 25;
            this.colOgrenciSoyisim.Name = "colOgrenciSoyisim";
            this.colOgrenciSoyisim.Visible = true;
            this.colOgrenciSoyisim.VisibleIndex = 3;
            this.colOgrenciSoyisim.Width = 94;
            // 
            // colGorevKonu
            // 
            this.colGorevKonu.FieldName = "GorevKonu";
            this.colGorevKonu.MinWidth = 25;
            this.colGorevKonu.Name = "colGorevKonu";
            this.colGorevKonu.Visible = true;
            this.colGorevKonu.VisibleIndex = 4;
            this.colGorevKonu.Width = 94;
            // 
            // colGorevYapildi
            // 
            this.colGorevYapildi.FieldName = "GorevYapildi";
            this.colGorevYapildi.MinWidth = 25;
            this.colGorevYapildi.Name = "colGorevYapildi";
            this.colGorevYapildi.Visible = true;
            this.colGorevYapildi.VisibleIndex = 5;
            this.colGorevYapildi.Width = 94;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xtraTabControl1.Location = new System.Drawing.Point(645, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(883, 710);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.simpleButton3);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(881, 680);
            this.xtraTabPage1.Text = "Görev Görüntüleme";
            // 
            // labelControl5
            // 
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(165, 263);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(713, 349);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "Görev İçeriği";
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(165, 141);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(329, 48);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Görev Konu İçeriği";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(374, 628);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(163, 40);
            this.simpleButton3.TabIndex = 21;
            this.simpleButton3.Text = "Pdf Ekle";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(8, 263);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(93, 28);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Görev Tanımı: ";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(8, 141);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 28);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Görev Konusu: ";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.simpleButton2);
            this.xtraTabPage2.Controls.Add(this.simpleButton1);
            this.xtraTabPage2.Controls.Add(this.pdfViewer1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(881, 680);
            this.xtraTabPage2.Text = "Pdf  Ekle";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(164, 599);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(163, 40);
            this.simpleButton2.TabIndex = 23;
            this.simpleButton2.Text = "Pdf Yükle";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(567, 599);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(163, 40);
            this.simpleButton1.TabIndex = 22;
            this.simpleButton1.Text = "Gönder";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Location = new System.Drawing.Point(3, 26);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(875, 547);
            this.pdfViewer1.TabIndex = 0;
            // 
            // taskTableAdapter1
            // 
            this.taskTableAdapter1.ClearBeforeFill = true;
            // 
            // OgrenciTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 734);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "OgrenciTask";
            this.Text = "OgrenciTask";
            this.Load += new System.EventHandler(this.OgrenciTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stajdbbelge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajdbbelgeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajdbDataSetgorevler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private stajdbbelge stajdbbelge;
        private System.Windows.Forms.BindingSource stajdbbelgeBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
        private stajdbDataSetgorevler stajdbDataSetgorevler1;
        private DevExpress.XtraGrid.Columns.GridColumn colGorevId;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrenciId;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrenIsim;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrenciSoyisim;
        private DevExpress.XtraGrid.Columns.GridColumn colGorevKonu;
        private DevExpress.XtraGrid.Columns.GridColumn colGorevYapildi;
        private stajdbDataSetgorevlerTableAdapters.TaskTableAdapter taskTableAdapter1;
    }
}