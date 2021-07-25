using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Repository.Entity;
using Sistema.Domain.Interfaces.Service.Entity;

namespace Sistema.Service.Implementations.Entity
{
    public class TipoDocumentoEntidadeServiceImp : ServiceBaseImp<TipoDocumentoEntidade>, TipoDocumentoEntidadeService
    {
        private readonly TipoDocumentoEntidadeRepository _Repository;
        public TipoDocumentoEntidadeServiceImp(TipoDocumentoEntidadeRepository repository):base(repository)
        {
            _Repository = repository;
        }
    }
}
