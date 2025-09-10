using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGII_TU_MOSQUITO_CLARES_CORTEZ_AROCUTIPA.Clases.Ejercicio_19
{
    internal class cls_Producto
    {
        private string Numero;
        private string Producto;
        private string Categoria;
        private double Precio;
        private int Cantidad;


        public string numero { get; set; }
        public string producto { get; set; }
        public string categoria { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }


        public double Sub_Total()
        {
            double Total = precio * Convert.ToDouble(cantidad);
            return Total;
        }
    }
}
