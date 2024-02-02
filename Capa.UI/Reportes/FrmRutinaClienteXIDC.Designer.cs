
namespace Capa.UI.Reportes
{
    partial class FrmRutinaClienteXIDC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRutinaClienteXIDC));
            this.pASeleccionarAgrupacionRutinaXClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRutinaClienteXIDC = new Capa.UI.DSRutinaClienteXIDC();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pA_SeleccionarAgrupacionRutinaXClienteTableAdapter = new Capa.UI.DSRutinaClienteXIDCTableAdapters.PA_SeleccionarAgrupacionRutinaXClienteTableAdapter();
            this.lblCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pASeleccionarAgrupacionRutinaXClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRutinaClienteXIDC)).BeginInit();
            this.SuspendLayout();
            // 
            // pASeleccionarAgrupacionRutinaXClienteBindingSource
            // 
            this.pASeleccionarAgrupacionRutinaXClienteBindingSource.DataMember = "PA_SeleccionarAgrupacionRutinaXCliente";
            this.pASeleccionarAgrupacionRutinaXClienteBindingSource.DataSource = this.dSRutinaClienteXIDC;
            // 
            // dSRutinaClienteXIDC
            // 
            this.dSRutinaClienteXIDC.DataSetName = "DSRutinaClienteXIDC";
            this.dSRutinaClienteXIDC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(289, 36);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(405, 28);
            this.cmbClientes.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(728, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 34);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 53;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pASeleccionarAgrupacionRutinaXClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.UI.RepRutinaClienteXIDC.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 74);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1017, 533);
            this.reportViewer1.TabIndex = 3;
            // 
            // pA_SeleccionarAgrupacionRutinaXClienteTableAdapter
            // 
            this.pA_SeleccionarAgrupacionRutinaXClienteTableAdapter.ClearBeforeFill = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(181, 39);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(84, 20);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Clientes: ";
            // 
            // FrmRutinaClienteXIDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1041, 619);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRutinaClienteXIDC";
            this.Text = "FrmRutinaClienteXIDC";
            this.Load += new System.EventHandler(this.FrmRutinaClienteXIDC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pASeleccionarAgrupacionRutinaXClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRutinaClienteXIDC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Button btnBuscar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pASeleccionarAgrupacionRutinaXClienteBindingSource;
        private DSRutinaClienteXIDC dSRutinaClienteXIDC;
        private DSRutinaClienteXIDCTableAdapters.PA_SeleccionarAgrupacionRutinaXClienteTableAdapter pA_SeleccionarAgrupacionRutinaXClienteTableAdapter;
        private System.Windows.Forms.Label lblCliente;
    }
}