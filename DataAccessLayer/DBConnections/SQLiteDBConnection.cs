using System.Configuration;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace DataAccessLayer.DBConnections
{
    internal static class SQLiteDBConnection
    {
        public static SqlConnection Get()
        {
            return new SqlConnection(ConnectionString);
        }

        private static string ConnectionString
        {
            get => ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString;
        }
    }
}
