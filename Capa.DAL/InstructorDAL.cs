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
   public class InstructorDAL
    {
        public void Insertar(Instructor oInst)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarIns";

                comando.Parameters.AddWithValue("@IDI", oInst.ID);
                comando.Parameters.AddWithValue("@NombreI", oInst.Nombre);
                comando.Parameters.AddWithValue("@ApellidosI", oInst.Apellidos);
                comando.Parameters.AddWithValue("@FotoI", oInst.Foto);
                comando.Parameters.AddWithValue("@FechaNacI", oInst.FechaNacimiento);
                comando.Parameters.AddWithValue("@CorreoI", oInst.Correo);
                comando.Parameters.AddWithValue("@ClaveI", oInst.Clave);
                comando.Parameters.AddWithValue("@IDGeneroI", oInst.IDGenero);

                db.ExecuteNonQuery(comando);
            }
        }

        public void Actualizar(Instructor oIns)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarIns";

                comando.Parameters.AddWithValue("@IDIn", oIns.ID);
                comando.Parameters.AddWithValue("@NombreIn", oIns.Nombre);
                comando.Parameters.AddWithValue("@ApellidosIn", oIns.Apellidos);
                comando.Parameters.AddWithValue("@FotoIn", oIns.Foto);
                comando.Parameters.AddWithValue("@FechaNacIn", oIns.FechaNacimiento);
                comando.Parameters.AddWithValue("@CorreoIn", oIns.Correo);
                comando.Parameters.AddWithValue("@ClaveIn", oIns.Clave);
                comando.Parameters.AddWithValue("@IDGeneroIn", oIns.IDGenero);

                db.ExecuteNonQuery(comando);
            }
        }
        public void Eliminar(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_EliminarIns";
                comando.Parameters.AddWithValue("@IDIns", id);

                db.ExecuteNonQuery(comando);
            }
        }
        public static Instructor Login(string UserIns, string ClaveIn)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_LoginInstructor";
                comando.Parameters.AddWithValue("@userInst", UserIns);
                comando.Parameters.AddWithValue("@ClaveInst", ClaveIn);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    Instructor oIns = new Instructor();

                    oIns.ID = (int)reader["ID"];
                    oIns.Nombre = reader["Nombre"].ToString();
                    oIns.Apellidos = reader["Apellidos"].ToString();
                    oIns.Foto = (byte[])reader["Foto"];
                    oIns.FechaNacimiento = Convert.ToDateTime(reader["FechaNac"]);
                    oIns.Correo = reader["Correo"].ToString();
                    oIns.Clave = reader["Clave"].ToString();
                    oIns.IDGenero = (int)reader["IDGenero"];
                    oIns.Genero = GeneroDAL.SeleccionarPorId(oIns.IDGenero);

                    return oIns;
                }
            }
            return null;
        }

        public static Instructor SeleccionarPorId(int IDIns)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarInstructorXID";
                comando.Parameters.AddWithValue("@IDInstructor", IDIns);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Instructor oIns = new Instructor();

                    oIns.ID = (int)dr["ID"];
                    oIns.Nombre = dr["Nombre"].ToString();
                    oIns.Apellidos = dr["Apellidos"].ToString();
                    oIns.Foto = (byte[])dr["Foto"];
                    oIns.FechaNacimiento = Convert.ToDateTime(dr["FechaNac"]);
                    oIns.Correo = dr["Correo"].ToString();
                    oIns.Clave = dr["Clave"].ToString();
                    oIns.IDGenero = (int)dr["IDGenero"];
                    oIns.Genero = GeneroDAL.SeleccionarPorId(oIns.IDGenero);

                    return oIns;
                }
            }
            return null;
        }
        public static List<Instructor> SeleccionarTodos()
        {
            List<Instructor> lista = new List<Instructor>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarInstructor";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Instructor oIns = new Instructor();

                    oIns.ID = (int)dr["ID"];
                    oIns.Nombre = dr["Nombre"].ToString();
                    oIns.Apellidos = dr["Apellidos"].ToString();
                    oIns.Foto = (byte[])dr["Foto"];
                    oIns.FechaNacimiento = Convert.ToDateTime(dr["FechaNac"]);
                    oIns.Correo = dr["Correo"].ToString();
                    oIns.Clave = dr["Clave"].ToString();
                    oIns.IDGenero = (int)dr["IDGenero"];
                    oIns.Genero = GeneroDAL.SeleccionarPorId(oIns.IDGenero);

                    lista.Add(oIns);
                }
            }

            return lista;
        }

    }
}
