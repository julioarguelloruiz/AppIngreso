using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace AppIngreso
{
    public class Connection
    {
        //private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=frmGridUsers;User=sa;Password=1234";

        //private string connectionString = "Server=localhost\\SQLEXPRESS; Database=AppIngreso; Integrated Security=True";
        //public SqlConnection cnn;

        //public Connection()
        //{
        //    OpenConnection();
        //}

        //public void OpenConnection()
        //{
        //    cnn = new SqlConnection();
        //    cnn.ConnectionString = connectionString;
        //    cnn.Open();
        //}

        //public void CloseConnection()
        //{
        //    cnn.Close();
        //}

        private SqlConnection Conexion = new SqlConnection("Server=localhost\\SQLEXPRESS; Database=AppIngreso; Integrated Security=True");

        public SqlConnection OpenConnection()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CloseConnection()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

    }
}
