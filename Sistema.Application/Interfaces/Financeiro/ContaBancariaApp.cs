using System.Collections.Generic;
using Sistema.Domain.Entities.Financeiro;

namespace Sistema.Application.Interfaces.Financeiro
{
    public interface ContaBancariaApp : AppBase<ContaBancaria>
    {
        List<ContaBancaria> GetContasDaEntidade(int entidadeId);
    }
}
