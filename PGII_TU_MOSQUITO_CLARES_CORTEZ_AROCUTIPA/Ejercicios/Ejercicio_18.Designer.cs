namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Ejercicios
{
    partial class Ejercicio_18
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
            this.btninformacion = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lblnombres = new System.Windows.Forms.Label();
            this.grb_Estudiante = new System.Windows.Forms.GroupBox();
            this.txt_Nombres = new System.Windows.Forms.TextBox();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.grb_Estudiante.SuspendLayout();
            this.SuspendLayout();
            // 
            // btninformacion
            // 
            this.btninformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninformacion.Location = new System.Drawing.Point(12, 12);
            this.btninformacion.Name = "btninformacion";
            this.btninformacion.Size = new System.Drawing.Size(152, 53);
            this.btninformacion.TabIndex = 6;
            this.btninformacion.Text = "Informacion del Ejercicio";
            this.btninformacion.UseVisualStyleBackColor = true;
            this.btninformacion.Click += new System.EventHandler(this.btninformacion_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(233, 24);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(303, 25);
            this.lbl_Titulo.TabIndex = 10;
            this.lbl_Titulo.Text = "REGISTRO DE MATRICULA";
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.Location = new System.Drawing.Point(16, 35);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(73, 20);
            this.lblnombres.TabIndex = 11;
            this.lblnombres.Text = "Nombres";
            // 
            // grb_Estudiante
            // 
            this.grb_Estudiante.Controls.Add(this.txt_Codigo);
            this.grb_Estudiante.Controls.Add(this.lbl_Codigo);
            this.grb_Estudiante.Controls.Add(this.lbl_Apellidos);
            this.grb_Estudiante.Controls.Add(this.txt_Apellidos);
            this.grb_Estudiante.Controls.Add(this.txt_Nombres);
            this.grb_Estudiante.Controls.Add(this.lblnombres);
            this.grb_Estudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Estudiante.Location = new System.Drawing.Point(13, 81);
            this.grb_Estudiante.Name = "grb_Estudiante";
            this.grb_Estudiante.Size = new System.Drawing.Size(243, 158);
            this.grb_Estudiante.TabIndex = 12;
            this.grb_Estudiante.TabStop = false;
            this.grb_Estudiante.Text = "Informacion del Estudiante";
            // 
            // txt_Nombres
            // 
            this.txt_Nombres.Location = new System.Drawing.Point(105, 34);
            this.txt_Nombres.Name = "txt_Nombres";
            this.txt_Nombres.Size = new System.Drawing.Size(100, 26);
            this.txt_Nombres.TabIndex = 12;
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Location = new System.Drawing.Point(105, 66);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(100, 26);
            this.txt_Apellidos.TabIndex = 13;
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Location = new System.Drawing.Point(16, 72);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(73, 20);
            this.lbl_Apellidos.TabIndex = 14;
            this.lbl_Apellidos.Text = "Apellidos";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(16, 108);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(59, 20);
            this.lbl_Codigo.TabIndex = 15;
            this.lbl_Codigo.Text = "Codigo";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(105, 105);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 26);
            this.txt_Codigo.TabIndex = 16;
            // 
            // Ejercicio_18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grb_Estudiante);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btninformacion);
            this.Name = "Ejercicio_18";
            this.Text = "Ejercicio_18";
            this.grb_Estudiante.ResumeLayout(false);
            this.grb_Estudiante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninformacion;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.GroupBox grb_Estudiante;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.TextBox txt_Nombres;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label lbl_Codigo;
    }
}