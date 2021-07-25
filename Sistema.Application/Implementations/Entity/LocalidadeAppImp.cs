using Sistema.Application.Interfaces.Entity;
using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Repository.Entity;
using Sistema.Domain.Interfaces.Service.Entity;

namespace Sistema.Application.Implementations.Entity
{
    public class LocalidadeAppImp : AppBaseImp<Localidade>, LocalidadeApp
    {
        private readonly LocalidadeService _Repository;
        public LocalidadeAppImp(LocalidadeService repository):base(repository)
        {
            _Repository = repository;
        }
    }
}
