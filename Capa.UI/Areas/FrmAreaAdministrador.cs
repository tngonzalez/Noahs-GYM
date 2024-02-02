using Capa.Entidades.Entidades;
using Capa.UI.Acceso;
using Capa.UI.AdminInstructor;
using Capa.UI.Clientes;
using Capa.UI.Reportes;
using Capa.UI.Rutinas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI.Areas
{
    public partial class FrmAreaAdministrador : Form
    {
        public FrmAreaAdministrador()
        {
            InitializeComponent();
        }
        public Administrador Administrador { get; set; }

        #region Permite abrir Frm dentro del Panel 

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelHijo.Controls.Add(childForm);
            panelHijo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        #endregion
        private void btnMiembros_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCliente()); 
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRegistroInstructor());
        }

        private void btnRutinas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRutinas());

        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            SubMenuReporte.Visible = true;
        }

        private void btnInformeRutinas_Click(object sender, EventArgs e)
        {
            SubMenuReporte.Visible = false;
        }

        private void btnInformeMembresia_Click(object sender, EventArgs e)
        {
            SubMenuReporte.Visible = false;

            OpenChildForm(new FrmAgregarMembresias()); 
        }

        private void btnInformeRegistroConex_Click(object sender, EventArgs e)
        {
            SubMenuReporte.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SubMenuReporte.Visible = false;
            OpenChildForm(new FrmRepFacturasFiltro()); 
        }

        private void pcbCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            FrmAcceso frm = new FrmAcceso();
            frm.ShowDialog();
; 
            
        }

        private void ptbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAdministradorRegistro()); 
        }

        private void FrmAreaAdministrador_Load(object sender, EventArgs e)
        {
            //Conver Imagen
            ImageConverter img = new ImageConverter();
            pictureBoxCircular1.Image = (Bitmap)img.ConvertFrom(Administrador.Foto);

            lblNombreCompleto.Text = Administrador.Nombre + "\n" + Administrador.Apellidos;
            lblID.Text = Administrador.ID.ToString();
        }

        private void btnInformeRutinas_Click_1(object sender, EventArgs e)
        {
            SubMenuReporte.Visible = false;

            subMenuRutina.Visible = true;
        }

        private void btnRepEjerciciosPop_Click(object sender, EventArgs e)
        {
            subMenuRutina.Visible = false;
           OpenChildForm(new FrmPopulares()); 

        }

        private void btnRepEjerClientes_Click(object sender, EventArgs e)
        {
            subMenuRutina.Visible = false;
            OpenChildForm(new FrmRutinaClienteXIDC()); 

        }

        private void btnEjerciciosTipo_Click(object sender, EventArgs e)
        {
            subMenuRutina.Visible = false;
            OpenChildForm(new FrmAgrupacionXTipoEjer()); 
        }

        private void btnMorosos_Click(object sender, EventArgs e)
        {
            SubMenuReporte.Visible = false;

            OpenChildForm(new FrmRepMorosos()); 
        }
    }
}
