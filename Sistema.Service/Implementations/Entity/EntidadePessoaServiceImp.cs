using System;
using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Repository.Entity;
using Sistema.Domain.Interfaces.Service.Entity;

namespace Sistema.Service.Implementations.Entity
{
    public class EntidadePessoaServiceImp : ServiceBaseImp<EntidadePessoa>, EntidadePessoaService
    {
        private readonly EntidadePessoaRepository _Repository;

        public EntidadePessoaServiceImp(EntidadePessoaRepository repository): base(repository)
        {
            _Repository = repository;
        }

        public int GetLastCode()
        {
            return _Repository.GetLastCode();
        }
    }
}
