using Capa.DAL;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
   public class PaqueteGYMBLL
    {
        public void Guardar(PaquetesGYM oRu)
        {
            PaqueteGYMDAL db = new PaqueteGYMDAL();
            db.Insertar(oRu);
        }
        public static List<PaquetesGYM> ObtenerTodos()
        {
            return PaqueteGYMDAL.SeleccionarTodos();
        }

        public static PaquetesGYM SeleccionarXID(char ID)
        {
            return PaqueteGYMDAL.SeleccionarPorId(ID);
        }

        public void Eliminar(char IDPaque)
        {
            PaqueteGYMDAL db = new PaqueteGYMDAL();
            db.Eliminar(IDPaque);
        }
    }
}
