using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Repository.Entity;
using Sistema.Domain.Interfaces.Service.Entity;

namespace Sistema.Service.Implementations.Entity
{
    public class FornecedorServiceImp : ServiceBaseImp<Fornecedor>, FornecedorService
    {
        private readonly FornecedorRepository _Repository;
        public FornecedorServiceImp(FornecedorRepository repository):base(repository)
        {
            _Repository = repository;
        }
    }
}
