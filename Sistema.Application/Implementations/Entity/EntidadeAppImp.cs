using System;
using Sistema.Application.Interfaces.Entity;
using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Service.Entity;

namespace Sistema.Application.Implementations.Entity
{
    public class EntidadeAppImp : AppBaseImp<Entidade>, EntidadeApp
    {
        private readonly EntidadeService Service;
        public EntidadeAppImp(EntidadeService service) :base(service)
        {
            Service = service;
        }

        public int GetLastCode()
        {
            return Service.GetLastCode();
        }
    }
}
