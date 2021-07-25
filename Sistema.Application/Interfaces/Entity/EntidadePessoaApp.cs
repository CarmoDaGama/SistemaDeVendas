using Sistema.Domain.Entities.Entity;

namespace Sistema.Application.Interfaces.Entity
{
    public interface EntidadePessoaApp : AppBase<EntidadePessoa>
    {
        EntidadePessoa GetByIdEntidade(int entidadeId);
        int GetLastCode();
    }
}
