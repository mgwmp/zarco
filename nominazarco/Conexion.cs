using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace nominazarco
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;

        

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=ZARCOSERVER\\SQLSERVER;Initial Catalog=floreria;Persist Security Info=True;User ID=sa;Password=sasa");
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se realizó la conexion con la base de datos, información: \n\n" + ex.ToString());
            }
        }

        public string Altas_entradas(string entrada, int id)
        {
            string mensaje = "Entrada registrada correctamente";
            try
            {
                cmd = new SqlCommand("Insert into asistencia(entrada, id_empleado) values ('" + entrada + "', " + id + ")", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                mensaje = "No se registró la entrada correctamente, acuda a un administrador, información: \n\n" + ex.ToString();
            }
            return mensaje;
        }

        public string Altas_salidas(string salida, int id)
        {
            string mensaje = "Salida registrada correctamente";
            try
            {
                DateTime FechaActual = DateTime.Now;
                string Fecha = DateTime.Now.ToShortDateString();

                cmd = new SqlCommand("UPDATE asistencia set salida = ('" + salida + "') where id_empleado = " + id + " and entrada like '" + DateTime.Now.ToString("dd/MM/yyyy") + "%'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                mensaje = "No se registró la correctamente, acuda a un administrador, información: \n\n" + ex.ToString();
            }
            return mensaje;
        }

        public string Altas_empleados(int idempleado, string nombre, string direccion, string telefono, string rfc, string nss, int idpuesto)
        {
            string mensaje = "Datos registrados correctamente";
            try
            {
                cmd = new SqlCommand("Insert into empleado(id_empleado, nombre_empleado, direccion_empleado, telefono_empleado, rfc_empleado, nss, id_puesto) values (" + idempleado + ", '" + nombre  + "', '" + direccion +"', '" + telefono +"',  '" + rfc +"', '" + nss + "', " + idpuesto + ")", cn);
                cmd.ExecuteNonQuery();               
            }
            catch (Exception ex)
            {
                mensaje = "No se registraron los datos correctamente, acuda a un administrador, información: \n\n" + ex.ToString();
            }
            return mensaje;
        }

        public string Bajas_empleados(int idempleado)
        {
            string mensaje = "Empleado eliminado correctamente";
            try
            {
                cmd = new SqlCommand("delete from puesto where id_empleado = " + idempleado + "", cn);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("delete from asistencia where id_empleado = " + idempleado + "", cn);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("delete from empleado where id_empleado = " + idempleado + "", cn);
                cmd.ExecuteNonQuery();

               //cmd = new SqlCommand("delete from nomina where id_empleado = " + idempleado + "", cn);
               //cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                mensaje = "No se elimino el empleado correctamente, acuda a un administrador, información: \n\n" + ex.ToString();
            }
            return mensaje;
        }

        public string Actualizar_empleado(int idempleado, string nombre, string direccion, string telefono, string rfc, string nss, int idpuesto)
        {
            string mensaje = "Datos actualizados correctamente";
            try
            {
                cmd = new SqlCommand("UPDATE empleado set nombre_empleado = ('" + nombre + "'), direccion_empleado = ('" + direccion + "'), telefono_empleado = ('" + telefono + "'), rfc_empleado = ('" + rfc + "'), nss = ('" + nss + "'), id_puesto = " + idpuesto + " where id_empleado = " + idempleado + "", cn);
                cmd.ExecuteNonQuery();

               // cmd = new SqlCommand("UPDATE puesto set nombre_puesto = ('" + nompuesto + "'), salario = ('" + salario + "'), horario = ('" + horario + "') where id_empleado = " + idempleado + "", cn);
                //cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                mensaje = "No se actualizaron los datos correctamente, acuda a un administrador, información: \n\n" + ex.ToString();
            }
            return mensaje;
        }

        //cmd = new SqlCommand("Insert into puesto(id_empleado, nombre_puesto, salario, horario) values (" + idempleado + ", '" + nompuesto + "', '" + salario + "', '" + horario + "')", cn);
        //cmd.ExecuteNonQuery();
    }
}
