using System.Reflection;

namespace Costum.DbEntity
{
    public class DataBaseCreator<Entity> : SchemaSet<Entity> where Entity : class, new()
    {
        public DataBaseCreator(InfoConnection info) 
            : base(info, new Entity())
        {
        }
        #region CREATE DATABASE
        private string GetTypeinSql(PropertyInfo typeInCsharp)
        {
            if (typeInCsharp.Name == "Imagem")
            {

            }
            if (typeInCsharp.PropertyType.BaseType.FullName.ToLower().Contains("enum"))
                return "int";
            switch (typeInCsharp.PropertyType.Name)
            {
                case "String":
                {
                    if (Info.Tipo == TipoBaseDados.Sql)
                        return "VarChar(MAX)";
                    if (Info.Tipo == TipoBaseDados.MySql)
                    {
                        return "TEXT";
                    }
                        return "TEXT";
                }
                case "int":
                    return "Int";

                case "Int16":
                    return "Int";

                case "Int32":
                    return "Int";

                case "Int64":
                    return "Int";

                case "long":
                    return "Int";

                case "Byte[]":
                    {
                        if (Info.Tipo == TipoBaseDados.MySql)
                        {
                            return "LongBlob";
                        }
                        return "varbinary(MAX)";
                    }
                case "Byte":
                    {
                        if (Info.Tipo == TipoBaseDados.MySql)
                        {
                            return "Blob";
                        }
                        return "varbinary(50)";
                    }

                case "DateTime":
                    return "datetime";

                case "Guid":
                    return "VarChar(250)";


                case "TimeStamp":
                    if (Info.Tipo == TipoBaseDados.MySql)
                    {
                        return "time";
                    }
                    else
                    {
                        return "timestamp";
                    }

                case "boolean":
                    if (Info.Tipo == TipoBaseDados.MySql)
                    {
                        return "bool";
                    }
                    else
                    {
                        return "bit";
                    }

                case "Boolean":
                    if (Info.Tipo == TipoBaseDados.MySql)
                    {
                        return "bool";
                    }
                    else
                    {
                        return "bit";
                    }


                case "enum":
                    return "int";

                case "decimal":
                    return "decimal(18, 0)";

                case "Decimal":
                    return "decimal(18, 0)";

                case "float":
                    return "float";

                case "Float":
                    return "float";

                case "double":
                    return "float";

                case "Double":
                    return "float";

                default:
                    if (Info.Tipo == TipoBaseDados.MySql)
                    {
                        return "TEXT";
                    }
                    else
                    {
                        return "VarChar(Max)";
                    }

            }
        }
        private string GetSquemaTable()
        {
            string auto_incremento = "IDENTITY";
            if (Info.Tipo == TipoBaseDados.MySql)
            {
                auto_incremento = "AUTO_INCREMENT";
            }
            Entity entity = new Entity();
            string squema = "CREATE TABLE [" + entity.GetType().Name + "] ( ";
            int count = 0;
            foreach (var field in entity.GetType().GetProperties())
            {
                if (IsEnumerable(field.PropertyType.Name))
                    continue;

                if (count == 0)
                {
                    if (propertyIsEntity(field))
                    {
                        squema += "FOREIGN KEY (" + field.PropertyType.Name + "Id) REFERENCES [" + field.PropertyType.Name + "]( " + field.PropertyType.Name + "Id)";
                    }
                    else
                    {
                        if (IsKey(field.Name))
                        {
                            squema += field.Name + " " + GetTypeinSql(field) + " PRIMARY KEY " + auto_incremento;
                        }
                        else
                        {

                            squema += field.Name + " " + GetTypeinSql(field);
                        }
                    }
                }
                else
                {
                    if (propertyIsEntity(field))
                    {
                        squema += ", FOREIGN KEY (" + field.PropertyType.Name + "Id) REFERENCES [" + field.PropertyType.Name + "]( " + field.PropertyType.Name + "Id)";
                    }
                    else
                    {
                        if (IsKey(field.Name))
                        {
                            squema += ", " + field.Name + " " + GetTypeinSql(field) + " PRIMARY KEY";
                        }
                        else
                        {

                            squema += ", " + field.Name + " " + GetTypeinSql(field);
                        }
                    }

                }
                count++;
            }
            squema += ");";
            return TiraParentes(squema);
        }
        public string SchemaTable { get { return GetSquemaTable(); } }
        public void CreateTable()
        {
            ExecuteSql(SchemaTable);
        }
        #endregion
    }
}
