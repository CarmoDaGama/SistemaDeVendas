namespace Sistema.Vendas.Desktop.Views.Forms.Main
{
    partial class FormMain
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.buttonEntitdade = new DevExpress.XtraBars.BarButtonItem();
            this.buttonArtigos = new DevExpress.XtraBars.BarButtonItem();
            this.buttonSale = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelContainerForForms = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.DarkBlue;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.buttonEntitdade,
            this.buttonArtigos,
            this.buttonSale});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonHome});
            this.ribbon.Size = new System.Drawing.Size(1032, 174);
            // 
            // buttonEntitdade
            // 
            this.buttonEntitdade.Caption = "Entidades";
            this.buttonEntitdade.Id = 1;
            this.buttonEntitdade.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Female_User_35px;
            this.buttonEntitdade.Name = "buttonEntitdade";
            this.buttonEntitdade.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.buttonEntitdade.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonEntitdade_ItemClick);
            // 
            // buttonArtigos
            // 
            this.buttonArtigos.Caption = "Artigos";
            this.buttonArtigos.Id = 2;
            this.buttonArtigos.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.New_Product_35px;
            this.buttonArtigos.Name = "buttonArtigos";
            this.buttonArtigos.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.buttonArtigos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonArtigos_ItemClick);
            // 
            // buttonSale
            // 
            this.buttonSale.Caption = "Posto De Vendas";
            this.buttonSale.Id = 3;
            this.buttonSale.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Buying_35px;
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.buttonSale.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSale_ItemClick);
            // 
            // ribbonHome
            // 
            this.ribbonHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonHome.Name = "ribbonHome";
            this.ribbonHome.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonEntitdade);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonArtigos);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonSale);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // panelContainerForForms
            // 
            this.panelContainerForForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainerForForms.Location = new System.Drawing.Point(0, 174);
            this.panelContainerForForms.Name = "panelContainerForForms";
            this.panelContainerForForms.Size = new System.Drawing.Size(1032, 359);
            this.panelContainerForForms.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 533);
            this.Controls.Add(this.panelContainerForForms);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Yu Gothic UI Light", 11.25F);
            this.Name = "FormMain";
            this.Ribbon = this.ribbon;
            this.Text = "INICIAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem buttonEntitdade;
        private DevExpress.XtraBars.BarButtonItem buttonArtigos;
        private System.Windows.Forms.Panel panelContainerForForms;
        private DevExpress.XtraBars.BarButtonItem buttonSale;
    }
}