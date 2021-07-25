using System;
using System.Collections.Generic;
using System.Linq;

namespace Costum.DbEntity
{
    public enum TipoDeQuery
    {
        Create, Read, Update, Delete
    }

    public enum TypeOrder
    {
        Columns, Values
    }

    public class TableSet<Entity> : SchemaSet<Entity> where Entity : class, new()
    {
        /*--COISAS QUE PRECISA IMPLEMENTAR--
            -Padronizar fields em que o valor não pode ser alterado
            -Criação do banco de dados automatico 
        */
        public DataBaseCreator<Entity> Creator { get; set; }

        public TableSet(InfoConnection info)
            : base(info, new Entity())
        {
            Creator = new DataBaseCreator<Entity>(info);
        }

        public int CreateThisTable
        {
            get
            {
                Creator.CreateTable();
                return 0;
            }
        }
        #region CRUD GENERICO
        public Entity Add(Entity entity)
        {
            foreach (var property in entity.GetType().GetProperties())
            {
                if (!IsKey(property.Name) &&
                    !IsEnumerable(property.PropertyType.Name))
                {
                    if (!propertyIsEntity(property))
                    {
                        addValue(
                            property.Name,
                            property.Name == "DataCadastro" ?
                                DateTime.Now :
                                property.GetValue(entity)
                        );
                    }
                }
            }

            Execute(TipoDeQuery.Create, "");
            CloseConnection();
            return entity;
        }
        public Entity Update(Entity entity)
        {
            foreach (var property in entity.GetType().GetProperties())
            {
                if (!IsKey(property.Name) &&
                    !IsEnumerable(property.PropertyType.Name))
                {
                    if (!propertyIsEntity(property)
                        && property.Name != "DataCadastro")
                    {
                        addValue(property.Name, property.GetValue(entity));
                    }
                }
            }

            Execute(TipoDeQuery.Update, getNorm(entity));
            CloseConnection();
            return entity;
        }
        public List<Entity> GetAll()
        {
            var entity = new Entity();
            string nameTable = entity.GetType().Name;
            Helpers.ReplaceInNameTable = Info.ReplaceInNameTable;
            List<Entity> entities = Helpers.ToListCostum<Entity>(FillTableEntity(""));

            return entities;
        }
        public List<Entity> GetAllFor(Criterio<Entity> criterio)
        {
            var entity = new Entity();
            string nameTable = entity.GetType().Name;

            Helpers.ReplaceInNameTable = Info.ReplaceInNameTable;
            List<Entity> entities = Helpers.ToListCostum<Entity>(FillTableEntity(criterio.GetStringCriterio()));

            return entities;
        }
        public Entity Find(object id)
        {
            Helpers.ReplaceInNameTable = Info.ReplaceInNameTable;
            List<Entity> entities = Helpers.ToListCostum<Entity>(FillTableEntity(getNorm((int)id)));

            return entities.FirstOrDefault();
        }
        public void remove(Entity entity)
        {
            Execute(TipoDeQuery.Delete, getNorm(entity));
            CloseConnection();
        }
        #endregion



  }
}
