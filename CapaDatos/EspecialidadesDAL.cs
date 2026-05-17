using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class EspecialidadesDAL
    {
        public static List<Especialidades> ObtenerTodos()
        {
            List<Especialidades> lista = new List<Especialidades>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerEspecialidades", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Especialidades
                    {
                        Id_Especialidad = Convert.ToInt32(dr["id_especialidad"]),
                        Nombre_Especialidad = dr["nombre_especialidad"].ToString(),
                        Descripcion = dr["descripcion"].ToString(),
                        Estado = Convert.ToBoolean(dr["estado"])
                    });
                }
            }
            return lista;
        }

        public static int Insertar(Especialidades obj)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarEspecialidad", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre_especialidad", obj.Nombre_Especialidad);
                cmd.Parameters.AddWithValue("@descripcion", obj.Descripcion ?? (object)DBNull.Value);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static int Actualizar(Especialidades obj)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarEspecialidad", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_especialidad", obj.Id_Especialidad);
                cmd.Parameters.AddWithValue("@nombre_especialidad", obj.Nombre_Especialidad);
                cmd.Parameters.AddWithValue("@descripcion", obj.Descripcion ?? (object)DBNull.Value);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static int Eliminar(int id)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarEspecialidad", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_especialidad", id);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
