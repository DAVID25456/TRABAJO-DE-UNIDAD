namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Ejercicios
{
    partial class Ejercicio_15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio_15));
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btninformacion = new System.Windows.Forms.Button();
            this.txt_Texto = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lsb_ocurrencias = new System.Windows.Forms.ListBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.txtpalabra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Location = new System.Drawing.Point(330, 80);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 36);
            this.btn_Buscar.TabIndex = 0;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btninformacion
            // 
            this.btninformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninformacion.Location = new System.Drawing.Point(12, 12);
            this.btninformacion.Name = "btninformacion";
            this.btninformacion.Size = new System.Drawing.Size(152, 53);
            this.btninformacion.TabIndex = 3;
            this.btninformacion.Text = "Informacion del Ejercicio";
            this.btninformacion.UseVisualStyleBackColor = true;
            this.btninformacion.Click += new System.EventHandler(this.btninformacion_Click);
            // 
            // txt_Texto
            // 
            this.txt_Texto.Location = new System.Drawing.Point(14, 119);
            this.txt_Texto.Multiline = true;
            this.txt_Texto.Name = "txt_Texto";
            this.txt_Texto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Texto.Size = new System.Drawing.Size(189, 212);
            this.txt_Texto.TabIndex = 4;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(84, 88);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(48, 20);
            this.lblTexto.TabIndex = 5;
            this.lblTexto.Text = "Texto";
            // 
            // lsb_ocurrencias
            // 
            this.lsb_ocurrencias.FormattingEnabled = true;
            this.lsb_ocurrencias.HorizontalScrollbar = true;
            this.lsb_ocurrencias.Location = new System.Drawing.Point(222, 119);
            this.lsb_ocurrencias.Name = "lsb_ocurrencias";
            this.lsb_ocurrencias.Size = new System.Drawing.Size(183, 212);
            this.lsb_ocurrencias.TabIndex = 6;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(180, 26);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(216, 25);
            this.lbl_Titulo.TabIndex = 8;
            this.lbl_Titulo.Text = "BUSCAR PALBRAS";
            // 
            // txtpalabra
            // 
            this.txtpalabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpalabra.Location = new System.Drawing.Point(222, 85);
            this.txtpalabra.Name = "txtpalabra";
            this.txtpalabra.Size = new System.Drawing.Size(100, 26);
            this.txtpalabra.TabIndex = 9;
            // 
            // Ejercicio_15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 354);
            this.Controls.Add(this.txtpalabra);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.lsb_ocurrencias);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.txt_Texto);
            this.Controls.Add(this.btninformacion);
            this.Controls.Add(this.btn_Buscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ejercicio_15";
            this.Text = "Ejercicio_15";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btninformacion;
        private System.Windows.Forms.TextBox txt_Texto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.ListBox lsb_ocurrencias;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txtpalabra;
    }
}