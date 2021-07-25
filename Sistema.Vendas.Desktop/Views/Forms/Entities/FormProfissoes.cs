using DevExpress.XtraBars;
using Sistema.Application.FormsBase;
using Sistema.Application.Interfaces.Entity;
using Sistema.Domain.Entities.Entity;

namespace Sistema.Vendas.Desktop.Views.Forms.Entities
{
    using DevExpress.XtraBars.Ribbon;
    using DevExpress.XtraGrid.Views.Grid;
    using Sistema.Domain.Enuns_Entities;
    public partial class FormProfissoes : /*RibbonForm*/FormBaseList<Profissao>
    {
        public int ProfissaoId { get; set; } 
        public FormProfissoes(ProfissaoApp app):base(app)
        {
            InitializeComponent();
        }
        public override Profissao GetEntity()
        {
            buttonSelectPais.Visibility = BarItemVisibility.Always;
            return base.GetEntity();
        }
        private void buttonSelectPais_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void buttonSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(textEditDescricao.Text))
            {
                messageBoxShow("Preencha O campo descrição!");
                return;
            }
            if (Operation == TypeOperationForm.Edit)
            {
                App.Update(new Profissao() { ProfissaoId = ProfissaoId, Descricao = textEditDescricao.Text });
            }
            else if(Operation == TypeOperationForm.Create)
            {
                App.Insert(new Profissao() { Descricao = textEditDescricao.Text });
            }
            buttonUpdate.Enabled = true;
            buttonNew.Enabled = true;
            buttonSave.Enabled = false;
            textEditDescricao.Enabled = false;
            loadList();
        }
        protected override void loadList()
        {
            base.loadList();
            gridControlProfissoes.DataSource = Entities;
        }
        private void buttonNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            Operation = TypeOperationForm.Create;
            textEditDescricao.Text = string.Empty;
            buttonUpdate.Enabled = false;
            buttonNew.Enabled = false;
            buttonSave.Enabled = true;
            textEditDescricao.Enabled = true;
        }

        private void buttonRemover_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleleEntity();
        }

        private void buttonUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!IndexIsSelected())
            {
                messageBoxShow("Selecione um registro!");
                return;
            }
            Operation = TypeOperationForm.Edit;
            textEditDescricao.Text = Entities[Index].Descricao;
            ProfissaoId = Entities[Index].ProfissaoId;
            buttonUpdate.Enabled = false;
            buttonNew.Enabled = false;
            textEditDescricao.Enabled = true;                        
        }
        private void FormProfissoes_Load(object sender, System.EventArgs e)
        {
            loadList();
        }

        private void gridViewProfissoes_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            Index = e.RowHandle;
        }
    }
}