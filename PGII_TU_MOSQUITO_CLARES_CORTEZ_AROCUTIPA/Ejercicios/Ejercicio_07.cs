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
    public partial class Ejercicio_07 : Form
    {
        public Ejercicio_07()
        {
            InitializeComponent();
        }

        private void btninformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se pide repetidamente una palabra, se cuenta el número de vocales de la palabra si el número de vocales es par, se pide una frase, se convierte en mayúsculas. Si el número de vocales es impar pida una palabra y halle la longitud de la misma.", "Informacion del Ejercicio 07", MessageBoxButtons.OK);
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            string palabra = txt_palabra.Text.Trim();

            if (palabra == "")
            {
                MessageBox.Show("Ingrese una palabra.");
                return;
            }

            for (int i = 0; i < palabra.Length; i++)
            {
                if (char.IsDigit(palabra[i]))
                {
                    MessageBox.Show("No se permiten números, solo letras.");
                    return;
                }
            }

            int contadorVocales = 0;
            palabra = palabra.ToLower();

            for (int i = 0; i < palabra.Length; i++)
            {
                char c = palabra[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    contadorVocales++;
                }
            }

            if (contadorVocales % 2 == 0)
            {
                lis_Resultado.Items.Add("Frase en mayúsculas: " + palabra.ToUpper());
            }
            else
            {
                lis_Resultado.Items.Add("La longitud de la palabra es: " + palabra.Length);
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_palabra.Clear();
            lis_Resultado.Items.Clear();
        }

        private void txt_palabra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
    }
}
