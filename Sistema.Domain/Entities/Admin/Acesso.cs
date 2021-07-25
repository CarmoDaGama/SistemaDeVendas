using Sistema.Domain.Enuns_Entities;

namespace Sistema.Domain.Entities.Admin
{
    public class Acesso
    {
        public int AcessoId { get; set; }
        public int Descricao { get; set; }
        public int AreaId { get; set; }
        public Area Area { get; set; }
        public OperacaoAcesso Operacao { get; set; }
        public int PerfilId { get; set; }
        public Perfil Perfil { get; set; }

        /*
            É necesseçario encontrar uma forma de registrar as permissões de Acesso,
            em que na qual não seja necessario mudar a estrutura das classes de dados
            Quando ouver uma nova forma de permição de dados como "permição do acesso
            a internet"
        */
    }
}
