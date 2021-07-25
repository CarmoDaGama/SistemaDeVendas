using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Repository.Entity;
using Costum.DbEntity;
using System.Linq;

namespace Sistema.Repository.Implementations.Entity
{
    public class EntidadePessoaRepositoryImp : RepositoryBaseImp<EntidadePessoa>, EntidadePessoaRepository
    {
        public int GetLastCode()
        {
            var criterio = new Criterio<EntidadePessoa>("").OrderBy(new { EntidadePessoaId = 0 });
            return Db.Set<EntidadePessoa>().GetAllFor(criterio).LastOrDefault().EntidadePessoaId;
        }
    }
}
