using Gimnasio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Controller
{
    public class clasesController
    {
        public string InsertarClase(clasesModel clase)
        {
            return clasesModel.Insertar(clase);
        }

        public string ActualizarClase(clasesModel clase)
        {
            return clasesModel.Actualizar(clase);
        }

        public string EliminarClase(int idClase)
        {
            return clasesModel.Eliminar(idClase);
        }

        public clasesModel ObtenerClasePorId(int idClase)
        {
            return clasesModel.ObtenerPorId(idClase);
        }

        public List<clasesModel> ObtenerTodasLasClases()
        {
            return clasesModel.ObtenerTodos();
        }

        public List<instructoresModel> ObtenerTodosLosInstructores()
        {
            return instructoresModel.ObtenerTodos();
        }
    }
}
