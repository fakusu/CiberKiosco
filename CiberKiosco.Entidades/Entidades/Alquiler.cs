using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberKiosco.Entidades.Entidades
{
    public class Alquiler
    {
        public Alquiler(int idAlquiler, int idCliente, int idComputadora, DateTime horaInicio, DateTime horaFin, decimal precio)
        {
            IdAlquiler = idAlquiler;
            IdCliente = idCliente;
            IdComputadora = idComputadora;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
            Precio = precio;
        }

        public int IdAlquiler { get; set; }
        public int IdCliente { get; set; }
        public int IdComputadora { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public decimal Precio { get; set; }  
    }
}
