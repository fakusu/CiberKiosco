using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberKiosco.Entidades.Entidades
{
    public class Computadora
    {
        public Computadora(int id, int nroComputadora)
        {
            Id = id;
            NroComputadora = nroComputadora;
        }

        public int Id { get; set; }
        public int NroComputadora { get; set; }

    }
}
