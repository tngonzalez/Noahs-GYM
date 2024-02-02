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
    public partial class FrmPopulares : Form
    {
        public FrmPopulares()
        {
            InitializeComponent();
        }

        private void FrmPopulares_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPopularesEjer.PA_SeleccionarEjerciciosFrecuentes' table. You can move, or remove it, as needed.
            this.pA_SeleccionarEjerciciosFrecuentesTableAdapter.Fill(this.dsPopularesEjer.PA_SeleccionarEjerciciosFrecuentes);

            this.reportViewer1.RefreshReport();
        }
    }
}
