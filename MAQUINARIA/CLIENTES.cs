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
    public partial class CLIENTES : Form
    {
        private Form1 inicio;
        conexion c;
        SqlDataAdapter da; //select
        DataTable dt; //datos a tabla
        SqlCommand cmd; //comando
        DataGridView dgv;
        SqlDataReader dr;
        public CLIENTES(Form1 ini)
        {
            InitializeComponent();
            inicio = ini;
            MuestraDatos(grid_clientes);
            this.DoubleBuffered = true;
            if (Form1.tipo == "USUARIO")
            {
                boton_eliminar.Enabled = false;
                boton_modificar.Enabled = false;
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CLIENTES_FormClosing(object sender, FormClosingEventArgs e)
        {
            inicio.Show();
        }
        
        public void MuestraDatos(DataGridView d)
        {
            try
            {
                c = new conexion();
                da = new SqlDataAdapter("SELECT * FROM CLIENTE", c.regresaConexion());
                dt = new DataTable();
                da.Fill(dt);
                d.DataSource = dt;
                c.cerrarConexion();
                if (grid_clientes.RowCount == 0)
                {
                    boton_modificar.Enabled = false;
                    boton_eliminar.Enabled = false;
                }
                if (grid_clientes.RowCount != 0)
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

        private void boton_agregar_Click(object sender, EventArgs e)
        {

            bool existe = false;
            try
            {
                if (nombre_cliente.Text == "" || rfc.Text == "" || empresa.Text == "" || direccion.Text == "" || colonia.Text == "" || ciudad.Text == "" || codigo_postal.Text == "" || telefeno.Text == "" || correo.Text == "" )
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {



                    if (grid_clientes.RowCount == 0)
                    {
                        c = new conexion();
                        cmd = new SqlCommand("INSERT INTO CLIENTE(nombre_cliente, rfc, empresa, direccion, colonia, cuidad, codigo_postal, telefono, correo) VALUES('" + nombre_cliente.Text + "', '" + rfc.Text + "', '" + empresa.Text + "', '" + direccion.Text + "', '" + colonia.Text + "', '" + ciudad.Text + "', " + codigo_postal.Text + ", " + telefeno.Text + ",'" + correo.Text + "')", c.regresaConexion());
                        cmd.ExecuteNonQuery();
                        c.cerrarConexion();
                        MessageBox.Show("Cliente Insertado");
                        nombre_cliente.Text = "";
                        rfc.Text = "";
                        empresa.Text = "";
                        direccion.Text = "";
                        colonia.Text = "";
                        ciudad.Text = "";
                        codigo_postal.Text = "";
                        telefeno.Text = "";
                        correo.Text = "";
              
                    }
                    else
                    {
                        for (int i = 0; i < grid_clientes.RowCount; i++)
                        {
                            if (grid_clientes.Rows[i].Cells[2].Value.ToString() == rfc.Text)
                            {
                                existe = true;
                            }
                        }
                        if (existe == false)
                        {
                            c = new conexion();
                            cmd = new SqlCommand("INSERT INTO CLIENTE(nombre_cliente, rfc, empresa, direccion, colonia, cuidad, codigo_postal, telefono, correo) VALUES('" + nombre_cliente.Text + "', '" + rfc.Text + "', '" + empresa.Text + "', '" + direccion.Text + "', '" + colonia.Text + "', '" + ciudad.Text + "', " + codigo_postal.Text + ", " + telefeno.Text + ",'" + correo.Text + "')", c.regresaConexion());
                            cmd.ExecuteNonQuery();
                            c.cerrarConexion();
                            MessageBox.Show("Cliente Insertado");
                            nombre_cliente.Text = "";
                            rfc.Text = "";
                            empresa.Text = "";
                            direccion.Text = "";
                            colonia.Text = "";
                            ciudad.Text = "";
                            codigo_postal.Text = "";
                            telefeno.Text = "";
                            correo.Text = "";
                        }
                        else
                            MessageBox.Show("YA ESTA DADO DE ALTA EL CLIENTE");
                        nombre_cliente.Text = "";
                        rfc.Text = "";
                        empresa.Text = "";
                        direccion.Text = "";
                        colonia.Text = "";
                        ciudad.Text = "";
                        codigo_postal.Text = "";
                        telefeno.Text = "";
                        correo.Text = "";

                    }

                    MuestraDatos(grid_clientes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar" + ex.ToString());
                c.cerrarConexion();
            }
        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {

            try
            {
                c = new conexion();
                cmd = new SqlCommand("DELETE FROM CLIENTE WHERE id_Cliente =" + id_cliente.Text, c.regresaConexion());
                cmd.ExecuteNonQuery();
                c.cerrarConexion();
                MuestraDatos(grid_clientes);
                MessageBox.Show("Cliente eliminado");
                id_cliente.Text = "";
                nombre_cliente.Text = "";
                rfc.Text = "";
                empresa.Text = "";
                direccion.Text = "";
                colonia.Text = "";
                ciudad.Text = "";
                codigo_postal.Text = "";
                telefeno.Text = "";
                correo.Text = "";
            }
            catch
            {

            }
        }

        private void grid_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_clientes.Rows[e.RowIndex].Selected = true;
            id_cliente.Text = grid_clientes.CurrentRow.Cells[0].Value.ToString();
            nombre_cliente.Text = grid_clientes.CurrentRow.Cells[1].Value.ToString();
            rfc.Text = grid_clientes.CurrentRow.Cells[2].Value.ToString();
            empresa.Text = grid_clientes.CurrentRow.Cells[3].Value.ToString();
            direccion.Text = grid_clientes.CurrentRow.Cells[4].Value.ToString();
            colonia.Text = grid_clientes.CurrentRow.Cells[5].Value.ToString();
            ciudad.Text = grid_clientes.CurrentRow.Cells[6].Value.ToString();
            codigo_postal.Text = grid_clientes.CurrentRow.Cells[7].Value.ToString();
            telefeno.Text = grid_clientes.CurrentRow.Cells[8].Value.ToString();
            correo.Text = grid_clientes.CurrentRow.Cells[9].Value.ToString();
        }

        private void boton_modificar_Click(object sender, EventArgs e)
        {
            try
            { //(id_Obra, nombre_obra, lugar_obra, fecha_inicio, fecha_termino, empresa_factura, estimacion, costo, residente, notas, cliente_obra) VALUES(" + id_obra.Text+",'" + Nombre_Obra.Text + "', '" + Lugar_Obra.Text + "','" + Fecha_Inicio.Text + "', '" + Fecha_Termino.Text + "', '" + Empresa_Facturar.SelectedItem + "', " + Estimacion_Obra.Text + ", " + Costo_Obra.Text + ", '" + Residente.SelectedItem + "','" + Notas.Text + "', '" + Cliente_Obra.SelectedItem + "' )", c.regresaConexion());
                c = new conexion();
                cmd = new SqlCommand("UPDATE CLIENTE SET nombre_cliente ='" + nombre_cliente.Text + "',rfc='" + rfc.Text + "',empresa='" + empresa.Text + "',direccion='" + direccion.Text + "',colonia='" + colonia.Text + "',cuidad='" + ciudad.Text + "',codigo_postal=" + codigo_postal.Text + ",telefono=" + telefeno.Text + ",correo='" + correo.Text + "' WHERE id_Cliente="  + grid_clientes.CurrentRow.Cells[0].Value.ToString() + "; ", c.regresaConexion());
                cmd.ExecuteNonQuery();
                c.cerrarConexion();
                MessageBox.Show("Cliente modificado");
                id_cliente.Text = "";
                nombre_cliente.Text = "";
                rfc.Text = "";
                empresa.Text = "";
                direccion.Text = "";
                colonia.Text = "";
                ciudad.Text = "";
                codigo_postal.Text = "";
                telefeno.Text = "";
                correo.Text = "";
                MuestraDatos(grid_clientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Modificar" + ex.ToString());
                c.cerrarConexion();
            }
        }

        private void nombre_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void telefeno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void codigo_postal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            if (grid_clientes.RowCount == 0)
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
                    paragraph.Add("REPORTE DE CLIENTES");//agregar texto
                    doc.Add(paragraph);//lo metes al documento
                    paragraph.Clear();
                    doc.Add(Chunk.NEWLINE);
                    paragraphfecha.Alignment = Element.ALIGN_RIGHT;
                    paragraphfecha.Add(DateTime.Now.ToString("dd/MM/yyyy"));
                    doc.Add(paragraphfecha);//lo metes al documento
                    paragraphfecha.Clear();
                    doc.Add(Chunk.NEWLINE);
                    PdfPTable pdftable = new PdfPTable(grid_clientes.ColumnCount - 0);

                    for (int j = 0; j < grid_clientes.Columns.Count - 0; j++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(grid_clientes.Columns[j].HeaderText, text));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        pdftable.AddCell(cell);
                    }

                    pdftable.HeaderRows = 0;
                    for (int i = 0; i < grid_clientes.Rows.Count; i++)

                    {
                        for (int k = 0; k < grid_clientes.Columns.Count - 0; k++)
                        {

                            if (grid_clientes[k, i].Value != null)
                            {
                                pdftable.AddCell(new Phrase(grid_clientes.Rows[i].Cells[k].Value.ToString(), text));
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
