using Sistema.Application.Interfaces.Entity;
using Sistema.Domain.Entities.Entity;
using Sistema.Domain.Interfaces.Service.Entity;

namespace Sistema.Application.Implementations.Entity
{
    public class DocumentoEntidadeAppImp : AppBaseImp<DocumentoEntidade>, DocumentoEntidadeApp
    {
        private readonly DocumentoEntidadeService _Repository;
        public DocumentoEntidadeAppImp(DocumentoEntidadeService repository):base(repository)
        {
            _Repository = repository;
        }
    }
}
