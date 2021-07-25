using Sistema.Domain.Entities.Entity;

namespace Sistema.Domain.Interfaces.Service.Entity
{
    public interface EntidadePessoaService : ServiceBase<EntidadePessoa>
    {
        int GetLastCode();
    }
}
