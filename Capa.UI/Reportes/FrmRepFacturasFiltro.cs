using Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution;
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
    public partial class FrmRepFacturasFiltro : Form
    {
        public FrmRepFacturasFiltro()
        {
            InitializeComponent();
        }

        private void FrmRepFacturasFiltro_Load(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSRepFiltro.PA_SeleccionarProductosReporte' table. You can move, or remove it, as needed.
            this.pA_SeleccionarFacturaRangoFechasTableAdapter.Fill(
                this.dSFacturaFiltro.PA_SeleccionarFacturaRangoFechas, (DateTime)dtpInicio.Value, (DateTime)dtpFin.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}
