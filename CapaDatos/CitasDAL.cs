using CapaDatos;
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
    public class CitasDAL
    {
        public static List<Citas> ObtenerTodos()
        {
            List<Citas> lista = new List<Citas>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerCitas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Citas
                    {
                        Id_Cita = Convert.ToInt32(dr["id_cita"]),
                        Fecha_Cita = Convert.ToDateTime(dr["fecha_cita"]),
                        Hora_Cita = (TimeSpan)dr["hora_cita"],
                        Motivo = dr["motivo"].ToString(),
                        Estado_Cita = dr["estado_cita"].ToString(),
                        Observacion = dr["observacion"].ToString(),
                        Id_Paciente = Convert.ToInt32(dr["id_paciente"]),
                        Id_Medico = Convert.ToInt32(dr["id_medico"]),
                        Estado = Convert.ToBoolean(dr["estado"]),

                        // Para Mostrar los nombres en lugar de los IDs
                        Nombre_Paciente = dr["Nombre_Paciente"].ToString(),
                        Nombre_Medico = dr["Nombre_Medico"].ToString()
                    });
                }
            }
            return lista;
        }

        public static int Insertar(Citas obj)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarCita", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_cita", obj.Fecha_Cita);
                cmd.Parameters.AddWithValue("@hora_cita", obj.Hora_Cita);
                cmd.Parameters.AddWithValue("@motivo", obj.Motivo ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@estado_cita", obj.Estado_Cita);
                cmd.Parameters.AddWithValue("@observacion", obj.Observacion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@id_paciente", obj.Id_Paciente);
                cmd.Parameters.AddWithValue("@id_medico", obj.Id_Medico);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static int Actualizar(Citas obj)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarCita", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cita", obj.Id_Cita);
                cmd.Parameters.AddWithValue("@fecha_cita", obj.Fecha_Cita);
                cmd.Parameters.AddWithValue("@hora_cita", obj.Hora_Cita);
                cmd.Parameters.AddWithValue("@motivo", obj.Motivo ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@estado_cita", obj.Estado_Cita);
                cmd.Parameters.AddWithValue("@observacion", obj.Observacion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@id_paciente", obj.Id_Paciente);
                cmd.Parameters.AddWithValue("@id_medico", obj.Id_Medico);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static int Eliminar(int id)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarCita", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cita", id);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}