using System.Collections.Generic;

namespace Sistema.Application.Interfaces
{
    public interface AppBase<Entity> where Entity : class, new()
    {
        List<Entity> GetEntities();
        Entity GetById(int id);
        void Insert(Entity entity);
        void Update(Entity entity);
        void Delete(Entity entity);
    }
}
