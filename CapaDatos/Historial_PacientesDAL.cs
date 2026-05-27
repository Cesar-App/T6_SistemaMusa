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
    public class Historial_PacientesDAL
    {
        public static List<Historial_Pacientes> ObtenerTodos()
        {
            List<Historial_Pacientes> lista = new List<Historial_Pacientes>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerHistorialMedico", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Historial_Pacientes
                    {
                        Id_Historial = Convert.ToInt32(dr["id_historial"]),
                        Id_Paciente = Convert.ToInt32(dr["id_paciente"]),
                        Alergias = dr["alergias"].ToString(),
                        Enfermedades = dr["enfermedades"].ToString(),
                        Medicamentos = dr["medicamentos"].ToString(),
                        Diagnostico = dr["diagnostico"].ToString(),
                        Tratamiento = dr["tratamiento"].ToString(),
                        Observaciones = dr["observaciones"].ToString(),
                        Fecha_Registro = Convert.ToDateTime(dr["fecha_registro"]),
                        Estado = Convert.ToBoolean(dr["estado"]),

                        // Para Mostrar los nombres en lugar de los IDs
                        Nombre_Paciente = dr["Nombre_Paciente"].ToString(),
                    });
                }
            }
            return lista;
        }

        public static int Insertar(Historial_Pacientes obj)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarHistorialMedico", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_paciente", obj.Id_Paciente);
                cmd.Parameters.AddWithValue("@alergias", obj.Alergias ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@enfermedades", obj.Enfermedades ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@medicamentos", obj.Medicamentos ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@diagnostico", obj.Diagnostico ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@tratamiento", obj.Tratamiento ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@observaciones", obj.Observaciones ?? (object)DBNull.Value);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static int Actualizar(Historial_Pacientes obj)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarHistorialMedico", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_historial", obj.Id_Historial);
                cmd.Parameters.AddWithValue("@id_paciente", obj.Id_Paciente);
                cmd.Parameters.AddWithValue("@alergias", obj.Alergias ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@enfermedades", obj.Enfermedades ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@medicamentos", obj.Medicamentos ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@diagnostico", obj.Diagnostico ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@tratamiento", obj.Tratamiento ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@observaciones", obj.Observaciones ?? (object)DBNull.Value);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static int Eliminar(int id)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarHistorialMedico", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_historial", id);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}

