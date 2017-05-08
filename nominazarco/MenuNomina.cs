using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace nominazarco
{
    public partial class MenuNomina : Form
    {
        Conexion c = new Conexion();
        Validacion v = new Validacion();
        SqlConnection cn;
        SqlCommand cmd;

        public MenuNomina()
        {
            InitializeComponent();
            txt_Nombre.Enabled = false;
            Reloj.Enabled = true;

            cn = new SqlConnection("Data Source=.;Initial Catalog=floreria;Integrated Security=True");
            cn.Open();
        }

        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.solonumeros(e);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "")
            {
                MessageBox.Show("Introduzca su ID de empleado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("Select nombre_empleado From empleado where id_empleado = '" + txt_ID.Text + "'", cn);
                    cmd.CommandType = CommandType.Text;
                    txt_Nombre.Text = cmd.ExecuteScalar().ToString();
                }
                catch
                {
                    MessageBox.Show("No se encontró el número de identificación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }            
        }

        private void btn_Entrada_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "")
            {
                MessageBox.Show("Identifiquese realizando la búsqueda por su ID de usuario", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DateTime FechaActual = DateTime.Now;
                string Fecha = Convert.ToString(FechaActual);

                MessageBox.Show(c.Altas_entradas(Fecha, Convert.ToInt32(txt_ID.Text)));
            }
        }

        private void btn_Salida_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "")
            {
                MessageBox.Show("Identifiquese realizando la búsqueda por su ID de usuario", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DateTime FechaActual = DateTime.Now;
                string Fecha = Convert.ToString(FechaActual);

                MessageBox.Show(c.Altas_salidas(Fecha, Convert.ToInt32(txt_ID.Text)));
            }
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            label_reloj.Text = DateTime.Now.ToString();
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nóminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nomina frm = new Nomina();
            frm.Show();
        }

        private void Altas_Click(object sender, EventArgs e)
        {
            Altas frm = new Altas();
            frm.Show();
        }

        private void Bajas_Click(object sender, EventArgs e)
        {
            Bajas frm = new Bajas();
            frm.Show();
        }

        private void Actualizacion_Click(object sender, EventArgs e)
        {
            Editar frm = new Editar();
            frm.Show();
        }
    }
}
