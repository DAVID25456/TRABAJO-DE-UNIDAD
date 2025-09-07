using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA
{
    public class clssCliente
    {
        //Propiedades del cliente
        public string Nombre { get; set; }
        public decimal Saldo { get; private set; }

        // Constructor que inicializa el nombre y el saldo en 0
        public clssCliente(string nombre)
        {
            Nombre = nombre;
            Saldo = 0;
        }

        // Método para depositar dinero
        public void Depositar(decimal cantidad)
        {
            if (cantidad > 0)
                // Suma el monto al saldo
                Saldo += cantidad;
        }

        // Método para retirar dinero
        public void Retirar(decimal cantidad)
        {
            if (cantidad > 0 && cantidad <= Saldo)
                // Resta el monto al saldo
                Saldo -= cantidad;
        }

        // Método que sobreescribe ToString para mostrar nombre y saldo
        //Uso Override para  mostrará el nombre y el saldo del objeto, en lugar del
        //comportamiento predeterminado de ToString() (que por defecto solo devuelve el nombre de la clase).
        public override string ToString()
        {
            return $"{Nombre} - Saldo: ${Saldo}";
        }
    }
}
