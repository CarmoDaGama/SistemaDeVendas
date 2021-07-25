using System;
using DevExpress.XtraBars;
using Sistema.Domain.Entities.Entity;
using Sistema.Framework;
using Sistema.Application.FormsBase;
using Sistema.Application.Interfaces.Entity;
using Sistema.Domain.Enuns_Entities;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraBars.Ribbon;

namespace Sistema.Vendas.Desktop.Views.Forms.Entities
{
    public partial class FormTipoContactos : /*RibbonForm*/FormBaseList<TipoContacto>
    {
        public int TipoContactoId { get; private set; }

        public FormTipoContactos(TipoContactoApp app):base(app)
        {
            InitializeComponent();
        }
        protected override void loadList()
        {
            base.loadList();
            gridControlEntities.DataSource = Entities;
        }
        public override TipoContacto GetEntity()
        {
            buttonSelect.Visibility = BarItemVisibility.Always;
            return base.GetEntity();
        }

        private void gridViewEntidades_DoubleClick(object sender, EventArgs e)
        {
            Index = GenericTasks.GetIndexGridCurrnet(sender, MousePosition);
            if (!buttonSave.Enabled)
                activeFuncaoEditar();
        }

        private void buttonSelect_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void buttonNewContact_ItemClick(object sender, ItemClickEventArgs e)
        {
            Operation = TypeOperationForm.Create;
            textEditDecricao.Text = string.Empty;
            buttonEditar.Enabled = false;
            buttonNewContact.Enabled = false;
            buttonSave.Enabled = true;
            textEditDecricao.Enabled = true;

        }

        private void buttonEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            activeFuncaoEditar();
        }

        private void activeFuncaoEditar()
        {
            if (!IndexIsSelected())
            {
                messageBoxShow("Selecione um registro!");
                return;
            }
            Operation = TypeOperationForm.Edit;
            textEditDecricao.Text = Entities[Index].Descricao;
            TipoContactoId = Entities[Index].TipoContactoId;
            buttonEditar.Enabled = false;
            buttonSave.Enabled = true;
            buttonNewContact.Enabled = false;
            textEditDecricao.Enabled = true;

        }

        private void buttonSave_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (string.IsNullOrEmpty(textEditDecricao.Text))
            {
                messageBoxShow("Preencha O campo descrição!");
                return;
            }
            if (Operation == TypeOperationForm.Edit)
            {
                App.Update(new TipoContacto() { TipoContactoId = TipoContactoId, Descricao = textEditDecricao.Text });
            }
            else if (Operation == TypeOperationForm.Create)
            {
                App.Insert(new TipoContacto() { Descricao = textEditDecricao.Text });
            }
            buttonEditar.Enabled = true;
            buttonNewContact.Enabled = true;
            buttonSave.Enabled = false;
            textEditDecricao.Enabled = false;
            loadList();
        }

        private void buttonRemover_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleleEntity();
        }

        private void FormTipoContactos_Load(object sender, EventArgs e)
        {
            loadList();
        }

        private void gridViewEntidades_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            Index = e.RowHandle;
        }

        private void gridViewEntidades_RowClick(object sender, RowClickEventArgs e)
        {
            Index = e.RowHandle;
        }
    }
}