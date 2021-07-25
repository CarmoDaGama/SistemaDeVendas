using System;
using System.Collections.Generic;
using System.Drawing;

namespace Sistema.Domain.Entities.Inventario
{
    public class Artigo
    {
        public int ArtigoId { get; set; }
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
        public int ImpostoId { get; set; }
        public Imposto Imposto { get; set; }
        public int MotivoIsencaoImpostoId { get; set; }
        public MotivoIsencaoImposto MotivoIsencaoImposto { get; set; }
        public DateTime DataFabrico { get; set; }
        public DateTime DataValidade { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<ArtigoIntegracao> ArtgosIntegrantes { get; set; }
        public List<ArtigoSubstituicao> ArtigosSubstitutos { get; set; }
        public List<ArtigoInventario> ArtigosInventarios { get; set; }

    }
}
