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
    public static class PacientesDAL
    {
        public static List<Pacientes> ObtenerTodos()
        {
            List<Pacientes> lista = new List<Pacientes>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerPacientes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Pacientes
                    {
                        Id_Paciente = Convert.ToInt32(dr["id_paciente"]),
                        Nombre = dr["nombre"].ToString(),
                        Apellido = dr["apellido"].ToString(),
                        Cedula = dr["cedula"].ToString(),
                        Telefono = dr["telefono"].ToString(),
                        Direccion = dr["direccion"].ToString(),
                        Fecha_Nacimiento = dr["fecha_nacimiento"] == DBNull.Value
                                           ? (DateTime?)null
                                           : Convert.ToDateTime(dr["fecha_nacimiento"]),
                        Sexo = dr["sexo"].ToString(),
                        Estado = Convert.ToBoolean(dr["estado"])
                    });
                }
            }
            return lista;
        }

        public static int Insertar(Pacientes obj)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
               
                SqlCommand cmd = new SqlCommand("sp_InsertarPaciente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@apellido", obj.Apellido ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@cedula", obj.Cedula);
                cmd.Parameters.AddWithValue("@telefono", obj.Telefono);
                cmd.Parameters.AddWithValue("@direccion", obj.Direccion);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", obj.Fecha_Nacimiento);
                cmd.Parameters.AddWithValue("@sexo", obj.Sexo);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static int Actualizar(Pacientes obj)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                
                SqlCommand cmd = new SqlCommand("sp_ActualizarPaciente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_paciente", obj.Id_Paciente);
                cmd.Parameters.AddWithValue("@nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@apellido", obj.Apellido ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@cedula", obj.Cedula);
                cmd.Parameters.AddWithValue("@telefono", obj.Telefono);
                cmd.Parameters.AddWithValue("@direccion", obj.Direccion);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", obj.Fecha_Nacimiento);
                cmd.Parameters.AddWithValue("@sexo", obj.Sexo);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static int Eliminar(int id)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarPaciente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_paciente", id);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}