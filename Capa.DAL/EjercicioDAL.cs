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
    public class EjercicioDAL
    {
        public void Insertar(Ejercicio oEjercicio)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarEjercicio";

                comando.Parameters.AddWithValue("@NombreE", oEjercicio.Nombre);
                comando.Parameters.AddWithValue("@DescripcionE", oEjercicio.Descripcion);
                comando.Parameters.AddWithValue("@FotoE", oEjercicio.Foto);
                comando.Parameters.AddWithValue("@IDTipoE", oEjercicio.IDTipoEjer);

                db.ExecuteNonQuery(comando);
            }
        }

        public void Eliminar(string nombre)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_EliminarEjercicios";
                comando.Parameters.AddWithValue("@NombreEje", nombre);

                db.ExecuteNonQuery(comando);
            }
        }

        public static Ejercicio SeleccionarPorIDTipo(int IDTipo)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarEjerciciosXTipo";
                comando.Parameters.AddWithValue("@IDTipoEjer", IDTipo);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Ejercicio oEjer = new Ejercicio();

                    oEjer.ID = Convert.ToInt32(dr["ID"]); 
                    oEjer.Nombre = dr["Nombre"].ToString();
                    oEjer.Descripcion = dr["Descripcion"].ToString();
                    oEjer.Foto = (byte[])dr["Foto"];
                    oEjer.IDTipoEjer = (int)dr["IDTipo"]; 
                    oEjer.TipoEjercicio = TipoEjercicioDAL.SeleccionarPorId(oEjer.IDTipoEjer);

                    return oEjer;
                }
            }
            return null;
        }

        public static List<Ejercicio> SeleccionarTodos()
        {
            List<Ejercicio> lista = new List<Ejercicio>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarEjercicios";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Ejercicio oEjer = new Ejercicio();

                    oEjer.ID = Convert.ToInt32(dr["ID"]);
                    oEjer.Nombre = dr["Nombre"].ToString();
                    oEjer.Descripcion = dr["Descripcion"].ToString();
                    oEjer.Foto = (byte[])dr["Foto"];
                    oEjer.IDTipoEjer = (int)dr["IDTipo"];
                    oEjer.TipoEjercicio = TipoEjercicioDAL.SeleccionarPorId(oEjer.IDTipoEjer);

                    lista.Add(oEjer);
                }
            }

            return lista;
        }

        public static Ejercicio SeleccionarPorID(int ID)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarEjerciciosXID";
                comando.Parameters.AddWithValue("@IDEjercicio", ID);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Ejercicio oEjer = new Ejercicio();

                    oEjer.ID = Convert.ToInt32(dr["ID"]);
                    oEjer.Nombre = dr["Nombre"].ToString();
                    oEjer.Descripcion = dr["Descripcion"].ToString();
                    oEjer.Foto = (byte[])dr["Foto"];
                    oEjer.IDTipoEjer = (int)dr["IDTipo"];
                    oEjer.TipoEjercicio = TipoEjercicioDAL.SeleccionarPorId(oEjer.IDTipoEjer);

                    return oEjer;
                }
            }
            return null;
        }

        //Reporte
        public static List<Ejercicio> SeleccionarEjerciciosFrecuentes()
        {
            List<Ejercicio> lista = new List<Ejercicio>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarEjerciciosFrecuentes";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Ejercicio oEjer = new Ejercicio();

                    oEjer.Nombre = dr["Nombre"].ToString();
                    oEjer.Descripcion = dr["Descripcion"].ToString();
                    oEjer.Foto = (byte[])dr["Foto"];
                    oEjer.IDTipoEjer = (int)dr["IDTipo"];
                    oEjer.TipoEjercicio = TipoEjercicioDAL.SeleccionarPorId(oEjer.IDTipoEjer);

                    lista.Add(oEjer);
                }
            }

            return lista;
        }

    }
}
