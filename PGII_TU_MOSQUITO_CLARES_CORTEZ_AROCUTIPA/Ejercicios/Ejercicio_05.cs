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
    public partial class Ejercicio_05 : Form
    {
        int contador = 1;

        public Ejercicio_05()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elaborar un programa que permita calcular la calificación final de 5 estudiantes,\r\nteniendo en cuenta los criterios de evaluación son:\r\na. Práctica 30%\r\nb. Trabajos encargados 30%\r\nc. Examen final 40%\r\nEl estudiante se considerará aprobado si la calificación es mayor a 10 y menor\r\nigual a 20, si la calificación es mayor a 2 y menor igual a 10 será desaprobado,\r\ncaso contrario deberá mostrar como Abandono. (usar la estructura While) ");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            while (contador <= 5)
            {
                try
                {
                    double practica = double.Parse(txtPractica.Text);
                    double trabajos = double.Parse(txtTrabajos.Text);
                    double examen = double.Parse(txtExamen.Text);

                    if (practica < 0 || practica > 20 ||
                        trabajos < 0 || trabajos > 20 ||
                        examen < 0 || examen > 20)
                    {
                        MessageBox.Show("Las notas deben estar entre 0 y 20.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    double notaFinal = (practica * 0.3) + (trabajos * 0.3) + (examen * 0.4);


                    string resultado;
                    if (notaFinal > 10 && notaFinal <= 20)
                        resultado = "Aprobado ✅";
                    else if (notaFinal > 2 && notaFinal <= 10)
                        resultado = "Desaprobado ❌";
                    else
                        resultado = "Abandono ⚠️";


                    lstResultados.Items.Add($"Estudiante {contador}: Nota Final = {notaFinal:F2} → {resultado}");


                    contador++;

                    txtPractica.Clear();
                    txtTrabajos.Clear();
                    txtExamen.Clear();

                    break;
                }
                catch
                {
                    MessageBox.Show("Error: Ingrese solo números válidos en las notas.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (contador > 5)
            {
                MessageBox.Show("Ya se ingresaron las notas de los 5 estudiantes.",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
