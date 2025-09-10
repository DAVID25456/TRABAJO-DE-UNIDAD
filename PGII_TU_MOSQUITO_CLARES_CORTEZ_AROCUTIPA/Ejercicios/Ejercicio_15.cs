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
    public partial class Ejercicio_15 : Form
    {
        public Ejercicio_15()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtpalabra.Text))
            {
                MessageBox.Show("Debe ingresar una palabras para verificar el numero de ocurrencias","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            
            string text = txt_Texto.Text.Replace("\r", " ").ToLower();

            string palabra = txtpalabra.Text.ToLower();

            var arrTex = text.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

            int contador = 0;

            foreach (var item in arrTex)
            {
                if (item == palabra)
                {
                    contador++;
                }
            }

            lsb_ocurrencias.Items.Add($"La palabra '{palabra}' aparece {contador} veces en el texto.");
        }

        private void btninformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se desea implementar un programa que permita contar en número de ocurrencias de una palabra buscada. El texto puede estar formado por mayúsculas o minúsculas y puede contener signos de puntuación como (“,”, “;”,“.”), las palabras pueden estar separadas por espacios o saltos de línea.", "Informacion del Ejercicio 15", MessageBoxButtons.OK);
        }
    }
}
