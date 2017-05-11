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
    public partial class Bajas : Form
    {
        Conexion c = new Conexion();
        Validacion v = new Validacion();
        SqlConnection cn;
        SqlCommand cmd;

        public Bajas()
        {
            InitializeComponent();

            txt_Nombre.Enabled = false;
            cn = new SqlConnection("Data Source=ZARCOSERVER\\SQLSERVER;Initial Catalog=floreria;Persist Security Info=True;User ID=sa;Password=sasa");
            cn.Open();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
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
                }
                catch
                {
                    MessageBox.Show("No se encontró el número de identificación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.solonumeros(e);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "")
            {
                MessageBox.Show("Realice la búsqueda del empleado por su ID", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {                
                var confirmar = MessageBox.Show("¿Seguro que desea dar de baja al empleado?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmar == DialogResult.Yes)
                {
                    MessageBox.Show(c.Bajas_empleados(Convert.ToInt32(txt_ID.Text)));
                    this.Close();
                }
            }
        }

        private void Bajas_Load(object sender, EventArgs e)
        {

        }
    }
}
