//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using AppIngreso;
//using System.Data.SqlClient;
//using System.Data;

//namespace AppIngreso.DTOs
//{
//    public class Users
//    {
//        private Connection cnn = new Connection();

//        SqlCommand cmd = new SqlCommand();
//        DataTable listUsers = new DataTable();
//        SqlDataReader Read;

//        #region Atributos
//        public int _Id { get; set; }
//        public string _Nombre { get; set; }
//        public string _Apellido { get; set; }
//        public string _Correo { get; set; }
//        public DateTime _fnacimiento { get; set; }
//        public DateTime _finicio { get; set; }
//        public int _Edad { get; set; }

//        //List<users> listUsers { get; set; }
//        #endregion

//        public Users()
//        {
//            this._Id = 0;
//            this._Nombre = "";
//            this._Apellido = "";
//            this._Correo = "";
//            this._fnacimiento = DateTime.Now;
//            this._finicio = DateTime.Now;
//            this._Edad = Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(this._fnacimiento.Year);
//        }

//        public Users(int pId, string pNombre, string pApellido, string pCorreo, DateTime pFnacimiento, DateTime pFinicio)
//        {
//            this._Id = pId;
//            this._Nombre = pNombre;
//            this._Apellido = pApellido;
//            this._Correo = pCorreo;
//            this._fnacimiento = pFnacimiento;
//            this._finicio = pFinicio;
//            this._Edad = Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(this._fnacimiento.Year);
//        }

//        public string NombreCompleto(string pNombre, string pApellido)
//        {
//            string nombrecompleto = this._Nombre + " " + this._Apellido;
//            return nombrecompleto;
//        }

//        public void Insert(int pId, string pName)
//        {
//            cmd.Connection = cnn.OpenConnection();
//            cmd.CommandText = "insert into test (id, nombre) values(" + pId + ", '" + pName + "')";
//            cmd.CommandType = CommandType.Text;
//            cmd.ExecuteNonQuery();
//        }

//        public DataTable Select()
//        {
//            cmd.Connection = cnn.OpenConnection();
//            cmd.CommandText = "select * from test";
//            cmd.CommandType = CommandType.Text;
//            Read = cmd.ExecuteReader();
//            listUsers.Load(Read);
//            cnn.CloseConnection();
//            return listUsers;
//        }

//        public DataTable Select(int where)
//        {
//            cmd.Connection = cnn.OpenConnection();
//            cmd.CommandText = "select * from test where id=" + where;
//            cmd.CommandType = CommandType.Text;
//            Read = cmd.ExecuteReader();
//            listUsers.Load(Read);
//            cnn.CloseConnection();
//            return listUsers;
//        }
//    }
//}
