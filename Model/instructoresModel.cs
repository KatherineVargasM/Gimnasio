using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Gimnasio.Config;

namespace Gimnasio.Model
{
    public class instructoresModel
    {
        public int ID_Instructor { get; set; }
        public string Nombre { get; set; }

        public static string Insertar(instructoresModel instructor)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "INSERT INTO Instructores (Nombre) OUTPUT INSERTED.ID_Instructor VALUES (@Nombre)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", instructor.Nombre);

                        var idInstructor = (int)comando.ExecuteScalar();
                        if (idInstructor > 0)
                        {
                            instructor.ID_Instructor = idInstructor;
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

        public static string Actualizar(instructoresModel instructor)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "UPDATE Instructores SET Nombre = @Nombre WHERE ID_Instructor = @ID_Instructor";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Instructor", instructor.ID_Instructor);
                        comando.Parameters.AddWithValue("@Nombre", instructor.Nombre);
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

        public static string Eliminar(int idInstructor)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "DELETE FROM Instructores WHERE ID_Instructor = @ID_Instructor";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Instructor", idInstructor);
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

        public static instructoresModel ObtenerPorId(int idInstructor)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM Instructores WHERE ID_Instructor = @ID_Instructor";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Instructor", idInstructor);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new instructoresModel
                                {
                                    ID_Instructor = Convert.ToInt32(lector["ID_Instructor"]),
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

        public static List<instructoresModel> ObtenerTodos()
        {
            var instructores = new List<instructoresModel>();

            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM Instructores";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                instructores.Add(new instructoresModel
                                {
                                    ID_Instructor = Convert.ToInt32(lector["ID_Instructor"]),
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

            return instructores;
        }
    }
}

