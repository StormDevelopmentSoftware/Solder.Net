using System;
using MySql.Data.MySqlClient;

namespace Solder.Net
{
    public class Database : IDisposable
    {
        public MySqlConnection Connection;

        public Database(string connectionString)
        {
            Connection = new MySqlConnection(connectionString);
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.DisposeAsync();
        }
    }
}
