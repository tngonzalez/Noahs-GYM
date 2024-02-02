using Capa.DAL;
using Capa.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
   public class InstructorBLL
    {
        public void Guardar(Instructor oIns)
        {
            InstructorDAL db = new InstructorDAL();

            if (InstructorDAL.SeleccionarPorId(oIns.ID) == null)
            {
                db.Insertar(oIns);
            }
            else
            {
                db.Actualizar(oIns);
            }
        }

        public void Eliminar(int IDIns)
        {
            InstructorDAL db = new InstructorDAL();
            db.Eliminar(IDIns);
        }
        public static List<Instructor> ObtenerTodos()
        {
            return InstructorDAL.SeleccionarTodos();
        }

        public static Instructor LoginInst(string User, string Clave)
        {
            return InstructorDAL.Login(User, Clave);
        }

        public static Instructor SeleccionarXId(int IDIns)
        {
            return InstructorDAL.SeleccionarPorId(IDIns);
        }
    }
}
