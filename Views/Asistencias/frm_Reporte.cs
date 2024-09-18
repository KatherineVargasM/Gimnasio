using Gimnasio.GimnasioDataSetTableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gimnasio.Views.Asistencias
{
    public partial class frm_Reporte : Form
    {
        public frm_Reporte()
        {
            InitializeComponent();
        }

        private void frm_Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gimnasioDataSet.Reporte1' Puede moverla o quitarla según sea necesario.
            this.reporte1TableAdapter.Fill(this.gimnasioDataSet.Reporte1);
            this.reportViewer1.RefreshReport();

        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Filtro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}

