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
    public class RegistroClienteDAL
    {
        public void Insertar(RegistroCliente oRe)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarRegistroCliente";

                comando.Parameters.AddWithValue("@IDClienteRC", oRe.IDCliente);
                comando.Parameters.AddWithValue("@HoraIngresoRC", oRe.HoraIngreso);
                comando.Parameters.AddWithValue("@HoraSalidaRC", oRe.HoraSalida);

                db.ExecuteNonQuery(comando);
            }
        }

        public static RegistroCliente SeleccionarPorID(int IDCliente)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarRegistroXIDCliente";
                comando.Parameters.AddWithValue("@IDClienteRCl", IDCliente);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    RegistroCliente oRC = new RegistroCliente();

                    oRC.IDCliente = (int)dr["ID"];
                    oRC.OCliente = ClienteDAL.SeleccionarPorId(oRC.IDCliente);
                    oRC.HoraIngreso = Convert.ToDateTime(dr["HoraIngreso"].ToString());
                    oRC.HoraSalida = Convert.ToDateTime(dr["HoraSalida"].ToString());

                    return oRC;
                }
            }
            return null;
        }
    }
}
