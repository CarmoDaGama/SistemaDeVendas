namespace Sistema.Vendas.Desktop.Views.Forms.Entities
{
    partial class FormEntidades
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
            this.buttonNewEntidade = new DevExpress.XtraBars.BarButtonItem();
            this.buttonSelectEntidade = new DevExpress.XtraBars.BarButtonItem();
            this.buttonRemover = new DevExpress.XtraBars.BarButtonItem();
            this.buttonEdit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControlEntidades = new DevExpress.XtraGrid.GridControl();
            this.gridViewEntidades = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEntidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
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
            this.buttonNewEntidade,
            this.buttonSelectEntidade,
            this.buttonRemover,
            this.buttonEdit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.PopupShowMode = DevExpress.XtraBars.PopupShowMode.Classic;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(918, 113);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbon.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // buttonNewEntidade
            // 
            this.buttonNewEntidade.Caption = "Nova";
            this.buttonNewEntidade.Id = 1;
            this.buttonNewEntidade.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Plus_48px;
            this.buttonNewEntidade.Name = "buttonNewEntidade";
            this.buttonNewEntidade.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.buttonNewEntidade.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonNewEntidade_ItemClick);
            // 
            // buttonSelectEntidade
            // 
            this.buttonSelectEntidade.Caption = "Selecionar";
            this.buttonSelectEntidade.Id = 2;
            this.buttonSelectEntidade.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Checkmark_35px;
            this.buttonSelectEntidade.Name = "buttonSelectEntidade";
            this.buttonSelectEntidade.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.buttonSelectEntidade.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.buttonSelectEntidade.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSelectEntidade_ItemClick);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Caption = "Eliminar";
            this.buttonRemover.Id = 3;
            this.buttonRemover.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Delete_48px;
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.buttonRemover.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonRemover_ItemClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Caption = "Editar";
            this.buttonEdit.Id = 4;
            this.buttonEdit.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Edit_35px;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.buttonEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonEdit_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonSelectEntidade);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonNewEntidade);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonRemover);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 564);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(918, 23);
            // 
            // gridControlEntidades
            // 
            this.gridControlEntidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEntidades.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlEntidades.Location = new System.Drawing.Point(0, 113);
            this.gridControlEntidades.MainView = this.gridViewEntidades;
            this.gridControlEntidades.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlEntidades.MenuManager = this.ribbon;
            this.gridControlEntidades.Name = "gridControlEntidades";
            this.gridControlEntidades.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControlEntidades.Size = new System.Drawing.Size(918, 451);
            this.gridControlEntidades.TabIndex = 2;
            this.gridControlEntidades.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEntidades});
            // 
            // gridViewEntidades
            // 
            this.gridViewEntidades.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridViewEntidades.DetailHeight = 457;
            this.gridViewEntidades.FixedLineWidth = 3;
            this.gridViewEntidades.GridControl = this.gridControlEntidades;
            this.gridViewEntidades.Name = "gridViewEntidades";
            this.gridViewEntidades.OptionsFind.AlwaysVisible = true;
            this.gridViewEntidades.OptionsView.ShowGroupPanel = false;
            this.gridViewEntidades.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewEntidades_RowCellClick);
            this.gridViewEntidades.DoubleClick += new System.EventHandler(this.gridViewEntidades_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "EntidadeId";
            this.gridColumn1.MinWidth = 24;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.Visible = false;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 126;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Descrição";
            this.gridColumn2.FieldName = "Nome";
            this.gridColumn2.MinWidth = 24;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 651;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Imagem";
            this.gridColumn3.ColumnEdit = this.repositoryItemPictureEdit1;
            this.gridColumn3.FieldName = "Imagem";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 120;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // FormEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 587);
            this.Controls.Add(this.gridControlEntidades);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEntidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entidades";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEntidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem buttonNewEntidade;
        private DevExpress.XtraBars.BarButtonItem buttonSelectEntidade;
        private DevExpress.XtraBars.BarButtonItem buttonRemover;
        private DevExpress.XtraGrid.GridControl gridControlEntidades;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEntidades;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraBars.BarButtonItem buttonEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
    }
}