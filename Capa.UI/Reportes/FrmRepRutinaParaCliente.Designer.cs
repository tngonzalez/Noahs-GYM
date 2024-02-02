
namespace Capa.UI.Reportes
{
    partial class FrmRepRutinaParaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRepRutinaParaCliente));
            this.pASeleccionarClienteRutinaXClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRutinaParaCliente = new Capa.UI.DSRutinaParaCliente();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pA_SeleccionarClienteRutinaXClienteTableAdapter = new Capa.UI.DSRutinaParaClienteTableAdapters.PA_SeleccionarClienteRutinaXClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pASeleccionarClienteRutinaXClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRutinaParaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // pASeleccionarClienteRutinaXClienteBindingSource
            // 
            this.pASeleccionarClienteRutinaXClienteBindingSource.DataMember = "PA_SeleccionarClienteRutinaXCliente";
            this.pASeleccionarClienteRutinaXClienteBindingSource.DataSource = this.dSRutinaParaCliente;
            // 
            // dSRutinaParaCliente
            // 
            this.dSRutinaParaCliente.DataSetName = "DSRutinaParaCliente";
            this.dSRutinaParaCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pASeleccionarClienteRutinaXClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.RepRutinaParaCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(965, 657);
            this.reportViewer1.TabIndex = 0;
            // 
            // pA_SeleccionarClienteRutinaXClienteTableAdapter
            // 
            this.pA_SeleccionarClienteRutinaXClienteTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRepRutinaParaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 657);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRepRutinaParaCliente";
            this.Text = "FrmRepRutinaParaCliente";
            this.Load += new System.EventHandler(this.FrmRepRutinaParaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pASeleccionarClienteRutinaXClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRutinaParaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pASeleccionarClienteRutinaXClienteBindingSource;
        private DSRutinaParaCliente dSRutinaParaCliente;
        private DSRutinaParaClienteTableAdapters.PA_SeleccionarClienteRutinaXClienteTableAdapter pA_SeleccionarClienteRutinaXClienteTableAdapter;
    }
}