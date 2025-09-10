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
    public partial class Ejercicio_04 : Form
    {
        public Ejercicio_04()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Realizar un programa que permita calcular el pago de 5 trabajadores, cantidad de\r\nhoras trabajadas, cantidad de horas extras y el total que debe pagar por\r\ntrabajador y el total a los 5 trabajadores, teniendo en cuenta que el pago por hora\r\nes 20 soles, el pago por horas extras es 25 soles. Si el usuario ingresa un valor\r\nnegativo o cero el programa deberá mostrar un mensaje de error. (usar la\r\nestructura FOR)");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double totalGeneral = 0;

            lstResultados.Items.Clear(); // limpiar resultados previos

            for (int i = 1; i <= 5; i++)
            {
                try
                {
                    // Solicitar datos al usuario con InputBox
                    string inputHoras = Microsoft.VisualBasic.Interaction.InputBox(
                        $"Ingrese las horas trabajadas del Trabajador {i}:",
                        "Horas trabajadas", "0");

                    string inputExtras = Microsoft.VisualBasic.Interaction.InputBox(
                        $"Ingrese las horas extras del Trabajador {i}:",
                        "Horas extras", "0");

                    double horas = double.Parse(inputHoras);
                    double extras = double.Parse(inputExtras);

                    // Validación
                    if (horas <= 0 || extras < 0)
                    {
                        MessageBox.Show("Error: No se permiten valores negativos o cero en horas trabajadas.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        i--; // repetir el ciclo para el mismo trabajador
                        continue;
                    }

                    // Cálculos
                    double pagoNormal = horas * 20;
                    double pagoExtra = extras * 25;
                    double pagoTotal = pagoNormal + pagoExtra;

                    totalGeneral += pagoTotal;

                    // Mostrar en ListBox
                    lstResultados.Items.Add($"Trabajador {i}: Horas {horas}, Extras {extras}, Pago Total: S/. {pagoTotal:F2}");
                }
                catch
                {
                    MessageBox.Show("Entrada inválida. Ingrese solo números.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    i--; // repetir el ciclo
                }
            }

            lstResultados.Items.Add("------------------------------------");
            lstResultados.Items.Add($"Total a pagar a los 5 trabajadores: S/. {totalGeneral:F2}");
        }
    }
}
