using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public static class ClientesData
    {
        private static string connectionString = Properties.Resources.miConexion;

        public static List<Cliente> ListarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            string query = "SELECT Id,NombreApellido,Domicilio,Telefono FROM Clientes";

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
                                    var cliente = new Cliente();
                                    cliente.Id = Convert.ToInt32(dr["Id"]);
                                    cliente.NombreApellido = dr["NombreApellido"].ToString();
                                    cliente.Domicilio = dr["Domicilio"].ToString();
                                    cliente.Telefono = dr["Telefono"].ToString();

                                    clientes.Add(cliente);
                                }
                            }
                        }
                    }
                    // Opcional
                    conexion.Close();
                }
                return clientes;
            }
            catch (Exception ex)
            {
                return clientes;
            }
        }
        public static Cliente ObtenerCliente(int id)
        {
            Cliente cliente = new Cliente();
            // Importante: Para que funcione
            // Modifica el parametro Server por el de tu Servidor
            string query = "SELECT Id,NombreApellido,Domicilio,Telefono FROM Clientes Where Id=@Id";

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
                                    cliente.Id = Convert.ToInt32(dr["Id"]);
                                    cliente.NombreApellido= dr["NombreApellido"].ToString();
                                    cliente.Domicilio = dr["Domicilio"].ToString();
                                    cliente.Telefono = dr["Telefono"].ToString();
                                }
                            }
                        }
                    }
                    // Opcional
                    conexion.Close();
                }
                return cliente;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static void CrearCliente(Cliente cliente)
        {
            string query = "INSERT INTO Clientes (NombreApellido,Domicilio,Telefono)" +
                " VALUES(@NombreApellido, @Domicilio, @Telefono); ";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // se puede determinar si es Procedimiento Tabla o consulta
                        // comando.CommandType = CommandType.TableDirect;

                        comando.Parameters.Add(new SqlParameter("NombreApellido", SqlDbType.VarChar) { Value = cliente.NombreApellido });
                        comando.Parameters.Add(new SqlParameter("Domicilio", SqlDbType.VarChar) { Value = cliente.Domicilio });
                        comando.Parameters.Add(new SqlParameter("Telefono", SqlDbType.VarChar) { Value = cliente.Telefono });

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
        public static void ModificarCliente(Cliente cliente)
        {
            string query = "UPDATE Clientes " +
                "SET NombreApellido = @NombreApellido ,Domicilio = @Domicilio, Telefono = @Telefono " +
                " WHERE Id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = cliente.Id });

                        comando.Parameters.Add(new SqlParameter("NombreApellido", SqlDbType.VarChar) { Value = cliente.NombreApellido });
                        comando.Parameters.Add(new SqlParameter("Domicilio", SqlDbType.VarChar) { Value = cliente.Domicilio });
                        comando.Parameters.Add(new SqlParameter("Telefono", SqlDbType.VarChar) { Value = cliente.Telefono });

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
        public static void EliminarCliente(int id)
        {
            string query = "DELETE FROM Clientes " +
                " WHERE Id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = id });

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
