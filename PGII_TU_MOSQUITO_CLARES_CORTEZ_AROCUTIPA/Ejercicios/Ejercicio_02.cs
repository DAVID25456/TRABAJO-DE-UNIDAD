using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Clases.Ejercicio_02;

namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Ejercicios
{
    public partial class Ejercicio_02 : Form
    {
        private List<Contacto> contactos = new List<Contacto>();

        public Ejercicio_02()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agenda de Contactos con Clase Contacto\r\n• Crear clase Contacto con propiedades Nombre, Teléfono, Email.\r\n• En el formulario, permitir agregar contactos y mostrarlos en un\r\nDataGridView.\r\n• Agregar opción de eliminar y buscar por nombre");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }

            // Validar que solo tenga 9 dígitos
            if (txtTelefono.Text.Length != 9 || !txtTelefono.Text.All(char.IsDigit))
            {
                MessageBox.Show("El teléfono debe contener exactamente 9 números.");
                return;
            }

            Contacto nuevo = new Contacto()
            {
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text
            };

            contactos.Add(nuevo);
            RefrescarGrid();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.CurrentRow != null)
            {
                Contacto seleccionado = (Contacto)dgvContactos.CurrentRow.DataBoundItem;
                contactos.Remove(seleccionado);
                RefrescarGrid();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text.ToLower();
            var resultado = contactos.Where(c => c.Nombre.ToLower().Contains(criterio)).ToList();
            dgvContactos.DataSource = null;
            dgvContactos.DataSource = resultado;
        }

        private void RefrescarGrid()
        {
            dgvContactos.DataSource = null;
            dgvContactos.DataSource = contactos;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        private void Ejercicio_02_Load(object sender, EventArgs e)
        {
            dgvContactos.DataSource = null;
            dgvContactos.DataSource = contactos;
        }
    }
}
