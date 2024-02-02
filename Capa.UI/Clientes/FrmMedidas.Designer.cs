
namespace Capa.UI.Registros
{
    partial class FrmMedidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedidas));
            this.mskAltura = new System.Windows.Forms.MaskedTextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnCalculos = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpFechaMedidas = new System.Windows.Forms.DateTimePicker();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.txtMetaBasal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMedidas = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAltura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetaBasal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ptbSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // mskAltura
            // 
            this.mskAltura.Location = new System.Drawing.Point(172, 88);
            this.mskAltura.Mask = "0.00";
            this.mskAltura.Name = "mskAltura";
            this.mskAltura.Size = new System.Drawing.Size(235, 23);
            this.mskAltura.TabIndex = 6;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(33, 193);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(108, 17);
            this.lblEstado.TabIndex = 35;
            this.lblEstado.Text = "Estado corporal";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(170, 184);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(235, 23);
            this.txtEstado.TabIndex = 34;
            // 
            // btnCalculos
            // 
            this.btnCalculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.btnCalculos.FlatAppearance.BorderSize = 0;
            this.btnCalculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCalculos.Location = new System.Drawing.Point(475, 70);
            this.btnCalculos.Name = "btnCalculos";
            this.btnCalculos.Size = new System.Drawing.Size(163, 41);
            this.btnCalculos.TabIndex = 7;
            this.btnCalculos.Text = "Realizar calculos";
            this.btnCalculos.UseVisualStyleBackColor = false;
            this.btnCalculos.Click += new System.EventHandler(this.btnCalculos_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 17);
            this.label16.TabIndex = 3;
            this.label16.Text = "Fecha de Medidas";
            // 
            // dtpFechaMedidas
            // 
            this.dtpFechaMedidas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaMedidas.Location = new System.Drawing.Point(172, 24);
            this.dtpFechaMedidas.Name = "dtpFechaMedidas";
            this.dtpFechaMedidas.Size = new System.Drawing.Size(235, 23);
            this.dtpFechaMedidas.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(475, 183);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(163, 41);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(475, 129);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(163, 41);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Metabolismo Basal";
            // 
            // txtIMC
            // 
            this.txtIMC.Enabled = false;
            this.txtIMC.Location = new System.Drawing.Point(172, 120);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(235, 23);
            this.txtIMC.TabIndex = 7;
            // 
            // txtMetaBasal
            // 
            this.txtMetaBasal.Enabled = false;
            this.txtMetaBasal.Location = new System.Drawing.Point(170, 152);
            this.txtMetaBasal.Name = "txtMetaBasal";
            this.txtMetaBasal.Size = new System.Drawing.Size(235, 23);
            this.txtMetaBasal.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "IMC";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(173, 56);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(235, 23);
            this.txtPeso.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "Peso";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 55);
            this.label3.TabIndex = 24;
            this.label3.Text = "Medidas";
            // 
            // dgvMedidas
            // 
            this.dgvMedidas.AllowUserToResizeColumns = false;
            this.dgvMedidas.AllowUserToResizeRows = false;
            this.dgvMedidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedidas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(169)))));
            this.dgvMedidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMedidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colIDCliente,
            this.colPeso,
            this.colAltura,
            this.colIMC,
            this.colMetaBasal,
            this.colFechaMedida});
            this.dgvMedidas.EnableHeadersVisualStyles = false;
            this.dgvMedidas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.dgvMedidas.Location = new System.Drawing.Point(12, 503);
            this.dgvMedidas.Name = "dgvMedidas";
            this.dgvMedidas.ReadOnly = true;
            this.dgvMedidas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMedidas.RowHeadersVisible = false;
            this.dgvMedidas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMedidas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedidas.Size = new System.Drawing.Size(708, 270);
            this.dgvMedidas.TabIndex = 26;
            this.dgvMedidas.SelectionChanged += new System.EventHandler(this.dgvMedidas_SelectionChanged);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "Cantidad";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colIDCliente
            // 
            this.colIDCliente.DataPropertyName = "IDCliente";
            this.colIDCliente.HeaderText = "Identificación";
            this.colIDCliente.Name = "colIDCliente";
            this.colIDCliente.ReadOnly = true;
            // 
            // colPeso
            // 
            this.colPeso.DataPropertyName = "Peso";
            this.colPeso.HeaderText = "Peso";
            this.colPeso.Name = "colPeso";
            this.colPeso.ReadOnly = true;
            // 
            // colAltura
            // 
            this.colAltura.DataPropertyName = "Altura";
            this.colAltura.HeaderText = "Altura";
            this.colAltura.Name = "colAltura";
            this.colAltura.ReadOnly = true;
            // 
            // colIMC
            // 
            this.colIMC.DataPropertyName = "IMC";
            this.colIMC.HeaderText = "IMC";
            this.colIMC.Name = "colIMC";
            this.colIMC.ReadOnly = true;
            // 
            // colMetaBasal
            // 
            this.colMetaBasal.DataPropertyName = "MetaBasal";
            this.colMetaBasal.HeaderText = "Metabolismo Basal";
            this.colMetaBasal.Name = "colMetaBasal";
            this.colMetaBasal.ReadOnly = true;
            // 
            // colFechaMedida
            // 
            this.colFechaMedida.DataPropertyName = "FechaMedida";
            this.colFechaMedida.HeaderText = "Fecha medida";
            this.colFechaMedida.Name = "colFechaMedida";
            this.colFechaMedida.ReadOnly = true;
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(799, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(34, 29);
            this.btnSalir.TabIndex = 34;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(170)))), ((int)(((byte)(74)))));
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnCalculos);
            this.groupBox1.Controls.Add(this.mskAltura);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtMetaBasal);
            this.groupBox1.Controls.Add(this.txtIMC);
            this.groupBox1.Controls.Add(this.dtpFechaMedidas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(20, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 237);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medidas";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(170)))), ((int)(((byte)(74)))));
            this.groupBox2.Controls.Add(this.txtEdad);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pcbFoto);
            this.groupBox2.Controls.Add(this.txtGenero);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtApellidos);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 164);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuario";
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(122, 125);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(316, 22);
            this.txtEdad.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Edad";
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
            // txtGenero
            // 
            this.txtGenero.Enabled = false;
            this.txtGenero.Location = new System.Drawing.Point(122, 94);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(316, 22);
            this.txtGenero.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Genero";
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
            this.txtApellidos.Location = new System.Drawing.Point(262, 62);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(176, 22);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(122, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // ptbSalir
            // 
            this.ptbSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbSalir.Image = global::Capa.UI.Properties.Resources.Salir;
            this.ptbSalir.Location = new System.Drawing.Point(698, 9);
            this.ptbSalir.Name = "ptbSalir";
            this.ptbSalir.Size = new System.Drawing.Size(30, 30);
            this.ptbSalir.TabIndex = 16;
            this.ptbSalir.TabStop = false;
            this.ptbSalir.Click += new System.EventHandler(this.ptbSalir_Click);
            // 
            // FrmMedidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(740, 807);
            this.Controls.Add(this.ptbSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvMedidas);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMedidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMedidas";
            this.Load += new System.EventHandler(this.FrmMedidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFechaMedidas;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.TextBox txtMetaBasal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMedidas;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCalculos;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.MaskedTextBox mskAltura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAltura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetaBasal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaMedida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox ptbSalir;
    }
}