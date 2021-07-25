using Sistema.Domain.Entities.GeralEntity;
using Sistema.Domain.Interfaces.Repository.Geral;
using Sistema.Domain.Interfaces.Service.Geral;

namespace Sistema.Service.Implementations.Geral
{
    public class PaisServiceImp : ServiceBaseImp<Pais>, PaisService
    {
        private readonly PaisRepository _Repository;
        public PaisServiceImp(PaisRepository repository) : base(repository)
        {
            _Repository = repository;
        }
    }
}
