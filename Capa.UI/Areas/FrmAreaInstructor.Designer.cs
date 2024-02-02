
namespace Capa.UI.Mantenimientos
{
    partial class FrmAreaInstructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAreaInstructor));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.ptbSalir = new System.Windows.Forms.PictureBox();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.pictureBoxCircular1 = new Capa.UI.Control.PictureBoxCircular();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbCerrarSesion = new System.Windows.Forms.PictureBox();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRutinas = new System.Windows.Forms.Button();
            this.btnMiembros = new System.Windows.Forms.Button();
            this.panelHijo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).BeginInit();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCircular1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCerrarSesion)).BeginInit();
            this.panelHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(150)))), ((int)(((byte)(143)))));
            this.barraTitulo.Controls.Add(this.ptbSalir);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1300, 33);
            this.barraTitulo.TabIndex = 0;
            // 
            // ptbSalir
            // 
            this.ptbSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbSalir.Image = global::Capa.UI.Properties.Resources.Salir;
            this.ptbSalir.Location = new System.Drawing.Point(1258, 0);
            this.ptbSalir.Name = "ptbSalir";
            this.ptbSalir.Size = new System.Drawing.Size(30, 30);
            this.ptbSalir.TabIndex = 0;
            this.ptbSalir.TabStop = false;
            this.ptbSalir.Click += new System.EventHandler(this.ptbSalir_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(150)))), ((int)(((byte)(143)))));
            this.PanelMenu.Controls.Add(this.pictureBoxCircular1);
            this.PanelMenu.Controls.Add(this.label1);
            this.PanelMenu.Controls.Add(this.pcbCerrarSesion);
            this.PanelMenu.Controls.Add(this.lblNombreCompleto);
            this.PanelMenu.Controls.Add(this.lblID);
            this.PanelMenu.Controls.Add(this.panel2);
            this.PanelMenu.Controls.Add(this.panel1);
            this.PanelMenu.Controls.Add(this.btnRutinas);
            this.PanelMenu.Controls.Add(this.btnMiembros);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 33);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(165, 679);
            this.PanelMenu.TabIndex = 1;
            // 
            // pictureBoxCircular1
            // 
            this.pictureBoxCircular1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureBoxCircular1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pictureBoxCircular1.BorderColor2 = System.Drawing.Color.HotPink;
            this.pictureBoxCircular1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pictureBoxCircular1.BorderSize = 2;
            this.pictureBoxCircular1.GradientAngle = 50F;
            this.pictureBoxCircular1.Location = new System.Drawing.Point(12, 0);
            this.pictureBoxCircular1.Name = "pictureBoxCircular1";
            this.pictureBoxCircular1.Size = new System.Drawing.Size(81, 81);
            this.pictureBoxCircular1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCircular1.TabIndex = 16;
            this.pictureBoxCircular1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID: ";
            // 
            // pcbCerrarSesion
            // 
            this.pcbCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("pcbCerrarSesion.Image")));
            this.pcbCerrarSesion.Location = new System.Drawing.Point(12, 603);
            this.pcbCerrarSesion.Name = "pcbCerrarSesion";
            this.pcbCerrarSesion.Size = new System.Drawing.Size(64, 64);
            this.pcbCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbCerrarSesion.TabIndex = 0;
            this.pcbCerrarSesion.TabStop = false;
            this.pcbCerrarSesion.Click += new System.EventHandler(this.pcbCerrarSesion_Click);
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.Location = new System.Drawing.Point(0, 90);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(135, 18);
            this.lblNombreCompleto.TabIndex = 18;
            this.lblNombreCompleto.Text = "Nombre Completo ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(36, 127);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 16);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(92)))));
            this.panel2.Location = new System.Drawing.Point(-1, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 36);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(92)))));
            this.panel1.Location = new System.Drawing.Point(-1, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 36);
            this.panel1.TabIndex = 2;
            // 
            // btnRutinas
            // 
            this.btnRutinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(150)))), ((int)(((byte)(143)))));
            this.btnRutinas.FlatAppearance.BorderSize = 0;
            this.btnRutinas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(92)))));
            this.btnRutinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutinas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutinas.Image = ((System.Drawing.Image)(resources.GetObject("btnRutinas.Image")));
            this.btnRutinas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRutinas.Location = new System.Drawing.Point(2, 207);
            this.btnRutinas.Name = "btnRutinas";
            this.btnRutinas.Size = new System.Drawing.Size(162, 36);
            this.btnRutinas.TabIndex = 3;
            this.btnRutinas.Text = "Rutinas";
            this.btnRutinas.UseVisualStyleBackColor = false;
            this.btnRutinas.Click += new System.EventHandler(this.btnRutinas_Click);
            // 
            // btnMiembros
            // 
            this.btnMiembros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(150)))), ((int)(((byte)(143)))));
            this.btnMiembros.FlatAppearance.BorderSize = 0;
            this.btnMiembros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(99)))), ((int)(((byte)(92)))));
            this.btnMiembros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiembros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiembros.Image = ((System.Drawing.Image)(resources.GetObject("btnMiembros.Image")));
            this.btnMiembros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiembros.Location = new System.Drawing.Point(2, 172);
            this.btnMiembros.Name = "btnMiembros";
            this.btnMiembros.Size = new System.Drawing.Size(162, 36);
            this.btnMiembros.TabIndex = 0;
            this.btnMiembros.Text = "Miembros";
            this.btnMiembros.UseVisualStyleBackColor = false;
            this.btnMiembros.Click += new System.EventHandler(this.btnMiembros_Click);
            // 
            // panelHijo
            // 
            this.panelHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(177)))), ((int)(((byte)(169)))));
            this.panelHijo.Controls.Add(this.pictureBox2);
            this.panelHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHijo.Location = new System.Drawing.Point(165, 33);
            this.panelHijo.Name = "panelHijo";
            this.panelHijo.Size = new System.Drawing.Size(1135, 679);
            this.panelHijo.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Capa.UI.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(347, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(441, 365);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // FrmAreaInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1300, 712);
            this.Controls.Add(this.panelHijo);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAreaInstructor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManCliente";
            this.Load += new System.EventHandler(this.FrmAreaInstructor_Load);
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSalir)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCircular1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCerrarSesion)).EndInit();
            this.panelHijo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button btnMiembros;
        private System.Windows.Forms.Panel panelHijo;
        private System.Windows.Forms.PictureBox ptbSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRutinas;
        private System.Windows.Forms.PictureBox pcbCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Control.PictureBoxCircular pictureBoxCircular1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblID;
    }
}