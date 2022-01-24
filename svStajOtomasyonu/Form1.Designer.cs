
namespace svStajOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.OgretmenGirisMenu = new DevExpress.XtraBars.BarButtonItem();
            this.ogrenciGirisMenu = new DevExpress.XtraBars.BarButtonItem();
            this.isYeriGirisMenu = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.wcfInstantFeedbackSource1 = new DevExpress.Data.WcfLinq.WcfInstantFeedbackSource();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(37);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.OgretmenGirisMenu,
            this.ogrenciGirisMenu,
            this.isYeriGirisMenu});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 412;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl1.Size = new System.Drawing.Size(1740, 183);
            // 
            // OgretmenGirisMenu
            // 
            this.OgretmenGirisMenu.Caption = "Öğretmen";
            this.OgretmenGirisMenu.Id = 1;
            this.OgretmenGirisMenu.ImageOptions.Image = global::svStajOtomasyonu.Properties.Resources.teacher;
            this.OgretmenGirisMenu.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10F);
            this.OgretmenGirisMenu.ItemAppearance.Disabled.Options.UseFont = true;
            this.OgretmenGirisMenu.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10F);
            this.OgretmenGirisMenu.ItemAppearance.Hovered.Options.UseFont = true;
            this.OgretmenGirisMenu.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 10F);
            this.OgretmenGirisMenu.ItemAppearance.Pressed.Options.UseFont = true;
            this.OgretmenGirisMenu.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.OgretmenGirisMenu.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.OgretmenGirisMenu.Name = "OgretmenGirisMenu";
            this.OgretmenGirisMenu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.OgretmenGirisMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OgretmenGirisMenu_ItemClick);
            // 
            // ogrenciGirisMenu
            // 
            this.ogrenciGirisMenu.Caption = "Öğrenci";
            this.ogrenciGirisMenu.Id = 2;
            this.ogrenciGirisMenu.ImageOptions.Image = global::svStajOtomasyonu.Properties.Resources.students;
            this.ogrenciGirisMenu.Name = "ogrenciGirisMenu";
            this.ogrenciGirisMenu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ogrenciGirisMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ogrenciGirisMenu_ItemClick);
            // 
            // isYeriGirisMenu
            // 
            this.isYeriGirisMenu.Caption = "İş Yeri";
            this.isYeriGirisMenu.Id = 3;
            this.isYeriGirisMenu.ImageOptions.Image = global::svStajOtomasyonu.Properties.Resources.factory;
            this.isYeriGirisMenu.Name = "isYeriGirisMenu";
            this.isYeriGirisMenu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.isYeriGirisMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.isYeriGirisMenu_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Giriş Ekranı";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.OgretmenGirisMenu);
            this.ribbonPageGroup1.ItemLinks.Add(this.ogrenciGirisMenu);
            this.ribbonPageGroup1.ItemLinks.Add(this.isYeriGirisMenu);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1740, 1046);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staj Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem OgretmenGirisMenu;
        private DevExpress.XtraBars.BarButtonItem ogrenciGirisMenu;
        private DevExpress.XtraBars.BarButtonItem isYeriGirisMenu;
        private DevExpress.Data.WcfLinq.WcfInstantFeedbackSource wcfInstantFeedbackSource1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

