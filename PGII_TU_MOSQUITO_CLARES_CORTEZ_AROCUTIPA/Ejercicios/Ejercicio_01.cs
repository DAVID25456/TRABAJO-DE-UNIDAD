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
    public partial class Ejercicio_01 : Form
    {
        private clssBanco banco;
        public Ejercicio_01()
        {
            banco = new clssBanco();
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Un banco tiene 3 clientes que pueden hacer depósitos y retiros; el banco requiere\r\nque al final del día calcule la cantidad de dinero que hay depositada.\r\nLa Solución deberá tener dos clases (cliente, banco).\r\n");
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada(out clssCliente cliente, out decimal monto))
            {
                cliente.Depositar(monto);
                ActualizarListaClientes();// Actualiza lista con nuevo saldo
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada(out clssCliente cliente, out decimal monto))
            {
                cliente.Retirar(monto);
                ActualizarListaClientes(); // Actualiza lista con nuevo saldo
            }
        }

        private void btnTotalBanco_Click(object sender, EventArgs e)
        {
            decimal total = banco.CalcularTotalDepositos();//obtiene el total
            MessageBox.Show($"Total de dinero en el banco: ${total}", "Banco");
        }

        // Método para validar la entrada del usuario (cliente y monto)
        private bool ValidarEntrada(out clssCliente clienteSeleccionado, out decimal monto)
        {
            clienteSeleccionado = null;
            monto = 0;

            // Verifica que se haya seleccionado un cliente
            if (cmbClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cliente.");
                return false;
            }

            // Verifica que el monto ingresado sea válido y positivo
            if (!decimal.TryParse(txtMonto.Text, out monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido.");
                return false;
            }

            // Busca el cliente por nombre
            string nombre = cmbClientes.SelectedItem.ToString();
            clienteSeleccionado = banco.Clientes.Find(c => c.Nombre == nombre);
            return true;
        }

        // Método para actualizar la lista visual de saldos
        private void ActualizarListaClientes()
        {
            lstClientes.Items.Clear();// Limpia lista anterior
            foreach (var cliente in banco.Clientes)
            {
                lstClientes.Items.Add(cliente.ToString());// Agrega nuevo estado
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MDIParent1 mdi = new MDIParent1();
            mdi.Show();
            this.Hide();
        }
    }
}
