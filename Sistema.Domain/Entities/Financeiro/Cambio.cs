namespace Sistema.Domain.Entities.Financeiro
{
    public class Cambio
    {
        public int CambioId { get; set; }
        public decimal ValorCambio { get; set; }
        public int MoedaId { get; set; }
        public Moeda MoedaPretendida { get; set; }

    }
}
