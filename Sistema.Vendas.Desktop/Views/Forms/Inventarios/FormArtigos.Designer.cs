namespace Sistema.Vendas.Desktop.Views.Forms.Inventarios
{
    partial class FormArtigos
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
            this.buttonNewArtigo = new DevExpress.XtraBars.BarButtonItem();
            this.buttonSelectArtigo = new DevExpress.XtraBars.BarButtonItem();
            this.buttonRemover = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControlArtigos = new DevExpress.XtraGrid.GridControl();
            this.gridViewArtigos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlArtigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewArtigos)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.DarkBlue;
            this.ribbon.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.buttonNewArtigo,
            this.buttonSelectArtigo,
            this.buttonRemover});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.PopupShowMode = DevExpress.XtraBars.PopupShowMode.Classic;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(1049, 119);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbon.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // buttonNewArtigo
            // 
            this.buttonNewArtigo.Caption = "Novo";
            this.buttonNewArtigo.Id = 1;
            this.buttonNewArtigo.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Plus_48px;
            this.buttonNewArtigo.Name = "buttonNewArtigo";
            this.buttonNewArtigo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // buttonSelectArtigo
            // 
            this.buttonSelectArtigo.Caption = "Selecionar";
            this.buttonSelectArtigo.Id = 2;
            this.buttonSelectArtigo.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Checked_Checkbox_48px;
            this.buttonSelectArtigo.Name = "buttonSelectArtigo";
            this.buttonSelectArtigo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.buttonSelectArtigo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // buttonRemover
            // 
            this.buttonRemover.Caption = "Eliminar";
            this.buttonRemover.Id = 3;
            this.buttonRemover.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Delete_48px;
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonSelectArtigo);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonNewArtigo);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonRemover);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 666);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1049, 25);
            // 
            // gridControlArtigos
            // 
            this.gridControlArtigos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlArtigos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControlArtigos.Location = new System.Drawing.Point(0, 119);
            this.gridControlArtigos.MainView = this.gridViewArtigos;
            this.gridControlArtigos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControlArtigos.MenuManager = this.ribbon;
            this.gridControlArtigos.Name = "gridControlArtigos";
            this.gridControlArtigos.Size = new System.Drawing.Size(1049, 547);
            this.gridControlArtigos.TabIndex = 2;
            this.gridControlArtigos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewArtigos});
            // 
            // gridViewArtigos
            // 
            this.gridViewArtigos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewArtigos.DetailHeight = 538;
            this.gridViewArtigos.FixedLineWidth = 3;
            this.gridViewArtigos.GridControl = this.gridControlArtigos;
            this.gridViewArtigos.Name = "gridViewArtigos";
            this.gridViewArtigos.OptionsFind.AlwaysVisible = true;
            this.gridViewArtigos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "EntidadeId";
            this.gridColumn1.MinWidth = 27;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 144;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Descrição";
            this.gridColumn2.FieldName = "Nome";
            this.gridColumn2.MinWidth = 27;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 881;
            // 
            // FormArtigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 691);
            this.Controls.Add(this.gridControlArtigos);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormArtigos";
            //this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //this.StatusBar = this.ribbonStatusBar;
            this.Text = "Artigos";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlArtigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewArtigos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem buttonNewArtigo;
        private DevExpress.XtraBars.BarButtonItem buttonSelectArtigo;
        private DevExpress.XtraBars.BarButtonItem buttonRemover;
        private DevExpress.XtraGrid.GridControl gridControlArtigos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewArtigos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}