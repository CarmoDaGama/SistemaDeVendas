using Sistema.Domain.Entities.Financeiro;
using Sistema.Domain.Interfaces.Repository.Financeiro;
using Sistema.Domain.Interfaces.Service.Financeiro;

namespace Sistema.Service.Implementations.Financeiro
{
    public class BancoServiceImp : ServiceBaseImp<Banco>, BancoService
    {
        private readonly BancoRepository _repository;

        public BancoServiceImp(BancoRepository repository):base(repository)
        {
            _repository = repository;
        }
    }
}
