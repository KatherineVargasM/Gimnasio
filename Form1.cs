using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gimnasio.Views;
using Gimnasio.Config;


namespace Gimnasio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            string usuario = txt_Usuario.Text;
            string contrasenia = txt_Contrasenia.Text;

            if (AutenticarUsuario(usuario, contrasenia))
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                lbl_Mensaje.Text = "Usuario o contraseña incorrecta";
            }

        }
        private bool AutenticarUsuario(string usuario, string contrasenia)
        {
            bool autenticado = false;
            string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contrasenia = @Contrasenia";

            try
            {
                using (SqlConnection connection = ConexionBDD.GetConnection())
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contrasenia", contrasenia);
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        autenticado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al autenticar al usuario: {ex.Message}");
            }

            return autenticado;
        }
    

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Contrasenia.Text = "";
            txt_Usuario.Text = "";
        }
    }
}
