using Sistema.Domain.Entities.Admin;
using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Enuns_Entities;
using System;

namespace Sistema.Domain.Entities.Documentos
{
    public class Documento
    {
        public int DocumentoId { get; set; }
        public int TurnoId { get; set; }
        public Turno Turno { get; set; }
        public int EntidadeId { get; set; }
        public Entidade EntidadeDestino { get; set; }
        public int OperacaoId { get; set; }
        public Operacao Operacao { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int NumeroDeOrdem { get; set; }
        public string Mascara { get; set; }
        public StateDocument Estado { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal DescontoGeral { get; set; }
        public TipoEmicaoDocumento Emitido { get; set; }

    }
}
