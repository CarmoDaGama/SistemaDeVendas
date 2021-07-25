namespace Sistema.Vendas.Desktop.Views.Forms.Gerais
{
    partial class FormPais
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
            this.buttonNew = new DevExpress.XtraBars.BarButtonItem();
            this.buttonSelectPais = new DevExpress.XtraBars.BarButtonItem();
            this.buttonRemover = new DevExpress.XtraBars.BarButtonItem();
            this.buttonGravar = new DevExpress.XtraBars.BarButtonItem();
            this.buttonEdit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControlPaises = new DevExpress.XtraGrid.GridControl();
            this.gridViewPaises = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.textEditDescricao = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPaises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPaises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescricao.Properties)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.buttonNew,
            this.buttonSelectPais,
            this.buttonRemover,
            this.buttonGravar,
            this.buttonEdit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.PopupShowMode = DevExpress.XtraBars.PopupShowMode.Classic;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(544, 119);
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbon.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // buttonNew
            // 
            this.buttonNew.Caption = "Nova";
            this.buttonNew.Id = 1;
            this.buttonNew.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Plus_48px;
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.buttonNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonNew_ItemClick);
            // 
            // buttonSelectPais
            // 
            this.buttonSelectPais.Caption = "Selecionar";
            this.buttonSelectPais.Id = 2;
            this.buttonSelectPais.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Checkmark_35px;
            this.buttonSelectPais.Name = "buttonSelectPais";
            this.buttonSelectPais.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.buttonSelectPais.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.buttonSelectPais.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSelectPais_ItemClick);
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
            // buttonGravar
            // 
            this.buttonGravar.Caption = "Gravar";
            this.buttonGravar.Enabled = false;
            this.buttonGravar.Id = 4;
            this.buttonGravar.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Save_40px;
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.buttonGravar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonGravar_ItemClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Caption = "Editar";
            this.buttonEdit.Id = 5;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonSelectPais);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonGravar);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonRemover);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // gridControlPaises
            // 
            this.gridControlPaises.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPaises.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControlPaises.Location = new System.Drawing.Point(0, 0);
            this.gridControlPaises.MainView = this.gridViewPaises;
            this.gridControlPaises.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControlPaises.MenuManager = this.ribbon;
            this.gridControlPaises.Name = "gridControlPaises";
            this.gridControlPaises.Size = new System.Drawing.Size(544, 504);
            this.gridControlPaises.TabIndex = 2;
            this.gridControlPaises.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPaises});
            // 
            // gridViewPaises
            // 
            this.gridViewPaises.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewPaises.DetailHeight = 538;
            this.gridViewPaises.FixedLineWidth = 3;
            this.gridViewPaises.GridControl = this.gridControlPaises;
            this.gridViewPaises.Name = "gridViewPaises";
            this.gridViewPaises.OptionsFind.AlwaysVisible = true;
            this.gridViewPaises.OptionsView.ShowGroupPanel = false;
            this.gridViewPaises.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewPaises_RowClick);
            this.gridViewPaises.DoubleClick += new System.EventHandler(this.gridViewPaises_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "PaisId";
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
            this.gridColumn2.FieldName = "Descricao";
            this.gridColumn2.MinWidth = 27;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 881;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.textEditDescricao);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 119);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(544, 68);
            this.panelControl1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Decrição:";
            // 
            // textEditDescricao
            // 
            this.textEditDescricao.Location = new System.Drawing.Point(76, 24);
            this.textEditDescricao.MenuManager = this.ribbon;
            this.textEditDescricao.Name = "textEditDescricao";
            this.textEditDescricao.Size = new System.Drawing.Size(456, 26);
            this.textEditDescricao.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlPaises);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 504);
            this.panel1.TabIndex = 0;
            // 
            // FormPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 691);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paises";
            this.Load += new System.EventHandler(this.FormPais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPaises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPaises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescricao.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem buttonNew;
        private DevExpress.XtraBars.BarButtonItem buttonSelectPais;
        private DevExpress.XtraBars.BarButtonItem buttonRemover;
        private DevExpress.XtraGrid.GridControl gridControlPaises;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPaises;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraBars.BarButtonItem buttonGravar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEditDescricao;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.BarButtonItem buttonEdit;
    }
}