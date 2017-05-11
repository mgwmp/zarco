using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using nominazarco.Bonos;
using nominazarco.Nominas;
using System.Windows;

namespace nominazarco
{
    public partial class MenuNomina : Form
    {
        Conexion c = new Conexion();
        Validacion v = new Validacion();
        SqlConnection cn;
        SqlCommand cmd;

        public MenuNomina()
        {
            InitializeComponent();
            txt_Nombre.Enabled = false;
            Reloj.Enabled = true;
            //TODO CAMBIAR DATA SOURCE
            cn = new SqlConnection("Data Source=ZARCOSERVER\\SQLSERVER;Initial Catalog=floreria;Persist Security Info=True;User ID=sa;Password=sasa");
            cn.Open();
        }

        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.solonumeros(e);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "")
            {
                MessageBox.Show("Introduzca su ID de empleado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btn_Entrada_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "")
            {
                MessageBox.Show("Identifiquese realizando la búsqueda por su ID de usuario", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DateTime FechaActual = DateTime.Now;
                string Fecha = Convert.ToString(FechaActual);

                MessageBox.Show(c.Altas_entradas(Fecha, Convert.ToInt32(txt_ID.Text)));
            }
        }

        private void btn_Salida_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "")
            {
                MessageBox.Show("Identifiquese realizando la búsqueda por su ID de usuario", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DateTime FechaActual = DateTime.Now;
                string Fecha = Convert.ToString(FechaActual);

                MessageBox.Show(c.Altas_salidas(Fecha, Convert.ToInt32(txt_ID.Text)));
            }
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            label_reloj.Text = DateTime.Now.ToString();
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nóminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Altas_Click(object sender, EventArgs e)
        {
            Altas frm = new Altas();
            frm.Show();
        }

        private void Bajas_Click(object sender, EventArgs e)
        {
            Bajas frm = new Bajas();
            frm.Show();
        }

        private void Actualizacion_Click(object sender, EventArgs e)
        {
            Editar frm = new Editar();
            frm.Show();
        }

        private void agregarPuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alta_puesto apst = new Alta_puesto();
            apst.Show();
        }

        private void eliminarPuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baja_puesto bpst = new Baja_puesto();
            bpst.Show();
        }

        private void actualizarConsultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edita_BuscaPuesto epst = new Edita_BuscaPuesto();
            epst.Show();
        }

        private void asistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asitencia asist = new Asitencia();
            asist.Show();
        }
        private void consultarYBajasDeNominasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bajas_Consultas_Nomina frmConsultasNomina = new Bajas_Consultas_Nomina();
            frmConsultasNomina.Show();
        }

        private void registrarNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nomina frm = new Nomina();
            frm.Show();
        }

        private void registrarAdelantoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Alta_Adelanto frmrgstraradelanto = new Alta_Adelanto();
            frmrgstraradelanto.Show();
        }

        private void pagarAdelantoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pagar_Adelanto frmpagradelanto = new Pagar_Adelanto();
            frmpagradelanto.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Registrar_Bono frmrgstrarbono = new Registrar_Bono();
            frmrgstrarbono.Show();
        }

        private void eliminarBonoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Eliminar_Bono frmelimniarbono = new Eliminar_Bono();
            frmelimniarbono.Show();
        }

       /* private void exportarAPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportarPdf exportarPdf = new ExportarPdf();
            exportarPdf.Show();
        }*/
    }
}
