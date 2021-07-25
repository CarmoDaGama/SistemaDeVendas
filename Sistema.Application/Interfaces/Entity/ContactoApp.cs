using System.Collections.Generic;
using Sistema.Domain.Entities.Entity;

namespace Sistema.Application.Interfaces.Entity
{
    public interface ContactoApp : AppBase<Contacto>
    {
        List<Contacto> GetEntities(int entidadeId);
    }
}
