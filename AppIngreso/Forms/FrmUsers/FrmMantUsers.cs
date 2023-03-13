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

namespace AppIngreso.Forms.FrmUsers
{
    public partial class FrmMantUsers : Form
    {
        Users obj_user;
        public string Accion;

        public FrmMantUsers()
        {
            InitializeComponent();
        }

        private void FrmMantUsers_Load(object sender, EventArgs e)
        {
            if (this.Accion == "Insertar")
            {
                grbDatos.Text = "Insertar un nuevo usuario";
                limpiar();
            }
            else
            {
                grbDatos.Text = "Modificar un usuario";
                this.txtNombre.Text = "te";
                this.txtNombre2.Text = "te";
                this.txtApellido.Text = "te";
                this.txtApellido2.Text = "te";
                this.txtCorreo.Text = "te";
                this.dtpNacimiento.Value = DateTime.Now;
                this.dtpInicio.Value = DateTime.Now;
                this.txtObs.Text = "te";
                this.ckbEstado.Checked = true;
            }
            
        }

        public void limpiar()
        {
            this.txtNombre.Text = "";
            this.txtNombre2.Text = "";
            this.txtApellido.Text = "";
            this.txtApellido2.Text = "";
            this.txtCorreo.Text = "";
            this.dtpNacimiento.Value = DateTime.Now;
            this.dtpInicio.Value = DateTime.Now;
            this.txtObs.Text = "";
        }

        private void tsbAceptar_Click(object sender, EventArgs e)
        {
            byte st = 0;
            if (ckbEstado.Checked == false)
            {
                st = 0;
            }
            else
            {
                st = 1;
            }
            Users us = new Users(txtCedula.Text, txtNombre.Text, txtNombre2.Text, txtApellido.Text, txtApellido2.Text, txtCorreo.Text, dtpNacimiento.Value, dtpInicio.Value, txtObs.Text, st);

            //obj_user._Cedula = txtCedula.Text;
            //obj_user._Nombre = txtNombre.Text;
            //obj_user._Nombre2 = txtNombre2.Text;
            //obj_user._Apellido = txtApellido.Text;
            //obj_user._Apellido2 = txtApellido2.Text;
            //obj_user._Correo = txtCorreo.Text;
            //obj_user._fnacimiento = dtpNacimiento.Value;
            //obj_user._finicio = dtpInicio.Value;
            //obj_user._Observaciones = txtObs.Text;
            //if (ckbEstado.Checked == false)
            //{
            //    obj_user._Estado = 0;
            //}
            //else
            //{
            //    obj_user._Estado = 1;
            //}
            //us.obj_users = this.obj_user;

            //--------------------------------------------------------------------------------
            if (this.Accion == "Insertar")
            {
                us.Insert();
                MessageBox.Show("Usuario insertado");
                limpiar();
            }
            else
            {
                //us.obj_users = this.obj_user;
                us.Update();
                MessageBox.Show("Usuario modificado");
            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void frmGridUsers_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public void ShowData()
        {
            Users us = new Users();
            var dt = us.Select();
            //this.dgGeneral.DataSource = dt;
        }
    }
}
