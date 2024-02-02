using Capa.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.DAL
{
   public class ClienteMorosoDAL
    {
        public void Insertar(ClienteMoroso pCM)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ConsultaClienteMoroso";

                comando.Parameters.AddWithValue("@IDClienteMo", pCM.IDCliente);
                comando.Parameters.AddWithValue("@cantMoro", pCM.CantDiasM);


                db.ExecuteNonQuery(comando);
            }
        }

        public void Eliminar(int IDCliente)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_EliminarClienteMoroso";
                comando.Parameters.AddWithValue("@IDClienteM", IDCliente);

                db.ExecuteNonQuery(comando);
            }
        }

        public static List<ClienteMoroso> SeleccionarTodos()
        {
            List<ClienteMoroso> lista = new List<ClienteMoroso>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarClientesMoroso";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ClienteMoroso oCM = new ClienteMoroso();

                    oCM.IDCliente = (int)dr["IDCliente"];
                    oCM.Ocliente = ClienteDAL.SeleccionarPorId(oCM.IDCliente);
                    oCM.CantDiasM = (int)dr["CantDias"];
                   
                    lista.Add(oCM);
                }
            }
            return lista;
        }
    }
}
