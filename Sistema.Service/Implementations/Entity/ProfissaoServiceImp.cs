using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Repository.Entity;
using Sistema.Domain.Interfaces.Service.Entity;

namespace Sistema.Service.Implementations.Entity
{
    public class ProfissaoServiceImp : ServiceBaseImp<Profissao>, ProfissaoService
    {
        private readonly ProfissaoRepository _Repository;
        public ProfissaoServiceImp(ProfissaoRepository repository) : base(repository)
        {
            _Repository = repository;
        }
    }
}
