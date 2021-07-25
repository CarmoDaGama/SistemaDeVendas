using System;
using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Repository.Entity;
using Sistema.Domain.Interfaces.Service.Entity;

namespace Sistema.Service.Implementations.Entity
{
    public class EntidadeServiceImp : ServiceBaseImp<Entidade>, EntidadeService
    {
        private readonly EntidadeRepository _Repository;
        public EntidadeServiceImp(EntidadeRepository repository) : base(repository)
        {
            _Repository = repository;
        }

        public int GetLastCode()
        {
            return _Repository.GetLastCode();
        }
    }
}
