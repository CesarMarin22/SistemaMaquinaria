using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class Horas_de_Maquinaria : Form
    {
        private MAQUINARIA maquinaria;
        SqlCommand cmd;
        SqlDataAdapter adaptador;
        conexion c;
        DataTable tabla;
        SqlDataAdapter da; //select
        DataTable dt; //datos a tabla
        //comando
        DataGridView dgv;
        SqlDataReader dr;
        public Horas_de_Maquinaria(MAQUINARIA maq)
        {
            InitializeComponent();
            maquinaria = maq;
            fecha_inicio.Text = DateTime.Now.ToString("dd-MM-yyyy");
            fecha_final.Text = DateTime.Now.ToString("dd-MM-yyyy");
            MuestraDatos(grid_horas_maquinaria);
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
                da = new SqlDataAdapter("SELECT * FROM HORAS_MAQUINA", c.regresaConexion());
                dt = new DataTable();
                da.Fill(dt);
                d.DataSource = dt;
                c.cerrarConexion();
                if (grid_horas_maquinaria.RowCount == 0)
                {
                    grid_horas_maquinaria.Enabled = false;
                    boton_eliminar.Enabled = false;
                }
                if (grid_horas_maquinaria.RowCount != 0)
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

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Horas_de_Maquinaria_FormClosing(object sender, FormClosingEventArgs e)
        {
            maquinaria.Show();
        }

        private void Horas_de_Maquinaria_Load(object sender, EventArgs e)
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

            //////////////////////////////////////////////////////////////////////////////////////////////

            
        }

        public void MuestraHoras_Acumuladas_Maquina()
        {
            c = new conexion();
            cmd = new SqlCommand("SELECT horas_acumuladas FROM MAQUINA WHERE nombre_maquina='" + nombre_maquina.SelectedItem.ToString() + "';", c.regresaConexion());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                horas_acumuladas.Text=(dr["horas_acumuladas"].ToString());
            }

           
            c.cerrarConexion();
        }

        public void MuestraHoras_Totales_Maquina()
        {
            c = new conexion();
            cmd = new SqlCommand("SELECT horas_totales FROM MAQUINA WHERE nombre_maquina='" + nombre_maquina.SelectedItem.ToString() + "';", c.regresaConexion());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                horas_totales.Text = (dr["horas_totales"].ToString());
            }


            c.cerrarConexion();
        }



        private void boton_agregar_Click(object sender, EventArgs e)
         {
            int suma, sumatotales;
            bool existe = false;
            try
            {
                if (horas_trabajadas.Text == "" && notas.Text=="")
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {                  
                    if (grid_horas_maquinaria.RowCount == 0)
                    {
                        suma = int.Parse(horas_trabajadas.Text) + int.Parse(horas_acumuladas.Text);
                        horas_acumuladas.Text = suma.ToString();
                        sumatotales = int.Parse(horas_acumuladas.Text) + int.Parse(horas_totales.Text);
                        horas_totales.Text = sumatotales.ToString();
                        c = new conexion();
                        cmd = new SqlCommand("INSERT INTO HORAS_MAQUINA(maquina, horas_trabajadas, horas_totales, fecha_inicio, fecha_finales, horas_acumuladas, servicio, notas) VALUES('" + nombre_maquina.SelectedItem + "', " + horas_trabajadas.Text + ", " + horas_totales.Text + ", '" + fecha_inicio.Text + "', '" + fecha_final.Text + "', " + horas_trabajadas.Text + ","+0+", '"+notas.Text+"')", c.regresaConexion());
                        cmd.ExecuteNonQuery();
                        c.cerrarConexion();
                        MessageBox.Show("Horas de la Maquinaria Insertadas");
                        fecha_inicio.Text = DateTime.Now.ToString("dd-MM-yyyy");
                        fecha_final.Text = DateTime.Now.ToString("dd-MM-yyyy");
                        horas_totales.Text = "";
                        horas_trabajadas.Text = "";
                        horas_acumuladas.Text = "";
                        MuestraDatos(grid_horas_maquinaria);

                    }
                    else
                    {
                        for (int i = 0; i < grid_horas_maquinaria.RowCount; i++)
                        {
                            if (grid_horas_maquinaria.Rows[i].Cells[0].Value.ToString() == id_horas.Text)
                            {
                                existe = true;
                            }
                        }
                        if (existe == false)
                        {
                            suma = int.Parse(horas_trabajadas.Text) + int.Parse(horas_acumuladas.Text);
                            horas_acumuladas.Text = suma.ToString();
                            sumatotales = int.Parse(horas_acumuladas.Text) + int.Parse(horas_totales.Text);
                            horas_totales.Text = sumatotales.ToString();
                            c = new conexion();
                            cmd = new SqlCommand("INSERT INTO HORAS_MAQUINA(maquina, horas_trabajadas, horas_totales, fecha_inicio, fecha_finales, horas_acumuladas, servicio, notas) VALUES('" + nombre_maquina.SelectedItem + "', " + horas_trabajadas.Text + ", " + horas_totales.Text + ", '" + fecha_inicio.Text + "', '" + fecha_final.Text + "', " + horas_trabajadas.Text + "," + 0 + ",'" + notas.Text + "')", c.regresaConexion());
                            cmd.ExecuteNonQuery();
                            c.cerrarConexion();
                            MessageBox.Show("Horas de la Maquinaria Insertadas");
                            fecha_inicio.Text = DateTime.Now.ToString("dd-MM-yyyy");
                            fecha_final.Text = DateTime.Now.ToString("dd-MM-yyyy");
                            horas_totales.Text = "";
                            horas_trabajadas.Text = "";
                            horas_acumuladas.Text = "";

                        }
                        else
                            MessageBox.Show("YA ESTAN DADAS DE ALTA LAS HORAS");
                        fecha_inicio.Text = DateTime.Now.ToString("dd-MM-yyyy");
                        fecha_final.Text = DateTime.Now.ToString("dd-MM-yyyy");
                        horas_totales.Text = "";
                        horas_trabajadas.Text = "";
                        horas_acumuladas.Text = "";
                        MuestraDatos(grid_horas_maquinaria);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar" + ex.ToString());
                c.cerrarConexion();
            }
        }

        private void nombre_maquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void nombre_maquina_SelectedValueChanged(object sender, EventArgs e)
        {
            MuestraHoras_Acumuladas_Maquina();
            MuestraHoras_Totales_Maquina();
        }

        private void grid_horas_maquinaria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_horas_maquinaria.Rows[e.RowIndex].Selected = true;
            id_horas.Text = grid_horas_maquinaria.CurrentRow.Cells[0].Value.ToString();
            nombre_maquina.Text = grid_horas_maquinaria.CurrentRow.Cells[1].Value.ToString();
            horas_acumuladas.Text = grid_horas_maquinaria.CurrentRow.Cells[3].Value.ToString();
            horas_totales.Text = grid_horas_maquinaria.CurrentRow.Cells[4].Value.ToString();
            fecha_inicio.Text = grid_horas_maquinaria.CurrentRow.Cells[5].Value.ToString();
            fecha_final.Text = grid_horas_maquinaria.CurrentRow.Cells[6].Value.ToString();
            notas.Text = grid_horas_maquinaria.CurrentRow.Cells[8].Value.ToString();
        }

        private void boton_modificar_Click(object sender, EventArgs e)
        {
            //bool servicio= false;
            int suma, sumatotales;
            try
            { //(id_Obra, nombre_obra, lugar_obra, fecha_inicio, fecha_termino, empresa_factura, estimacion, costo, residente, notas, cliente_obra) VALUES(" + id_obra.Text+",'" + Nombre_Obra.Text + "', '" + Lugar_Obra.Text + "','" + Fecha_Inicio.Text + "', '" + Fecha_Termino.Text + "', '" + Empresa_Facturar.SelectedItem + "', " + Estimacion_Obra.Text + ", " + Costo_Obra.Text + ", '" + Residente.SelectedItem + "','" + Notas.Text + "', '" + Cliente_Obra.SelectedItem + "' )", c.regresaConexion());
                //if(servicio==false)
                //{
                  suma = int.Parse(horas_trabajadas.Text) + int.Parse(horas_acumuladas.Text);
                  horas_acumuladas.Text = suma.ToString();
                  sumatotales = int.Parse(horas_totales.Text) + int.Parse(horas_trabajadas.Text);
                  horas_totales.Text = sumatotales.ToString();               
                  c = new conexion();
                  cmd = new SqlCommand("UPDATE HORAS_MAQUINA SET maquina ='" + nombre_maquina.SelectedItem + "',horas_trabajadas='" + horas_trabajadas.Text + "',horas_acumuladas='" + horas_acumuladas.Text + "',horas_totales='" + horas_totales.Text + "',fecha_inicio='" + fecha_inicio.Text + "',fecha_finales='" + fecha_final.Text + "', servicio="+0+ ", notas ='"+notas.Text+"' WHERE id_Horas_Maquina=" + grid_horas_maquinaria.CurrentRow.Cells[0].Value.ToString(), c.regresaConexion());
                  cmd.ExecuteNonQuery();
                  c.cerrarConexion();
                  MessageBox.Show("Reporte modificado");
                 /*   //if(suma > 20)
                    //{
                       //  MessageBox.Show("le toca servicio a la maqina");
                        cmd = new SqlCommand("UPDATE HORAS_MAQUINA SET maquina ='" + nombre_maquina.SelectedItem + "',horas_trabajadas='" + horas_trabajadas.Text + "',horas_acumuladas='" + horas_acumuladas.Text + "',horas_totales='" + horas_totales.Text + "',fecha_inicio='" + fecha_inicio.Text + "',fecha_finales='" + fecha_final.Text + "', servicio=" + 1 + " WHERE id_Horas_Maquina=" + grid_horas_maquinaria.CurrentRow.Cells[0].Value.ToString(), c.regresaConexion());
                        servicio = true;
                    //}
                    //else { 
                             fecha_inicio.Text = DateTime.Now.ToString("dd-MM-yyyy");
                             fecha_final.Text = DateTime.Now.ToString("dd-MM-yyyy");
                             horas_totales.Text = "";
                             horas_trabajadas.Text = "";
                             horas_acumuladas.Text = "";
                             MuestraDatos(grid_horas_maquinaria);
                   // }
                //}
                //else
               // {*/
                   // MessageBox.Show("le toca servicio a la maqina");
                    fecha_inicio.Text = DateTime.Now.ToString("dd-MM-yyyy");
                    fecha_final.Text = DateTime.Now.ToString("dd-MM-yyyy");
                    horas_totales.Text = "";
                    horas_trabajadas.Text = "";
                    horas_acumuladas.Text = "";
                    MuestraDatos(grid_horas_maquinaria);
                //}
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
                cmd = new SqlCommand("DELETE FROM  HORAS_MAQUINA WHERE id_Horas_Maquina =" + grid_horas_maquinaria.CurrentRow.Cells[0].Value.ToString(), c.regresaConexion());
                cmd.ExecuteNonQuery();
                c.cerrarConexion();
                MuestraDatos(grid_horas_maquinaria);
                MessageBox.Show("Maquina Eliminada");
                fecha_inicio.Text = DateTime.Now.ToString("dd-MM-yyyy");
                fecha_final.Text = DateTime.Now.ToString("dd-MM-yyyy");
                horas_totales.Text = "";
                horas_trabajadas.Text = "";
                horas_acumuladas.Text = "";
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c = new conexion();
            cmd = new SqlCommand("UPDATE  HORAS_MAQUINA SET horas_acumuladas =" + 0 + ", servicio="+0+";", c.regresaConexion());
            cmd.ExecuteNonQuery();
            c.cerrarConexion();
            MuestraDatos(grid_horas_maquinaria);
        }

        private void horas_trabajadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void imprime_reporte_Click(object sender, EventArgs e)
        {
            Paragraph paragraph = new Paragraph(); //se crea el parrafo
            Paragraph paragraphfecha = new Paragraph();
            paragraph.Clear();//limpiar el parrago para agregar mas texto
            iTextSharp.text.Font text = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 11);
            if (grid_horas_maquinaria.RowCount == 0)
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
                    paragraph.Add("REPORTE DE HORAS DE LA MAQUINARIA");//agregar texto
                    doc.Add(paragraph);//lo metes al documento
                    paragraph.Clear();
                    doc.Add(Chunk.NEWLINE);
                    paragraphfecha.Alignment = Element.ALIGN_RIGHT;
                    paragraphfecha.Add(DateTime.Now.ToString("dd/MM/yyyy"));
                    doc.Add(paragraphfecha);//lo metes al documento
                    paragraphfecha.Clear();
                    doc.Add(Chunk.NEWLINE);
                    PdfPTable pdftable = new PdfPTable(grid_horas_maquinaria.ColumnCount - 0);

                    for (int j = 0; j < grid_horas_maquinaria.Columns.Count - 0; j++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(grid_horas_maquinaria.Columns[j].HeaderText, text));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        pdftable.AddCell(cell);
                    }

                    pdftable.HeaderRows = 0;
                    for (int i = 0; i < grid_horas_maquinaria.Rows.Count; i++)

                    {
                        for (int k = 0; k < grid_horas_maquinaria.Columns.Count - 0; k++)
                        {

                            if (grid_horas_maquinaria[k, i].Value != null)
                            {
                                pdftable.AddCell(new Phrase(grid_horas_maquinaria.Rows[i].Cells[k].Value.ToString(), text));
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


/* if(suma > 20)
                {
                    servicio = true;
                    MessageBox.Show("le toca servicio a la maqina");
                    fecha_inicio.Text = DateTime.Now.ToString("dd-MM-yyyy");
                    fecha_final.Text = DateTime.Now.ToString("dd-MM-yyyy");
                    horas_totales.Text = "";
                    horas_trabajadas.Text = "";
                    horas_acumuladas.Text = "";
                }*/
