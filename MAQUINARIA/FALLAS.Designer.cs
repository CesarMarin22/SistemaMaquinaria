namespace MAQUINARIA
{
    partial class FALLAS
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
            this.id_falla = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.nombre_maquina = new System.Windows.Forms.ComboBox();
            this.sistema_afectado = new System.Windows.Forms.ComboBox();
            this.grid_fallas = new System.Windows.Forms.DataGridView();
            this.boton_agregar = new System.Windows.Forms.Button();
            this.boton_modifcar = new System.Windows.Forms.Button();
            this.boton_eliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Imprimir_Reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_fallas)).BeginInit();
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
            this.label12.Location = new System.Drawing.Point(352, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(236, 33);
            this.label12.TabIndex = 33;
            this.label12.Text = "MENU DE MANTENIMIENTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "N°:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre de la Maquina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Sistema Afectado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Descripción:";
            // 
            // id_falla
            // 
            this.id_falla.Location = new System.Drawing.Point(40, 107);
            this.id_falla.Name = "id_falla";
            this.id_falla.ReadOnly = true;
            this.id_falla.Size = new System.Drawing.Size(125, 20);
            this.id_falla.TabIndex = 39;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(55, 180);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(107, 20);
            this.fecha.TabIndex = 40;
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(255, 154);
            this.Descripcion.Multiline = true;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(592, 71);
            this.Descripcion.TabIndex = 41;
            this.Descripcion.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // nombre_maquina
            // 
            this.nombre_maquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nombre_maquina.FormattingEnabled = true;
            this.nombre_maquina.Location = new System.Drawing.Point(294, 107);
            this.nombre_maquina.Name = "nombre_maquina";
            this.nombre_maquina.Size = new System.Drawing.Size(210, 21);
            this.nombre_maquina.TabIndex = 44;
            // 
            // sistema_afectado
            // 
            this.sistema_afectado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sistema_afectado.FormattingEnabled = true;
            this.sistema_afectado.Location = new System.Drawing.Point(606, 106);
            this.sistema_afectado.Name = "sistema_afectado";
            this.sistema_afectado.Size = new System.Drawing.Size(241, 21);
            this.sistema_afectado.TabIndex = 45;
            // 
            // grid_fallas
            // 
            this.grid_fallas.AllowUserToAddRows = false;
            this.grid_fallas.AllowUserToDeleteRows = false;
            this.grid_fallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_fallas.Location = new System.Drawing.Point(15, 288);
            this.grid_fallas.MultiSelect = false;
            this.grid_fallas.Name = "grid_fallas";
            this.grid_fallas.ReadOnly = true;
            this.grid_fallas.Size = new System.Drawing.Size(832, 150);
            this.grid_fallas.TabIndex = 46;
            this.grid_fallas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_fallas_CellClick);
            // 
            // boton_agregar
            // 
            this.boton_agregar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_agregar.Location = new System.Drawing.Point(12, 231);
            this.boton_agregar.Name = "boton_agregar";
            this.boton_agregar.Size = new System.Drawing.Size(276, 43);
            this.boton_agregar.TabIndex = 57;
            this.boton_agregar.Text = "AGREGAR +";
            this.boton_agregar.UseVisualStyleBackColor = true;
            this.boton_agregar.Click += new System.EventHandler(this.boton_agregar_Click);
            // 
            // boton_modifcar
            // 
            this.boton_modifcar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_modifcar.Location = new System.Drawing.Point(294, 231);
            this.boton_modifcar.Name = "boton_modifcar";
            this.boton_modifcar.Size = new System.Drawing.Size(269, 43);
            this.boton_modifcar.TabIndex = 58;
            this.boton_modifcar.Text = "MODIFICAR ?";
            this.boton_modifcar.UseVisualStyleBackColor = true;
            this.boton_modifcar.Click += new System.EventHandler(this.boton_modifcar_Click);
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_eliminar.Location = new System.Drawing.Point(569, 231);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(278, 43);
            this.boton_eliminar.TabIndex = 59;
            this.boton_eliminar.Text = "ELIMINAR -";
            this.boton_eliminar.UseVisualStyleBackColor = true;
            this.boton_eliminar.Click += new System.EventHandler(this.boton_eliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "formato de fecha dd-mm-aaaa";
            // 
            // Imprimir_Reporte
            // 
            this.Imprimir_Reporte.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimir_Reporte.Location = new System.Drawing.Point(15, 460);
            this.Imprimir_Reporte.Name = "Imprimir_Reporte";
            this.Imprimir_Reporte.Size = new System.Drawing.Size(248, 43);
            this.Imprimir_Reporte.TabIndex = 74;
            this.Imprimir_Reporte.Text = "IMPRIMIR REPORTE";
            this.Imprimir_Reporte.UseVisualStyleBackColor = true;
            this.Imprimir_Reporte.Click += new System.EventHandler(this.Imprimir_Reporte_Click);
            // 
            // FALLAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 515);
            this.Controls.Add(this.Imprimir_Reporte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boton_eliminar);
            this.Controls.Add(this.boton_modifcar);
            this.Controls.Add(this.boton_agregar);
            this.Controls.Add(this.grid_fallas);
            this.Controls.Add(this.sistema_afectado);
            this.Controls.Add(this.nombre_maquina);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.id_falla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.botonVolver);
            this.Name = "FALLAS";
            this.Text = "FALLAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FALLAS_FormClosing);
            this.Load += new System.EventHandler(this.FALLAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_fallas)).EndInit();
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
        private System.Windows.Forms.TextBox id_falla;
        private System.Windows.Forms.TextBox fecha;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.ComboBox nombre_maquina;
        private System.Windows.Forms.ComboBox sistema_afectado;
        private System.Windows.Forms.DataGridView grid_fallas;
        private System.Windows.Forms.Button boton_agregar;
        private System.Windows.Forms.Button boton_modifcar;
        private System.Windows.Forms.Button boton_eliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Imprimir_Reporte;
    }
}