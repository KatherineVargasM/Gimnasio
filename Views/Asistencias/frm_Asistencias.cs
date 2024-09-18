using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gimnasio.Config;
using Gimnasio.Controller;
using Gimnasio.Model;

namespace Gimnasio.Views.Asistencias
{
    public partial class frm_Asistencias : Form
    {
        asistenciasController _asistenciasController = new asistenciasController();
        int id = 0;

        public frm_Asistencias()
        {
            InitializeComponent();
            cargalista();
            cargarClientes();
            cargarClases();
        }

        private void frm_Asistencias_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (cmb_clientes.SelectedValue == null || cmb_clases.SelectedValue == null || dtp_Fecha.Value == null)
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            try
            {
                var asistencia = new asistenciasModel
                {
                    ID_Asistencia = 0,
                    ID_Cliente = (int)cmb_clientes.SelectedValue,
                    ID_Clase = (int)cmb_clases.SelectedValue,
                    Fecha = dtp_Fecha.Value
                };

                var resultado = _asistenciasController.InsertarAsistencia(asistencia);

                if (resultado == "OK")
                {
                    ControlErrores.ManejarInsertar();
                }
                else
                {
                    ControlErrores.ManejarErrorGeneral(null, $"Error al agregar la asistencia: {resultado}");
                }

                cargalista();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void cargalista()
        {
            try
            {
                var listaAsistencias = _asistenciasController.ObtenerTodasLasAsistencias();
                lst_Asistencias.DataSource = null;
                lst_Asistencias.DataSource = listaAsistencias;
                lst_Asistencias.DisplayMember = "ID_Asistencia";
                lst_Asistencias.ValueMember = "ID_Asistencia";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar asistencias: {ex.Message}");
            }
        }

        private void cargarClientes()
        {
            try
            {
                var listaClientes = _asistenciasController.ObtenerTodosLosClientes();
                cmb_clientes.DataSource = null;
                cmb_clientes.DataSource = listaClientes;
                cmb_clientes.DisplayMember = "Nombre";
                cmb_clientes.ValueMember = "ID_Cliente";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}");
            }
        }

        private void cargarClases()
        {
            try
            {
                var listaClases = _asistenciasController.ObtenerTodasLasClases();
                cmb_clases.DataSource = null;
                cmb_clases.DataSource = listaClases;
                cmb_clases.DisplayMember = "Nombre";
                cmb_clases.ValueMember = "ID_Clase";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clases: {ex.Message}");
            }
        }

        private void limpiarCampos()
        {
            cmb_clientes.SelectedIndex = -1;
            cmb_clases.SelectedIndex = -1;
            dtp_Fecha.Value = DateTime.Now;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (cmb_clientes.SelectedValue == null || cmb_clases.SelectedValue == null || dtp_Fecha.Value == null || id == 0)
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            try
            {
                var asistencia = new asistenciasModel
                {
                    ID_Asistencia = id,
                    ID_Cliente = (int)cmb_clientes.SelectedValue,
                    ID_Clase = (int)cmb_clases.SelectedValue,
                    Fecha = dtp_Fecha.Value
                };

                var resultado = _asistenciasController.ActualizarAsistencia(asistencia);

                if (resultado == "OK")
                {
                    ControlErrores.ManejarActualizar();
                }
                else
                {
                    ControlErrores.ManejarErrorGeneral(null, $"Error al actualizar la asistencia: {resultado}");
                }

                cargalista();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                ControlErrores.ManejarErrorGeneral(ex);
            }

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (lst_Asistencias.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una asistencia para eliminar.");
                return;
            }

            var result = MessageBox.Show("¿Está seguro de que desea eliminar esta asistencia?", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var resultado = _asistenciasController.EliminarAsistencia((int)lst_Asistencias.SelectedValue);
                    if (resultado == "OK")
                    {
                        ControlErrores.ManejarEliminar();
                    }
                    else
                    {
                        ControlErrores.ManejarErrorGeneral(null, $"Error al eliminar la asistencia: {resultado}");
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

        private void lst_Asistencias_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Asistencias.SelectedValue != null)
            {
                id = (int)lst_Asistencias.SelectedValue;
                var asistencia = _asistenciasController.ObtenerAsistenciaPorId(id);
                if (asistencia != null)
                {
                    cmb_clientes.SelectedValue = asistencia.ID_Cliente;
                    cmb_clases.SelectedValue = asistencia.ID_Clase;
                    dtp_Fecha.Value = asistencia.Fecha;
                }
            }
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            frm_Reporte _Reporte = new frm_Reporte();
            _Reporte.Show();
        }
    }
    
}
