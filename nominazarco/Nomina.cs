using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nominazarco
{
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();

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
            if (txt_ID.Text == "")
            {
                MessageBox.Show("Realice la búsqueda del empleado por su ID", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

            }
        }
    }
}
