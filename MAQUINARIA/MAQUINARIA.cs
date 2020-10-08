using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//usuada
using System.Data.SqlClient;
//pdf
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.Diagnostics;
using System.IO.Compression;
namespace MAQUINARIA
{
    public partial class MAQUINARIA : Form
    {
        private Salidas_de_Maquinaria salidas;
        private Horas_de_Maquinaria horas;
        private Form1 inicio;
        conexion c;
        SqlDataAdapter da; //select
        DataTable dt; //datos a tabla
        SqlCommand cmd; //comando
        DataGridView dgv;
        SqlDataReader dr;
        public MAQUINARIA(Form1 ini)
        {
            InitializeComponent();
            inicio = ini;
           
           
            CargaEncargado();
            CargaCategoria();
            MuestraDatosMaquinaria(grid_maquina);
            this.DoubleBuffered = true;
            if (Form1.tipo == "USUARIO")
            {
                boton_eliminar.Enabled = false;

            }
            if (Form1.tipo == "MARY")
            {
                boton_eliminar.Enabled = false;
                boton_agregar.Enabled = false;
                boton_modificar.Enabled = false;
                horas_maquinaria.Enabled = false;
            }
        }

        private void CargaCategoria()
        {
            categoria.Items.Insert(0, "TRACTORES");
            categoria.SelectedIndex = 0;
            categoria.Items.Insert(1, "PAYLOADERS");
            categoria.Items.Insert(2, "EXCAVADORAS");
            categoria.Items.Insert(3, "RETROEXCAVADORAS");
            categoria.Items.Insert(4, "MOTOCONFORMADORAS");
            categoria.Items.Insert(5, "PETROLIZADORAS");
            categoria.Items.Insert(6, "CAMIONES DE VOLTEO");
            categoria.Items.Insert(7, "PIPAS DE AGUA");
            categoria.Items.Insert(8, "PIPAS DISEL");
            categoria.Items.Insert(9, "COMPACTADORES TIERRA & ASFALTO");
            categoria.Items.Insert(10, "PATAS DE CABRA");
            categoria.Items.Insert(11, "TRAILERS");
            categoria.Items.Insert(12, "LOWBOYS");
            categoria.Items.Insert(13, "NEUMATICOS");
            categoria.Items.Insert(14, "BARREDORAS");
            categoria.Items.Insert(15, "PAVIMENTADORAS (FINISHER)");
            categoria.Items.Insert(16, "PLANTAS DE LUZ");
            categoria.Items.Insert(17, "PLANTAS DE ASFALTO");
            categoria.Items.Insert(18, "PLANTAS DE TRITURACION");
            categoria.Items.Insert(19, "RECUPERADORAS");
            categoria.Items.Insert(20, "EQUIPO LIGERO");
            categoria.Items.Insert(21, "TANQUES DE PROCESO");
            categoria.Items.Insert(22, "CALDERAS");
            categoria.Items.Insert(23, "SUBARRENDADAS");
            categoria.Items.Insert(24, "SELLADORAS");
            categoria.Items.Insert(25, "ESTACIONES TOTALES");
            categoria.Items.Insert(26, "NIVELES");
            categoria.Items.Insert(27, "CASETAS OFICIALES MOVILES");
            categoria.Items.Insert(28, "EQUIPO LIGERO");
            categoria.Items.Insert(29, "INACTIVAS");
            categoria.Items.Insert(30, "VENDIDAS");
        }

        private void CargaEncargado()
        {
            encargado.Items.Insert(0, "Jorge Luis Faz Aguilar");
            encargado.SelectedIndex = 0;
            encargado.Items.Insert(1, "Jose Luis Cazares Solis");
            encargado.Items.Insert(2, "Osvaldo Vazquez Debo");
            encargado.Items.Insert(3, "Pedro Lara Zamora");

        }

        public void MuestraDatosMaquinaria(DataGridView d)
        {
            try
            {
                c = new conexion();
                da = new SqlDataAdapter("SELECT * FROM MAQUINA", c.regresaConexion());
                dt = new DataTable();
                da.Fill(dt);
                d.DataSource = dt;
                c.cerrarConexion();
                if (grid_maquina.RowCount == 0)
                {
                    boton_modificar.Enabled = false;
                    boton_eliminar.Enabled = false;
                }
                if (grid_maquina.RowCount != 0)
                {
                    boton_modificar.Enabled = true;
                    boton_eliminar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar" + ex.ToString());
                c.cerrarConexion();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MAQUINARIA_Load(object sender, EventArgs e)
        {

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MAQUINARIA_FormClosing(object sender, FormClosingEventArgs e)
        {
            inicio.Show();
        }

        private void salida_maquinaria_Click(object sender, EventArgs e)
        {
            salidas = new Salidas_de_Maquinaria(this);
            salidas.Show();
            this.Hide();
        }

        private void horas_maquinaria_Click(object sender, EventArgs e)
        {
            horas = new Horas_de_Maquinaria(this);
            horas.Show();
            this.Hide();
        }

        private void boton_agregar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            try
            {
                if (nombre_maquina.Text == "" || marca.Text == "" || serie.Text == "" || origen.Text == "" || precio.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {



                    if (grid_maquina.RowCount == 0)
                    {
                        c = new conexion();
                        cmd = new SqlCommand("INSERT INTO MAQUINA(nombre_maquina, marca, serie, origen, precio, existe_maquina, horas_acumuladas, horas_totales, encargado, categoria) VALUES('" + nombre_maquina.Text + "', '" + marca.Text + "', '" + serie.Text + "', '" + origen.Text + "', " + precio.Text + ", "+ 1 + ", " + 0 + ", " + 0 + ", '"+encargado.SelectedItem+ "', '" + categoria.SelectedItem + "')", c.regresaConexion());
                        cmd.ExecuteNonQuery();
                        c.cerrarConexion();
                        MessageBox.Show("Maquina Insertada");
                        encargado.SelectedIndex = 0;
                        nombre_maquina.Text = "";
                        marca.Text = "";
                        serie.Text = "";
                        origen.Text = "";
                        precio.Text = "";
                        

                    }
                    else
                    {
                        for (int i = 0; i < grid_maquina.RowCount; i++)
                        {
                            if (grid_maquina.Rows[i].Cells[3].Value.ToString() == serie.Text)
                            {
                                existe = true;
                            }
                        }
                        if (existe == false)
                        {
                            c = new conexion();
                            cmd = new SqlCommand("INSERT INTO MAQUINA(nombre_maquina, marca, serie, origen, precio, existe_maquina, horas_acumuladas, horas_totales, encargado, categoria) VALUES('" + nombre_maquina.Text + "', '" + marca.Text + "', '" + serie.Text + "', '" + origen.Text + "', " + precio.Text + ", " + 1 + ", " + 0 + ", " + 0 + ", '" + encargado.SelectedItem + "', '" + categoria.SelectedItem + "')", c.regresaConexion());
                            cmd.ExecuteNonQuery();
                            c.cerrarConexion();
                            MessageBox.Show("Maquina Insertada");
                            encargado.SelectedIndex = 0;
                            nombre_maquina.Text = "";
                            marca.Text = "";
                            serie.Text = "";
                            origen.Text = "";
                            precio.Text = "";
                        }
                        else
                            MessageBox.Show("YA ESTA DADA DE ALTA LA MAQUINA ");
                        nombre_maquina.Text = "";
                        marca.Text = "";
                        serie.Text = "";
                        origen.Text = "";
                        precio.Text = "";
                        encargado.SelectedIndex = 0;

                    }

                    MuestraDatosMaquinaria(grid_maquina);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar" + ex.ToString());
                c.cerrarConexion();
            }
        }

        private void grid_maquina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_maquina.Rows[e.RowIndex].Selected = true;
            id_Maquina.Text = grid_maquina.CurrentRow.Cells[0].Value.ToString();
            nombre_maquina.Text = grid_maquina.CurrentRow.Cells[1].Value.ToString();
            marca.Text = grid_maquina.CurrentRow.Cells[2].Value.ToString();
            serie.Text = grid_maquina.CurrentRow.Cells[3].Value.ToString();
            origen.Text = grid_maquina.CurrentRow.Cells[4].Value.ToString();
            precio.Text = grid_maquina.CurrentRow.Cells[5].Value.ToString();
            encargado.Text = grid_maquina.CurrentRow.Cells[9].Value.ToString();
            categoria.Text = grid_maquina.CurrentRow.Cells[10].Value.ToString();

        }

        private void boton_modificar_Click(object sender, EventArgs e)
        {
            try
            { //(id_Obra, nombre_obra, lugar_obra, fecha_inicio, fecha_termino, empresa_factura, estimacion, costo, residente, notas, cliente_obra) VALUES(" + id_obra.Text+",'" + Nombre_Obra.Text + "', '" + Lugar_Obra.Text + "','" + Fecha_Inicio.Text + "', '" + Fecha_Termino.Text + "', '" + Empresa_Facturar.SelectedItem + "', " + Estimacion_Obra.Text + ", " + Costo_Obra.Text + ", '" + Residente.SelectedItem + "','" + Notas.Text + "', '" + Cliente_Obra.SelectedItem + "' )", c.regresaConexion());
                c = new conexion();
                cmd = new SqlCommand("UPDATE MAQUINA SET nombre_maquina ='" + nombre_maquina.Text + "',marca='" + marca.Text + "',serie='" + serie.Text + "',origen='" + origen.Text + "',precio=" + precio.Text + ", encargado='" + encargado.SelectedItem + "', categoria='"+categoria.SelectedItem+"' WHERE id_Maquina = " + grid_maquina.CurrentRow.Cells[0].Value.ToString() + ";", c.regresaConexion());
                cmd.ExecuteNonQuery();
                c.cerrarConexion();
                MessageBox.Show("Maquina Modificada");
                id_Maquina.Text = "";
                nombre_maquina.Text = "";
                encargado.SelectedIndex = 0;
                marca.Text = "";
                serie.Text = "";
                origen.Text = "";
                precio.Text = "";
                MuestraDatosMaquinaria(grid_maquina);
            }
             
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Modificar" + ex.ToString());
                c.cerrarConexion();
            }
        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                c = new conexion();
                cmd = new SqlCommand("DELETE FROM SALIDAS WHERE id_maquina =" + id_Maquina.Text, c.regresaConexion());
                cmd.ExecuteNonQuery();
                c.cerrarConexion();
                c = new conexion();
                cmd = new SqlCommand("DELETE FROM MAQUINA WHERE id_Maquina =" + id_Maquina.Text, c.regresaConexion());
                cmd.ExecuteNonQuery();
                c.cerrarConexion();
                MuestraDatosMaquinaria(grid_maquina);
                MessageBox.Show("Maquina Eliminada");
                id_Maquina.Text = "";
                nombre_maquina.Text = "";
                encargado.SelectedIndex = 0;
                marca.Text = "";
                serie.Text = "";
                origen.Text = "";
                precio.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Modificar" + ex.ToString());
                c.cerrarConexion();
            }
        }

        private void nombre_maquina_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void Imprimir_Reporte_Click(object sender, EventArgs e)
        {
            Paragraph paragraph = new Paragraph(); //se crea el parrafo
            Paragraph paragraphfecha = new Paragraph();
            paragraph.Clear();//limpiar el parrago para agregar mas texto
            iTextSharp.text.Font text = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 11);
            if (grid_maquina.RowCount == 0)
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
                    paragraph.Add("REPORTE DE MAQUINARIA");//agregar texto
                    doc.Add(paragraph);//lo metes al documento
                    paragraph.Clear();
                    doc.Add(Chunk.NEWLINE);
                    paragraphfecha.Alignment = Element.ALIGN_RIGHT;
                    paragraphfecha.Add(DateTime.Now.ToString("dd/MM/yyyy"));
                    doc.Add(paragraphfecha);//lo metes al documento
                    paragraphfecha.Clear();
                    doc.Add(Chunk.NEWLINE);
                    PdfPTable pdftable = new PdfPTable(grid_maquina.ColumnCount - 0);

                    for (int j = 0; j < grid_maquina.Columns.Count - 0; j++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(grid_maquina.Columns[j].HeaderText, text));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        pdftable.AddCell(cell);
                    }

                    pdftable.HeaderRows = 0;
                    for (int i = 0; i < grid_maquina.Rows.Count; i++)

                    {
                        for (int k = 0; k < grid_maquina.Columns.Count - 0; k++)
                        {

                            if (grid_maquina[k, i].Value != null)
                            {
                                pdftable.AddCell(new Phrase(grid_maquina.Rows[i].Cells[k].Value.ToString(), text));
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
    }
}
