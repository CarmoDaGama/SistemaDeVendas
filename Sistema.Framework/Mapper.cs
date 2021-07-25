using System;
using System.Collections.Generic;
using System.Reflection;

namespace Sistema.Framework
{
    public static class Mapper<TypeSet, TypeGet> where TypeGet : class, new()
    {
        public static TypeGet MapearEntity(TypeSet entitySet)
        {
            TypeGet entityGet = new TypeGet();
            foreach (var field in entitySet.GetType().GetProperties())
            {
                if (EqualsNamesAndType(field, entityGet.GetType().GetProperty(field.Name)))
                {
                    var fieldGet = entityGet.GetType().GetProperty(field.Name);
                    fieldGet.SetValue(entityGet, field.GetValue(entitySet));
                }
            }
            return entityGet;
        }
        public static List<TypeGet> MapearListEntity(List<TypeSet> listEntitySet)
        {
            List<TypeGet> listEntityGet = new List<TypeGet>();
            foreach (var item in listEntitySet)
            {
                listEntityGet.Add(MapearEntity(item));
            }
            return listEntityGet;
        }
        private static bool EqualsNamesAndType(PropertyInfo fieldSet, PropertyInfo fieldGet)
        {
            return !Equals(fieldGet, null) && fieldSet.PropertyType.Name == fieldGet.PropertyType.Name;
        }
    }
}
