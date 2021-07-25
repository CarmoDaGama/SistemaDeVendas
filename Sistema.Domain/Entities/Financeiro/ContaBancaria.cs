

using Sistema.Domain.Entities.Entity;

namespace Sistema.Domain.Entities.Financeiro
{
    public class ContaBancaria
    {
        public int ContaBancariaId { get; set; }
        public string Numero { get; set; }
        public string Sequencia { get; set; }
        public string Swift { get; set; }
        public string Natureza { get; set; }
        public string Iban { get; set; }
        public int BancoId { get; set; }
        public Banco Banco { get; set; }
        public int EntidadeId { get; set; } 
        public Entidade Entidade { get; set; }
    }
}
