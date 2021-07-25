using Sistema.Domain.Entities.Inventario;

namespace Sistema.Domain.Entities.Entity
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }
        public int EntidadeId { get; set; }
        public Entidade Entidade { get; set; }
        public int ArtigoId { get; set; }
        public Artigo Artigo { get; set; }
    }
}
