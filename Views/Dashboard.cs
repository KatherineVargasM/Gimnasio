using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gimnasio.Views.Asistencias;
using Gimnasio.Views.Instructores;
using Gimnasio.Views.Clases;
using Gimnasio.Views.Clientes;

namespace Gimnasio.Views
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        public void centrarimagen()
        {
            int alto = this.ClientSize.Height;
            int ancho = this.ClientSize.Width;


            picture.Left = (ancho - picture.Width) / 2;
            picture.Top = (alto - picture.Width) / 2;
        }

        private void picture_SizeChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_SizeChanged(object sender, EventArgs e)
        {
            centrarimagen();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes.Clientes _Clientes = new Clientes.Clientes();
            _Clientes.Show();
        }

        private void cLASESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Clases _Clases = new frm_Clases();
            _Clases.Show();
        }

        private void iNSTRUCTORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Instructores _Instructores = new frm_Instructores();
            _Instructores.Show();
        }

        private void aSISTENCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Asistencias _Asistencias = new frm_Asistencias();
            _Asistencias.Show();
        }
    }
}
