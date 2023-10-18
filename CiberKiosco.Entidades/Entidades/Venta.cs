using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberKiosco.Entidades.Entidades
{
    public class Venta
    {
        public Venta(int idVenta, DateTime fechaVenta, decimal total, int alquilerId)
        {
            IdVenta = idVenta;
            FechaVenta = fechaVenta;
            Total = total;
            AlquilerId = alquilerId;
        }

        public int IdVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }
        public int AlquilerId { get; set; }
    }
}
