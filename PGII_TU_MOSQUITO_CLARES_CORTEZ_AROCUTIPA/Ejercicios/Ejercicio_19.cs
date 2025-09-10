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
        private DataGridViewRow filaSeleccionada = null;


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

        public void ActivarBotones(bool a, bool b, bool c, bool d, bool e, bool f)
        {
            btn_Nuevo.Enabled = a;
            btn_Grabar.Enabled = b;
            btn_Editar.Enabled = c;
            btn_Eliminar.Enabled = d;
            btn_Cancelar.Enabled = e;
            btn_Cerrar.Enabled = f;

        }

        public void Activartext(bool x)
        {
            txt_Numero.Enabled = x;
            txt_Producto.Enabled = x;
            cmb_Categoria.Enabled = x;
            txt_Precio.Enabled = x;
            txt_Cantidad.Enabled = x;

            rdb_Bueno.Enabled = x;
            rdb_Malo.Enabled = x;
            rdb_Regular.Enabled = x;

            chb_Activo.Enabled = x;
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            ActivarBotones(false, true, false, false, true, true);
            Activartext(true);
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

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            verificacion();

            txt_Sub_Total.Text = Obj_Producto.Sub_Total().ToString();

            if (rdb_Bueno.Checked)
            {
                Obj_Producto.condicion = "Bueno";
            }
            else if (rdb_Malo.Checked)
            {
                Obj_Producto.condicion = "Malo";
            }
            else if (rdb_Regular.Checked)
            {
                Obj_Producto.condicion = "Regular";
            }
            else
            {
                MessageBox.Show("Debe Escoger un valor en la condicion");
                return;
            }

            if (chb_Activo.Checked)
            {
                Obj_Producto.estado = "Activo";
            }
            else
            {
                Obj_Producto.estado = "No Activo";
            }

            if (filaSeleccionada == null)
            {
                dgv_Mantenimiento.Rows.Add(
                    Obj_Producto.numero,
                    Obj_Producto.producto,
                    Obj_Producto.categoria,
                    Obj_Producto.precio,
                    Obj_Producto.cantidad,
                    Obj_Producto.Sub_Total().ToString(),
                    Obj_Producto.condicion,
                    Obj_Producto.estado
                );
                
            }
            else
            {
                filaSeleccionada.Cells[0].Value = Obj_Producto.numero;
                filaSeleccionada.Cells[1].Value = Obj_Producto.producto;
                filaSeleccionada.Cells[2].Value = Obj_Producto.categoria;
                filaSeleccionada.Cells[3].Value = Obj_Producto.precio;
                filaSeleccionada.Cells[4].Value = Obj_Producto.cantidad;
                filaSeleccionada.Cells[5].Value = Obj_Producto.Sub_Total().ToString();
                filaSeleccionada.Cells[6].Value = Obj_Producto.condicion;
                filaSeleccionada.Cells[7].Value = Obj_Producto.estado;

                filaSeleccionada = null; // limpiar referencia
            }

            Limpiar();
            Activartext(false);
            ActivarBotones(true, false, false, false, true, true);
        }

        private void verificacion()
        {
            if (string.IsNullOrEmpty(txt_Numero.Text))
            {
                MessageBox.Show("Ingrese el numero del producto");
                return;
            }
            else
            {
                Obj_Producto.numero = txt_Numero.Text;
            }

            if (string.IsNullOrEmpty(txt_Producto.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto");
                return;
            }
            else
            {
                Obj_Producto.producto = txt_Producto.Text;
            }

            if (string.IsNullOrEmpty(cmb_Categoria.Text))
            {
                MessageBox.Show("Ingrese la categoria");
                return;
            }
            else
            {
                Obj_Producto.categoria = cmb_Categoria.Text;
            }

            if (string.IsNullOrEmpty(txt_Precio.Text))
            {
                MessageBox.Show("Ingrese el precio");
                return;
            }
            else
            {
                Obj_Producto.precio = Convert.ToDouble(txt_Precio.Text);
            }

            if (string.IsNullOrEmpty(txt_Cantidad.Text))
            {
                MessageBox.Show("Ingrese la cantidad");
                return;
            }
            else
            {
                Obj_Producto.cantidad = Convert.ToInt32(txt_Cantidad.Text);
            }
        }

        private void Limpiar()
        {
            txt_Numero.Clear();
            txt_Producto.Clear();
            txt_Precio.Clear();
            txt_Cantidad.Clear();
            txt_Sub_Total.Clear();

            chb_Activo.Checked = false;

            rdb_Bueno.Checked = false;
            rdb_Malo.Checked = false;
            rdb_Regular.Checked = false;

            cmb_Categoria.SelectedIndex = -1;
            cmb_Categoria.Text = string.Empty;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            ActivarBotones(true,false,false,false,false,true);
        }

        private void dgv_Mantenimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_Mantenimiento.Rows)
            {
                if (e.RowIndex >= 0)
                {
                    filaSeleccionada = dgv_Mantenimiento.Rows[e.RowIndex];

                    txt_Numero.Text = filaSeleccionada.Cells[0].Value.ToString();
                    txt_Producto.Text = filaSeleccionada.Cells[1].Value.ToString();
                    cmb_Categoria.Text = filaSeleccionada.Cells[2].Value.ToString();
                    txt_Precio.Text = filaSeleccionada.Cells[3].Value.ToString();
                    txt_Cantidad.Text = filaSeleccionada.Cells[4].Value.ToString();
                    txt_Sub_Total.Text = filaSeleccionada.Cells[5].Value.ToString();

                    ActivarBotones(false, false, true, true, true, true);
                    Activartext(false);
                }
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Activartext(true);
            ActivarBotones(false, true, false, true, true, true);
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro de eliminar el registro?", "Sistema",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dgv_Mantenimiento.CurrentRow != null)
                {
                    dgv_Mantenimiento.Rows.Remove(dgv_Mantenimiento.CurrentRow);
                }
            }
            Limpiar();
        }

        private void MostrarDatosRegistroSelecionado()
        {

            if (dgv_Mantenimiento.CurrentRow != null)
            {
                DataGridViewRow filaSeleccionada = dgv_Mantenimiento.CurrentRow;

                txt_Numero.Text = filaSeleccionada.Cells[0].Value.ToString();
                txt_Producto.Text = filaSeleccionada.Cells[1].Value.ToString();
                cmb_Categoria.Text = filaSeleccionada.Cells[2].Value.ToString();
                txt_Precio.Text = filaSeleccionada.Cells[3].Value.ToString();
                txt_Cantidad.Text = filaSeleccionada.Cells[4].Value.ToString();
                txt_Sub_Total.Text = filaSeleccionada.Cells[5].Value.ToString();
            }
        }

        private void btn_Primero_Click(object sender, EventArgs e)
        {
            if (dgv_Mantenimiento.Rows.Count > 0)
            {
                dgv_Mantenimiento.CurrentCell = dgv_Mantenimiento.Rows[0].Cells[0];
                MostrarDatosRegistroSelecionado();
            }
        }

        private void btn_Anterior_Click(object sender, EventArgs e)
        {
            if (dgv_Mantenimiento.CurrentRow != null && dgv_Mantenimiento.CurrentRow.Index > 0)
            {
                int indiceAnterior = dgv_Mantenimiento.CurrentRow.Index - 1;
                dgv_Mantenimiento.CurrentCell = dgv_Mantenimiento.Rows[indiceAnterior].Cells[0];
                MostrarDatosRegistroSelecionado();
            }
        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            if (dgv_Mantenimiento.CurrentRow != null && dgv_Mantenimiento.CurrentRow.Index < dgv_Mantenimiento.Rows.Count - 1)
            {
                int indiceSiguiente = dgv_Mantenimiento.CurrentRow.Index + 1;
                dgv_Mantenimiento.CurrentCell = dgv_Mantenimiento.Rows[indiceSiguiente].Cells[0];
                MostrarDatosRegistroSelecionado();
            }
        }

        private void btn_Ultimo_Click(object sender, EventArgs e)
        {
            int ultimaFilaIndex = dgv_Mantenimiento.Rows.Count - 1;
            if (ultimaFilaIndex >= 0)
            {
                dgv_Mantenimiento.CurrentCell = dgv_Mantenimiento.Rows[ultimaFilaIndex].Cells[0];
                MostrarDatosRegistroSelecionado();
            }
        }
    }
}
