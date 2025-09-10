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
    public partial class Ejercicio_09 : Form
    {
        public Ejercicio_09()
        {
            InitializeComponent();
        }

        private void btninformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Crear un programa que muestre los números de 1 a 100 (ambos incluidos y con un\r\nsalto de línea entre cada impresión), sustituyendo los siguientes:\r\n• Múltiplos de 7 por la palabra \"fizz\".\r\n• Múltiplos de 3 por la palabra \"buzz\".\r\n• Múltiplos de 7 y de 3 a la vez por la palabra \"fizzbuzz\".", "Informacion del Ejercicio 09", MessageBoxButtons.OK);
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            lis_Original.Items.Clear();

            for (int fila = 0; fila < 25; fila++)
            {
                string linea = "";
                for (int col = 0; col < 4; col++)
                {
                    int num = fila + (col * 25) + 1;
                    linea += num.ToString().PadLeft(5);
                }
                lis_Original.Items.Add(linea);
            }
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            lis_Resultado.Items.Clear();

            for (int fila = 0; fila < 25; fila++)
            {
                string linea = "";

                for (int col = 0; col < 4; col++)
                {
                    int num = fila + (col * 25) + 1;
                    string texto = num.ToString();


                    if (num % 3 == 0 && num % 7 == 0)
                        texto += " == fizzbuzz";
                    else if (num % 7 == 0)
                        texto += " == fizz";
                    else if (num % 3 == 0)
                        texto += " == buzz";

                    linea += texto.PadRight(20);
                }

                lis_Resultado.Items.Add(linea);
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            lis_Original.Items.Clear();
            lis_Resultado.Items.Clear();
        }
    }
}
