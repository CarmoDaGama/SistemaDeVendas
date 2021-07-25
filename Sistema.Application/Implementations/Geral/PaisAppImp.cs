using Sistema.Application.Interfaces.Geral;
using Sistema.Domain.Entities.GeralEntity;
using Sistema.Domain.Interfaces.Service.Geral;

namespace Sistema.Application.Implementations.Geral
{
    public class PaisAppImp : AppBaseImp<Pais>, PaisApp
    {
        private readonly PaisService _App;
        public PaisAppImp(PaisService app):base(app)
        {
            _App = app;
        }
    }
}
