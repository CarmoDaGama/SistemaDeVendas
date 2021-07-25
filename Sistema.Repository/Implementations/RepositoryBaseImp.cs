using Costum.DbEntity;
using Sistema.Domain.Interfaces.Repository;
using Sistema.Repository.Context;
using System.Collections.Generic;
using System.Linq;

namespace Sistema.Repository.Implementations
{
    public class RepositoryBaseImp<Entity> : RepositoryBase<Entity> where Entity : class, new()
    {
        protected DbContext Db = new DbContext(new InfoConnection("Data Source=DESKTOP-6RTIUL4;Initial Catalog=SystemSaleDB;Integrated Security=True"));

        public void Delete(Entity entity)
        {
            Db.Set<Entity>().remove(entity);
        }

        public Entity GetById(int id)
        {
            return Db.Set<Entity>().Find(id);
        }

        public List<Entity> GetEntities()
        {
            return Db.Set<Entity>().GetAll();
        }

        public void Insert(Entity entity)
        {
            Db.Set<Entity>().Add(entity);
        }

        public void Update(Entity entity)
        {
            Db.Set<Entity>().Update(entity);
        }
    }
}
