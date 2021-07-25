using Sistema.Domain.Interfaces.Repository;
using Sistema.Domain.Interfaces.Service;
using System.Collections.Generic;

namespace Sistema.Service.Implementations
{
    public class ServiceBaseImp<Entity> : ServiceBase<Entity> where Entity : class, new()
    {
        private readonly RepositoryBase<Entity> Repository;
        public ServiceBaseImp(RepositoryBase<Entity> repository)
        {
            Repository = repository;
        }
        public void Delete(Entity entity)
        {
            Repository.Delete(entity);
        }

        public Entity GetById(int id)
        {
            return Repository.GetById(id);
        }

        public List<Entity> GetEntities()
        {
            return Repository.GetEntities();
        }

        public void Insert(Entity entity)
        {
            Repository.Insert(entity);
        }

        public void Update(Entity entity)
        {
            Repository.Update(entity);
        }
    }
}
