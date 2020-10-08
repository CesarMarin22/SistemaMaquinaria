using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAQUINARIA
{
    public partial class Form1 : Form
    {
        public static string tipo;
        private CLIENTES clientes;
        private FALLAS fallas;
        private MAQUINARIA maquinaria;
        private OBRAS obras;
        private PIZARRON pizarron;
        private OPERADORES operadores;
        
        public Form1(string tipoUsuario)
        {
            InitializeComponent();
            if (tipoUsuario == "CONSULTA")
            {
                button1.Enabled = false;
                boton_clientes.Enabled = false;
                boton_maquinaria.Enabled = false;
                boton_fallas.Enabled = false;
                boton_Operadores.Enabled = false;
            }
            if (tipoUsuario == "MARY")
            {
                button1.Enabled = false;
                boton_clientes.Enabled = false;
                boton_fallas.Enabled = false;
                boton_Operadores.Enabled = false;
                boton_pizarron.Enabled = false;
            }
            tipo = tipoUsuario;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obras = new OBRAS(this);
            obras.Show();
            this.Hide();
        }

        private void boton_clientes_Click(object sender, EventArgs e)
        {
            clientes = new CLIENTES(this);
            clientes.Show();
            this.Hide();
        }

        private void boton_maquinaria_Click(object sender, EventArgs e)
        {
            maquinaria = new MAQUINARIA(this);
            maquinaria.Show();
            this.Hide();
        }

        private void boton_fallas_Click(object sender, EventArgs e)
        {
            fallas = new FALLAS(this);
            fallas.Show();
            this.Hide();
        }

        private void boton_pizarron_Click(object sender, EventArgs e)
        {
            pizarron = new PIZARRON(this);
            pizarron.Show();
            this.Hide();
        }

        private void boton_Operadores_Click(object sender, EventArgs e)
        {
            operadores = new OPERADORES(this);
            operadores.Show();
            this.Hide();
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
