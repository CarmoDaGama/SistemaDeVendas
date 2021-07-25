using Sistema.Domain.Entities.Admin;
using Sistema.Domain.Enuns_Entities;

namespace Sistema.Domain.Entities.Financeiro
{
    public class FormaPagamento
    {
        public int FormaPagamentoId { get; set; }
        public string Descricao { get; set; }
        public int CaixaId { get; set; }
        public Caixa Caixa { get; set; }
        public int ContaBancariaId { get; set; }
        public ContaBancaria Conta  { get; set; }
        public TipoPagamento Forma { get; set; }
        
    }
}
