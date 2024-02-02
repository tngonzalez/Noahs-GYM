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
   public class FacturaDAL
    {
        public void Insertar(EncFactura oEF)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarEncFactura";

                comando.Parameters.AddWithValue("@IDClienteEF", oEF.IDCliente);
                comando.Parameters.AddWithValue("@QRCodEF", oEF.QRCodigo);
                comando.Parameters.AddWithValue("@FechaEF", oEF.FechaActual);

                db.ExecuteNonQuery(comando);
            }
        }

        public static EncFactura SeleccionarPorId(int IDCliente)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarEncXIDCliente";
                comando.Parameters.AddWithValue("@IDCliente", IDCliente);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    EncFactura oEnc = new EncFactura();

                    oEnc.IDCliente = (int)dr["IDCliente"];
                    oEnc.QRCodigo = (byte[])dr["QRCod"];
                    oEnc.FechaActual =Convert.ToDateTime(dr["Fecha"]); 
                    oEnc.NumFactura = (int)dr["NumFactura"];
                    return oEnc;
                }
            }
            return null;
        }

        //Detalle Fac. 

        public void InsertarDF(DetalleFac oDF)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarDetalleFac";

                comando.Parameters.AddWithValue("@IDFacturaDF", oDF.IDFactura);
                comando.Parameters.AddWithValue("@IDPlanInscritoDF", oDF.IDPlanInscrito);
                comando.Parameters.AddWithValue("@TipoCambioDF", oDF.TipoCambio);

                db.ExecuteNonQuery(comando);
            }
        }

        //Reporte
        public static List<DetalleFac> SeleccionarFacturaRangos()
        {
            List<DetalleFac> lista = new List<DetalleFac>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarFacturaRangoFechas";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DetalleFac oDF = new DetalleFac();

                    oDF.IDFactura = (int)dr["IDFactura"];
                    oDF.IDPlanInscrito = (int)dr["IDPlanInscrito"];

                    lista.Add(oDF);
                }
            }

            return lista;
        }
    }
}
