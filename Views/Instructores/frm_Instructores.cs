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

namespace Gimnasio.Views.Instructores
{
    public partial class frm_Instructores : Form
    {
        instructoresController _instructoresController = new instructoresController();
        int id = 0;

        public frm_Instructores()
        {
            InitializeComponent();
            cargalista();
        }

        private void frm_Instructores_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del instructor.");
                return;
            }

            try
            {
                var instructor = new instructoresModel
                {
                    ID_Instructor = 0,
                    Nombre = txt_nombre.Text.Trim()
                };

                var resultado = _instructoresController.InsertarInstructor(instructor);

                if (resultado == "OK")
                {
                    ControlErrores.ManejarInsertar();
                }
                else
                {
                    ControlErrores.ManejarErrorGeneral(null, $"Error al agregar el instructor: {resultado}");
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
                var listaInstructores = _instructoresController.ObtenerTodosLosInstructores();
                lst_Instructores.DataSource = null;
                lst_Instructores.DataSource = listaInstructores;
                lst_Instructores.DisplayMember = "Nombre";
                lst_Instructores.ValueMember = "ID_Instructor";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar instructores: {ex.Message}");
            }
        }

        private void limpiarCampos()
        {
            txt_nombre.Text = "";
            id = 0;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (lst_Instructores.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un instructor de la lista para modificar.");
                return;
            }

            var result = MessageBox.Show("¿Está seguro de que desea modificar este instructor?", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var instructor = new instructoresModel
                    {
                        ID_Instructor = (int)lst_Instructores.SelectedValue,
                        Nombre = txt_nombre.Text.Trim()
                    };

                    var resultado = _instructoresController.ActualizarInstructor(instructor);
                    if (resultado == "OK")
                    {
                        ControlErrores.ManejarActualizar();
                    }
                    else
                    {
                        ControlErrores.ManejarErrorGeneral(null, $"Error al modificar el instructor: {resultado}");
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
            if (lst_Instructores.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un instructor para eliminar.");
                return;
            }

            var result = MessageBox.Show("¿Está seguro de que desea eliminar este instructor?", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var instructorId = (int)lst_Instructores.SelectedValue;
                    var resultado = _instructoresController.EliminarInstructor(instructorId);
                    if (resultado == "OK")
                    {
                        ControlErrores.ManejarEliminar();
                    }
                    else
                    {
                        ControlErrores.ManejarErrorGeneral(null, $"Error al eliminar el instructor: {resultado}");
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

        private void lst_Instructores_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Instructores.SelectedItem != null)
            {
                var instructorSeleccionado = (instructoresModel)lst_Instructores.SelectedItem;
                txt_nombre.Text = instructorSeleccionado.Nombre;
                id = instructorSeleccionado.ID_Instructor;
            }
        }
    }
}