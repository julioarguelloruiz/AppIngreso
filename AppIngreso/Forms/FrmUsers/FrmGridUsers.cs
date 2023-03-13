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
            try
            {
                Users us = new Users();
                us.Accion = "Eliminar";
                us.Delete(txtId.Text);
                MessageBox.Show("Usuario eliminado");
                actualizar();
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void frmGridUsers_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public void ShowData()
        {
            Users us = new Users();
            var dt = us.Select();
            this.dgGeneral.DataSource = dt;
        }

        //Buscar
        private void button2_Click(object sender, EventArgs e)
        {
            Users us = new Users();
            var dt = us.Select(txtId.Text);
            this.dgGeneral.DataSource = dt;
        }

        //Eliminar
        private void button1_Click_2(object sender, EventArgs e)
        {
            Users us = new Users();
            var dt = us.Select(txtId.Text);
            this.dgGeneral.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}
