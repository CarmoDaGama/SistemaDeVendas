namespace Sistema.Domain.Entities.Entity
{
    public class Contacto
    {
        public int ContactoId { get; set; }
        public string Descricao { get; set; }
        public int EntidadeId { get; set; }
        public Entidade Entidade { get; set; }
        public int TipoContactoId { get; set; }
        public TipoContacto Tipo { get; set; } 
    }
}
