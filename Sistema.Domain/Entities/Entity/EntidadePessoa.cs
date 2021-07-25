using Sistema.Domain.Enuns_Entities;
using System;

namespace Sistema.Domain.Entities.Entity
{
    public class EntidadePessoa
    {
        public int EntidadePessoaId { get; set; }
        public int EntidadeId { get; set; }
        public Entidade Entidade { get; set; }
        public TypeSexo Sexo { get; set; }
        public TypeEstadoCivil EntadoCivil { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public DateTime DataNascimento { get; set; }
        public int ProfissaoId { get; set; }
        public Profissao Profissao { get; set; }
        public int HabilitacaoId { get; set; }
        public Habilitacao Habilitacao { get; set; }


    }
}
