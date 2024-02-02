using Capa.DAL;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
    public class GeneroBLL
    {
        public static List<Genero> ObtenerTodos()
        {
            return GeneroDAL.SeleccionarTodos();
        }

        public static Genero SeleccionarXID(int ID)
        {
            return GeneroDAL.SeleccionarPorId(ID); 
        }
    }
}
