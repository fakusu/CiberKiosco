using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberKiosco.Entidades.Entidades
{
    public class Socio:Persona
    {
        public int NumeroSocio { get; set; }

        public Socio(string nombre, string apellido, string direccion, string dni, int numeroSocio)
            : base(nombre, apellido, direccion, dni)
        {
            NumeroSocio = numeroSocio;
        }
    }
}
