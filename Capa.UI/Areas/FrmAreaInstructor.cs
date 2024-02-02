using Capa.Entidades.Entidades;
using Capa.UI.Acceso;
using Capa.UI.Clientes;
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

namespace Capa.UI.Mantenimientos
{
    public partial class FrmAreaInstructor : Form
    {
        public FrmAreaInstructor()
        {
            InitializeComponent();
        }
        public Instructor Instructor { get; set; }

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


        #region Estos eventos no son usados 
        private void tslMiembros_Click(object sender, EventArgs e)
        {
            
        }
        private void tslRutinas_Click(object sender, EventArgs e)
        {
           
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        #endregion

        private void ptbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        #region Estos eventos no están en uso
        private void btnInformes_Click(object sender, EventArgs e)
        {
        }

        private void btnInformeMedidas_Click(object sender, EventArgs e)
        {
        }

        private void btnInformeRutinas_Click(object sender, EventArgs e)
        {
        }

        private void btnInformeMembresia_Click(object sender, EventArgs e)
        {
        }

        private void btnInformeRegistroConex_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private void pcbCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            this.Close();
            FrmAcceso oAcceso = new FrmAcceso();
            oAcceso.ShowDialog(); 
        }

        private void btnMiembros_Click(object sender, EventArgs e)
        {
            //Abrir el frm 
            OpenChildForm(new FrmCliente()); 
        }

        private void btnRutinas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRutinas()); 
        }

        private void FrmAreaInstructor_Load(object sender, EventArgs e)
        {
            //Conver Imagen
            ImageConverter img = new ImageConverter();
            pictureBoxCircular1.Image = (Bitmap)img.ConvertFrom(Instructor.Foto);

            lblNombreCompleto.Text = Instructor.Nombre + "\n" + Instructor.Apellidos;
            lblID.Text = Instructor.ID.ToString();
        }
    }
}
