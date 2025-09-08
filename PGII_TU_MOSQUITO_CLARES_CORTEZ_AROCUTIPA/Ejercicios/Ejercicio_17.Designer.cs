namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Ejercicios
{
    partial class Ejercicio_17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio_17));
            this.btninformacion = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_filas = new System.Windows.Forms.Label();
            this.txt_filas = new System.Windows.Forms.TextBox();
            this.lbl_columnas = new System.Windows.Forms.Label();
            this.txt_columnas = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lblnum = new System.Windows.Forms.Label();
            this.dgv_array = new System.Windows.Forms.DataGridView();
            this.btn_matriz = new System.Windows.Forms.Button();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_array)).BeginInit();
            this.SuspendLayout();
            // 
            // btninformacion
            // 
            this.btninformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninformacion.Location = new System.Drawing.Point(12, 12);
            this.btninformacion.Name = "btninformacion";
            this.btninformacion.Size = new System.Drawing.Size(152, 53);
            this.btninformacion.TabIndex = 5;
            this.btninformacion.Text = "Informacion del Ejercicio";
            this.btninformacion.UseVisualStyleBackColor = true;
            this.btninformacion.Click += new System.EventHandler(this.btninformacion_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(199, 24);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(373, 25);
            this.lbl_Titulo.TabIndex = 9;
            this.lbl_Titulo.Text = "BUSCAR NUMERO EN UN ARRAY";
            // 
            // lbl_filas
            // 
            this.lbl_filas.AutoSize = true;
            this.lbl_filas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filas.Location = new System.Drawing.Point(8, 37);
            this.lbl_filas.Name = "lbl_filas";
            this.lbl_filas.Size = new System.Drawing.Size(196, 20);
            this.lbl_filas.TabIndex = 10;
            this.lbl_filas.Text = "Ingresar el numero de filas";
            // 
            // txt_filas
            // 
            this.txt_filas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filas.Location = new System.Drawing.Point(250, 34);
            this.txt_filas.Name = "txt_filas";
            this.txt_filas.Size = new System.Drawing.Size(100, 26);
            this.txt_filas.TabIndex = 11;
            this.txt_filas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_filas_KeyPress);
            // 
            // lbl_columnas
            // 
            this.lbl_columnas.AutoSize = true;
            this.lbl_columnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_columnas.Location = new System.Drawing.Point(8, 69);
            this.lbl_columnas.Name = "lbl_columnas";
            this.lbl_columnas.Size = new System.Drawing.Size(236, 20);
            this.lbl_columnas.TabIndex = 12;
            this.lbl_columnas.Text = "Ingresar el numero de columnas";
            // 
            // txt_columnas
            // 
            this.txt_columnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_columnas.Location = new System.Drawing.Point(250, 66);
            this.txt_columnas.Name = "txt_columnas";
            this.txt_columnas.Size = new System.Drawing.Size(100, 26);
            this.txt_columnas.TabIndex = 13;
            this.txt_columnas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_columnas_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_filas);
            this.groupBox1.Controls.Add(this.txt_columnas);
            this.groupBox1.Controls.Add(this.lbl_filas);
            this.groupBox1.Controls.Add(this.lbl_columnas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 119);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Informacion";
            // 
            // txt_numero
            // 
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(288, 260);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 26);
            this.txt_numero.TabIndex = 15;
            this.txt_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero_KeyPress);
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.Location = new System.Drawing.Point(46, 263);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(230, 20);
            this.lblnum.TabIndex = 14;
            this.lblnum.Text = "Ingresar el numero para buscar";
            // 
            // dgv_array
            // 
            this.dgv_array.AllowUserToAddRows = false;
            this.dgv_array.AllowUserToDeleteRows = false;
            this.dgv_array.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_array.Location = new System.Drawing.Point(411, 68);
            this.dgv_array.Name = "dgv_array";
            this.dgv_array.ReadOnly = true;
            this.dgv_array.Size = new System.Drawing.Size(347, 184);
            this.dgv_array.TabIndex = 16;
            // 
            // btn_matriz
            // 
            this.btn_matriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_matriz.Location = new System.Drawing.Point(12, 224);
            this.btn_matriz.Name = "btn_matriz";
            this.btn_matriz.Size = new System.Drawing.Size(128, 28);
            this.btn_matriz.TabIndex = 17;
            this.btn_matriz.Text = "Crear Matriz";
            this.btn_matriz.UseVisualStyleBackColor = true;
            this.btn_matriz.Click += new System.EventHandler(this.btn_matriz_Click);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mostrar.Location = new System.Drawing.Point(250, 224);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(128, 28);
            this.btn_Mostrar.TabIndex = 18;
            this.btn_Mostrar.Text = "Mostrar Matriz";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Location = new System.Drawing.Point(411, 258);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(128, 28);
            this.btn_Buscar.TabIndex = 19;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.Location = new System.Drawing.Point(630, 258);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(128, 28);
            this.btn_Nuevo.TabIndex = 20;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // Ejercicio_17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 308);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.btn_matriz);
            this.Controls.Add(this.dgv_array);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btninformacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ejercicio_17";
            this.Text = "Ejercicio_17";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_array)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninformacion;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_filas;
        private System.Windows.Forms.TextBox txt_filas;
        private System.Windows.Forms.Label lbl_columnas;
        private System.Windows.Forms.TextBox txt_columnas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.DataGridView dgv_array;
        private System.Windows.Forms.Button btn_matriz;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Nuevo;
    }
}