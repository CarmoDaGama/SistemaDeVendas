namespace Sistema.Vendas.Desktop.Views.Forms.Entities
{
    partial class FormAddDocumentoEntity
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
            this.buttonSaveClose = new DevExpress.XtraBars.BarButtonItem();
            this.buttonSaveEntidade = new DevExpress.XtraBars.BarButtonItem();
            this.buttonClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.buttoGetTipoDocument = new DevExpress.XtraEditors.SimpleButton();
            this.label14 = new System.Windows.Forms.Label();
            this.textEditTipoDocument = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.textEditNumeroDocumento = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.textEditNatureza = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.textEditSequencia = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTipoDocument.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumeroDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNatureza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSequencia.Properties)).BeginInit();
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
            this.buttonSaveClose,
            this.buttonSaveEntidade,
            this.buttonClose});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.PopupShowMode = DevExpress.XtraBars.PopupShowMode.Classic;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(516, 119);
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbon.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // buttonSaveClose
            // 
            this.buttonSaveClose.Caption = "Salvar e Fechar";
            this.buttonSaveClose.Id = 1;
            this.buttonSaveClose.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Save_48px;
            this.buttonSaveClose.Name = "buttonSaveClose";
            this.buttonSaveClose.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // buttonSaveEntidade
            // 
            this.buttonSaveEntidade.Caption = "Salvar";
            this.buttonSaveEntidade.Id = 2;
            this.buttonSaveEntidade.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Save_40px;
            this.buttonSaveEntidade.Name = "buttonSaveEntidade";
            this.buttonSaveEntidade.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.buttonSaveEntidade.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // buttonClose
            // 
            this.buttonClose.Caption = "Fechar";
            this.buttonClose.Id = 3;
            this.buttonClose.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Delete_48px;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
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
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonSaveEntidade);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonSaveClose);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // buttoGetTipoDocument
            // 
            this.buttoGetTipoDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttoGetTipoDocument.Location = new System.Drawing.Point(481, 141);
            this.buttoGetTipoDocument.Name = "buttoGetTipoDocument";
            this.buttoGetTipoDocument.Size = new System.Drawing.Size(24, 26);
            this.buttoGetTipoDocument.TabIndex = 8;
            this.buttoGetTipoDocument.Text = "...";
            this.buttoGetTipoDocument.Click += new System.EventHandler(this.buttoGetTipoDocument_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-119, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "Hablitação:";
            // 
            // textEditTipoDocument
            // 
            this.textEditTipoDocument.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditTipoDocument.Enabled = false;
            this.textEditTipoDocument.Location = new System.Drawing.Point(140, 141);
            this.textEditTipoDocument.Name = "textEditTipoDocument";
            this.textEditTipoDocument.Size = new System.Drawing.Size(339, 26);
            this.textEditTipoDocument.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo:";
            // 
            // textEditNumeroDocumento
            // 
            this.textEditNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditNumeroDocumento.Location = new System.Drawing.Point(140, 170);
            this.textEditNumeroDocumento.Name = "textEditNumeroDocumento";
            this.textEditNumeroDocumento.Size = new System.Drawing.Size(365, 26);
            this.textEditNumeroDocumento.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Número:";
            // 
            // textEditNatureza
            // 
            this.textEditNatureza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditNatureza.Location = new System.Drawing.Point(140, 199);
            this.textEditNatureza.Name = "textEditNatureza";
            this.textEditNatureza.Size = new System.Drawing.Size(365, 26);
            this.textEditNatureza.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data De Emissão:";
            // 
            // textEditSequencia
            // 
            this.textEditSequencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditSequencia.Location = new System.Drawing.Point(140, 228);
            this.textEditSequencia.Name = "textEditSequencia";
            this.textEditSequencia.Size = new System.Drawing.Size(365, 26);
            this.textEditSequencia.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data De Validade:";
            // 
            // FormAddDocumentoEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 266);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textEditSequencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEditNatureza);
            this.Controls.Add(this.buttoGetTipoDocument);
            this.Controls.Add(this.textEditNumeroDocumento);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textEditTipoDocument);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAddDocumentoEntity";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Documento";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTipoDocument.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumeroDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNatureza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSequencia.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem buttonSaveClose;
        private DevExpress.XtraBars.BarButtonItem buttonSaveEntidade;
        private DevExpress.XtraBars.BarButtonItem buttonClose;
        private DevExpress.XtraEditors.SimpleButton buttoGetTipoDocument;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.TextEdit textEditTipoDocument;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEditNumeroDocumento;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEditNatureza;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEditSequencia;
        private System.Windows.Forms.Label label4;
    }
}