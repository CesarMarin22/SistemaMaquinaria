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
    public partial class OBRAS : Form
    {
        private Form1 inicio;
        conexion c;
        SqlDataAdapter da; //select
        DataTable dt; //datos a tabla
        SqlCommand cmd; //comando
        DataGridView dgv;
        SqlDataReader dr;
        public SqlConnection cn;
        public OBRAS(Form1 ini)
        {
           
            InitializeComponent();
           
            Fecha_Inicio.Text = DateTime.Now.ToString("dd-MM-yyyy");
            Fecha_Termino.Text = DateTime.Now.ToString("dd-MM-yyyy");
            CargaResidente();
            CargaEmpresaFacturar();
           // CargaCliente();
            inicio = ini;
            MuestraDatos(Grid_Obras);
            this.DoubleBuffered = true;
            if (Form1.tipo == "USUARIO")
            {
                Eliminar_Obras.Enabled = false;
                Modificar_Obras.Enabled = false;
            }


        }

        private void CargaResidente()
        {
            Residente.Items.Insert(0, "Andres Ponce Rodriguez");
            Residente.SelectedIndex = 0;
            Residente.Items.Insert(1, "Gerardo Alonso Perez");
            Residente.Items.Insert(2, "Joel Gerardo Palomares Flores");
            Residente.Items.Insert(3, "Luis Humberto Diaz Mendoza");
            Residente.Items.Insert(4, "Mario Alberto Murillo Guerrero");
            Residente.Items.Insert(5, "Mauro Alejandro Herrera Guadarrama");
        }

        private void CargaEmpresaFacturar()
        {
            Empresa_Facturar.Items.Insert(0, "Consorcio Constructor del Centro de Maexico SA de CV");
            Empresa_Facturar.SelectedIndex = 0;
            Empresa_Facturar.Items.Insert(1, "Argufer Grupo Constructor");
            Empresa_Facturar.Items.Insert(2, "Maquinaria y Renta Zacatecas SA DE CV");
            Empresa_Facturar.Items.Insert(3, "Maquinaria y Renta Potosinas SA de CV");
            Empresa_Facturar.Items.Insert(4, "Maquirsa del Centro");
            Empresa_Facturar.Items.Insert(5, "Promotora Naranja Forte SA de CV");
            Empresa_Facturar.Items.Insert(6, "Provrec del Potosi SA de CV");
            Empresa_Facturar.Items.Insert(7, "Resete Asociados SC");
            Empresa_Facturar.Items.Insert(8, "Servicios Especializados y Comercializacion C SA de CV");
            Empresa_Facturar.Items.Insert(9, "Trituracion en Movimiento SA de CV");
            Empresa_Facturar.Items.Insert(10, "Tupax Constructora SA de CV");
        }

      /*  private void CargaCliente()
        {
            Cliente_Obra.Items.Insert(0, "Julio Marin");
            Cliente_Obra.SelectedIndex = 0;
            Cliente_Obra.Items.Insert(1, "Cesar Cardona");
            Cliente_Obra.Items.Insert(2, "Rafael Fariña");
            Cliente_Obra.Items.Insert(3, "Dante lopez");
            
        }*/

        private void OBRAS_Load(object sender, EventArgs e)
        {
            c = new conexion();
            cmd = new SqlCommand("SELECT nombre_cliente FROM CLIENTE", c.regresaConexion());
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Cliente_Obra.Items.Add(dr["nombre_cliente"].ToString());
            }
            Cliente_Obra.SelectedIndex =0;
            c.cerrarConexion();

        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OBRAS_FormClosing(object sender, FormClosingEventArgs e)
        {
            inicio.Show();
        }

        public void MuestraDatos(DataGridView d)
        {
            try
            {
                c = new conexion();
                da = new SqlDataAdapter("SELECT id_Obra, nombre_obra, lugar_obra, fecha_inicio, fecha_termino, empresa_factura, estimacion, costo, residente, notas, cliente_obra FROM OBRA", c.regresaConexion());
                dt = new DataTable();
                da.Fill(dt);
                d.DataSource = dt;
                c.cerrarConexion();
                if(Grid_Obras.RowCount==0)
                {
                    Modificar_Obras.Enabled = false;
                    Eliminar_Obras.Enabled = false;
                }
                if(Grid_Obras.RowCount != 0)
                {
                    Modificar_Obras.Enabled = true;
                    Eliminar_Obras.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar" + ex.ToString());
                c.cerrarConexion();
            }
        }

        private void Agregar_Obras_Click(object sender, EventArgs e)
        {
            bool existe = false;
            try
            {
                if(Nombre_Obra.Text == "" || Lugar_Obra.Text == "" || Fecha_Inicio.Text == "" || Fecha_Termino.Text == "" || Empresa_Facturar.Text == "" || Estimacion_Obra.Text == "" || Costo_Obra.Text == "" || Residente.Text == "" || Notas.Text == "" || Cliente_Obra.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
                else
                {

               

                if(Grid_Obras.RowCount==0)
                {
                    c = new conexion();
                    cmd = new SqlCommand("INSERT INTO OBRA(nombre_obra, lugar_obra, fecha_inicio, fecha_termino, empresa_factura, estimacion, costo, residente, notas, cliente_obra) VALUES('" + Nombre_Obra.Text + "', '" + Lugar_Obra.Text + "', '" + Fecha_Inicio.Text + "', '" +Fecha_Termino.Text+ "', '" + Empresa_Facturar.SelectedItem +"', "+Estimacion_Obra.Text+", "+Costo_Obra.Text+ ", '" + Residente.SelectedItem + "','"+ Notas.Text +"', '" + Cliente_Obra.SelectedItem+ "' )", c.regresaConexion());
                    cmd.ExecuteNonQuery();
                    c.cerrarConexion();
                    MessageBox.Show("Obra Insertada");
                    id_obra.Text = "";
                    Nombre_Obra.Text = "";
                    Lugar_Obra.Text = "";
                    Fecha_Inicio.Text = "";
                    Fecha_Termino.Text = "";
                    Empresa_Facturar.Text = "";
                    Estimacion_Obra.Text = "";
                    Costo_Obra.Text = "";
                    Residente.Text = "";
                    Notas.Text = "";
                    Cliente_Obra.Text = "";
                    Fecha_Inicio.Text = DateTime.Now.ToString("dd-MM-yyyy");
                    Fecha_Termino.Text = DateTime.Now.ToString("dd-MM-yyyy");
                    }
                else
                {
                    for (int i = 0; i < Grid_Obras.RowCount; i++)
                    {
                        if (Grid_Obras.Rows[i].Cells[0].Value.ToString() == id_obra.Text)
                        {
                            existe = true;
                        }
                    }
                    if (existe == false)
                    {
                        c = new conexion();
                        cmd = new SqlCommand("INSERT INTO OBRA(nombre_obra, lugar_obra, fecha_inicio, fecha_termino, empresa_factura, estimacion, costo, residente, notas, cliente_obra) VALUES('" + Nombre_Obra.Text + "', '" + Lugar_Obra.Text + "','" + Fecha_Inicio.Text + "', '" + Fecha_Termino.Text + "', '" + Empresa_Facturar.SelectedItem + "', " + Estimacion_Obra.Text + ", " + Costo_Obra.Text + ", '" + Residente.SelectedItem + "','" + Notas.Text + "', '" + Cliente_Obra.SelectedItem + "' )", c.regresaConexion());
                        cmd.ExecuteNonQuery();
                        c.cerrarConexion();
                        MessageBox.Show("Obra Insertada");
                        id_obra.Text = "";
                        Nombre_Obra.Text = "";
                        Lugar_Obra.Text = "";
                        Fecha_Inicio.Text = "";
                        Fecha_Termino.Text = "";
                        Estimacion_Obra.Text = "";
                        Costo_Obra.Text = "";
                        Notas.Text = "";
                        Fecha_Inicio.Text = DateTime.Now.ToString("dd-MM-yyyy");
                        Fecha_Termino.Text = DateTime.Now.ToString("dd-MM-yyyy");
                        }
                    else
                        MessageBox.Show("YA ESTA DADA DE ALTA LA OBRA");
                        id_obra.Text = "";
                        Nombre_Obra.Text = "";
                        Lugar_Obra.Text = "";
                        Fecha_Inicio.Text = "";
                        Fecha_Termino.Text = "";
                        Estimacion_Obra.Text = "";
                        Costo_Obra.Text = "";
                        Notas.Text = "";
                        Fecha_Inicio.Text = DateTime.Now.ToString("dd-MM-yyyy");
                        Fecha_Termino.Text = DateTime.Now.ToString("dd-MM-yyyy");

                    }

                MuestraDatos(Grid_Obras);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar" + ex.ToString());
                c.cerrarConexion();
            }
        }

        private void Eliminar_Obras_Click(object sender, EventArgs e)
        {
            try
            {
                c = new conexion();
                cmd = new SqlCommand("DELETE FROM OBRA WHERE id_Obra =" + id_obra.Text, c.regresaConexion());
                cmd.ExecuteNonQuery();
                c.cerrarConexion();
                MuestraDatos(Grid_Obras);
                MessageBox.Show("Reporte eliminado");
                id_obra.Text = "";
                Nombre_Obra.Text = "";
                Lugar_Obra.Text = "";
                Estimacion_Obra.Text = "";
                Costo_Obra.Text = "";
                Notas.Text = "";
            }
            catch
            {

            }
        }

        private void Grid_Obras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Grid_Obras.Rows[e.RowIndex].Selected = true;
            id_obra.Text = Grid_Obras.CurrentRow.Cells[0].Value.ToString();
            Nombre_Obra.Text = Grid_Obras.CurrentRow.Cells[1].Value.ToString();
            Lugar_Obra.Text = Grid_Obras.CurrentRow.Cells[2].Value.ToString();
            Fecha_Inicio.Text = DateTime.Parse(Grid_Obras.CurrentRow.Cells[3].Value.ToString()).ToString("dd-MM-yyyy");
            Fecha_Termino.Text = DateTime.Parse(Grid_Obras.CurrentRow.Cells[4].Value.ToString()).ToString("dd-MM-yyyy");
            Empresa_Facturar.Text = Grid_Obras.CurrentRow.Cells[5].Value.ToString();
            Estimacion_Obra.Text = Grid_Obras.CurrentRow.Cells[6].Value.ToString();
            Costo_Obra.Text = Grid_Obras.CurrentRow.Cells[7].Value.ToString();
            Residente.Text = Grid_Obras.CurrentRow.Cells[8].Value.ToString();
            Notas.Text = Grid_Obras.CurrentRow.Cells[9].Value.ToString();
            Cliente_Obra.Text = Grid_Obras.CurrentRow.Cells[10].Value.ToString();

        }

        private void Estimacion_Obra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Costo_Obra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void id_obra_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Modificar_Obras_Click(object sender, EventArgs e)
        {
            try
            { //(id_Obra, nombre_obra, lugar_obra, fecha_inicio, fecha_termino, empresa_factura, estimacion, costo, residente, notas, cliente_obra) VALUES(" + id_obra.Text+",'" + Nombre_Obra.Text + "', '" + Lugar_Obra.Text + "','" + Fecha_Inicio.Text + "', '" + Fecha_Termino.Text + "', '" + Empresa_Facturar.SelectedItem + "', " + Estimacion_Obra.Text + ", " + Costo_Obra.Text + ", '" + Residente.SelectedItem + "','" + Notas.Text + "', '" + Cliente_Obra.SelectedItem + "' )", c.regresaConexion());
                c = new conexion();
                cmd = new SqlCommand("UPDATE OBRA SET nombre_obra ='" + Nombre_Obra.Text + "',lugar_obra='" + Lugar_Obra.Text + "',fecha_inicio='" + Fecha_Inicio.Text + "',fecha_termino='" + Fecha_Termino.Text + "',empresa_factura='" + Empresa_Facturar.SelectedItem + "',estimacion=" + Estimacion_Obra.Text + ",costo=" + Costo_Obra.Text + ",residente='" + Residente.SelectedItem + "',notas='" + Notas.Text + "',cliente_obra='" + Cliente_Obra.SelectedItem + "' WHERE id_Obra=" + id_obra.Text, c.regresaConexion());
                cmd.ExecuteNonQuery();
                c.cerrarConexion();
                MessageBox.Show("Reporte modificado");
                id_obra.Text = "";
                Nombre_Obra.Text = "";
                Lugar_Obra.Text = "";
                Estimacion_Obra.Text = "";
                Costo_Obra.Text = "";
                Notas.Text = "";
                MuestraDatos(Grid_Obras);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Modificar" + ex.ToString());
                c.cerrarConexion();
            }
        }

        private void Nombre_Obra_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Imprimir_Reporte_Click(object sender, EventArgs e)
        {
            Paragraph paragraph = new Paragraph(); //se crea el parrafo
            Paragraph paragraphfecha = new Paragraph();
            paragraph.Clear();//limpiar el parrago para agregar mas texto
            iTextSharp.text.Font text = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 11);
            if (Grid_Obras.RowCount == 0)
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
                    paragraph.Add("REPORTE DE OBRAS");//agregar texto
                    doc.Add(paragraph);//lo metes al documento
                    paragraph.Clear();
                    doc.Add(Chunk.NEWLINE);
                    paragraphfecha.Alignment = Element.ALIGN_RIGHT;
                    paragraphfecha.Add(DateTime.Now.ToString("dd/MM/yyyy"));
                    doc.Add(paragraphfecha);//lo metes al documento
                    paragraphfecha.Clear();
                    doc.Add(Chunk.NEWLINE);
                    PdfPTable pdftable = new PdfPTable(Grid_Obras.ColumnCount - 0);

                    for (int j = 0; j < Grid_Obras.Columns.Count - 0; j++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(Grid_Obras.Columns[j].HeaderText, text));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        pdftable.AddCell(cell);
                    }

                    pdftable.HeaderRows = 0;
                    for (int i = 0; i < Grid_Obras.Rows.Count; i++)

                    {
                        for (int k = 0; k < Grid_Obras.Columns.Count - 0; k++)
                        {

                            if (Grid_Obras[k, i].Value != null)
                            {
                                pdftable.AddCell(new Phrase(Grid_Obras.Rows[i].Cells[k].Value.ToString(), text));
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
