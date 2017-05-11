using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace nominazarco
{
    public partial class Editar : Form
    {
        Conexion c = new Conexion();
        Validacion v = new Validacion();
        SqlConnection cn;
        SqlCommand cmd;

        public Editar()
        {
            InitializeComponent();

            txt_Nombre.Enabled = false;
            txt_Direccion.Enabled = false;
            txt_Telefono.Enabled = false;
            txt_RFC.Enabled = false;
            txt_NSS.Enabled = false;
            txt_Nompuesto.Enabled = false;
            txt_Idpuesto.Enabled = false;

            txt_Nombre.Enabled = false;
            cn = new SqlConnection("Data Source=ZARCOSERVER\\SQLSERVER;Initial Catalog=floreria;Persist Security Info=True;User ID=sa;Password=sasa");
            cn.Open();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.solonumeros(e);
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "")
            {
                MessageBox.Show("Realice la búsqueda del empleado por su ID", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_Nombre.Text == "")
            {
                MessageBox.Show("Introduzca el nombre del empleado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(txt_Direccion.Text == "")
            {
                MessageBox.Show("Introduzca la dirección del empleado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_Telefono.Text == "")
            {
                MessageBox.Show("Introduzca el teléfono del empleado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_RFC.Text == "")
            {
                MessageBox.Show("Introduzca el RFC del empelado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_NSS.Text == "")
            {
                MessageBox.Show("Introduzca el NSS del empleado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_Idpuesto.Text == "")
            {
                MessageBox.Show("Introduzca ID del puesto del empleado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(c.Actualizar_empleado(Convert.ToInt32(txt_ID.Text), txt_Nombre.Text, txt_Direccion.Text, txt_Telefono.Text, txt_RFC.Text, txt_NSS.Text, Convert.ToInt32(txt_Idpuesto.Text)));
                this.Close();
            }
        }

        private void txt_IDPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.solonumeros(e);
        }

        private void r_Editar_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "")
            {
               MessageBox.Show("Realice la búsqueda del empleado por su ID", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txt_Nombre.Enabled = true;
                txt_Direccion.Enabled = true;
                txt_Telefono.Enabled = true;
                txt_RFC.Enabled = true;
                txt_NSS.Enabled = true;
                txt_Idpuesto.Enabled = true;
            }
        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            if (txt_ID.Text == "")
            {
                MessageBox.Show("Realice la búsqueda del empleado por su ID", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("Select nombre_empleado From empleado where id_empleado = '" + txt_ID.Text + "'", cn);
                    cmd.CommandType = CommandType.Text;
                    txt_Nombre.Text = cmd.ExecuteScalar().ToString();

                    cmd = new SqlCommand("Select direccion_empleado From empleado where id_empleado = '" + txt_ID.Text + "'", cn);
                    cmd.CommandType = CommandType.Text;
                    txt_Direccion.Text = cmd.ExecuteScalar().ToString();

                    cmd = new SqlCommand("Select telefono_empleado From empleado where id_empleado = '" + txt_ID.Text + "'", cn);
                    cmd.CommandType = CommandType.Text;
                    txt_Telefono.Text = cmd.ExecuteScalar().ToString();

                    cmd = new SqlCommand("Select rfc_empleado From empleado where id_empleado = '" + txt_ID.Text + "'", cn);
                    cmd.CommandType = CommandType.Text;
                    txt_RFC.Text = cmd.ExecuteScalar().ToString();

                    cmd = new SqlCommand("Select nss From empleado where id_empleado = '" + txt_ID.Text + "'", cn);
                    cmd.CommandType = CommandType.Text;
                    txt_NSS.Text = cmd.ExecuteScalar().ToString();

                    cmd = new SqlCommand("Select id_puesto From empleado where id_empleado = '" + txt_ID.Text + "'", cn);
                    cmd.CommandType = CommandType.Text;
                    txt_Idpuesto.Text = cmd.ExecuteScalar().ToString();

                    cmd = new SqlCommand("Select nombre_puesto From puesto where id_puesto = '" + txt_Idpuesto.Text + "'", cn);
                    cmd.CommandType = CommandType.Text;
                    txt_Nompuesto.Text = cmd.ExecuteScalar().ToString();
                }
                catch
                {
                    MessageBox.Show("No se encontró el número de identificación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                r_Editar.Checked = false;

                txt_Nombre.Enabled = false;
                txt_Direccion.Enabled = false;
                txt_Telefono.Enabled = false;
                txt_RFC.Enabled = false;
                txt_NSS.Enabled = false;
            }
        }

        private void txt_Idpuesto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_Idpuesto.Text == "")
                {
                    txt_Nompuesto.Clear();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Select nombre_puesto From puesto where id_puesto = '" + txt_Idpuesto.Text + "'", cn);
                    cmd.CommandType = CommandType.Text;
                    txt_Nompuesto.Text = cmd.ExecuteScalar().ToString();
                }
            }
            catch
            {
                MessageBox.Show("No existe el puesto", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Idpuesto.Clear();
            }
        }
    }
}
