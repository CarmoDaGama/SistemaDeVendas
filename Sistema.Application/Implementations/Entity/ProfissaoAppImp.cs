using Sistema.Application.Interfaces.Entity;
using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Service.Entity;

namespace Sistema.Application.Implementations.Entity
{
    public class ProfissaoAppImp : AppBaseImp<Profissao>, ProfissaoApp
    {
        private readonly ProfissaoService _Repository;
        public ProfissaoAppImp(ProfissaoService repository) : base(repository)
        {
            _Repository = repository;
        }
    }
}
