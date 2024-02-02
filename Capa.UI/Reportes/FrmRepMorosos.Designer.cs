
namespace Capa.UI.Reportes
{
    partial class FrmRepMorosos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRepMorosos));
            this.pASeleccionarClientesMorosoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMorosos = new Capa.UI.DSMorosos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pA_SeleccionarClientesMorosoTableAdapter = new Capa.UI.DSMorososTableAdapters.PA_SeleccionarClientesMorosoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pASeleccionarClientesMorosoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMorosos)).BeginInit();
            this.SuspendLayout();
            // 
            // pASeleccionarClientesMorosoBindingSource
            // 
            this.pASeleccionarClientesMorosoBindingSource.DataMember = "PA_SeleccionarClientesMoroso";
            this.pASeleccionarClientesMorosoBindingSource.DataSource = this.dSMorosos;
            // 
            // dSMorosos
            // 
            this.dSMorosos.DataSetName = "DSMorosos";
            this.dSMorosos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pASeleccionarClientesMorosoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.RepMorosos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(996, 662);
            this.reportViewer1.TabIndex = 0;
            // 
            // pA_SeleccionarClientesMorosoTableAdapter
            // 
            this.pA_SeleccionarClientesMorosoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRepMorosos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 662);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRepMorosos";
            this.Text = "FrmRepMorosos";
            this.Load += new System.EventHandler(this.FrmRepMorosos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pASeleccionarClientesMorosoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMorosos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DSMorosos dSMorosos;
        private System.Windows.Forms.BindingSource pASeleccionarClientesMorosoBindingSource;
        private DSMorososTableAdapters.PA_SeleccionarClientesMorosoTableAdapter pA_SeleccionarClientesMorosoTableAdapter;
    }
}