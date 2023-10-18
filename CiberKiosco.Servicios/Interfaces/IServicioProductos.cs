using CiberKiosco.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberKiosco.Servicios.Interfaces
{
    public interface IServicioProductos
    {
        void Guardar(Producto producto);
        void Borrar(int IdProducto);
        bool Existe(Producto producto);
        int GetCantidad();
        List<Producto> GetProductos();
        Producto GetProductoPorId(int IdProducto);
    }
}
