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
    public class AdministradorDAL
    {
        public void Insertar(Administrador oAdmin)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarAdm";

                comando.Parameters.AddWithValue("@IDA", oAdmin.ID);
                comando.Parameters.AddWithValue("@NombreA", oAdmin.Nombre);
                comando.Parameters.AddWithValue("@ApellidosA", oAdmin.Apellidos);
                comando.Parameters.AddWithValue("@FotoA", oAdmin.Foto);
                comando.Parameters.AddWithValue("@FechaNacA", oAdmin.FechaNacimiento);
                comando.Parameters.AddWithValue("@CorreoA", oAdmin.Correo);
                comando.Parameters.AddWithValue("@ClaveA", oAdmin.Clave);
                comando.Parameters.AddWithValue("@IDGeneroA", oAdmin.IDGenero);

                db.ExecuteNonQuery(comando);
            }
        }

        public void Actualizar(Administrador oAdmin)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarAdm";

                comando.Parameters.AddWithValue("@IDAd", oAdmin.ID);
                comando.Parameters.AddWithValue("@NombreAd", oAdmin.Nombre);
                comando.Parameters.AddWithValue("@ApellidosAd", oAdmin.Apellidos);
                comando.Parameters.AddWithValue("@FotoAd", oAdmin.Foto);
                comando.Parameters.AddWithValue("@FechaNacAd", oAdmin.FechaNacimiento);
                comando.Parameters.AddWithValue("@CorreoAd", oAdmin.Correo);
                comando.Parameters.AddWithValue("@ClaveAd", oAdmin.Clave);
                comando.Parameters.AddWithValue("@IDGeneroAd", oAdmin.IDGenero);

                db.ExecuteNonQuery(comando);
            }
        }
        public static Administrador Login(string user, string clave)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_LoginAdministrador";

                comando.Parameters.AddWithValue("@userAdmi", user);
                comando.Parameters.AddWithValue("@ClaveAdmi", clave);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    Administrador oADM = new Administrador();

                    oADM.ID = (int)reader["ID"];
                    oADM.Nombre = reader["Nombre"].ToString();
                    oADM.Apellidos = reader["Apellidos"].ToString();
                    oADM.Foto = (byte[])reader["Foto"];
                    oADM.FechaNacimiento = Convert.ToDateTime(reader["FechaNac"]);
                    oADM.Correo = reader["Correo"].ToString();
                    oADM.Clave = reader["Clave"].ToString();
                    oADM.IDGenero = (int)reader["IDGenero"];
                    oADM.Genero = GeneroDAL.SeleccionarPorId(oADM.IDGenero);

                    return oADM;
                }
            }
            return null;
        }

        public void Eliminar(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_EliminarAdm";
                comando.Parameters.AddWithValue("@IDAdmin", id);

                db.ExecuteNonQuery(comando);
            }
        }

        public static Administrador SeleccionarPorId(int IDAdmin)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarAdmin";
                comando.Parameters.AddWithValue("@IDAdminis", IDAdmin);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Administrador oADM = new Administrador();

                    oADM.ID = (int)dr["ID"];
                    oADM.Nombre = dr["Nombre"].ToString();
                    oADM.Apellidos = dr["Apellidos"].ToString();
                    oADM.Foto = (byte[])dr["Foto"];
                    oADM.FechaNacimiento = Convert.ToDateTime(dr["FechaNac"]);
                    oADM.Correo = dr["Correo"].ToString();
                    oADM.Clave = dr["Clave"].ToString();
                    oADM.IDGenero = (int)dr["IDGenero"];
                    oADM.Genero = GeneroDAL.SeleccionarPorId(oADM.IDGenero);

                    return oADM;
                }
            }
            return null;
        }
        public static List<Administrador> SeleccionarTodos()
        {
            List<Administrador> lista = new List<Administrador>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarAdminTodo";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Administrador oAdm = new Administrador();

                    oAdm.ID = (int)dr["ID"];
                    oAdm.Nombre = dr["Nombre"].ToString();
                    oAdm.Apellidos = dr["Apellidos"].ToString();
                    oAdm.Foto = (byte[])dr["Foto"];
                    oAdm.FechaNacimiento = Convert.ToDateTime(dr["FechaNac"]);
                    oAdm.Correo = dr["Correo"].ToString();
                    oAdm.Clave = dr["Clave"].ToString();
                    oAdm.IDGenero = (int)dr["IDGenero"];
                    oAdm.Genero = GeneroDAL.SeleccionarPorId(oAdm.IDGenero);

                    lista.Add(oAdm);
                }
            }

            return lista;
        }

    }
}
