namespace Gimnasio.Views.Asistencias
{
    partial class frm_Reporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporte1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gimnasioDataSet = new Gimnasio.GimnasioDataSet();
            this.reporte1TableAdapter = new Gimnasio.GimnasioDataSetTableAdapters.Reporte1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporte1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporte1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gimnasio.Views.Asistencias.ReporteAsistencia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(584, 509);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporte1BindingSource
            // 
            this.reporte1BindingSource.DataMember = "Reporte1";
            this.reporte1BindingSource.DataSource = this.gimnasioDataSet;
            // 
            // gimnasioDataSet
            // 
            this.gimnasioDataSet.DataSetName = "GimnasioDataSet";
            this.gimnasioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporte1TableAdapter
            // 
            this.reporte1TableAdapter.ClearBeforeFill = true;
            // 
            // frm_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 509);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Reporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Asistencias";
            this.Load += new System.EventHandler(this.frm_Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporte1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private GimnasioDataSet gimnasioDataSet;
        private System.Windows.Forms.BindingSource reporte1BindingSource;
        private GimnasioDataSetTableAdapters.Reporte1TableAdapter reporte1TableAdapter;
    }
}