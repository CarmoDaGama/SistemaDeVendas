using Sistema.Domain.Entities.Entity;
using System.Collections.Generic;

namespace Sistema.Domain.Interfaces.Repository.Entity
{
    public interface ContactoRepository : RepositoryBase<Contacto>
    {
        List<Contacto> GetEntities(int entidadeId);
    }
}
