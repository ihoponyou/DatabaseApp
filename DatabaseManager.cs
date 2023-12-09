using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

namespace DatabaseApp
{
    // database manager singleton using the 4th version of this singleton pattern
    // https://csharpindepth.com/articles/singleton
    internal class DatabaseManager
    {
        private static readonly DatabaseManager instance = new DatabaseManager();

        private string connString = "Host=localhost;Username=postgres;Password=s$cret;Database=assignment6";
        private NpgsqlConnection? _connection;

        static DatabaseManager()
        { 
        }

        private DatabaseManager()
        {
        }

        public static DatabaseManager Instance
        {
            get => instance;
        }

        private void setConnection()
        {
            try
            {
                var cs = "Host=localhost;Username=postgres;Password=s$cret;Database=testdb";

                using var con = new NpgsqlConnection(cs);
                con.Open();

                var sql = "SELECT version()";

                using var cmd = new NpgsqlCommand(sql, con);

                var version = cmd.ExecuteScalar().ToString();
                Console.WriteLine($"PostgreSQL version: {version}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private NpgsqlConnection getConnection()
        {
            if (_connection == null)
            {
                setConnection();
            }
            return _connection;
        }

        private void closeConnection()
        {
            if (_connection == null) return;
            _connection.Close();
        }

        public NpgsqlDataReader? Query(string query)
        {
            try
            {
                using var cmd = new NpgsqlCommand(query, _connection);
                
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
