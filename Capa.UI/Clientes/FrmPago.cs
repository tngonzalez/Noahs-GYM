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
using QRCoder;
using Capa.BLL;
using Capa.UI.Reportes;
using System.Drawing.Imaging;
using System.IO;

namespace Capa.UI.Clientes
{
    public partial class FrmPago : Form
    {
        private static readonly ILog GYMEventos = log4net.LogManager.GetLogger("NoahGYMEventos");

        public FrmPago()
        {
            InitializeComponent();
        }
        public Cliente oCliente { get; set; }
        public PlanInscrito oMembresia { get; set; }

        EncFactura oEnc = new EncFactura();

        #region Metodos Variados 
        private void ValidarDatos()
        {
            try
            {
                erp.Clear();
                //Tipo de tarjeta
                if (rbtnCredito.Checked == false || rbtnDebito.Checked == false)
                {
                    erp.SetError(groupBox1, "Debe seleccionar el tipo de tarjeta que utilizará");
                }

                //Num tarjeta
                if (string.IsNullOrEmpty(txtNumTarjeta.Text))
                {
                    erp.SetError(txtNumTarjeta, "Debe ingresar el número de tarjeta");
                }
                if (int.TryParse(txtNumTarjeta.Text, out int cod))
                {
                    erp.SetError(txtNumTarjeta, "Este campo solo permite números");
                }

                //Mes 
                if (string.IsNullOrEmpty(txtMes.Text))
                {
                    erp.SetError(txtNumTarjeta, "Debe ingresar el mes de caducidad");
                }
                if (int.TryParse(txtMes.Text, out int c))
                {
                    erp.SetError(txtMes, "Este campo solo permite números");
                }

                //Año
                if (string.IsNullOrEmpty(txtAnnio.Text))
                {
                    erp.SetError(txtAnnio, "Debe ingresar el año de caducidad");
                }
                if (int.TryParse(txtAnnio.Text, out int co))
                {
                    erp.SetError(txtAnnio, "Este campo solo permite números");
                }

                //Codigo 
                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    erp.SetError(txtCodigo, "Debe ingresar el codigo de seguridad");
                }
                if (int.TryParse(txtCodigo.Text, out int cd))
                {
                    erp.SetError(txtCodigo, "Este campo solo permite números");
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

        private void FrmPago_Load(object sender, EventArgs e)
        {
            //Limpiar
            rbtnCredito.Checked = false;
            rbtnDebito.Checked = false;
            txtNumTarjeta.Clear();
            txtMes.Text = "MM";
            txtAnnio.Text = "AA";
            txtCodigo.Text = "CVC";
            rtxtInfoCliente.Clear();
            dgvTipoCambio.ClearSelection(); 


            //ASMX WebServices 
            string correoRegistrado = "noahsgym3@gmail.com";
            string token = "0CN21OO2HM";
            string nombreRegistrado = "Tylinn González";

            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            Agente.wsindicadoreseconomicosSoapClient cliente =
                      new Agente.wsindicadoreseconomicosSoapClient("wsindicadoreseconomicosSoap12");

            DataSet ds = cliente.ObtenerIndicadoresEconomicos("317", "07/08/2022", "15/08/2022",
                                    nombreRegistrado, "N", correoRegistrado, token);

            dgvTipoCambio.DataSource = ds.Tables[0];
 

        }

        private void pctCodigo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El CVC se encuentra en la parte de atrás de tu tarjeta \n y que está compuesto generalmente por 3 números", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Question); 
        }


        private void txtMes_Click(object sender, EventArgs e)
        {
            if(txtNumTarjeta.Text != "")
            {
                rtxtInfoCliente.Text = "ID: " + oCliente.ID + "\nPropietario:" +
                    oCliente.Nombre + "  " + oCliente.Apellidos; 
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {

            try
            {
                ValidarDatos();
                string num = (oEnc.NumFactura + 1).ToString(); 
                //Crea factura 

                //Crear el QR 
                QRCodeGenerator qrGenerador = new QRCodeGenerator();
                QRCodeData qrDatos = qrGenerador.CreateQrCode(num, QRCodeGenerator.ECCLevel.H);
                QRCode qrCodigo = new QRCode(qrDatos);

                Bitmap qrImagen = qrCodigo.GetGraphic(5, Color.Black, Color.White, true);
                qrImagen.Save(@"C:\temp\" + num + ".jpg", ImageFormat.Jpeg);

                //EncFactura 
                oEnc.IDCliente = oCliente.ID;
                oEnc.FechaActual = DateTime.Now;
                oEnc.QRCodigo = (byte[])File.ReadAllBytes(@"C:\temp\" + num + ".jpg");

                FacturaBLL oBLL = new FacturaBLL();
                oBLL.Guardar(oEnc);

                //Se modifica el estado de la membresía 
                PlanInscritoBLL oPlan = new PlanInscritoBLL();
                oPlan.Actualizar(oCliente.ID);

                var Enca = FacturaBLL.SeleccionarXID(oCliente.ID);

                var frm = new FrmRepFacturaAdminIns();
                frm.Cliente = oCliente;
                frm.EncF = Enca;
                frm.Plan = oMembresia;
                frm.Cambio = Convert.ToDecimal(txtCambio.Text);
                frm.ShowDialog();
                this.Close();

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

        #region Mostrar un ejemplo de MM, AA y CVC 


        private void txtMes_Enter(object sender, EventArgs e)
        {
            if (txtMes.Text == "MM")
            {
                txtMes.Text = "";

                txtMes.ForeColor = Color.Black;
            }
        }

        private void txtMes_Leave(object sender, EventArgs e)
        {
            if (txtMes.Text == "")
            {
                txtMes.Text = "MM";

                txtMes.ForeColor = Color.Silver;
            }
        }

        private void txtAnnio_Leave(object sender, EventArgs e)
        {
            if (txtAnnio.Text == "")
            {
                txtAnnio.Text = "AA";

                txtAnnio.ForeColor = Color.Silver;
            }
        }

        private void txtAnnio_Enter(object sender, EventArgs e)
        {
            if (txtAnnio.Text == "AA")
            {
                txtAnnio.Text = "";

                txtAnnio.ForeColor = Color.Black;
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                txtCodigo.Text = "CVC";

                txtCodigo.ForeColor = Color.Silver;
            }
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "CVC")
            {
                txtCodigo.Text = "";

                txtCodigo.ForeColor = Color.Black;
            }
        }

        #endregion

        private void dgvTipoCambio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvTipoCambio.Rows[e.RowIndex];
                txtCambio.Text = dgvRow.Cells[2].Value.ToString(); 
            }

        }
    }
}
