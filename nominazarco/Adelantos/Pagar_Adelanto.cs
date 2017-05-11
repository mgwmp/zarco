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

namespace nominazarco.Bonos
{
    public partial class Pagar_Adelanto : Form
    {
        Conexion c = new Conexion();
        Validacion v = new Validacion();

        SqlConnection cn = new SqlConnection("Data Source=ZARCOSERVER\\SQLSERVER;Initial Catalog=floreria;Persist Security Info=True;User ID=sa;Password=sasa");

        public Pagar_Adelanto()
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
                    using (SqlCommand cmd = new SqlCommand("SELECT id_adelanto AS 'Identificador del adelanto', fecha_creacion AS 'Fecha de creacion',cantidad"+
                                                        " FROM adelanto WHERE activo = 1 AND id_empleado ='" + txt_ID.Text+"';", cn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dgd_Bonos.DataSource = dt;
                            }
                        }
                    }
                }
                catch(Exception df)
                {
                    MessageBox.Show("Ocurrio un error al buscar el empleado. \n Error : \n"+df.ToString(), "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dgd_Bonos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgd_Bonos.Rows[rowIndex];
            if (MessageBox.Show("¿ Dese pagar el adelanto siguiente ?\n"+
                                "Identificador del adelanto : "+ row.Cells[0].Value.ToString()+"\n"+
                                "Fecha de creacion del adelanto : " + row.Cells[1].Value.ToString()+"\n"+
                                "Monto del adelanto : " + row.Cells[2].Value.ToString(), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE adelanto SET activo = 0 WHERE id_adelanto = '" + row.Cells[0].Value.ToString() + "';", cn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteScalar();
                    MessageBox.Show("Adelanto pagado con exito.");
                    this.Close();
                }
                catch (Exception df)
                {
                    MessageBox.Show("Ocurrio un error al intentar pagar el adelanto.\n Error : \n" + df.ToString(), "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
