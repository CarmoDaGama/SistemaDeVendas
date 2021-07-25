using System;
using Sistema.Application.Interfaces.Entity;
using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Service.Entity;
using System.Linq;

namespace Sistema.Application.Implementations.Entity
{
    public class EntidadePessoaAppImp : AppBaseImp<EntidadePessoa>, EntidadePessoaApp
    {
        private readonly EntidadePessoaService _Service;

        public EntidadePessoaAppImp(EntidadePessoaService service): base(service)
        {
            _Service = service;
        }

        public EntidadePessoa GetByIdEntidade(int entidadeId)
        {
            return GetEntities().Where(e => e.EntidadeId == entidadeId).FirstOrDefault();
        }

        public int GetLastCode()
        {
            return _Service.GetLastCode();
        }
    }
}
