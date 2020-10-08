using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//usadas
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
    public partial class FALLAS : Form
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
        public FALLAS(Form1 ini)
        {
            InitializeComponent();
            inicio = ini;
            // MuestraDatos(dataGridProducto);
            
            CargaFalla();
            fecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            MuestraDatos(grid_fallas);
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
                da = new SqlDataAdapter("SELECT * FROM FALLAS", c.regresaConexion());
                dt = new DataTable();
                da.Fill(dt);
                d.DataSource = dt;
                c.cerrarConexion();
                if (grid_fallas.RowCount == 0)
                {
                    boton_modifcar.Enabled = false;
                    boton_eliminar.Enabled = false;
                }
                if (grid_fallas.RowCount != 0)
                {
                    boton_modifcar.Enabled = true;
                    boton_eliminar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar" + ex.ToString());
                c.cerrarConexion();
            }
        }

        private void CargaFalla()
        {
            sistema_afectado.Items.Insert(0, "MOTOR");
            sistema_afectado.SelectedIndex = 0;
            sistema_afectado.Items.Insert(1, "LLANTAS");
            sistema_afectado.Items.Insert(2, "CAMBIO DE ACEITE");
            sistema_afectado.Items.Insert(3, "SERVICIO");
            sistema_afectado.Items.Insert(4, "SUSPENSION");
            sistema_afectado.Items.Insert(5, "CAMBIO DE ACEITE HIDRAULICO");
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FALLAS_FormClosing(object sender, FormClosingEventArgs e)
        {
            inicio.Show();
        }

        private void FALLAS_Load(object sender, EventArgs e)
        {
            c = new conexion();
            cmd = new SqlCommand("SELECT nombre_maquina FROM MAQUINA", c.regresaConexion());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                nombre_maquina.Items.Add(dr["nombre_maquina"].ToString());
            }
            nombre_maquina.SelectedIndex = 0;
            c.cerrarConexion();

        }

        private void boton_agregar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            try
            {
                if (fecha.Text == "" || Descripcion.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {



                    if (grid_fallas.RowCount == 0)
                    {
                        c = new conexion();
                        cmd = new SqlCommand("INSERT INTO FALLAS(maquina, sistema_afectado, descripcion, fecha) VALUES('" + nombre_maquina.SelectedItem + "', '" +sistema_afectado.SelectedItem+ "', '" + Descripcion.Text + "', '" + fecha.Text + "')", c.regresaConexion());
                        cmd.ExecuteNonQuery();
                        c.cerrarConexion();
                        MessageBox.Show("Mantenimiento Insertado");
                        id_falla.Text = "";
                        fecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
                        nombre_maquina.SelectedIndex = 0;
                        Descripcion.Text = "";

                    }
                    else
                    {
                        for (int i = 0; i < grid_fallas.RowCount; i++)
                        {
                            if (grid_fallas.Rows[i].Cells[0].Value.ToString() == id_falla.Text)
                            {
                                existe = true;
                            }
                        }
                        if (existe == false)
                        {
                            c = new conexion();
                            cmd = new SqlCommand("INSERT INTO FALLAS(maquina, sistema_afectado, descripcion, fecha) VALUES('" + nombre_maquina.SelectedItem + "', '" + sistema_afectado.SelectedItem + "', '" + Descripcion.Text + "', '" + fecha.Text + "')", c.regresaConexion());
                            cmd.ExecuteNonQuery();
                            c.cerrarConexion();
                            MessageBox.Show("Mantenimiento Insertado");
                            nombre_maquina.SelectedIndex = 0;
                            id_falla.Text = "";
                            fecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
                            Descripcion.Text = "";
                        }
                        else
                            MessageBox.Show("YA ESTA DADA DE ALTA LA MAQUINA ");
                        nombre_maquina.SelectedIndex = 0;
                        id_falla.Text = "";
                        fecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
                        Descripcion.Text = "";
                    }

                    MuestraDatos(grid_fallas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar" + ex.ToString());
                c.cerrarConexion();
            }
        }

        private void boton_modifcar_Click(object sender, EventArgs e)
        {
            try
            { //(id_Obra, nombre_obra, lugar_obra, fecha_inicio, fecha_termino, empresa_factura, estimacion, costo, residente, notas, cliente_obra) VALUES(" + id_obra.Text+",'" + Nombre_Obra.Text + "', '" + Lugar_Obra.Text + "','" + Fecha_Inicio.Text + "', '" + Fecha_Termino.Text + "', '" + Empresa_Facturar.SelectedItem + "', " + Estimacion_Obra.Text + ", " + Costo_Obra.Text + ", '" + Residente.SelectedItem + "','" + Notas.Text + "', '" + Cliente_Obra.SelectedItem + "' )", c.regresaConexion());
                c = new conexion();
                cmd = new SqlCommand("UPDATE FALLAS SET maquina ='" + nombre_maquina.SelectedItem + "',sistema_afectado='" + sistema_afectado.SelectedItem + "',descripcion='" + Descripcion.Text + "',fecha='" + fecha.Text + "' WHERE id_Falla = " + grid_fallas.CurrentRow.Cells[0].Value.ToString() + ";", c.regresaConexion());
                cmd.ExecuteNonQuery();
                c.cerrarConexion();
                MessageBox.Show("Mantenimiento Modificado");
                nombre_maquina.SelectedIndex = 0;
                fecha.Text = fecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
                Descripcion.Text = "";
                MuestraDatos(grid_fallas);
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Modificar" + ex.ToString());
                c.cerrarConexion();
            }

        }

        private void grid_fallas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_fallas.Rows[e.RowIndex].Selected = true;
            id_falla.Text = grid_fallas.CurrentRow.Cells[0].Value.ToString();
            nombre_maquina.Text = grid_fallas.CurrentRow.Cells[1].Value.ToString();
            sistema_afectado.Text = grid_fallas.CurrentRow.Cells[2].Value.ToString();
            Descripcion.Text = grid_fallas.CurrentRow.Cells[3].Value.ToString();
            fecha.Text = grid_fallas.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                c = new conexion();
                cmd = new SqlCommand("DELETE FROM FALLAS WHERE id_Falla =" + id_falla.Text, c.regresaConexion());
                cmd.ExecuteNonQuery();
                c.cerrarConexion();
                MuestraDatos(grid_fallas);
                MessageBox.Show("Mantenimiento eliminado");
                nombre_maquina.SelectedIndex = 0;
                id_falla.Text = "";
                fecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
                Descripcion.Text = "";
            }
            catch
            {

            }
        }

        private void Imprimir_Reporte_Click(object sender, EventArgs e)
        {
            Paragraph paragraph = new Paragraph(); //se crea el parrafo
            Paragraph paragraphfecha = new Paragraph();
            paragraph.Clear();//limpiar el parrago para agregar mas texto
            iTextSharp.text.Font text = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 11);
            if (grid_fallas.RowCount == 0)
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
                    paragraph.Add("REPORTE DE MANTENIMIENTO");//agregar texto
                    doc.Add(paragraph);//lo metes al documento
                    paragraph.Clear();
                    doc.Add(Chunk.NEWLINE);
                    paragraphfecha.Alignment = Element.ALIGN_RIGHT;
                    paragraphfecha.Add(DateTime.Now.ToString("dd/MM/yyyy"));
                    doc.Add(paragraphfecha);//lo metes al documento
                    paragraphfecha.Clear();
                    doc.Add(Chunk.NEWLINE);
                    PdfPTable pdftable = new PdfPTable(grid_fallas.ColumnCount - 0);

                    for (int j = 0; j < grid_fallas.Columns.Count - 0; j++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(grid_fallas.Columns[j].HeaderText, text));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        pdftable.AddCell(cell);
                    }

                    pdftable.HeaderRows = 0;
                    for (int i = 0; i < grid_fallas.Rows.Count; i++)

                    {
                        for (int k = 0; k < grid_fallas.Columns.Count - 0; k++)
                        {

                            if (grid_fallas[k, i].Value != null)
                            {
                                pdftable.AddCell(new Phrase(grid_fallas.Rows[i].Cells[k].Value.ToString(), text));
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
