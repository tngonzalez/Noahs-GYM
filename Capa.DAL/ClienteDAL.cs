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
    public class ClienteDAL
    {
        public void Insertar(Cliente oCliente)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarCliente";

                comando.Parameters.AddWithValue("@IDC", oCliente.ID);
                comando.Parameters.AddWithValue("@NombreC", oCliente.Nombre);
                comando.Parameters.AddWithValue("@ApellidosC", oCliente.Apellidos);
                comando.Parameters.AddWithValue("@FotoC", oCliente.Foto);
                comando.Parameters.AddWithValue("@FechaNacC", oCliente.FechaNacimiento);
                comando.Parameters.AddWithValue("@CorreoC", oCliente.Correo);
                comando.Parameters.AddWithValue("@ClaveC", oCliente.Clave);
                comando.Parameters.AddWithValue("@TelefonoC", oCliente.Telefono);
                comando.Parameters.AddWithValue("@IDGeneroC", oCliente.Genero.ID);

                db.ExecuteNonQuery(comando);
            }
        }

        public void Actualizar(Cliente oCli)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarCliente";

                comando.Parameters.AddWithValue("@IDCl", oCli.ID);
                comando.Parameters.AddWithValue("@NombreCl", oCli.Nombre);
                comando.Parameters.AddWithValue("@ApellidosCl", oCli.Apellidos);
                comando.Parameters.AddWithValue("@FotoCl", oCli.Foto);
                comando.Parameters.AddWithValue("@FechaNacCl", oCli.FechaNacimiento);
                comando.Parameters.AddWithValue("@CorreoCl", oCli.Correo);
                comando.Parameters.AddWithValue("@ClaveCl", oCli.Clave);
                comando.Parameters.AddWithValue("@TelefonoCl", oCli.Telefono);
                comando.Parameters.AddWithValue("@IDGeneroCl", oCli.IdGenero);

                db.ExecuteNonQuery(comando);
            }
        }

        public static Cliente SeleccionarPorId(int IDCliente)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarClienteXID";
                comando.Parameters.AddWithValue("@IDCli", IDCliente);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Cliente oCli = new Cliente();

                    oCli.ID = (int)dr["ID"];
                    oCli.Nombre = dr["Nombre"].ToString();
                    oCli.Apellidos = dr["Apellidos"].ToString();
                    oCli.Foto = (byte[])dr["Foto"];
                    oCli.FechaNacimiento = Convert.ToDateTime(dr["FechaNac"]);
                    oCli.Correo = dr["Correo"].ToString();
                    oCli.Clave = dr["Clave"].ToString();
                    oCli.Telefono = dr["Telefono"].ToString();
                    oCli.IdGenero = (int)dr["IDGenero"];
                    oCli.Genero = GeneroDAL.SeleccionarPorId(oCli.IdGenero);

                    return oCli;
                }
            }
            return null;
        }

        public static List<Cliente> SeleccionarTodos()
        {
            List<Cliente> lista = new List<Cliente>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarClientes";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Cliente oCli = new Cliente();

                    oCli.ID = (int)dr["ID"];
                    oCli.Nombre = dr["Nombre"].ToString();
                    oCli.Apellidos = dr["Apellidos"].ToString();
                    oCli.Foto = (byte[])dr["Foto"];
                    oCli.FechaNacimiento = Convert.ToDateTime(dr["FechaNac"]);
                    oCli.Correo = dr["Correo"].ToString();
                    oCli.Clave = dr["Clave"].ToString();
                    oCli.Telefono = dr["Telefono"].ToString();
                    oCli.IdGenero = (int)dr["IDGenero"];
                    oCli.Genero = GeneroDAL.SeleccionarPorId(oCli.IdGenero);

                    lista.Add(oCli);
                }
            }

            return lista;
        }

        public void Eliminar(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_EliminarCliente";
                comando.Parameters.AddWithValue("@IDCliE", id);

                db.ExecuteNonQuery(comando);
            }
        }

        public static Cliente Login(string UserCli, string ClaveCli)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_LoginCliente";
                comando.Parameters.AddWithValue("@UserClient", UserCli);
                comando.Parameters.AddWithValue("@ClaveClient", ClaveCli);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    Cliente oCli = new Cliente();

                    oCli.ID = (int)reader["ID"];
                    oCli.Nombre = reader["Nombre"].ToString();
                    oCli.Apellidos = reader["Apellidos"].ToString();
                    oCli.Foto = (byte[])reader["Foto"];
                    oCli.FechaNacimiento = Convert.ToDateTime(reader["FechaNac"]);
                    oCli.Correo = reader["Correo"].ToString();
                    oCli.Clave = reader["Clave"].ToString();
                    oCli.Telefono = reader["Telefono"].ToString(); 
                    oCli.IdGenero = (int)reader["IDGenero"];
                    oCli.Genero = GeneroDAL.SeleccionarPorId(oCli.IdGenero);

                    return oCli; 
                }
                return null; 
            }
        }

        //Tabla ClienteRutina
        public void InsertarClienteRutina(int IDCliente, int IDRutina, string Dia)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarClienteRutina";

                comando.Parameters.AddWithValue("@IDClienteCR", IDCliente);
                comando.Parameters.AddWithValue("@IDRutinaCR", IDRutina);
                comando.Parameters.AddWithValue("@DiaRut", Dia);


                db.ExecuteNonQuery(comando);
            }
        }



        public void EliminarClienteRutina(int IDCliente, int IDRutina)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_EliminarClienteRutina";
                comando.Parameters.AddWithValue("@IDClienteCRut", IDCliente);
                comando.Parameters.AddWithValue("@IDRutinaCRut", IDRutina);
               

                db.ExecuteNonQuery(comando);
            }
        }



        public static Rutina SeleccionarRutinaXCliente(int IDCliente)
        {
            List<Rutina> lista = new List<Rutina>();

            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarClienteRutinaXCliente";
                comando.Parameters.AddWithValue("@@IDClienteCRuti", IDCliente);

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

    }
}
