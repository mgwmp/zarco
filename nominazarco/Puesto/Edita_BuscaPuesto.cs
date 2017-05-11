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
    public partial class Edita_BuscaPuesto : Form
    {
        Conexion c = new Conexion();
        Validacion v = new Validacion();
        SqlConnection cn;
        SqlCommand cmd;

        public Edita_BuscaPuesto()
        {
            InitializeComponent();

            txt_Nompuesto.Enabled = false;           
            txt_salario.Enabled = false;
            txt_horario.Enabled = false;

            cn = new SqlConnection("Data Source=ZARCOSERVER\\SQLSERVER;Initial Catalog=floreria;Persist Security Info=True;User ID=sa;Password=sasa");
            cn.Open();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txt_Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.solonumeros(e);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "")
            {
                MessageBox.Show("Realice la búsqueda del puesto por su ID", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("Select nombre_puesto From puesto where id_puesto = '" + txt_ID.Text + "'", cn);
                    cmd.CommandType = CommandType.Text;
                    txt_Nompuesto.Text = cmd.ExecuteScalar().ToString();

                    cmd = new SqlCommand("Select salario From puesto where id_puesto = '" + txt_ID.Text + "'", cn);
                    cmd.CommandType = CommandType.Text;
                    txt_salario.Text = cmd.ExecuteScalar().ToString();

                    cmd = new SqlCommand("Select horario From puesto where id_puesto = '" + txt_ID.Text + "'", cn);
                    cmd.CommandType = CommandType.Text;
                    txt_horario.Text = cmd.ExecuteScalar().ToString();

                }
                catch
                {
                    MessageBox.Show("No se encontró el número de identificación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                r_Editar.Checked = false;

                txt_Nompuesto.Enabled = false;
                txt_salario.Enabled = false;
                txt_horario.Enabled = false;
            }
        }

        private void r_Editar_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_ID.Text == "")
            {
                MessageBox.Show("Realice la búsqueda del puesto por su ID", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txt_horario.Enabled = true;
                txt_salario.Enabled = true;
                txt_Nompuesto.Enabled = true;
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "")
            {
                MessageBox.Show("Realice la búsqueda del puesto por su ID", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_Nompuesto.Text == "")
            {
                MessageBox.Show("Introduzca el nombre del puesto", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_salario.Text == "")
            {
                MessageBox.Show("Introduzca el salario", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_horario.Text == "")
            {
                MessageBox.Show("Introduzca el horario", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                MessageBox.Show(c.Actualizar_puesto(Convert.ToInt32(txt_ID.Text), txt_Nompuesto.Text, Convert.ToDouble(txt_salario.Text), txt_horario.Text ));
                this.Close();
            }
        }

        private void txt_Nompuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sololetras(e);
        }

        private void txt_salario_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.solonumeros_(e);
        }

        private void btn_con_Click(object sender, EventArgs e)
        {
            Consulta_puestos conp = new Consulta_puestos();
            conp.Show();
        }
    }
}
