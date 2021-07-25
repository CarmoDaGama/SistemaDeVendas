using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Sistema.Application.Interfaces;
using Sistema.Domain.Enuns_Entities;
using DevExpress.XtraEditors;

namespace Sistema.Application.FormsBase
{
    public partial class FormBaseList<Entity> : XtraForm where Entity : class, new()
    {
        protected readonly AppBase<Entity> App;
        protected int Index { get; set; }
        protected List<Entity> Entities { get; set; }
        protected TypeOperationForm Operation { get; set; } = TypeOperationForm.List;
        public FormBaseList(AppBase<Entity> app)
        {
            App = app;
        }
        protected bool IsSelectOperation()
        {
            return Equals(Operation, TypeOperationForm.Select);
        }
        public bool IndexIsSelected()
        {
            return Index >= 0;
        }
        protected virtual void loadList()
        {
            Entities = App.GetEntities();
            Index = 0;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            loadList();
        }
        public virtual Entity GetEntity()
        {
            Operation = TypeOperationForm.Select;
            ShowDialog();
            if (Index <= -1)
            {
                return new Entity();
            }
            return Entities[Index];
        }
        protected virtual void DeleleEntity()
        {
            if (Index <= -1)
                messageBoxShow("Selecione Um Registro!");

            else
            {
                App.Delete(Entities[Index]);
                loadList();
            }
        }
        protected void messageBoxShow(string message)
        {
            MessageBox.Show(
                message,
                "MESSAGEM", MessageBoxButtons.OK,
                MessageBoxIcon.Information
           );
        }
        
    }
}