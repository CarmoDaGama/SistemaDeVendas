namespace Sistema.Vendas.Desktop.Views.Forms.Financeiros
{
    partial class FormAddContaBancaria
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
            this.buttonSaveEntidade = new DevExpress.XtraBars.BarButtonItem();
            this.buttonClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.buttoGetBanco = new DevExpress.XtraEditors.SimpleButton();
            this.label14 = new System.Windows.Forms.Label();
            this.textEditNameBank = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.textEditNumero = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.textEditNatureza = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.textEditSequencia = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.textEditIban = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.textEditSwift = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNameBank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNatureza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSequencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSwift.Properties)).BeginInit();
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
            this.buttonSaveEntidade,
            this.buttonClose});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.PopupShowMode = DevExpress.XtraBars.PopupShowMode.Inplace;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(452, 113);
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbon.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // buttonSaveEntidade
            // 
            this.buttonSaveEntidade.Caption = "Salvar";
            this.buttonSaveEntidade.Id = 2;
            this.buttonSaveEntidade.ImageOptions.Image = global::Sistema.Vendas.Desktop.Properties.Resources.Save_40px;
            this.buttonSaveEntidade.Name = "buttonSaveEntidade";
            this.buttonSaveEntidade.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.buttonSaveEntidade.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSaveEntidade_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // buttoGetBanco
            // 
            this.buttoGetBanco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttoGetBanco.Location = new System.Drawing.Point(421, 120);
            this.buttoGetBanco.Name = "buttoGetBanco";
            this.buttoGetBanco.Size = new System.Drawing.Size(21, 24);
            this.buttoGetBanco.TabIndex = 8;
            this.buttoGetBanco.Text = "...";
            this.buttoGetBanco.Click += new System.EventHandler(this.buttoGetBanco_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-104, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "Hablitação:";
            // 
            // textEditNameBank
            // 
            this.textEditNameBank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditNameBank.Enabled = false;
            this.textEditNameBank.Location = new System.Drawing.Point(77, 120);
            this.textEditNameBank.Name = "textEditNameBank";
            this.textEditNameBank.Size = new System.Drawing.Size(344, 24);
            this.textEditNameBank.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Banco:";
            // 
            // textEditNumero
            // 
            this.textEditNumero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditNumero.Location = new System.Drawing.Point(77, 144);
            this.textEditNumero.Name = "textEditNumero";
            this.textEditNumero.Size = new System.Drawing.Size(365, 24);
            this.textEditNumero.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Número:";
            // 
            // textEditNatureza
            // 
            this.textEditNatureza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditNatureza.Location = new System.Drawing.Point(77, 168);
            this.textEditNatureza.Name = "textEditNatureza";
            this.textEditNatureza.Size = new System.Drawing.Size(365, 24);
            this.textEditNatureza.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Natureza:";
            // 
            // textEditSequencia
            // 
            this.textEditSequencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditSequencia.Location = new System.Drawing.Point(77, 192);
            this.textEditSequencia.Name = "textEditSequencia";
            this.textEditSequencia.Size = new System.Drawing.Size(365, 24);
            this.textEditSequencia.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sequência:";
            // 
            // textEditIban
            // 
            this.textEditIban.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditIban.Location = new System.Drawing.Point(77, 216);
            this.textEditIban.Name = "textEditIban";
            this.textEditIban.Size = new System.Drawing.Size(365, 24);
            this.textEditIban.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Iban:";
            // 
            // textEditSwift
            // 
            this.textEditSwift.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditSwift.Location = new System.Drawing.Point(77, 240);
            this.textEditSwift.Name = "textEditSwift";
            this.textEditSwift.Size = new System.Drawing.Size(365, 24);
            this.textEditSwift.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Swift";
            // 
            // FormAddContaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 278);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textEditSwift);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textEditIban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textEditSequencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEditNatureza);
            this.Controls.Add(this.buttoGetBanco);
            this.Controls.Add(this.textEditNumero);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textEditNameBank);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddContaBancaria";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Conta Bancaria";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNameBank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNatureza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSequencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSwift.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem buttonSaveEntidade;
        private DevExpress.XtraBars.BarButtonItem buttonClose;
        private DevExpress.XtraEditors.SimpleButton buttoGetBanco;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.TextEdit textEditNameBank;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEditNumero;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEditNatureza;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEditSequencia;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit textEditIban;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit textEditSwift;
        private System.Windows.Forms.Label label6;
    }
}