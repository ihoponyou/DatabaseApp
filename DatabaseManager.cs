using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

namespace DatabaseApp
{
    public class DatabaseManager
    {
        private string connString = "Host=localhost;Username=noah;Password=noah123;Database=366-final";

        public DatabaseManager()
        {
        }

        private void setConnection()
        {
            try
            {
                using var con = new NpgsqlConnection(connString);
                con.Open();

                var sql = "SELECT version()";

                using var cmd = new NpgsqlCommand(sql, con);

                var version = cmd.ExecuteScalar();
                Console.WriteLine($"PostgreSQL version: {version}");

                //_connection = con;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Manager: Setting Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public NpgsqlConnection? getConnection()
        {
            //if (_connection == null)
            //{
            //    setConnection();
            //}
            //return _connection;
            try
            {
                using var con = new NpgsqlConnection(connString);
                con.Open();

                var sql = "SELECT version()";

                using var cmd = new NpgsqlCommand(sql, con);

                var version = cmd.ExecuteScalar();
                Console.WriteLine($"PostgreSQL version: {version}");

                return con;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Manager: Getting Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //private void closeConnection()
        //{
        //    if (_connection == null) return;
        //    _connection.Close();
        //}

        public NpgsqlDataReader? Query(string query)
        {
            try 
            {
                NpgsqlConnection conn = new NpgsqlConnection(connString);
                conn.Open();

                NpgsqlCommand command = new NpgsqlCommand(query, conn);

                return command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Manager: Query", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
