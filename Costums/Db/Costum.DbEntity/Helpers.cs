using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Costum.DbEntity
{
    public static class Helpers
    {
        public static string ReplaceInNameTable { get; set; } = " ";
        public static List<TSource> ToList<TSource>(this DataTable dataTable) where TSource : new()
        {
            var dataList = new List<TSource>();

            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic;

            var objFieldNames = (from PropertyInfo aProp in typeof(TSource).GetProperties(flags)
                                 select new
                                 {
                                     Name = aProp.Name,
                                     Type = Nullable.GetUnderlyingType(aProp.PropertyType) ??
                                        aProp.PropertyType
                                 }).ToList();

            var dataTblFieldNames = (from DataColumn aHeader in dataTable.Columns
                                     select new
                                     {
                                         Name = aHeader.ColumnName,
                                         Type = aHeader.DataType
                                     }).ToList();
            var commonFields = objFieldNames.Intersect(dataTblFieldNames).ToList();

            foreach (DataRow dataRow in dataTable.AsEnumerable().ToList())
            {
                var aTSource = new TSource();
                foreach (var aField in commonFields)
                {
                    PropertyInfo propertyInfos = aTSource.GetType().GetProperty(aField.Name);
                    var value = (dataRow[aField.Name] == DBNull.Value) ?
                    null : dataRow[aField.Name]; //if database field is nullable
                    propertyInfos.SetValue(aTSource, value, null);
                }
                dataList.Add(aTSource);
            }
            return dataList;
        }
        private static bool IsEnumerable(PropertyInfo property)
        {
            return property.PropertyType.Name.Contains("IEnumerable") ||
                   property.PropertyType.Name.Contains("ICollection") ||
                   property.PropertyType.Name.Contains("List") ||
                   property.PropertyType.Name.Contains("IList");
        }
        private static bool IsKey(object entity, PropertyInfo property)
        {
            string nameColumnKey = entity.GetType().Name.Replace(ReplaceInNameTable, string.Empty) + "Id";
            return nameColumnKey == property.Name.Replace(ReplaceInNameTable, string.Empty);
        }
        public static object Initialize(Type type)
        {
            var construtor = type.GetConstructor(new Type[] { });
            var newInstance = construtor.Invoke(new object[] { });
            return newInstance;
        }
        private static bool IsEnum(PropertyInfo property)
        {
            return property.PropertyType.BaseType.FullName.ToLower().Contains("enum");
        }
        private static bool propertyIsEntity(PropertyInfo property)
        {
            return !property.PropertyType.Assembly.GlobalAssemblyCache && !IsEnum(property);
        }
        private static object getValueField<T>(DataRow row, T entity) where T : class, new()
        {
            if(Equals(entity, null))
            {
                entity = new T();
            }
            foreach (var field in entity.GetType().GetProperties())
            {
                if (propertyIsEntity(field) && !IsEnumerable(field))
                {
                    //var valueField = entity.GetType().GetProperty(field.Name).GetValue(entity);
                    var valueField = Initialize(field.PropertyType);
                    field.SetValue(
                        entity, 
                        getValueField(row, valueField)
                    ); 
                }
                else if (!IsEnumerable(field))
                {
                    var value = row[entity.GetType().Name.Replace(ReplaceInNameTable, string.Empty) + field.Name.Replace(ReplaceInNameTable, string.Empty)];
                    value = value == DBNull.Value ? null : value;
                    field.SetValue(entity, value);
                }
            }
            return entity;
        }
        public static List<Entity> ToListCostum<Entity>(DataTable datas) where Entity : class, new()
        {
            //GAMA
            List<Entity> entities = new List<Entity>();
            foreach(DataRow row in datas.Rows)
            {
                Entity entity = new Entity();
                entity = (Entity)getValueField(row, entity);

                entities.Add(entity);
            }

            return entities;
        }
        public static TSource toentidad<TSource>(this DataTable dataTable) where TSource : new()
        {
            var dataList = new TSource();

            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic;
            var objFieldNames = (from PropertyInfo aProp in typeof(TSource).GetProperties(flags)
                                 select new
                                 {
                                     Name = aProp.Name,
                                     Type = Nullable.GetUnderlyingType(aProp.PropertyType) ??
                             aProp.PropertyType
                                 }).ToList();
            var dataTblFieldNames = (from DataColumn aHeader in dataTable.Columns
                                     select new
                                     {
                                         Name = aHeader.ColumnName,
                                         Type = aHeader.DataType
                                     }).ToList();
            var commonFields = objFieldNames.Intersect(dataTblFieldNames).ToList();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                var aTSource = new TSource();
                foreach (var aField in commonFields)
                {
                    PropertyInfo propertyInfos = aTSource.GetType().GetProperty(aField.Name);
                    var value = (dataRow[aField.Name] == DBNull.Value) ?
                    null : dataRow[aField.Name]; //if database field is nullable
                    propertyInfos.SetValue(aTSource, value, null);
                    dataList = aTSource;
                }

            }
            return dataList;
        }
        public static List<Entity> SimpelToList<Entity>(this DataTable datas) where Entity : class, new()
        {
            List<Entity> entities = new List<Entity>();

            foreach (var item in datas.AsEnumerable())
            {
                //var entity = item.ToObject<Entity>();
            }
            return entities;
        }

    }
}
