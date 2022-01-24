
namespace svStajOtomasyonu
{
    partial class IsYeriTaskGorevPuanla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsYeriTaskGorevPuanla));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.stajdbgorev1 = new svStajOtomasyonu.stajdbgorev();
            this.taskTableAdapter1 = new svStajOtomasyonu.stajdbgorevTableAdapters.TaskTableAdapter();
            this.colGorevId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsYeriId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrenciId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrenIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrenciSoyisim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGorevKonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGorevPuanOnay = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajdbgorev1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Task";
            this.gridControl1.DataSource = this.stajdbgorev1;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(566, 610);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
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
            this.colGorevPuanOnay});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(584, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(944, 610);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.simpleButton3);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(942, 580);
            this.xtraTabPage1.Text = "Öğrenci Görevleri";
            this.xtraTabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage1_Paint);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(403, 491);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(163, 40);
            this.simpleButton3.TabIndex = 16;
            this.simpleButton3.Text = "Pdf İncele";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(26, 280);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(93, 28);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Görev Tanımı: ";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(26, 158);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 28);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Görev Konusu: ";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(403, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(257, 42);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "İsim + Soyisim";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.simpleButton1);
            this.xtraTabPage2.Controls.Add(this.pdfViewer1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(942, 580);
            this.xtraTabPage2.Text = "Pdf İncele";
            this.xtraTabPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage2_Paint);
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(183, 158);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(329, 48);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "İsim + Soyisim";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(183, 280);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(713, 180);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "İsim + Soyisim";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Location = new System.Drawing.Point(18, 18);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(921, 503);
            this.pdfViewer1.TabIndex = 0;
            this.pdfViewer1.Load += new System.EventHandler(this.pdfViewer1_Load);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(405, 527);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(163, 40);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "Puanla";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.labelControl10);
            this.xtraTabPage3.Controls.Add(this.labelControl9);
            this.xtraTabPage3.Controls.Add(this.simpleButton2);
            this.xtraTabPage3.Controls.Add(this.numericUpDown3);
            this.xtraTabPage3.Controls.Add(this.labelControl8);
            this.xtraTabPage3.Controls.Add(this.numericUpDown2);
            this.xtraTabPage3.Controls.Add(this.labelControl7);
            this.xtraTabPage3.Controls.Add(this.numericUpDown1);
            this.xtraTabPage3.Controls.Add(this.labelControl6);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(942, 580);
            this.xtraTabPage3.Text = "Puanla";
            this.xtraTabPage3.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage3_Paint);
            // 
            // labelControl6
            // 
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(16, 87);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(122, 32);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Zaman: ";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(123, 93);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(123, 150);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(16, 144);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(122, 32);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Zaman: ";
            this.labelControl7.Click += new System.EventHandler(this.labelControl7_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(123, 209);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown3.TabIndex = 5;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Location = new System.Drawing.Point(16, 203);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(122, 32);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Zaman: ";
            this.labelControl8.Click += new System.EventHandler(this.labelControl8_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(644, 136);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(182, 48);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Puanla";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Location = new System.Drawing.Point(416, 126);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(71, 66);
            this.labelControl9.TabIndex = 7;
            this.labelControl9.Text = "Ortalama Puan";
            this.labelControl9.Click += new System.EventHandler(this.labelControl9_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.Location = new System.Drawing.Point(25, 373);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(878, 181);
            this.labelControl10.TabIndex = 8;
            this.labelControl10.Text = "Canım buraya bir mesajla bilgilendirme ekleyebilirsin";
            // 
            // stajdbgorev1
            // 
            this.stajdbgorev1.DataSetName = "stajdbgorev";
            this.stajdbgorev1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskTableAdapter1
            // 
            this.taskTableAdapter1.ClearBeforeFill = true;
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
            // colGorevPuanOnay
            // 
            this.colGorevPuanOnay.FieldName = "GorevPuanOnay";
            this.colGorevPuanOnay.MinWidth = 25;
            this.colGorevPuanOnay.Name = "colGorevPuanOnay";
            this.colGorevPuanOnay.Visible = true;
            this.colGorevPuanOnay.VisibleIndex = 6;
            this.colGorevPuanOnay.Width = 94;
            // 
            // IsYeriTaskGorevPuanla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 634);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "IsYeriTaskGorevPuanla";
            this.Text = "IsYeriTaskGorevPuanla";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajdbgorev1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private stajdbgorev stajdbgorev1;
        private DevExpress.XtraGrid.Columns.GridColumn colGorevId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsYeriId;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrenciId;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrenIsim;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrenciSoyisim;
        private DevExpress.XtraGrid.Columns.GridColumn colGorevKonu;
        private DevExpress.XtraGrid.Columns.GridColumn colGorevPuanOnay;
        private stajdbgorevTableAdapters.TaskTableAdapter taskTableAdapter1;
    }
}