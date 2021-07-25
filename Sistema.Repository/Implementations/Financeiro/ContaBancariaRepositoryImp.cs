using System;
using System.Collections.Generic;
using Sistema.Domain.Entities.Financeiro;
using Sistema.Domain.Interfaces.Repository.Financeiro;
using Costum.DbEntity;

namespace Sistema.Repository.Implementations.Financeiro
{
    public class ContaBancariaRepositoryImp : RepositoryBaseImp<ContaBancaria>, ContaBancariaRepository
    {
        public List<ContaBancaria> GetContasDaEntidade(int entidadeId)
        {
            var criterio = new Criterio<ContaBancaria>("").Where(new { EntidadeId = entidadeId }, TipoJionCriterio.AND, TipoOperador.Igual);
            return Db.Set<ContaBancaria>().GetAllFor(criterio);
        }
    }
}
