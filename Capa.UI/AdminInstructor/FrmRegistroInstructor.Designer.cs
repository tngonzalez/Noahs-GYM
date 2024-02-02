
namespace Capa.UI.AdminInstructor
{
    partial class FrmRegistroInstructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroInstructor));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvInstructor = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.grbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnSeleccionFoto = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructor)).BeginInit();
            this.grbDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(933, 288);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 45);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(769, 288);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(111, 45);
            this.btnNuevo.TabIndex = 35;
            this.btnNuevo.Text = "Guardar";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvInstructor
            // 
            this.dgvInstructor.AllowUserToResizeColumns = false;
            this.dgvInstructor.AllowUserToResizeRows = false;
            this.dgvInstructor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInstructor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInstructor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(169)))));
            this.dgvInstructor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInstructor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInstructor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInstructor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInstructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstructor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colApellidos,
            this.colFechaNac,
            this.colCorreo,
            this.colClave,
            this.colGenero,
            this.colFoto});
            this.dgvInstructor.EnableHeadersVisualStyles = false;
            this.dgvInstructor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.dgvInstructor.Location = new System.Drawing.Point(15, 359);
            this.dgvInstructor.Name = "dgvInstructor";
            this.dgvInstructor.ReadOnly = true;
            this.dgvInstructor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInstructor.RowHeadersVisible = false;
            this.dgvInstructor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInstructor.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInstructor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstructor.Size = new System.Drawing.Size(1082, 295);
            this.dgvInstructor.TabIndex = 34;
            this.dgvInstructor.SelectionChanged += new System.EventHandler(this.dgvInstructor_SelectionChanged);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "ID";
            this.colId.HeaderText = "Identificación";
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
            // colApellidos
            // 
            this.colApellidos.DataPropertyName = "Apellidos";
            this.colApellidos.HeaderText = "Apellidos";
            this.colApellidos.Name = "colApellidos";
            this.colApellidos.ReadOnly = true;
            // 
            // colFechaNac
            // 
            this.colFechaNac.DataPropertyName = "FechaNacimiento";
            this.colFechaNac.HeaderText = "Fecha Nacimiento";
            this.colFechaNac.Name = "colFechaNac";
            this.colFechaNac.ReadOnly = true;
            // 
            // colCorreo
            // 
            this.colCorreo.DataPropertyName = "Correo";
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.ReadOnly = true;
            // 
            // colClave
            // 
            this.colClave.DataPropertyName = "Clave";
            this.colClave.HeaderText = "Clave";
            this.colClave.Name = "colClave";
            this.colClave.ReadOnly = true;
            // 
            // colGenero
            // 
            this.colGenero.DataPropertyName = "Genero";
            this.colGenero.HeaderText = "Genero";
            this.colGenero.Name = "colGenero";
            this.colGenero.ReadOnly = true;
            // 
            // colFoto
            // 
            this.colFoto.DataPropertyName = "Foto";
            this.colFoto.HeaderText = "Foto";
            this.colFoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colFoto.Name = "colFoto";
            this.colFoto.ReadOnly = true;
            // 
            // grbDatosPersonales
            // 
            this.grbDatosPersonales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.grbDatosPersonales.Controls.Add(this.txtContra);
            this.grbDatosPersonales.Controls.Add(this.btnSeleccionFoto);
            this.grbDatosPersonales.Controls.Add(this.label11);
            this.grbDatosPersonales.Controls.Add(this.label10);
            this.grbDatosPersonales.Controls.Add(this.label8);
            this.grbDatosPersonales.Controls.Add(this.cmbGenero);
            this.grbDatosPersonales.Controls.Add(this.label9);
            this.grbDatosPersonales.Controls.Add(this.txtCorreo);
            this.grbDatosPersonales.Controls.Add(this.label6);
            this.grbDatosPersonales.Controls.Add(this.dtpFechaNacimiento);
            this.grbDatosPersonales.Controls.Add(this.txtNombre);
            this.grbDatosPersonales.Controls.Add(this.label5);
            this.grbDatosPersonales.Controls.Add(this.txtApellidos);
            this.grbDatosPersonales.Controls.Add(this.label4);
            this.grbDatosPersonales.Controls.Add(this.label3);
            this.grbDatosPersonales.Controls.Add(this.txtID);
            this.grbDatosPersonales.Controls.Add(this.label2);
            this.grbDatosPersonales.Controls.Add(this.pcbFoto);
            this.grbDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosPersonales.Location = new System.Drawing.Point(15, 65);
            this.grbDatosPersonales.Name = "grbDatosPersonales";
            this.grbDatosPersonales.Size = new System.Drawing.Size(719, 278);
            this.grbDatosPersonales.TabIndex = 32;
            this.grbDatosPersonales.TabStop = false;
            this.grbDatosPersonales.Text = "Datos Personales";
            // 
            // txtContra
            // 
            this.txtContra.ForeColor = System.Drawing.Color.Gray;
            this.txtContra.Location = new System.Drawing.Point(197, 177);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(264, 22);
            this.txtContra.TabIndex = 6;
            // 
            // btnSeleccionFoto
            // 
            this.btnSeleccionFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.btnSeleccionFoto.FlatAppearance.BorderSize = 0;
            this.btnSeleccionFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionFoto.Location = new System.Drawing.Point(501, 235);
            this.btnSeleccionFoto.Name = "btnSeleccionFoto";
            this.btnSeleccionFoto.Size = new System.Drawing.Size(192, 30);
            this.btnSeleccionFoto.TabIndex = 9;
            this.btnSeleccionFoto.Text = "Seleccionar foto de perfil";
            this.btnSeleccionFoto.UseVisualStyleBackColor = false;
            this.btnSeleccionFoto.Click += new System.EventHandler(this.btnSeleccionFoto_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Clave";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(547, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Foto de perfil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Contacto";
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(197, 117);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(264, 24);
            this.cmbGenero.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Genero";
            // 
            // txtCorreo
            // 
            this.txtCorreo.ForeColor = System.Drawing.Color.Gray;
            this.txtCorreo.Location = new System.Drawing.Point(195, 234);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(264, 22);
            this.txtCorreo.TabIndex = 7;
            this.txtCorreo.Text = "someone@ejemplo.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "E-mail";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(197, 148);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(264, 22);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(197, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(264, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(197, 88);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(264, 22);
            this.txtApellidos.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(197, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(264, 22);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificación";
            // 
            // pcbFoto
            // 
            this.pcbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbFoto.Location = new System.Drawing.Point(501, 44);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(192, 173);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 0;
            this.pcbFoto.TabStop = false;
            this.pcbFoto.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 55);
            this.label1.TabIndex = 33;
            this.label1.Text = "Instructores";
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // FrmRegistroInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1109, 666);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvInstructor);
            this.Controls.Add(this.grbDatosPersonales);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistroInstructor";
            this.Text = "FrmRegistroInstructor";
            this.Load += new System.EventHandler(this.FrmRegistroInstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructor)).EndInit();
            this.grbDatosPersonales.ResumeLayout(false);
            this.grbDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvInstructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewImageColumn colFoto;
        private System.Windows.Forms.GroupBox grbDatosPersonales;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button btnSeleccionFoto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider erp;
    }
}