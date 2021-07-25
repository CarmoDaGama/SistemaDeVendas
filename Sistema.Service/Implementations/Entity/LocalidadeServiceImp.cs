using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Repository.Entity;
using Sistema.Domain.Interfaces.Service.Entity;

namespace Sistema.Service.Implementations.Entity
{
    public class LocalidadeServiceImp : ServiceBaseImp<Localidade>, LocalidadeService
    {
        private readonly LocalidadeRepository _Repository;
        public LocalidadeServiceImp(LocalidadeRepository repository):base(repository)
        {
            _Repository = repository;
        }
    }
}
