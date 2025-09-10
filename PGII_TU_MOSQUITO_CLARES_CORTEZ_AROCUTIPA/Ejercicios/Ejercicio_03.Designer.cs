namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Ejercicios
{
    partial class Ejercicio_03
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
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.numEstudiantes = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEjercicio1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstudiantes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(627, 41);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(268, 222);
            this.txtResultados.TabIndex = 66;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(515, 158);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 65;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dgvNotas
            // 
            this.dgvNotas.AllowUserToAddRows = false;
            this.dgvNotas.AllowUserToDeleteRows = false;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Location = new System.Drawing.Point(215, 288);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.ReadOnly = true;
            this.dgvNotas.Size = new System.Drawing.Size(596, 150);
            this.dgvNotas.TabIndex = 64;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(389, 158);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 63;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // numEstudiantes
            // 
            this.numEstudiantes.Location = new System.Drawing.Point(430, 87);
            this.numEstudiantes.Name = "numEstudiantes";
            this.numEstudiantes.Size = new System.Drawing.Size(120, 20);
            this.numEstudiantes.TabIndex = 62;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnEjercicio1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 61;
            // 
            // btnEjercicio1
            // 
            this.btnEjercicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjercicio1.Location = new System.Drawing.Point(22, 23);
            this.btnEjercicio1.Name = "btnEjercicio1";
            this.btnEjercicio1.Size = new System.Drawing.Size(152, 53);
            this.btnEjercicio1.TabIndex = 19;
            this.btnEjercicio1.Text = "Informacion del Ejercicio";
            this.btnEjercicio1.UseVisualStyleBackColor = true;
            this.btnEjercicio1.Click += new System.EventHandler(this.btnEjercicio1_Click);
            // 
            // Ejercicio_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvNotas);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.numEstudiantes);
            this.Controls.Add(this.panel1);
            this.Name = "Ejercicio_03";
            this.Text = "Ejercicio_03";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstudiantes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.NumericUpDown numEstudiantes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEjercicio1;
    }
}