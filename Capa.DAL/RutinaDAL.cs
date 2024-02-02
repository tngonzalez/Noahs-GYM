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
   public class RutinaDAL
    {
        public void Insertar(Rutina oRu)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarRutina";

                comando.Parameters.AddWithValue("@NombreR", oRu.Nombre);
                comando.Parameters.AddWithValue("@IDInstructorR", oRu.IDInstructor);
                comando.Parameters.AddWithValue("@IDEjercicioR", oRu.IDEjercicio);
                comando.Parameters.AddWithValue("@SerieRepeticion", oRu.SerieRepeticion);
                comando.Parameters.AddWithValue("@Descanso", oRu.Descanso);

                db.ExecuteNonQuery(comando);
            }
        }

        public void Eliminar(int IDRu)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_EliminarRutina";
                comando.Parameters.AddWithValue("@IDRut", IDRu);

                db.ExecuteNonQuery(comando);
            }
        }

        public static Rutina SeleccionarPorIDIns(int IDInstructor)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarRutinasXInstructor";
                comando.Parameters.AddWithValue("@IDInsRut", IDInstructor);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Rutina oRu = new Rutina();

                    oRu.ID = Convert.ToInt32(dr["ID"]); 
                    oRu.Nombre = dr["Nombre"].ToString();
                    oRu.IDInstructor = (int)dr["IDInstructor"];
                    oRu.IDEjercicio = (int)dr["IDEjercicio"];
                    oRu.Ejercicio = EjercicioDAL.SeleccionarPorID(oRu.IDEjercicio);
                    oRu.SerieRepeticion = dr["SerieRepeticion"].ToString();
                    oRu.Descanso = dr["Descanso"].ToString();

                    return oRu;
                }
            }
            return null;
        }
        public static List<Rutina> SeleccionarTodos()
        {
            List<Rutina> lista = new List<Rutina>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarRutinas";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Rutina oRu = new Rutina();

                    oRu.ID = Convert.ToInt32(dr["ID"]);
                    oRu.Nombre = dr["Nombre"].ToString();
                    oRu.IDInstructor = (int)dr["IDInstructor"];
                    oRu.IDEjercicio = (int)dr["IDEjercicio"];
                    oRu.Ejercicio = EjercicioDAL.SeleccionarPorID(oRu.IDEjercicio);
                    oRu.SerieRepeticion = dr["SerieRepetion"].ToString();
                    oRu.Descanso = dr["Descanso"].ToString();

                    lista.Add(oRu);
                }
            }

            return lista;
        }

        //Reporte
        public static List<Rutina> SeleccionarAgrupacionXIDCliente()
        {
            List<Rutina> lista = new List<Rutina>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarAgrupacionRutinaXCliente";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Rutina oRu = new Rutina();

                    oRu.ID = Convert.ToInt32(dr["ID"]);
                    oRu.Nombre = dr["Nombre"].ToString();
                    oRu.IDInstructor = (int)dr["IDInstructor"];
                    oRu.IDEjercicio = (int)dr["IDEjercicio"];
                    oRu.Ejercicio = EjercicioDAL.SeleccionarPorID(oRu.IDEjercicio);
                    oRu.SerieRepeticion = dr["SerieRepeticion"].ToString();
                    oRu.Descanso = dr["Descanso"].ToString();

                    lista.Add(oRu);
                }
            }

            return lista;
        }

    }
}
