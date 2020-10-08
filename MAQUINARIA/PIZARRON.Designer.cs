namespace MAQUINARIA
{
    partial class PIZARRON
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
            this.grid_pizarron = new System.Windows.Forms.DataGridView();
            this.boton_pizarron = new System.Windows.Forms.Button();
            this.categoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pizarron)).BeginInit();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.Location = new System.Drawing.Point(12, 12);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(70, 61);
            this.botonVolver.TabIndex = 32;
            this.botonVolver.Text = "ATRAS";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label12.Location = new System.Drawing.Point(298, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 58);
            this.label12.TabIndex = 33;
            this.label12.Text = "PIZARRÓN";
            // 
            // grid_pizarron
            // 
            this.grid_pizarron.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_pizarron.Location = new System.Drawing.Point(12, 108);
            this.grid_pizarron.Name = "grid_pizarron";
            this.grid_pizarron.Size = new System.Drawing.Size(870, 519);
            this.grid_pizarron.TabIndex = 34;
            // 
            // boton_pizarron
            // 
            this.boton_pizarron.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_pizarron.Location = new System.Drawing.Point(673, 21);
            this.boton_pizarron.Name = "boton_pizarron";
            this.boton_pizarron.Size = new System.Drawing.Size(209, 52);
            this.boton_pizarron.TabIndex = 35;
            this.boton_pizarron.Text = "GENERAR PIZARRÓN";
            this.boton_pizarron.UseVisualStyleBackColor = true;
            this.boton_pizarron.Click += new System.EventHandler(this.boton_pizarron_Click);
            // 
            // categoria
            // 
            this.categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoria.FormattingEnabled = true;
            this.categoria.Location = new System.Drawing.Point(44, 646);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(121, 21);
            this.categoria.TabIndex = 36;
            // 
            // PIZARRON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 688);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.boton_pizarron);
            this.Controls.Add(this.grid_pizarron);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.botonVolver);
            this.Name = "PIZARRON";
            this.Text = "PIZARRON";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PIZARRON_FormClosing);
            this.Load += new System.EventHandler(this.PIZARRON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_pizarron)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView grid_pizarron;
        private System.Windows.Forms.Button boton_pizarron;
        private System.Windows.Forms.ComboBox categoria;
    }
}