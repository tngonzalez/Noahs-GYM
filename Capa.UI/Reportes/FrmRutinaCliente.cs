using Capa.Entidades.Entidades;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using log4net; 
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using Capa.UI.Clientes;
using Capa.BLL;

namespace Capa.UI.Reportes
{
    public partial class FrmRepCorreo : Form
    {
        private static readonly ILog GYMEventos = log4net.LogManager.GetLogger("NoahGYMEventos");

        public FrmRepCorreo()
        {
            InitializeComponent();
        }
        private void CargarCombo()
        {
            cmbClientes.DataSource = ClienteBLL.ObtenerTodos();
            cmbClientes.DisplayMember = "Apellidos";
            cmbClientes.ValueMember = "Apellidos";
        }

        private void FrmRutinaCliente_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FrmCorreoTo();
                this.Close(); 
                frm.ShowDialog(); 

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSRepFiltro.PA_SeleccionarProductosReporte' table. You can move, or remove it, as needed.
            this.pA_SeleccionarClienteRutinaXClienteTableAdapter.Fill(
                this.dSClienteRutina.PA_SeleccionarClienteRutinaXCliente, this.cmbClientes.SelectedValue.ToString());

            // TODO: This line of code loads data into the 'CapasDBDataSet.PA_SeleccionarProductosReporte' table. You can move, or remove it, as needed.
            ReportParameter[] parameters = new ReportParameter[1];
            //Establecemos el valor de los parámetros

            parameters[0] = new ReportParameter("Apellidos", this.cmbClientes.SelectedValue.ToString());

            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(parameters);


            this.reportViewer1.RefreshReport();
        }
    }
}
