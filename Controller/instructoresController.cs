using Gimnasio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Controller
{
    public class instructoresController
    {
        public string InsertarInstructor(instructoresModel instructor)
        {
            return instructoresModel.Insertar(instructor);
        }

        public string ActualizarInstructor(instructoresModel instructor)
        {
            return instructoresModel.Actualizar(instructor);
        }

        public string EliminarInstructor(int idInstructor)
        {
            return instructoresModel.Eliminar(idInstructor);
        }

        public instructoresModel ObtenerInstructorPorId(int idInstructor)
        {
            return instructoresModel.ObtenerPorId(idInstructor);
        }

        public List<instructoresModel> ObtenerTodosLosInstructores()
        {
            return instructoresModel.ObtenerTodos();
        }
    }
}

