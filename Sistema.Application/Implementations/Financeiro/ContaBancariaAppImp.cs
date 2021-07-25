using System;
using System.Collections.Generic;
using Sistema.Application.Interfaces.Financeiro;
using Sistema.Domain.Entities.Financeiro;
using Sistema.Domain.Interfaces.Service.Financeiro;

namespace Sistema.Application.Implementations.Financeiro
{
    public class ContaBancariaAppImp : AppBaseImp<ContaBancaria>, ContaBancariaApp
    {
        private readonly ContaBancariaService _service;

        public ContaBancariaAppImp(ContaBancariaService service): base(service)
        {
            _service = service;
        }

        public List<ContaBancaria> GetContasDaEntidade(int entidadeId)
        {
            return _service.GetContasDaEntidade(entidadeId);
        }
    }
}
