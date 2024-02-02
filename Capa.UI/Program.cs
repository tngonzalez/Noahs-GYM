using Capa.UI.Acceso;
using Capa.UI.AdminInstructor;
using Capa.UI.Areas;
using Capa.UI.Clientes;
using Capa.UI.Mantenimientos;
using Capa.UI.Registros;
using Capa.UI.Reportes;
using Capa.UI.Rutinas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Capa.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmAcceso());
        }
    }
}
