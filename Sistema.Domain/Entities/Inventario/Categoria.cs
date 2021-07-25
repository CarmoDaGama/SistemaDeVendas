namespace Sistema.Domain.Entities.Inventario
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public int TipoCategoriaId { get; set; }
        public TipoCategoria Tipo { get; set; }
    }
}