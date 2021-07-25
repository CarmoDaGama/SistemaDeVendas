using Sistema.Domain.Entities.Financeiro;
using System.Collections.Generic;

namespace Sistema.Domain.Interfaces.Repository.Financeiro
{
    public interface ContaBancariaRepository : RepositoryBase<ContaBancaria>
    {
        List<ContaBancaria> GetContasDaEntidade(int entidadeId);
    }
}
