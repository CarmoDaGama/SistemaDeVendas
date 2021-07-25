using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Sistema.Application.FormsBase;
using Sistema.Domain.Entities.GeralEntity;
using Sistema.Application.Interfaces.Geral;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraBars.Ribbon;
using Sistema.Domain.Enuns_Entities;

namespace Sistema.Vendas.Desktop.Views.Forms.Gerais
{
    public partial class FormPais : /*RibbonForm*/ FormBaseList<Pais>
    {

        private bool Gravar { get; set; } = false;
        private int PaisId { get;  set; }

        public FormPais(PaisApp app):base(app)
        {
            InitializeComponent();
            loadList();
            textEditDescricao.Enabled = false;
            buttonGravar.Enabled = false;
        }
        
        private void buttonSelectPais_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void buttonGravar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Equals(textEditDescricao.Text, string.Empty))
            {
                MessageBox.Show(
                    "Preencha o campo Descrição", 
                    "Mensagem", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information
                );
                return;
            }
            if (Operation == TypeOperationForm.Create)
            {
                App.Insert(new Pais() { Descricao = textEditDescricao.Text });
            }
            else
            {
                App.Update(new Pais() { Descricao = textEditDescricao.Text, PaisId = PaisId });
            }
            loadList();
            Gravar = false;
            buttonGravar.Enabled = false;
            buttonNew.Enabled = true;
            buttonEdit.Enabled = true;
            textEditDescricao.Enabled = false;
        }
        protected override void loadList()
        {
            base.loadList();
            gridControlPaises.DataSource = Entities;
        }
        
        private void buttonNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            Operation = TypeOperationForm.Create;
            //textEditDescricao.Text = Entities[Index].Descricao;
            //PaisId = Entities[Index].PaisId;
            buttonGravar.Enabled = true;
            buttonNew.Enabled = false;
            buttonEdit.Enabled = false;
            textEditDescricao.Enabled = true;
        }

        private void buttonRemover_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IndexIsSelected())
            {
                DeleleEntity();
                loadList();
            }
        }

        private void gridViewPaises_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void gridViewPaises_RowClick(object sender, RowClickEventArgs e)
        {
            Index = e.RowHandle;
        }

        private void FormPais_Load(object sender, EventArgs e)
        {
            if (IsSelectOperation())
            {
                buttonSelectPais.Visibility = BarItemVisibility.Always;
            }
        }
        public override Pais GetEntity()
        {
            buttonSelectPais.Visibility = BarItemVisibility.Always;
            return base.GetEntity();
        }
        private void buttonEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IndexIsSelected())
            {
                messageBoxShow("Selecione uma linha de registro!");
                return;
            }
            Operation = TypeOperationForm.Edit;
            textEditDescricao.Text = Entities[Index].Descricao;
            PaisId = Entities[Index].PaisId;
            buttonGravar.Enabled = true;
            buttonNew.Enabled = false;
            buttonEdit.Enabled = false;
            textEditDescricao.Enabled = true;
        }
    }
}