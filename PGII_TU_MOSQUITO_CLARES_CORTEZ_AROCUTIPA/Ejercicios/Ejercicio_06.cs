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
    public partial class Ejercicio_06 : Form
    {
        double[,] notas = new double[,]
        {
            {3.2, 4.3, 4.8, 2.5},
            {4.1, 4.0, 4.2, 4.0},
            {3.7, 3.8, 4.5, 3.8},
            {3.8, 4.3, 4.4, 3.0}
        };
        string[] especialidades = { "Pediatría", "Ginecología", "Internista", "Neurología" };
        string[] turnos = { "Turno 1", "Turno 2", "Turno 3", "Turno 4" };

        public Ejercicio_06()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            string texto = "En una EPS los Especialistas trabajan en 4 turnos diarios y por cada uno de ellos se " +
                           "atiende 5 pacientes. Al finalizar la cita el paciente debe evaluar el servicio recibido " +
                           "en la escala de 1 a 5.\n\n" +
                           "Siendo:\n" +
                           "3.5 – Regular\n" +
                           "4.0 – Aceptable\n" +
                           "4.5 – Notable\n" +
                           "5.0 – Sobresaliente\n\n" +
                           "Al promediar las notas por Especialidad y Turno se obtiene la siguiente relación:\n\n" +

                           "           Pediatría   Ginecología   Internista   Neurología\n" +
                           "Turno 1      3.2          4.3          4.8          2.5\n" +
                           "Turno 2      4.1          4.0          4.2          4.0\n" +
                           "Turno 3      3.7          3.8          4.5          3.8\n" +
                           "Turno 4      3.8          4.3          4.4          3.0";

            MessageBox.Show(texto, "Ejercicio 01");
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            dgvNotas.Rows.Clear();
            dgvNotas.Columns.Clear();

            dgvNotas.ColumnCount = especialidades.Length;
            for (int i = 0; i < especialidades.Length; i++)
            {
                dgvNotas.Columns[i].Name = especialidades[i];
            }

            // Cargar datos en el DataGridView
            for (int fila = 0; fila < turnos.Length; fila++)
            {
                string[] row = new string[especialidades.Length];
                for (int col = 0; col < especialidades.Length; col++)
                {
                    row[col] = notas[fila, col].ToString("0.0");
                }
                dgvNotas.Rows.Add(row);
                dgvNotas.Rows[fila].HeaderCell.Value = turnos[fila];
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            // 1. Promedio por Especialidad
            double[] promediosEspecialidad = new double[especialidades.Length];
            for (int col = 0; col < especialidades.Length; col++)
            {
                double suma = 0;
                for (int fila = 0; fila < turnos.Length; fila++)
                {
                    suma += notas[fila, col];
                }
                promediosEspecialidad[col] = suma / turnos.Length;
                sb.AppendLine($"{especialidades[col]}: {promediosEspecialidad[col]:0.00}");
            }

            // 2. Turnos donde todos >= 4.0
            List<string> turnosBuenos = new List<string>();
            for (int fila = 0; fila < turnos.Length; fila++)
            {
                bool todosBuenos = true;
                for (int col = 0; col < especialidades.Length; col++)
                {
                    if (notas[fila, col] < 4.0)
                    {
                        todosBuenos = false;
                        break;
                    }
                }
                if (todosBuenos)
                    turnosBuenos.Add(turnos[fila]);
            }

            // 3. Mejor nota individual (máximo de la matriz)
            double mejorNota = double.MinValue;
            string mejorEspecialidad = "";
            string mejorTurno = "";
            for (int fila = 0; fila < turnos.Length; fila++)
            {
                for (int col = 0; col < especialidades.Length; col++)
                {
                    if (notas[fila, col] > mejorNota)
                    {
                        mejorNota = notas[fila, col];
                        mejorEspecialidad = especialidades[col];
                        mejorTurno = turnos[fila];
                    }
                }
            }

            // 4. Promedio general (toda la matriz)
            double sumaGeneral = 0;
            int totalNotas = 0;
            for (int fila = 0; fila < turnos.Length; fila++)
            {
                for (int col = 0; col < especialidades.Length; col++)
                {
                    sumaGeneral += notas[fila, col];
                    totalNotas++;
                }
            }
            double promedioGeneral = sumaGeneral / totalNotas;

            // --- Construir el resultado ---
            string resultado = "RESULTADOS:\n\n";

            // Turnos con todos >= 4
            if (turnosBuenos.Count > 0)
                resultado += "Turnos donde todos evaluaron >= 4.0:\n" + string.Join(", ", turnosBuenos) + "\n\n";
            else
                resultado += "No hubo turnos con todos >= 4.0\n\n";

            // Mejor especialidad y turno
            resultado += $"La mejor nota fue {mejorNota:0.0}, en {mejorEspecialidad}, durante {mejorTurno}\n\n";

            // Promedio general
            resultado += $"Promedio general de todas las evaluaciones: {promedioGeneral:0.00}\n\n";

            // Promedios por especialidad
            resultado += "Promedio por Especialidad:\n";
            for (int i = 0; i < especialidades.Length; i++)
            {
                resultado += $"{especialidades[i]}: {promediosEspecialidad[i]:0.00}\n";
            }

            MessageBox.Show(resultado, "Resultados del Ejercicio 06");
        }

        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvNotas.ColumnCount = especialidades.Length;
            for (int i = 0; i < especialidades.Length; i++)
            {
                dgvNotas.Columns[i].Name = especialidades[i];
            }

            // Cargar datos en el DataGridView
            for (int fila = 0; fila < turnos.Length; fila++)
            {
                string[] row = new string[especialidades.Length];
                for (int col = 0; col < especialidades.Length; col++)
                {
                    row[col] = notas[fila, col].ToString("0.0");
                }
                dgvNotas.Rows.Add(row);
                dgvNotas.Rows[fila].HeaderCell.Value = turnos[fila];
            }
        }
    }
}
