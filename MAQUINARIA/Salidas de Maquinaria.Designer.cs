namespace MAQUINARIA
{
    partial class Salidas_de_Maquinaria
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
            this.combo_maquina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.combo_operador = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha_regreso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fecha_salida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.origen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_obra = new System.Windows.Forms.ComboBox();
            this.grid_salida_maquinaria = new System.Windows.Forms.DataGridView();
            this.boton_agregar = new System.Windows.Forms.Button();
            this.boton_modificar = new System.Windows.Forms.Button();
            this.boton_Eliminar = new System.Windows.Forms.Button();
            this.Imprimir_Reporte = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cliente = new System.Windows.Forms.TextBox();
            this.categoria = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_salida_maquinaria)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_maquina
            // 
            this.combo_maquina.FormattingEnabled = true;
            this.combo_maquina.Location = new System.Drawing.Point(132, 115);
            this.combo_maquina.Name = "combo_maquina";
            this.combo_maquina.Size = new System.Drawing.Size(255, 21);
            this.combo_maquina.TabIndex = 36;
            this.combo_maquina.SelectedValueChanged += new System.EventHandler(this.combo_maquina_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nombre de la Maquina:";
            // 
            // botonVolver
            // 
            this.botonVolver.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.Location = new System.Drawing.Point(12, 12);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(70, 61);
            this.botonVolver.TabIndex = 37;
            this.botonVolver.Text = "ATRAS";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label12.Location = new System.Drawing.Point(240, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(254, 33);
            this.label12.TabIndex = 38;
            this.label12.Text = "SALIDAS DE LA MAQUINARIA";
            // 
            // combo_operador
            // 
            this.combo_operador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_operador.FormattingEnabled = true;
            this.combo_operador.Location = new System.Drawing.Point(509, 115);
            this.combo_operador.Name = "combo_operador";
            this.combo_operador.Size = new System.Drawing.Size(278, 21);
            this.combo_operador.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nombre del Operador:";
            // 
            // fecha_regreso
            // 
            this.fecha_regreso.Location = new System.Drawing.Point(284, 161);
            this.fecha_regreso.Name = "fecha_regreso";
            this.fecha_regreso.Size = new System.Drawing.Size(103, 20);
            this.fecha_regreso.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Fecha Regreso:";
            // 
            // fecha_salida
            // 
            this.fecha_salida.Location = new System.Drawing.Point(83, 161);
            this.fecha_salida.Name = "fecha_salida";
            this.fecha_salida.Size = new System.Drawing.Size(103, 20);
            this.fecha_salida.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Fecha Salida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Origen:";
            // 
            // origen
            // 
            this.origen.Location = new System.Drawing.Point(448, 161);
            this.origen.Name = "origen";
            this.origen.ReadOnly = true;
            this.origen.Size = new System.Drawing.Size(103, 20);
            this.origen.TabIndex = 66;
            this.origen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.origen_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Obra:";
            // 
            // combo_obra
            // 
            this.combo_obra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_obra.FormattingEnabled = true;
            this.combo_obra.Location = new System.Drawing.Point(596, 161);
            this.combo_obra.Name = "combo_obra";
            this.combo_obra.Size = new System.Drawing.Size(191, 21);
            this.combo_obra.TabIndex = 68;
            this.combo_obra.SelectedIndexChanged += new System.EventHandler(this.combo_obra_SelectedIndexChanged);
            this.combo_obra.SelectedValueChanged += new System.EventHandler(this.combo_obra_SelectedValueChanged);
            // 
            // grid_salida_maquinaria
            // 
            this.grid_salida_maquinaria.AllowUserToAddRows = false;
            this.grid_salida_maquinaria.AllowUserToDeleteRows = false;
            this.grid_salida_maquinaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_salida_maquinaria.Location = new System.Drawing.Point(12, 310);
            this.grid_salida_maquinaria.MultiSelect = false;
            this.grid_salida_maquinaria.Name = "grid_salida_maquinaria";
            this.grid_salida_maquinaria.ReadOnly = true;
            this.grid_salida_maquinaria.Size = new System.Drawing.Size(772, 150);
            this.grid_salida_maquinaria.TabIndex = 69;
            this.grid_salida_maquinaria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_salida_maquinaria_CellClick);
            // 
            // boton_agregar
            // 
            this.boton_agregar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_agregar.Location = new System.Drawing.Point(15, 261);
            this.boton_agregar.Name = "boton_agregar";
            this.boton_agregar.Size = new System.Drawing.Size(248, 43);
            this.boton_agregar.TabIndex = 70;
            this.boton_agregar.Text = "AGREGAR +";
            this.boton_agregar.UseVisualStyleBackColor = true;
            this.boton_agregar.Click += new System.EventHandler(this.boton_agregar_Click);
            // 
            // boton_modificar
            // 
            this.boton_modificar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_modificar.Location = new System.Drawing.Point(265, 261);
            this.boton_modificar.Name = "boton_modificar";
            this.boton_modificar.Size = new System.Drawing.Size(259, 43);
            this.boton_modificar.TabIndex = 71;
            this.boton_modificar.Text = "MODIFICAR ?";
            this.boton_modificar.UseVisualStyleBackColor = true;
            this.boton_modificar.Click += new System.EventHandler(this.boton_modificar_Click);
            // 
            // boton_Eliminar
            // 
            this.boton_Eliminar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_Eliminar.Location = new System.Drawing.Point(527, 261);
            this.boton_Eliminar.Name = "boton_Eliminar";
            this.boton_Eliminar.Size = new System.Drawing.Size(257, 43);
            this.boton_Eliminar.TabIndex = 72;
            this.boton_Eliminar.Text = "ELIMINAR -";
            this.boton_Eliminar.UseVisualStyleBackColor = true;
            this.boton_Eliminar.Click += new System.EventHandler(this.boton_Eliminar_Click);
            // 
            // Imprimir_Reporte
            // 
            this.Imprimir_Reporte.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimir_Reporte.Location = new System.Drawing.Point(15, 466);
            this.Imprimir_Reporte.Name = "Imprimir_Reporte";
            this.Imprimir_Reporte.Size = new System.Drawing.Size(248, 43);
            this.Imprimir_Reporte.TabIndex = 73;
            this.Imprimir_Reporte.Text = "IMPRIMIR REPORTE";
            this.Imprimir_Reporte.UseVisualStyleBackColor = true;
            this.Imprimir_Reporte.Click += new System.EventHandler(this.Imprimir_Reporte_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "dd-mm-aaaa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "dd-mm-aaaa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "Cliente:";
            // 
            // cliente
            // 
            this.cliente.Location = new System.Drawing.Point(60, 225);
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Size = new System.Drawing.Size(256, 20);
            this.cliente.TabIndex = 77;
            // 
            // categoria
            // 
            this.categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoria.FormattingEnabled = true;
            this.categoria.Location = new System.Drawing.Point(421, 224);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(191, 21);
            this.categoria.TabIndex = 78;
            this.categoria.SelectedValueChanged += new System.EventHandler(this.categoria_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(354, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 79;
            this.label10.Text = "Categoria:";
            // 
            // Salidas_de_Maquinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Imprimir_Reporte);
            this.Controls.Add(this.boton_Eliminar);
            this.Controls.Add(this.boton_modificar);
            this.Controls.Add(this.boton_agregar);
            this.Controls.Add(this.grid_salida_maquinaria);
            this.Controls.Add(this.combo_obra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.origen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecha_regreso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fecha_salida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combo_operador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.combo_maquina);
            this.Controls.Add(this.label1);
            this.Name = "Salidas_de_Maquinaria";
            this.Text = "Salidas_de_Maquinaria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Salidas_de_Maquinaria_FormClosing);
            this.Load += new System.EventHandler(this.Salidas_de_Maquinaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_salida_maquinaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_maquina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox combo_operador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fecha_regreso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fecha_salida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox origen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_obra;
        private System.Windows.Forms.DataGridView grid_salida_maquinaria;
        private System.Windows.Forms.Button boton_agregar;
        private System.Windows.Forms.Button boton_modificar;
        private System.Windows.Forms.Button boton_Eliminar;
        private System.Windows.Forms.Button Imprimir_Reporte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cliente;
        private System.Windows.Forms.ComboBox categoria;
        private System.Windows.Forms.Label label10;
    }
}