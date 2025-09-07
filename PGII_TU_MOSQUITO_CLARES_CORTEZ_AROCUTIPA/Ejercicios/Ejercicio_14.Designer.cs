namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Ejercicios
{
    partial class Ejercicio_14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio_14));
            this.btninformacion = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grb_Posicion_Jugador = new System.Windows.Forms.GroupBox();
            this.rdb_Delantero = new System.Windows.Forms.RadioButton();
            this.rdb_Medio = new System.Windows.Forms.RadioButton();
            this.rdb_Defensa = new System.Windows.Forms.RadioButton();
            this.rdb_portero = new System.Windows.Forms.RadioButton();
            this.grb_Datos_Jugador = new System.Windows.Forms.GroupBox();
            this.txt_Goles = new System.Windows.Forms.TextBox();
            this.txt_Min = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Goles = new System.Windows.Forms.Label();
            this.lbl_Min_Jugadores = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txt__Num_Uniforme = new System.Windows.Forms.TextBox();
            this.lbl_num_Uniforme = new System.Windows.Forms.Label();
            this.btn_Capturar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.dgv_Jugadores = new System.Windows.Forms.DataGridView();
            this.col_Num_Uniforme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Minutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Goles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_num_jugadores = new System.Windows.Forms.TextBox();
            this.lbl_num_jugadores = new System.Windows.Forms.Label();
            this.grb_Posicion_Jugador.SuspendLayout();
            this.grb_Datos_Jugador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Jugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btninformacion
            // 
            this.btninformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninformacion.Location = new System.Drawing.Point(12, 12);
            this.btninformacion.Name = "btninformacion";
            this.btninformacion.Size = new System.Drawing.Size(152, 53);
            this.btninformacion.TabIndex = 2;
            this.btninformacion.Text = "Informacion del Ejercicio";
            this.btninformacion.UseVisualStyleBackColor = true;
            this.btninformacion.Click += new System.EventHandler(this.btninformacion_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(189, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(358, 25);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "ESTADISTICAS DE JUGADORES";
            // 
            // grb_Posicion_Jugador
            // 
            this.grb_Posicion_Jugador.Controls.Add(this.rdb_Delantero);
            this.grb_Posicion_Jugador.Controls.Add(this.rdb_Medio);
            this.grb_Posicion_Jugador.Controls.Add(this.rdb_Defensa);
            this.grb_Posicion_Jugador.Controls.Add(this.rdb_portero);
            this.grb_Posicion_Jugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Posicion_Jugador.Location = new System.Drawing.Point(28, 102);
            this.grb_Posicion_Jugador.Name = "grb_Posicion_Jugador";
            this.grb_Posicion_Jugador.Size = new System.Drawing.Size(169, 174);
            this.grb_Posicion_Jugador.TabIndex = 4;
            this.grb_Posicion_Jugador.TabStop = false;
            this.grb_Posicion_Jugador.Text = "Posicion de Jugador";
            // 
            // rdb_Delantero
            // 
            this.rdb_Delantero.AutoSize = true;
            this.rdb_Delantero.Location = new System.Drawing.Point(18, 130);
            this.rdb_Delantero.Name = "rdb_Delantero";
            this.rdb_Delantero.Size = new System.Drawing.Size(97, 24);
            this.rdb_Delantero.TabIndex = 3;
            this.rdb_Delantero.TabStop = true;
            this.rdb_Delantero.Text = "Delantero";
            this.rdb_Delantero.UseVisualStyleBackColor = true;
            // 
            // rdb_Medio
            // 
            this.rdb_Medio.AutoSize = true;
            this.rdb_Medio.Location = new System.Drawing.Point(18, 100);
            this.rdb_Medio.Name = "rdb_Medio";
            this.rdb_Medio.Size = new System.Drawing.Size(70, 24);
            this.rdb_Medio.TabIndex = 2;
            this.rdb_Medio.TabStop = true;
            this.rdb_Medio.Text = "Medio";
            this.rdb_Medio.UseVisualStyleBackColor = true;
            // 
            // rdb_Defensa
            // 
            this.rdb_Defensa.AutoSize = true;
            this.rdb_Defensa.Location = new System.Drawing.Point(18, 70);
            this.rdb_Defensa.Name = "rdb_Defensa";
            this.rdb_Defensa.Size = new System.Drawing.Size(88, 24);
            this.rdb_Defensa.TabIndex = 1;
            this.rdb_Defensa.TabStop = true;
            this.rdb_Defensa.Text = "Defensa";
            this.rdb_Defensa.UseVisualStyleBackColor = true;
            // 
            // rdb_portero
            // 
            this.rdb_portero.AutoSize = true;
            this.rdb_portero.Location = new System.Drawing.Point(18, 40);
            this.rdb_portero.Name = "rdb_portero";
            this.rdb_portero.Size = new System.Drawing.Size(79, 24);
            this.rdb_portero.TabIndex = 0;
            this.rdb_portero.TabStop = true;
            this.rdb_portero.Text = "Portero";
            this.rdb_portero.UseVisualStyleBackColor = true;
            this.rdb_portero.CheckedChanged += new System.EventHandler(this.rdb_portero_CheckedChanged);
            // 
            // grb_Datos_Jugador
            // 
            this.grb_Datos_Jugador.Controls.Add(this.txt_Goles);
            this.grb_Datos_Jugador.Controls.Add(this.txt_Min);
            this.grb_Datos_Jugador.Controls.Add(this.txt_Nombre);
            this.grb_Datos_Jugador.Controls.Add(this.lbl_Goles);
            this.grb_Datos_Jugador.Controls.Add(this.lbl_Min_Jugadores);
            this.grb_Datos_Jugador.Controls.Add(this.lblNombre);
            this.grb_Datos_Jugador.Controls.Add(this.txt__Num_Uniforme);
            this.grb_Datos_Jugador.Controls.Add(this.lbl_num_Uniforme);
            this.grb_Datos_Jugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Datos_Jugador.Location = new System.Drawing.Point(213, 102);
            this.grb_Datos_Jugador.Name = "grb_Datos_Jugador";
            this.grb_Datos_Jugador.Size = new System.Drawing.Size(316, 174);
            this.grb_Datos_Jugador.TabIndex = 5;
            this.grb_Datos_Jugador.TabStop = false;
            this.grb_Datos_Jugador.Text = "Datos del Jugador";
            // 
            // txt_Goles
            // 
            this.txt_Goles.Location = new System.Drawing.Point(147, 130);
            this.txt_Goles.Name = "txt_Goles";
            this.txt_Goles.Size = new System.Drawing.Size(148, 26);
            this.txt_Goles.TabIndex = 7;
            this.txt_Goles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Goles_KeyPress);
            // 
            // txt_Min
            // 
            this.txt_Min.Location = new System.Drawing.Point(147, 97);
            this.txt_Min.Name = "txt_Min";
            this.txt_Min.Size = new System.Drawing.Size(148, 26);
            this.txt_Min.TabIndex = 6;
            this.txt_Min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Min_KeyPress);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(147, 64);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(148, 26);
            this.txt_Nombre.TabIndex = 5;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // lbl_Goles
            // 
            this.lbl_Goles.AutoSize = true;
            this.lbl_Goles.Location = new System.Drawing.Point(10, 133);
            this.lbl_Goles.Name = "lbl_Goles";
            this.lbl_Goles.Size = new System.Drawing.Size(124, 20);
            this.lbl_Goles.TabIndex = 4;
            this.lbl_Goles.Text = "Goles Anotados";
            // 
            // lbl_Min_Jugadores
            // 
            this.lbl_Min_Jugadores.AutoSize = true;
            this.lbl_Min_Jugadores.Location = new System.Drawing.Point(31, 100);
            this.lbl_Min_Jugadores.Name = "lbl_Min_Jugadores";
            this.lbl_Min_Jugadores.Size = new System.Drawing.Size(103, 20);
            this.lbl_Min_Jugadores.TabIndex = 3;
            this.lbl_Min_Jugadores.Text = "Min. Jugados";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(69, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txt__Num_Uniforme
            // 
            this.txt__Num_Uniforme.Location = new System.Drawing.Point(147, 31);
            this.txt__Num_Uniforme.Name = "txt__Num_Uniforme";
            this.txt__Num_Uniforme.Size = new System.Drawing.Size(148, 26);
            this.txt__Num_Uniforme.TabIndex = 1;
            this.txt__Num_Uniforme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt__Num_Uniforme_KeyPress);
            // 
            // lbl_num_Uniforme
            // 
            this.lbl_num_Uniforme.AutoSize = true;
            this.lbl_num_Uniforme.Location = new System.Drawing.Point(40, 34);
            this.lbl_num_Uniforme.Name = "lbl_num_Uniforme";
            this.lbl_num_Uniforme.Size = new System.Drawing.Size(94, 20);
            this.lbl_num_Uniforme.TabIndex = 0;
            this.lbl_num_Uniforme.Text = "N° Uniforme";
            // 
            // btn_Capturar
            // 
            this.btn_Capturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Capturar.Location = new System.Drawing.Point(535, 107);
            this.btn_Capturar.Name = "btn_Capturar";
            this.btn_Capturar.Size = new System.Drawing.Size(88, 52);
            this.btn_Capturar.TabIndex = 6;
            this.btn_Capturar.Text = "Capturar Datos";
            this.btn_Capturar.UseVisualStyleBackColor = true;
            this.btn_Capturar.Click += new System.EventHandler(this.btn_Capturar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(535, 165);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(88, 32);
            this.btn_Salir.TabIndex = 7;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // dgv_Jugadores
            // 
            this.dgv_Jugadores.AllowUserToAddRows = false;
            this.dgv_Jugadores.AllowUserToDeleteRows = false;
            this.dgv_Jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Jugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Num_Uniforme,
            this.col_Nombre,
            this.col_Posicion,
            this.col_Minutos,
            this.col_Goles});
            this.dgv_Jugadores.Location = new System.Drawing.Point(28, 291);
            this.dgv_Jugadores.Name = "dgv_Jugadores";
            this.dgv_Jugadores.ReadOnly = true;
            this.dgv_Jugadores.Size = new System.Drawing.Size(543, 150);
            this.dgv_Jugadores.TabIndex = 8;
            // 
            // col_Num_Uniforme
            // 
            this.col_Num_Uniforme.HeaderText = "N° Uniforme";
            this.col_Num_Uniforme.Name = "col_Num_Uniforme";
            this.col_Num_Uniforme.ReadOnly = true;
            // 
            // col_Nombre
            // 
            this.col_Nombre.HeaderText = "Nombre";
            this.col_Nombre.Name = "col_Nombre";
            this.col_Nombre.ReadOnly = true;
            // 
            // col_Posicion
            // 
            this.col_Posicion.HeaderText = "Posicion";
            this.col_Posicion.Name = "col_Posicion";
            this.col_Posicion.ReadOnly = true;
            // 
            // col_Minutos
            // 
            this.col_Minutos.HeaderText = "Min. Jugados";
            this.col_Minutos.Name = "col_Minutos";
            this.col_Minutos.ReadOnly = true;
            // 
            // col_Goles
            // 
            this.col_Goles.HeaderText = "Goles Anotados";
            this.col_Goles.Name = "col_Goles";
            this.col_Goles.ReadOnly = true;
            // 
            // txt_num_jugadores
            // 
            this.txt_num_jugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_jugadores.Location = new System.Drawing.Point(393, 65);
            this.txt_num_jugadores.Name = "txt_num_jugadores";
            this.txt_num_jugadores.ReadOnly = true;
            this.txt_num_jugadores.Size = new System.Drawing.Size(100, 26);
            this.txt_num_jugadores.TabIndex = 9;
            // 
            // lbl_num_jugadores
            // 
            this.lbl_num_jugadores.AutoSize = true;
            this.lbl_num_jugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num_jugadores.Location = new System.Drawing.Point(227, 68);
            this.lbl_num_jugadores.Name = "lbl_num_jugadores";
            this.lbl_num_jugadores.Size = new System.Drawing.Size(161, 20);
            this.lbl_num_jugadores.TabIndex = 10;
            this.lbl_num_jugadores.Text = "Numero de jugadores";
            // 
            // Ejercicio_14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.lbl_num_jugadores);
            this.Controls.Add(this.txt_num_jugadores);
            this.Controls.Add(this.dgv_Jugadores);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Capturar);
            this.Controls.Add(this.grb_Datos_Jugador);
            this.Controls.Add(this.grb_Posicion_Jugador);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btninformacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ejercicio_14";
            this.Text = "Ejercicio_14";
            this.grb_Posicion_Jugador.ResumeLayout(false);
            this.grb_Posicion_Jugador.PerformLayout();
            this.grb_Datos_Jugador.ResumeLayout(false);
            this.grb_Datos_Jugador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Jugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninformacion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grb_Posicion_Jugador;
        private System.Windows.Forms.RadioButton rdb_Delantero;
        private System.Windows.Forms.RadioButton rdb_Medio;
        private System.Windows.Forms.RadioButton rdb_Defensa;
        private System.Windows.Forms.RadioButton rdb_portero;
        private System.Windows.Forms.GroupBox grb_Datos_Jugador;
        private System.Windows.Forms.Label lbl_num_Uniforme;
        private System.Windows.Forms.TextBox txt_Goles;
        private System.Windows.Forms.TextBox txt_Min;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Goles;
        private System.Windows.Forms.Label lbl_Min_Jugadores;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txt__Num_Uniforme;
        private System.Windows.Forms.Button btn_Capturar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridView dgv_Jugadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Num_Uniforme;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Minutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Goles;
        private System.Windows.Forms.TextBox txt_num_jugadores;
        private System.Windows.Forms.Label lbl_num_jugadores;
    }
}