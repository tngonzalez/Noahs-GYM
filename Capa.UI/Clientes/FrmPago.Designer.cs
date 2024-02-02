
namespace Capa.UI.Clientes
{
    partial class FrmPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPago));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumTarjeta = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtInfoCliente = new System.Windows.Forms.RichTextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCredito = new System.Windows.Forms.RadioButton();
            this.rbtnDebito = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnnio = new System.Windows.Forms.TextBox();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvTipoCambio = new System.Windows.Forms.DataGridView();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.txtQR = new System.Windows.Forms.TextBox();
            this.pctCodigo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCambio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forma de pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de tarjeta";
            // 
            // txtNumTarjeta
            // 
            this.txtNumTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTarjeta.ForeColor = System.Drawing.Color.Black;
            this.txtNumTarjeta.Location = new System.Drawing.Point(15, 144);
            this.txtNumTarjeta.Name = "txtNumTarjeta";
            this.txtNumTarjeta.Size = new System.Drawing.Size(239, 22);
            this.txtNumTarjeta.TabIndex = 2;
            // 
            // txtMes
            // 
            this.txtMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes.ForeColor = System.Drawing.Color.Gray;
            this.txtMes.Location = new System.Drawing.Point(15, 207);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(36, 22);
            this.txtMes.TabIndex = 3;
            this.txtMes.Text = "MM";
            this.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMes.Click += new System.EventHandler(this.txtMes_Click);
            this.txtMes.Enter += new System.EventHandler(this.txtMes_Enter);
            this.txtMes.Leave += new System.EventHandler(this.txtMes_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de caducidad";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Gray;
            this.txtCodigo.Location = new System.Drawing.Point(182, 207);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(38, 22);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.Text = "CVC";
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Código de seguridad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Propietario";
            // 
            // rtxtInfoCliente
            // 
            this.rtxtInfoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtInfoCliente.Enabled = false;
            this.rtxtInfoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtInfoCliente.Location = new System.Drawing.Point(12, 270);
            this.rtxtInfoCliente.Name = "rtxtInfoCliente";
            this.rtxtInfoCliente.Size = new System.Drawing.Size(325, 64);
            this.rtxtInfoCliente.TabIndex = 8;
            this.rtxtInfoCliente.Text = "";
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.btnConfirma.FlatAppearance.BorderSize = 0;
            this.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.Location = new System.Drawing.Point(12, 360);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(149, 48);
            this.btnConfirma.TabIndex = 6;
            this.btnConfirma.Text = "Confimar pago";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(182, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(149, 48);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCredito);
            this.groupBox1.Controls.Add(this.rbtnDebito);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Tarjeta";
            // 
            // rbtnCredito
            // 
            this.rbtnCredito.AutoSize = true;
            this.rbtnCredito.Location = new System.Drawing.Point(166, 32);
            this.rbtnCredito.Name = "rbtnCredito";
            this.rbtnCredito.Size = new System.Drawing.Size(132, 20);
            this.rbtnCredito.TabIndex = 15;
            this.rbtnCredito.TabStop = true;
            this.rbtnCredito.Text = "Tarjeta de crédito";
            this.rbtnCredito.UseVisualStyleBackColor = true;
            // 
            // rbtnDebito
            // 
            this.rbtnDebito.AutoSize = true;
            this.rbtnDebito.Location = new System.Drawing.Point(16, 32);
            this.rbtnDebito.Name = "rbtnDebito";
            this.rbtnDebito.Size = new System.Drawing.Size(129, 20);
            this.rbtnDebito.TabIndex = 14;
            this.rbtnDebito.TabStop = true;
            this.rbtnDebito.Text = "Tarjeta de débito";
            this.rbtnDebito.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "/";
            // 
            // txtAnnio
            // 
            this.txtAnnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnio.ForeColor = System.Drawing.Color.Gray;
            this.txtAnnio.Location = new System.Drawing.Point(77, 207);
            this.txtAnnio.Name = "txtAnnio";
            this.txtAnnio.Size = new System.Drawing.Size(36, 22);
            this.txtAnnio.TabIndex = 4;
            this.txtAnnio.Text = "AA";
            this.txtAnnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnnio.Enter += new System.EventHandler(this.txtAnnio_Enter);
            this.txtAnnio.Leave += new System.EventHandler(this.txtAnnio_Leave);
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // dgvTipoCambio
            // 
            this.dgvTipoCambio.AllowUserToResizeColumns = false;
            this.dgvTipoCambio.AllowUserToResizeRows = false;
            this.dgvTipoCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTipoCambio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoCambio.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dgvTipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTipoCambio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTipoCambio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipoCambio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTipoCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoCambio.EnableHeadersVisualStyles = false;
            this.dgvTipoCambio.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.dgvTipoCambio.Location = new System.Drawing.Point(12, 436);
            this.dgvTipoCambio.Name = "dgvTipoCambio";
            this.dgvTipoCambio.ReadOnly = true;
            this.dgvTipoCambio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTipoCambio.RowHeadersVisible = false;
            this.dgvTipoCambio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTipoCambio.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTipoCambio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoCambio.Size = new System.Drawing.Size(325, 132);
            this.dgvTipoCambio.TabIndex = 25;
            this.dgvTipoCambio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoCambio_CellClick);
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.ForeColor = System.Drawing.Color.Black;
            this.txtCambio.Location = new System.Drawing.Point(182, 9);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(69, 22);
            this.txtCambio.TabIndex = 26;
            this.txtCambio.Visible = false;
            // 
            // txtQR
            // 
            this.txtQR.Enabled = false;
            this.txtQR.Location = new System.Drawing.Point(277, 11);
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(100, 20);
            this.txtQR.TabIndex = 27;
            this.txtQR.Visible = false;
            // 
            // pctCodigo
            // 
            this.pctCodigo.Image = ((System.Drawing.Image)(resources.GetObject("pctCodigo.Image")));
            this.pctCodigo.Location = new System.Drawing.Point(226, 207);
            this.pctCodigo.Name = "pctCodigo";
            this.pctCodigo.Size = new System.Drawing.Size(16, 16);
            this.pctCodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctCodigo.TabIndex = 14;
            this.pctCodigo.TabStop = false;
            this.pctCodigo.Click += new System.EventHandler(this.pctCodigo_Click);
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(359, 601);
            this.Controls.Add(this.txtQR);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.dgvTipoCambio);
            this.Controls.Add(this.pctCodigo);
            this.Controls.Add(this.txtAnnio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.rtxtInfoCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumTarjeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPago";
            this.Load += new System.EventHandler(this.FrmPago_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCambio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumTarjeta;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtInfoCliente;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnCredito;
        private System.Windows.Forms.RadioButton rbtnDebito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnnio;
        private System.Windows.Forms.PictureBox pctCodigo;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.DataGridView dgvTipoCambio;
        private System.Windows.Forms.TextBox txtQR;
        public System.Windows.Forms.TextBox txtCambio;
    }
}