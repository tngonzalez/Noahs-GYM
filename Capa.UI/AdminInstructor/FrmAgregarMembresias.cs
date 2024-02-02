using Capa.BLL;
using Capa.Entidades;
using System;
using log4net; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa.Entidades.Entidades;

namespace Capa.UI.AdminInstructor
{
    public partial class FrmAgregarMembresias : Form
    {
        private static readonly ILog GYMEventos = log4net.LogManager.GetLogger("NoahGYMEventos");

        public FrmAgregarMembresias()
        {
            InitializeComponent();
        }
        #region Metodos Variados 

        private void Refrescar()
        {
            dgvMembresia.DataSource = PaqueteGYMBLL.ObtenerTodos();
            dgvMembresia.ClearSelection();
        }
       

        private void Validaciones()
        {
            erp.Clear();

            try
            {
                //ID
                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    erp.SetError(txtCodigo, "Ingrese la inicial de la membresía"); return;
                }

                //Nombre
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    erp.SetError(txtNombre, "Digite el nombre de la membresía"); return;
                }

                //Precio 
                if (string.IsNullOrEmpty(txtPrecio.Text))
                {
                    erp.SetError(txtPrecio, "Digite  el precio de la membresía"); return;
                }
                if (!int.TryParse(txtPrecio.Text, out int pre))
                {
                    erp.SetError(txtPrecio, "Digite  el precio de la membresía"); return;
                }
            }
            catch (Exception error)
            {
                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("\r\nMessage        {0}\n", error.Message);
                msg.AppendFormat("Source         {0}\n", error.Source);
                msg.AppendFormat("StackTrace     {0}\n", error.StackTrace);
                msg.AppendFormat("Data           {0}\n", error.Data);

                GYMEventos.Error(msg.ToString());

                MessageBox.Show("Se ha producido un error :" + error.Message, "Error");
            }
        }

        #endregion
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrEmpty(txtCodigo.Text))
                {
                    PaquetesGYM oPaquete = new PaquetesGYM();

                    oPaquete.ID = txtCodigo.Text.ToString();
                    oPaquete.Nombre = txtNombre.Text;
                    oPaquete.Precio = Convert.ToDouble(txtPrecio.Text);
                    oPaquete.Meses = Convert.ToInt32(txtMeses.Text);
                    oPaquete.Semanas = Convert.ToInt32(txtSemanas.Text); 

                    PaqueteGYMBLL oBLL = new PaqueteGYMBLL();
                    oBLL.Guardar(oPaquete);
                    Refrescar(); 

                    Validaciones(); 

                    //Limpiar
                    txtCodigo.Clear();
                    txtNombre.Clear();
                    txtPrecio.Clear();
                    txtMeses.Clear();
                    txtSemanas.Clear();

                    MessageBox.Show("Membresía agregada exitosamente! :) ", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show("Ingrese los datos solicitados", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigo.Focus();
                }
            }
            catch (Exception error)
            {
                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("\r\nMessage        {0}\n", error.Message);
                msg.AppendFormat("Source         {0}\n", error.Source);
                msg.AppendFormat("StackTrace     {0}\n", error.StackTrace);
                msg.AppendFormat("Data           {0}\n", error.Data);

                GYMEventos.Error(msg.ToString());

                MessageBox.Show("Se ha producido un error :" + error.Message, "Error");
            }
        }

        private void FrmAgregarMembresias_Load(object sender, EventArgs e)
        {
            Refrescar();

            //Limpiar
            dgvMembresia.ClearSelection(); 
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtMeses.Clear();
            txtSemanas.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void dgvMembresia_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                if (dgvMembresia.SelectedRows.Count > 0)
                {
                    var oMe = (PaquetesGYM)dgvMembresia.SelectedRows[0].DataBoundItem;

                    txtCodigo.Text = oMe.ID.ToString();
                    txtNombre.Text = oMe.Nombre;
                    txtPrecio.Text = oMe.Precio.ToString();
                    txtMeses.Text = oMe.Meses.ToString();
                    txtSemanas.Text = oMe.Semanas.ToString(); 
                }
            }
            catch (Exception error)
            {
                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("\r\nMessage        {0}\n", error.Message);
                msg.AppendFormat("Source         {0}\n", error.Source);
                msg.AppendFormat("StackTrace     {0}\n", error.StackTrace);
                msg.AppendFormat("Data           {0}\n", error.Data);

                GYMEventos.Error(msg.ToString());

                MessageBox.Show("Se ha producido un error :" + error.Message, "Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMembresia.SelectedRows.Count > 0)
                {
                    var Pregunta = MessageBox.Show("¿Esta seguro que desea eliminar la membresía seleccionada?", "Eliminación permanente",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Pregunta == DialogResult.Yes)
                    {
                        PaqueteGYMBLL oBLL = new PaqueteGYMBLL();
                        oBLL.Eliminar(Convert.ToChar(txtCodigo.Text));
                        Refrescar();

                        //Limpiar
                        dgvMembresia.ClearSelection(); 
                        txtCodigo.Clear();
                        txtNombre.Clear();
                        txtPrecio.Clear();
                        txtMeses.Clear();
                        txtSemanas.Clear();

                        MessageBox.Show("La membresía se ha eliminado de manera exitosa! :) ", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Para poder eliminar la membresía, primero debe seleccionarla", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception error)
            {
                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("\r\nMessage        {0}\n", error.Message);
                msg.AppendFormat("Source         {0}\n", error.Source);
                msg.AppendFormat("StackTrace     {0}\n", error.StackTrace);
                msg.AppendFormat("Data           {0}\n", error.Data);

                GYMEventos.Error(msg.ToString());

                MessageBox.Show("Se ha producido un error :" + error.Message, "Error");
            }
        }
    }
}
