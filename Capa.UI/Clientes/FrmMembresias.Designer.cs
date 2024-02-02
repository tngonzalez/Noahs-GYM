
namespace Capa.UI.Clientes
{
    partial class FrmMembresias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMembresias));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSemanas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPaquete = new System.Windows.Forms.ComboBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarMembresia = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnPagarMembresia = new System.Windows.Forms.Button();
            this.dgvPlanInscrito = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDPaquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptbSalir = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanInscrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(170)))), ((int)(((byte)(74)))));
            this.groupBox1.Controls.Add(this.pcbFoto);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // pcbFoto
            // 
            this.pcbFoto.Location = new System.Drawing.Point(516, 33);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(141, 108);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbFoto.TabIndex = 7;
            this.pcbFoto.TabStop = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(122, 107);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(316, 22);
            this.txtCorreo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(122, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(316, 22);
            this.txtID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Identificación";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Location = new System.Drawing.Point(262, 70);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(176, 22);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(122, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 42);
            this.label1.TabIndex = 29;
            this.label1.Text = "Membresías\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(170)))), ((int)(((byte)(74)))));
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.dtpVencimiento);
            this.groupBox2.Controls.Add(this.dtpIngreso);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSemanas);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbPaquete);
            this.groupBox2.Controls.Add(this.txtMes);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 179);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Membresía";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(356, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(444, 33);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(199, 22);
            this.txtPrecio.TabIndex = 12;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Enabled = false;
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(444, 111);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(200, 22);
            this.dtpVencimiento.TabIndex = 11;
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngreso.Location = new System.Drawing.Point(443, 72);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(200, 22);
            this.dtpIngreso.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Vencimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ingreso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Semanas";
            // 
            // txtSemanas
            // 
            this.txtSemanas.Enabled = false;
            this.txtSemanas.Location = new System.Drawing.Point(122, 112);
            this.txtSemanas.Name = "txtSemanas";
            this.txtSemanas.Size = new System.Drawing.Size(217, 22);
            this.txtSemanas.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Meses";
            // 
            // cmbPaquete
            // 
            this.cmbPaquete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaquete.FormattingEnabled = true;
            this.cmbPaquete.Location = new System.Drawing.Point(122, 36);
            this.cmbPaquete.Name = "cmbPaquete";
            this.cmbPaquete.Size = new System.Drawing.Size(217, 24);
            this.cmbPaquete.TabIndex = 2;
            this.cmbPaquete.SelectedIndexChanged += new System.EventHandler(this.cmbPaquete_SelectedIndexChanged);
            // 
            // txtMes
            // 
            this.txtMes.Enabled = false;
            this.txtMes.Location = new System.Drawing.Point(122, 76);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(217, 22);
            this.txtMes.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Paquete";
            // 
            // btnAgregarMembresia
            // 
            this.btnAgregarMembresia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.btnAgregarMembresia.FlatAppearance.BorderSize = 0;
            this.btnAgregarMembresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMembresia.Location = new System.Drawing.Point(22, 444);
            this.btnAgregarMembresia.Name = "btnAgregarMembresia";
            this.btnAgregarMembresia.Size = new System.Drawing.Size(183, 34);
            this.btnAgregarMembresia.TabIndex = 30;
            this.btnAgregarMembresia.Text = "Guardar";
            this.btnAgregarMembresia.UseVisualStyleBackColor = false;
            this.btnAgregarMembresia.Click += new System.EventHandler(this.btnAgregarMembresia_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(277, 444);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(183, 34);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnPagarMembresia
            // 
            this.btnPagarMembresia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.btnPagarMembresia.FlatAppearance.BorderSize = 0;
            this.btnPagarMembresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarMembresia.Location = new System.Drawing.Point(523, 444);
            this.btnPagarMembresia.Name = "btnPagarMembresia";
            this.btnPagarMembresia.Size = new System.Drawing.Size(183, 34);
            this.btnPagarMembresia.TabIndex = 32;
            this.btnPagarMembresia.Text = "Pagar membresía";
            this.btnPagarMembresia.UseVisualStyleBackColor = false;
            this.btnPagarMembresia.Click += new System.EventHandler(this.btnPagarMembresia_Click);
            // 
            // dgvPlanInscrito
            // 
            this.dgvPlanInscrito.AllowUserToResizeColumns = false;
            this.dgvPlanInscrito.AllowUserToResizeRows = false;
            this.dgvPlanInscrito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlanInscrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanInscrito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(169)))));
            this.dgvPlanInscrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlanInscrito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPlanInscrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanInscrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlanInscrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanInscrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colIDCliente,
            this.colIDPaquete,
            this.colIngreso,
            this.colVencimiento,
            this.colEstado});
            this.dgvPlanInscrito.EnableHeadersVisualStyles = false;
            this.dgvPlanInscrito.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.dgvPlanInscrito.Location = new System.Drawing.Point(12, 499);
            this.dgvPlanInscrito.Name = "dgvPlanInscrito";
            this.dgvPlanInscrito.ReadOnly = true;
            this.dgvPlanInscrito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPlanInscrito.RowHeadersVisible = false;
            this.dgvPlanInscrito.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPlanInscrito.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlanInscrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanInscrito.Size = new System.Drawing.Size(717, 329);
            this.dgvPlanInscrito.TabIndex = 33;
            this.dgvPlanInscrito.SelectionChanged += new System.EventHandler(this.dgvPlanInscrito_SelectionChanged);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colIDCliente
            // 
            this.colIDCliente.DataPropertyName = "IDCliente";
            this.colIDCliente.HeaderText = "Cliente";
            this.colIDCliente.Name = "colIDCliente";
            this.colIDCliente.ReadOnly = true;
            // 
            // colIDPaquete
            // 
            this.colIDPaquete.DataPropertyName = "IDPaquete";
            this.colIDPaquete.HeaderText = "Paquete";
            this.colIDPaquete.Name = "colIDPaquete";
            this.colIDPaquete.ReadOnly = true;
            // 
            // colIngreso
            // 
            this.colIngreso.DataPropertyName = "FechaIngreso";
            this.colIngreso.HeaderText = "Ingreso";
            this.colIngreso.Name = "colIngreso";
            this.colIngreso.ReadOnly = true;
            // 
            // colVencimiento
            // 
            this.colVencimiento.DataPropertyName = "FechaProximoPago";
            this.colVencimiento.HeaderText = "Vencimiento";
            this.colVencimiento.Name = "colVencimiento";
            this.colVencimiento.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "Estado";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // ptbSalir
            // 
            this.ptbSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbSalir.Image = global::Capa.UI.Properties.Resources.Salir;
            this.ptbSalir.Location = new System.Drawing.Point(699, 9);
            this.ptbSalir.Name = "ptbSalir";
            this.ptbSalir.Size = new System.Drawing.Size(30, 30);
            this.ptbSalir.TabIndex = 34;
            this.ptbSalir.TabStop = false;
            this.ptbSalir.Click += new System.EventHandler(this.ptbSalir_Click);
            // 
            // FrmMembresias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(741, 840);
            this.Controls.Add(this.ptbSalir);
            this.Controls.Add(this.dgvPlanInscrito);
            this.Controls.Add(this.btnPagarMembresia);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarMembresia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMembresias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMembresias";
            this.Load += new System.EventHandler(this.FrmMembresias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanInscrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSemanas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPaquete;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarMembresia;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnPagarMembresia;
        private System.Windows.Forms.DataGridView dgvPlanInscrito;
        private System.Windows.Forms.PictureBox ptbSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDPaquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}