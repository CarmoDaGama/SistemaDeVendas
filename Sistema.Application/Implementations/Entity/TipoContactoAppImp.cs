using Sistema.Application.Interfaces.Entity;
using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Service.Entity;

namespace Sistema.Application.Implementations.Entity
{
    public class TipoContactoAppImp : AppBaseImp<TipoContacto>, TipoContactoApp
    {
        private readonly TipoContactoService _Repository;
        public TipoContactoAppImp(TipoContactoService repository):base(repository)
        {
            _Repository = repository;
        }
    }
}
