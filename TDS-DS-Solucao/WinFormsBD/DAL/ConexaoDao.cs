using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBD.DAL
{
    public class CConexaoDao
    {
        private static string connectionString = "Data Source=SNCCHLAB03F20\\SQLEXPRESS;Initial Catalog=db_tds_ds;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(connectionString);

        public static void Conectar()
        {
            if(connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public static void Desconectar()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public static SqlConnection GetConnection()
        {
            return connection;
        }

    }
}
