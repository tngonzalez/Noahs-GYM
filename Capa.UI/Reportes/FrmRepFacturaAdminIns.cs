using Capa.BLL;
using Capa.Entidades.Entidades;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI.Reportes
{
    public partial class FrmRepFacturaAdminIns : Form
    {
        public FrmRepFacturaAdminIns()
        {
            InitializeComponent();
        }
        public Cliente Cliente { get; set; }
        public EncFactura EncF { get; set; }
        public PlanInscrito Plan { get; set; }
        public decimal Cambio { get; set; }

        private void FrmRepFacturaAdminIns_Load(object sender, EventArgs e)
        {
            //FrmPago oP = new FrmPago();

            //DetFactura 
            DetalleFac oDF = new DetalleFac();
            oDF.IDFactura = EncF.NumFactura;
            oDF.IDPlanInscrito = Plan.ID;
            oDF.TipoCambio = Cambio;

            FacturaBLL oBLL = new FacturaBLL();
            oBLL.GuardarDF(oDF);


            // TODO: This line of code loads data into the 'DSRepFiltro.PA_SeleccionarProductosReporte' table. You can move, or remove it, as needed.
            this.pA_GenerarFacturaTableAdapter.Fill(
                this.dSFacturaAdminIns.PA_GenerarFactura, Cliente.Apellidos.ToString());

            // TODO: This line of code loads data into the 'CapasDBDataSet.PA_SeleccionarProductosReporte' table. You can move, or remove it, as needed.
            ReportParameter[] parameters = new ReportParameter[1];
            //Establecemos el valor de los parámetros

            parameters[0] = new ReportParameter("ApellidosF", Cliente.Apellidos.ToString());

            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void ptbSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
