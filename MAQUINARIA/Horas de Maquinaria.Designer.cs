namespace MAQUINARIA
{
    partial class Horas_de_Maquinaria
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
            this.nombre_maquina = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.horas_trabajadas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.horas_totales = new System.Windows.Forms.TextBox();
            this.boton_agregar = new System.Windows.Forms.Button();
            this.boton_modificar = new System.Windows.Forms.Button();
            this.boton_eliminar = new System.Windows.Forms.Button();
            this.grid_horas_maquinaria = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.fecha_inicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fecha_final = new System.Windows.Forms.TextBox();
            this.imprime_reporte = new System.Windows.Forms.Button();
            this.horas_acumuladas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.id_horas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.notas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_horas_maquinaria)).BeginInit();
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
            this.label12.Location = new System.Drawing.Point(306, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(238, 33);
            this.label12.TabIndex = 32;
            this.label12.Text = "HORAS DE LA MAQUINARIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombre de la Maquina";
            // 
            // nombre_maquina
            // 
            this.nombre_maquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nombre_maquina.FormattingEnabled = true;
            this.nombre_maquina.Location = new System.Drawing.Point(132, 108);
            this.nombre_maquina.Name = "nombre_maquina";
            this.nombre_maquina.Size = new System.Drawing.Size(227, 21);
            this.nombre_maquina.TabIndex = 34;
            this.nombre_maquina.SelectedIndexChanged += new System.EventHandler(this.nombre_maquina_SelectedIndexChanged);
            this.nombre_maquina.SelectedValueChanged += new System.EventHandler(this.nombre_maquina_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Horas Trabajadas";
            // 
            // horas_trabajadas
            // 
            this.horas_trabajadas.Location = new System.Drawing.Point(462, 108);
            this.horas_trabajadas.Name = "horas_trabajadas";
            this.horas_trabajadas.Size = new System.Drawing.Size(103, 20);
            this.horas_trabajadas.TabIndex = 36;
            this.horas_trabajadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.horas_trabajadas_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Horas Totales";
            // 
            // horas_totales
            // 
            this.horas_totales.Location = new System.Drawing.Point(462, 141);
            this.horas_totales.Name = "horas_totales";
            this.horas_totales.ReadOnly = true;
            this.horas_totales.Size = new System.Drawing.Size(103, 20);
            this.horas_totales.TabIndex = 38;
            // 
            // boton_agregar
            // 
            this.boton_agregar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_agregar.Location = new System.Drawing.Point(15, 320);
            this.boton_agregar.Name = "boton_agregar";
            this.boton_agregar.Size = new System.Drawing.Size(248, 43);
            this.boton_agregar.TabIndex = 53;
            this.boton_agregar.Text = "AGREGAR +";
            this.boton_agregar.UseVisualStyleBackColor = true;
            this.boton_agregar.Click += new System.EventHandler(this.boton_agregar_Click);
            // 
            // boton_modificar
            // 
            this.boton_modificar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_modificar.Location = new System.Drawing.Point(266, 320);
            this.boton_modificar.Name = "boton_modificar";
            this.boton_modificar.Size = new System.Drawing.Size(259, 43);
            this.boton_modificar.TabIndex = 54;
            this.boton_modificar.Text = "MODIFICAR ?";
            this.boton_modificar.UseVisualStyleBackColor = true;
            this.boton_modificar.Click += new System.EventHandler(this.boton_modificar_Click);
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_eliminar.Location = new System.Drawing.Point(528, 320);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(257, 43);
            this.boton_eliminar.TabIndex = 55;
            this.boton_eliminar.Text = "ELIMINAR -";
            this.boton_eliminar.UseVisualStyleBackColor = true;
            this.boton_eliminar.Click += new System.EventHandler(this.boton_eliminar_Click);
            // 
            // grid_horas_maquinaria
            // 
            this.grid_horas_maquinaria.AllowUserToAddRows = false;
            this.grid_horas_maquinaria.AllowUserToDeleteRows = false;
            this.grid_horas_maquinaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_horas_maquinaria.Location = new System.Drawing.Point(15, 369);
            this.grid_horas_maquinaria.MultiSelect = false;
            this.grid_horas_maquinaria.Name = "grid_horas_maquinaria";
            this.grid_horas_maquinaria.ReadOnly = true;
            this.grid_horas_maquinaria.Size = new System.Drawing.Size(773, 207);
            this.grid_horas_maquinaria.TabIndex = 56;
            this.grid_horas_maquinaria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_horas_maquinaria_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Fecha Inicio";
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.Location = new System.Drawing.Point(83, 141);
            this.fecha_inicio.Name = "fecha_inicio";
            this.fecha_inicio.Size = new System.Drawing.Size(103, 20);
            this.fecha_inicio.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Fecha Final";
            // 
            // fecha_final
            // 
            this.fecha_final.Location = new System.Drawing.Point(266, 141);
            this.fecha_final.Name = "fecha_final";
            this.fecha_final.Size = new System.Drawing.Size(103, 20);
            this.fecha_final.TabIndex = 60;
            // 
            // imprime_reporte
            // 
            this.imprime_reporte.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprime_reporte.Location = new System.Drawing.Point(12, 582);
            this.imprime_reporte.Name = "imprime_reporte";
            this.imprime_reporte.Size = new System.Drawing.Size(248, 43);
            this.imprime_reporte.TabIndex = 62;
            this.imprime_reporte.Text = "IMPRIMIR REPORTE";
            this.imprime_reporte.UseVisualStyleBackColor = true;
            this.imprime_reporte.Click += new System.EventHandler(this.imprime_reporte_Click);
            // 
            // horas_acumuladas
            // 
            this.horas_acumuladas.Location = new System.Drawing.Point(673, 108);
            this.horas_acumuladas.Name = "horas_acumuladas";
            this.horas_acumuladas.ReadOnly = true;
            this.horas_acumuladas.Size = new System.Drawing.Size(103, 20);
            this.horas_acumuladas.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(571, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Horas Acumuladas";
            // 
            // id_horas
            // 
            this.id_horas.Location = new System.Drawing.Point(644, 141);
            this.id_horas.Name = "id_horas";
            this.id_horas.ReadOnly = true;
            this.id_horas.Size = new System.Drawing.Size(132, 20);
            this.id_horas.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(588, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Id_Horas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 43);
            this.button1.TabIndex = 67;
            this.button1.Text = "Se Hizo Servicio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "dd-mm-aaaa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "dd-mm-aaaa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 70;
            this.label10.Text = "Notas";
            // 
            // notas
            // 
            this.notas.Location = new System.Drawing.Point(53, 194);
            this.notas.Multiline = true;
            this.notas.Name = "notas";
            this.notas.Size = new System.Drawing.Size(723, 120);
            this.notas.TabIndex = 71;
            // 
            // Horas_de_Maquinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 637);
            this.Controls.Add(this.notas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.id_horas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.horas_acumuladas);
            this.Controls.Add(this.imprime_reporte);
            this.Controls.Add(this.fecha_final);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fecha_inicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grid_horas_maquinaria);
            this.Controls.Add(this.boton_eliminar);
            this.Controls.Add(this.boton_modificar);
            this.Controls.Add(this.boton_agregar);
            this.Controls.Add(this.horas_totales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.horas_trabajadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre_maquina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.botonVolver);
            this.Name = "Horas_de_Maquinaria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Horas_de_Maquinaria_FormClosing);
            this.Load += new System.EventHandler(this.Horas_de_Maquinaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_horas_maquinaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nombre_maquina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox horas_trabajadas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox horas_totales;
        private System.Windows.Forms.Button boton_agregar;
        private System.Windows.Forms.Button boton_modificar;
        private System.Windows.Forms.Button boton_eliminar;
        private System.Windows.Forms.DataGridView grid_horas_maquinaria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fecha_inicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fecha_final;
        private System.Windows.Forms.Button imprime_reporte;
        private System.Windows.Forms.TextBox horas_acumuladas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox id_horas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox notas;
    }
}