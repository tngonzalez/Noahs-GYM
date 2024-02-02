
namespace Capa.UI
{
    partial class FrmAgrupacionXTipoEjer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgrupacionXTipoEjer));
            this.PA_SeleccionarEjerciciosXTipoEjerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSAgrupacionXTipo = new Capa.UI.DSAgrupacionXTipo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PA_SeleccionarEjerciciosXTipoEjerTableAdapter = new Capa.UI.DSAgrupacionXTipoTableAdapters.PA_SeleccionarEjerciciosXTipoEjerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PA_SeleccionarEjerciciosXTipoEjerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSAgrupacionXTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // PA_SeleccionarEjerciciosXTipoEjerBindingSource
            // 
            this.PA_SeleccionarEjerciciosXTipoEjerBindingSource.DataMember = "PA_SeleccionarEjerciciosXTipoEjer";
            this.PA_SeleccionarEjerciciosXTipoEjerBindingSource.DataSource = this.DSAgrupacionXTipo;
            // 
            // DSAgrupacionXTipo
            // 
            this.DSAgrupacionXTipo.DataSetName = "DSAgrupacionXTipo";
            this.DSAgrupacionXTipo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PA_SeleccionarEjerciciosXTipoEjerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.RepAgrupacionXTipoEjer.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1051, 620);
            this.reportViewer1.TabIndex = 0;
            // 
            // PA_SeleccionarEjerciciosXTipoEjerTableAdapter
            // 
            this.PA_SeleccionarEjerciciosXTipoEjerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAgrupacionXTipoEjer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 620);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgrupacionXTipoEjer";
            this.Text = "FrmAgrupacionXTipoEjer";
            this.Load += new System.EventHandler(this.FrmAgrupacionXTipoEjer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_SeleccionarEjerciciosXTipoEjerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSAgrupacionXTipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PA_SeleccionarEjerciciosXTipoEjerBindingSource;
        private DSAgrupacionXTipo DSAgrupacionXTipo;
        private DSAgrupacionXTipoTableAdapters.PA_SeleccionarEjerciciosXTipoEjerTableAdapter PA_SeleccionarEjerciciosXTipoEjerTableAdapter;
    }
}