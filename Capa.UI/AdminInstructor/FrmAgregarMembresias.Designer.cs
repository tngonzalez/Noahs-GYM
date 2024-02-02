
namespace Capa.UI.AdminInstructor
{
    partial class FrmAgregarMembresias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarMembresias));
            this.grbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtSemanas = new System.Windows.Forms.TextBox();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMembresia = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMeses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSemanas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembresia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosPersonales
            // 
            this.grbDatosPersonales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(170)))), ((int)(((byte)(74)))));
            this.grbDatosPersonales.Controls.Add(this.btnEliminar);
            this.grbDatosPersonales.Controls.Add(this.btnGuardar);
            this.grbDatosPersonales.Controls.Add(this.txtSemanas);
            this.grbDatosPersonales.Controls.Add(this.txtMeses);
            this.grbDatosPersonales.Controls.Add(this.label9);
            this.grbDatosPersonales.Controls.Add(this.txtNombre);
            this.grbDatosPersonales.Controls.Add(this.label5);
            this.grbDatosPersonales.Controls.Add(this.txtPrecio);
            this.grbDatosPersonales.Controls.Add(this.label4);
            this.grbDatosPersonales.Controls.Add(this.label3);
            this.grbDatosPersonales.Controls.Add(this.txtCodigo);
            this.grbDatosPersonales.Controls.Add(this.label2);
            this.grbDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosPersonales.Location = new System.Drawing.Point(58, 65);
            this.grbDatosPersonales.Name = "grbDatosPersonales";
            this.grbDatosPersonales.Size = new System.Drawing.Size(437, 278);
            this.grbDatosPersonales.TabIndex = 27;
            this.grbDatosPersonales.TabStop = false;
            this.grbDatosPersonales.Text = "Datos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEliminar.Location = new System.Drawing.Point(256, 193);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 41);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardar.Location = new System.Drawing.Point(117, 193);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 41);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar\r\n";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtSemanas
            // 
            this.txtSemanas.Location = new System.Drawing.Point(117, 151);
            this.txtSemanas.Name = "txtSemanas";
            this.txtSemanas.Size = new System.Drawing.Size(264, 22);
            this.txtSemanas.TabIndex = 5;
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(117, 120);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(264, 22);
            this.txtMeses.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Meses";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(264, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(117, 89);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(264, 22);
            this.txtPrecio.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Semanas";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(117, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(264, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 42);
            this.label1.TabIndex = 28;
            this.label1.Text = "Membresías\r\n";
            // 
            // dgvMembresia
            // 
            this.dgvMembresia.AllowUserToResizeColumns = false;
            this.dgvMembresia.AllowUserToResizeRows = false;
            this.dgvMembresia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMembresia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembresia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(169)))));
            this.dgvMembresia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMembresia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMembresia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembresia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMembresia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembresia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colPrecio,
            this.colMeses,
            this.colSemanas});
            this.dgvMembresia.EnableHeadersVisualStyles = false;
            this.dgvMembresia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.dgvMembresia.Location = new System.Drawing.Point(12, 359);
            this.dgvMembresia.Name = "dgvMembresia";
            this.dgvMembresia.ReadOnly = true;
            this.dgvMembresia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMembresia.RowHeadersVisible = false;
            this.dgvMembresia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMembresia.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMembresia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembresia.Size = new System.Drawing.Size(538, 201);
            this.dgvMembresia.TabIndex = 29;
            this.dgvMembresia.SelectionChanged += new System.EventHandler(this.dgvMembresia_SelectionChanged);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "ID";
            this.colId.HeaderText = "Código";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "Nombre";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.DataPropertyName = "Precio";
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colMeses
            // 
            this.colMeses.DataPropertyName = "Meses";
            this.colMeses.HeaderText = "Meses";
            this.colMeses.Name = "colMeses";
            this.colMeses.ReadOnly = true;
            // 
            // colSemanas
            // 
            this.colSemanas.DataPropertyName = "Semanas";
            this.colSemanas.HeaderText = "Semanas";
            this.colSemanas.Name = "colSemanas";
            this.colSemanas.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(512, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(38, 29);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // FrmAgregarMembresias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(562, 572);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvMembresia);
            this.Controls.Add(this.grbDatosPersonales);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgregarMembresias";
            this.Text = "FrmAgregarMembresias";
            this.Load += new System.EventHandler(this.FrmAgregarMembresias_Load);
            this.grbDatosPersonales.ResumeLayout(false);
            this.grbDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembresia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosPersonales;
        private System.Windows.Forms.TextBox txtSemanas;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMembresia;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMeses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSemanas;
    }
}