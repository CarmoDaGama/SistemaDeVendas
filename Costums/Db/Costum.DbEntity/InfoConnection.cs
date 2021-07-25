using System;

namespace Costum.DbEntity
{
    public class InfoConnection
    {
        public static string stringConnection = "Data Source=DESKTOP-6RTIUL4;Initial Catalog=SystemSaleDB;Integrated Security=True";
        public static string stringConnectionMySql = "server=localhost;user id=root;database=crisoftec";
        public string ServerName { get; set; }
        public string DataBaseName { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Security { get; set; }
        public string ReplaceInNameTable { get; set; } = " ";
        public int Porta { get; set; } = -1;
        public string StringConnection {
            get
            {
                string strConnection = string.Empty;
                if (Tipo == TipoBaseDados.Sql)
                {
                    Porta = Porta <= 0 ? 1433 : Porta;
                    strConnection = "Data Source=" + ServerName +
                           " ;Initial Catalog=" + DataBaseName ;
                    if (!string.IsNullOrEmpty(Usuario))
                    {
                        strConnection += ";User ID=" + Usuario;
                    }
                    if (!string.IsNullOrEmpty(Senha))
                    {
                        strConnection += "; Password=" + Senha;
                    }
                    strConnection += "; Integrated Security = TRUE";
                }
                else if (Tipo == TipoBaseDados.MySql)
                {
                    Porta = Porta <= 0 ? 3306 : Porta;
                    strConnection = "Server=" + ServerName +
                           " ;Port=" + Porta +
                           ";DataBase='" + DataBaseName;
                    if (!string.IsNullOrEmpty(Usuario))
                    {
                        strConnection += "';uid=" + Usuario;
                    }
                    if (!string.IsNullOrEmpty(Senha))
                    {
                        strConnection += ";Pwd=" + Senha;
                    }
                    
                }
                else
                {
                    strConnection = "Data Source=" + ServerName +
                           ";Initial Catalog=" + DataBaseName +
                           ";Integrated Security=" + Security;
                }
                return strConnection;
            }
        }

        public TipoBaseDados Tipo { get; set; } 

        public InfoConnection()
        {

        }
        public InfoConnection(string strConnection)
        {
            setProperties(strConnection);
            throws();
        }


        public void setProperties(string stringConnection)
        {
            string[] arrayConnection = stringConnection.Split(';');
            ServerName = arrayConnection[0].Replace("Data Source", "").Replace("=", " ").Trim();
            DataBaseName = arrayConnection[1].Replace("Initial Catalog", "").Replace("=", " ").Trim();
            Security = arrayConnection[2].Replace("Integrated Security", "").Replace("=", " ").Trim();

        }
        private void throws()
        {
            if (Equals(ServerName, string.Empty))
                throwName("SERVER:");

            if (Equals(Security, string.Empty))
                throwName("SECURITY:");
        }
        private void throwName(string name)
        {
            throw new Exception(name + " Desconhecido!");
        }
    }
}
