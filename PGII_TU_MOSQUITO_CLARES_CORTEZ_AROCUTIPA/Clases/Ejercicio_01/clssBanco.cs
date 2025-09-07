using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA
{
    public class clssBanco
    {
        public List<clssCliente> Clientes { get; set; }

        // Constructor que crea 3 clientes por defecto
        public clssBanco()
        {
            Clientes = new List<clssCliente>
        {
            new clssCliente("Cliente 1"),
            new clssCliente("Cliente 2"),
            new clssCliente("Cliente 3")
        };
        }

        // Método para calcular el total de todos los saldos
        public decimal CalcularTotalDepositos()
        {
            return Clientes.Sum(c => c.Saldo);
        }
    }
}
