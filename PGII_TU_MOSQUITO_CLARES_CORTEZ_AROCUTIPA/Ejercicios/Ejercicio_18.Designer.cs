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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio_18));
            this.btninformacion = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.grb_Estudiante = new System.Windows.Forms.GroupBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.txt_Nombres = new System.Windows.Forms.TextBox();
            this.lst_Cursos = new System.Windows.Forms.ListBox();
            this.lbl_Disponible = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Quitar = new System.Windows.Forms.Button();
            this.lst_Cursos_Matricula = new System.Windows.Forms.ListBox();
            this.lbl_Matricula = new System.Windows.Forms.Label();
            this.lbl_Monto = new System.Windows.Forms.Label();
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.btn_Generar_Matricula = new System.Windows.Forms.Button();
            this.lbl_Credito = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Cursos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Creditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_Estudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.Location = new System.Drawing.Point(13, 44);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(73, 20);
            this.lbl_Nombres.TabIndex = 11;
            this.lbl_Nombres.Text = "Nombres";
            // 
            // grb_Estudiante
            // 
            this.grb_Estudiante.Controls.Add(this.txt_Codigo);
            this.grb_Estudiante.Controls.Add(this.lbl_Codigo);
            this.grb_Estudiante.Controls.Add(this.lbl_Apellidos);
            this.grb_Estudiante.Controls.Add(this.txt_Apellidos);
            this.grb_Estudiante.Controls.Add(this.txt_Nombres);
            this.grb_Estudiante.Controls.Add(this.lbl_Nombres);
            this.grb_Estudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Estudiante.Location = new System.Drawing.Point(13, 81);
            this.grb_Estudiante.Name = "grb_Estudiante";
            this.grb_Estudiante.Size = new System.Drawing.Size(243, 167);
            this.grb_Estudiante.TabIndex = 12;
            this.grb_Estudiante.TabStop = false;
            this.grb_Estudiante.Text = "Informacion del Estudiante";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(102, 114);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(130, 26);
            this.txt_Codigo.TabIndex = 16;
            this.txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Codigo_KeyPress);
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(13, 117);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(59, 20);
            this.lbl_Codigo.TabIndex = 15;
            this.lbl_Codigo.Text = "Codigo";
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Location = new System.Drawing.Point(13, 81);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(73, 20);
            this.lbl_Apellidos.TabIndex = 14;
            this.lbl_Apellidos.Text = "Apellidos";
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Location = new System.Drawing.Point(102, 75);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(130, 26);
            this.txt_Apellidos.TabIndex = 13;
            this.txt_Apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Apellidos_KeyPress);
            // 
            // txt_Nombres
            // 
            this.txt_Nombres.Location = new System.Drawing.Point(102, 43);
            this.txt_Nombres.Name = "txt_Nombres";
            this.txt_Nombres.Size = new System.Drawing.Size(130, 26);
            this.txt_Nombres.TabIndex = 12;
            this.txt_Nombres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Nombres_KeyDown);
            this.txt_Nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombres_KeyPress);
            // 
            // lst_Cursos
            // 
            this.lst_Cursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Cursos.FormattingEnabled = true;
            this.lst_Cursos.ItemHeight = 20;
            this.lst_Cursos.Location = new System.Drawing.Point(282, 104);
            this.lst_Cursos.Name = "lst_Cursos";
            this.lst_Cursos.Size = new System.Drawing.Size(138, 144);
            this.lst_Cursos.TabIndex = 13;
            // 
            // lbl_Disponible
            // 
            this.lbl_Disponible.AutoSize = true;
            this.lbl_Disponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Disponible.Location = new System.Drawing.Point(278, 81);
            this.lbl_Disponible.Name = "lbl_Disponible";
            this.lbl_Disponible.Size = new System.Drawing.Size(142, 20);
            this.lbl_Disponible.TabIndex = 17;
            this.lbl_Disponible.Text = "Cursos disponibles";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(426, 138);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 37);
            this.btn_Agregar.TabIndex = 18;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Quitar
            // 
            this.btn_Quitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitar.Location = new System.Drawing.Point(426, 181);
            this.btn_Quitar.Name = "btn_Quitar";
            this.btn_Quitar.Size = new System.Drawing.Size(75, 37);
            this.btn_Quitar.TabIndex = 19;
            this.btn_Quitar.Text = "Quitar";
            this.btn_Quitar.UseVisualStyleBackColor = true;
            this.btn_Quitar.Click += new System.EventHandler(this.btn_Quitar_Click);
            // 
            // lst_Cursos_Matricula
            // 
            this.lst_Cursos_Matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Cursos_Matricula.FormattingEnabled = true;
            this.lst_Cursos_Matricula.ItemHeight = 20;
            this.lst_Cursos_Matricula.Location = new System.Drawing.Point(507, 104);
            this.lst_Cursos_Matricula.Name = "lst_Cursos_Matricula";
            this.lst_Cursos_Matricula.Size = new System.Drawing.Size(138, 144);
            this.lst_Cursos_Matricula.TabIndex = 20;
            // 
            // lbl_Matricula
            // 
            this.lbl_Matricula.AutoSize = true;
            this.lbl_Matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Matricula.Location = new System.Drawing.Point(503, 81);
            this.lbl_Matricula.Name = "lbl_Matricula";
            this.lbl_Matricula.Size = new System.Drawing.Size(145, 20);
            this.lbl_Matricula.TabIndex = 21;
            this.lbl_Matricula.Text = "Cursos a Matricular";
            // 
            // lbl_Monto
            // 
            this.lbl_Monto.AutoSize = true;
            this.lbl_Monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Monto.Location = new System.Drawing.Point(26, 254);
            this.lbl_Monto.Name = "lbl_Monto";
            this.lbl_Monto.Size = new System.Drawing.Size(112, 20);
            this.lbl_Monto.TabIndex = 22;
            this.lbl_Monto.Text = "Monto a pagar";
            // 
            // txt_Monto
            // 
            this.txt_Monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Monto.Location = new System.Drawing.Point(144, 251);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.ReadOnly = true;
            this.txt_Monto.Size = new System.Drawing.Size(101, 26);
            this.txt_Monto.TabIndex = 17;
            // 
            // btn_Generar_Matricula
            // 
            this.btn_Generar_Matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generar_Matricula.Location = new System.Drawing.Point(360, 254);
            this.btn_Generar_Matricula.Name = "btn_Generar_Matricula";
            this.btn_Generar_Matricula.Size = new System.Drawing.Size(219, 37);
            this.btn_Generar_Matricula.TabIndex = 23;
            this.btn_Generar_Matricula.Text = "Generar matricula";
            this.btn_Generar_Matricula.UseVisualStyleBackColor = true;
            this.btn_Generar_Matricula.Click += new System.EventHandler(this.btn_Generar_Matricula_Click);
            // 
            // lbl_Credito
            // 
            this.lbl_Credito.AutoSize = true;
            this.lbl_Credito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Credito.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_Credito.Location = new System.Drawing.Point(12, 289);
            this.lbl_Credito.Name = "lbl_Credito";
            this.lbl_Credito.Size = new System.Drawing.Size(182, 20);
            this.lbl_Credito.TabIndex = 24;
            this.lbl_Credito.Text = "1 Credito = 100 Soles";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_codigo,
            this.col_Cursos,
            this.col_Creditos});
            this.dataGridView1.Location = new System.Drawing.Point(12, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(541, 150);
            this.dataGridView1.TabIndex = 25;
            // 
            // col_codigo
            // 
            this.col_codigo.HeaderText = "Codigo";
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.ReadOnly = true;
            // 
            // col_Cursos
            // 
            this.col_Cursos.HeaderText = "Cursos";
            this.col_Cursos.Name = "col_Cursos";
            this.col_Cursos.ReadOnly = true;
            // 
            // col_Creditos
            // 
            this.col_Creditos.HeaderText = "Creditos";
            this.col_Creditos.Name = "col_Creditos";
            this.col_Creditos.ReadOnly = true;
            // 
            // Ejercicio_18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 524);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Credito);
            this.Controls.Add(this.btn_Generar_Matricula);
            this.Controls.Add(this.txt_Monto);
            this.Controls.Add(this.lbl_Monto);
            this.Controls.Add(this.lbl_Matricula);
            this.Controls.Add(this.lst_Cursos_Matricula);
            this.Controls.Add(this.btn_Quitar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_Disponible);
            this.Controls.Add(this.lst_Cursos);
            this.Controls.Add(this.grb_Estudiante);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btninformacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ejercicio_18";
            this.Text = "Ejercicio_18";
            this.grb_Estudiante.ResumeLayout(false);
            this.grb_Estudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninformacion;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Nombres;
        private System.Windows.Forms.GroupBox grb_Estudiante;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.TextBox txt_Nombres;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.ListBox lst_Cursos;
        private System.Windows.Forms.Label lbl_Disponible;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Quitar;
        private System.Windows.Forms.ListBox lst_Cursos_Matricula;
        private System.Windows.Forms.Label lbl_Matricula;
        private System.Windows.Forms.Label lbl_Monto;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.Button btn_Generar_Matricula;
        private System.Windows.Forms.Label lbl_Credito;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Cursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Creditos;
    }
}