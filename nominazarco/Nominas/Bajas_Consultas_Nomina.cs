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

namespace nominazarco.Nominas
{
    public partial class Bajas_Consultas_Nomina : Form
    {
        Conexion c = new Conexion();
        Validacion v = new Validacion();

        SqlConnection cn = new SqlConnection("Data Source=ZARCOSERVER\\SQLSERVER;Initial Catalog=floreria;Persist Security Info=True;User ID=sa;Password=sasa");

        public Bajas_Consultas_Nomina()
        {
            InitializeComponent();
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
                    string longSqlQuery = "SELECT n.id_nomina AS 'Identificado de la nomina' , n.fecha_nomina AS 'Fecha creacion'," +
                                           "n.sueldo_neto AS 'Sueldo neto', n.bonos AS 'Bonos', n.adelantos AS 'Adelantos'," +
                                           "e.nombre_empleado AS 'Nombre empleado', e.rfc_empleado AS 'RFC EMPLEADO' " +
                                           "FROM nomina AS n INNER JOIN empleado as e ON n.id_empleado = e.id_empleado WHERE e.id_empleado ='" + txt_ID.Text + "';";
                    using (SqlCommand cmd = new SqlCommand(longSqlQuery, cn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dgd_Nominas.DataSource = dt;
                            }
                        }
                    }
                }
                catch (Exception df)
                {
                    MessageBox.Show("Ocurrio un error al buscar el empleado. \n Error : \n" + df.ToString(), "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dgd_Nominas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgd_Nominas.Rows[rowIndex];
            if (MessageBox.Show("¿ Dese eliminar la nomina siguiente ?\n" +
                                "Identificador de la nomina : " + row.Cells[0].Value.ToString() + "\n" +
                                "Empleado de la nomina : " + row.Cells[5].Value.ToString() + "\n" +
                                "Fecha de creacion de la nomina : " + row.Cells[1].Value.ToString() + "\n" +
                                "Sueldo neto de la nomina : " + row.Cells[2].Value.ToString(), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE nomina WHERE id_nomina = '" + row.Cells[0].Value.ToString() + "';", cn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteScalar();
                    MessageBox.Show("Nomina eliminado con exito.");
                    this.Close();
                }
                catch (Exception df)
                {
                    MessageBox.Show("Ocurrio un error al intentar eliminar el nomina.\n Error : \n" + df.ToString(), "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
