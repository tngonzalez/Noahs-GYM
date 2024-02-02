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
    public partial class FrmRepRutinaParaCliente : Form
    {
        public FrmRepRutinaParaCliente()
        {
            InitializeComponent();
        }
        public Cliente oCliente { get; set; }

        private void FrmRepRutinaParaCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSRepFiltro.PA_SeleccionarProductosReporte' table. You can move, or remove it, as needed.
            this.pA_SeleccionarClienteRutinaXClienteTableAdapter.Fill(
                this.dSRutinaParaCliente.PA_SeleccionarClienteRutinaXCliente, this.oCliente.Apellidos);

            // TODO: This line of code loads data into the 'CapasDBDataSet.PA_SeleccionarProductosReporte' table. You can move, or remove it, as needed.
            ReportParameter[] parameters = new ReportParameter[1];
            //Establecemos el valor de los parámetros

            parameters[0] = new ReportParameter("Apellidos", oCliente.Apellidos);

            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.RefreshReport(); 
        }
    }
}
