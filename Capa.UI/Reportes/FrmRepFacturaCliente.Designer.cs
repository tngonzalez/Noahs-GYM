
namespace Capa.UI.Reportes
{
    partial class FrmRepFacturaCliente
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
            this.pAGenerarFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSFacturaCliente = new Capa.UI.DSFacturaCliente();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pA_GenerarFacturaTableAdapter = new Capa.UI.DSFacturaClienteTableAdapters.PA_GenerarFacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pAGenerarFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // pAGenerarFacturaBindingSource
            // 
            this.pAGenerarFacturaBindingSource.DataMember = "PA_GenerarFactura";
            this.pAGenerarFacturaBindingSource.DataSource = this.dSFacturaCliente;
            // 
            // dSFacturaCliente
            // 
            this.dSFacturaCliente.DataSetName = "DSFacturaCliente";
            this.dSFacturaCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pAGenerarFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.RepFacturaCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(924, 634);
            this.reportViewer1.TabIndex = 0;
            // 
            // pA_GenerarFacturaTableAdapter
            // 
            this.pA_GenerarFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRepFacturaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 634);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRepFacturaCliente";
            this.Text = "FrmRepFacturaCliente";
            this.Load += new System.EventHandler(this.FrmRepFacturaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pAGenerarFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pAGenerarFacturaBindingSource;
        private DSFacturaCliente dSFacturaCliente;
        private DSFacturaClienteTableAdapters.PA_GenerarFacturaTableAdapter pA_GenerarFacturaTableAdapter;
    }
}