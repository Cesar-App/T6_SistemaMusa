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
    public class Horarios_MedicosDAL
    {
        public static List<Horarios_Medicos> ObtenerTodos()
        {
            List<Horarios_Medicos> lista = new List<Horarios_Medicos>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerHorarios", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Horarios_Medicos
                    {
                        Id_Horario = Convert.ToInt32(dr["id_horario"]),
                        Dia_Semana = dr["dia_semana"].ToString(),
                        Hora_Inicio = (TimeSpan)dr["hora_inicio"],
                        Hora_Fin = (TimeSpan)dr["hora_fin"],
                        Id_Medico = Convert.ToInt32(dr["id_medico"]),
                        Estado = Convert.ToBoolean(dr["estado"]),

                        // Para Mostrar los nombres en lugar de los IDs
                        Nombre_Medico = dr["Nombre_Medico"].ToString()
                    });
                }
            }
            return lista;
        }

        public static int Insertar(Horarios_Medicos obj)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarHorario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dia_semana", obj.Dia_Semana);
                cmd.Parameters.AddWithValue("@hora_inicio", obj.Hora_Inicio);
                cmd.Parameters.AddWithValue("@hora_fin", obj.Hora_Fin);
                cmd.Parameters.AddWithValue("@id_medico", obj.Id_Medico);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static int Actualizar(Horarios_Medicos obj)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarHorario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_horario", obj.Id_Horario);
                cmd.Parameters.AddWithValue("@dia_semana", obj.Dia_Semana);
                cmd.Parameters.AddWithValue("@hora_inicio", obj.Hora_Inicio);
                cmd.Parameters.AddWithValue("@hora_fin", obj.Hora_Fin);
                cmd.Parameters.AddWithValue("@id_medico", obj.Id_Medico);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static int Eliminar(int id)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarHorario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_horario", id);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
