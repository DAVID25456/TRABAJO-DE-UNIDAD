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
    public partial class Ejercicio_14 : Form
    {
        

        public Ejercicio_14()
        {
            InitializeComponent();
        }

        private void btninformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Utilizando arras y elaborar un programa sobre un equipo de futbol debe controlar las estadísticas de sus jugadores y para ello requiere un sistema computacional. Los datos de cada jugador son el número de uniforme, nombre y su posición (portero, defensa, medio y delantero). Además, el equipo desea almacenar la cantidad de goles anotados por cada jugador (excepto el portero) y los minutos jugados", "Informacion del Ejercicio 14", MessageBoxButtons.OK);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rdb_portero_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_portero.Checked)
            {
                txt_Goles.Enabled = false;
            }
            else
            {
                txt_Goles.Enabled = true;
            }
        }

        private void txt__Num_Uniforme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar letras","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txt_Min_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txt_Goles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void btn_Capturar_Click(object sender, EventArgs e)
        {

        }
    }
}
