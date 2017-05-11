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
    public partial class Consulta_puestos : Form
    {
        public BindingSource bindingSource1 = new BindingSource();
        Conexion c = new Conexion();
        SqlConnection cn;

        public Consulta_puestos()
        {
            InitializeComponent();

            cn = new SqlConnection("Data Source=ZARCOSERVER\\SQLSERVER;Initial Catalog=floreria;Persist Security Info=True;User ID=sa;Password=sasa");
            cn.Open();

            Consultar();
        }

        string comando = "select id_puesto as 'Id puesto', nombre_puesto as Nombre, salario, horario from puesto";

        public void Consultar()
        {
            dgv_con.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            SqlCommand cmd = new SqlCommand(comando, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_con.DataSource = dt;
            cn.Close();
        }
    }
}
