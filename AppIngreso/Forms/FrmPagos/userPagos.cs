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
using AppIngreso.Forms.Ingreso;
using AppIngreso;

namespace AppIngreso.cUser_Pagos
{
    public partial class userPagos : Form
    {
        static List<pagos> listPagos = new List<pagos>();
        public DataTable obj_ListUser;
        static int cod = 0;

        public userPagos()
        {
            InitializeComponent();
        }

        private void userPagos_Load_1(object sender, EventArgs e)
        {
            CargaDatos();
            //CargarCombo(obj_ListUser);
            actualizar();
        }

        public void CargarCombo(string pDisplay, string pValue, DataTable dt)
        {
            this.cmbUser.DisplayMember = pDisplay;
            this.cmbUser.ValueMember = pValue;
            this.cmbUser.DataSource = dt;
        }

        public void CargaDatos()
        {
            try
            {
                this.cmbUser.DisplayMember = "Nombre";
                this.cmbUser.ValueMember = "Id";
                this.cmbUser.DataSource = obj_ListUser;

            }
            catch (Exception)
            {
                MessageBox.Show("Error generado al ejecutar la acción.");
                throw;
            }
        }

        private void tsbInsertar_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text != "" && cmbUser.SelectedValue != null)
            {
                cod++;
                pagos us = new pagos(cod, Convert.ToInt32(cmbUser.SelectedValue), Convert.ToInt32(txtMonto.Text), dtpDesde.Value, dtpHasta.Value);
                listPagos.Add(us);
                MessageBox.Show("Pago insertado", "Pagos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizar();
                limpiar();
            }
            else 
            {
                MessageBox.Show("No puede haber campos vacíos, favor revisar", "Error en campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void limpiar()
        {
            this.txtMonto.Text = "";
            //this.cmbUser.value = -1;
            this.dtpDesde.Value = DateTime.Now;
            this.dtpHasta.Value = DateTime.Now;
        }

        public void actualizar()
        {
            this.dgGeneral.DataSource = null;
            this.dgGeneral.DataSource = listPagos;
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgGeneral.RowCount == 0)
            {
                MessageBox.Show("Primero se deben agregar usurarios", "Sin usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmIngreso frm = new frmIngreso();
                frm.obj_Pagos = listPagos;
                frm.ShowDialog();
            }
        }
    }
}
