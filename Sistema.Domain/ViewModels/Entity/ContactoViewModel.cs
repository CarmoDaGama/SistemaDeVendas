using Sistema.Domain.Entities.Entity;

namespace Sistema.Domain.ViewModels.Entity
{
    public class ContactoViewModel
    {
        public ContactoViewModel()
        {
            Entidade = new Entidade();
            Tipo = new TipoContacto();
        }
        public int ContactoId { get; set; }
        public string Descricao { get; set; }
        public int EntidadeId { get; set; }
        public Entidade Entidade { get; set; }
        public string NomeEntidade { get { return Equals(Entidade, null)? string.Empty : Entidade.Nome; } }
        public int TipoContactoId { get; set; }
        public TipoContacto Tipo { get; set; }
        public string NomeTipo { get { return Equals(Tipo, null) ? string.Empty : Tipo.Descricao; } }
    }
}
