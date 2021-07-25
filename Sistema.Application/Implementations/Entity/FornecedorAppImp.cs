using Sistema.Application.Interfaces.Entity;
using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Service.Entity;

namespace Sistema.Application.Implementations.Entity
{
    public class FornecedorAppImp : AppBaseImp<Fornecedor>, FornecedorApp
    {
        private readonly FornecedorService _Repository;
        public FornecedorAppImp(FornecedorService repository):base(repository)
        {
            _Repository = repository;
        }
    }
}
