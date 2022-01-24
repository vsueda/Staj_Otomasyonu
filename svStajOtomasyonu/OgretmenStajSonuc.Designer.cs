
namespace svStajOtomasyonu
{
    partial class OgretmenStajSonuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretmenStajSonuc));
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.stajdbDataSetgorevogr1 = new svStajOtomasyonu.stajdbDataSetgorevogr();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGorevId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsYeriId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrenciId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrenIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrenciSoyisim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGorevKonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGorevPuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taskTableAdapter1 = new svStajOtomasyonu.stajdbDataSetgorevogrTableAdapters.TaskTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).BeginInit();
            this.xtraTabControl3.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajdbDataSetgorevogr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl3
            // 
            this.xtraTabControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xtraTabControl3.Location = new System.Drawing.Point(562, 12);
            this.xtraTabControl3.Name = "xtraTabControl3";
            this.xtraTabControl3.SelectedTabPage = this.xtraTabPage4;
            this.xtraTabControl3.Size = new System.Drawing.Size(959, 710);
            this.xtraTabControl3.TabIndex = 5;
            this.xtraTabControl3.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage4,
            this.xtraTabPage5});
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.labelControl5);
            this.xtraTabPage4.Controls.Add(this.labelControl6);
            this.xtraTabPage4.Controls.Add(this.simpleButton4);
            this.xtraTabPage4.Controls.Add(this.labelControl7);
            this.xtraTabPage4.Controls.Add(this.labelControl8);
            this.xtraTabPage4.Controls.Add(this.labelControl9);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(957, 680);
            this.xtraTabPage4.Text = "Öğrenci Görevleri";
            // 
            // labelControl5
            // 
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(183, 280);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(713, 180);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Görev içerik bilgisi";
            // 
            // labelControl6
            // 
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(183, 158);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(329, 48);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Görev konu bilgisi";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            this.simpleButton4.Location = new System.Drawing.Point(403, 491);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(163, 40);
            this.simpleButton4.TabIndex = 16;
            this.simpleButton4.Text = "Pdf İncele";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(26, 280);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(93, 28);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Görev Tanımı: ";
            // 
            // labelControl8
            // 
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Location = new System.Drawing.Point(26, 158);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(93, 28);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Görev Konusu: ";
            // 
            // labelControl9
            // 
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Location = new System.Drawing.Point(403, 44);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(257, 42);
            this.labelControl9.TabIndex = 13;
            this.labelControl9.Text = "İsim + Soyisim";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.pdfViewer1);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(957, 680);
            this.xtraTabPage5.Text = "Pdf İncele";
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Location = new System.Drawing.Point(18, 18);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(921, 609);
            this.pdfViewer1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridControl1.DataMember = "Task";
            this.gridControl1.DataSource = this.stajdbDataSetgorevogr1;
            this.gridControl1.Location = new System.Drawing.Point(-2, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(558, 709);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stajdbDataSetgorevogr1
            // 
            this.stajdbDataSetgorevogr1.DataSetName = "stajdbDataSetgorevogr";
            this.stajdbDataSetgorevogr1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGorevId,
            this.colIsYeriId,
            this.colOgrenciId,
            this.colOgrenIsim,
            this.colOgrenciSoyisim,
            this.colGorevKonu,
            this.colGorevPuan});
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
            // colIsYeriId
            // 
            this.colIsYeriId.FieldName = "IsYeriId";
            this.colIsYeriId.MinWidth = 25;
            this.colIsYeriId.Name = "colIsYeriId";
            this.colIsYeriId.Visible = true;
            this.colIsYeriId.VisibleIndex = 1;
            this.colIsYeriId.Width = 94;
            // 
            // colOgrenciId
            // 
            this.colOgrenciId.FieldName = "OgrenciId";
            this.colOgrenciId.MinWidth = 25;
            this.colOgrenciId.Name = "colOgrenciId";
            this.colOgrenciId.Visible = true;
            this.colOgrenciId.VisibleIndex = 2;
            this.colOgrenciId.Width = 94;
            // 
            // colOgrenIsim
            // 
            this.colOgrenIsim.FieldName = "OgrenIsim";
            this.colOgrenIsim.MinWidth = 25;
            this.colOgrenIsim.Name = "colOgrenIsim";
            this.colOgrenIsim.Visible = true;
            this.colOgrenIsim.VisibleIndex = 3;
            this.colOgrenIsim.Width = 94;
            // 
            // colOgrenciSoyisim
            // 
            this.colOgrenciSoyisim.FieldName = "OgrenciSoyisim";
            this.colOgrenciSoyisim.MinWidth = 25;
            this.colOgrenciSoyisim.Name = "colOgrenciSoyisim";
            this.colOgrenciSoyisim.Visible = true;
            this.colOgrenciSoyisim.VisibleIndex = 4;
            this.colOgrenciSoyisim.Width = 94;
            // 
            // colGorevKonu
            // 
            this.colGorevKonu.FieldName = "GorevKonu";
            this.colGorevKonu.MinWidth = 25;
            this.colGorevKonu.Name = "colGorevKonu";
            this.colGorevKonu.Visible = true;
            this.colGorevKonu.VisibleIndex = 5;
            this.colGorevKonu.Width = 94;
            // 
            // colGorevPuan
            // 
            this.colGorevPuan.FieldName = "GorevPuan";
            this.colGorevPuan.MinWidth = 25;
            this.colGorevPuan.Name = "colGorevPuan";
            this.colGorevPuan.Visible = true;
            this.colGorevPuan.VisibleIndex = 6;
            this.colGorevPuan.Width = 94;
            // 
            // taskTableAdapter1
            // 
            this.taskTableAdapter1.ClearBeforeFill = true;
            // 
            // OgretmenStajSonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 734);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.xtraTabControl3);
            this.Name = "OgretmenStajSonuc";
            this.Text = "OgretmenStajSonuc";
            this.Load += new System.EventHandler(this.OgretmenStajSonuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).EndInit();
            this.xtraTabControl3.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajdbDataSetgorevogr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl xtraTabControl3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private stajdbDataSetgorevogr stajdbDataSetgorevogr1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colGorevId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsYeriId;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrenciId;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrenIsim;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrenciSoyisim;
        private DevExpress.XtraGrid.Columns.GridColumn colGorevKonu;
        private DevExpress.XtraGrid.Columns.GridColumn colGorevPuan;
        private stajdbDataSetgorevogrTableAdapters.TaskTableAdapter taskTableAdapter1;
    }
}