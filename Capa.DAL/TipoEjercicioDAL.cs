using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.DAL
{
  public  class TipoEjercicioDAL
    {
        public static List<TipoEjercicio> SeleccionarTodos()
        {
            List<TipoEjercicio> lista = new List<TipoEjercicio>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarTipoEjercicios";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    TipoEjercicio oTipo = new TipoEjercicio();
                    oTipo.ID = (int)dr["ID"]; 
                    oTipo.Nombre = dr["Nombre"].ToString();
                    lista.Add(oTipo);
                }
            }

            return lista;
        }

        public static TipoEjercicio SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarTipoEjerciciosXID";
                comando.Parameters.AddWithValue("@IDTE", id);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    TipoEjercicio oTipo = new TipoEjercicio();
                    oTipo.ID = (int)reader["ID"]; 
                    oTipo.Nombre = reader["Nombre"].ToString();

                    return oTipo;
                }
            }

            return null;
        }
    }
}
