using Capa.DAL;
using Capa.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BLL
{
    public class ClienteBLL
    {
        public void Guardar(Cliente oCli)
        {
            ClienteDAL db = new ClienteDAL();
            if (ClienteDAL.SeleccionarPorId(oCli.ID) == null)
            {
                db.Insertar(oCli); 
            }
            else
            {
                db.Actualizar(oCli); 
            }
        }

        public static Cliente SeleccionarXID(int ID)
        {
            return ClienteDAL.SeleccionarPorId(ID); 
        }
        public void Eliminar(int IDCli)
        {
            ClienteDAL db = new ClienteDAL();
            db.Eliminar(IDCli);
        }

        public static List<Cliente> ObtenerTodos()
        {
            return ClienteDAL.SeleccionarTodos();
        }

        public static Cliente Login(string User, string Clave)
        {
            return ClienteDAL.Login(User, Clave);
        }

        //ClienteRutina
        public void GuardarClienteRutina(int IDCliente, int IDRutina, string Dia)
        {
            ClienteDAL db = new ClienteDAL();
            db.InsertarClienteRutina(IDCliente, IDRutina, Dia);
        }



        public void EliminarClienteRutina(int IDCliente, int IDRutina )
        {
            ClienteDAL db = new ClienteDAL();
            db.EliminarClienteRutina(IDCliente, IDRutina);
        }

        public static Rutina SeleccionarEjercicioXTipo(int IDCliente)
        {
            return ClienteDAL.SeleccionarRutinaXCliente(IDCliente);
        }


    }
}
