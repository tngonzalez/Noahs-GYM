using Capa.DAL;
using Capa.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
    public class RegistroClienteBLL
    {
        public void Guardar(RegistroCliente oRu)
        {
            RegistroClienteDAL db = new RegistroClienteDAL();
            db.Insertar(oRu);
        }

        public static RegistroCliente SeleccionarEjercicioXIDCliente(int IDCliente)
        {
            return RegistroClienteDAL.SeleccionarPorID(IDCliente);
        }
    }
}
