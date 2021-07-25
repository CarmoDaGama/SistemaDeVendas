using System;
using System.Collections.Generic;
using Sistema.Application.Interfaces.Entity;
using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Service.Entity;

namespace Sistema.Application.Implementations.Entity
{
     public class ContactoAppImp : AppBaseImp<Contacto>, ContactoApp
    {
        private readonly ContactoService _Service;

        public ContactoAppImp(ContactoService repository):base(repository)
        {
            _Service = repository;
        }

        public List<Contacto> GetEntities(int entidadeId)
        {
            return _Service.GetEntities(entidadeId);
        }
    }
}
