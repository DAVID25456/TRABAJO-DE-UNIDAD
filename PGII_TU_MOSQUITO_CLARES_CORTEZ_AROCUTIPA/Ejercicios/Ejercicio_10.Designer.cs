namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Ejercicios
{
    partial class Ejercicio_10
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
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lis_Resultado = new System.Windows.Forms.ListBox();
            this.DATOS = new System.Windows.Forms.DataGridView();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_NombreTrabajador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_HorasTrabajadas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btninformacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DATOS)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(395, 325);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(128, 28);
            this.btn_Limpiar.TabIndex = 46;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(219, 325);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(128, 28);
            this.btn_Calcular.TabIndex = 45;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lis_Resultado
            // 
            this.lis_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lis_Resultado.FormattingEnabled = true;
            this.lis_Resultado.ItemHeight = 20;
            this.lis_Resultado.Location = new System.Drawing.Point(424, 133);
            this.lis_Resultado.Margin = new System.Windows.Forms.Padding(2);
            this.lis_Resultado.Name = "lis_Resultado";
            this.lis_Resultado.Size = new System.Drawing.Size(288, 164);
            this.lis_Resultado.TabIndex = 44;
            // 
            // DATOS
            // 
            this.DATOS.AllowUserToAddRows = false;
            this.DATOS.AllowUserToDeleteRows = false;
            this.DATOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE,
            this.HORAS,
            this.PAGO});
            this.DATOS.Location = new System.Drawing.Point(22, 133);
            this.DATOS.Margin = new System.Windows.Forms.Padding(2);
            this.DATOS.Name = "DATOS";
            this.DATOS.ReadOnly = true;
            this.DATOS.RowHeadersWidth = 51;
            this.DATOS.RowTemplate.Height = 24;
            this.DATOS.Size = new System.Drawing.Size(378, 166);
            this.DATOS.TabIndex = 41;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.MinimumWidth = 6;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Width = 125;
            // 
            // HORAS
            // 
            this.HORAS.HeaderText = "HORAS";
            this.HORAS.MinimumWidth = 6;
            this.HORAS.Name = "HORAS";
            this.HORAS.ReadOnly = true;
            this.HORAS.Width = 125;
            // 
            // PAGO
            // 
            this.PAGO.HeaderText = "PAGO";
            this.PAGO.MinimumWidth = 6;
            this.PAGO.Name = "PAGO";
            this.PAGO.ReadOnly = true;
            this.PAGO.Width = 125;
            // 
            // txt_NombreTrabajador
            // 
            this.txt_NombreTrabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreTrabajador.Location = new System.Drawing.Point(179, 85);
            this.txt_NombreTrabajador.Name = "txt_NombreTrabajador";
            this.txt_NombreTrabajador.Size = new System.Drawing.Size(124, 26);
            this.txt_NombreTrabajador.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nombre Trabajador";
            // 
            // txt_HorasTrabajadas
            // 
            this.txt_HorasTrabajadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HorasTrabajadas.Location = new System.Drawing.Point(564, 85);
            this.txt_HorasTrabajadas.Name = "txt_HorasTrabajadas";
            this.txt_HorasTrabajadas.Size = new System.Drawing.Size(124, 26);
            this.txt_HorasTrabajadas.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Horas Trabajadas";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(203, 24);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(347, 25);
            this.lbl_Titulo.TabIndex = 38;
            this.lbl_Titulo.Text = "PAGOS PARA TRABAJADORES";
            // 
            // btninformacion
            // 
            this.btninformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninformacion.Location = new System.Drawing.Point(12, 12);
            this.btninformacion.Name = "btninformacion";
            this.btninformacion.Size = new System.Drawing.Size(152, 53);
            this.btninformacion.TabIndex = 37;
            this.btninformacion.Text = "Informacion del Ejercicio";
            this.btninformacion.UseVisualStyleBackColor = true;
            this.btninformacion.Click += new System.EventHandler(this.btninformacion_Click);
            // 
            // Ejercicio_10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 376);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.lis_Resultado);
            this.Controls.Add(this.DATOS);
            this.Controls.Add(this.txt_NombreTrabajador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_HorasTrabajadas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btninformacion);
            this.Name = "Ejercicio_10";
            this.Text = "Ejercicio_10";
            ((System.ComponentModel.ISupportInitialize)(this.DATOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.ListBox lis_Resultado;
        private System.Windows.Forms.DataGridView DATOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAGO;
        private System.Windows.Forms.TextBox txt_NombreTrabajador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_HorasTrabajadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btninformacion;
    }
}