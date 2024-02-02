using Capa.DAL;
using Capa.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
    public class RutinaBLL
    {
        public void Guardar(Rutina oRu)
        {
            RutinaDAL db = new RutinaDAL();
            db.Insertar(oRu);
        }

        public void Eliminar(int Ru)
        {
            RutinaDAL db = new RutinaDAL();
            db.Eliminar(Ru);
        }

        public static Rutina SeleccionarXIDInstructor(int IDInst)
        {
            return RutinaDAL.SeleccionarPorIDIns(IDInst); 
        }
        public static List<Rutina> ObtenerTodos()
        {
            return RutinaDAL.SeleccionarTodos();
        }

        public List<Rutina> ObtenerTodosAgrupacionXCliente()
        {
            return RutinaDAL.SeleccionarAgrupacionXIDCliente(); 
        }
    }
}
