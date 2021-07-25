namespace Sistema.Vendas.Desktop.Views.Forms.Entities
{
    partial class FormHabilitacoes
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
            this.buttonSelectHabilitacao = new DevExpress.XtraBars.BarButtonItem();
            this.buttonRemover = new DevExpress.XtraBars.BarButtonItem();
            this.buttonSave = new DevExpress.XtraBars.BarButtonItem();
            this.buttonUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControlHabilitacoes = new DevExpress.XtraGrid.GridControl();
            this.gridViewHabilitacoes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.textEditDescricao = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHabilitacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHabilitacoes)).BeginInit();
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
            this.buttonSelectHabilitacao,
            this.buttonRemover,
            this.buttonSave,
            this.buttonUpdate});
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
            // buttonSelectHabilitacao
            // 
            this.buttonSelectHabilitacao.Caption = "Selecionar";
            this.buttonSelectHabilitacao.Id = 2;
            this.buttonSelectHabilitacao.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Checkmark_35px;
            this.buttonSelectHabilitacao.Name = "buttonSelectHabilitacao";
            this.buttonSelectHabilitacao.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.buttonSelectHabilitacao.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.buttonSelectHabilitacao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSelectHabiltacao_ItemClick);
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
            // buttonUpdate
            // 
            this.buttonUpdate.Caption = "Editar";
            this.buttonUpdate.Id = 5;
            this.buttonUpdate.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Edit_35px;
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.buttonUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonUpdate_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonSelectHabilitacao);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonUpdate);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonRemover);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // gridControlHabilitacoes
            // 
            this.gridControlHabilitacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHabilitacoes.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControlHabilitacoes.Location = new System.Drawing.Point(0, 0);
            this.gridControlHabilitacoes.MainView = this.gridViewHabilitacoes;
            this.gridControlHabilitacoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControlHabilitacoes.MenuManager = this.ribbon;
            this.gridControlHabilitacoes.Name = "gridControlHabilitacoes";
            this.gridControlHabilitacoes.Size = new System.Drawing.Size(544, 504);
            this.gridControlHabilitacoes.TabIndex = 2;
            this.gridControlHabilitacoes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHabilitacoes});
            // 
            // gridViewHabilitacoes
            // 
            this.gridViewHabilitacoes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewHabilitacoes.DetailHeight = 538;
            this.gridViewHabilitacoes.FixedLineWidth = 3;
            this.gridViewHabilitacoes.GridControl = this.gridControlHabilitacoes;
            this.gridViewHabilitacoes.Name = "gridViewHabilitacoes";
            this.gridViewHabilitacoes.OptionsFind.AlwaysVisible = true;
            this.gridViewHabilitacoes.OptionsView.ShowGroupPanel = false;
            this.gridViewHabilitacoes.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewHabilitacoes_RowCellClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "HabilitacaoId";
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
            this.gridColumn2.FieldName = "Decricao";
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
            this.textEditDescricao.Enabled = false;
            this.textEditDescricao.Location = new System.Drawing.Point(76, 24);
            this.textEditDescricao.MenuManager = this.ribbon;
            this.textEditDescricao.Name = "textEditDescricao";
            this.textEditDescricao.Size = new System.Drawing.Size(456, 26);
            this.textEditDescricao.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlHabilitacoes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 504);
            this.panel1.TabIndex = 0;
            // 
            // FormHabilitacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 691);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormHabilitacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habilitações";
            this.Load += new System.EventHandler(this.FormHabilitacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHabilitacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHabilitacoes)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem buttonSelectHabilitacao;
        private DevExpress.XtraBars.BarButtonItem buttonRemover;
        private DevExpress.XtraGrid.GridControl gridControlHabilitacoes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHabilitacoes;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraBars.BarButtonItem buttonSave;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEditDescricao;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.BarButtonItem buttonUpdate;
    }
}