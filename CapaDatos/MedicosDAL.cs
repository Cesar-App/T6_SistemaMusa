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
    public class MedicosDAL
    {
        public static List<Medicos> ObtenerTodos()
        {
            List<Medicos> lista = new List<Medicos>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerMedicos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Medicos
                    {
                        Id_Medico = Convert.ToInt32(dr["id_medico"]),
                        Nombre = dr["nombre"].ToString(),
                        Apellido = dr["apellido"].ToString(),
                        Telefono = dr["telefono"].ToString(),
                        Correo = dr["correo"].ToString(),
                        Id_Especialidad = Convert.ToInt32(dr["id_especialidad"]),
                        Estado = Convert.ToBoolean(dr["estado"]),

                        // Para Mostrar los nombres en lugar de los IDs
                        Nombre_Especialidad = dr["Nombre_Especialidad"].ToString()
                    });
                }
            }
            return lista;
        }

        public static int Insertar(Medicos obj)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarMedico", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@apellido", obj.Apellido);
                cmd.Parameters.AddWithValue("@telefono", obj.Telefono ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@correo", obj.Correo ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@id_especialidad", obj.Id_Especialidad);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static int Actualizar(Medicos obj)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarMedico", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_medico", obj.Id_Medico);
                cmd.Parameters.AddWithValue("@nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@apellido", obj.Apellido);
                cmd.Parameters.AddWithValue("@telefono", obj.Telefono ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@correo", obj.Correo ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@id_especialidad", obj.Id_Especialidad);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static int Eliminar(int id)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarMedico", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_medico", id);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
