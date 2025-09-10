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
    public partial class Ejercicio_10 : Form
    {
        const double PagoHora = 15.0;
        int contador = 0;
        double totalGeneral = 0;

        public Ejercicio_10()
        {
            InitializeComponent();
        }

        private void btninformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Realizar un programa que permita calcular el pago de 5 trabajadores, cantidad de\r\nhoras trabajadas y el total que debe pagar por trabajador y el total a los 5\r\ntrabajadores, teniendo en cuenta que el pago por hora es 15 soles. Si el usuario\r\ningresa un valor negativo o cero el programa deberá mostrar un mensaje de error\r\nusando vectores.", "Informacion del Ejercicio 10", MessageBoxButtons.OK);
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            string nombre = txt_NombreTrabajador.Text.Trim();
            string horasTxt = txt_HorasTrabajadas.Text.Trim();

            if (nombre == "" || horasTxt == "")
            {
                MessageBox.Show("Ingrese todos los datos!!.");
                return;
            }


            for (int i = 0; i < nombre.Length; i++)
            {
                if (char.IsDigit(nombre[i]))
                {
                    MessageBox.Show("Ingrese solo texto.");
                    return;
                }
            }


            for (int i = 0; i < horasTxt.Length; i++)
            {
                if (!char.IsDigit(horasTxt[i]))
                {
                    MessageBox.Show("Las horas trabajadas deben ser números enteros positivos.");
                    return;
                }
            }

            int horas = int.Parse(horasTxt);

            if (horas <= 0)
            {
                MessageBox.Show("Las horas debe ser mayor a cero.");
                return;
            }

            double pago = horas * PagoHora;

            DATOS.Rows.Add(nombre, horas, "S/. " + pago);

            totalGeneral += pago;
            contador++;

            if (contador == 5)
            {
                lis_Resultado.Items.Clear();

                string nombres = "";
                for (int i = 0; i < DATOS.Rows.Count; i++)
                {
                    if (DATOS.Rows[i].Cells[0].Value != null)
                    {
                        nombres += DATOS.Rows[i].Cells[0].Value.ToString() + ", ";
                    }
                }

                if (nombres.EndsWith(", "))
                {
                    nombres = nombres.Substring(0, nombres.Length - 2);
                }

                lis_Resultado.Items.Add("El pago completo de los 5 trabajadores:");
                lis_Resultado.Items.Add(nombres + " es: S/. " + totalGeneral);
            }

            txt_NombreTrabajador.Clear();
            txt_HorasTrabajadas.Clear();
            txt_NombreTrabajador.Focus();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            DATOS.Rows.Clear();
            lis_Resultado.Items.Clear();
            txt_NombreTrabajador.Clear();
            txt_HorasTrabajadas.Clear();
            totalGeneral = 0;
            contador = 0;
        }
    }
}
