using Capa.DAL;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
  public  class TipoEjercicioBLL
    {
        public static List<TipoEjercicio> ObtenerTodos()
        {
            return TipoEjercicioDAL.SeleccionarTodos();
        }

        public static TipoEjercicio SeleccionarXID(int ID)
        {
            return TipoEjercicioDAL.SeleccionarPorId(ID);
        }
    }
}
