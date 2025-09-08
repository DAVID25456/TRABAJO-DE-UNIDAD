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
    public partial class Ejercicio_16 : Form
    {
        public Ejercicio_16()
        {
            InitializeComponent();
        }

        private void btninformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Crear un programa que mediante que permita reservar o cancelar asientos de un avión, así como mostrar qué asientos están ocupados y libres actualmente. Debe implementar\n \nCrear los asientos utilizando arrays obteniendo 25 filas y 3 columnas \nReservar Asientos \nCambiar de Asiento \nCancelar Reserva", "Informacion del Ejercicio 16", MessageBoxButtons.OK);
        }
    }
}
