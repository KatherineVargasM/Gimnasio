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

namespace Gimnasio.Views.Clases
{
    public partial class frm_Clases : Form
    {
        clasesController _clasesController = new clasesController();
        int id = 0;

        public frm_Clases()
        {
            InitializeComponent();
            cargalista();
            cargarInstructores();
            limpiarCampos();
        }

        private void frm_Clases_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombre.Text) || cmb_Instructor.SelectedValue == null)
            {
                MessageBox.Show("Ingrese el nombre de la clase y seleccione un instructor.");
                return;
            }

            try
            {
                var clase = new clasesModel
                {
                    ID_Clase = 0,
                    Nombre = txt_nombre.Text.Trim(),
                    ID_Instructor = (int)cmb_Instructor.SelectedValue
                };

                var resultado = _clasesController.InsertarClase(clase);

                if (resultado == "OK")
                {
                    ControlErrores.ManejarInsertar();
                }
                else
                {
                    ControlErrores.ManejarErrorGeneral(null, $"Error al agregar la clase: {resultado}");
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
                var listaClases = _clasesController.ObtenerTodasLasClases();
                lst_Clases.DataSource = null;
                lst_Clases.DataSource = listaClases;
                lst_Clases.DisplayMember = "Nombre";
                lst_Clases.ValueMember = "ID_Clase";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clases: {ex.Message}");
            }
        }

        private void cargarInstructores()
        {
            try
            {
                var listaInstructores = _clasesController.ObtenerTodosLosInstructores();
                cmb_Instructor.DataSource = null;
                cmb_Instructor.DataSource = listaInstructores;
                cmb_Instructor.DisplayMember = "Nombre";
                cmb_Instructor.ValueMember = "ID_Instructor";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar instructores: {ex.Message}");
            }
        }

        private void limpiarCampos()
        {
            txt_nombre.Text = "";
            cmb_Instructor.SelectedIndex = -1;
            id = 0;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (lst_Clases.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una clase de la lista para modificar.");
                return;
            }

            var result = MessageBox.Show("¿Está seguro de que desea modificar esta clase?", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var clase = new clasesModel
                    {
                        ID_Clase = (int)lst_Clases.SelectedValue,
                        Nombre = txt_nombre.Text.Trim(),
                        ID_Instructor = (int)cmb_Instructor.SelectedValue
                    };

                    var resultado = _clasesController.ActualizarClase(clase);
                    if (resultado == "OK")
                    {
                        ControlErrores.ManejarActualizar();
                    }
                    else
                    {
                        ControlErrores.ManejarErrorGeneral(null, $"Error al modificar la clase: {resultado}");
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
            if (lst_Clases.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una clase para eliminar.");
                return;
            }

            var result = MessageBox.Show("¿Está seguro de que desea eliminar esta clase?", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var resultado = _clasesController.EliminarClase((int)lst_Clases.SelectedValue);
                    if (resultado == "OK")
                    {
                        ControlErrores.ManejarEliminar();
                    }
                    else
                    {
                        ControlErrores.ManejarErrorGeneral(null, $"Error al eliminar la clase: {resultado}");
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void lst_Clases_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Clases.SelectedValue != null)
            {
                id = (int)lst_Clases.SelectedValue;
                var clase = _clasesController.ObtenerClasePorId(id);
                if (clase != null)
                {
                    txt_nombre.Text = clase.Nombre;
                    cmb_Instructor.SelectedValue = clase.ID_Instructor;
                }
            }
        }
    }
}
