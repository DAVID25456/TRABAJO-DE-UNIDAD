using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Clases.Ejercicio_19;


namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Ejercicios
{
    public partial class Ejercicio_19 : Form
    {
        cls_Producto Obj_Producto = new cls_Producto();

        public Ejercicio_19()
        {
            InitializeComponent();

            txt_Numero.Enabled = false;
            txt_Producto.Enabled = false;
            cmb_Categoria.Enabled = false;
            txt_Precio.Enabled = false;
            txt_Sub_Total.Enabled = false;
            txt_Cantidad.Enabled = false;

            rdb_Bueno.Enabled = false;
            rdb_Malo.Enabled = false;
            rdb_Regular.Enabled = false;

            chb_Activo.Enabled = false;

            btn_Grabar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Cancelar.Enabled = false;
        }

        private void btninformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elaborar un programa que permita realizar el mantenimiento de productos (Grabar, Modificar, Eliminar, Listar). Los campos son Número, Nombre de Producto, Categoria, Precio, Cantidad, SubTotal, Condición, Estado Teniendo en cuenta lo siguiente:\n \n- El campo número debe ser correlativo \nLa categoría debe ser un combobox (Disco Duro, Laptop, Computadora, Impresora, Monitor, Tablet). \n-El campo Sub Total debe calcularse automáticamente \n-El Campo condición debe ser un Radiobutton (Bueno / Regular / Malo) \n-El campo Estado debe ser Check radiobutton (Activo / Inactivo)", "Informacion del Ejercicio 19", MessageBoxButtons.OK);
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            btn_Nuevo.Enabled = false;
            btn_Grabar.Enabled = true;
            btn_Editar.Enabled = true;
            btn_Eliminar.Enabled = true;
            btn_Cancelar.Enabled = true;

            txt_Numero.Enabled = true;
            txt_Producto.Enabled = true;
            cmb_Categoria.Enabled = true;
            txt_Precio.Enabled = true;
            txt_Cantidad.Enabled = true;

            rdb_Bueno.Enabled = true;
            rdb_Malo.Enabled = true;
            rdb_Regular.Enabled = true;

            chb_Activo.Enabled = true;


            Obj_Producto.numero = txt_Numero.Text;
            Obj_Producto.producto = txt_Producto.Text;
            Obj_Producto.categoria = cmb_Categoria.Text;
            Obj_Producto.precio = Convert.ToDouble(txt_Precio.Text);
            Obj_Producto.cantidad = Convert.ToInt32(txt_Cantidad.Text);


        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txt_Producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txt_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                MessageBox.Show("Solo puede ingresar números y un separador decimal (coma o punto).",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }

            // Evitar más de un separador decimal
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (txt_Precio.Text.Contains('.') || txt_Precio.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
    }
}
