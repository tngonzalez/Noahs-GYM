using Capa.DAL;
using Capa.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
   public class ClienteMorosoBLL
    {
        public void Guardar(ClienteMoroso oCM)
        {
            ClienteMorosoDAL db = new ClienteMorosoDAL();
            db.Insertar(oCM);
        }

        public void Eliminar(int IDCliente)
        {
            ClienteMorosoDAL db = new ClienteMorosoDAL();
            db.Eliminar(IDCliente);
        }
        public List<ClienteMoroso> ObtenerTodos()
        {
            return ClienteMorosoDAL.SeleccionarTodos();
        }
    }
}
