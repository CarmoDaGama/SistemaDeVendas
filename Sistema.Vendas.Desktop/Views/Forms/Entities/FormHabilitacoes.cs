using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Sistema.Application.FormsBase;
using Sistema.Application.Interfaces.Entity;
using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Enuns_Entities;

namespace Sistema.Vendas.Desktop.Views.Forms.Entities
{
    public partial class FormHabilitacoes : /*RibbonForm*/ FormBaseList<Habilitacao>
    {
        public int HabilitacaoId { get; private set; }

        public FormHabilitacoes(HabilitacaoApp app):base(app)
        {
            InitializeComponent();
        }

        public override Habilitacao GetEntity()
        {
            buttonSelectHabilitacao.Visibility = BarItemVisibility.Always;
            return base.GetEntity();
        }
        private void buttonSelectHabiltacao_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void buttonNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            Operation = TypeOperationForm.Create;
            buttonSave.Enabled = true;
            buttonNew.Enabled = false;
            buttonUpdate.Enabled = false;
            textEditDescricao.Enabled = true;
            textEditDescricao.Text = string.Empty;
        }

        private void buttonUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            buttonSave.Enabled = true;
            buttonNew.Enabled = false;
            buttonUpdate.Enabled = false;
            textEditDescricao.Enabled = true;
            if (IndexIsSelected())
            {
                messageBoxShow("Selecione uma linha de registro!");
                return;
            }
            Operation = TypeOperationForm.Edit;
            textEditDescricao.Text = Entities[Index].Descricao;
            HabilitacaoId = Entities[Index].HabilitacaoId;
        }

        private void buttonSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            buttonSave.Enabled = false;
            buttonNew.Enabled = true;
            buttonUpdate.Enabled = true;
            textEditDescricao.Enabled = false;
            if (Operation == TypeOperationForm.Create)
            {
                App.Insert(new Habilitacao() { Descricao = textEditDescricao.Text });
            }
            else if(Operation == TypeOperationForm.Edit)
            {
                App.Update(new Habilitacao() {
                    HabilitacaoId = HabilitacaoId,
                    Descricao = textEditDescricao.Text
                });
            }
            loadList();
            HabilitacaoId = 0;

        }

        private void buttonRemover_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            DeleleEntity();
        }
        protected override void loadList()
        {
            base.loadList();
            gridControlHabilitacoes.DataSource = Entities;
        }

        private void gridViewHabilitacoes_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            Index = e.RowHandle;
        }

        private void FormHabilitacoes_Load(object sender, System.EventArgs e)
        {
            loadList();
        }
    }
}