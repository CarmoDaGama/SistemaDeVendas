using System;
using DevExpress.XtraBars.Navigation;
using Sistema.Vendas.Desktop.Views.Forms.Gerais;
using Sistema.Vendas.Desktop.Views.Forms.Financeiros;
using Sistema.Framework;
using Sistema.Domain.Entities.Entity;
using Sistema.Application.Interfaces.Entity;
using DevExpress.XtraBars.Ribbon;
using Sistema.Domain.Enuns_Entities;
using DevExpress.XtraBars;
using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Grid;
using Sistema.Domain.Entities.Financeiro;
using Sistema.Application.Interfaces.Financeiro;
using Sistema.Domain.ViewModels.Financeiro;
using Sistema.Domain.ViewModels.Entity;

namespace Sistema.Vendas.Desktop.Views.Forms.Entities
{
    public partial class FormSaveEntity : RibbonForm
    {
        private readonly EntidadeApp App;
        private readonly EntidadePessoaApp PessoaApp;
        private readonly ContactoApp _ContactoApp;
        private readonly ContaBancariaApp _ContaApp;
        private bool Changed { get; set; }

        public TypeOperationForm Operation { get; set; } = TypeOperationForm.Create;
        private Entidade ThisEntity { get; set; }
        private EntidadePessoa EntityPerson { get; set; }
        public int IndexContactos { get; set; }
        public int IndexDocumentos { get; set; }
        public int IndexContas { get; set; }
        public int IndexLocalidades { get; set; }

        public FormSaveEntity(
            EntidadeApp app, 
            EntidadePessoaApp pessoaApp, 
            ContactoApp contactoApp, 
            ContaBancariaApp contaApp)
        {
            InitializeComponent();
            App = app;
            PessoaApp = pessoaApp;
            _ContactoApp = contactoApp;
            _ContaApp = contaApp;
            ThisEntity = new Entidade();
            EntityPerson = new EntidadePessoa();
            dateEditNascimento.Properties.MaxValue = DateTime.Now;
        }

        private void accordionElementHome_Click(object sender, EventArgs e)
        {
            //var namePage = (sender as AccordionControlElement).Name.Replace("accordionElement","page");
            //navigationFrameDataEntity.SelectedPage = (NavigationPage)navigationFrameDataEntity.Controls[namePage];
            GenericTasks.MudarPageFrame(sender, navigationFrameDataEntity, "accordionElement");
        }

        private void buttonGetNacionalidade_Click(object sender, EventArgs e)
        {
            ThisEntity.Nacionalidade =  Injections.GetFormRegisted<FormPais>().GetEntity();
            ThisEntity.PaisId = ThisEntity.Nacionalidade.PaisId;
            textEditNacionalidae.Text = ThisEntity.Nacionalidade.Descricao;
        }

        private void buttonGetProficao_Click(object sender, EventArgs e)
        {
            EntityPerson.Profissao = Injections.GetFormRegisted<FormProfissoes>().GetEntity();
            EntityPerson.ProfissaoId = EntityPerson.Profissao.ProfissaoId;
            textEditProfissoes.Text = EntityPerson.Profissao.Descricao;
        }

        private void buttoGetHablitacao_Click(object sender, EventArgs e)
        {
            EntityPerson.Habilitacao = Injections.GetFormRegisted<FormHabilitacoes>().GetEntity();
            EntityPerson.HabilitacaoId = EntityPerson.Habilitacao.HabilitacaoId;
            textEditHabilitacao.Text = EntityPerson.Habilitacao.Descricao;
        }

        private void buttonAddContacto_Click(object sender, EventArgs e)
        {
            if (GenericTasks.IsNull(ThisEntity.Contactos))
            {
                ThisEntity.Contactos = new List<Contacto>();
            }
            ThisEntity.Contactos.Add(new FormAddContact().GetContacto());
            loadContactos();
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            if (GenericTasks.IsNull(ThisEntity.ContasBancarias))
            {
                ThisEntity.ContasBancarias = new List<ContaBancaria>();
            }
            var newConta = new FormAddContaBancaria().GetConta();
            if (!GenericTasks.IsNull(newConta))
            {
                ThisEntity.ContasBancarias.Add(newConta);
            }
            loadContas();

        }

        private void buttonAddDocument_Click(object sender, EventArgs e)
        {
            new FormAddDocumentoEntity().ShowDialog();
        }

        private void buttonAddLocalidade_Click(object sender, EventArgs e)
        {
            new FormAddLocalidade().ShowDialog();
        }

        private void buttonSaveEntidade_ItemClick(object sender, ItemClickEventArgs e)
        {
            removeControlsPerson();
            if (GenericTasks.ValuesIsValidInFields(panelFields.Controls))
            {
                pepularDodosDaEntidade();
                if (comboBoxEditTipo.SelectedIndex == (int)TypePerson.Pessoa)
                {
                    saveEntityPerson();
                }
                else if (comboBoxEditTipo.SelectedIndex == (int)TypePerson.Juridica)
                {
                    saveEntity();
                }
                saveDatasAdicionais();
                Operation = TypeOperationForm.Create;
                Changed = true;

            }
            addControlsPerson();
        }

        private void saveDatasAdicionais()
        {
            saveContactos();
            saveConta();
        }

        private void saveConta()
        {
            foreach (var item in ThisEntity.ContasBancarias)
            {
                item.EntidadeId = ThisEntity.EntidadeId;
                if (item.ContaBancariaId <= 0)
                {
                    _ContaApp.Insert(item);
                }
                else
                {
                    _ContaApp.Update(item);
                }
            }
        }

        private void saveContactos()
        {
            foreach (var item in ThisEntity.Contactos)
            {
                item.EntidadeId = ThisEntity.EntidadeId;
                if (item.ContactoId <= 0)
                {
                    _ContactoApp.Insert(item);
                }
                else
                {
                    _ContactoApp.Update(item);
                }
            }
        }

        private void removeControlsPerson()
        {
            if (comboBoxEditTipo.SelectedIndex == 1)
            {
                panelFields.Controls.Remove(textEditNomePai);
                panelFields.Controls.Remove(textEditNomeMae);
                panelFields.Controls.Remove(buttoGetHablitacao);
                panelFields.Controls.Remove(buttonGetProficao);
                panelFields.Controls.Remove(comboBoxEditSexo);
                panelFields.Controls.Remove(comboBoxEditEstadoCivil);
                panelFields.Controls.Remove(dateEditNascimento);
                panelFields.Controls.Remove(textEditHabilitacao);
                panelFields.Controls.Remove(textEditProfissoes);
            }
        }
        private void addControlsPerson()
        {
            if (panelFields.Controls.Count == 17)
            {
                panelFields.Controls.Add(textEditNomePai);
                panelFields.Controls.Add(textEditNomeMae);
                panelFields.Controls.Add(buttoGetHablitacao);
                panelFields.Controls.Add(buttonGetProficao);
                panelFields.Controls.Add(comboBoxEditSexo);
                panelFields.Controls.Add(comboBoxEditEstadoCivil);
                panelFields.Controls.Add(dateEditNascimento);
                panelFields.Controls.Add(textEditHabilitacao);
                panelFields.Controls.Add(textEditProfissoes);
            }
        }
        private void saveEntity()
        {
            if (Operation == TypeOperationForm.Create)
            {
                App.Insert(ThisEntity);
                ThisEntity.EntidadeId = App.GetLastCode();
                Operation = TypeOperationForm.Edit;
            }
            else if(Operation == TypeOperationForm.Edit)
            {
                App.Update(ThisEntity);
            }
        }
        private void saveEntityPerson()
        {
            if (Operation == TypeOperationForm.Create)
            {
                saveEntity(); 
                popularDadosDaEntidadePessoa(ThisEntity.EntidadeId);
                PessoaApp.Insert(EntityPerson);
                EntityPerson.EntidadePessoaId = PessoaApp.GetLastCode();
                Operation = TypeOperationForm.Edit;
            }
            else if (Operation == TypeOperationForm.Edit)
            {
                saveEntity();
                popularDadosDaEntidadePessoa(ThisEntity.EntidadeId);
                PessoaApp.Update(EntityPerson);
            }
        }
        private void popularDadosDaEntidadePessoa(int newEntidadeId)
        {
            EntityPerson.EntidadeId = newEntidadeId;
            EntityPerson.EntadoCivil = getEstadoCivil(comboBoxEditEstadoCivil.SelectedIndex);
            EntityPerson.DataNascimento = Convert.ToDateTime(dateEditNascimento.EditValue);
            EntityPerson.NomeMae = textEditNomeMae.Text;
            EntityPerson.NomePai = textEditNomePai.Text;
            EntityPerson.Sexo = comboBoxEditSexo.SelectedIndex == 0 ? TypeSexo.Masculino : TypeSexo.Femenino;
        }
        private TypeEstadoCivil getEstadoCivil(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0: return TypeEstadoCivil.Solteiro;
                case 1: return TypeEstadoCivil.Casado;
                case 2: return TypeEstadoCivil.Divorciado;
                case 3: return TypeEstadoCivil.Viuvo;
                default:
                    return TypeEstadoCivil.Solteiro;
            }
        }
        private void pepularDodosDaEntidade()
        {
            ThisEntity.Nome = textEditNome.Text;
            ThisEntity.DebitoLimite = decimal.Parse(textEditDebitoLimite.Text);
            ThisEntity.Imagem = ImagemUtils.ConvertImagemParaArrayByte(pictureEditImageEntity.Image);
            
        }
        public bool UpdateEntity(EntidadePessoa entidade, TypePerson Tipo)
        {
            Changed = false;
            Operation = TypeOperationForm.Edit;
            comboBoxEditTipo.SelectedIndex = (int)Tipo;
            SetEntities(entidade);
            ShowDialog();
            return Changed;

        }
        public bool ShowSaveNewEntity()
        {
            Changed = false;
            ShowDialog();
            return Changed;
        }
        private void SetEntities(EntidadePessoa pessoa)
        {
            EntityPerson = null;
            EntityPerson = pessoa;
            if (pessoa.EntidadePessoaId > 0)
            {
                setFieldControlsOfPessoa();
            }
            SetThisEntity(pessoa.Entidade);
        }

        private void setFieldControlsOfPessoa()
        {
            textEditNomePai.Text = EntityPerson.NomePai;
            textEditNomeMae.Text = EntityPerson.NomeMae;
            textEditProfissoes.Text = EntityPerson.Profissao.Descricao;
            textEditHabilitacao.Text = EntityPerson.Habilitacao.Descricao;
            comboBoxEditSexo.SelectedIndex = (int)EntityPerson.Sexo;
            comboBoxEditEstadoCivil.SelectedIndex = (int)EntityPerson.EntadoCivil;
            dateEditNascimento.EditValue = EntityPerson.DataNascimento.ToShortDateString();
        }

        private void SetThisEntity(Entidade entidade)
        {
            ThisEntity = null;
            ThisEntity = entidade;
            GetDatasAdicionais();
            setFieldControlsOfEntity();
        }

        private void GetDatasAdicionais()
        {
            GetContactos();
            GetContas();
        }

        private void GetContas()
        {
            ThisEntity.ContasBancarias = _ContaApp.GetContasDaEntidade(ThisEntity.EntidadeId);
        }

        private void GetContactos()
        {
            ThisEntity.Contactos = _ContactoApp.GetEntities(ThisEntity.EntidadeId);
        }

        private void setFieldControlsOfEntity()
        {
            textEditNome.Text = ThisEntity.Nome;
            textEditNacionalidae.Text = ThisEntity.Nacionalidade.Descricao;
            textEditDebitoLimite.Text = ThisEntity.DebitoLimite.ToString("N2");
            pictureEditImageEntity.Image = ImagemUtils.ConvertArrayByteParaImagem(ThisEntity.Imagem);
            loadContactos();
            loadContas();
        }

        private void buttonSaveClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            buttonSaveEntidade_ItemClick(sender, e);
            if(Changed)
                Close();
        }

        private void comboBoxEditTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEditTipo.SelectedIndex == 0)
            {
                textEditNomePai.Enabled = true;
                textEditNomeMae.Enabled = true;
                buttoGetHablitacao.Enabled = true;
                buttonGetProficao.Enabled = true;
                comboBoxEditSexo.Enabled = true;
                comboBoxEditEstadoCivil.Enabled = true;
                dateEditNascimento.Enabled = true;
            }
            else if (comboBoxEditTipo.SelectedIndex == 1)
            {
                textEditNomePai.Enabled = false;
                textEditNomeMae.Enabled = false;
                buttoGetHablitacao.Enabled = false;
                buttonGetProficao.Enabled = false;
                comboBoxEditSexo.Enabled = false;
                comboBoxEditEstadoCivil.Enabled = false;
                dateEditNascimento.Enabled = false;
            }
        }
        
        private void FormSaveEntity_MouseEnter(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                panelBottom.Controls.Add(pageDocumentos);
            }

            if (WindowState == FormWindowState.Normal)
            {
                panelBottom.Controls.Remove(navigationFrameDataEntity);
            }
        }

        private void gridView_RowClick(object sender, RowClickEventArgs e)
        {
            setIndexGrid(sender, e.RowHandle);
        }

        private void gridView_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            setIndexGrid(sender, e.RowHandle);
        }

        private void setIndexGrid(object sender, int rowHandle)
        {
            var gridClick = (GridView)sender;
            var gridName = gridClick.Name.Replace("gridView", string.Empty);
            GetType().GetProperty("Index" + gridName).SetValue(this, rowHandle);
        }

        private void gridViewContactos_DoubleClick(object sender, EventArgs e)
        {
            if (GenericTasks.IsValidList(ThisEntity.Contactos))
            {
                Contacto newContact = new FormAddContact().EditarContacto(ThisEntity.Contactos[IndexContactos]);
                ThisEntity.Contactos[IndexContactos] = newContact;
                loadContactos();
            }
        }

        private void buttonRemoveContact_Click(object sender, EventArgs e)
        {
            if (GenericTasks.IsValidList(ThisEntity.Contactos) && temCerteza())
            {
                if (ThisEntity.Contactos[IndexContactos].ContactoId > 0)
                {
                    _ContactoApp.Delete(ThisEntity.Contactos[IndexContactos]);
                }
                ThisEntity.Contactos.RemoveAt(IndexContactos);
                loadContactos();
            }
        }

        private void loadContactos()
        {
            gridControlContactos.DataSource = null;
            gridControlContactos.DataSource = Mapper<Contacto, ContactoViewModel>.MapearListEntity(ThisEntity.Contactos);
            IndexContactos = 0;
        }

        private bool temCerteza()
        {
            var result = MessageBox.Show(
                "Tem certeza que pretende elimnar esta linha de registro!",
                "QUESTÃO",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private void gridViewContas_DoubleClick(object sender, EventArgs e)
        {
            if (GenericTasks.IsValidList(ThisEntity.Contactos))
            {
                ContaBancaria newConta = new FormAddContaBancaria().EditarConta(ThisEntity.ContasBancarias[IndexContas]);
                ThisEntity.ContasBancarias[IndexContas] = newConta;
                loadContas();
            }
        }
        private void loadContas()
        {
            gridControlContas.DataSource = null;
            gridControlContas.DataSource = Mapper<
                ContaBancaria, ContaBancariaViewModel>.MapearListEntity(ThisEntity.ContasBancarias);
            IndexContas = 0;
        }

        private void buttonRemoveAccount_Click(object sender, EventArgs e)
        {
            if (GenericTasks.IsValidList(ThisEntity.ContasBancarias) && temCerteza())
            {
                if (ThisEntity.ContasBancarias[IndexContactos].ContaBancariaId > 0)
                {
                    _ContaApp.Delete(ThisEntity.ContasBancarias[IndexContactos]);
                }
                ThisEntity.ContasBancarias.RemoveAt(IndexContas);
                loadContas();
            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}