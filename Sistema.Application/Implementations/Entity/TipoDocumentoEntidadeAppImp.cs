using Sistema.Application.Interfaces.Entity;
using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Service.Entity;

namespace Sistema.Application.Implementations.Entity
{
    public class TipoDocumentoEntidadeAppImp : AppBaseImp<TipoDocumentoEntidade>, TipoDocumentoEntidadeApp
    {
        private readonly TipoDocumentoEntidadeService _Repository;
        public TipoDocumentoEntidadeAppImp(TipoDocumentoEntidadeService repository):base(repository)
        {
            _Repository = repository;
        }
    }
}
