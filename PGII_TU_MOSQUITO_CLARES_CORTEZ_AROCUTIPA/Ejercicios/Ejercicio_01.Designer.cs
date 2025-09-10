namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Ejercicios
{
    partial class Ejercicio_01
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
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.btnTotalBanco = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lbl_Monto = new System.Windows.Forms.Label();
            this.lbl_Clliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEjercicio1 = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(626, 120);
            this.lstClientes.Margin = new System.Windows.Forms.Padding(2);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(230, 134);
            this.lstClientes.TabIndex = 41;
            // 
            // btnTotalBanco
            // 
            this.btnTotalBanco.Location = new System.Drawing.Point(380, 247);
            this.btnTotalBanco.Margin = new System.Windows.Forms.Padding(2);
            this.btnTotalBanco.Name = "btnTotalBanco";
            this.btnTotalBanco.Size = new System.Drawing.Size(122, 22);
            this.btnTotalBanco.TabIndex = 40;
            this.btnTotalBanco.Text = "MOSTRAR TOTAL";
            this.btnTotalBanco.UseVisualStyleBackColor = true;
            this.btnTotalBanco.Click += new System.EventHandler(this.btnTotalBanco_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(506, 167);
            this.btnRetirar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(80, 25);
            this.btnRetirar.TabIndex = 39;
            this.btnRetirar.Text = "RETIRAR";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(506, 120);
            this.btnDepositar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(80, 28);
            this.btnDepositar.TabIndex = 38;
            this.btnDepositar.Text = "DEPOSITAR";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(356, 168);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(125, 20);
            this.txtMonto.TabIndex = 37;
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Items.AddRange(new object[] {
            "Cliente 1",
            "Cliente 2",
            "Cliente 3"});
            this.cmbClientes.Location = new System.Drawing.Point(356, 120);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(2);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(125, 21);
            this.cmbClientes.TabIndex = 36;
            // 
            // lbl_Monto
            // 
            this.lbl_Monto.AutoSize = true;
            this.lbl_Monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Monto.Location = new System.Drawing.Point(286, 173);
            this.lbl_Monto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Monto.Name = "lbl_Monto";
            this.lbl_Monto.Size = new System.Drawing.Size(56, 13);
            this.lbl_Monto.TabIndex = 35;
            this.lbl_Monto.Text = "MONTO:";
            // 
            // lbl_Clliente
            // 
            this.lbl_Clliente.AutoSize = true;
            this.lbl_Clliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clliente.Location = new System.Drawing.Point(281, 128);
            this.lbl_Clliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Clliente.Name = "lbl_Clliente";
            this.lbl_Clliente.Size = new System.Drawing.Size(63, 13);
            this.lbl_Clliente.TabIndex = 34;
            this.lbl_Clliente.Text = "CLIENTE:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnEjercicio1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 43;
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
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(226, 23);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(668, 25);
            this.lbl_Titulo.TabIndex = 42;
            this.lbl_Titulo.Text = "Simulación de operaciones bancarias con clientes y depósitos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(781, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ejercicio_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.btnTotalBanco);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.lbl_Monto);
            this.Controls.Add(this.lbl_Clliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.button1);
            this.Name = "Ejercicio_01";
            this.Text = "Ejercicio_01";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label lbl_Monto;
        private System.Windows.Forms.Label lbl_Clliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEjercicio1;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTotalBanco;
    }
}