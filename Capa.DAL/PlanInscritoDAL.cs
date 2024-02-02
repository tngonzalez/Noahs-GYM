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
    public class PlanInscritoDAL
    {
        public void Insertar(PlanInscrito oPlan)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ConsultaPlanInscrito";

                comando.Parameters.AddWithValue("@IDClientePI", oPlan.IDCliente);
                comando.Parameters.AddWithValue("@IDPaqueteGYMPI", oPlan.IDPaquete);
                comando.Parameters.AddWithValue("@FechaIngresoPI", oPlan.FechaIngreso);
                comando.Parameters.AddWithValue("@FechaProximoPagoPI", oPlan.FechaProximoPago);
                comando.Parameters.AddWithValue("@EstadoPI", oPlan.Estado);

                db.ExecuteNonQuery(comando);
            }
        }

      
        public void Eliminar(int IDCliente)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_EliminarPlanInscrito";
                comando.Parameters.AddWithValue("@IDClientePIns", IDCliente);

                db.ExecuteNonQuery(comando);
            }
        }
      
        public static List<PlanInscrito> SeleccionarPorId(int IDCliente)
        {
            List<PlanInscrito> lista = new List<PlanInscrito>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarPlanInscritoXCliente";
                comando.Parameters.AddWithValue("@IDClientePInsc", IDCliente);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    PlanInscrito oPlan = new PlanInscrito();

                    oPlan.ID = (int)dr["ID"];
                    oPlan.IDCliente = (int)dr["IDCliente"];
                    oPlan.IDPaquete = Convert.ToChar(dr["IDPaqueteGYM"]);
                    oPlan.FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"]);
                    oPlan.FechaProximoPago = Convert.ToDateTime(dr["FechaProximoPago"]);
                    oPlan.Estado = dr["Estado"].ToString();

                    lista.Add(oPlan);
                }
            }
            return lista;
        }

        public static List<PlanInscrito> SeleccionarTodos()
        {
            List<PlanInscrito> lista = new List<PlanInscrito>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarPlanesInscritos";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    PlanInscrito oPlan = new PlanInscrito();

                    oPlan.ID = (int)dr["ID"];
                    oPlan.IDCliente = (int)dr["IDCliente"];
                    oPlan.IDPaquete = (char)dr["IDPaqueteGYM"];
                    oPlan.FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"]);
                    oPlan.FechaProximoPago = Convert.ToDateTime(dr["FechaProximoPago"]);
                    oPlan.Estado = dr["Estado"].ToString();

                    lista.Add(oPlan);
                }
            }

            return lista;
        }
        public static PlanInscrito SeleccionarPorIdPlan(int IDPlan)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarPlanInscritoXIDPlan";
                comando.Parameters.AddWithValue("@IDPlan", IDPlan);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    PlanInscrito oPlan = new PlanInscrito();

                    oPlan.IDCliente = (int)dr["IDCliente"];
                    oPlan.IDPaquete = (char)dr["IDPaqueteGYM"];
                    oPlan.FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"]);
                    oPlan.FechaProximoPago = Convert.ToDateTime(dr["FechaProximoPago"]);

                    return oPlan;
                }
            }
            return null;
        }

        //Actualizar el estado del planinscrito
        public void Actualizar(int IDCliente)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ModificarEstadoXCliente";

                comando.Parameters.AddWithValue("@IDClientePInscrito", IDCliente);

                db.ExecuteNonQuery(comando);
            }
        }

    }
}
