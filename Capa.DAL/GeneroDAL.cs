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
    public class GeneroDAL
    {
        public static List<Genero> SeleccionarTodos()
        {
            List<Genero> lista = new List<Genero>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarGenero";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Genero oGe = new Genero();
                    oGe.ID = (int)dr["ID"]; 
                    oGe.Nombre = dr["Nombre"].ToString();
                    lista.Add(oGe);
                }
            }

            return lista;
        }

        public static Genero SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarGeneroXID";
                comando.Parameters.AddWithValue("@IDGe", id);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    Genero oGe = new Genero();
                    oGe.ID = (int)reader["ID"]; 
                    oGe.Nombre = reader["Nombre"].ToString();

                    return oGe;
                }
            }

            return null;
        }
    }
}
