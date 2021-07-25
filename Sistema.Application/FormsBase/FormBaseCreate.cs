using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using Sistema.Application.Interfaces;
using System;
using Sistema.Domain.Enuns_Entities;

namespace Sistema.Application.FormsBase
{
    public partial class FormBaseCreate<Entity>: RibbonForm where Entity : class, new() 
    {
        protected RibbonControl ribbonControl1;
        protected BarButtonItem btnSave;
        protected BarButtonItem buttonSaveClose;
        protected RibbonPage ribbonPage1;
        protected RibbonPageGroup ribbonPageGroup1;
        protected readonly AppBase<Entity> App;
        protected Entity ThisEntity { get; set; }
        protected TypeOperationForm Operation { get; set; } = TypeOperationForm.Create;
        public FormBaseCreate(AppBase<Entity> app)
        {
            App = app;
            InitializeComponentBase();
        }
        protected void SaveEntityIfValid()
        {
            if (isValidEntity())
            {
                if (Operation == TypeOperationForm.Create)
                    App.Insert(ThisEntity);
                else if (Operation == TypeOperationForm.Edit)
                    App.Update(ThisEntity);
            }
            else messageShow("Existe Campos da Entidade com valor nulo!");
        }
        protected void messageShow(string message)
        {
            MessageBox.Show(
                message,
                "MENSAGEM",
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information
            );
        }
        protected bool isValidEntity()
        {
            bool valid = true;
            foreach(var field in ThisEntity.GetType().GetProperties())
            {
                var valueField = field.GetValue(ThisEntity);
                if (Equals(valueField, null) || 
                    Equals(valueField, string.Empty) ||
                    Equals(valueField, 0))
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
        protected void EditEntity(Entity entity)
        {
            ThisEntity = entity;
            Operation = TypeOperationForm.Edit;
            ShowDialog();
        }
        protected void SetControlsFields(Control.ControlCollection controlFields)
        {
            foreach(var field in ThisEntity.GetType().GetProperties())
            {
                foreach(Control control in controlFields)
                {
                    if (control.Name.Contains(field.Name))
                    {
                        SetControl(control, field.GetValue(ThisEntity));
                    }
                }
            }
        }
        private void SetControl(Control control, object value)
        {
            var cob = new ComboBox();
            cob.SelectedIndex = 1;
            if (control.GetType().Name.Contains("Combo"))
            {
                control.GetType().GetProperty("SelectedIndex").SetValue(control, (int)value);
            }
            if (control.GetType().Name.Contains("Text"))
            {
                control.GetType().GetProperty("Text").SetValue(control, value);
            }
        }
        private void InitializeComponentBase()
        {
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.buttonSaveClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.DarkBlue;
            this.ribbonControl1.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnSave,
            this.buttonSaveClose});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(606, 100);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Gravar";
            this.btnSave.Id = 1;
            //this.btnSave.ImageOptions.Image = global::Sistema.Framework.Properties.Resources.Save_40px;
            this.btnSave.Name = "btnSave";
            this.btnSave.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // buttonSaveClose
            // 
            this.buttonSaveClose.Caption = "Gravar e Fechar";
            this.buttonSaveClose.Id = 2;
            //this.buttonSaveClose.ImageOptions.Image = global::Sistema.Framework.Properties.Resources.Save_48px;
            this.buttonSaveClose.Name = "buttonSaveClose";
            this.buttonSaveClose.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttonSaveClose);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // FormBaseCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 446);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormBaseCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GRAVAR ENTIDADE";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}