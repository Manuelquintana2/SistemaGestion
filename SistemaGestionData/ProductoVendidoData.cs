﻿using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public static class ProductoVendidoData
    {
        private static string connectionString = Properties.Resources.miConexion;
        public static List<ProductoVendido> ListarProductosVendidos()
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();
            // Importante: Para que funcione
            // Modifica el parametro Server por el de tu Servidor
            
            string query = "SELECT Id,Stock,IdProducto,IdVenta FROM ProductoVendido";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var productoVendido = new ProductoVendido();
                                    productoVendido.Id = Convert.ToInt32(dr["Id"]);
                                    productoVendido.Stock = Convert.ToInt32(dr["Stock"]);
                                    productoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                    productoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);

                                    lista.Add(productoVendido);
                                }
                            }
                        }
                    }
                    // Opcional
                    conexion.Close();
                }
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static ProductoVendido ObtenerProductoVendido(int id)
        {
            ProductoVendido productoVendido = new ProductoVendido();
            // Importante: Para que funcione
            // Modifica el parametro Server por el de tu Servidor
            string query = "SELECT Id,Stock,IdProducto,IdVenta FROM ProductoVendido Where Id=@Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = id });


                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    productoVendido.Id = Convert.ToInt32(dr["Id"]);
                                    productoVendido.Stock = Convert.ToInt32(dr["Stock"]);
                                    productoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                    productoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                                }
                            }
                        }
                    }
                    // Opcional
                    conexion.Close();
                }
                return productoVendido;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static void CrearProductoVendido(ProductoVendido productoVendido)
        {
            string query = "INSERT INTO ProductoVendido (Stock, IdProducto,IdVenta)" +
                        " VALUES(@Stock, @IdProducto, @IdVenta); ";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // se puede determinar si es Procedimiento Tabla o consulta
                        // comando.CommandType = CommandType.TableDirect;
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Decimal) { Value = productoVendido.Stock });
                        comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productoVendido.IdProducto });
                        comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = productoVendido.IdVenta });
                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void ModificarProductoVendido(ProductoVendido productoVendido)
        {
            string query = "UPDATE ProductoVendido " +
                "SET Stock = @Stock, IdProducto=@IdProducto. IdVenta = @IdVenta " +
                " WHERE Id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = productoVendido.Id });


                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Decimal) { Value = productoVendido.Stock });
                        comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = productoVendido.IdProducto });
                        comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.BigInt) { Value = productoVendido.IdVenta });

                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void EliminarProductoVendido(int id)
        {
            string query = "DELETE FROM ProductoVendido " +
                " WHERE Id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = id });
                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
