using Gimnasio.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Model
{
    public class asistenciasModel
    {
        public int ID_Asistencia { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Clase { get; set; }
        public DateTime Fecha { get; set; }

        public static string Insertar(asistenciasModel asistencia)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "INSERT INTO Asistencias (ID_Cliente, ID_Clase, Fecha) OUTPUT INSERTED.ID_Asistencia VALUES (@ID_Cliente, @ID_Clase, @Fecha)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Cliente", asistencia.ID_Cliente);
                        comando.Parameters.AddWithValue("@ID_Clase", asistencia.ID_Clase);
                        comando.Parameters.AddWithValue("@Fecha", asistencia.Fecha);

                        var idAsistencia = (int)comando.ExecuteScalar();
                        if (idAsistencia > 0)
                        {
                            asistencia.ID_Asistencia = idAsistencia;
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

        public static string Actualizar(asistenciasModel asistencia)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "UPDATE Asistencias SET ID_Cliente = @ID_Cliente, ID_Clase = @ID_Clase, Fecha = @Fecha WHERE ID_Asistencia = @ID_Asistencia";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Asistencia", asistencia.ID_Asistencia);
                        comando.Parameters.AddWithValue("@ID_Cliente", asistencia.ID_Cliente);
                        comando.Parameters.AddWithValue("@ID_Clase", asistencia.ID_Clase);
                        comando.Parameters.AddWithValue("@Fecha", asistencia.Fecha);
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

        public static string Eliminar(int idAsistencia)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "DELETE FROM Asistencias WHERE ID_Asistencia = @ID_Asistencia";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Asistencia", idAsistencia);
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

        public static asistenciasModel ObtenerPorId(int idAsistencia)
        {
            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM Asistencias WHERE ID_Asistencia = @ID_Asistencia";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_Asistencia", idAsistencia);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new asistenciasModel
                                {
                                    ID_Asistencia = Convert.ToInt32(lector["ID_Asistencia"]),
                                    ID_Cliente = Convert.ToInt32(lector["ID_Cliente"]),
                                    ID_Clase = Convert.ToInt32(lector["ID_Clase"]),
                                    Fecha = Convert.ToDateTime(lector["Fecha"])
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

        public static List<asistenciasModel> ObtenerTodas()
        {
            var asistencias = new List<asistenciasModel>();

            try
            {
                using (var conexion = ConexionBDD.GetConnection())
                {
                    var consulta = "SELECT * FROM Asistencias";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                asistencias.Add(new asistenciasModel
                                {
                                    ID_Asistencia = Convert.ToInt32(lector["ID_Asistencia"]),
                                    ID_Cliente = Convert.ToInt32(lector["ID_Cliente"]),
                                    ID_Clase = Convert.ToInt32(lector["ID_Clase"]),
                                    Fecha = Convert.ToDateTime(lector["Fecha"])
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

            return asistencias;
        }
    }
}
