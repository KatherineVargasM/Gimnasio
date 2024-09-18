using Gimnasio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Controller
{
    public class asistenciasController
    {
        public string InsertarAsistencia(asistenciasModel asistencia)
        {
            return asistenciasModel.Insertar(asistencia);
        }

        public string ActualizarAsistencia(asistenciasModel asistencia)
        {
            return asistenciasModel.Actualizar(asistencia);
        }

        public string EliminarAsistencia(int idAsistencia)
        {
            return asistenciasModel.Eliminar(idAsistencia);
        }

        public asistenciasModel ObtenerAsistenciaPorId(int idAsistencia)
        {
            return asistenciasModel.ObtenerPorId(idAsistencia);
        }

        public List<asistenciasModel> ObtenerTodasLasAsistencias()
        {
            return asistenciasModel.ObtenerTodas();
        }

        public List<clientesModel> ObtenerTodosLosClientes()
        {
            return clientesModel.ObtenerTodos();
        }

        public List<clasesModel> ObtenerTodasLasClases()
        {
            return clasesModel.ObtenerTodos();
        }
    }
}
