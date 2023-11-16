using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

namespace DatabaseApp
{
    internal class DatabaseManager
    {
        private string connString = "Host=localhost;Username=postgres;Password=s$cret;Database=assignment6";
        private NpgsqlConnection? connection;

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
            if (connection == null)
            {
                setConnection();
            }
            return connection;
        }

        private void closeConnection()
        {
            if (connection == null) return;
            connection.Close();
        }
    }
}
