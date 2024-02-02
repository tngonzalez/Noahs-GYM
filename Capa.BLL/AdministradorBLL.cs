using Capa.DAL;
using Capa.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
   public class AdministradorBLL
    {
        public void Guardar(Administrador oAdmin)
        {
            AdministradorDAL db = new AdministradorDAL();
            if (AdministradorDAL.SeleccionarPorId(oAdmin.ID) == null)
            {
                db.Insertar(oAdmin);
            }
            else
            {
                db.Actualizar(oAdmin);
            }
        }

        public static Administrador LoginAdmin(string User, string Clave)
        {
            return AdministradorDAL.Login(User, Clave);
        }

        public void Eliminar(int IDAdm)
        {
            AdministradorDAL db = new AdministradorDAL();
            db.Eliminar(IDAdm);
        }

        public static List<Administrador> ObtenerTodos()
        {
            return AdministradorDAL.SeleccionarTodos();
        }

    }
}
