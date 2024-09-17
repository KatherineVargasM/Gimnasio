using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Gimnasio.Config;

namespace Gimnasio.Model
{
    public class clientesModel
    {
        public int ID_Cliente { get; set; }
        public string Nombre { get; set; }

        public static string Insertar(clientesModel cliente)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "INSERT INTO Clientes (Nombre) OUTPUT INSERTED.ID_Cliente VALUES (@Nombre)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);

                        var idCliente = (int)comando.ExecuteScalar();
                        if (idCliente > 0)
                        {
                            cliente.ID_Cliente = idCliente;
                            return "OK";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Error: " + ex.Message;
            }
            return "Error";
        }

        public static string Actualizar(clientesModel cliente)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "UPDATE Clientes SET Nombre = @Nombre WHERE ID_Cliente = @ID_Cliente";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Cliente", cliente.ID_Cliente);
                        comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public static string Eliminar(int idCliente)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "DELETE FROM Clientes WHERE ID_Cliente = @ID_Cliente";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Cliente", idCliente);
                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public static clientesModel ObtenerPorId(int idCliente)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM Clientes WHERE ID_Cliente = @ID_Cliente";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Cliente", idCliente);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new clientesModel
                                {
                                    ID_Cliente = Convert.ToInt32(lector["ID_Cliente"]),
                                    Nombre = lector["Nombre"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public static List<clientesModel> ObtenerTodos()
        {
            var clientes = new List<clientesModel>();

            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM Clientes";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                clientes.Add(new clientesModel
                                {
                                    ID_Cliente = Convert.ToInt32(lector["ID_Cliente"]),
                                    Nombre = lector["Nombre"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return clientes;
        }
    }
}

