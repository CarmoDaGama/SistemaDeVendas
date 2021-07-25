namespace Sistema.Domain.Entities.Entity
{
    public class Localidade
    {
        public int LocalidadeId { get; set; }
        public string Descricao { get; set; }
        public int EntidadeId { get; set; }
        public Entidade Entidade { get; set; }
    }
}
