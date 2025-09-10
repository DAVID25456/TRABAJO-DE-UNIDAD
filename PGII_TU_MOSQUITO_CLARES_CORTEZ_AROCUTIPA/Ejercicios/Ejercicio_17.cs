using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Ejercicios
{
    public partial class Ejercicio_17 : Form
    {
        string[,] array;
        Regex soloNumeros = new Regex(@"^[0-9]+$");

        public Ejercicio_17()
        {
            InitializeComponent();
            btn_Mostrar.Enabled = false;
            btn_Buscar.Enabled = false;

            dgv_array.ReadOnly = true;
        }

        private void btninformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Utilizando Arrays elabore lo siguiente. Crear una matriz de N*M, el cual debe permitir ingresar números por teclado. El programa debe permitir buscar un número y marcarlo en el array", "Informacion del Ejercicio 17", MessageBoxButtons.OK);
        }

        private void txt_filas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo puede ingresar numeros","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_columnas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo puede ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo puede ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_matriz_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_filas.Text);
            int b = Convert.ToInt32(txt_columnas.Text);

            array = new string[a,b];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {

                    do
                    {
                        array[i, j] = Convert.ToString(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un valor para el bloque [" + i + "," + j + "]", "Ingrese datos", ""));

                        if (!soloNumeros.IsMatch(array[i, j]))
                        {
                            MessageBox.Show("Solo puede ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    while (!soloNumeros.IsMatch(array[i, j]));
                }
            }

            btn_matriz.Enabled = false;
            btn_Mostrar.Enabled = true;
            btn_Buscar.Enabled = true;
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            txt_numero.Enabled = true;

            int a = Convert.ToInt32(txt_filas.Text);
            int b = Convert.ToInt32(txt_columnas.Text);

            dgv_array.Columns.Clear();
            dgv_array.Rows.Clear();

            for (int j = 0; j < b; j++)
            {
                dgv_array.Columns.Add($"Col{j}", $"Col {j + 1}");
            }

            for (int i = 0; i < a; i++)
            {
                object[] fila = new object[b];
                for (int j = 0; j < b; j++)
                {
                    fila[j] = array[i, j];
                }
                dgv_array.Rows.Add(fila);
            }

            dgv_array.ClearSelection();
            dgv_array.CurrentCell = null;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_numero.Text))
            {
                MessageBox.Show("El campo esta vacio", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow row in dgv_array.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                }
            }

            int num = Convert.ToInt32(txt_numero.Text);

            bool encontrado = false;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (Convert.ToInt32(array[i, j]) == num)
                    {
                        encontrado = true;
                        dgv_array.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                    }
                }
            }

            dgv_array.ClearSelection();
            dgv_array.CurrentCell = null;

            if (!encontrado)
            {
                MessageBox.Show("Número no encontrado en la matriz.");
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            dgv_array.Rows.Clear();

            foreach (DataGridViewColumn col in dgv_array.Columns)
            {
                col.HeaderText = string.Empty;
            }

            txt_filas.Clear();
            txt_columnas.Clear();
            txt_numero.Clear();
            txt_numero.Enabled = false;

            btn_matriz.Enabled = true;
            btn_Mostrar.Enabled = false;
            btn_Buscar.Enabled = false;
        }
    }
}
