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
    public partial class Asitencia : Form
    {
        public BindingSource bindingSource1 = new BindingSource();
        Conexion c = new Conexion();
        SqlConnection cn;

        public Asitencia()
        {
            InitializeComponent();
            dgv_asi.Enabled = false;
            cn = new SqlConnection("Data Source=ZARCOSERVER\\SQLSERVER;Initial Catalog=floreria;Persist Security Info=True;User ID=sa;Password=sasa");
            cn.Open();

        }

        string comando = "";

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            comando = "select E.nombre_empleado as Nombre, A.entrada, A.salida from empleado as E inner join asistencia as A on E.id_empleado =  A.id_empleado where A.entrada like '%" + dtp_fecha.Value.ToShortDateString() + "%';";
            //comando = "select E.nombre_empleado, A.entrada, A.salida from empleado as E inner join asistencia as A on E.id_empleado =  A.id_empleado;";
            Consultar(comando);
            //textBox1.Text = dtp_fecha.Value.ToShortDateString();
        }

        public void Consultar(string com)
        {
            dgv_asi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            SqlCommand cmd = new SqlCommand(com, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_asi.DataSource = dt;
            cn.Close();
        }

    }
}
