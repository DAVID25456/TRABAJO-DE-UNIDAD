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
using System.Xml.Linq;

namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Ejercicios
{
    public partial class Ejercicio_18 : Form
    {
        cls_Estudiante ObjEstudiante = new cls_Estudiante();

        string[] cursos = {"Matematica [4]","Comunicacion [3]","Historia [5]","Biologia [3]"};

        public Ejercicio_18()
        {
            InitializeComponent();

            for (int i = 0; i < cursos.Length; i++)
            {
                lst_Cursos.Items.Add(cursos[i]);
            }
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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Nombres.Text) || 
                string.IsNullOrEmpty(txt_Apellidos.Text) || 
                string.IsNullOrEmpty(txt_Codigo.Text))
            {
                MessageBox.Show("Debe agregar primero los datos del estudiante");
                return;
            }

            ObjEstudiante.nombres = txt_Nombres.Text;
            ObjEstudiante.apellidos = txt_Apellidos.Text;
            ObjEstudiante.codigo = txt_Codigo.Text;

            foreach (string elemento in lst_Cursos.SelectedItems)
            {
                if (!lst_Cursos_Matricula.Items.Contains(elemento))
                {
                    lst_Cursos_Matricula.Items.Add(elemento);
                }
                else
                {
                    MessageBox.Show($"El curso '{elemento}' ya está en la matrícula.");
                }
            }
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            int indice = lst_Cursos_Matricula.SelectedIndex;

            if (indice != -1)
            {
                lst_Cursos_Matricula.Items.RemoveAt(indice);
            }
            else
            {
                MessageBox.Show("Selecciona un elemento para eliminar");
            }


        }

        private void btn_Generar_Matricula_Click(object sender, EventArgs e)
        {
            foreach (string elemento in lst_Cursos_Matricula.SelectedItems)
            {
                switch (elemento)
                {
                    case : 
                }
            }
        }
    }
}
