using CiberKiosco.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberKiosco.Comun
{
    public interface IREpositorioProductos
    {
        void Agregar(Producto producto);
        void Borrar(int IdProducto);
        void Editar(Producto producto);
        bool Existe(Producto producto);
        int GetCantidad();
        Producto GetProductoPorId(int IdProducto);
        List<Producto> GetProductos();
    }
}
