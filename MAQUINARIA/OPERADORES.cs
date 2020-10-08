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
    public partial class OPERADORES : Form
    {
        private Form1 inicio;
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
        public OPERADORES(Form1 ini)
        {
            InitializeComponent();
            inicio = ini;
            

            MuestraDatos(grid_operadores);
            this.DoubleBuffered = true;
            if (Form1.tipo == "USUARIO")
            {
                boton_eliminar.Enabled = false;
            }
        }

        public void MuestraDatos(DataGridView d)
        {
            try
            {
                c = new conexion();
                da = new SqlDataAdapter("SELECT * FROM OPERADORES", c.regresaConexion());
                dt = new DataTable();
                da.Fill(dt);
                d.DataSource = dt;
                c.cerrarConexion();
                if (grid_operadores.RowCount == 0)
                {
                    boton_modificar.Enabled = false;
                    boton_eliminar.Enabled = false;
                }
                if (grid_operadores.RowCount != 0)
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

        private void OPERADORES_FormClosing(object sender, FormClosingEventArgs e)
        {
            inicio.Show();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool existe = false;
            try
            {
                if (nombre_operador.Text == "" || telefono.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {



                    if (grid_operadores.RowCount == 0)
                    {
                        c = new conexion();
                        cmd = new SqlCommand("INSERT INTO OPERADORES(nombre, telefono) VALUES('" + nombre_operador.Text + "', '" + telefono.Text + "')", c.regresaConexion());
                        cmd.ExecuteNonQuery();
                        c.cerrarConexion();
                        MessageBox.Show("Operador Insertado");
                        nombre_operador.Text = "";
                        telefono.Text = "";
                       

                    }
                    else
                    {
                        for (int i = 0; i < grid_operadores.RowCount; i++)
                        {
                            if (grid_operadores.Rows[i].Cells[1].Value.ToString() == nombre_operador.Text)
                            {
                                existe = true;
                            }
                        }
                        if (existe == false)
                        {
                            c = new conexion();
                            cmd = new SqlCommand("INSERT INTO OPERADORES(nombre, telefono) VALUES('" + nombre_operador.Text + "', '" + telefono.Text + "')", c.regresaConexion());
                            cmd.ExecuteNonQuery();
                            c.cerrarConexion();
                            MessageBox.Show("Operador Insertado");
                            nombre_operador.Text = "";
                            telefono.Text = "";
                        }
                        else
                            MessageBox.Show("YA ESTA DADO DE ALTA EL OPERADOR ");
                        nombre_operador.Text = "";
                        telefono.Text = "";
                    }

                    MuestraDatos(grid_operadores);
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
                cmd = new SqlCommand("UPDATE OPERADORES SET nombre ='" + nombre_operador.Text + "',telefono='" + telefono.Text + "' WHERE id_operadores = " + grid_operadores.CurrentRow.Cells[0].Value.ToString() + ";", c.regresaConexion());
                cmd.ExecuteNonQuery();
                c.cerrarConexion();
                MessageBox.Show("OPERADOR MODIFICADO");
                nombre_operador.Text = "";
                telefono.Text = "";
                MuestraDatos(grid_operadores);
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Modificar" + ex.ToString());
                c.cerrarConexion();
            }
        }

        private void grid_operadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_operadores.Rows[e.RowIndex].Selected = true;
            nombre_operador.Text = grid_operadores.CurrentRow.Cells[1].Value.ToString();
            telefono.Text = grid_operadores.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                c = new conexion();
                cmd = new SqlCommand("DELETE FROM OPERADORES WHERE id_operadores =" + grid_operadores.CurrentRow.Cells[0].Value.ToString(), c.regresaConexion());
                cmd.ExecuteNonQuery();
                c.cerrarConexion();
                MuestraDatos(grid_operadores);
                MessageBox.Show("Falla eliminado");
                nombre_operador.Text = "";
                telefono.Text = "";
            }
            catch
            {

            }
        }

        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nombre_operador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Imprimir_Reporte_Click(object sender, EventArgs e)
        {
            Paragraph paragraph = new Paragraph(); //se crea el parrafo
            Paragraph paragraphfecha = new Paragraph();
            paragraph.Clear();//limpiar el parrago para agregar mas texto
            iTextSharp.text.Font text = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 11);
            if (grid_operadores.RowCount == 0)
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
                    paragraph.Add("REPORTE DE OPERADORES");//agregar texto
                    doc.Add(paragraph);//lo metes al documento
                    paragraph.Clear();
                    doc.Add(Chunk.NEWLINE);
                    paragraphfecha.Alignment = Element.ALIGN_RIGHT;
                    paragraphfecha.Add(DateTime.Now.ToString("dd/MM/yyyy"));
                    doc.Add(paragraphfecha);//lo metes al documento
                    paragraphfecha.Clear();
                    doc.Add(Chunk.NEWLINE);
                    PdfPTable pdftable = new PdfPTable(grid_operadores.ColumnCount - 0);

                    for (int j = 0; j < grid_operadores.Columns.Count - 0; j++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(grid_operadores.Columns[j].HeaderText, text));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        pdftable.AddCell(cell);
                    }

                    pdftable.HeaderRows = 0;
                    for (int i = 0; i < grid_operadores.Rows.Count; i++)

                    {
                        for (int k = 0; k < grid_operadores.Columns.Count - 0; k++)
                        {

                            if (grid_operadores[k, i].Value != null)
                            {
                                pdftable.AddCell(new Phrase(grid_operadores.Rows[i].Cells[k].Value.ToString(), text));
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
