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
    public class Historial_CitasDAL
    {
        public static List<Historial_Citas> ObtenerTodos()
        {
            List<Historial_Citas> lista = new List<Historial_Citas>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerHistorial", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Historial_Citas
                    {
                        Id_Historial = Convert.ToInt32(dr["id_historial"]),
                        Accion = dr["accion"].ToString(),
                        Fecha = Convert.ToDateTime(dr["fecha"]),
                        Usuario = dr["usuario"].ToString(),
                        Id_Cita = Convert.ToInt32(dr["id_cita"]),
                        Estado = Convert.ToBoolean(dr["estado"])
                    });
                }
            }
            return lista;
        }

        public static int Insertar(Historial_Citas obj)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarHistorial", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accion", obj.Accion);
                cmd.Parameters.AddWithValue("@usuario", obj.Usuario);
                cmd.Parameters.AddWithValue("@id_cita", obj.Id_Cita);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static int Actualizar(Historial_Citas obj)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarHistorial", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_historial", obj.Id_Historial);
                cmd.Parameters.AddWithValue("@accion", obj.Accion);
                cmd.Parameters.AddWithValue("@usuario", obj.Usuario);
                cmd.Parameters.AddWithValue("@id_cita", obj.Id_Cita);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static int Eliminar(int id)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarHistorial", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_historial", id);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
