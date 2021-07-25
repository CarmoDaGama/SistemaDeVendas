using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Repository.Entity;
using Sistema.Domain.Interfaces.Service.Entity;

namespace Sistema.Service.Implementations.Entity
{
    public class TipoContactoServiceImp : ServiceBaseImp<TipoContacto>, TipoContactoService
    {
        private readonly TipoContactoRepository _Repository;
        public TipoContactoServiceImp(TipoContactoRepository repository):base(repository)
        {
            _Repository = repository;
        }
    }
}
