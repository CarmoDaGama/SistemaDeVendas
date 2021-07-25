using Sistema.Domain.Entities.Entity;

namespace Sistema.Domain.Entities.Admin
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public int PerfilId { get; set; }
        public Perfil Perfil { get; set; }
        public int EntidadeId { get; set; }
        public Entidade Entidade { get; set; }
    }
}
