namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Ejercicios
{
    partial class Ejercicio_07
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lis_Resultado = new System.Windows.Forms.ListBox();
            this.txt_palabra = new System.Windows.Forms.TextBox();
            this.lbl_ = new System.Windows.Forms.Label();
            this.btninformacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(210, 24);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(151, 25);
            this.lbl_Titulo.TabIndex = 30;
            this.lbl_Titulo.Text = "LA PALABRA";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(244, 184);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(128, 28);
            this.btn_Limpiar.TabIndex = 29;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(244, 143);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(128, 28);
            this.btn_Calcular.TabIndex = 28;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lis_Resultado
            // 
            this.lis_Resultado.FormattingEnabled = true;
            this.lis_Resultado.Location = new System.Drawing.Point(19, 129);
            this.lis_Resultado.Margin = new System.Windows.Forms.Padding(2);
            this.lis_Resultado.Name = "lis_Resultado";
            this.lis_Resultado.Size = new System.Drawing.Size(200, 108);
            this.lis_Resultado.TabIndex = 27;
            // 
            // txt_palabra
            // 
            this.txt_palabra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_palabra.Location = new System.Drawing.Point(250, 92);
            this.txt_palabra.Name = "txt_palabra";
            this.txt_palabra.Size = new System.Drawing.Size(124, 26);
            this.txt_palabra.TabIndex = 26;
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(64, 92);
            this.lbl_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(140, 20);
            this.lbl_.TabIndex = 25;
            this.lbl_.Text = "Ingrese la palabra ";
            // 
            // btninformacion
            // 
            this.btninformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninformacion.Location = new System.Drawing.Point(12, 12);
            this.btninformacion.Name = "btninformacion";
            this.btninformacion.Size = new System.Drawing.Size(152, 53);
            this.btninformacion.TabIndex = 24;
            this.btninformacion.Text = "Informacion del Ejercicio";
            this.btninformacion.UseVisualStyleBackColor = true;
            this.btninformacion.Click += new System.EventHandler(this.btninformacion_Click);
            // 
            // Ejercicio_07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 255);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.lis_Resultado);
            this.Controls.Add(this.txt_palabra);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.btninformacion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ejercicio_07";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.ListBox lis_Resultado;
        private System.Windows.Forms.TextBox txt_palabra;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Button btninformacion;
    }
}