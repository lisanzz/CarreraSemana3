using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCarreras.Dominio
{
    public class AccesoBD
    {
        private SqlConnection conexion = new SqlConnection(
            @"Data Source=(localdb)\local;Initial Catalog=Carreras;Integrated Security=True");
        private SqlCommand comando = new SqlCommand();

        private void ConfigurarComando_SP(string SPNombre)
        {
            comando.Connection = conexion;
            comando.CommandText = SPNombre;
            comando.CommandType = System.Data.CommandType.StoredProcedure;
        }

        public DataTable Consultar_SP(string SPNombre)
        {
            DataTable tabla = new DataTable();

            conexion.Open();
            ConfigurarComando_SP(SPNombre);
            tabla.Load(comando.ExecuteReader());

            conexion.Close();

            return tabla;
        }

        public void AltaDetallesCarrera_SP(string SPNombre, int id_carrera, Carrera carrera)
        {
            conexion.Open();
            ConfigurarComando_SP(SPNombre);

            for (int i = 0; i < carrera.DetallesCarrera.Count; i++)
            {
                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@anioCursado", carrera.DetallesCarrera[i].AnioCursado);
                comando.Parameters.AddWithValue("@cuatrimestre", carrera.DetallesCarrera[i].Cuatrimestre);
                comando.Parameters.AddWithValue("@id_asignatura", carrera.DetallesCarrera[i].Materia.Id_asignatura);
                comando.Parameters.AddWithValue("@id_carrera", id_carrera);

                comando.ExecuteNonQuery();
            }

            conexion.Close();
        }

        public bool AltaCarrera(Carrera carrera)
        {
            bool respuesta = true;
            SqlTransaction transaccion = null;

            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();

                SqlCommand cmdMaestro = new SqlCommand("SP_insertar_carrera", conexion, transaccion);
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@new_id_carrera", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmdMaestro.Parameters.Add(param);
                cmdMaestro.ExecuteNonQuery();

                int id_carrera = Convert.ToInt32(param.Value);
                SqlCommand comandoDetalle = new SqlCommand("SP_insertar_detalleCarreras", conexion, transaccion);
                comandoDetalle.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < carrera.DetallesCarrera.Count; i++)
                {
                    comandoDetalle.Parameters.Clear();
                    comandoDetalle.Parameters.AddWithValue("@anioCursado", carrera.DetallesCarrera[i].AnioCursado);
                    comandoDetalle.Parameters.AddWithValue("@cuatrimestre", carrera.DetallesCarrera[i].Cuatrimestre);
                    comandoDetalle.Parameters.AddWithValue("@id_asignatura", carrera.DetallesCarrera[i].Materia.Id_asignatura);
                    comandoDetalle.Parameters.AddWithValue("@id_carrera", id_carrera);
                    comandoDetalle.ExecuteNonQuery();
                }
                transaccion.Commit();
            }
            catch (Exception)
            {
                transaccion.Rollback();
                respuesta = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return respuesta;
        }

        public int AltaCarrera_SP(string SPName, Carrera carrera)
        {
            int id_carrera;

            conexion.Open();
            ConfigurarComando_SP(SPName);
            comando.Parameters.AddWithValue("@nombre", carrera.Nombre_Titulo);

            SqlParameter param = new SqlParameter("@new_id_carrera", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            comando.Parameters.Add(param);

            comando.ExecuteNonQuery();

            id_carrera = Convert.ToInt32(param.Value);

            conexion.Close();
            return id_carrera;

        }

        public List<Carrera> ConsultarCarreras()
        {
            using (SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=Carreras;Integrated Security=True"))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "consultarCarreras";
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    List<Carrera> lstc = new List<Carrera>();
                    foreach (DataRow fila in dt.Rows)
                    {
                        int Id_Carrera = Convert.ToInt32(fila[0]);
                        string NombreTitulo = fila[1].ToString();


                        Carrera c = new Carrera(Id_Carrera, NombreTitulo);
                        lstc.Add(c);
                    }
                    return lstc;
                }


            }
        }


            public List<Asignatura> ConsultarAsignatura()
        {
            using (SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=Carreras;Integrated Security=True"))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandText = "consultarAsignaturas";
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    List<Asignatura> lsta = new List<Asignatura>();
                    foreach (DataRow fila in dt.Rows)
                    {
                        int id_asignatura = Convert.ToInt32(fila[0]);
                        string nombre = fila[1].ToString();

                        Asignatura a = new Asignatura(id_asignatura, nombre);
                        lsta.Add(a);
                    }
                    return lsta;
                }
            }
        }
        public DataTable ConsultarPlanCarrera(int idCarrera)
        {
            DataTable tabla = new DataTable();
            conexion.Open();

            SqlCommand cmd = new SqlCommand("sp_consultar_detalleCarreras", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_carrera", idCarrera);

            tabla.Load(cmd.ExecuteReader());
            conexion.Close();
            return tabla;
        }


        public bool EliminarCarrera(int idCarrera)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\local;Initial Catalog=Carreras;Integrated Security=True"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_eliminar_carrera", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id_carrera", idCarrera);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true; 
                        }
                        else
                        {
                            return false; 
                        }
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }







    }
    }


