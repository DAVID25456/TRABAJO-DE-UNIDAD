using Microsoft.Win32;
using PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Clases.Ejercicio_18;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Ejercicios
{
    public partial class Ejercicio_18 : Form
    {
        cls_Estudiante ObjEstudiante = new cls_Estudiante();

        //Crear un array donde se almacenen los cursos
        //permitir que el list box de cursos lea el array

        public Ejercicio_18()
        {
            InitializeComponent();
        }

        private void btninformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Utilizando arrays implemente un formulario que permita realizar el registro de matrícula, el programa debe poder realizar:\n \n• Agregar o quitar cursos a matricular\n• El cálculo de créditos\n• El cálculo del monto a pagar en base a costo por crédito de cada curso por ciclo\n• Registrar, modificar la matricula\n• Generar la Ficha de Matricula", "Informacion del Ejercicio 18",MessageBoxButtons.OK);
        }

        private void txt_Nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo Puede ingresar letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txt_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo Puede ingresar letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //https://es.stackoverflow.com/questions/602391/permitir-copiar-y-pegar-n%C3%BAmeros-en-un-textbox-de-tipo-num%C3%A9rico-c

            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Solo Puede ingresar Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txt_Nombres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = true;
            }
        }
    }
}
