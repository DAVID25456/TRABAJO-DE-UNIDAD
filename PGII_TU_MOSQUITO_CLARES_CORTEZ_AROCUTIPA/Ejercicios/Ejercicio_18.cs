using Microsoft.Win32;
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
        public Ejercicio_18()
        {
            InitializeComponent();
        }

        private void btninformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Utilizando arrays implemente un formulario que permita realizar el registro de matrícula, el programa debe poder realizar:\n \n• Agregar o quitar cursos a matricular\n• El cálculo de créditos\n• El cálculo del monto a pagar en base a costo por crédito de cada curso por ciclo\n• Registrar, modificar la matricula\n• Generar la Ficha de Matricula", "Informacion del Ejercicio 18",MessageBoxButtons.OK);
        }


    }
}
