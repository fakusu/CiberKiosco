using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberKiosco.Entidades.Dtos
{
    public class ProductoListDto : ICloneable
    {
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
