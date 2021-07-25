using System;
using System.Collections.Generic;
using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Repository.Entity;
using Sistema.Domain.Interfaces.Service.Entity;

namespace Sistema.Service.Implementations.Entity
{
     public class ContactoServiceImp : ServiceBaseImp<Contacto>, ContactoService
    {
        private readonly ContactoRepository _Repository;

        public ContactoServiceImp(ContactoRepository repository):base(repository)
        {
            _Repository = repository;
        }

        public List<Contacto> GetEntities(int entidadeId)
        {
            return _Repository.GetEntities(entidadeId);
        }
    }
}
