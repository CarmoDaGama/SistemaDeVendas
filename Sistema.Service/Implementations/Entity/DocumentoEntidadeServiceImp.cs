using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Repository.Entity;
using Sistema.Domain.Interfaces.Service.Entity;

namespace Sistema.Service.Implementations.Entity
{
    public class DocumentoEntidadeServiceImp : ServiceBaseImp<DocumentoEntidade>, DocumentoEntidadeService
    {
        private readonly DocumentoEntidadeRepository _Repository;
        public DocumentoEntidadeServiceImp(DocumentoEntidadeRepository repository):base(repository)
        {
            _Repository = repository;
        }
    }
}
