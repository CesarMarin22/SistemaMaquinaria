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
//
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
    public partial class PIZARRON : Form
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
        public PIZARRON(Form1 ini)
        {
            InitializeComponent();
            inicio = ini;
            this.DoubleBuffered = true;
            List<string> ListaCategoria = new List<string>();
            CargaCategoria();
            MuestraDatos(grid_pizarron);
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

        public void MuestraDatos(DataGridView d)
        {           
          foreach(string item in categoria.Items)
            {
  
                try
                {              
                    c = new conexion();
                    da = new SqlDataAdapter("select ma.serie, ma.nombre_maquina, ma.origen, s.fecha_salida, s.fecha_regreso, ma.encargado, s.nombre_operador, ma.existe_maquina, s.nombre_obra, ma.categoria from MAQUINA ma full join SALIDAS s on ma.id_Maquina = s.id_maquina", c.regresaConexion());
                    dt = new DataTable();
                    da.Fill(dt);
                    d.DataSource = dt;

                    c.cerrarConexion();
                

            }
            catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar" + ex.ToString());
                    c.cerrarConexion();
                }
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PIZARRON_FormClosing(object sender, FormClosingEventArgs e)
        {
            inicio.Show();
        }

       
        private void boton_pizarron_Click(object sender, EventArgs e)
        {
            var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
            PdfPTable pdfTable = new PdfPTable(grid_pizarron.ColumnCount);
            Paragraph paragraph = new Paragraph(); //se crea el parrafo
            Paragraph categoria = new Paragraph(); //se crea el parrafo
            Paragraph paragraphfecha = new Paragraph();
            paragraph.Clear();//limpiar el parrago para agregar mas texto
            iTextSharp.text.Font text = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14);
            if (grid_pizarron.RowCount == 0)
            {
                MessageBox.Show("No Hay Datos Para Realizar Un Reporte");
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A2.Rotate(), 5, 5, 5, 5);
                    string filename = save.FileName;
                    FileStream file = new FileStream(filename, FileMode.OpenOrCreate);
                    PdfWriter writer = PdfWriter.GetInstance(doc, file);
                    writer.ViewerPreferences = PdfWriter.PageModeUseThumbs;
                    writer.ViewerPreferences = PdfWriter.PageLayoutOneColumn;
                    doc.Open();
                    paragraph.Font = new iTextSharp.text.Font(FontFactory.GetFont("Arial", 22, BaseColor.BLACK));
                    paragraph.Alignment = Element.ALIGN_CENTER;
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(Chunk.NEWLINE);
                    
                    PdfPTable pdftable = new PdfPTable(grid_pizarron.ColumnCount);

                    for (int j = 0; j < grid_pizarron.Columns.Count - 0; j++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(grid_pizarron.Columns[j].HeaderText, boldFont));
                        cell.Border = 0;
                        pdftable.AddCell(cell);
                    }
                    pdftable.HeaderRows = 0;

                    paragraph.Add("PIZARRON DE MAQUINARIA");//agregar texto
                    doc.Add(paragraph);//lo metes al documento
                    paragraph.Clear();
                    doc.Add(Chunk.NEWLINE);
                    paragraphfecha.Alignment = Element.ALIGN_RIGHT;
                    paragraphfecha.Add(DateTime.Now.ToString("dd/MM/yyyy"));
                    doc.Add(paragraphfecha);//lo metes al documento
                    paragraphfecha.Clear();
                    doc.Add(Chunk.NEWLINE);

                    //itera categorias
                    //foreach (string item in categoria.Items)
                    //{
                       //instanciamos categoria con el valor del primer registro
                        String categoriaCadena = grid_pizarron.Rows[0].Cells[9].Value.ToString();
                    doc.Add(new Paragraph(categoriaCadena, boldFont));
                   
                    for (int i = 0; i < grid_pizarron.Rows.Count-1; i++)
                        {
                        //Inserta categoria text
                        if (categoriaCadena != grid_pizarron.Rows[i].Cells[9].Value.ToString()) {
                            categoriaCadena = grid_pizarron.Rows[i].Cells[9].Value.ToString();
 
                            doc.Add(new Paragraph(categoriaCadena, boldFont));
                            

                            //Limpiar table y agregar headers
                            //Poner encabezados por tabla
                            pdftable = new PdfPTable(grid_pizarron.ColumnCount - 0);
                            for (int j = 0; j < grid_pizarron.Columns.Count - 0; j++)
                            {
                                
                                PdfPCell cell = new PdfPCell(new Phrase(grid_pizarron.Columns[j].HeaderText, boldFont));
                                cell.Border = 0;
                                // cell.Border = 0;
                                pdftable.AddCell(cell);
                            }
                            pdftable.HeaderRows = 0;
                            //fin de crear encabezados
                        }

                        //itera celdas de las columnas
                        for (int k = 0; k < grid_pizarron.Columns.Count; k++)
                                {
                                     if (grid_pizarron[k, i].Value != null)
                                        {

                                ////inserta celdas
                                //doc.Add(new Paragraph(categoriaCadena));
                                            pdftable.DefaultCell.Border = 0;
                                            pdftable.AddCell(new Phrase(grid_pizarron.Rows[i].Cells[k].Value.ToString(), text));
                                            //pdftable.AddCell(new PdfPCell(new Paragraph(grid_pizarron.Rows[i].Cells[k].Value.ToString(), text)) { HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE });
                                            //pdftable.DefaultCell.Border = 0;
                            }
                                }
                            //agregar las celdas
                             doc.Add(pdftable);
                             //Limpiar pdfTable
                             pdftable = new PdfPTable(grid_pizarron.ColumnCount - 0);
                           

                    }
                        //al final
                        //doc.Add(pdftable);



                    //}



                    //float[] widths = new float[] { 15f, 50f, 40f, 40f, 40f, 40f, 40f, 40f, 40f, 40f, 40f, 40f, 40f, 40f, 40f, 40f, 40f };

                    // pdftable.SetWidths(widths);

                    doc.Close();
                    System.Diagnostics.Process.Start(filename);
                }
            }
        }

        private void PIZARRON_Load(object sender, EventArgs e)
        {
          
        }
    }
}

//pizza.id_Pizarron, ma.id_Maquina, sa.id_salidas, ma.nombre_maquina, sa.nombre_obra, ma.origen, sa.fecha_salida, sa.fecha_regreso, ma.encargado, sa.nombre_operador 

/*doc.Add(new Paragraph(item));
                            for (int i = 0; i<grid_pizarron.Rows.Count; i++)

                            {
                                for (int k = 0; k<grid_pizarron.Columns.Count - 0; k++)
                                {

                                    if (grid_pizarron[k, i].Value != null && grid_pizarron.Rows[i].Cells[8].ToString() == item)
                                    {

                                        pdftable.AddCell(new Phrase(grid_pizarron.Rows[i].Cells[k].Value.ToString(), text));

                                        //pdftable.AddCell(new Phrase(dgvLoadAll[k, i].Value.ToString(), text));

                                }
                            }
                        }
                        doc.Add(Chunk.NEWLINE);*/



//                    da = new SqlDataAdapter(" SELECT ma.serie, ma.nombre_maquina, s.nombre_obra, ma.origen, s.fecha_salida, s.fecha_regreso, ma.encargado, s.nombre_operador, ma.categoria from SALIDAS s, MAQUINA ma  WHERE s.id_maquina = ma.id_Maquina ORDER BY 'Categoria'", c.regresaConexion()); 
// 8

// da = new SqlDataAdapter(" SELECT * from  MAQUINA  ORDER BY 'Categoria'", c.regresaConexion());