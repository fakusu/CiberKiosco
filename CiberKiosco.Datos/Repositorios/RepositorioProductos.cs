using CiberKiosco.Comun;
using CiberKiosco.Entidades.Dtos;
using CiberKiosco.Entidades.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberKiosco.Datos
{
    public class RepositorioProductos : IREpositorioProductos
    {
        private readonly string cadenaConexion;
        public RepositorioProductos()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }


        public void Agregar(Producto producto)
        {
            try
            {
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string insertQuery = @"INSERT INTO Productos (NombreProducto,
                      PrecioUnitario, Stock) VALUES(@NombreProducto, @PrecioUnitario, @Stock,); SELECT SCOPE_IDENTITY()";
                    using (var comando = new SqlCommand(insertQuery, conn))
                    {
                        comando.Parameters.Add("@NombreProducto", SqlDbType.NVarChar);
                        comando.Parameters["@NombreProducto"].Value = producto.NombreProducto;

                        comando.Parameters.Add("@PrecioUnitario", SqlDbType.Decimal);
                        comando.Parameters["@PrecioUnitario"].Value = producto.PrecioUnitario;

                        comando.Parameters.Add("@Stock", SqlDbType.Int);
                        comando.Parameters["@Stock"].Value = producto.Stock;

                        int id = Convert.ToInt32(comando.ExecuteScalar());
                        producto.IdProducto = id;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Borrar(int IdProducto)
        {
            try
            {
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM Productos WHERE IdProducto=@IdProducto";
                    using (var comando = new SqlCommand(deleteQuery, conn))
                    {
                        comando.Parameters.Add("@IdProducto", SqlDbType.Int);
                        comando.Parameters["@IdProducto"].Value = IdProducto;

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Editar(Producto producto)
        {
            try
            {
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string updateQuery = @"UPDATE Productos SET NombreProducto=@NombreProducto, 
                        PrecioUnitario=@PrecioUnitario, Stock=@Stock
                       WHERE IdProducto=@IdProducto";
                    using (var comando = new SqlCommand(updateQuery, conn))
                    {
                        comando.Parameters.Add("@NombreProducto", SqlDbType.NVarChar);
                        comando.Parameters["@NombreProducto"].Value = producto.NombreProducto;

                       
                        

                        comando.Parameters.Add("@PrecioUnitario", SqlDbType.Decimal);
                        comando.Parameters["@PrecioUnitario"].Value = producto.PrecioUnitario;

                        comando.Parameters.Add("@Stock", SqlDbType.Int);
                        comando.Parameters["@Stock"].Value = producto.Stock;

                     


                        comando.Parameters.Add("@IdProducto", SqlDbType.Int);
                        comando.Parameters["@IdProducto"].Value = producto.IdProducto;


                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public List<ProductoListDto> GetProductos()
        {
            try
            {
                List<ProductoListDto> lista = new List<ProductoListDto>();
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    conn.Open();
                    string selectQuery = @"SELECT IdProducto, NombreProducto,PrecioUnitario
                        StockFROM Productos
                        ORDER BY NombreProducto";
                    using (var comando = new SqlCommand(selectQuery, conn))
                    {
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var producto = ConstruirProductoDto(reader);
                                lista.Add(producto);
                            }
                        }
                    }
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad()
        {
            try
            {
                int cantidad = 0;
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string selectQuery = "SELECT COUNT(*) FROM Productos";
                    using (var comando = new SqlCommand(selectQuery, conn))
                    {
                        cantidad = (int)comando.ExecuteScalar();
                    }
                }
                return cantidad;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Producto producto)
        {
            try
            {
                var cantidad = 0;
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string selectQuery;
                    if (producto.IdProducto == 0)
                    {
                        selectQuery = "SELECT COUNT(*) FROM Productos WHERE NombreProducto=@NombreProducto";

                    }
                    else
                    {
                        selectQuery = "SELECT COUNT(*) FROM Productos WHERE NombreProducto=@NombreProducto AND IdProducto<>@IdProducto";

                    }
                    using (var comando = new SqlCommand(selectQuery, conn))
                    {
                        comando.Parameters.Add("@NombreProducto", SqlDbType.NVarChar);
                        comando.Parameters["@NombreProducto"].Value = producto.NombreProducto;

                        if (producto.IdProducto != 0)
                        {
                            comando.Parameters.Add("@IdProducto", SqlDbType.Int);
                            comando.Parameters["@IdProducto"].Value = producto.IdProducto;

                        }

                        cantidad = (int)comando.ExecuteScalar();
                    }
                }
                return cantidad > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ProductoListDto> GetProductosPorPagina(int cantidad, int pagina)
        {
            List<ProductoListDto> lista = new List<ProductoListDto>();
            try
            {
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string selectQuery = @"SELECT IdProducto, NombreProducto,PrecioUnitario,
                        Stock
                        ORDER BY NombreProducto
                        OFFSET @cantidadRegistros ROWS 
                        FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    using (var comando = new SqlCommand(selectQuery, conn))
                    {
                        comando.Parameters.Add("@cantidadRegistros", SqlDbType.Int);
                        comando.Parameters["@cantidadRegistros"].Value = cantidad * (pagina - 1);

                        comando.Parameters.Add("@cantidadPorPagina", SqlDbType.Int);
                        comando.Parameters["@cantidadPorPagina"].Value = cantidad;
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var productoDto = ConstruirProductoDto(reader);
                                lista.Add(productoDto);
                            }
                        }
                    }
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private ProductoListDto ConstruirProductoDto(SqlDataReader reader)
        {
            return new ProductoListDto
            {
                IdProducto = reader.GetInt32(0),
                NombreProducto = reader.GetString(1),
                PrecioUnitario = reader.GetDecimal(2),
                Stock = reader.GetInt32(3),
               
            };
        }

        private Producto ConstruirProducto(SqlDataReader reader)
        {
            return new Producto()
            {
                IdProducto = reader.GetInt32(0),
                NombreProducto = reader.GetString(1),
                PrecioUnitario = reader.GetDecimal(2),
                Stock = reader.GetInt32(3),
          
            };
        }

        public Producto GetProductoPorId(int IdProducto)
        {
            try
            {
                Producto producto = null;
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string selectQuery = @"SELECT IdProducto, NombreProductoPrecioUnitario, Stock,
                      FROM Productos WHERE IdProducto=@IdProducto";
                    using (var comando = new SqlCommand(selectQuery, conn))
                    {
                        comando.Parameters.Add("@IdProducto", SqlDbType.Int);
                        comando.Parameters["@IdProducto"].Value = IdProducto;
                        using (var reader = comando.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                producto = ConstruirProducto(reader);
                            }
                        }
                    }
                }
                return producto;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool EstaRelacionado(Producto producto)
        {
            throw new NotImplementedException();
        }

        List<Producto> IREpositorioProductos.GetProductos()
        {
            throw new NotImplementedException();
        }
    }
}
