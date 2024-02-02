using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.UI
{
    public partial class FrmAgrupacionXTipoEjer : Form
    {
        public FrmAgrupacionXTipoEjer()
        {
            InitializeComponent();
        }

        private void FrmAgrupacionXTipoEjer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSAgrupacionXTipo.PA_SeleccionarEjerciciosXTipoEjer' table. You can move, or remove it, as needed.
            this.PA_SeleccionarEjerciciosXTipoEjerTableAdapter.Fill(this.DSAgrupacionXTipo.PA_SeleccionarEjerciciosXTipoEjer);

            this.reportViewer1.RefreshReport();
        }
    }
}
