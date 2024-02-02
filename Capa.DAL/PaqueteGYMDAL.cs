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
    public class PaqueteGYMDAL
    { 
    public void Insertar(PaquetesGYM oPaq)
    {
        using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "PA_InsertarPaqueteGYM";

            comando.Parameters.AddWithValue("@IDPaGYM", oPaq.ID);
            comando.Parameters.AddWithValue("@NombrePaGYM", oPaq.Nombre);
            comando.Parameters.AddWithValue("@PrecioPaGYM", oPaq.Precio);
            comando.Parameters.AddWithValue("@MesesPaGYM", oPaq.Meses);
            comando.Parameters.AddWithValue("@SemanasPaGYM", oPaq.Semanas);
  

            db.ExecuteNonQuery(comando);
        }
    }
    public static List<PaquetesGYM> SeleccionarTodos()
        {
            List<PaquetesGYM> lista = new List<PaquetesGYM>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarPaquetesGYM";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    PaquetesGYM oPaque = new PaquetesGYM();

                    oPaque.ID = dr["ID"].ToString();
                    oPaque.Nombre = dr["Nombre"].ToString();
                    oPaque.Precio = Convert.ToDouble(dr["Precio"]);
                    oPaque.Meses = (int)dr["Meses"];
                    oPaque.Semanas = (int)dr["Semanas"]; 

                    lista.Add(oPaque);
                }
            }

            return lista;
        }

        public static PaquetesGYM SeleccionarPorId(char plan)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarPaquetesGYMID";
                comando.Parameters.AddWithValue("@IDPaqGYM", plan);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    PaquetesGYM oPaque = new PaquetesGYM();

                    oPaque.ID = reader["ID"].ToString();
                    oPaque.Nombre = reader["Nombre"].ToString();
                    oPaque.Precio = Convert.ToDouble(reader["Precio"]);
                    oPaque.Meses = (int)reader["Meses"];
                    oPaque.Semanas = (int)reader["Semanas"];

                    return oPaque;
                }
            }
            return null;
        }

        public void Eliminar(char IDPaque)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_EliminarPaquete";
                comando.Parameters.AddWithValue("@IDPaque", IDPaque);

                db.ExecuteNonQuery(comando);
            }
        }
    }
}
