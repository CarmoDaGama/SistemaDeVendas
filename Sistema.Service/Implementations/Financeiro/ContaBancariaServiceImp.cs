using Sistema.Domain.Entities.Financeiro;
using Sistema.Domain.Interfaces.Repository.Financeiro;
using Sistema.Domain.Interfaces.Service.Financeiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Service.Implementations.Financeiro
{
    public class ContaBancariaServiceImp : ServiceBaseImp<ContaBancaria>, ContaBancariaService
    {
        private readonly ContaBancariaRepository _repository;

        public ContaBancariaServiceImp(ContaBancariaRepository repository):base(repository)
        {
            _repository = repository;
        }

        public List<ContaBancaria> GetContasDaEntidade(int entidadeId)
        {
            return _repository.GetContasDaEntidade(entidadeId);
        }
    }
}
