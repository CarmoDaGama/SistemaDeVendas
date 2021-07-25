using System;
using Sistema.Domain.Entities.Entity;

namespace Sistema.Vendas.Desktop.Views.Forms.Entities
{
    partial class FormAddContact
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
            this.buttoGetTipoContacto = new DevExpress.XtraEditors.SimpleButton();
            this.label14 = new System.Windows.Forms.Label();
            this.textEditTipo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.textEditContacto = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditContacto.Properties)).BeginInit();
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
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.PopupShowMode = DevExpress.XtraBars.PopupShowMode.Classic;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(452, 113);
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
            this.buttonSaveClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSaveClose_ItemClick);
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
            this.buttonSaveEntidade.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSaveEntidade_ItemClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Caption = "Cancelar";
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
            // buttoGetTipoContacto
            // 
            this.buttoGetTipoContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttoGetTipoContacto.Location = new System.Drawing.Point(419, 141);
            this.buttoGetTipoContacto.Name = "buttoGetTipoContacto";
            this.buttoGetTipoContacto.Size = new System.Drawing.Size(21, 24);
            this.buttoGetTipoContacto.TabIndex = 8;
            this.buttoGetTipoContacto.Text = "...";
            this.buttoGetTipoContacto.Click += new System.EventHandler(this.buttoGetTipoContacto_Click);
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
            // textEditTipo
            // 
            this.textEditTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditTipo.Enabled = false;
            this.textEditTipo.Location = new System.Drawing.Point(77, 141);
            this.textEditTipo.Name = "textEditTipo";
            this.textEditTipo.Size = new System.Drawing.Size(342, 24);
            this.textEditTipo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo:";
            // 
            // textEditContacto
            // 
            this.textEditContacto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditContacto.Location = new System.Drawing.Point(77, 174);
            this.textEditContacto.Name = "textEditContacto";
            this.textEditContacto.Size = new System.Drawing.Size(365, 24);
            this.textEditContacto.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contacto:";
            // 
            // FormAddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 236);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttoGetTipoContacto);
            this.Controls.Add(this.textEditContacto);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textEditTipo);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddContact";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Contacto";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditContacto.Properties)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton buttoGetTipoContacto;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.TextEdit textEditTipo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEditContacto;
        private System.Windows.Forms.Label label2;
    }
}