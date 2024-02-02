using Capa.DAL;
using Capa.Entidades;
using Capa.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
    public class MedidasBLL
    {
        public void Guardar(Medidas oMed)
        {
            MedidasDAL db = new MedidasDAL();
            db.Insertar(oMed);
        }

        public void Eliminar(int IDClien)
        {
            MedidasDAL db = new MedidasDAL();
            db.Eliminar(IDClien);
        }

        public static List<Medidas> SeleccionarXID(int IDCli)
        {
            return MedidasDAL.SeleccionarPorID(IDCli);
        }
        public static List<Medidas> ObtenerTodos()
        {
            return MedidasDAL.SeleccionarTodos();
        }
    }
}
