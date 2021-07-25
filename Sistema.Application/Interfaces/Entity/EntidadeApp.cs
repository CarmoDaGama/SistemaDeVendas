using Sistema.Domain.Entities.Entity;

namespace Sistema.Application.Interfaces.Entity
{
    public interface EntidadeApp : AppBase<Entidade>
    {
        int GetLastCode();
    }
}
