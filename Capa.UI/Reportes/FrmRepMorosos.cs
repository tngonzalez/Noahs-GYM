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
    public partial class FrmRepMorosos : Form
    {
        public FrmRepMorosos()
        {
            InitializeComponent();
        }

        private void FrmRepMorosos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSMorosos.PA_SeleccionarClientesMoroso' table. You can move, or remove it, as needed.
            this.pA_SeleccionarClientesMorosoTableAdapter.Fill(this.dSMorosos.PA_SeleccionarClientesMoroso);

            this.reportViewer1.RefreshReport();
        }
    }
}
