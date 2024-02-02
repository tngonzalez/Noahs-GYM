using Capa.DAL;
using Capa.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
   public class EjercicioBLL
    {
        public void Guardar(Ejercicio oEjer)
        {
            EjercicioDAL db = new EjercicioDAL();
            db.Insertar(oEjer);
        }

        public void Eliminar(string IDEjer)
        {
            EjercicioDAL db = new EjercicioDAL();
            db.Eliminar(IDEjer);
        }

        public static Ejercicio SeleccionarEjercicioXTipo(int IDTipo)
        {
            return EjercicioDAL.SeleccionarPorIDTipo(IDTipo);
        }
        public static List<Ejercicio> ObtenerTodos()
        {
            return EjercicioDAL.SeleccionarTodos();
        }
        public static Ejercicio SeleccionarEjercicioXID(int IDEjercicio)
        {
            return EjercicioDAL.SeleccionarPorID(IDEjercicio);
        }

        //Reporte
        public List<Ejercicio> ObtenerEjerciciosFrecuentes()
        {
            return EjercicioDAL.SeleccionarEjerciciosFrecuentes();
        }
    }
}
