using Capa.BLL;
using Capa.Entidades.Entidades;
using Capa.UI.Acceso;
using Capa.UI.Clientes;
using Capa.UI.Reportes;
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
    public partial class FrmMantCliente : Form
    {
        public FrmMantCliente()
        {
            InitializeComponent();
        }

        public Cliente Cliente { get; set; }

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
        private void btnDatosP_Click(object sender, EventArgs e)
        {
            var frm = new FrmDatosClientes();
            frm.oCliente = Cliente;

            OpenChildForm(frm);

        }

        private void btnRutinas_Click(object sender, EventArgs e)
        {
            var frm = new FrmRepRutinaParaCliente();
            frm.oCliente = Cliente;
            OpenChildForm(frm); 
        }

        private void btnMembresia_Click(object sender, EventArgs e)
        {
            var frm = new FrmMembresias();
            frm.oCliente = Cliente;
            OpenChildForm(frm);
        }

        private void btnMedidas_Click(object sender, EventArgs e)
        {
            var frm = new FrmRepMedidasC();
            frm.oCliente = Cliente;
            OpenChildForm(frm);
        }

        private void ptbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void FrmMantCliente_Load(object sender, EventArgs e)
        {
            //Conver Imagen
            ImageConverter img = new ImageConverter();
            pictureBoxCircular2.Image = (Bitmap)img.ConvertFrom(Cliente.Foto); 
            lblNombreCompleto.Text = Cliente.Nombre + "\n" + Cliente.Apellidos;
            lblID.Text = Cliente.ID.ToString(); 
        }

        private void btnInfoGYM_Click(object sender, EventArgs e)
        {
            var frm = new FrmInfoGYM();
            OpenChildForm(frm);
        }

        private void pcbCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            FrmAcceso oAcceso = new FrmAcceso();
            oAcceso.ShowDialog();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            var frm = new FrmRepFacturaCliente();
            frm.oCliente = Cliente;
            OpenChildForm(frm);
        }
    }
}
