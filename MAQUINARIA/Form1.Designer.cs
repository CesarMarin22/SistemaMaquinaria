namespace MAQUINARIA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.boton_clientes = new System.Windows.Forms.Button();
            this.boton_maquinaria = new System.Windows.Forms.Button();
            this.boton_fallas = new System.Windows.Forms.Button();
            this.boton_pizarron = new System.Windows.Forms.Button();
            this.boton_Operadores = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(406, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "OBRAS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boton_clientes
            // 
            this.boton_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton_clientes.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_clientes.Location = new System.Drawing.Point(208, 3);
            this.boton_clientes.Name = "boton_clientes";
            this.boton_clientes.Size = new System.Drawing.Size(192, 55);
            this.boton_clientes.TabIndex = 1;
            this.boton_clientes.Text = "CLIENTES";
            this.boton_clientes.UseVisualStyleBackColor = true;
            this.boton_clientes.Click += new System.EventHandler(this.boton_clientes_Click);
            // 
            // boton_maquinaria
            // 
            this.boton_maquinaria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton_maquinaria.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_maquinaria.Location = new System.Drawing.Point(1, 3);
            this.boton_maquinaria.Name = "boton_maquinaria";
            this.boton_maquinaria.Size = new System.Drawing.Size(201, 55);
            this.boton_maquinaria.TabIndex = 2;
            this.boton_maquinaria.Text = "MAQUINARIA";
            this.boton_maquinaria.UseVisualStyleBackColor = true;
            this.boton_maquinaria.Click += new System.EventHandler(this.boton_maquinaria_Click);
            // 
            // boton_fallas
            // 
            this.boton_fallas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton_fallas.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_fallas.Location = new System.Drawing.Point(590, 3);
            this.boton_fallas.Name = "boton_fallas";
            this.boton_fallas.Size = new System.Drawing.Size(214, 55);
            this.boton_fallas.TabIndex = 3;
            this.boton_fallas.Text = "MANTENIMIENTO ";
            this.boton_fallas.UseVisualStyleBackColor = true;
            this.boton_fallas.Click += new System.EventHandler(this.boton_fallas_Click);
            // 
            // boton_pizarron
            // 
            this.boton_pizarron.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton_pizarron.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_pizarron.Location = new System.Drawing.Point(406, 77);
            this.boton_pizarron.Name = "boton_pizarron";
            this.boton_pizarron.Size = new System.Drawing.Size(178, 55);
            this.boton_pizarron.TabIndex = 4;
            this.boton_pizarron.Text = "PIZARRON";
            this.boton_pizarron.UseVisualStyleBackColor = true;
            this.boton_pizarron.Click += new System.EventHandler(this.boton_pizarron_Click);
            // 
            // boton_Operadores
            // 
            this.boton_Operadores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton_Operadores.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_Operadores.Location = new System.Drawing.Point(810, 3);
            this.boton_Operadores.Name = "boton_Operadores";
            this.boton_Operadores.Size = new System.Drawing.Size(170, 55);
            this.boton_Operadores.TabIndex = 5;
            this.boton_Operadores.Text = "OPERADORES";
            this.boton_Operadores.UseVisualStyleBackColor = true;
            this.boton_Operadores.Click += new System.EventHandler(this.boton_Operadores_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(12, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(968, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "* EL MENU DE LA SALIDAS Y LAS HORAS DE LA MAQUINARIA SE ENCUENTRANB DENTRO DEL ME" +
    "NU DE MAQUINARIA";
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CerrarSesion.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarSesion.Location = new System.Drawing.Point(315, 497);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(323, 78);
            this.CerrarSesion.TabIndex = 7;
            this.CerrarSesion.Text = "Cerrar Sesión ";
            this.CerrarSesion.UseVisualStyleBackColor = true;
            this.CerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MAQUINARIA.Properties.Resources.logo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(986, 652);
            this.Controls.Add(this.CerrarSesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_Operadores);
            this.Controls.Add(this.boton_pizarron);
            this.Controls.Add(this.boton_fallas);
            this.Controls.Add(this.boton_maquinaria);
            this.Controls.Add(this.boton_clientes);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "SISTEMA DE SALIDA DE MAQUINARIA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button boton_clientes;
        private System.Windows.Forms.Button boton_maquinaria;
        private System.Windows.Forms.Button boton_fallas;
        private System.Windows.Forms.Button boton_pizarron;
        private System.Windows.Forms.Button boton_Operadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CerrarSesion;
    }
}

