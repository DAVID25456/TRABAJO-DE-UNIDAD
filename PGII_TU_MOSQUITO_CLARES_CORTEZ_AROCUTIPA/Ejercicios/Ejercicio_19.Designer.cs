namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Ejercicios
{
    partial class Ejercicio_19
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
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.txt_Producto = new System.Windows.Forms.TextBox();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.cmb_Categoria = new System.Windows.Forms.ComboBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_Sub_Total = new System.Windows.Forms.TextBox();
            this.lbl_Sub_Total = new System.Windows.Forms.Label();
            this.lbl_Condicion = new System.Windows.Forms.Label();
            this.rdb_Bueno = new System.Windows.Forms.RadioButton();
            this.rdb_Regular = new System.Windows.Forms.RadioButton();
            this.rdb_Malo = new System.Windows.Forms.RadioButton();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.chb_Activo = new System.Windows.Forms.CheckBox();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Primero = new System.Windows.Forms.Button();
            this.btn_Anterior = new System.Windows.Forms.Button();
            this.btn_Siguiente = new System.Windows.Forms.Button();
            this.btn_Ultimo = new System.Windows.Forms.Button();
            this.dgv_Mantenimiento = new System.Windows.Forms.DataGridView();
            this.col_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // btninformacion
            // 
            this.btninformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninformacion.Location = new System.Drawing.Point(12, 12);
            this.btninformacion.Name = "btninformacion";
            this.btninformacion.Size = new System.Drawing.Size(152, 53);
            this.btninformacion.TabIndex = 7;
            this.btninformacion.Text = "Informacion del Ejercicio";
            this.btninformacion.UseVisualStyleBackColor = true;
            this.btninformacion.Click += new System.EventHandler(this.btninformacion_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(193, 24);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(200, 25);
            this.lbl_Titulo.TabIndex = 11;
            this.lbl_Titulo.Text = "MANTENIMIENTO";
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero.Location = new System.Drawing.Point(12, 86);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(69, 20);
            this.lbl_Numero.TabIndex = 18;
            this.lbl_Numero.Text = "Número:";
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Producto.Location = new System.Drawing.Point(12, 118);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(77, 20);
            this.lbl_Producto.TabIndex = 19;
            this.lbl_Producto.Text = "Producto:";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numero.Location = new System.Drawing.Point(119, 83);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(121, 26);
            this.txt_Numero.TabIndex = 20;
            this.txt_Numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Numero_KeyPress);
            // 
            // txt_Producto
            // 
            this.txt_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Producto.Location = new System.Drawing.Point(119, 115);
            this.txt_Producto.Name = "txt_Producto";
            this.txt_Producto.Size = new System.Drawing.Size(121, 26);
            this.txt_Producto.TabIndex = 21;
            this.txt_Producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Producto_KeyPress);
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria.Location = new System.Drawing.Point(12, 151);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(82, 20);
            this.lbl_Categoria.TabIndex = 22;
            this.lbl_Categoria.Text = "Categoria:";
            // 
            // cmb_Categoria
            // 
            this.cmb_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Categoria.FormattingEnabled = true;
            this.cmb_Categoria.Items.AddRange(new object[] {
            "Electrónica",
            "Ropa",
            "Alimentos",
            "Hogar",
            "Juguetes"});
            this.cmb_Categoria.Location = new System.Drawing.Point(119, 147);
            this.cmb_Categoria.Name = "cmb_Categoria";
            this.cmb_Categoria.Size = new System.Drawing.Size(121, 28);
            this.cmb_Categoria.TabIndex = 23;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio.Location = new System.Drawing.Point(12, 184);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(57, 20);
            this.lbl_Precio.TabIndex = 24;
            this.lbl_Precio.Text = "Precio:";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Precio.Location = new System.Drawing.Point(119, 181);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(121, 26);
            this.txt_Precio.TabIndex = 25;
            this.txt_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Precio_KeyPress);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad.Location = new System.Drawing.Point(376, 213);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 26);
            this.txt_Cantidad.TabIndex = 27;
            this.txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cantidad_KeyPress);
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.Location = new System.Drawing.Point(269, 216);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(77, 20);
            this.lbl_Cantidad.TabIndex = 26;
            this.lbl_Cantidad.Text = "Cantidad:";
            // 
            // txt_Sub_Total
            // 
            this.txt_Sub_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sub_Total.Location = new System.Drawing.Point(119, 213);
            this.txt_Sub_Total.Name = "txt_Sub_Total";
            this.txt_Sub_Total.Size = new System.Drawing.Size(121, 26);
            this.txt_Sub_Total.TabIndex = 29;
            // 
            // lbl_Sub_Total
            // 
            this.lbl_Sub_Total.AutoSize = true;
            this.lbl_Sub_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sub_Total.Location = new System.Drawing.Point(12, 216);
            this.lbl_Sub_Total.Name = "lbl_Sub_Total";
            this.lbl_Sub_Total.Size = new System.Drawing.Size(81, 20);
            this.lbl_Sub_Total.TabIndex = 28;
            this.lbl_Sub_Total.Text = "Sub Total:";
            // 
            // lbl_Condicion
            // 
            this.lbl_Condicion.AutoSize = true;
            this.lbl_Condicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Condicion.Location = new System.Drawing.Point(12, 257);
            this.lbl_Condicion.Name = "lbl_Condicion";
            this.lbl_Condicion.Size = new System.Drawing.Size(79, 20);
            this.lbl_Condicion.TabIndex = 30;
            this.lbl_Condicion.Text = "Condicion";
            // 
            // rdb_Bueno
            // 
            this.rdb_Bueno.AutoSize = true;
            this.rdb_Bueno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Bueno.Location = new System.Drawing.Point(120, 255);
            this.rdb_Bueno.Name = "rdb_Bueno";
            this.rdb_Bueno.Size = new System.Drawing.Size(74, 24);
            this.rdb_Bueno.TabIndex = 31;
            this.rdb_Bueno.TabStop = true;
            this.rdb_Bueno.Text = "Bueno";
            this.rdb_Bueno.UseVisualStyleBackColor = true;
            // 
            // rdb_Regular
            // 
            this.rdb_Regular.AutoSize = true;
            this.rdb_Regular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Regular.Location = new System.Drawing.Point(215, 255);
            this.rdb_Regular.Name = "rdb_Regular";
            this.rdb_Regular.Size = new System.Drawing.Size(83, 24);
            this.rdb_Regular.TabIndex = 32;
            this.rdb_Regular.TabStop = true;
            this.rdb_Regular.Text = "Regular";
            this.rdb_Regular.UseVisualStyleBackColor = true;
            // 
            // rdb_Malo
            // 
            this.rdb_Malo.AutoSize = true;
            this.rdb_Malo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Malo.Location = new System.Drawing.Point(319, 255);
            this.rdb_Malo.Name = "rdb_Malo";
            this.rdb_Malo.Size = new System.Drawing.Size(61, 24);
            this.rdb_Malo.TabIndex = 33;
            this.rdb_Malo.TabStop = true;
            this.rdb_Malo.Text = "Malo";
            this.rdb_Malo.UseVisualStyleBackColor = true;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.Location = new System.Drawing.Point(12, 291);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(60, 20);
            this.lbl_Estado.TabIndex = 34;
            this.lbl_Estado.Text = "Estado";
            // 
            // chb_Activo
            // 
            this.chb_Activo.AutoSize = true;
            this.chb_Activo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_Activo.Location = new System.Drawing.Point(119, 293);
            this.chb_Activo.Name = "chb_Activo";
            this.chb_Activo.Size = new System.Drawing.Size(71, 24);
            this.chb_Activo.TabIndex = 35;
            this.chb_Activo.Text = "Activo";
            this.chb_Activo.UseVisualStyleBackColor = true;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.Location = new System.Drawing.Point(497, 80);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(90, 26);
            this.btn_Nuevo.TabIndex = 36;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Grabar.Location = new System.Drawing.Point(497, 112);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(90, 26);
            this.btn_Grabar.TabIndex = 37;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Location = new System.Drawing.Point(497, 144);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(90, 26);
            this.btn_Editar.TabIndex = 38;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Location = new System.Drawing.Point(497, 176);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(90, 26);
            this.btn_Eliminar.TabIndex = 39;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(497, 208);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(90, 26);
            this.btn_Cancelar.TabIndex = 40;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.Location = new System.Drawing.Point(497, 240);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(90, 26);
            this.btn_Cerrar.TabIndex = 41;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Primero
            // 
            this.btn_Primero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Primero.Location = new System.Drawing.Point(75, 326);
            this.btn_Primero.Name = "btn_Primero";
            this.btn_Primero.Size = new System.Drawing.Size(90, 26);
            this.btn_Primero.TabIndex = 42;
            this.btn_Primero.Text = "Primero";
            this.btn_Primero.UseVisualStyleBackColor = true;
            this.btn_Primero.Click += new System.EventHandler(this.btn_Primero_Click);
            // 
            // btn_Anterior
            // 
            this.btn_Anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Anterior.Location = new System.Drawing.Point(184, 326);
            this.btn_Anterior.Name = "btn_Anterior";
            this.btn_Anterior.Size = new System.Drawing.Size(103, 26);
            this.btn_Anterior.TabIndex = 43;
            this.btn_Anterior.Text = "<<Anterior";
            this.btn_Anterior.UseVisualStyleBackColor = true;
            this.btn_Anterior.Click += new System.EventHandler(this.btn_Anterior_Click);
            // 
            // btn_Siguiente
            // 
            this.btn_Siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Siguiente.Location = new System.Drawing.Point(306, 326);
            this.btn_Siguiente.Name = "btn_Siguiente";
            this.btn_Siguiente.Size = new System.Drawing.Size(103, 26);
            this.btn_Siguiente.TabIndex = 44;
            this.btn_Siguiente.Text = "Siguiente>>";
            this.btn_Siguiente.UseVisualStyleBackColor = true;
            this.btn_Siguiente.Click += new System.EventHandler(this.btn_Siguiente_Click);
            // 
            // btn_Ultimo
            // 
            this.btn_Ultimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ultimo.Location = new System.Drawing.Point(428, 326);
            this.btn_Ultimo.Name = "btn_Ultimo";
            this.btn_Ultimo.Size = new System.Drawing.Size(103, 26);
            this.btn_Ultimo.TabIndex = 45;
            this.btn_Ultimo.Text = "Ultimo";
            this.btn_Ultimo.UseVisualStyleBackColor = true;
            this.btn_Ultimo.Click += new System.EventHandler(this.btn_Ultimo_Click);
            // 
            // dgv_Mantenimiento
            // 
            this.dgv_Mantenimiento.AllowUserToAddRows = false;
            this.dgv_Mantenimiento.AllowUserToDeleteRows = false;
            this.dgv_Mantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mantenimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_numero,
            this.col_Producto,
            this.col_Categoria,
            this.col_precio,
            this.col_cantidad,
            this.col_subtotal,
            this.col_condicion,
            this.col_Estado});
            this.dgv_Mantenimiento.Location = new System.Drawing.Point(12, 358);
            this.dgv_Mantenimiento.Name = "dgv_Mantenimiento";
            this.dgv_Mantenimiento.ReadOnly = true;
            this.dgv_Mantenimiento.Size = new System.Drawing.Size(581, 150);
            this.dgv_Mantenimiento.TabIndex = 46;
            this.dgv_Mantenimiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Mantenimiento_CellClick);
            // 
            // col_numero
            // 
            this.col_numero.HeaderText = "Numero";
            this.col_numero.Name = "col_numero";
            this.col_numero.ReadOnly = true;
            this.col_numero.Width = 80;
            // 
            // col_Producto
            // 
            this.col_Producto.HeaderText = "Porducto";
            this.col_Producto.Name = "col_Producto";
            this.col_Producto.ReadOnly = true;
            this.col_Producto.Width = 80;
            // 
            // col_Categoria
            // 
            this.col_Categoria.HeaderText = "Categoria";
            this.col_Categoria.Name = "col_Categoria";
            this.col_Categoria.ReadOnly = true;
            this.col_Categoria.Width = 80;
            // 
            // col_precio
            // 
            this.col_precio.HeaderText = "Precio";
            this.col_precio.Name = "col_precio";
            this.col_precio.ReadOnly = true;
            this.col_precio.Width = 80;
            // 
            // col_cantidad
            // 
            this.col_cantidad.HeaderText = "Cantidad";
            this.col_cantidad.Name = "col_cantidad";
            this.col_cantidad.ReadOnly = true;
            this.col_cantidad.Width = 80;
            // 
            // col_subtotal
            // 
            this.col_subtotal.HeaderText = "Sub Total";
            this.col_subtotal.Name = "col_subtotal";
            this.col_subtotal.ReadOnly = true;
            this.col_subtotal.Width = 80;
            // 
            // col_condicion
            // 
            this.col_condicion.HeaderText = "Condicion";
            this.col_condicion.Name = "col_condicion";
            this.col_condicion.ReadOnly = true;
            this.col_condicion.Width = 80;
            // 
            // col_Estado
            // 
            this.col_Estado.HeaderText = "Estado";
            this.col_Estado.Name = "col_Estado";
            this.col_Estado.ReadOnly = true;
            this.col_Estado.Width = 80;
            // 
            // Ejercicio_19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 521);
            this.Controls.Add(this.dgv_Mantenimiento);
            this.Controls.Add(this.btn_Ultimo);
            this.Controls.Add(this.btn_Siguiente);
            this.Controls.Add(this.btn_Anterior);
            this.Controls.Add(this.btn_Primero);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Grabar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.chb_Activo);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.rdb_Malo);
            this.Controls.Add(this.rdb_Regular);
            this.Controls.Add(this.rdb_Bueno);
            this.Controls.Add(this.lbl_Condicion);
            this.Controls.Add(this.txt_Sub_Total);
            this.Controls.Add(this.lbl_Sub_Total);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.cmb_Categoria);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.txt_Producto);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.lbl_Producto);
            this.Controls.Add(this.lbl_Numero);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btninformacion);
            this.Name = "Ejercicio_19";
            this.Text = "Ejercicio_19";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mantenimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninformacion;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.TextBox txt_Producto;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.ComboBox cmb_Categoria;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_Sub_Total;
        private System.Windows.Forms.Label lbl_Sub_Total;
        private System.Windows.Forms.Label lbl_Condicion;
        private System.Windows.Forms.RadioButton rdb_Bueno;
        private System.Windows.Forms.RadioButton rdb_Regular;
        private System.Windows.Forms.RadioButton rdb_Malo;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.CheckBox chb_Activo;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Primero;
        private System.Windows.Forms.Button btn_Anterior;
        private System.Windows.Forms.Button btn_Siguiente;
        private System.Windows.Forms.Button btn_Ultimo;
        private System.Windows.Forms.DataGridView dgv_Mantenimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Estado;
    }
}