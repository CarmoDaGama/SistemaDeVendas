using Sistema.Domain.Entities.Entity;

namespace Sistema.Domain.Interfaces.Service.Entity
{
    public interface EntidadeService : ServiceBase<Entidade>
    {
        int GetLastCode();
    }
}
