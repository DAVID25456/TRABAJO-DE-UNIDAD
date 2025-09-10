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
    public partial class Ejercicio_13 : Form
    {
        int cant_niños = 0, cant_adult = 0;
        int cant_total;

        int cant_pepsi = 0, cant_coca_cola = 0, cant_fanta = 0, cant_crush = 0; 

        public Ejercicio_13()
        {
            InitializeComponent();

            grb_gaseosas.Enabled = false;

            btnRespuesta.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btninformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Diseñe un programa para encuestar a un grupo de personas de diferentes edades acerca de sus preferencias en bebidas gaseosas entre Pepsi Cola, Coca Cola, Fanta y Crush. El resultado se debe mostrar en un GriView. La empresa encuestadora desea saber lo siguiente:\n  \n- Cuántas personas en total, prefieren cada tipo de gaseosa \n- Cuántas personas fueron encuestadas en cada rango de edades \n- Se pide agregar una columna al costado de cada marca de gaseosa que muestra el porcentaje respectivo", "Informacion del Ejercicio 13",MessageBoxButtons.OK);
        }

        private void btnEncuesta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtedad.Text))
            {
                MessageBox.Show("Debe ingresar la edad para realizar la encuenta","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            int edad = Convert.ToInt32(txtedad.Text);

            if (edad >= 100)
            {
                MessageBox.Show("Tienes mas de 100 años????", "Imposible",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
            else
            {
                grb_gaseosas.Enabled = true;
                txtedad.Enabled = false;

                btnRespuesta.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        
        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void resetearCheckBox()
        {
            if (chb_Pepsi_Cola.Checked)
            {
                chb_Pepsi_Cola.Checked = false;
            }

            if (chb_Coca_Cola.Checked)
            {
                chb_Coca_Cola.Checked = false;
            }

            if (chb_Fanta.Checked)
            {
                chb_Fanta.Checked = false;
            }

            if (chb_Crush.Checked)
            {
                chb_Crush.Checked = false;
            }
        }

        private void btnRespuesta_Click(object sender, EventArgs e)
        {
            if (!chb_Coca_Cola.Checked && !chb_Pepsi_Cola.Checked && !chb_Fanta.Checked && !chb_Crush.Checked)
            {
                MessageBox.Show("Debe elegir algun valor","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToInt32(txtedad.Text) <18)
            {
                cant_niños++;
                txtniños.Clear();
                txtniños.Text = cant_niños.ToString();
            }
            else
            {
                cant_adult++;
                txtadultos.Clear();
                txtadultos.Text = cant_adult.ToString();
            }

            txttotal.Clear();
            cant_total = cant_niños + cant_adult;
            txttotal.Text = cant_total.ToString();

            if (chb_Pepsi_Cola.Checked)
            {
                cant_pepsi++;
            }

            if (chb_Coca_Cola.Checked)
            {
                cant_coca_cola++;
                
            }

            if (chb_Fanta.Checked)
            {
                cant_fanta++;
            }

            if (chb_Crush.Checked)
            {
                cant_crush++;
            }

            double promedio_Pepsi = (cant_pepsi * 100) / cant_total;
            double promedio_Coca_cola = (cant_coca_cola * 100) / cant_total;
            double promedio_Fanta = (cant_fanta * 100) / cant_total;
            double promedio_Crush = (cant_crush * 100) / cant_total;

            resetearCheckBox();

            grb_gaseosas.Enabled = false;
            btnCancelar.Enabled = false;
            btnRespuesta.Enabled = false;

            chb_Coca_Cola.Checked = false;

            dgv_gaseosas.Rows.Clear();
            dgv_gaseosas.Rows.Add("Pepsi Cola", cant_pepsi, promedio_Pepsi.ToString("F2") + "%");
            dgv_gaseosas.Rows.Add("Coca Cola", cant_coca_cola, promedio_Coca_cola.ToString("F2") + "%");
            dgv_gaseosas.Rows.Add("Fanta", cant_fanta, promedio_Fanta.ToString("F2") + "%");
            dgv_gaseosas.Rows.Add("Crush", cant_crush, promedio_Crush.ToString("F2") + "%");

            txtedad.Clear();
            txtedad.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Esta seguro que desea cancelar su respuesta","Pregunta",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
            {
                grb_gaseosas.Enabled = false;
                btnRespuesta.Enabled = false;
                txtedad.Clear();
                txtedad.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
