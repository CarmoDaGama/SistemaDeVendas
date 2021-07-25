using System.Collections.Generic;

namespace Sistema.Domain.Interfaces.Repository
{
    public interface RepositoryBase<Entity> where Entity : class, new()
    {
        List<Entity> GetEntities();
        Entity GetById(int id);
        void Insert(Entity entity);
        void Update(Entity entity);
        void Delete(Entity entity);
    }
}
