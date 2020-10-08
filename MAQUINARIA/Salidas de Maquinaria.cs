using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Data.SqlClient;
//PDF
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.Diagnostics;
using System.IO.Compression;

namespace MAQUINARIA
{
    public partial class Salidas_de_Maquinaria : Form
    {
        private MAQUINARIA maquinaria;
        int id_Maquina = 0;
        string origen2;
        SqlCommand cmd;
        SqlDataAdapter adaptador;
        conexion c;
        DataTable tabla;
        SqlDataAdapter da; //select
        DataTable dt; //datos a tabla
        //comando
        DataGridView dgv;
        SqlDataReader dr;
        public SqlConnection cn;
        public Salidas_de_Maquinaria(MAQUINARIA maq)
        {
            InitializeComponent();
            maquinaria = maq;
            
           
            fecha_salida.Text = DateTime.Now.ToString("dd-MM-yyyy");
            fecha_regreso.Text = DateTime.Now.ToString("dd-MM-yyyy");
            MuestraDatos(grid_salida_maquinaria);
            this.DoubleBuffered = true;
            MuestraMaquinaCategoria();
            if (Form1.tipo == "USUARIO")
            {
                boton_Eliminar.Enabled = false;
            }
            if (Form1.tipo == "MARY")
            {
                boton_Eliminar.Enabled = false;
            }
        }

        public void MuestraDatos(DataGridView d)
        {
            try
            {
                c = new conexion();
                da = new SqlDataAdapter("select * from SALIDAS", c.regresaConexion());
                dt = new DataTable();
                da.Fill(dt);
                d.DataSource = dt;
                c.cerrarConexion();
                if (grid_salida_maquinaria.RowCount == 0)
                {
                    boton_modificar.Enabled = false;
                    boton_Eliminar.Enabled = false;
                }
                if (grid_salida_maquinaria.RowCount != 0)
                {
                    boton_modificar.Enabled = true;
                    boton_Eliminar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar" + ex.ToString());
                c.cerrarConexion();
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Salidas_de_Maquinaria_FormClosing(object sender, FormClosingEventArgs e)
        {
            maquinaria.Show();
        }

        private void Salidas_de_Maquinaria_Load(object sender, EventArgs e)
        {
           /* c = new conexion();
            cmd = new SqlCommand("SELECT nombre_maquina FROM MAQUINA WHERE existe_maquina =" + 1 + ";" , c.regresaConexion());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                combo_maquina.Items.Add(dr["nombre_maquina"].ToString());
            }
            combo_maquina.Items.Insert(0, "-----SELECCIONA MAQUINA----------");
            combo_maquina.SelectedIndex = 0;*/


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            c = new conexion();
            cmd = new SqlCommand("SELECT nombre FROM OPERADORES", c.regresaConexion());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                combo_operador.Items.Add(dr["nombre"].ToString());
            }
            combo_operador.Items.Insert(0, "----SELECCIONA OPERADOR----");
            combo_operador.SelectedIndex = 0;
                

            c.cerrarConexion();
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            c = new conexion();
            cmd = new SqlCommand("SELECT nombre_obra FROM OBRA", c.regresaConexion());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                combo_obra.Items.Add(dr["nombre_obra"].ToString());
            }
            combo_obra.Items.Insert(0, "----SELECCIONA OBRA----");
            combo_obra.SelectedIndex = 0;
            

            c.cerrarConexion();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            c = new conexion();
            cmd = new SqlCommand("SELECT DISTINCT categoria FROM MAQUINA", c.regresaConexion());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                categoria.Items.Add(dr["categoria"].ToString());
            }
            categoria.Items.Insert(0, "----SELECCIONA CATEGORIA----");
            categoria.SelectedIndex = 0;


            c.cerrarConexion();




        }

        private void boton_agregar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            try
            {
                if (origen.Text == "" && id_Maquina != 0)
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {



                    if (grid_salida_maquinaria.RowCount == 0)
                    {
                        c = new conexion();
                        cmd = new SqlCommand("INSERT INTO SALIDAS(nombre_maquinaria, nombre_operador, fecha_salida, fecha_regreso, origen, nombre_obra, id_maquina, cliente, categoria) VALUES('" + combo_maquina.SelectedItem + "', '" + combo_operador.SelectedItem + "', '" + fecha_salida.Text + "', '" + fecha_regreso.Text + "','" + origen.Text + "','" + combo_obra.SelectedItem + "', "+id_Maquina+", '"+cliente.Text+ "', '" + categoria.SelectedItem + "')", c.regresaConexion());
                        cmd.ExecuteNonQuery();
                        c.cerrarConexion();
                        ////////////////////////////////////////////////////////////////////////////
                        c = new conexion();
                        cmd = new SqlCommand("UPDATE MAQUINA SET existe_maquina =" + 0 + " WHERE nombre_maquina = '" + combo_maquina.SelectedItem + "';", c.regresaConexion());
                        cmd.ExecuteNonQuery();
                        c.cerrarConexion();
                        ///////////////////////////////////////////////////////////////////////////
                        MessageBox.Show("Salida Insertada");
                        origen.Text = "";
                        fecha_salida.Text = DateTime.Now.ToString("dd-MM-yyyy");
                        fecha_regreso.Text = DateTime.Now.ToString("dd-MM-yyyy");
                        combo_maquina.Text="";
                        combo_operador.SelectedIndex = 0;
                        combo_obra.SelectedIndex = 0;



                    }
                    else
                    {
                        for (int i = 0; i < grid_salida_maquinaria.RowCount; i++)
                        {
                            if (grid_salida_maquinaria.Rows[i].Cells[3].Value.ToString() == grid_salida_maquinaria.CurrentRow.Cells[0].Value.ToString())
                            {
                                existe = true;
                            }
                        }
                        if (existe == false)
                        {
                            c = new conexion();
                            cmd = new SqlCommand("INSERT INTO SALIDAS(nombre_maquinaria, nombre_operador, fecha_salida, fecha_regreso, origen, nombre_obra, id_maquina, cliente, categoria) VALUES('" + combo_maquina.SelectedItem + "', '" + combo_operador.SelectedItem + "', '" + fecha_salida.Text + "', '" + fecha_regreso.Text + "','" + origen.Text + "','" + combo_obra.SelectedItem + "', " + id_Maquina + ", '" + cliente.Text + "', '" + categoria.SelectedItem + "')", c.regresaConexion());
                            cmd.ExecuteNonQuery();

                            c.cerrarConexion();
                            ////////////////////////////////////////////////////////////////////////////
                            c = new conexion();
                            cmd = new SqlCommand("UPDATE MAQUINA SET existe_maquina =" + 0 + " WHERE nombre_maquina = '" + combo_maquina.SelectedItem + "';", c.regresaConexion());
                            cmd.ExecuteNonQuery();
                            c.cerrarConexion();
                            ///////////////////////////////////////////////////////////////////////////
                            MessageBox.Show("Salida Insertada");
                            origen.Text = "";
                            fecha_salida.Text = DateTime.Now.ToString("dd-MM-yyyy");
                            fecha_regreso.Text = DateTime.Now.ToString("dd-MM-yyyy");
                            combo_maquina.Text = "";
                            combo_operador.SelectedIndex = 0;
                            combo_obra.SelectedIndex = 0;
                        }
                        else
                            MessageBox.Show("YA ESTA DADA DE ALTA LA SALIDA ");
                        origen.Text = "";
                        fecha_salida.Text = DateTime.Now.ToString("dd-MM-yyyy");
                        fecha_regreso.Text = DateTime.Now.ToString("dd-MM-yyyy");
                        combo_maquina.SelectedIndex = 0;
                        combo_operador.SelectedIndex = 0;
                        combo_obra.SelectedIndex = 0;

                    }

                    MuestraDatos(grid_salida_maquinaria);
                    combo_maquina.Items.Clear();
                    c = new conexion();
                    cmd = new SqlCommand("SELECT nombre_maquina FROM MAQUINA WHERE existe_maquina =" + 1 + ";", c.regresaConexion());
                    dr = cmd.ExecuteReader();
             
                    while (dr.Read())
                    {

                        combo_maquina.Items.Add(dr["nombre_maquina"].ToString());
                    }
                    
                    c.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar" + ex.ToString());
                c.cerrarConexion();
            }
        }

        private void boton_modificar_Click(object sender, EventArgs e)
        {
            try
            { //(id_Obra, nombre_obra, lugar_obra, fecha_inicio, fecha_termino, empresa_factura, estimacion, costo, residente, notas, cliente_obra) VALUES(" + id_obra.Text+",'" + Nombre_Obra.Text + "', '" + Lugar_Obra.Text + "','" + Fecha_Inicio.Text + "', '" + Fecha_Termino.Text + "', '" + Empresa_Facturar.SelectedItem + "', " + Estimacion_Obra.Text + ", " + Costo_Obra.Text + ", '" + Residente.SelectedItem + "','" + Notas.Text + "', '" + Cliente_Obra.SelectedItem + "' )", c.regresaConexion());
                c = new conexion();
                cmd = new SqlCommand("UPDATE SALIDAS SET nombre_maquinaria ='" +grid_salida_maquinaria.CurrentRow.Cells[2].Value.ToString()+ "',nombre_operador='" + combo_operador.SelectedItem + "',fecha_salida='" + fecha_salida.Text + "',fecha_regreso='" + fecha_regreso.Text + "',origen='" + origen.Text + "',nombre_obra='" + combo_obra.SelectedItem + "', cliente='"+cliente.Text+"', categoria='"+categoria.SelectedItem+"' WHERE id_salidas= " + grid_salida_maquinaria.CurrentRow.Cells[0].Value.ToString() + ";", c.regresaConexion());
                cmd.ExecuteNonQuery();
                c.cerrarConexion();
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                c = new conexion();
                if(fecha_regreso.Text != grid_salida_maquinaria.CurrentRow.Cells[4].Value.ToString())
                {
                    cmd = new SqlCommand("UPDATE MAQUINA SET existe_maquina =" + 1 + " WHERE nombre_maquina = '" + grid_salida_maquinaria.CurrentRow.Cells[2].Value.ToString() + "';", c.regresaConexion());
                    cmd.ExecuteNonQuery();
                    c.cerrarConexion();
                }
                    
               
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                MessageBox.Show("salida Modificada");
                origen.Text = "";
                fecha_salida.Text = DateTime.Now.ToString("dd-MM-yyyy");
                fecha_regreso.Text = DateTime.Now.ToString("dd-MM-yyyy");
                
                combo_operador.SelectedIndex = 0;
                combo_obra.SelectedIndex = 0;
                MuestraDatos(grid_salida_maquinaria);
                combo_maquina.Items.Clear();
                c = new conexion();
                cmd = new SqlCommand("SELECT nombre_maquina FROM MAQUINA WHERE existe_maquina =" + 1 + ";", c.regresaConexion());
                dr = cmd.ExecuteReader();
                combo_maquina.Items.Insert(0, "--------");
                while (dr.Read())
                {

                    combo_maquina.Items.Add(dr["nombre_maquina"].ToString());
                }
                combo_maquina.SelectedIndex = 0;
                c.cerrarConexion();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Modificar" + ex.ToString());
                c.cerrarConexion();
            }
        }

        private void grid_salida_maquinaria_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            grid_salida_maquinaria.Rows[e.RowIndex].Selected = true;
            combo_maquina.Text = grid_salida_maquinaria.CurrentRow.Cells[2].Value.ToString();
            combo_operador.Text = grid_salida_maquinaria.CurrentRow.Cells[3].Value.ToString();
            fecha_salida.Text = grid_salida_maquinaria.CurrentRow.Cells[4].Value.ToString();
            fecha_regreso.Text = grid_salida_maquinaria.CurrentRow.Cells[5].Value.ToString();
            origen.Text = grid_salida_maquinaria.CurrentRow.Cells[6].Value.ToString();
            combo_obra.Text = grid_salida_maquinaria.CurrentRow.Cells[7].Value.ToString();
            cliente.Text = grid_salida_maquinaria.CurrentRow.Cells[8].Value.ToString();
            categoria.Text = grid_salida_maquinaria.CurrentRow.Cells[9].Value.ToString();

        }

        private void boton_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                c = new conexion();
                cmd = new SqlCommand("DELETE FROM SALIDAS WHERE id_salidas =" + grid_salida_maquinaria.CurrentRow.Cells[0].Value.ToString(), c.regresaConexion());
                cmd.ExecuteNonQuery();
                c.cerrarConexion();
                MuestraDatos(grid_salida_maquinaria);
                MessageBox.Show("Maquina Eliminada");
                origen.Text = "";
                fecha_salida.Text = DateTime.Now.ToString("dd-MM-yyyy");
                fecha_regreso.Text = DateTime.Now.ToString("dd-MM-yyyy");
                combo_maquina.SelectedIndex = 0;
                combo_operador.SelectedIndex = 0;
                combo_obra.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        public void MuestraOrigen()
        {
            c = new conexion();
            cmd = new SqlCommand("SELECT origen FROM MAQUINA WHERE nombre_maquina='" + combo_maquina.SelectedItem + "'", c.regresaConexion());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                origen.Text = (dr["origen"].ToString());
            }


            c.cerrarConexion();
        }

        public void MuestraCliente()
        {
            c = new conexion();
            cmd = new SqlCommand("SELECT cliente_obra FROM OBRA WHERE nombre_obra='" + combo_obra.SelectedItem + "'", c.regresaConexion());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cliente.Text = (dr["cliente_obra"].ToString());
            }


            c.cerrarConexion();
        }

        public void MuestraMaquinaCategoria()
        {
            c = new conexion();
            cmd = new SqlCommand("SELECT DISTINCT nombre_maquina FROM MAQUINA WHERE categoria='" + categoria.SelectedItem + "' AND existe_maquina =" + 1 + "", c.regresaConexion());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                combo_maquina.Items.Add(dr["nombre_maquina"].ToString());
            }
           
            

             c.cerrarConexion();
        }

        private void Imprimir_Reporte_Click(object sender, EventArgs e)
        {
            Paragraph paragraph = new Paragraph(); //se crea el parrafo
            Paragraph paragraphfecha = new Paragraph();
            paragraph.Clear();//limpiar el parrago para agregar mas texto
            iTextSharp.text.Font text = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 11);
            if (grid_salida_maquinaria.RowCount == 0)
            {
                MessageBox.Show("No Hay Datos Para Realizar Un Reporte");
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A2.Rotate(), 1, 1, 1, 1);
                    string filename = save.FileName;
                    FileStream file = new FileStream(filename, FileMode.OpenOrCreate);
                    PdfWriter writer = PdfWriter.GetInstance(doc, file);
                    writer.ViewerPreferences = PdfWriter.PageModeUseThumbs;
                    writer.ViewerPreferences = PdfWriter.PageLayoutOneColumn;
                    doc.Open();
                    paragraph.Font = new iTextSharp.text.Font(FontFactory.GetFont("Arial", 22, BaseColor.BLACK));
                    paragraph.Alignment = Element.ALIGN_CENTER;
                    paragraph.Add("SALIDAS DE MAQUINARIA");//agregar texto
                    doc.Add(paragraph);//lo metes al documento
                    paragraph.Clear();
                    doc.Add(Chunk.NEWLINE);
                    paragraphfecha.Alignment = Element.ALIGN_RIGHT;
                    paragraphfecha.Add(DateTime.Now.ToString("dd/MM/yyyy"));
                    doc.Add(paragraphfecha);//lo metes al documento
                    paragraphfecha.Clear();
                    doc.Add(Chunk.NEWLINE);
                    PdfPTable pdftable = new PdfPTable(grid_salida_maquinaria.ColumnCount - 0);

                    for (int j = 0; j < grid_salida_maquinaria.Columns.Count - 0; j++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(grid_salida_maquinaria.Columns[j].HeaderText, text));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        pdftable.AddCell(cell);
                    }

                    pdftable.HeaderRows = 0;
                    for (int i = 0; i < grid_salida_maquinaria.Rows.Count ; i++)

                    {
                        for (int k = 0; k < grid_salida_maquinaria.Columns.Count - 0; k++)
                        {

                            if (grid_salida_maquinaria[k, i].Value != null)
                            {
                                pdftable.AddCell(new Phrase(grid_salida_maquinaria.Rows[i].Cells[k].Value.ToString(), text));
                                //pdftable.AddCell(new Phrase(dgvLoadAll[k, i].Value.ToString(), text));

                            }
                        }
                    }

                    //float[] widths = new float[] { 15f, 50f, 40f, 40f, 40f, 40f, 40f, 40f, 40f, 40f, 40f, 40f, 40f, 40f, 40f, 40f, 40f };

                    // pdftable.SetWidths(widths);
                    doc.Add(pdftable);
                    doc.Close();
                    System.Diagnostics.Process.Start(filename);
                }
            }
            
        }

        private void origen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void combo_maquina_SelectedValueChanged(object sender, EventArgs e)
        {
           // if(combo_maquina.SelectedIndex)
           // {
                c = new conexion();
                cmd = new SqlCommand("SELECT id_Maquina FROM MAQUINA WHERE nombre_maquina='"+ combo_maquina.SelectedItem+ "'", c.regresaConexion());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                     id_Maquina = int.Parse(dr["id_Maquina"].ToString());
                }

                MuestraOrigen();
               
           // }
        }

        private void combo_obra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_obra_SelectedValueChanged(object sender, EventArgs e)
        {
            MuestraCliente();
        }

        private void categoria_SelectedValueChanged(object sender, EventArgs e)
        {
            combo_maquina.Items.Clear();
            MuestraMaquinaCategoria();
        }
    }
}
