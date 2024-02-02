
namespace Capa.UI.Reportes
{
    partial class FrmPopulares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPopulares));
            this.pASeleccionarEjerciciosFrecuentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPopularesEjer = new Capa.UI.DsPopularesEjer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pA_SeleccionarEjerciciosFrecuentesTableAdapter = new Capa.UI.DsPopularesEjerTableAdapters.PA_SeleccionarEjerciciosFrecuentesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pASeleccionarEjerciciosFrecuentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPopularesEjer)).BeginInit();
            this.SuspendLayout();
            // 
            // pASeleccionarEjerciciosFrecuentesBindingSource
            // 
            this.pASeleccionarEjerciciosFrecuentesBindingSource.DataMember = "PA_SeleccionarEjerciciosFrecuentes";
            this.pASeleccionarEjerciciosFrecuentesBindingSource.DataSource = this.dsPopularesEjer;
            // 
            // dsPopularesEjer
            // 
            this.dsPopularesEjer.DataSetName = "DsPopularesEjer";
            this.dsPopularesEjer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pASeleccionarEjerciciosFrecuentesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.RepPopularesEjer.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(936, 591);
            this.reportViewer1.TabIndex = 0;
            // 
            // pA_SeleccionarEjerciciosFrecuentesTableAdapter
            // 
            this.pA_SeleccionarEjerciciosFrecuentesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPopulares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 591);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPopulares";
            this.Text = "FrmPopulares";
            this.Load += new System.EventHandler(this.FrmPopulares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pASeleccionarEjerciciosFrecuentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPopularesEjer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DsPopularesEjer dsPopularesEjer;
        private System.Windows.Forms.BindingSource pASeleccionarEjerciciosFrecuentesBindingSource;
        private DsPopularesEjerTableAdapters.PA_SeleccionarEjerciciosFrecuentesTableAdapter pA_SeleccionarEjerciciosFrecuentesTableAdapter;
    }
}