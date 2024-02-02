
namespace Capa.UI.Reportes
{
    partial class FrmRepFacturasFiltro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRepFacturasFiltro));
            this.pASeleccionarFacturaRangoFechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSFacturaFiltro = new Capa.UI.DSFacturaFiltro();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pA_SeleccionarFacturaRangoFechasTableAdapter = new Capa.UI.DSFacturaFiltroTableAdapters.PA_SeleccionarFacturaRangoFechasTableAdapter();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pASeleccionarFacturaRangoFechasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturaFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // pASeleccionarFacturaRangoFechasBindingSource
            // 
            this.pASeleccionarFacturaRangoFechasBindingSource.DataMember = "PA_SeleccionarFacturaRangoFechas";
            this.pASeleccionarFacturaRangoFechasBindingSource.DataSource = this.dSFacturaFiltro;
            // 
            // dSFacturaFiltro
            // 
            this.dSFacturaFiltro.DataSetName = "DSFacturaFiltro";
            this.dSFacturaFiltro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pASeleccionarFacturaRangoFechasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.RepFacturasFiltro.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(17, 133);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(981, 595);
            this.reportViewer1.TabIndex = 0;
            // 
            // pA_SeleccionarFacturaRangoFechasTableAdapter
            // 
            this.pA_SeleccionarFacturaRangoFechasTableAdapter.ClearBeforeFill = true;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(129, 82);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 22);
            this.dtpInicio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "y";
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(403, 82);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 22);
            this.dtpFin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Facturas por filtro";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(651, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 30);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmRepFacturasFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1019, 740);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRepFacturasFiltro";
            this.Text = "FrmRepFacturasFiltro";
            this.Load += new System.EventHandler(this.FrmRepFacturasFiltro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pASeleccionarFacturaRangoFechasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturaFiltro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pASeleccionarFacturaRangoFechasBindingSource;
        private DSFacturaFiltro dSFacturaFiltro;
        private DSFacturaFiltroTableAdapters.PA_SeleccionarFacturaRangoFechasTableAdapter pA_SeleccionarFacturaRangoFechasTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
    }
}