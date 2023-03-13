using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppIngreso.DTOs;
using AppIngreso.cUser_Pagos;
using AppIngreso.Forms.FrmUsers;
using AppIngreso;

namespace AppIngreso
{
    public partial class frmGridUsers : Form
    {                   
        public frmGridUsers()
        {
            InitializeComponent();
        }

        private void frmGridUsers_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void tsbInsertar_Click(object sender, EventArgs e)
        {
            FrmMantUsers frm = new FrmMantUsers();
            frm.Accion = "Insertar";
            frm.ShowDialog();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            FrmMantUsers frm = new FrmMantUsers();
            frm.Accion = "Modificar";
            frm.ShowDialog();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            Users us = new Users();
            us.Accion = "Eliminar";
            us.Delete(txtId.Text);
            MessageBox.Show("Usuario eliminado");
            actualizar();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbRefrescar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        public void actualizar()
        {
            Users us = new Users();
            var dt = us.Select();
            this.dgGeneral.DataSource = dt;
        }

        private void Pagos_Click(object sender, EventArgs e)
        {
            if (dgGeneral.RowCount == 0)
            {
                MessageBox.Show("Primero se deben agregar usurarios", "Sin usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Users us = new Users();
                userPagos frm = new userPagos();
                frm.obj_ListUser = us.Select(); ;
                frm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users us = new Users();
            //us.Insert(Convert.ToInt32(txtId.Text), txtName.Text);
            var dt = us.Select(txtId.Text);
            ShowData();

        }

        public void ShowData()
        {
            Users us = new Users();
            var dt = us.Select();
            dt.Columns.Add("Id").Caption = "Identificación";
            //dt.Columns.Add("Cédula").ColumnName = "Cedula";
            //dt.Columns.Add("Primer Nombre").ColumnName = "Nombre";
            //dt.Columns.Add("Segundo Nombre").ColumnName = "Nombre2";
            //dt.Columns.Add("Primer Apellido").ColumnName = "Apellido";
            //dt.Columns.Add("Segundo Apellido").ColumnName = "Apellido2";
            //dt.Columns.Add("Correo").ColumnName = "Correo";
            //dt.Columns.Add("Fecha Nacimiento").ColumnName = "FechaNacimiento";
            //dt.Columns.Add("Fecha Inicio").ColumnName = "Fecha Inicio";
            //dt.Columns.Add("Estado").ColumnName = "Estado";
            this.dgGeneral.DataSource = dt;
        }

        //Buscar
        private void button2_Click(object sender, EventArgs e)
        {
            Users us = new Users();
            var dt = us.Select(txtId.Text);
            this.dgGeneral.DataSource = dt;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                actualizar();
            }
        }
    }
}
