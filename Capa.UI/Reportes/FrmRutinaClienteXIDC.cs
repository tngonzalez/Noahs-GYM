using Capa.BLL;
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
    public partial class FrmRutinaClienteXIDC : Form
    {
        public FrmRutinaClienteXIDC()
        {
            InitializeComponent();
        }
        private void CargarCombo()
        {
            cmbClientes.DataSource = ClienteBLL.ObtenerTodos();
            cmbClientes.DisplayMember = "Apellidos";
            cmbClientes.ValueMember = "Apellidos"; 
        }
        private void FrmRutinaClienteXIDC_Load(object sender, EventArgs e)
        {
            CargarCombo(); 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSRepFiltro.PA_SeleccionarProductosReporte' table. You can move, or remove it, as needed.
            this.pA_SeleccionarAgrupacionRutinaXClienteTableAdapter.Fill(
                this.dSRutinaClienteXIDC.PA_SeleccionarAgrupacionRutinaXCliente, cmbClientes.SelectedValue.ToString());

            // TODO: This line of code loads data into the 'CapasDBDataSet.PA_SeleccionarProductosReporte' table. You can move, or remove it, as needed.
            ReportParameter[] parameters = new ReportParameter[1];
            //Establecemos el valor de los parámetros

            parameters[0] = new ReportParameter("ApellidosCR", cmbClientes.SelectedValue.ToString());

            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.RefreshReport();
        }
    }
}
