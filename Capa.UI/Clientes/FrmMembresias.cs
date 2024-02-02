using Capa.BLL;
using log4net; 
using Capa.Entidades;
using Capa.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI.Clientes
{
    public partial class FrmMembresias : Form
    {
        private static readonly ILog GYMEventos = log4net.LogManager.GetLogger("NoahGYMEventos");

        public FrmMembresias()
        {
            InitializeComponent();
        }
        public Cliente oCliente { get; set; }

        #region Metodos Variados 

        private void Refrescar()
        {
            dgvPlanInscrito.DataSource = PlanInscritoBLL.SeleccionarXIDCliente(Convert.ToInt32(oCliente.ID)); 
            dgvPlanInscrito.ClearSelection();
        }
        private void CargarCombo()
        {
            //Paquete
            cmbPaquete.DataSource = PaqueteGYMBLL.ObtenerTodos();
            cmbPaquete.DisplayMember = "Nombre";
            cmbPaquete.ValueMember = "ID";

            cmbPaquete.SelectedItem = -1; 
        }
        private void AsignarValores()
        {
            txtID.Text = oCliente.ID.ToString();
            txtNombre.Text = oCliente.Nombre;
            txtApellidos.Text = oCliente.Apellidos;
            txtCorreo.Text = oCliente.Correo;

            //Conver Imagen
            ImageConverter img = new ImageConverter();
            pcbFoto.Image = (Bitmap)img.ConvertFrom(oCliente.Foto);
           
        }
        #endregion

        private void cmbPaquete_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaquetesGYM Opaquete = cmbPaquete.SelectedItem as PaquetesGYM;
            char IDPaquete = char.Parse(Opaquete.ID);

            var oPa = PaqueteGYMBLL.SeleccionarXID(IDPaquete);

            txtMes.Text = oPa.Meses.ToString();
            txtSemanas.Text = oPa.Semanas.ToString();
            txtPrecio.Text = oPa.Precio.ToString();
        }

        private void FrmMembresias_Load(object sender, EventArgs e)
        {
            Refrescar();
            CargarCombo();
            AsignarValores();
            dgvPlanInscrito.ClearSelection(); 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
        }

        private void ptbSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnAgregarMembresia_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbPaquete.SelectedIndex != -1)
                {
                    PlanInscrito oPlan = new PlanInscrito();

                    oPlan.IDCliente = Convert.ToInt32(txtID.Text);
                    oPlan.IDPaquete = Convert.ToChar(cmbPaquete.SelectedValue);
                    oPlan.FechaIngreso = dtpIngreso.Value;
                    if(txtMes.Text != "")
                    {
                        dtpVencimiento.Value = DateTime.Now.AddMonths(Convert.ToInt32(txtMes.Text)); 
                    }
                    else
                    {
                        DateTime cant = DateTime.Now;
                        DateTime can = cant.AddDays(7);
                        dtpVencimiento.Value = can; 

                    }

                    oPlan.FechaProximoPago = dtpVencimiento.Value;
                    oPlan.Estado = "Pendiente"; 
                    PlanInscritoBLL oBLL = new PlanInscritoBLL();
                    oBLL.Guardar(oPlan);
                    Refrescar();

                    //Limpiar 
                   // cmbPaquete.SelectedIndex = -1;
                    txtPrecio.Clear();
                    txtMes.Clear();
                    txtSemanas.Clear();
                    dtpIngreso.Value = DateTime.Now;
                   // dtpVencimiento.Value = DateTime.Now;

                    MessageBox.Show("Membresía registrada, recuerde realizar su pagado para iniciar! :) ", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
                if (dgvPlanInscrito.SelectedRows.Count > 0)
                {
                    var Pregunta = MessageBox.Show("¿Esta seguro que desea eliminar la membresía reservada?", "Eliminación permanente",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Pregunta == DialogResult.Yes)
                    {
                        PlanInscritoBLL oBLL = new PlanInscritoBLL();
                        oBLL.Eliminar(Convert.ToInt32(txtID.Text));
                        Refrescar();

                        MessageBox.Show("La reserva de la membresía ha sido anulada de manera exitosa! :) ", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Para poder anular la reserva primero debe seleccionarla", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void btnPagarMembresia_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPlanInscrito.SelectedRows.Count > 0)
                {

                    var membresia = (PlanInscrito)dgvPlanInscrito.SelectedRows[0].DataBoundItem;
                    var frm = new FrmPago();
                    frm.oMembresia = membresia;
                    frm.oCliente = oCliente;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Debe selección la membresía reservada", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dgvPlanInscrito_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPlanInscrito.SelectedRows.Count > 0)
            {
                var oMe = (PlanInscrito)dgvPlanInscrito.SelectedRows[0].DataBoundItem;

                //Cliente Moroso
                ClienteMoroso oMoroso = new ClienteMoroso();
                oMoroso.IDCliente = oCliente.ID;
                oMoroso.CantDiasM = Convert.ToInt32((DateTime.Now.Day - oMe.FechaProximoPago.Day));

                ClienteMorosoBLL oMBLL = new ClienteMorosoBLL();
                oMBLL.Guardar(oMoroso);
            }

        }
    }

}
