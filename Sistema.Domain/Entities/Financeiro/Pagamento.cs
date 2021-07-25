using Sistema.Domain.Entities.Admin;
using Sistema.Domain.Entities.Documentos;
using System;

namespace Sistema.Domain.Entities.Financeiro
{
    public class Pagamento
    {
        public int PagamentoId { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento Forma { get; set; }
        public int DocumentoId { get; set; }
        public Documento Documento { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public int MoedaId { get; set; }
        public Moeda Moeda { get; set; }
        public int CambioId { get; set; }
        public Cambio Cambio { get; set; }
        public int CaixaId { get; set; }
        public Caixa Caixa { get; set; }
        public int ContaBancariaId { get; set; }
        public ContaBancaria Conta { get; set; }
    }
}
