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
    public partial class Ejercicio_03 : Form
    {
        public Ejercicio_03()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En una matriz A de N x 5, se encuentran almacenadas las calificaciones de 5 cursos\r\nde un grupo de N estudiantes. Calcular:\r\na. La nota promedio de cada estudiante\r\nb. El número de estudiantes que aprobaron cada curso\r\nc. El número de estudiantes que desaprobaron cada curso\r\nd. La nota promedio de cada curso.\r\n");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int N = (int)numEstudiantes.Value;

            dgvNotas.Columns.Clear();
            dgvNotas.Rows.Clear();


            for (int j = 0; j < 5; j++)
                dgvNotas.Columns.Add("Curso" + (j + 1), "Curso " + (j + 1));

            dgvNotas.Rows.Add(N);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int N = dgvNotas.Rows.Count;
            int M = dgvNotas.Columns.Count;

            double[,] A = new double[N, M];


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (dgvNotas.Rows[i].Cells[j].Value != null &&
                        double.TryParse(dgvNotas.Rows[i].Cells[j].Value.ToString(), out double nota))
                    {
                        A[i, j] = nota;
                    }
                    else
                    {
                        A[i, j] = 0;
                    }
                }
            }

            // Resultados
            txtResultados.Clear();
            txtResultados.AppendText("=== Promedio de cada estudiante ===\r\n");
            for (int i = 0; i < N; i++)
            {
                double promedio = 0;
                for (int j = 0; j < M; j++)
                    promedio += A[i, j];
                promedio /= M;
                txtResultados.AppendText($"Estudiante {i + 1}: {promedio:F2}\r\n");
            }

            txtResultados.AppendText("\r\n=== Aprobados / Desaprobados por curso ===\r\n");
            for (int j = 0; j < M; j++)
            {
                int aprobados = 0, desaprobados = 0;
                for (int i = 0; i < N; i++)
                {
                    if (A[i, j] >= 11) aprobados++;
                    else desaprobados++;
                }
                txtResultados.AppendText($"Curso {j + 1}: Aprobados = {aprobados}, Desaprobados = {desaprobados}\r\n");
            }

            txtResultados.AppendText("\r\n=== Promedio de cada curso ===\r\n");
            for (int j = 0; j < M; j++)
            {
                double suma = 0;
                for (int i = 0; i < N; i++)
                    suma += A[i, j];
                double promedioCurso = suma / N;
                txtResultados.AppendText($"Curso {j + 1}: {promedioCurso:F2}\r\n");
            }
        }
    }
}
