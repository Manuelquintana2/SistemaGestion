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
    public static class UsuariosData
    {
        private static string connectionString = Properties.Resources.miConexion;
        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            // Importante: Para que funcione
            // Modifica el parametro Server por el de tu Servidor
            string query = "SELECT Id,Nombre,Apellido,NombreUsuario,Contraseña,Mail FROM Usuario";

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
                                    var usuario = new Usuario();
                                    usuario.Id = Convert.ToInt32(dr["Id"]);
                                    usuario.Nombre = dr["Nombre"].ToString();
                                    usuario.Apellido = dr["Apellido"].ToString();
                                    usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                                    usuario.Contraseña = (dr["Contraseña"]).ToString();
                                    usuario.Mail = (dr["Mail"]).ToString();
                                    lista.Add(usuario);
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
        public static Usuario ObtenerUsuario(int id)
        {
            Usuario usuario = new Usuario();
            // Importante: Para que funcione
            // Modifica el parametro Server por el de tu Servidor
            string query = "SELECT Id,Nombre,Apellido,NombreUsuario,Contraseña,Mail FROM Usuario Where Id=@Id";

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
                                    usuario.Id = Convert.ToInt32(dr["Id"]);
                                    usuario.Nombre = dr["Nombre"].ToString();
                                    usuario.Apellido = dr["Apellido"].ToString();
                                    usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                                    usuario.Contraseña = (dr["Contraseña"]).ToString();
                                    usuario.Mail = (dr["Mail"]).ToString();
                                }
                            }
                        }
                    }
                    // Opcional
                    conexion.Close();
                }
                return usuario;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static void CrearUsuario(Usuario usuario)
        {
            string query = "INSERT INTO Usuario (Nombre,Apellido,NombreUsuario,Contraseña,Mail)" +
                " VALUES(@Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail); ";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // se puede determinar si es Procedimiento Tabla o consulta
                        // comando.CommandType = CommandType.TableDirect;

                        comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                        comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                        comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                        comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
                        comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });

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
        public static void ModificarUsuario(Usuario usuario)
        {
            string query = "UPDATE Usuario " +
                "SET Nombre = @Nombre ,Apellido = @Apellido, NombreUsuario = @NombreUsuario,Contraseña = @Contraseña, Mail=@Mail " +
                " WHERE Id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = usuario.Id });

                        comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                        comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                        comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                        comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
                        comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });

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
        public static void EliminarUsuario(int id)
        {
            string query = "DELETE FROM Usuario " +
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
