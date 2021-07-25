using Sistema.Application.Interfaces.Entity;
using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Repository.Entity;
using Sistema.Domain.Interfaces.Service.Entity;

namespace Sistema.Application.Implementations.Entity
{
    public class HabilitacaoAppImp : AppBaseImp<Habilitacao>, HabilitacaoApp
    {
        private readonly HabilitacaoService _Repository;
        public HabilitacaoAppImp(HabilitacaoService repository):base(repository)
        {
            _Repository = repository;
        }
    }
}
