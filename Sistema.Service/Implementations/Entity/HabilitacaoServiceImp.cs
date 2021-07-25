using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Repository.Entity;
using Sistema.Domain.Interfaces.Service.Entity;

namespace Sistema.Service.Implementations.Entity
{
    public class HabilitacaoServiceImp : ServiceBaseImp<Habilitacao>, HabilitacaoService
    {
        private readonly HabilitacaoRepository _Repository;
        public HabilitacaoServiceImp(HabilitacaoRepository repository):base(repository)
        {
            _Repository = repository;
        }
    }
}
