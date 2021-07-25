namespace Sistema.Domain.Entities.Inventario
{
    public class ArtigoIntegracao
    {
        public int ArtigoIntegracaoId { get; set; }
        public int ArtigoId { get; set; }
        public Artigo Artigo { get; set; }
        public int ArtigoIntegranteId { get; set; }
        public ArtigoIntegrante ArtigoIntegrante { get; set; }
    }
}
