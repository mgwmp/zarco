using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace nominazarco.Bonos
{
    public partial class Alta_Adelanto : Form
    {
        Conexion c = new Conexion();
        Validacion v = new Validacion();

        SqlConnection cn = new SqlConnection("Data Source=ZARCOSERVER\\SQLSERVER;Initial Catalog=floreria;Persist Security Info=True;User ID=sa;Password=sasa");

        public Alta_Adelanto()
        {
            InitializeComponent();

            cn.Open();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "")
            {
                MessageBox.Show("ntroduzca el ID del empleado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_NombreEmpleado.Text == "")
            {
                MessageBox.Show("Error empleado invalido.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_Puesto.Text == "")
            {
                MessageBox.Show("Error puesto invalido.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    var isoDateTimeFormat = CultureInfo.InvariantCulture.DateTimeFormat;
                    SqlCommand cmd = new SqlCommand("INSERT INTO adelanto (fecha_creacion, cantidad, id_empleado)" +
                                                    " VALUES('" + dtp_FechaBono.Value.ToString(isoDateTimeFormat) + "','" + txt_CantidadBono.Text + "','" + txt_ID.Text + "');", cn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteScalar();
                    MessageBox.Show("adelanto registrado con exito.");
                    this.Close();
                }
                catch(Exception df)
                {
                    MessageBox.Show("Ocurrio un error al intentar registrar el adelanto.\n Error : \n" + df.ToString(), "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

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
                    SqlCommand cmd = new SqlCommand("Select nombre_empleado From empleado where id_empleado = '" + txt_ID.Text + "'", cn);
                    cmd.CommandType = CommandType.Text;
                    txt_NombreEmpleado.Text = cmd.ExecuteScalar().ToString();

                    cmd = new SqlCommand("SELECT puesto.nombre_puesto FROM empleado INNER JOIN puesto ON empleado.id_puesto = puesto.id_puesto WHERE empleado.id_empleado = '" + txt_ID.Text + "'", cn);
                    cmd.CommandType = CommandType.Text;
                    txt_Puesto.Text = cmd.ExecuteScalar().ToString();
                }
                catch
                {
                    MessageBox.Show("No se encontró el número de identificación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txt_CantidadBono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.solonumeros_(e);
        }
    }
}
