using DevExpress.XtraBars;
using Sistema.Domain.Entities.Entity;
using Sistema.Application.FormsBase;
using Sistema.Application.Interfaces.Entity;
using DevExpress.XtraBars.Ribbon;
using Sistema.Framework;
using Sistema.Domain.Enuns_Entities;
using System;
using DevExpress.XtraGrid.Views.Grid;

namespace Sistema.Vendas.Desktop.Views.Forms.Entities
{
    public partial class FormEntidades : /*RibbonForm*/FormBaseList<Entidade>
    {
        private readonly EntidadePessoaApp PessoaApp;

        public FormEntidades(EntidadeApp app, EntidadePessoaApp pessoaApp) : base(app)
        {
            InitializeComponent();
            PessoaApp = pessoaApp;
            gridColumn1.Visible = false;
        }

        private void buttonNewEntidade_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(Injections.GetFormRegisted<FormSaveEntity>().ShowSaveNewEntity())
                loadList();
        }
        protected override void loadList()
        {
            base.loadList();
            gridControlEntidades.DataSource = Entities;
        }
        private void buttonRemover_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleleEntity();
            gridControlEntidades.DataSource = null;
            gridControlEntidades.DataSource = Entities;
        }

        private void buttonSelectEntidade_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void buttonEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IndexIsSelected())
            {
                var pessao = PessoaApp.GetByIdEntidade(Entities[Index].EntidadeId);
                if (Equals(pessao, null))
                {
                    pessao = new EntidadePessoa() {
                        EntidadeId = Entities[Index].EntidadeId,
                        Entidade = Entities[Index]
                    };
                    if (Injections.GetFormRegisted<FormSaveEntity>().UpdateEntity(pessao, TypePerson.Juridica))
                    {
                        loadList();
                    }
                }
                else
                {
                    if (Injections.GetFormRegisted<FormSaveEntity>().UpdateEntity(pessao, TypePerson.Pessoa))
                    {
                        loadList();
                    }
                }
            }
        }

        private void gridViewEntidades_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            Index = e.RowHandle;
        }

        private void gridViewEntidades_DoubleClick(object sender, EventArgs e)
        {
            var pessao = PessoaApp.GetByIdEntidade(Entities[Index].EntidadeId);
            if (Equals(pessao, null))
            {
                pessao = new EntidadePessoa()
                {
                    EntidadeId = Entities[Index].EntidadeId,
                    Entidade = Entities[Index]
                };
                if (Injections.GetFormRegisted<FormSaveEntity>().UpdateEntity(pessao, TypePerson.Juridica))
                {
                    loadList();
                }
            }
            else
            {
                if (Injections.GetFormRegisted<FormSaveEntity>().UpdateEntity(pessao, TypePerson.Pessoa))
                {
                    loadList();
                }
            }
        }
    }
}