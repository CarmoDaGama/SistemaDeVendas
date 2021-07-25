using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace Costum.DbEntity
{
    public class SchemaSet<Entity> where Entity:class, new()
    {
        protected SqlConnection ConnectionSql;
        protected SqlCommand CommandSql;
        protected MySqlConnection ConnectionMySql;
        protected MySqlCommand CommandMySql;
        private string strParenteCurvoInit;
        private string strParenteCurvoEnd;
        protected string ReplaceInNameTable = " ";

        protected string NamePrimaryKey { get; set; }
        protected string NameTable { get; set; }
        protected string Norm { get; set; }
        protected string PathNameEntity { get; set; }
        private Entity ThisEntity { get; set; }
        private List<string> NamesTablesJoins { get; set; }
        protected InfoConnection Info { get; set; }

        public object Initialize(Type type)
        {
            var construtor = type.GetConstructor(new Type[] {  });
            var newInstance = construtor.Invoke(new object[] { });
            return newInstance;
        }
        public object Initialize(Type type, object parametro)
        {
            var construtor = type.GetConstructors();

            var newInstance = construtor[0].Invoke(new object[] { parametro });
            return newInstance;
        }
        public object Initialize(Type type, object[] parametros)
        {
            var construtor = type.GetConstructor(new Type[] { });
            var newInstance = construtor.Invoke(parametros);
            return newInstance;
        }
        public SchemaSet(InfoConnection info, Entity entity)
        {
            Info = info;
            ThisEntity = entity;
            initializeConnectionAndCraeteCommand();
            constructNorm();
        }
        protected void RefreshConnection(InfoConnection info)
        {
            Info = info;
            initializeConnectionAndCraeteCommand();
        }
        private void constructNorm()
        {
            if (Equals(ThisEntity, null)) return;
            NameTable = ThisEntity.GetType().Name.Replace(Info.ReplaceInNameTable, string.Empty);
            NamePrimaryKey = NameTable + "Id";

            Norm = " WHERE " + NamePrimaryKey + " = ";
            PathNameEntity = ThisEntity
                                    .GetType()
                                    .FullName.Replace(
                                        ThisEntity
                                                .GetType()
                                                .Name,
                                        ""
                                    );
        }
        private void initializeConnectionAndCraeteCommand()
        {
            SetStringConnection();
        }
        public void SetStringConnection()
        {
            if (Info.Tipo == TipoBaseDados.Sql)
            {
                ConnectionSql = new SqlConnection(Info.StringConnection);
                CommandSql = ConnectionSql.CreateCommand();
            }

            if (Info.Tipo == TipoBaseDados.MySql)
            {
                ConnectionMySql = new MySqlConnection(Info.StringConnection);
                CommandMySql = ConnectionMySql.CreateCommand();
            }
        }
        protected void Close()
        {
            if (Info.Tipo == TipoBaseDados.Sql)
            {
                if (ConnectionState.Open == ConnectionSql.State)
                    ConnectionSql.Close();
            }
            if (Info.Tipo == TipoBaseDados.MySql)
            {
                if (ConnectionState.Open == ConnectionMySql.State)
                    ConnectionMySql.Close();
            }
        }
        protected string CloseConnection()
        {
            var messageException = "";
            try
            {
                if (Info.Tipo == TipoBaseDados.Sql)
                {
                    if (ConnectionState.Open == ConnectionSql.State)
                        ConnectionSql.Close();
                }
                if (Info.Tipo == TipoBaseDados.MySql)
                {
                    if (ConnectionState.Open == ConnectionMySql.State)
                        ConnectionMySql.Close();
                }

            }
            catch(SqlException exception)
            {
                messageException = exception.Message;
            }

            return messageException;
        }
        protected void Open()
        {
            if (Info.Tipo == TipoBaseDados.Sql)
            {
                if (ConnectionState.Closed == ConnectionSql.State)
                    ConnectionSql.Open();
            }
            if (Info.Tipo == TipoBaseDados.MySql)
            {
                if (ConnectionState.Closed == ConnectionMySql.State)
                    ConnectionMySql.Open();
            }
        }
        protected string OpenConnection()
        {
            var messageException = "";
            try
            {
                if (Info.Tipo == TipoBaseDados.Sql)
                {
                    if (ConnectionState.Closed == ConnectionSql.State)
                        ConnectionSql.Open();
                }
                if (Info.Tipo == TipoBaseDados.MySql)
                {
                    if (ConnectionState.Closed == ConnectionMySql.State)
                        ConnectionMySql.Open();
                }

            }
            catch (Exception exception)
            {
                messageException = exception.Message;
            }
            return messageException;
        }
        protected void clearParameters()
        {
            if (Info.Tipo == TipoBaseDados.Sql)
            {
                CommandSql.Parameters.Clear();
            }
            if (Info.Tipo == TipoBaseDados.MySql)
            {
                CommandMySql.Parameters.Clear();
            }
        }
        protected void addValue(string name, object _object)
        {

            if (Info.Tipo == TipoBaseDados.Sql)
            {
                CommandSql.Parameters.AddWithValue("@" + name, _object);
            }
            if (Info.Tipo == TipoBaseDados.MySql)
            {
                CommandMySql.Parameters.AddWithValue("@" + name, _object);
            }
        }
        protected bool IsNotExistsDatabase()
        {
            RefreshConnection(Info);
            var messageOpenned = OpenConnection();
            var containsToLower = ("Unknown database '" + Info.DataBaseName + "'").ToLower();
            var resultadoContains = messageOpenned.ToLower().Contains(containsToLower);
            return (messageOpenned.Contains("Cannot open database")&&
                   messageOpenned.Contains("requested by the login. The login failed.") &&
                   messageOpenned.Contains("Login failed for user") ) || resultadoContains;
        }
        protected bool NotAcessivelServer()
        {
            var nameDataBase = Info.DataBaseName;
            Info.DataBaseName = string.Empty;
            RefreshConnection(Info);
            var messageOpenned = OpenConnection();
            Info.DataBaseName = nameDataBase;
            return messageOpenned == getErrorMessageServer();
        }

        private string getErrorMessageServer()
        {
            return "Erro de rede ou específico à instância "+
                   "ao estabelecer conexão com o SQL Server."+
                   " O servidor não foi encontrado ou não estava"+
                   " acessível. Verifique se o nome da instância"+
                   " está correto e se o SQL Server está configurado"+
                   " para permitir conexões remotas. (provider: Named"+
                   " Pipes Provider, error: 40 - Não foi possível abrir"+
                   " uma conexão com o SQL Server)";
        }

        protected string orderParemeters(TypeOrder type)
        {
            string strParameters = "";
            if (Info.Tipo == TipoBaseDados.Sql)
            {
                if (CommandSql.Parameters.Count > 0)
                    foreach (SqlParameter parameter in CommandSql.Parameters)
                    {
                        string name = TypeOrder.Columns == type ?
                            parameter.ParameterName.Replace("@", string.Empty) :
                            parameter.ParameterName;

                        strParameters += strParameters.Equals(string.Empty) ? name : "," + name;
                    }
            }
            if (Info.Tipo == TipoBaseDados.MySql)
            {
                if (CommandMySql.Parameters.Count > 0)
                    foreach (MySqlParameter parameter in CommandMySql.Parameters)
                    {
                        string name = TypeOrder.Columns == type ?
                            parameter.ParameterName.Replace("@", string.Empty) :
                            parameter.ParameterName;

                        strParameters += strParameters.Equals(string.Empty) ? name : "," + name;
                    }
            }


            return strParameters;
        }
        protected string getJoins<VarEntity>(VarEntity entity) where VarEntity : class, new()
        {
            string joins = "";
            if(Equals(entity, null))
            {
                entity = new VarEntity();
            }
            string nameTable = entity.GetType().Name.Replace(Info.ReplaceInNameTable, string.Empty);
            if (Equals(NamesTablesJoins, null))
                NamesTablesJoins = new List<string>();
            foreach (var property in entity.GetType().GetProperties())
            {
                if (propertyIsEntity(property) && !IsEnumerable(property.PropertyType.FullName))
                {
                    property.SetValue(entity, Initialize(property.PropertyType));
                    string columnId = property.PropertyType.Name.Replace(Info.ReplaceInNameTable, string.Empty) + "Id";
                    string nameTableJoin = property.PropertyType.Name.Replace(Info.ReplaceInNameTable, string.Empty);
                    if (ifNotExistsTableJoin(nameTableJoin))
                    {
                        joins += " LEFT JOIN [" + nameTableJoin + "] ON [" + nameTable + "]." + columnId + " = [" + nameTableJoin + "]." + columnId;
                        NamesTablesJoins.Add(nameTableJoin);
                    }
                    joins += getJoins(entity.GetType().GetProperty(property.Name).GetValue(entity));
                }
            }
            return TiraParentes(joins);
        }

        protected void TrocarParentesCurvos()
        {
            strParenteCurvoInit = "[";
            strParenteCurvoEnd = "]";
            if (Info.Tipo == TipoBaseDados.MySql)
            {
                strParenteCurvoInit = string.Empty;
                strParenteCurvoEnd = string.Empty;
            }
        }

        private bool ifNotExistsTableJoin(string nameTableJoin)
        {
            var resultNameTableJoin = NamesTablesJoins.Where(name => Equals(name, nameTableJoin)).FirstOrDefault();

            return Equals(resultNameTableJoin, null);
        }

        protected string getColumns<VarEntity>(VarEntity entity)where VarEntity : class, new()
        {
            if (Equals(entity, null))
            {
                entity = new VarEntity();
            }
            string columns = string.Empty;
            string nameTable = "[" + entity.GetType().Name.Replace(Info.ReplaceInNameTable, string.Empty) + "]";
            foreach (var field in entity.GetType().GetProperties())
            {
                if (IsEnumerable(field.PropertyType.Name))
                    continue;

                if (propertyIsEntity(field))
                {
                    field.SetValue(entity, Initialize(field.PropertyType));
                    columns += columns.Equals(string.Empty) ?
                        getColumns(field.GetValue(entity)) :
                        ", " + getColumns(field.GetValue(entity));
                }
                else
                {
                    string fieldName = field.Name.Replace(Info.ReplaceInNameTable, string.Empty);
                    string entityName = entity.GetType().Name.Replace(Info.ReplaceInNameTable, string.Empty);
                    columns += columns.Equals(string.Empty) ?
                        nameTable + "." + fieldName + " AS " + entityName + fieldName :
                        ", " + nameTable + "." + fieldName + " AS " + entityName + fieldName;
                }
            }

            return TiraParentes(columns);
        }

        protected string TiraParentes(string str)
        {
            TrocarParentesCurvos();
            return str.Replace("[", strParenteCurvoInit).Replace("]", strParenteCurvoEnd);
        }

        private void throwField<VarEntity>(VarEntity value, string name) where VarEntity : class, new()
        {
            if (Equals(value, null))
                value = new VarEntity();
                //throw new Exception("O Valor da propriedade " + name + " é nula!");
        }

        protected string getCreateQuery(string criterio)
        {
            var query =  TiraParentes( "INSERT INTO [" + NameTable.Replace(Info.ReplaceInNameTable, string.Empty) + "] ( " + orderParemeters(TypeOrder.Columns) + " ) VALUES ( " + orderParemeters(TypeOrder.Values) + " )");
            return query;
        }
        protected string getReadQuery(string criterio)
        {
            var query = TiraParentes( "SELECT " + getColumns(ThisEntity) +
                   " FROM [" + NameTable.Replace(Info.ReplaceInNameTable, string.Empty) + "]" + getJoins(ThisEntity) + criterio);
            return query;
        }
        protected string getUpdateQuery(string criterio)
        {
            string[] columns = orderParemeters(TypeOrder.Columns).Split(',');
            string[] values = orderParemeters(TypeOrder.Values).Split(',');
            string query = "";

            for (int i = 0; i < columns.Length; i++)
            {
                query += i.Equals(0) ? columns[i] + " = " + values[i] :
                ", " + columns[i] + " = " + values[i];
            }

            query = TiraParentes("UPDATE [" + NameTable.Replace(Info.ReplaceInNameTable, string.Empty) + "] SET " + query + criterio);

            return query;
        }
        protected string getDeleteQuery(string criterio)
        {
            return TiraParentes("DELETE FROM [" + NameTable.Replace(Info.ReplaceInNameTable, string.Empty) + "]" + criterio);
        }
        protected string getQuery(TipoDeQuery typeQuery, string criterio)
        {
            string query = "";

            switch (typeQuery)
            {
                case TipoDeQuery.Create:
                    query = getCreateQuery(criterio);
                    break;
                case TipoDeQuery.Read:
                    query = getReadQuery(criterio);
                    break;

                case TipoDeQuery.Update:
                    query = getUpdateQuery(criterio);
                    break;

                case TipoDeQuery.Delete:
                    query = getDeleteQuery(criterio);
                    break;

                default:
                    break;
            }

            return query;
        }
        protected string getNorm<VarEntity>(VarEntity entity) where VarEntity : class, new()
        {
            if (Equals(entity, null))
            {
                entity = new VarEntity();
            }
            var valueId = entity
                            .GetType()
                            .GetProperty(NamePrimaryKey)
                            .GetValue(entity);
            return Norm + valueId;
        }
        protected string getNorm(int id)
        {
            return Norm + id;
        }
        protected bool Execute(TipoDeQuery typeQuery, string criterio)
        {
            OpenConnection();
            bool boolRead = false;
            try
            {
                if (Info.Tipo == TipoBaseDados.Sql)
                {
                    CommandSql.CommandText = getQuery(typeQuery, criterio);
                    SqlDataReader reader = CommandSql.ExecuteReader();
                    boolRead = reader.Read();
                }
                if (Info.Tipo == TipoBaseDados.MySql)
                {
                    CommandMySql.CommandText = getQuery(typeQuery, criterio);
                    MySqlDataReader reader = CommandMySql.ExecuteReader();
                    boolRead = reader.Read();
                }
            }
            catch (Exception excessao)
            {
                if (ExisteParamentroNulo(excessao.Message))
                {
                    SetTodosParametrosSql(DBNull.Value);
                    Execute(typeQuery, criterio);
                }
            }

            clearParameters();

            return boolRead;
        }

        private void SetTodosParametrosSql(DBNull value)
        {
            if (Info.Tipo == TipoBaseDados.Sql)
            {
                foreach (SqlParameter item in CommandSql.Parameters)
                {
                    if (Equals(item.Value, null))
                    {
                        item.Value = value;
                    }
                }
            }
            if (Info.Tipo == TipoBaseDados.MySql)
            {
                foreach (MySqlParameter item in CommandMySql.Parameters)
                {
                    if (Equals(item.Value, null))
                    {
                        item.Value = value;
                    }
                }
            }
        }

        private bool ExisteParamentroNulo(string message)
        {
            return message.Contains("The parameterized query") && 
                   message.Contains("expects the parameter") && 
                   message.Contains("which was not supplied.");
        }
        public void ExecuteQuery(string query)
        {
            ExecuteSql(query);
        }
        public DataTable SelectQuery(string query)
        {
            return Select(query);
        }
        protected DataTable Select(string sql)
        {
            OpenConnection();
            DataTable table = new DataTable();
            if (Info.Tipo == TipoBaseDados.Sql)
            {
                CommandSql.CommandText = sql;
                SqlDataReader reader = CommandSql.ExecuteReader();
                table.Load(reader);
            }
            if (Info.Tipo == TipoBaseDados.MySql)
            {
                CommandMySql.CommandText = sql;
                MySqlDataReader reader = CommandMySql.ExecuteReader();
                table.Load(reader);
            }

            clearParameters();

            return table;
        }
        protected void ExecuteSql(string sql)
        {
            try
            {
                OpenConnection();
                if (Info.Tipo == TipoBaseDados.Sql)
                {
                    CommandSql.CommandText = sql;
                    CommandSql.ExecuteNonQuery();
                }
                if (Info.Tipo == TipoBaseDados.MySql)
                {
                    CommandMySql.CommandText = sql;
                    CommandMySql.ExecuteNonQuery();
                }
                CloseConnection();

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("ExecuteNonQuery requer uma Connection aberta e disponível. O estado atual da conexão é fechada."))
                {
                    if (Info.Tipo == TipoBaseDados.Sql)
                    {
                        if (ConnectionSql.State == ConnectionState.Closed)
                        {
                            ConnectionSql.Open();
                        }
                        CommandSql.CommandText = sql;
                        CommandSql.ExecuteNonQuery();
                    }
                    if (Info.Tipo == TipoBaseDados.MySql)
                    {
                        if (ConnectionMySql.State == ConnectionState.Closed)
                        {
                            ConnectionMySql.Open();
                        }
                        CommandMySql.CommandText = sql;
                        CommandMySql.ExecuteNonQuery();
                    }
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        protected DataTable FillTableEntity(string criterios)
        {
            OpenConnection();
            DataTable table = new DataTable();
            if (Info.Tipo == TipoBaseDados.Sql)
            {
                CommandSql.CommandText = getQuery(TipoDeQuery.Read, criterios);
                SqlDataReader reader = CommandSql.ExecuteReader();
                table.Load(reader);
            }
            if (Info.Tipo == TipoBaseDados.MySql)
            {
                CommandMySql.CommandText = getQuery(TipoDeQuery.Read, criterios);
                MySqlDataReader reader = CommandMySql.ExecuteReader();
                table.Load(reader);
            }

            clearParameters();

            return table;
        }
        protected bool IsEnumerable(string propertyTypeName)
        {
            return propertyTypeName.Contains("IEnumerable") ||
                   propertyTypeName.Contains("ICollection") ||
                   propertyTypeName.Contains("List") ||
                   propertyTypeName.Contains("IList");
        }
        protected bool IsKey(string propertyName)
        {
            return NamePrimaryKey == propertyName;
        }
        protected bool UmaChave(PropertyInfo property)
        {
            return true;
        }
        protected bool IsEnum(PropertyInfo property)
        {
            return property.PropertyType.BaseType.FullName.ToLower().Contains("enum");
        }
        protected bool propertyIsEntity(PropertyInfo property)
        {
            return !property.PropertyType.Assembly.GlobalAssemblyCache && !IsEnum(property);
        }
    }
}
