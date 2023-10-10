using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberKiosco.Entidades.Entidades
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string DNI { get; set; }

        public Persona(string nombre, string apellido, string direccion, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            DNI = dni;
        }
    }
}
