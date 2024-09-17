using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gimnasio.Config;
using Gimnasio.Controller;
using Gimnasio.Model;

namespace Gimnasio.Views.Clientes
{
    public partial class Clientes : Form
    {
        clientesController _clientesController = new clientesController();
        int id = 0;

        public Clientes()
        {
            InitializeComponent();
            cargalista();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente.");
                return;
            }

            try
            {
                var cliente = new clientesModel
                {
                    ID_Cliente = 0,
                    Nombre = txt_nombre.Text.Trim()
                };

                var resultado = _clientesController.InsertarCliente(cliente);

                if (resultado == "OK")
                {
                    ControlErrores.ManejarInsertar();
                }
                else
                {
                    ControlErrores.ManejarErrorGeneral(null, $"Error al agregar el cliente: {resultado}");
                }

                cargalista();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex);
            }
        }

        private void cargalista()
        {
            try
            {
                var listaClientes = _clientesController.ObtenerTodosLosClientes();
                lst_Clientes.DataSource = null;
                lst_Clientes.DataSource = listaClientes;
                lst_Clientes.DisplayMember = "Nombre";
                lst_Clientes.ValueMember = "ID_Cliente";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}");
            }
        }

        private void limpiarCampos()
        {
            txt_nombre.Text = "";
            id = 0;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (lst_Clientes.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un cliente de la lista para modificar.");
                return;
            }

            var result = MessageBox.Show("¿Está seguro de que desea modificar este cliente?", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var cliente = new clientesModel
                    {
                        ID_Cliente = (int)lst_Clientes.SelectedValue,
                        Nombre = txt_nombre.Text.Trim()
                    };

                    var resultado = _clientesController.ActualizarCliente(cliente);
                    if (resultado == "OK")
                    {
                        ControlErrores.ManejarActualizar();
                    }
                    else
                    {
                        ControlErrores.ManejarErrorGeneral(null, $"Error al modificar el cliente: {resultado}");
                    }

                    cargalista();
                    limpiarCampos();
                }
                catch (Exception ex)
                {
                    ControlErrores.ManejarErrorGeneral(ex);
                }
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (lst_Clientes.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
                return;
            }

            var result = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var clienteId = (int)lst_Clientes.SelectedValue;
                    var resultado = _clientesController.EliminarCliente(clienteId);
                    if (resultado == "OK")
                    {
                        ControlErrores.ManejarEliminar();
                    }
                    else
                    {
                        ControlErrores.ManejarErrorGeneral(null, $"Error al eliminar el cliente: {resultado}");
                    }
                    cargalista();
                }
                catch (Exception ex)
                {
                    ControlErrores.ManejarErrorGeneral(ex);
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void lst_Clientes_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Clientes.SelectedItem != null)
            {
                var clienteSeleccionado = (clientesModel)lst_Clientes.SelectedItem;
                txt_nombre.Text = clienteSeleccionado.Nombre;
                id = clienteSeleccionado.ID_Cliente;
            }
        }
    }
}
