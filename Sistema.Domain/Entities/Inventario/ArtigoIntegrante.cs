using System;

namespace Sistema.Domain.Entities.Inventario
{
    public class ArtigoIntegrante
    {
        public int ArtigoIntegranteId { get; set; }
        public string Nome { get; set; }
        public string Taxa { get; set; }
        public string CodigoBarra { get; set; }
        public byte[] Imagem { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public bool MovimentaInventario { get; set; }
        public bool Vender { get; set; }
        public bool Enabled { get; set; }
        public decimal Custo { get; set; }
        public decimal Preco { get; set; }
        public decimal Imposto { get; set; }
        public DateTime DataFabrico { get; set; }
        public DateTime DataValidade { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
