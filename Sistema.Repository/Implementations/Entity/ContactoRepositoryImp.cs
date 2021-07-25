using System;
using System.Collections.Generic;
using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Repository.Entity;
using Costum.DbEntity;

namespace Sistema.Repository.Implementations.Entity
{
    public class ContactoRepositoryImp : RepositoryBaseImp<Contacto>, ContactoRepository
    {
        public List<Contacto> GetEntities(int entidadeId)
        {
            var criterio = new Criterio<Contacto>("").Where(new { EntidadeId = entidadeId }, TipoJionCriterio.AND, TipoOperador.Igual);
            return Db.Set<Contacto>().GetAllFor(criterio);
        }
    }
}
