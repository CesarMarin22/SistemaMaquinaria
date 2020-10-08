using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregadas
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MAQUINARIA
{
    class conexion
    {
        private SqlConnection cn; //conexion
        private SqlCommand cmd; //comando

        //para crear y conectar
        public conexion()
        {
            try
            {
                //tcp:CONTABILIDAD\SALIDAMAQUINARIA,49500
                cn = new SqlConnection(@"Data Source=tcp:CONTABILIDAD\\SALIDAMAQUINARIA,49500;Initial Catalog=salidas; User Id=AppAccess; Password=admin123");
                //cn = new SqlConnection("Data Source=MARIE;Initial Catalog=proyectoFissicGym; Integrated Security=True");
                //localhost\\SQLEXPRESS02
                cn.Open();

                //quitar esto, solo es para ver si si entró
                //MessageBox.Show("Abierto");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir. Error: " + ex);
            }
        }

        //termina la coneccion
        public void cerrarConexion()
        {
            cn.Close();
        }

        public SqlConnection regresaConexion()
        {
            return cn;
        }
    }
}
