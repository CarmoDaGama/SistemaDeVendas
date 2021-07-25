using Costum.DbEntity;
using Sistema.Domain.Entities;
using Sistema.Domain.Entities.Admin;
using Sistema.Domain.Entities.Documentos;
using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Entities.Financeiro;
using Sistema.Domain.Entities.GeralEntity;
using Sistema.Domain.Entities.Inventario;
using Sistema.Domain.Enuns_Entities;
using System;
using System.Collections.Generic;

namespace Sistema.Repository.Context
{
    public class DbContext : DbCostum
    {
        public DbContext(InfoConnection info) : base(info)
        {
            //inserirDadosIniciais();
        }

        private void inserirDadosIniciais()
        {
            //InserirDadosIniciais(new List<Pais>(){
            //    new Pais() {
            //        Descricao = "ANGOLA"
            //    }
            //});
            //InserirDadosIniciais(new List<Entidade>() {
            //    new Entidade()
            //    {
            //        Nome = "Administrador",
            //        DebitoLimite = 100000000.0m,
            //        TipoPessoa = TypePerson.Pessoa,
            //        PaisId = 1
            //    }
            //});
            //InserirDadosIniciais(new List<Profissao>()
            //{
            //    new Profissao()
            //    {
            //        Descricao = "Sem Profissão"
            //    }
            //});
            //InserirDadosIniciais(new List<Habilitacao>()
            //{
            //    new Habilitacao()
            //    {
            //        Descricao = "Sem Habilitação"
            //    }
            //});
            //InserirDadosIniciais(new List<EntidadePessoa>()
            //{
            //    new EntidadePessoa()
            //    {
            //        EntidadeId = 1,
            //        DataNascimento = DateTime.Now,
            //        HabilitacaoId = 1,
            //        NomeMae = "DESCONHECIDO",
            //        NomePai = "DESCONHECIDO",
            //        ProfissaoId = 1,
            //        Sexo = TypeSexo.Masculino,
            //        EntadoCivil = TypeEstadoCivil.Solteiro
            //    }
            //});
        }

        protected override void SetEntities()
        {
            base.SetEntities();

            AddSet<Pais>();
            AddSet<Entidade>();
            AddSet<Profissao>();
            AddSet<Habilitacao>();
            AddSet<EntidadePessoa>();
            AddSet<TipoDocumentoEntidade>();
            AddSet<DocumentoEntidade>();
            AddSet<TipoContacto>();
            AddSet<Contacto>();
            AddSet<Localidade>();
            AddSet<TipoCategoria>();
            AddSet<Categoria>();
            AddSet<Imposto>();
            AddSet<MotivoIsencaoImposto>();
            AddSet<Artigo>();
            AddSet<Operacao>();
            AddSet<Area>();
            AddSet<Perfil>();
            AddSet<Usuario>();
            AddSet<Caixa>();
            AddSet<Turno>();
            AddSet<Acesso>();
            AddSet<Documento>();
            AddSet<Armazem>();
            AddSet<ArtigoInventario>();
            AddSet<ArtigoMovimento>();
            AddSet<ArtigoIntegrante>();
            AddSet<ArtigoIntegracao>();
            AddSet<ArtigoSubstituto>();
            AddSet<ArtigoSubstituicao>();
            AddSet<Fornecedor>();
            AddSet<Banco>();
            AddSet<Moeda>();
            AddSet<Cambio>();
            AddSet<ContaBancaria>();
            AddSet<FormaPagamento>();
            AddSet<Pagamento>();

        }
    }
}
