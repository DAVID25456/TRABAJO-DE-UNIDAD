using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Ejercicios
{
    public partial class Ejercicio_11 : Form
    {
        int contadorEmpleados = 0;
        public Ejercicio_11()
        {
            InitializeComponent();
        }

        private void btninformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En una empresa cada empleado tiene un código entero de tres cifras. Elabore un\r\nprograma que lea el código de un empleado y determine de qué tipo de empleado\r\nse trata de acuerdo a los siguientes criterios:\r\n• Si el código es divisible por 2, por 3 y por 5, el tipo de empleado es\r\n“Administrativo”.\r\n• Si el código es divisible por 3 y por 5 pero no por 2, el tipo de empleado es\r\n“Directivo”.\r\n• Si el código es divisible por 2, pero no por 3 ni por 5, el tipo de empleado es\r\n“Vendedor”.\r\n• Si el código no es divisible por 2, ni por 3 ni por 5, el tipo de empleado es\r\n“Seguridad”. ", "Informacion del Ejercicio 11", MessageBoxButtons.OK);
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txt_Empleados.Text, out int totalEmpleados) || totalEmpleados <= 0)
            {
                MessageBox.Show("Ingrese la cantidad de empleados.");
                txt_Empleados.Focus();
                return;
            }

            string nombre = txt_Nombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese el nombre del empleado.");
                txt_Nombre.Focus();
                return;
            }
            foreach (char c in nombre)
            {
                if (char.IsDigit(c))
                {
                    MessageBox.Show("Solo texto. Ingrese texto!!.");
                    txt_Nombre.Focus();
                    return;
                }
            }

            if (!int.TryParse(txt_Codigo.Text, out int codigo))
            {
                MessageBox.Show("Ingrese solo números.");
                txt_Codigo.Focus();
                return;
            }
            if (codigo < 100 || codigo > 999)
            {
                MessageBox.Show("El código debe ser un número de 3 cifras .");
                txt_Codigo.Focus();
                return;
            }

            string tipoEmpleado = "";
            if (codigo % 2 == 0 && codigo % 3 == 0 && codigo % 5 == 0)
                tipoEmpleado = "Administrativo";
            else if (codigo % 3 == 0 && codigo % 5 == 0 && codigo % 2 != 0)
                tipoEmpleado = "Directivo";
            else if (codigo % 2 == 0 && codigo % 3 != 0 && codigo % 5 != 0)
                tipoEmpleado = "Vendedor";
            else if (codigo % 2 != 0 && codigo % 3 != 0 && codigo % 5 != 0)
                tipoEmpleado = "Seguridad";
            else
                tipoEmpleado = "Otro";

            int fila = DATOS.Rows.Add();
            DATOS.Rows[fila].Cells[0].Value = contadorEmpleados + 1;
            DATOS.Rows[fila].Cells[1].Value = nombre;
            DATOS.Rows[fila].Cells[2].Value = codigo;
            DATOS.Rows[fila].Cells[3].Value = tipoEmpleado;

            contadorEmpleados++;

            txt_Nombre.Clear();
            txt_Codigo.Clear();
            txt_Nombre.Focus();

            if (contadorEmpleados >= totalEmpleados)
            {
                MessageBox.Show("Se ha alcanzado la cantidad de empleados registrada.");
                btn_Calcular.Enabled = false;
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Empleados.Clear();
            txt_Nombre.Clear();
            txt_Codigo.Clear();
            DATOS.Rows.Clear();
            txt_Empleados.Focus();
        }
    }
}
