namespace MAQUINARIA
{
    partial class CLIENTES
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonVolver = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.id_cliente = new System.Windows.Forms.TextBox();
            this.empresa = new System.Windows.Forms.TextBox();
            this.nombre_cliente = new System.Windows.Forms.TextBox();
            this.rfc = new System.Windows.Forms.TextBox();
            this.colonia = new System.Windows.Forms.TextBox();
            this.ciudad = new System.Windows.Forms.TextBox();
            this.codigo_postal = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.telefeno = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.TextBox();
            this.boton_agregar = new System.Windows.Forms.Button();
            this.boton_modificar = new System.Windows.Forms.Button();
            this.boton_eliminar = new System.Windows.Forms.Button();
            this.grid_clientes = new System.Windows.Forms.DataGridView();
            this.Imprimir_Reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.Location = new System.Drawing.Point(12, 12);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(70, 61);
            this.botonVolver.TabIndex = 30;
            this.botonVolver.Text = "ATRAS";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label12.Location = new System.Drawing.Point(389, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 33);
            this.label12.TabIndex = 31;
            this.label12.Text = "MENU DE CLIENTES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "N°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nombre del Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "RFC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(721, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Empresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Colonia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(675, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Ciudad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Codigo Postal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(215, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Teléfono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Correo Electronico:";
            // 
            // id_cliente
            // 
            this.id_cliente.Location = new System.Drawing.Point(34, 114);
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            this.id_cliente.Size = new System.Drawing.Size(135, 20);
            this.id_cliente.TabIndex = 42;
            // 
            // empresa
            // 
            this.empresa.Location = new System.Drawing.Point(778, 114);
            this.empresa.Name = "empresa";
            this.empresa.Size = new System.Drawing.Size(171, 20);
            this.empresa.TabIndex = 43;
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.Location = new System.Drawing.Point(280, 114);
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.Size = new System.Drawing.Size(277, 20);
            this.nombre_cliente.TabIndex = 44;
            this.nombre_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_cliente_KeyPress);
            // 
            // rfc
            // 
            this.rfc.Location = new System.Drawing.Point(597, 114);
            this.rfc.Name = "rfc";
            this.rfc.Size = new System.Drawing.Size(118, 20);
            this.rfc.TabIndex = 45;
            // 
            // colonia
            // 
            this.colonia.Location = new System.Drawing.Point(487, 159);
            this.colonia.Name = "colonia";
            this.colonia.Size = new System.Drawing.Size(182, 20);
            this.colonia.TabIndex = 46;
            // 
            // ciudad
            // 
            this.ciudad.Location = new System.Drawing.Point(724, 159);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(225, 20);
            this.ciudad.TabIndex = 47;
            this.ciudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ciudad_KeyPress);
            // 
            // codigo_postal
            // 
            this.codigo_postal.Location = new System.Drawing.Point(93, 209);
            this.codigo_postal.MaxLength = 5;
            this.codigo_postal.Name = "codigo_postal";
            this.codigo_postal.Size = new System.Drawing.Size(116, 20);
            this.codigo_postal.TabIndex = 48;
            this.codigo_postal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigo_postal_KeyPress);
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(73, 159);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(357, 20);
            this.direccion.TabIndex = 49;
            // 
            // telefeno
            // 
            this.telefeno.Location = new System.Drawing.Point(273, 209);
            this.telefeno.MaxLength = 10;
            this.telefeno.Name = "telefeno";
            this.telefeno.Size = new System.Drawing.Size(143, 20);
            this.telefeno.TabIndex = 50;
            this.telefeno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefeno_KeyPress);
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(516, 209);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(433, 20);
            this.correo.TabIndex = 51;
            // 
            // boton_agregar
            // 
            this.boton_agregar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_agregar.Location = new System.Drawing.Point(12, 251);
            this.boton_agregar.Name = "boton_agregar";
            this.boton_agregar.Size = new System.Drawing.Size(300, 43);
            this.boton_agregar.TabIndex = 52;
            this.boton_agregar.Text = "AGREGAR +";
            this.boton_agregar.UseVisualStyleBackColor = true;
            this.boton_agregar.Click += new System.EventHandler(this.boton_agregar_Click);
            // 
            // boton_modificar
            // 
            this.boton_modificar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_modificar.Location = new System.Drawing.Point(318, 251);
            this.boton_modificar.Name = "boton_modificar";
            this.boton_modificar.Size = new System.Drawing.Size(317, 43);
            this.boton_modificar.TabIndex = 53;
            this.boton_modificar.Text = "MODIFICAR ?";
            this.boton_modificar.UseVisualStyleBackColor = true;
            this.boton_modificar.Click += new System.EventHandler(this.boton_modificar_Click);
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_eliminar.Location = new System.Drawing.Point(641, 251);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(310, 43);
            this.boton_eliminar.TabIndex = 54;
            this.boton_eliminar.Text = "ELIMINAR -";
            this.boton_eliminar.UseVisualStyleBackColor = true;
            this.boton_eliminar.Click += new System.EventHandler(this.boton_eliminar_Click);
            // 
            // grid_clientes
            // 
            this.grid_clientes.AllowUserToAddRows = false;
            this.grid_clientes.AllowUserToDeleteRows = false;
            this.grid_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_clientes.Location = new System.Drawing.Point(15, 300);
            this.grid_clientes.MultiSelect = false;
            this.grid_clientes.Name = "grid_clientes";
            this.grid_clientes.ReadOnly = true;
            this.grid_clientes.Size = new System.Drawing.Size(936, 259);
            this.grid_clientes.TabIndex = 55;
            this.grid_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_clientes_CellClick);
            // 
            // Imprimir_Reporte
            // 
            this.Imprimir_Reporte.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimir_Reporte.Location = new System.Drawing.Point(15, 574);
            this.Imprimir_Reporte.Name = "Imprimir_Reporte";
            this.Imprimir_Reporte.Size = new System.Drawing.Size(248, 43);
            this.Imprimir_Reporte.TabIndex = 74;
            this.Imprimir_Reporte.Text = "IMPRIMIR REPORTE";
            this.Imprimir_Reporte.UseVisualStyleBackColor = true;
            this.Imprimir_Reporte.Click += new System.EventHandler(this.Imprimir_Reporte_Click);
            // 
            // CLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 631);
            this.Controls.Add(this.Imprimir_Reporte);
            this.Controls.Add(this.grid_clientes);
            this.Controls.Add(this.boton_eliminar);
            this.Controls.Add(this.boton_modificar);
            this.Controls.Add(this.boton_agregar);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.telefeno);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.codigo_postal);
            this.Controls.Add(this.ciudad);
            this.Controls.Add(this.colonia);
            this.Controls.Add(this.rfc);
            this.Controls.Add(this.nombre_cliente);
            this.Controls.Add(this.empresa);
            this.Controls.Add(this.id_cliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.botonVolver);
            this.Name = "CLIENTES";
            this.Text = "CLIENTES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CLIENTES_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grid_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox id_cliente;
        private System.Windows.Forms.TextBox empresa;
        private System.Windows.Forms.TextBox nombre_cliente;
        private System.Windows.Forms.TextBox rfc;
        private System.Windows.Forms.TextBox colonia;
        private System.Windows.Forms.TextBox ciudad;
        private System.Windows.Forms.TextBox codigo_postal;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox telefeno;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Button boton_agregar;
        private System.Windows.Forms.Button boton_modificar;
        private System.Windows.Forms.Button boton_eliminar;
        private System.Windows.Forms.DataGridView grid_clientes;
        private System.Windows.Forms.Button Imprimir_Reporte;
    }
}