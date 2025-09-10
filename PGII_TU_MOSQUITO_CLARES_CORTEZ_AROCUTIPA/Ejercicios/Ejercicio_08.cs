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
    public partial class Ejercicio_08 : Form
    {
        public Ejercicio_08()
        {
            InitializeComponent();
        }

        private void btninformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elaborar el siguiente juego: Truco o Trato Este es un reto especial por Halloween. Deberemos crear un programa al que le indiquemos si queremos realizar \"Truco o Trato\" y un listado (array) de personas con las siguientes propiedades: • Nombre de la niña o niño • Edad • Altura en centímetros Si las personas han pedido truco, el programa retornará sustos (aleatorios) siguiendo estos criterios: • Un susto por cada 2 letras del nombre por persona • Dos sustos por cada edad que sea un número par • Tres sustos por cada 100 cm de altura entre todas las personas • Sustos: 🎃👻💀🕷 🕸\U0001f987 Si las personas han pedido trato, el programa retornará dulces (aleatorios) siguiendo estos criterios: • Un dulce por cada letra de nombre • Un dulce por cada 3 años cumplidos hasta un máximo de 10 años por persona • Dos dulces por cada 50 cm de altura hasta un máximo de 150 cm por persona • Dulces: 🍰🍬🍡🍭🍪🍫\U0001f9c1🍩 En caso contrario retornará un error.", "Informacion del Ejercicio 08", MessageBoxButtons.OK);
        }

        private void btn_Sortear_Click(object sender, EventArgs e)
        {
            string nombre = Txt_Nombre.Text.Trim();
            string edadTxt = Txt_Edad.Text.Trim();
            string alturaTxt = Txt_Altura.Text.Trim();

            if (edadTxt.Length > 3)
            {
                MessageBox.Show("La edad no puede tener más de 3 dígitos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (alturaTxt.Length > 3)
            {
                MessageBox.Show("La altura no puede tener más de 3 dígitos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToInt32(Txt_Edad.Text) > 100)
            {
                MessageBox.Show("Ninguna wawita vive mas de 100 años");
                return;
            }

            lis_Resultado.Items.Clear();

            if (nombre == "" || edadTxt == "" || alturaTxt == "")
            {
                MessageBox.Show("Complete todos los datos!.");
                return;
            }

            for (int i = 0; i < nombre.Length; i++)
            {
                if (char.IsDigit(nombre[i]))
                {
                    MessageBox.Show("Solo se aceptan letras.");
                    return;
                }
            }

            for (int i = 0; i < edadTxt.Length; i++)
            {
                if (!char.IsDigit(edadTxt[i]))
                {
                    MessageBox.Show("Solo se aceptan números.");
                    return;
                }
            }

            for (int i = 0; i < alturaTxt.Length; i++)
            {
                if (!char.IsDigit(alturaTxt[i]))
                {
                    MessageBox.Show("Solo se aceptan números.");
                    return;
                }
            }

            int edad = int.Parse(edadTxt);
            int altura = int.Parse(alturaTxt);

            switch (combo_Opcion.Text.Trim())
            {
                case "Truco":
                case "truco":
                case "TRUCO":
                    List<string> sustos = GenerarTruco(nombre, edad, altura);
                    lis_Resultado.Items.Add("😱 Sustos recibidos:");
                    lis_Resultado.Items.Add(string.Join(" ", sustos));
                    break;

                case "Trato":
                case "trato":
                case "TRATO":
                    List<string> dulces = GenerarTrato(nombre, edad, altura);
                    lis_Resultado.Items.Add("😋 Dulces recibidos:");
                    lis_Resultado.Items.Add(string.Join(" ", dulces));
                    break;

                default:
                    MessageBox.Show("Seleccione Truco o Trato.");
                    break;
            }
        }

        private List<string> GenerarTruco(string nombre, int edad, int altura)
        {
            string[] sustosPosibles = { "🎃", "👻", "💀", "🕷", "🕸", "🦇" };
            Random rnd = new Random();
            List<string> sustos = new List<string>();

            sustos.AddRange(Enumerable.Range(0, nombre.Length / 2)
                .Select(_ => sustosPosibles[rnd.Next(sustosPosibles.Length)]));

            if (edad % 2 == 0)
            {
                sustos.Add(sustosPosibles[rnd.Next(sustosPosibles.Length)]);
                sustos.Add(sustosPosibles[rnd.Next(sustosPosibles.Length)]);
            }

            int cantidad = altura / 100 * 3;
            for (int i = 0; i < cantidad; i++)
            {
                sustos.Add(sustosPosibles[rnd.Next(sustosPosibles.Length)]);
            }

            return sustos;
        }

        private List<string> GenerarTrato(string nombre, int edad, int altura)
        {
            string[] dulcesPosibles = { "🍰", "🍬", "🍡", "🍭", "🍪", "🍫", "🧁", "🍩" };
            Random rnd = new Random();
            List<string> dulces = new List<string>();

            foreach (char _ in nombre)
                dulces.Add(dulcesPosibles[rnd.Next(dulcesPosibles.Length)]);

            int dulcesEdad = Math.Min(edad / 3, 10);
            for (int i = 0; i < dulcesEdad; i++)
                dulces.Add(dulcesPosibles[rnd.Next(dulcesPosibles.Length)]);

            int dulcesAltura = Math.Min(altura, 150) / 50 * 2;
            for (int i = 0; i < dulcesAltura; i++)
                dulces.Add(dulcesPosibles[rnd.Next(dulcesPosibles.Length)]);

            return dulces;
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_Nombre.Clear();
            Txt_Edad.Clear();
            Txt_Altura.Clear();
            combo_Opcion.SelectedIndex = -1;
            lis_Resultado.Items.Clear();
        }
    }
}
