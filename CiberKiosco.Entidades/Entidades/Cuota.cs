using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberKiosco.Entidades.Entidades
{
    public class Cuota
    {
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }

        public Cuota(DateTime fecha, decimal monto)
        {
            Fecha = fecha;
            Monto = monto;
        }

        public override string ToString()
        {
            return $"Fecha: {Fecha.ToShortDateString()}, Monto: {Monto:C}";
        }
    }
}
