using Sistema.Domain.Entities.Financeiro;
using System.Collections.Generic;

namespace Sistema.Domain.Interfaces.Service.Financeiro
{
    public interface ContaBancariaService : ServiceBase<ContaBancaria>
    {
        List<ContaBancaria> GetContasDaEntidade(int entidadeId);
    }
}
