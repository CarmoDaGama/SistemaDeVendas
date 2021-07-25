using Sistema.Application.Interfaces.Financeiro;
using Sistema.Domain.Entities.Financeiro;
using Sistema.Domain.Interfaces.Service.Financeiro;

namespace Sistema.Application.Implementations.Financeiro
{
    public class BancoAppImp : AppBaseImp<Banco>, BancoApp
    {
        private readonly BancoService _service;

        public BancoAppImp(BancoService service): base(service)
        {
            _service = service;
        }
    }
}
