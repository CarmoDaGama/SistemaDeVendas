using Sistema.Domain.Entities.Entity;

namespace Sistema.Domain.Interfaces.Repository.Entity
{
    public interface EntidadePessoaRepository : RepositoryBase<EntidadePessoa>
    {
        int GetLastCode();
    }
}
