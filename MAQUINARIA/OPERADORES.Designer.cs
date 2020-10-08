namespace MAQUINARIA
{
    partial class OPERADORES
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
            this.label12 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.telefono = new System.Windows.Forms.TextBox();
            this.nombre_operador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boton_eliminar = new System.Windows.Forms.Button();
            this.boton_modificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grid_operadores = new System.Windows.Forms.DataGridView();
            this.Imprimir_Reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_operadores)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label12.Location = new System.Drawing.Point(200, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(209, 33);
            this.label12.TabIndex = 34;
            this.label12.Text = "MENU DE OPERADORES";
            // 
            // botonVolver
            // 
            this.botonVolver.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.Location = new System.Drawing.Point(12, 12);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(70, 61);
            this.botonVolver.TabIndex = 33;
            this.botonVolver.Text = "ATRAS";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(470, 113);
            this.telefono.MaxLength = 10;
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(118, 20);
            this.telefono.TabIndex = 50;
            this.telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefono_KeyPress);
            // 
            // nombre_operador
            // 
            this.nombre_operador.Location = new System.Drawing.Point(129, 113);
            this.nombre_operador.Name = "nombre_operador";
            this.nombre_operador.Size = new System.Drawing.Size(277, 20);
            this.nombre_operador.TabIndex = 49;
            this.nombre_operador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_operador_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nombre del Operador:";
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_eliminar.Location = new System.Drawing.Point(402, 158);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(186, 44);
            this.boton_eliminar.TabIndex = 57;
            this.boton_eliminar.Text = "ELIMINAR -";
            this.boton_eliminar.UseVisualStyleBackColor = true;
            this.boton_eliminar.Click += new System.EventHandler(this.boton_eliminar_Click);
            // 
            // boton_modificar
            // 
            this.boton_modificar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_modificar.Location = new System.Drawing.Point(214, 158);
            this.boton_modificar.Name = "boton_modificar";
            this.boton_modificar.Size = new System.Drawing.Size(182, 44);
            this.boton_modificar.TabIndex = 56;
            this.boton_modificar.Text = "MODIFICAR ?";
            this.boton_modificar.UseVisualStyleBackColor = true;
            this.boton_modificar.Click += new System.EventHandler(this.boton_modificar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 44);
            this.button1.TabIndex = 55;
            this.button1.Text = "AGREGAR +";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grid_operadores
            // 
            this.grid_operadores.AllowUserToAddRows = false;
            this.grid_operadores.AllowUserToDeleteRows = false;
            this.grid_operadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_operadores.Location = new System.Drawing.Point(26, 208);
            this.grid_operadores.Name = "grid_operadores";
            this.grid_operadores.Size = new System.Drawing.Size(562, 147);
            this.grid_operadores.TabIndex = 58;
            this.grid_operadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_operadores_CellClick);
            // 
            // Imprimir_Reporte
            // 
            this.Imprimir_Reporte.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimir_Reporte.Location = new System.Drawing.Point(26, 379);
            this.Imprimir_Reporte.Name = "Imprimir_Reporte";
            this.Imprimir_Reporte.Size = new System.Drawing.Size(248, 43);
            this.Imprimir_Reporte.TabIndex = 74;
            this.Imprimir_Reporte.Text = "IMPRIMIR REPORTE";
            this.Imprimir_Reporte.UseVisualStyleBackColor = true;
            this.Imprimir_Reporte.Click += new System.EventHandler(this.Imprimir_Reporte_Click);
            // 
            // OPERADORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 434);
            this.Controls.Add(this.Imprimir_Reporte);
            this.Controls.Add(this.grid_operadores);
            this.Controls.Add(this.boton_eliminar);
            this.Controls.Add(this.boton_modificar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.nombre_operador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.botonVolver);
            this.Name = "OPERADORES";
            this.Text = "OPERADORES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OPERADORES_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grid_operadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox nombre_operador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boton_eliminar;
        private System.Windows.Forms.Button boton_modificar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grid_operadores;
        private System.Windows.Forms.Button Imprimir_Reporte;
    }
}