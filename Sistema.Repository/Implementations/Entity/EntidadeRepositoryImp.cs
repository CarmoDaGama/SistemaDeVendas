using Costum.DbEntity;
using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Repository.Entity;
using System.Linq;

namespace Sistema.Repository.Implementations.Entity
{
    public class EntidadeRepositoryImp : RepositoryBaseImp<Entidade>, EntidadeRepository
    {
        public EntidadeRepositoryImp() { }

        public int GetLastCode()
        {
            var criterio = new Criterio<Entidade>("").OrderBy(new { EntidadeId = string.Empty });
            return Db.Set<Entidade>().GetAllFor(criterio).LastOrDefault().EntidadeId;
        }
    }
}
