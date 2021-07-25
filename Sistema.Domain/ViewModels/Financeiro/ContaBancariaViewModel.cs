using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Entities.Financeiro;

namespace Sistema.Domain.ViewModels.Financeiro
{
    public class ContaBancariaViewModel
    {
        public int ContaBancariaId { get; set; }
        public string Numero { get; set; }
        public string Sequencia { get; set; }
        public string Swift { get; set; }
        public string Natureza { get; set; }
        public string Iban { get; set; }
        public int BancoId { get; set; }
        public Banco Banco { get; set; }
        public string NameBank { get { return Equals(Banco, null) ? string.Empty : Banco.Dercricao; } }
        public int EntidadeId { get; set; }
        public Entidade Entidade { get; set; }
    }
}
