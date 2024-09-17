using Gimnasio.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Model
{
    public class clasesModel
    {
        public int ID_Clase { get; set; }
        public string Nombre { get; set; }
        public int ID_Instructor { get; set; }

        public static string Insertar(clasesModel clase)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "INSERT INTO Clases (Nombre, ID_Instructor) OUTPUT INSERTED.ID_Clase VALUES (@Nombre, @ID_Instructor)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", clase.Nombre);
                        comando.Parameters.AddWithValue("@ID_Instructor", clase.ID_Instructor);

                        var idClase = (int)comando.ExecuteScalar();
                        if (idClase > 0)
                        {
                            clase.ID_Clase = idClase;
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

        public static string Actualizar(clasesModel clase)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "UPDATE Clases SET Nombre = @Nombre, ID_Instructor = @ID_Instructor WHERE ID_Clase = @ID_Clase";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Clase", clase.ID_Clase);
                        comando.Parameters.AddWithValue("@Nombre", clase.Nombre);
                        comando.Parameters.AddWithValue("@ID_Instructor", clase.ID_Instructor);
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

        public static string Eliminar(int idClase)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "DELETE FROM Clases WHERE ID_Clase = @ID_Clase";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Clase", idClase);
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

        public static clasesModel ObtenerPorId(int idClase)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM Clases WHERE ID_Clase = @ID_Clase";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Clase", idClase);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new clasesModel
                                {
                                    ID_Clase = Convert.ToInt32(lector["ID_Clase"]),
                                    Nombre = lector["Nombre"].ToString(),
                                    ID_Instructor = Convert.ToInt32(lector["ID_Instructor"])
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

        public static List<clasesModel> ObtenerTodos()
        {
            var clases = new List<clasesModel>();

            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM Clases";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                clases.Add(new clasesModel
                                {
                                    ID_Clase = Convert.ToInt32(lector["ID_Clase"]),
                                    Nombre = lector["Nombre"].ToString(),
                                    ID_Instructor = Convert.ToInt32(lector["ID_Instructor"])
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

            return clases;
        }
    }
}
