namespace Sistema.Domain.Entities.Financeiro
{
    public class Moeda
    {
        public int MoedaId { get; set; }
        public string Descricao { get; set; }
        public string Sigla { get; set; }
        public bool MoedaPadrao { get; set; }
    }
}
