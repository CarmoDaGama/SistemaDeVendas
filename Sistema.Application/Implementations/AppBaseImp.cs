using Sistema.Application.Interfaces;
using Sistema.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Application.Implementations
{
    public class AppBaseImp<Entity> : AppBase<Entity> where Entity : class, new()
    {
        private readonly ServiceBase<Entity> Service;
        public AppBaseImp(ServiceBase<Entity> service)
        {
            Service = service;
        }
        public void Delete(Entity entity)
        {
            Service.Delete(entity);
        }

        public Entity GetById(int id)
        {
            return Service.GetById(id);
        }

        public List<Entity> GetEntities()
        {
            return Service.GetEntities();
        }

        public void Insert(Entity entity)
        {
            Service.Insert(entity);
        }

        public void Update(Entity entity)
        {
            Service.Update(entity);
        }
    }
}
