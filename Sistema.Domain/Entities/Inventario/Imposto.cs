namespace Sistema.Domain.Entities.Inventario
{
    public class Imposto
    {
        public int ImpostoId { get; set; }
        public int TipoImpostoId { get; set; }
        public TipoImposto TipoImposto { get; set; }
        public string Descricao { get; set; }
        public decimal Percentagem { get; set; } 
        public string CodigoImposto { get; set; }
    }
}
