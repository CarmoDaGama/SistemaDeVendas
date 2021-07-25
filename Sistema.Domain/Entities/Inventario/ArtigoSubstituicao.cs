namespace Sistema.Domain.Entities.Inventario
{
    public class ArtigoSubstituicao
    {
        public int ArtigosubstituicaoId { get; set; }
        public int ArtigoId { get; set; }
        public Artigo Artigo { get; set; }
        public int ArtigoSubstitutoId { get; set; }
        public ArtigoSubstituto ArtigoSubstituto { get; set; }
    }
}
