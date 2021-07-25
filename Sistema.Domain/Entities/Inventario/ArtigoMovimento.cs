using Sistema.Domain.Entities.Documentos;
using System;

namespace Sistema.Domain.Entities.Inventario
{
    public class ArtigoMovimento
    {
        public int ArtigoMovimentoId { get; set; }
        public int DocumentoId { get; set; }
        public Documento Documento { get; set; }
        public int ArtigoInventarioId { get; set; }
        public ArtigoInventario Artigo { get; set; }
        public decimal Preco { get; set; }
        public decimal Qtd { get; set; }
        public decimal Desconto { get; set; }
        public decimal Imposto { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
