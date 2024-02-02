
namespace Capa.UI.Reportes
{
    partial class FrmRepFacturaAdminIns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRepFacturaAdminIns));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSFacturaAdminIns = new Capa.UI.DSFacturaAdminIns();
            this.pAGenerarFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pA_GenerarFacturaTableAdapter = new Capa.UI.DSFacturaAdminInsTableAdapters.PA_GenerarFacturaTableAdapter();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.ptbSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturaAdminIns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAGenerarFacturaBindingSource)).BeginInit();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pAGenerarFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.RepFacturaAdminIns.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 31);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(851, 558);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSFacturaAdminIns
            // 
            this.dSFacturaAdminIns.DataSetName = "DSFacturaAdminIns";
            this.dSFacturaAdminIns.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pAGenerarFacturaBindingSource
            // 
            this.pAGenerarFacturaBindingSource.DataMember = "PA_GenerarFactura";
            this.pAGenerarFacturaBindingSource.DataSource = this.dSFacturaAdminIns;
            // 
            // pA_GenerarFacturaTableAdapter
            // 
            this.pA_GenerarFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(150)))), ((int)(((byte)(143)))));
            this.barraTitulo.Controls.Add(this.ptbSalir);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(851, 33);
            this.barraTitulo.TabIndex = 2;
            // 
            // ptbSalir
            // 
            this.ptbSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbSalir.Image = global::Capa.UI.Properties.Resources.Salir;
            this.ptbSalir.Location = new System.Drawing.Point(818, 3);
            this.ptbSalir.Name = "ptbSalir";
            this.ptbSalir.Size = new System.Drawing.Size(30, 30);
            this.ptbSalir.TabIndex = 0;
            this.ptbSalir.TabStop = false;
            this.ptbSalir.Click += new System.EventHandler(this.ptbSalir_Click);
            // 
            // FrmRepFacturaAdminIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 591);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRepFacturaAdminIns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmRepFacturaAdminIns";
            this.Load += new System.EventHandler(this.FrmRepFacturaAdminIns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturaAdminIns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAGenerarFacturaBindingSource)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pAGenerarFacturaBindingSource;
        private DSFacturaAdminIns dSFacturaAdminIns;
        private DSFacturaAdminInsTableAdapters.PA_GenerarFacturaTableAdapter pA_GenerarFacturaTableAdapter;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox ptbSalir;
    }
}