
namespace Capa.UI.Reportes
{
    partial class FrmRepMedidasC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRepMedidasC));
            this.pASeleccionarMedidasXClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMedidas = new Capa.UI.DSMedidas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pA_SeleccionarMedidasXClienteTableAdapter = new Capa.UI.DSMedidasTableAdapters.PA_SeleccionarMedidasXClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pASeleccionarMedidasXClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMedidas)).BeginInit();
            this.SuspendLayout();
            // 
            // pASeleccionarMedidasXClienteBindingSource
            // 
            this.pASeleccionarMedidasXClienteBindingSource.DataMember = "PA_SeleccionarMedidasXCliente";
            this.pASeleccionarMedidasXClienteBindingSource.DataSource = this.dSMedidas;
            // 
            // dSMedidas
            // 
            this.dSMedidas.DataSetName = "DSMedidas";
            this.dSMedidas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pASeleccionarMedidasXClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.RepMedidasC.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1033, 718);
            this.reportViewer1.TabIndex = 0;
            // 
            // pA_SeleccionarMedidasXClienteTableAdapter
            // 
            this.pA_SeleccionarMedidasXClienteTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRepMedidasC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 718);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRepMedidasC";
            this.Text = "FrmRepMedidasC";
            this.Load += new System.EventHandler(this.FrmRepMedidasC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pASeleccionarMedidasXClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMedidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pASeleccionarMedidasXClienteBindingSource;
        private DSMedidas dSMedidas;
        private DSMedidasTableAdapters.PA_SeleccionarMedidasXClienteTableAdapter pA_SeleccionarMedidasXClienteTableAdapter;
    }
}