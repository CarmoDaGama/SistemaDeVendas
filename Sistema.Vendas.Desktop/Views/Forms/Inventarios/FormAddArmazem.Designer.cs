namespace Sistema.Vendas.Desktop.Views.Forms.Inventarios
{
    partial class FormAddArmazem
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
            this.buttoGetArmazem = new DevExpress.XtraEditors.SimpleButton();
            this.label14 = new System.Windows.Forms.Label();
            this.textEditArmazem = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.textEditQtdMax = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.textEditQtdMinima = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.textEditQtdInicial = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditArmazem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQtdMax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQtdMinima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQtdInicial.Properties)).BeginInit();
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
            // buttoGetArmazem
            // 
            this.buttoGetArmazem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttoGetArmazem.Location = new System.Drawing.Point(481, 141);
            this.buttoGetArmazem.Name = "buttoGetArmazem";
            this.buttoGetArmazem.Size = new System.Drawing.Size(24, 26);
            this.buttoGetArmazem.TabIndex = 8;
            this.buttoGetArmazem.Text = "...";
            this.buttoGetArmazem.Click += new System.EventHandler(this.buttoGetArmazem_Click);
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
            // textEditArmazem
            // 
            this.textEditArmazem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditArmazem.Enabled = false;
            this.textEditArmazem.Location = new System.Drawing.Point(153, 141);
            this.textEditArmazem.Name = "textEditArmazem";
            this.textEditArmazem.Size = new System.Drawing.Size(326, 26);
            this.textEditArmazem.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Armazem:";
            // 
            // textEditQtdMax
            // 
            this.textEditQtdMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditQtdMax.Location = new System.Drawing.Point(153, 170);
            this.textEditQtdMax.Name = "textEditQtdMax";
            this.textEditQtdMax.Size = new System.Drawing.Size(352, 26);
            this.textEditQtdMax.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quantidade Maxíma:";
            // 
            // textEditQtdMinima
            // 
            this.textEditQtdMinima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditQtdMinima.Location = new System.Drawing.Point(153, 199);
            this.textEditQtdMinima.Name = "textEditQtdMinima";
            this.textEditQtdMinima.Size = new System.Drawing.Size(352, 26);
            this.textEditQtdMinima.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantidade Miníma:";
            // 
            // textEditQtdInicial
            // 
            this.textEditQtdInicial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditQtdInicial.Location = new System.Drawing.Point(153, 228);
            this.textEditQtdInicial.Name = "textEditQtdInicial";
            this.textEditQtdInicial.Size = new System.Drawing.Size(352, 26);
            this.textEditQtdInicial.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantidade Inicial:";
            // 
            // FormAddArmazem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 266);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEditQtdInicial);
            this.Controls.Add(this.textEditQtdMinima);
            this.Controls.Add(this.buttoGetArmazem);
            this.Controls.Add(this.textEditQtdMax);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textEditArmazem);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAddArmazem";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar A Um Armazem";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditArmazem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQtdMax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQtdMinima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQtdInicial.Properties)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton buttoGetArmazem;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.TextEdit textEditArmazem;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEditQtdMax;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEditQtdMinima;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEditQtdInicial;
        private System.Windows.Forms.Label label4;
    }
}