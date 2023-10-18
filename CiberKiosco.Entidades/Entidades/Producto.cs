using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberKiosco.Entidades.Entidades
{
    public class Producto : ICloneable
    {
        public Producto(int idProducto, string nombreProducto, decimal precioUnitario, int stock)
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            PrecioUnitario = precioUnitario;
            Stock = stock;
        }

        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Stock { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();   
        }
    }
}
