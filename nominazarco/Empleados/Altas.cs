using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace nominazarco
{
    public partial class Altas : Form
    {
        Conexion c = new Conexion();
        Validacion v = new Validacion();

        SqlConnection cn = new SqlConnection("Data Source=ZARCOSERVER\\SQLSERVER;Initial Catalog=floreria;Persist Security Info=True;User ID=sa;Password=sasa");
        

        public Altas()
        {
            InitializeComponent();
            txt_ID.Enabled = false;
            txt_Nompuesto.Enabled = false;

            cn.Open();

            SqlCommand cm = new SqlCommand("Select max(id_empleado) as id_empleado From empleado", cn);
            cm.CommandType = CommandType.Text;
            string iden = cm.ExecuteScalar().ToString();
            if (iden == "")
            {
                txt_ID.Text = "1";
            }
            else
            {
                txt_ID.Text = Convert.ToString(Int32.Parse(iden) + 1);
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.solonumeros(e);
        }

        private void txt_IDPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.solonumeros(e);
        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            if (txt_ID.Text == "")
            {
                MessageBox.Show("ntroduzca el ID del empleado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_Nombre.Text == "")
            {
                MessageBox.Show("Introduzca el nombre del empleado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_Direccion.Text == "")
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
                MessageBox.Show(c.Altas_empleados(Convert.ToInt32(txt_ID.Text), txt_Nombre.Text, txt_Direccion.Text, txt_Telefono.Text, txt_RFC.Text, txt_NSS.Text, Convert.ToInt32(txt_Idpuesto.Text)));
                this.Close();
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
