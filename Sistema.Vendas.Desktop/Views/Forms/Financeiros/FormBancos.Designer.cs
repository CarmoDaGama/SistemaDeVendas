namespace Sistema.Vendas.Desktop.Views.Forms.Financeiros
{
    partial class FormBancos
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
            this.buttonNewContact = new DevExpress.XtraBars.BarButtonItem();
            this.buttonSelect = new DevExpress.XtraBars.BarButtonItem();
            this.buttonRemover = new DevExpress.XtraBars.BarButtonItem();
            this.buttonSave = new DevExpress.XtraBars.BarButtonItem();
            this.buttonEditar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControlBancos = new DevExpress.XtraGrid.GridControl();
            this.gridViewBancos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.textEditDecricao = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDecricao.Properties)).BeginInit();
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
            this.buttonNewContact,
            this.buttonSelect,
            this.buttonRemover,
            this.buttonSave,
            this.buttonEditar});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.PopupShowMode = DevExpress.XtraBars.PopupShowMode.Classic;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(476, 113);
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbon.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // buttonNewContact
            // 
            this.buttonNewContact.Caption = "Novo";
            this.buttonNewContact.Id = 1;
            this.buttonNewContact.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Plus_48px;
            this.buttonNewContact.Name = "buttonNewContact";
            this.buttonNewContact.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.buttonNewContact.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonNewContact_ItemClick);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Caption = "Selecionar";
            this.buttonSelect.Id = 2;
            this.buttonSelect.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Checkmark_35px;
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.buttonSelect.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.buttonSelect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSelect_ItemClick);
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
            // buttonSave
            // 
            this.buttonSave.Caption = "Gravar";
            this.buttonSave.Enabled = false;
            this.buttonSave.Id = 4;
            this.buttonSave.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Save_40px;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.buttonSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSave_ItemClick);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Caption = "Editar";
            this.buttonEditar.Id = 5;
            this.buttonEditar.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Edit_35px;
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.buttonEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonEditar_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonSelect);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonNewContact);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonEditar);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonRemover);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // gridControlBancos
            // 
            this.gridControlBancos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBancos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlBancos.Location = new System.Drawing.Point(0, 0);
            this.gridControlBancos.MainView = this.gridViewBancos;
            this.gridControlBancos.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlBancos.MenuManager = this.ribbon;
            this.gridControlBancos.Name = "gridControlBancos";
            this.gridControlBancos.Size = new System.Drawing.Size(476, 416);
            this.gridControlBancos.TabIndex = 2;
            this.gridControlBancos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBancos});
            // 
            // gridViewBancos
            // 
            this.gridViewBancos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewBancos.DetailHeight = 457;
            this.gridViewBancos.FixedLineWidth = 3;
            this.gridViewBancos.GridControl = this.gridControlBancos;
            this.gridViewBancos.Name = "gridViewBancos";
            this.gridViewBancos.OptionsFind.AlwaysVisible = true;
            this.gridViewBancos.OptionsView.ShowGroupPanel = false;
            this.gridViewBancos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewBancos_RowClick);
            this.gridViewBancos.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewBancos_RowCellClick);
            this.gridViewBancos.DoubleClick += new System.EventHandler(this.gridViewBancos_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "BancoId";
            this.gridColumn1.MinWidth = 24;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 126;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Descrição";
            this.gridColumn2.FieldName = "Dercricao";
            this.gridColumn2.MinWidth = 24;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 771;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.textEditDecricao);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 113);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(476, 58);
            this.panelControl1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Decrição:";
            // 
            // textEditDecricao
            // 
            this.textEditDecricao.Enabled = false;
            this.textEditDecricao.Location = new System.Drawing.Point(66, 20);
            this.textEditDecricao.MenuManager = this.ribbon;
            this.textEditDecricao.Name = "textEditDecricao";
            this.textEditDecricao.Size = new System.Drawing.Size(399, 24);
            this.textEditDecricao.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlBancos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 416);
            this.panel1.TabIndex = 0;
            // 
            // FormBancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 587);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBancos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bancos";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDecricao.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem buttonNewContact;
        private DevExpress.XtraBars.BarButtonItem buttonSelect;
        private DevExpress.XtraBars.BarButtonItem buttonRemover;
        private DevExpress.XtraGrid.GridControl gridControlBancos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBancos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraBars.BarButtonItem buttonSave;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEditDecricao;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.BarButtonItem buttonEditar;
    }

}