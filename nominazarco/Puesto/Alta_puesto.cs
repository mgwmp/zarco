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
    public partial class Alta_puesto : Form
    {
        Conexion c = new Conexion();
        Validacion v = new Validacion();

        SqlConnection cn = new SqlConnection("Data Source=ZARCOSERVER\\SQLSERVER;Initial Catalog=floreria;Persist Security Info=True;User ID=sa;Password=sasa");
        public Alta_puesto()
        {
            InitializeComponent();
            txt_Idpuesto.Enabled = false;

            cn.Open();

            SqlCommand cm = new SqlCommand("Select max(id_puesto) as id_puesto From puesto", cn);
            cm.CommandType = CommandType.Text;
            string iden = cm.ExecuteScalar().ToString();
            if (iden == "")
            {
                txt_Idpuesto.Text = "1";
            }
            else
            {
                txt_Idpuesto.Text = Convert.ToString(Int32.Parse(iden) + 1);
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_Idpuesto.Text == "")
            {
                MessageBox.Show("ntroduzca el ID del empleado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_Nompuesto.Text == "")
            {
                MessageBox.Show("Introduzca el nombre del empleado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_salario.Text == "")
            {
                MessageBox.Show("Introduzca la dirección del empleado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_horario.Text == "")
            {
                MessageBox.Show("Introduzca el teléfono del empleado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(c.Altas_puesto(Convert.ToInt32(txt_Idpuesto.Text), txt_Nompuesto.Text, Convert.ToDouble(txt_salario.Text), txt_horario.Text));
                this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Idpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.solonumeros(e);
        }

        private void txt_Nompuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sololetras(e);
        }

        private void txt_salario_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.solonumeros_(e);
        }
    }
}
