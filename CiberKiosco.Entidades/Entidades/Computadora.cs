using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberKiosco.Entidades.Entidades
{
    public class Computadora
    {
        public Computadora(int idComputadora, int nroComputadora)
        {
            IdComputadora = idComputadora;
            NroComputadora = nroComputadora;
        }

        public int IdComputadora { get; set; }
        public int NroComputadora { get; set; }

    }
}
