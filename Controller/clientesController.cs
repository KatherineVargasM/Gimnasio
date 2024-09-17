using Gimnasio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Controller
{
    public class clientesController
    {
        public string InsertarCliente(clientesModel cliente)
        {
            return clientesModel.Insertar(cliente);
        }

        public string ActualizarCliente(clientesModel cliente)
        {
            return clientesModel.Actualizar(cliente);
        }

        public string EliminarCliente(int idCliente)
        {
            return clientesModel.Eliminar(idCliente);
        }

        public clientesModel ObtenerClientePorId(int idCliente)
        {
            return clientesModel.ObtenerPorId(idCliente);
        }

        public List<clientesModel> ObtenerTodosLosClientes()
        {
            return clientesModel.ObtenerTodos();
        }
    }
}
