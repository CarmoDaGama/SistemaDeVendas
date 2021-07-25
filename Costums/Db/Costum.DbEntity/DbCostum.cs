using System.Collections.Generic;

namespace Costum.DbEntity
{
    public class DbCostum : SchemaSet<object>
    {
        public List<object> ListaDadosIniciais { get; set; } 
        public DbCostum(InfoConnection info)
            : base(info, null)
        {
            Info = info;
            SetEntities();
            createSchemaDataBase();
        }
        private List<object> Sets{ get; set; } 

        private void createSchemaDataBase()
        {
            if (!NotAcessivelServer() &&
                IsNotExistsDatabase())
            {
                creataDataBase();
                createTablesInDb();
            }
        }

        private void createTablesInDb()
        {
            var propriedades = GetType().GetProperties();
            foreach (var item in propriedades)
            {
                var nametype = item.PropertyType.Name;
                if (item.PropertyType.Name.Contains("TableSet"))
                {
                    var valueItem = item.GetValue(this);

                    if (Equals(valueItem, null))
                    {
                        item.SetValue(this, Initialize(item.PropertyType, Info));
                    }
                    var propertyCreate = item.PropertyType.GetProperty("CreateThisTable");
                    var ValueCreate = propertyCreate.GetValue(item.GetValue(this));
                }
            }

            /**foreach (var item in Sets)
            //{
            //    if (item.GetType().Name.Contains("TableSet"))
            //    {
            //        item.GetType().GetProperty("CreateThisTable").GetValue(item);
            //    }
            //}*/
        }

        private void creataDataBase()
        {
            var databaseName = Info.DataBaseName;
            Info.DataBaseName = "";
            RefreshConnection(Info);
            ExecuteSql("CREATE DATABASE " + databaseName + ";");
            Info.DataBaseName = databaseName;
            RefreshConnection(Info);
        }

        protected virtual void SetEntities()
        {
            Sets = new List<object>();
        }
        protected DbCostum AddSet<Entity>()where Entity : class, new(){
            if(Equals(Sets, null))
            {
                Sets = new List<object>();
            }
            Sets.Add(Set<Entity>());

            return this;
        }
        public virtual TableSet<TEntity> Set<TEntity>() where TEntity : class, new()
        {
            return new TableSet<TEntity>(Info);
        }
        protected virtual void InserirDadosIniciais<Entity>(List<Entity> listaDados) where Entity : class, new()
        {
            ListaDadosIniciais.Add(listaDados);
            var tabelaSet = new TableSet<Entity>(Info);
            foreach (var item in listaDados)
            {
                tabelaSet.Add(item);
            }
        }
    }
}
