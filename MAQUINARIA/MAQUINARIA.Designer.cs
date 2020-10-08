namespace MAQUINARIA
{
    partial class MAQUINARIA
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
            this.nombre_maquina = new System.Windows.Forms.TextBox();
            this.marca = new System.Windows.Forms.TextBox();
            this.serie = new System.Windows.Forms.TextBox();
            this.origen = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.id_Maquina = new System.Windows.Forms.TextBox();
            this.boton_agregar = new System.Windows.Forms.Button();
            this.boton_modificar = new System.Windows.Forms.Button();
            this.boton_eliminar = new System.Windows.Forms.Button();
            this.grid_maquina = new System.Windows.Forms.DataGridView();
            this.salida_maquinaria = new System.Windows.Forms.Button();
            this.horas_maquinaria = new System.Windows.Forms.Button();
            this.Imprimir_Reporte = new System.Windows.Forms.Button();
            this.encargado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_maquina)).BeginInit();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.Location = new System.Drawing.Point(12, 12);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(70, 61);
            this.botonVolver.TabIndex = 31;
            this.botonVolver.Text = "ATRAS";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label12.Location = new System.Drawing.Point(400, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 33);
            this.label12.TabIndex = 32;
            this.label12.Text = "MENU DE MAQUINARIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "N°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre de la Maquina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(817, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Serie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Origen:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Precio:";
            // 
            // nombre_maquina
            // 
            this.nombre_maquina.Location = new System.Drawing.Point(307, 127);
            this.nombre_maquina.Name = "nombre_maquina";
            this.nombre_maquina.Size = new System.Drawing.Size(311, 20);
            this.nombre_maquina.TabIndex = 42;
            this.nombre_maquina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_maquina_KeyPress);
            // 
            // marca
            // 
            this.marca.Location = new System.Drawing.Point(670, 127);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(141, 20);
            this.marca.TabIndex = 43;
            // 
            // serie
            // 
            this.serie.Location = new System.Drawing.Point(857, 127);
            this.serie.Name = "serie";
            this.serie.Size = new System.Drawing.Size(127, 20);
            this.serie.TabIndex = 44;
            // 
            // origen
            // 
            this.origen.Location = new System.Drawing.Point(59, 168);
            this.origen.Name = "origen";
            this.origen.Size = new System.Drawing.Size(169, 20);
            this.origen.TabIndex = 45;
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(277, 168);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(112, 20);
            this.precio.TabIndex = 46;
            this.precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precio_KeyPress);
            // 
            // id_Maquina
            // 
            this.id_Maquina.Location = new System.Drawing.Point(33, 127);
            this.id_Maquina.Name = "id_Maquina";
            this.id_Maquina.ReadOnly = true;
            this.id_Maquina.Size = new System.Drawing.Size(145, 20);
            this.id_Maquina.TabIndex = 47;
            // 
            // boton_agregar
            // 
            this.boton_agregar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_agregar.Location = new System.Drawing.Point(12, 203);
            this.boton_agregar.Name = "boton_agregar";
            this.boton_agregar.Size = new System.Drawing.Size(319, 43);
            this.boton_agregar.TabIndex = 56;
            this.boton_agregar.Text = "AGREGAR +";
            this.boton_agregar.UseVisualStyleBackColor = true;
            this.boton_agregar.Click += new System.EventHandler(this.boton_agregar_Click);
            // 
            // boton_modificar
            // 
            this.boton_modificar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_modificar.Location = new System.Drawing.Point(337, 203);
            this.boton_modificar.Name = "boton_modificar";
            this.boton_modificar.Size = new System.Drawing.Size(327, 43);
            this.boton_modificar.TabIndex = 57;
            this.boton_modificar.Text = "MODIFICAR ?";
            this.boton_modificar.UseVisualStyleBackColor = true;
            this.boton_modificar.Click += new System.EventHandler(this.boton_modificar_Click);
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_eliminar.Location = new System.Drawing.Point(670, 203);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(317, 43);
            this.boton_eliminar.TabIndex = 58;
            this.boton_eliminar.Text = "ELIMINAR -";
            this.boton_eliminar.UseVisualStyleBackColor = true;
            this.boton_eliminar.Click += new System.EventHandler(this.boton_eliminar_Click);
            // 
            // grid_maquina
            // 
            this.grid_maquina.AllowUserToAddRows = false;
            this.grid_maquina.AllowUserToDeleteRows = false;
            this.grid_maquina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_maquina.Location = new System.Drawing.Point(15, 252);
            this.grid_maquina.MultiSelect = false;
            this.grid_maquina.Name = "grid_maquina";
            this.grid_maquina.ReadOnly = true;
            this.grid_maquina.Size = new System.Drawing.Size(972, 232);
            this.grid_maquina.TabIndex = 59;
            this.grid_maquina.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_maquina_CellClick);
            // 
            // salida_maquinaria
            // 
            this.salida_maquinaria.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salida_maquinaria.Location = new System.Drawing.Point(15, 499);
            this.salida_maquinaria.Name = "salida_maquinaria";
            this.salida_maquinaria.Size = new System.Drawing.Size(448, 80);
            this.salida_maquinaria.TabIndex = 60;
            this.salida_maquinaria.Text = "SALIDAS DE  MAQUINARIA";
            this.salida_maquinaria.UseVisualStyleBackColor = true;
            this.salida_maquinaria.Click += new System.EventHandler(this.salida_maquinaria_Click);
            // 
            // horas_maquinaria
            // 
            this.horas_maquinaria.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horas_maquinaria.Location = new System.Drawing.Point(491, 499);
            this.horas_maquinaria.Name = "horas_maquinaria";
            this.horas_maquinaria.Size = new System.Drawing.Size(496, 80);
            this.horas_maquinaria.TabIndex = 61;
            this.horas_maquinaria.Text = "HORAS DE LA MAQUINARIA";
            this.horas_maquinaria.UseVisualStyleBackColor = true;
            this.horas_maquinaria.Click += new System.EventHandler(this.horas_maquinaria_Click);
            // 
            // Imprimir_Reporte
            // 
            this.Imprimir_Reporte.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimir_Reporte.Location = new System.Drawing.Point(721, 30);
            this.Imprimir_Reporte.Name = "Imprimir_Reporte";
            this.Imprimir_Reporte.Size = new System.Drawing.Size(248, 43);
            this.Imprimir_Reporte.TabIndex = 74;
            this.Imprimir_Reporte.Text = "IMPRIMIR REPORTE";
            this.Imprimir_Reporte.UseVisualStyleBackColor = true;
            this.Imprimir_Reporte.Click += new System.EventHandler(this.Imprimir_Reporte_Click);
            // 
            // encargado
            // 
            this.encargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encargado.FormattingEnabled = true;
            this.encargado.Location = new System.Drawing.Point(468, 167);
            this.encargado.Name = "encargado";
            this.encargado.Size = new System.Drawing.Size(224, 21);
            this.encargado.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Encargado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(702, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "Categoria";
            // 
            // categoria
            // 
            this.categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoria.FormattingEnabled = true;
            this.categoria.Location = new System.Drawing.Point(760, 168);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(224, 21);
            this.categoria.TabIndex = 78;
            // 
            // MAQUINARIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 585);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.encargado);
            this.Controls.Add(this.Imprimir_Reporte);
            this.Controls.Add(this.horas_maquinaria);
            this.Controls.Add(this.salida_maquinaria);
            this.Controls.Add(this.grid_maquina);
            this.Controls.Add(this.boton_eliminar);
            this.Controls.Add(this.boton_modificar);
            this.Controls.Add(this.boton_agregar);
            this.Controls.Add(this.id_Maquina);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.origen);
            this.Controls.Add(this.serie);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.nombre_maquina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.botonVolver);
            this.Name = "MAQUINARIA";
            this.Text = "MAQUINARIA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MAQUINARIA_FormClosing);
            this.Load += new System.EventHandler(this.MAQUINARIA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_maquina)).EndInit();
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
        private System.Windows.Forms.TextBox nombre_maquina;
        private System.Windows.Forms.TextBox marca;
        private System.Windows.Forms.TextBox serie;
        private System.Windows.Forms.TextBox origen;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox id_Maquina;
        private System.Windows.Forms.Button boton_agregar;
        private System.Windows.Forms.Button boton_modificar;
        private System.Windows.Forms.Button boton_eliminar;
        private System.Windows.Forms.DataGridView grid_maquina;
        private System.Windows.Forms.Button salida_maquinaria;
        private System.Windows.Forms.Button horas_maquinaria;
        private System.Windows.Forms.Button Imprimir_Reporte;
        private System.Windows.Forms.ComboBox encargado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox categoria;
    }
}