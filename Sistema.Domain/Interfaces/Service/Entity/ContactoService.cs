using Sistema.Domain.Entities.Entity;
using System.Collections.Generic;

namespace Sistema.Domain.Interfaces.Service.Entity
{
    public interface ContactoService : ServiceBase<Contacto>
    {
        List<Contacto> GetEntities(int entidadeId);
    }
}
