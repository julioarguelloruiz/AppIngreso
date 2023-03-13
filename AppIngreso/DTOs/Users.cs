using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppIngreso;
using System.Data.SqlClient;
using System.Data;

namespace AppIngreso.DTOs
{
    public class Users
    {
        private Connection cnn = new Connection();

        SqlCommand cmd = new SqlCommand();
        DataTable listUsers = new DataTable();
        SqlDataReader Read;
        public Users obj_users;
        public string Accion;

        #region Atributos
        public int _Id { get; set; }
        public string _Cedula { get; set; }
        public string _Nombre { get; set; }
        public string _Nombre2 { get; set; }
        public string _Apellido { get; set; }
        public string _Apellido2 { get; set; }
        public string _Correo { get; set; }
        public DateTime _fnacimiento { get; set; }
        public DateTime _finicio { get; set; }
        public string _Observaciones { get; set; }
        public byte _Estado { get; set; }

        public int _Edad { get; set; }

        //List<users> listUsers { get; set; }
        #endregion

        public Users()
        {
            this._Id = 0;
            this._Nombre = "";
            this._Nombre2 = "";
            this._Apellido = "";
            this._Apellido2 = "";
            this._Correo = "";
            this._fnacimiento = DateTime.Now;
            this._finicio = DateTime.Now;
            this._Observaciones = "";
            this._Estado = 0;

            this._Edad = Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(this._fnacimiento.Year);
        }

        public Users(string pCedula, string pNombre, string pNombre2, string pApellido, string pApellido2, string pCorreo, DateTime pFnacimiento, DateTime pFinicio, string pObs, byte pEstado)
        {
            this._Cedula = pCedula;
            this._Nombre = pNombre;
            this._Nombre2 = pNombre2;
            this._Apellido = pApellido;
            this._Apellido2 = pApellido2;
            this._Correo = pCorreo;
            this._fnacimiento = pFnacimiento;
            this._finicio = pFinicio;
            this._Observaciones = pObs;
            this._Estado = pEstado;
            this._Edad = Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(this._fnacimiento.Year);
        }

        public string NombreCompleto(string pNombre, string pApellido)
        {
            string nombrecompleto = this._Nombre + " " + this._Apellido;
            return nombrecompleto;
        }

        public void Insert()
        {
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "sp_insert_user";
            cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.AddWithValue("@Cedula", obj_users._Cedula);
            //cmd.Parameters.AddWithValue("@Nombre", obj_users._Nombre);
            //cmd.Parameters.AddWithValue("@Nombre2", obj_users._Nombre2);
            //cmd.Parameters.AddWithValue("@Apellido", obj_users._Apellido);
            //cmd.Parameters.AddWithValue("@Apellido2", obj_users._Apellido2);
            //cmd.Parameters.AddWithValue("@Correo", obj_users._Correo);
            //cmd.Parameters.AddWithValue("@FechaNacimiento", obj_users._fnacimiento);
            //cmd.Parameters.AddWithValue("@FechaInicio", obj_users._finicio);
            //cmd.Parameters.AddWithValue("@Observaciones", obj_users._Observaciones);
            //cmd.Parameters.AddWithValue("@Estado", obj_users._Estado);

            cmd.Parameters.AddWithValue("@Cedula", _Cedula);
            cmd.Parameters.AddWithValue("@Nombre", _Nombre);
            cmd.Parameters.AddWithValue("@Nombre2", _Nombre2);
            cmd.Parameters.AddWithValue("@Apellido", _Apellido);
            cmd.Parameters.AddWithValue("@Apellido2", _Apellido2);
            cmd.Parameters.AddWithValue("@Correo", _Correo);
            cmd.Parameters.AddWithValue("@FechaNacimiento", _fnacimiento);
            cmd.Parameters.AddWithValue("@FechaInicio", _finicio);
            cmd.Parameters.AddWithValue("@Observaciones", _Observaciones);
            cmd.Parameters.AddWithValue("@Estado", _Estado);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cnn.CloseConnection();
        }

        public void Update()
        {
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "sp_update_user";
            cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.AddWithValue("@Cedula", obj_users._Cedula);
            //cmd.Parameters.AddWithValue("@Nombre", obj_users._Nombre);
            //cmd.Parameters.AddWithValue("@Nombre2", obj_users._Nombre2);
            //cmd.Parameters.AddWithValue("@Apellido", obj_users._Apellido);
            //cmd.Parameters.AddWithValue("@Apellido2", obj_users._Apellido2);
            //cmd.Parameters.AddWithValue("@Correo", obj_users._Correo);
            //cmd.Parameters.AddWithValue("@FechaNacimiento", obj_users._fnacimiento);
            //cmd.Parameters.AddWithValue("@FechaInicio", obj_users._finicio);
            //cmd.Parameters.AddWithValue("@Observaciones", obj_users._Observaciones);
            //cmd.Parameters.AddWithValue("@Estado", obj_users._Estado);

            cmd.Parameters.AddWithValue("@Cedula", _Cedula);
            cmd.Parameters.AddWithValue("@Nombre", _Nombre);
            cmd.Parameters.AddWithValue("@Nombre2", _Nombre2);
            cmd.Parameters.AddWithValue("@Apellido", _Apellido);
            cmd.Parameters.AddWithValue("@Apellido2", _Apellido2);
            cmd.Parameters.AddWithValue("@Correo", _Correo);
            cmd.Parameters.AddWithValue("@FechaNacimiento", _fnacimiento);
            cmd.Parameters.AddWithValue("@FechaInicio", _finicio);
            cmd.Parameters.AddWithValue("@Observaciones", _Observaciones);
            cmd.Parameters.AddWithValue("@Estado", _Estado);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cnn.CloseConnection();
        }

        public void Delete(string where)
        {
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "sp_delete_user";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cedula", where);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cnn.CloseConnection();
        }

        public DataTable Select()
        {
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "select * from Users order by Id";
            cmd.CommandType = CommandType.Text;
            Read = cmd.ExecuteReader();
            listUsers.Load(Read);
            cnn.CloseConnection();
            return listUsers;
        }

        public DataTable Select(string where)
        {
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "select * from Users where cedula = '" + where +"'";
            cmd.CommandType = CommandType.Text;
            Read = cmd.ExecuteReader();
            listUsers.Load(Read);
            cnn.CloseConnection();
            return listUsers;
        }
    }
}
