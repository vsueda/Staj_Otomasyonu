
namespace svStajOtomasyonu
{
    partial class IsYeriTaskGorevVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsYeriTaskGorevVer));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOgrenciId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrenciTc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgreciIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrenciSoyisim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrenciIsYeriId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(592, 51);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(936, 533);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.comboBox1);
            this.xtraTabPage1.Controls.Add(this.simpleButton3);
            this.xtraTabPage1.Controls.Add(this.textBox1);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.textEdit1);
            this.xtraTabPage1.Controls.Add(this.simpleButton2);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.simpleButton1);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(934, 503);
            this.xtraTabPage1.Text = "Görev Ekle";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(428, 448);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(163, 40);
            this.simpleButton3.TabIndex = 12;
            this.simpleButton3.Text = "Gönder";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 248);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(781, 181);
            this.textBox1.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(16, 248);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(93, 28);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Görev Tanımı: ";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(687, 140);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(125, 22);
            this.textEdit1.TabIndex = 9;
            this.textEdit1.Visible = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(830, 131);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(82, 34);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "Ekle";
            this.simpleButton2.Visible = false;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(588, 135);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 28);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Görev Konusu: ";
            this.labelControl3.Visible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(304, 135);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(163, 40);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Görev Konusu Ekle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(16, 126);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 28);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Görev Konusu: ";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(16, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(257, 42);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "İsim + Soyisim";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Ogrenci";
            this.gridControl1.Location = new System.Drawing.Point(12, 51);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(559, 533);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOgrenciId,
            this.colOgrenciTc,
            this.colOgreciIsim,
            this.colOgrenciSoyisim,
            this.colOgrenciIsYeriId});
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
            // colOgrenciTc
            // 
            this.colOgrenciTc.FieldName = "OgrenciTc";
            this.colOgrenciTc.MinWidth = 25;
            this.colOgrenciTc.Name = "colOgrenciTc";
            this.colOgrenciTc.Visible = true;
            this.colOgrenciTc.VisibleIndex = 1;
            this.colOgrenciTc.Width = 94;
            // 
            // colOgreciIsim
            // 
            this.colOgreciIsim.FieldName = "OgreciIsim";
            this.colOgreciIsim.MinWidth = 25;
            this.colOgreciIsim.Name = "colOgreciIsim";
            this.colOgreciIsim.Visible = true;
            this.colOgreciIsim.VisibleIndex = 2;
            this.colOgreciIsim.Width = 94;
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
            // colOgrenciIsYeriId
            // 
            this.colOgrenciIsYeriId.FieldName = "OgrenciIsYeriId";
            this.colOgrenciIsYeriId.MinWidth = 25;
            this.colOgrenciIsYeriId.Name = "colOgrenciIsYeriId";
            this.colOgrenciIsYeriId.Visible = true;
            this.colOgrenciIsYeriId.VisibleIndex = 4;
            this.colOgrenciIsYeriId.Width = 94;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // IsYeriTaskGorevVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 634);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "IsYeriTaskGorevVer";
            this.Text = "IsYeriTaskGorevVer";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrenciId;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrenciTc;
        private DevExpress.XtraGrid.Columns.GridColumn colOgreciIsim;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrenciSoyisim;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrenciIsYeriId;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}