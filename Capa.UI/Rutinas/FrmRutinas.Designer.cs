
namespace Capa.UI.Rutinas
{
    partial class FrmRutinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRutinas));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAsignarRutinas = new System.Windows.Forms.Button();
            this.btnMostrarEjercicios = new System.Windows.Forms.Button();
            this.dgvRutinas = new System.Windows.Forms.DataGridView();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEjercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeriexRepeticion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescanso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescanso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSerieXRepeticion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEjercicio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbInstructor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutinas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rutinas";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(772, 432);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(132, 43);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nueva rutina";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(772, 524);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 43);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar rutina";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAsignarRutinas
            // 
            this.btnAsignarRutinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.btnAsignarRutinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarRutinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarRutinas.Location = new System.Drawing.Point(926, 524);
            this.btnAsignarRutinas.Name = "btnAsignarRutinas";
            this.btnAsignarRutinas.Size = new System.Drawing.Size(132, 43);
            this.btnAsignarRutinas.TabIndex = 13;
            this.btnAsignarRutinas.Text = "Asignar rutinas";
            this.btnAsignarRutinas.UseVisualStyleBackColor = false;
            this.btnAsignarRutinas.Click += new System.EventHandler(this.btnAsignarRutinas_Click);
            // 
            // btnMostrarEjercicios
            // 
            this.btnMostrarEjercicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.btnMostrarEjercicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarEjercicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarEjercicios.Location = new System.Drawing.Point(926, 432);
            this.btnMostrarEjercicios.Name = "btnMostrarEjercicios";
            this.btnMostrarEjercicios.Size = new System.Drawing.Size(132, 43);
            this.btnMostrarEjercicios.TabIndex = 14;
            this.btnMostrarEjercicios.Text = "Mostrar ejercicios";
            this.btnMostrarEjercicios.UseVisualStyleBackColor = false;
            this.btnMostrarEjercicios.Click += new System.EventHandler(this.btnMostrarEjercicios_Click);
            // 
            // dgvRutinas
            // 
            this.dgvRutinas.AllowUserToResizeColumns = false;
            this.dgvRutinas.AllowUserToResizeRows = false;
            this.dgvRutinas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRutinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRutinas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(169)))));
            this.dgvRutinas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRutinas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRutinas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRutinas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRutinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCantidad,
            this.colNombre,
            this.colGenero,
            this.colEjercicio,
            this.colSeriexRepeticion,
            this.colDescanso});
            this.dgvRutinas.EnableHeadersVisualStyles = false;
            this.dgvRutinas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.dgvRutinas.Location = new System.Drawing.Point(22, 110);
            this.dgvRutinas.Name = "dgvRutinas";
            this.dgvRutinas.ReadOnly = true;
            this.dgvRutinas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRutinas.RowHeadersVisible = false;
            this.dgvRutinas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRutinas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRutinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRutinas.Size = new System.Drawing.Size(669, 510);
            this.dgvRutinas.TabIndex = 15;
            this.dgvRutinas.SelectionChanged += new System.EventHandler(this.dgvRutinas_SelectionChanged);
            // 
            // colCantidad
            // 
            this.colCantidad.DataPropertyName = "ID";
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "Nombre";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colGenero
            // 
            this.colGenero.DataPropertyName = "IDInstructor";
            this.colGenero.HeaderText = "Instructor";
            this.colGenero.Name = "colGenero";
            this.colGenero.ReadOnly = true;
            // 
            // colEjercicio
            // 
            this.colEjercicio.DataPropertyName = "Ejercicio";
            this.colEjercicio.HeaderText = "Ejercicio";
            this.colEjercicio.Name = "colEjercicio";
            this.colEjercicio.ReadOnly = true;
            // 
            // colSeriexRepeticion
            // 
            this.colSeriexRepeticion.DataPropertyName = "SerieRepeticion";
            this.colSeriexRepeticion.HeaderText = "Serie X Repetición";
            this.colSeriexRepeticion.Name = "colSeriexRepeticion";
            this.colSeriexRepeticion.ReadOnly = true;
            // 
            // colDescanso
            // 
            this.colDescanso.DataPropertyName = "Descanso";
            this.colDescanso.HeaderText = "Descanso";
            this.colDescanso.Name = "colDescanso";
            this.colDescanso.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDescanso);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSerieXRepeticion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbEjercicio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.cmbInstructor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(735, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 269);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rutinas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Descanso";
            // 
            // txtDescanso
            // 
            this.txtDescanso.Location = new System.Drawing.Point(139, 212);
            this.txtDescanso.Name = "txtDescanso";
            this.txtDescanso.Size = new System.Drawing.Size(211, 22);
            this.txtDescanso.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Serie x Repetición";
            // 
            // txtSerieXRepeticion
            // 
            this.txtSerieXRepeticion.Location = new System.Drawing.Point(139, 174);
            this.txtSerieXRepeticion.Name = "txtSerieXRepeticion";
            this.txtSerieXRepeticion.Size = new System.Drawing.Size(211, 22);
            this.txtSerieXRepeticion.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "---------------------------------------------------------------------------------" +
    "---";
            // 
            // cmbEjercicio
            // 
            this.cmbEjercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEjercicio.FormattingEnabled = true;
            this.cmbEjercicio.Location = new System.Drawing.Point(139, 141);
            this.cmbEjercicio.Name = "cmbEjercicio";
            this.cmbEjercicio.Size = new System.Drawing.Size(211, 24);
            this.cmbEjercicio.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ejercicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(211, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // cmbInstructor
            // 
            this.cmbInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstructor.FormattingEnabled = true;
            this.cmbInstructor.Location = new System.Drawing.Point(139, 69);
            this.cmbInstructor.Name = "cmbInstructor";
            this.cmbInstructor.Size = new System.Drawing.Size(211, 24);
            this.cmbInstructor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Instructor";
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(1007, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(51, 20);
            this.txtCodigo.TabIndex = 15;
            this.txtCodigo.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(772, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "Generar reporte";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRutinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1109, 666);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRutinas);
            this.Controls.Add(this.btnMostrarEjercicios);
            this.Controls.Add(this.btnAsignarRutinas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRutinas";
            this.Text = "FrmRutinas";
            this.Load += new System.EventHandler(this.FrmRutinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutinas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAsignarRutinas;
        private System.Windows.Forms.Button btnMostrarEjercicios;
        private System.Windows.Forms.DataGridView dgvRutinas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescanso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSerieXRepeticion;
        private System.Windows.Forms.ComboBox cmbEjercicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbInstructor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEjercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeriexRepeticion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescanso;
        private System.Windows.Forms.Button button1;
    }
}