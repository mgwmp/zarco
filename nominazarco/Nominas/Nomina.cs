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

namespace nominazarco
{
    public partial class Nomina : Form
    {
        Validacion v = new Validacion();
        SqlConnection cn = new SqlConnection("Data Source=ZARCOSERVER\\SQLSERVER;Initial Catalog=floreria;Persist Security Info=True;User ID=sa;Password=sasa");
        double salarioEmpleado;
        public Nomina()
        {
            InitializeComponent();
            salarioEmpleado = 0;

            cn.Open();


            SqlCommand cm = new SqlCommand("Select max(id_nomina) as id_nomina From nomina", cn);
            cm.CommandType = CommandType.Text;
            string iden = cm.ExecuteScalar().ToString();
            if (iden == "")
            {
                txt_Idnom.Text = "1";
            }
            else
            {
                txt_Idnom.Text = Convert.ToString(Int32.Parse(iden) + 1);
            }
        
            txt_Nombre.Enabled = false;
            txt_Sueldo.Enabled = false;
            txt_Idnom.Enabled = false;
            date_Fecha.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_idempleado.Text == "")
                {
                    MessageBox.Show("Realice la búsqueda del empleado por su ID", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Select nombre_empleado From empleado where id_empleado = '" + txt_idempleado.Text + "'", cn);
                    cmd.CommandType = CommandType.Text;
                    txt_Nombre.Text = cmd.ExecuteScalar().ToString();

                    cmd = new SqlCommand("SELECT puesto.salario FROM empleado INNER JOIN puesto ON empleado.id_puesto = puesto.id_puesto WHERE empleado.id_empleado = '" + txt_idempleado.Text + "'", cn);
                    cmd.CommandType = CommandType.Text;
                    salarioEmpleado = Convert.ToDouble(cmd.ExecuteScalar());


                    cmd = new SqlCommand("SELECT SUM(CAST(cantidad AS decimal)) FROM bono WHERE activo = 1 and id_empleado ='" + txt_idempleado.Text + "'", cn);
                    cmd.CommandType = CommandType.Text;
                    txt_Bonos.Text = cmd.ExecuteScalar().ToString();
                    /*txt_Bonos.Text = cmd.ExecuteScalar().ToString();*/

                    cmd = new SqlCommand("SELECT SUM(CAST(cantidad AS decimal)) FROM adelanto WHERE activo = 1 and id_empleado ='" + txt_idempleado.Text + "'", cn);
                    cmd.CommandType = CommandType.Text;
                    txt_Adelantos.Text = cmd.ExecuteScalar().ToString();

                }
            }
            catch(Exception df)
            {
                MessageBox.Show("No existe el empleado : \n"+df.ToString(), "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_idempleado.Clear();
            }
        }

        private void txt_Dias_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.solonumeros(e);
        }

        private void txt_Horas_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.solonumeros(e);
        }
        private void txt_Dias_Leave(object sender, EventArgs e)
        {
            if (txt_Dias.Text == "0")
            {
                MessageBox.Show("Imposible trabajar con 0 dias.");
                txt_Dias.Clear();
            }
        }

        private void txt_Horas_Leave(object sender, EventArgs e)
        {
            if (txt_Horas.Text == "0")
            {
                MessageBox.Show("Imposible trabajar con 0 horas.");
                txt_Horas.Clear();
            }
        }
        
        private void calculaSueldo_KeyUp(object sender, KeyEventArgs e)
        {
            txt_Sueldo.Text = calculaSueld();
        }
        private String calculaSueld()
        {
            double sueldoPrevio = 0;
             // SALARIO MULTIPLICADO POR LAS HORAS TRABAJADAS 
            if (txt_Horas.Text != "")
            {
                sueldoPrevio = Convert.ToDouble(txt_Horas.Text) * salarioEmpleado;
            }
            if (txt_Dias.Text != "")
            {
                int horasEnDias = Convert.ToInt32(txt_Dias.Text) * 24;
                sueldoPrevio += horasEnDias * salarioEmpleado;
            }
            /* BONOS */
            if (txt_Bonos.Text != "")
            {
                sueldoPrevio += Convert.ToDouble(txt_Bonos.Text);
            }
            if (txt_Adelantos.Text != "")
            {
                sueldoPrevio -= Convert.ToDouble(txt_Adelantos.Text);
            }

            return sueldoPrevio.ToString();
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            if (txt_idempleado.Text == "")
            {
                MessageBox.Show("Introduzca el ID del empleado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_Nombre.Text == "")
            {
                MessageBox.Show("Nombre empleado no valido", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_Horas.Text == "" && txt_Dias.Text == "")
            {
                MessageBox.Show("Introduzca la cantidad de horas o dias trabajados por el empleado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (txt_idempleado.Text == "")
                    {
                        MessageBox.Show("Realice la búsqueda del empleado por su ID", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }else if (txt_Horas.Text == "" && txt_Dias.Text == "")
                    {
                        MessageBox.Show("Introduzca la cantidad de horas o dias trabajados por el empleado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        var isoDateTimeFormat = CultureInfo.InvariantCulture.DateTimeFormat;
                        string longSqlQuery = "INSERT INTO nomina (id_empleado, fecha_nomina, dias_trabajados, horas_trabajadas, sueldo_neto, bonos,adelantos)" +
                                                        " VALUES('" + txt_idempleado.Text + "','" + date_Fecha.Value.ToString(isoDateTimeFormat) + "','" + txt_Dias.Text + "','" +
                                                        txt_Horas.Text + "','" + txt_Sueldo.Text + "','" + txt_Bonos.Text + "','" + txt_Adelantos.Text + "' )";
                        SqlCommand cmd = new SqlCommand(longSqlQuery, cn);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteScalar();
                        MessageBox.Show("Nomina registrada con exito.\n Procesando PDF...");
                        this.Close();
                    }
                }
                catch (Exception df)
                {
                    MessageBox.Show("No existe el empleado : \n" + df.ToString(), "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_idempleado.Clear();
                }
            }
        }
    }
    
}
/*
SELECT
        [entrada]
      ,[salida]
      ,[id_empleado]
FROM[floreria].[dbo].[asistencia]
WHERE CONVERT(VARCHAR(25), entrada, 126) LIKE '%/05/2017%'

    POR SI SALEN CON ALGO

     */