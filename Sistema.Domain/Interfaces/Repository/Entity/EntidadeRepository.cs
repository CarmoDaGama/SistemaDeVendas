using Sistema.Domain.Entities.Entity;

namespace Sistema.Domain.Interfaces.Repository.Entity
{
    public interface EntidadeRepository : RepositoryBase<Entidade>
    {
        int GetLastCode();
    }
}
