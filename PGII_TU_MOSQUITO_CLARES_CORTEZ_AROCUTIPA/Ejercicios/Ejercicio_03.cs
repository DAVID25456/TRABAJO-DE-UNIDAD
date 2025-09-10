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

            dgvNotas.ColumnCount = 5;
            dgvNotas.ColumnHeadersVisible = true;


            dgvNotas.Columns[0].HeaderText = "Curso 1";
            dgvNotas.Columns[1].HeaderText = "Curso 2";
            dgvNotas.Columns[2].HeaderText = "Curso 3";
            dgvNotas.Columns[3].HeaderText = "Curso 4";
            dgvNotas.Columns[4].HeaderText = "Curso 5";
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            int N = dgvNotas.RowCount;
            int M = dgvNotas.ColumnCount;

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

            lstResultados.Items.Clear();


            lstResultados.Items.Add("Promedio por estudiante:");
            for (int i = 0; i < N; i++)
            {
                double suma = 0;
                for (int j = 0; j < M; j++)
                {
                    suma += A[i, j];
                }
                double promedio = suma / M;
                lstResultados.Items.Add($"Estudiante {i + 1}: {promedio:F2}");
            }


            lstResultados.Items.Add("\nAprobados por curso:");
            for (int j = 0; j < M; j++)
            {
                int contador = 0;
                for (int i = 0; i < N; i++)
                {
                    if (A[i, j] >= 10.5) contador++;
                }
                lstResultados.Items.Add($"Curso {j + 1}: {contador} aprobaron");
            }


            lstResultados.Items.Add("\nReprobados por curso:");
            for (int j = 0; j < M; j++)
            {
                int contador = 0;
                for (int i = 0; i < N; i++)
                {
                    if (A[i, j] < 10.5) contador++;
                }
                lstResultados.Items.Add($"Curso {j + 1}: {contador} reprobaron");
            }

            lstResultados.Items.Add("\nPromedio por curso:");
            for (int j = 0; j < M; j++)
            {
                double suma = 0;
                for (int i = 0; i < N; i++)
                {
                    suma += A[i, j];
                }
                double promedio = suma / N;
                lstResultados.Items.Add($"Curso {j + 1}: {promedio:F2}");
            }
        }
    }
}
