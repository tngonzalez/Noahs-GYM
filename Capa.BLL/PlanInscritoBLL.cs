using Capa.DAL;
using Capa.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
   public class PlanInscritoBLL
    {
        public void Guardar(PlanInscrito oPlan)
        {
            PlanInscritoDAL db = new PlanInscritoDAL();
            db.Insertar(oPlan);
        }
     
        public void Eliminar(int IDCliente)
        {
            PlanInscritoDAL db = new PlanInscritoDAL();
            db.Eliminar(IDCliente);
        }

        public static List<PlanInscrito> SeleccionarXIDCliente(int IDCliente)
        {
            return PlanInscritoDAL.SeleccionarPorId(IDCliente);
        }
        public List<PlanInscrito> ObtenerTodos()
        {
            return PlanInscritoDAL.SeleccionarTodos(); 
        }
        public static PlanInscrito SeleccionarPlanInsXIDPlan(int IDPlan)
        {
            return PlanInscritoDAL.SeleccionarPorIdPlan(IDPlan);
        }

        //Actualizar estado 
        public void Actualizar(int IDCliente)
        {
            PlanInscritoDAL db = new PlanInscritoDAL();
            db.Actualizar(IDCliente);
        }

    }
}
