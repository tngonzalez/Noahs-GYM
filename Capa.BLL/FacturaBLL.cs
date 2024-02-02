using Capa.DAL;
using Capa.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
    public class FacturaBLL
    {
        public void Guardar(EncFactura oEF)
        {
            FacturaDAL db = new FacturaDAL();
            db.Insertar(oEF);
        }

        public static EncFactura SeleccionarXID(int IDCliente)
        {
            return FacturaDAL.SeleccionarPorId(IDCliente); 
        }

        //Detalle Fac.

        public void GuardarDF(DetalleFac oDF)
        {
            FacturaDAL db = new FacturaDAL();
            db.InsertarDF(oDF);
        }

        //Reporte 

        public List<DetalleFac> ObtenerFacturaRangosFechas()
        {
            return FacturaDAL.SeleccionarFacturaRangos();
        }
    }
}
