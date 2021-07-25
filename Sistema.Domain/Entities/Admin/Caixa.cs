namespace Sistema.Domain.Entities.Admin
{
    public class Caixa
    {
        public int CaixaId { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
