using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberKiosco.Entidades.Entidades
{
    public class Cliente:Persona
    {
        public Cliente(string nombre, string apellido, string direccion)
      : base(nombre, apellido, "N/A", "N/A")
        {
            // DNI se establece como "N/A" para los clientes comunes
        }
    }
}
