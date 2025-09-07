namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Ejercicios
{
    partial class Ejercicio_13
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio_13));
            this.label1 = new System.Windows.Forms.Label();
            this.btninformacion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEncuesta = new System.Windows.Forms.Button();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.grb_gaseosas = new System.Windows.Forms.GroupBox();
            this.chb_Crush = new System.Windows.Forms.CheckBox();
            this.chb_Fanta = new System.Windows.Forms.CheckBox();
            this.chb_Coca_Cola = new System.Windows.Forms.CheckBox();
            this.chb_Pepsi_Cola = new System.Windows.Forms.CheckBox();
            this.dgv_gaseosas = new System.Windows.Forms.DataGridView();
            this.colgaseosas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colporcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRespuesta = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtniños = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtadultos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grb_gaseosas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gaseosas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENCUESTA DE BEBIDAS GASEOSAS";
            // 
            // btninformacion
            // 
            this.btninformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninformacion.Location = new System.Drawing.Point(12, 12);
            this.btninformacion.Name = "btninformacion";
            this.btninformacion.Size = new System.Drawing.Size(152, 53);
            this.btninformacion.TabIndex = 1;
            this.btninformacion.Text = "Informacion del Ejercicio";
            this.btninformacion.UseVisualStyleBackColor = true;
            this.btninformacion.Click += new System.EventHandler(this.btninformacion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese la edad";
            // 
            // btnEncuesta
            // 
            this.btnEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncuesta.Location = new System.Drawing.Point(294, 64);
            this.btnEncuesta.Name = "btnEncuesta";
            this.btnEncuesta.Size = new System.Drawing.Size(115, 51);
            this.btnEncuesta.TabIndex = 3;
            this.btnEncuesta.Text = "Realizar encuesta";
            this.btnEncuesta.UseVisualStyleBackColor = true;
            this.btnEncuesta.Click += new System.EventHandler(this.btnEncuesta_Click);
            // 
            // txtedad
            // 
            this.txtedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtedad.Location = new System.Drawing.Point(175, 76);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 26);
            this.txtedad.TabIndex = 4;
            this.txtedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedad_KeyPress);
            // 
            // grb_gaseosas
            // 
            this.grb_gaseosas.Controls.Add(this.chb_Crush);
            this.grb_gaseosas.Controls.Add(this.chb_Fanta);
            this.grb_gaseosas.Controls.Add(this.chb_Coca_Cola);
            this.grb_gaseosas.Controls.Add(this.chb_Pepsi_Cola);
            this.grb_gaseosas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_gaseosas.Location = new System.Drawing.Point(12, 138);
            this.grb_gaseosas.Name = "grb_gaseosas";
            this.grb_gaseosas.Size = new System.Drawing.Size(171, 152);
            this.grb_gaseosas.TabIndex = 5;
            this.grb_gaseosas.TabStop = false;
            this.grb_gaseosas.Text = "GASEOSAS";
            // 
            // chb_Crush
            // 
            this.chb_Crush.AutoSize = true;
            this.chb_Crush.Location = new System.Drawing.Point(16, 113);
            this.chb_Crush.Name = "chb_Crush";
            this.chb_Crush.Size = new System.Drawing.Size(70, 24);
            this.chb_Crush.TabIndex = 11;
            this.chb_Crush.Text = "Crush";
            this.chb_Crush.UseVisualStyleBackColor = true;
            // 
            // chb_Fanta
            // 
            this.chb_Fanta.AutoSize = true;
            this.chb_Fanta.Location = new System.Drawing.Point(16, 86);
            this.chb_Fanta.Name = "chb_Fanta";
            this.chb_Fanta.Size = new System.Drawing.Size(70, 24);
            this.chb_Fanta.TabIndex = 10;
            this.chb_Fanta.Text = "Fanta";
            this.chb_Fanta.UseVisualStyleBackColor = true;
            // 
            // chb_Coca_Cola
            // 
            this.chb_Coca_Cola.AutoSize = true;
            this.chb_Coca_Cola.Location = new System.Drawing.Point(16, 59);
            this.chb_Coca_Cola.Name = "chb_Coca_Cola";
            this.chb_Coca_Cola.Size = new System.Drawing.Size(101, 24);
            this.chb_Coca_Cola.TabIndex = 9;
            this.chb_Coca_Cola.Text = "Coca Cola";
            this.chb_Coca_Cola.UseVisualStyleBackColor = true;
            // 
            // chb_Pepsi_Cola
            // 
            this.chb_Pepsi_Cola.AutoSize = true;
            this.chb_Pepsi_Cola.Location = new System.Drawing.Point(16, 32);
            this.chb_Pepsi_Cola.Name = "chb_Pepsi_Cola";
            this.chb_Pepsi_Cola.Size = new System.Drawing.Size(103, 24);
            this.chb_Pepsi_Cola.TabIndex = 8;
            this.chb_Pepsi_Cola.Text = "Pepsi Cola";
            this.chb_Pepsi_Cola.UseVisualStyleBackColor = true;
            // 
            // dgv_gaseosas
            // 
            this.dgv_gaseosas.AllowUserToAddRows = false;
            this.dgv_gaseosas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_gaseosas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_gaseosas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gaseosas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colgaseosas,
            this.colpersonas,
            this.colporcentaje});
            this.dgv_gaseosas.Location = new System.Drawing.Point(215, 138);
            this.dgv_gaseosas.Name = "dgv_gaseosas";
            this.dgv_gaseosas.ReadOnly = true;
            this.dgv_gaseosas.Size = new System.Drawing.Size(345, 168);
            this.dgv_gaseosas.TabIndex = 6;
            // 
            // colgaseosas
            // 
            this.colgaseosas.HeaderText = "Gaseosas";
            this.colgaseosas.Name = "colgaseosas";
            this.colgaseosas.ReadOnly = true;
            // 
            // colpersonas
            // 
            this.colpersonas.HeaderText = "Numero de Personas";
            this.colpersonas.Name = "colpersonas";
            this.colpersonas.ReadOnly = true;
            // 
            // colporcentaje
            // 
            this.colporcentaje.HeaderText = "Porcentaje";
            this.colporcentaje.Name = "colporcentaje";
            this.colporcentaje.ReadOnly = true;
            // 
            // btnRespuesta
            // 
            this.btnRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespuesta.Location = new System.Drawing.Point(12, 296);
            this.btnRespuesta.Name = "btnRespuesta";
            this.btnRespuesta.Size = new System.Drawing.Size(171, 40);
            this.btnRespuesta.TabIndex = 7;
            this.btnRespuesta.Text = "Enviar Respuesta";
            this.btnRespuesta.UseVisualStyleBackColor = true;
            this.btnRespuesta.Click += new System.EventHandler(this.btnRespuesta_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(415, 65);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(74, 50);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(460, 319);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(100, 26);
            this.txttotal.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total de personas";
            // 
            // txtniños
            // 
            this.txtniños.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtniños.Location = new System.Drawing.Point(460, 351);
            this.txtniños.Name = "txtniños";
            this.txtniños.ReadOnly = true;
            this.txtniños.Size = new System.Drawing.Size(100, 26);
            this.txtniños.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total de niños";
            // 
            // txtadultos
            // 
            this.txtadultos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadultos.Location = new System.Drawing.Point(460, 383);
            this.txtadultos.Name = "txtadultos";
            this.txtadultos.ReadOnly = true;
            this.txtadultos.Size = new System.Drawing.Size(100, 26);
            this.txtadultos.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total de adultos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(12, 342);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(171, 40);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Ejercicio_13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 430);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtadultos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtniños);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnRespuesta);
            this.Controls.Add(this.dgv_gaseosas);
            this.Controls.Add(this.grb_gaseosas);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.btnEncuesta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btninformacion);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ejercicio_13";
            this.Text = "Ejercicio_13";
            this.grb_gaseosas.ResumeLayout(false);
            this.grb_gaseosas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gaseosas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btninformacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Button btnEncuesta;
        private System.Windows.Forms.GroupBox grb_gaseosas;
        private System.Windows.Forms.DataGridView dgv_gaseosas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgaseosas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colporcentaje;
        private System.Windows.Forms.Button btnRespuesta;
        private System.Windows.Forms.CheckBox chb_Crush;
        private System.Windows.Forms.CheckBox chb_Fanta;
        private System.Windows.Forms.CheckBox chb_Coca_Cola;
        private System.Windows.Forms.CheckBox chb_Pepsi_Cola;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtniños;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtadultos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
    }
}