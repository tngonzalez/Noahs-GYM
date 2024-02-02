
namespace Capa.UI.Clientes
{
    partial class FrmCorreoTo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCorreoTo));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.ptbSalir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.rtxtMensaje = new System.Windows.Forms.RichTextBox();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dlg = new System.Windows.Forms.OpenFileDialog();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(150)))), ((int)(((byte)(143)))));
            this.barraTitulo.Controls.Add(this.ptbSalir);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(451, 33);
            this.barraTitulo.TabIndex = 3;
            // 
            // ptbSalir
            // 
            this.ptbSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbSalir.Image = global::Capa.UI.Properties.Resources.Salir;
            this.ptbSalir.Location = new System.Drawing.Point(409, 3);
            this.ptbSalir.Name = "ptbSalir";
            this.ptbSalir.Size = new System.Drawing.Size(30, 30);
            this.ptbSalir.TabIndex = 0;
            this.ptbSalir.TabStop = false;
            this.ptbSalir.Click += new System.EventHandler(this.ptbSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Asunto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contenido: ";
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.btnAdjuntar.FlatAppearance.BorderSize = 0;
            this.btnAdjuntar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjuntar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjuntar.Location = new System.Drawing.Point(136, 166);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(127, 24);
            this.btnAdjuntar.TabIndex = 7;
            this.btnAdjuntar.Text = "Cargar archivo";
            this.btnAdjuntar.UseVisualStyleBackColor = false;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // rtxtMensaje
            // 
            this.rtxtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMensaje.Location = new System.Drawing.Point(23, 272);
            this.rtxtMensaje.Name = "rtxtMensaje";
            this.rtxtMensaje.Size = new System.Drawing.Size(393, 92);
            this.rtxtMensaje.TabIndex = 8;
            this.rtxtMensaje.Text = "";
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsunto.Location = new System.Drawing.Point(20, 202);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(45, 16);
            this.lblAsunto.TabIndex = 9;
            this.lblAsunto.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Asunto adjunto:";
            // 
            // txtPara
            // 
            this.txtPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPara.Location = new System.Drawing.Point(23, 74);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(239, 22);
            this.txtPara.TabIndex = 11;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.Location = new System.Drawing.Point(23, 127);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(239, 22);
            this.txtAsunto.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(92)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(301, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 50);
            this.button2.TabIndex = 13;
            this.button2.Text = "Enviar correo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dlg
            // 
            this.dlg.FileName = "openFileDialog1";
            // 
            // FrmCorreoTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(451, 384);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAsunto);
            this.Controls.Add(this.rtxtMensaje);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCorreoTo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCorreoTo";
            this.Load += new System.EventHandler(this.FrmCorreoTo_Load);
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox ptbSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdjuntar;
        private System.Windows.Forms.RichTextBox rtxtMensaje;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog dlg;
    }
}