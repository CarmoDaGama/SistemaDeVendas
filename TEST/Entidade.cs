namespace TEST
{
    public class Entidade
    {
        [Chave(AutoIncremente = true, Unico = true)]
        public int EntidadeId { get; set; }
        public string Nome { get; set; }
        public int PaisId { get; set; }
        public Pais Pais { get; set; }
    }
}