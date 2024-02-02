using Capa.Entidades;
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
    public class MedidasDAL
    {
        public void Insertar(Medidas oMed)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarMedidas";

                comando.Parameters.AddWithValue("@IDClienteM", oMed.IDCliente);
                comando.Parameters.AddWithValue("@PesoM", oMed.Peso);
                comando.Parameters.AddWithValue("@AlturaM", oMed.Altura);
                comando.Parameters.AddWithValue("@IMCM", oMed.IMC);
                comando.Parameters.AddWithValue("@MetaBasalM", oMed.MetaBasal);
                comando.Parameters.AddWithValue("@FechaM", oMed.FechaMedida);
                comando.Parameters.AddWithValue("@EstadoM", oMed.Estado); 

                db.ExecuteNonQuery(comando);
            }
        }

        public void Eliminar(int IDCliente)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_EliminarMedidas";
                comando.Parameters.AddWithValue("@IDClienteXM", IDCliente);

                db.ExecuteNonQuery(comando);
            }
        }

        public static List<Medidas> SeleccionarPorID(int IDCliente)
        {
            List<Medidas> lista = new List<Medidas>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarMedidasXIDCliente";
                comando.Parameters.AddWithValue("@IDCliente", IDCliente);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Medidas oMed = new Medidas();

                    oMed.ID = (int)dr["ID"]; 
                    oMed.IDCliente = (int)dr["IDCliente"];
                    oMed.Peso = (double)dr["Peso"];
                    oMed.Altura = (double)dr["Altura"];
                    oMed.IMC = (double)dr["IMC"];
                    oMed.MetaBasal = (double)dr["MetaBasal"];
                    oMed.FechaMedida = Convert.ToDateTime(dr["FechaMedidas"]);
                    oMed.Estado = dr["Estado"].ToString();

                    lista.Add(oMed);
                }
            }
            return lista;
        }

        public static List<Medidas> SeleccionarTodos()
        {
            List<Medidas> lista = new List<Medidas>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarMedidas";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Medidas oMed = new Medidas();

                    oMed.ID = (int)dr["ID"];
                    oMed.IDCliente = (int)dr["IDCliente"];
                    oMed.Peso = Convert.ToDouble(dr["Peso"]);
                    oMed.Altura = Convert.ToDouble(dr["Altura"]);
                    oMed.IMC = Convert.ToDouble(dr["IMC"]);
                    oMed.MetaBasal = Convert.ToDouble(dr["MetaBasal"]);
                    oMed.FechaMedida = Convert.ToDateTime(dr["FechaMedidas"]);
                    oMed.Estado = dr["Estado"].ToString();

                    lista.Add(oMed);
                }
            }

            return lista;
        }
    }
}
