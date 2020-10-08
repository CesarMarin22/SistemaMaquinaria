using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//AGREGADAS
using System.Data.SqlClient;

namespace MAQUINARIA
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source = tcp:CONTABILIDAD\\SALIDAMAQUINARIA,49500; Initial Catalog = salidas; User Id =AppAccess; Password=admin123");

        public void logear(string usuario, string contrasena)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT nombre, tipo_usuario FROM USUARIOS WHERE usuario = @usuario AND contrasena = @pass", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pass", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count==1)
                {
                    this.Hide();
                    if(dt.Rows[0][1].ToString() == "ADMINISTRADOR")
                    {
                        new Form1(dt.Rows[0][1].ToString()).Show();
                    }
                    else if(dt.Rows[0][1].ToString() == "USUARIO")
                    {
                        new Form1(dt.Rows[0][1].ToString()).Show();
                    }
                    else if(dt.Rows[0][1].ToString() == "CONSULTA")
                    {
                        new Form1(dt.Rows[0][1].ToString()).Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "MARY")
                    {
                        new Form1(dt.Rows[0][1].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorecta");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_logear_Click(object sender, EventArgs e)
        {
            logear(this.usuario.Text, this.password.Text);
        }
    }
}
