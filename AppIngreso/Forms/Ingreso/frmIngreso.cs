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


namespace AppIngreso.Forms.Ingreso
{
    public partial class frmIngreso : Form
    {
        public List<pagos> obj_Pagos;

        public frmIngreso()
        {
            InitializeComponent();
            txtId.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pagosgroup = from p in obj_Pagos 
                             select p;

            foreach (var p in pagosgroup)
            {
                //if ()
                //{
                    if (p._IdUser == Convert.ToInt32(txtId.Text))
                    {
                        lblMemsaje.Text = "Membresía vigente";
                        lblMemsaje.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblMemsaje.Text = "Membresía caducada";
                        lblMemsaje.ForeColor = Color.Red;
                    } 
                //}
                //else
                //{

                //}
                
            }
                //p._IdUser = Convert.ToInt32(txtId.Text);
        }
    }
}
