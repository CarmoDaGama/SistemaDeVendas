using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Grid;
using Sistema.Application.FormsBase;
using Sistema.Application.Interfaces.Financeiro;
using Sistema.Domain.Entities.Financeiro;
using System.Windows.Forms;
using System;
using Sistema.Domain.Enuns_Entities;

namespace Sistema.Vendas.Desktop.Views.Forms.Financeiros
{
    public partial class FormBancos : /*RibbonForm*/FormBaseList<Banco>
    {

        public FormBancos(BancoApp app):base(app) 
        {
            InitializeComponent();
        }

        private void buttonSelect_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void buttonNewContact_ItemClick(object sender, ItemClickEventArgs e)
        {
            activarNovo();
        }

        private void buttonEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            activarEditar();
        }

        private void buttonSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (isValidValuesInFields())
            {
                if (Operation == TypeOperationForm.Create)
                {
                    App.Insert(new Banco() { Dercricao = textEditDecricao.Text });
                    loadList();
                }
                else if (Operation == TypeOperationForm.Edit)
                {
                    if (IndexIsSelected())
                    {
                        var banco = Entities[Index];
                        banco.Dercricao = textEditDecricao.Text;
                        App.Update(banco);
                        loadList();
                    }
                }
                textEditDecricao.Text = string.Empty;
                textEditDecricao.Enabled = false;
                buttonEditar.Enabled = true;
                buttonNewContact.Enabled = true;
                buttonSave.Enabled = false;
            }
        }

        protected override void loadList()
        {
            base.loadList();
            gridControlBancos.DataSource = Entities;
        }
        private bool isValidValuesInFields()
        {
            if (string.IsNullOrEmpty(textEditDecricao.Text))
            {
                messageBoxShow("Preencha o campo descrição correctamente!");
                return false;
            }
            return true;
        }

        private void buttonRemover_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleleEntity();

        }

        private void gridViewBancos_RowClick(object sender, RowClickEventArgs e)
        {
            Index = e.RowHandle;
        }

        private void gridViewBancos_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            Index = e.RowHandle;
        }

        private void gridViewBancos_DoubleClick(object sender, EventArgs e)
        {
            if (buttonSelect.Visibility == BarItemVisibility.Always)
            {
                Close();
            }else

            {
                activarEditar();
            }
        }

        private void activarEditar()
        {
            buttonEditar.Enabled = false;
            buttonNewContact.Enabled = false;
            buttonSave.Enabled = true;
            textEditDecricao.Enabled = true;
            Operation = TypeOperationForm.Edit;
            textEditDecricao.Text = string.Empty;
        }
        private void activarNovo()
        {
            buttonEditar.Enabled = false;
            buttonNewContact.Enabled = false;
            buttonSave.Enabled = true;
            Operation = TypeOperationForm.Create;
            textEditDecricao.Enabled = true;
            textEditDecricao.Text = string.Empty;
        }
        public override Banco GetEntity()
        {
            buttonSelect.Visibility = BarItemVisibility.Always;
            return base.GetEntity();
        }
        private bool temCerteza()
        {
            var result = MessageBox.Show(
                "Tem certeza que pretende eliminar está Linha de registro",
                "QUESTÃO",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question
            );

            return result == DialogResult.Yes;
        }
    }
}