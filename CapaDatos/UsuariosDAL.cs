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
    public class UsuariosDAL
    {
        public static List<Usuarios> ObtenerTodos()
        {
            List<Usuarios> lista = new List<Usuarios>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerUsuarios", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Usuarios
                    {
                        Id_Usuario = Convert.ToInt32(dr["id_usuario"]),
                        Username = dr["username"].ToString(),
                        Password = dr["password"].ToString(),
                        Nombre = dr["nombre"].ToString(),
                        Id_Rol = Convert.ToInt32(dr["id_rol"]),
                        Estado = Convert.ToBoolean(dr["estado"])
                    });
                }
            }
            return lista;
        }

        // El Login consulta la vista vw_UsuariosRoles para verificar credenciales
        public static Usuarios Login(string username, string password)
        {
            Usuarios obj = null;
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                // Usamos sp_ObtenerUsuarios y filtramos en memoria,
                // o una consulta directa a la vista (no hay SP de login en tu BD)
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Usuarios WHERE username=@user AND password=@pass AND estado=1", con);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    obj = new Usuarios
                    {
                        Id_Usuario = Convert.ToInt32(dr["id_usuario"]),
                        Username = dr["username"].ToString(),
                        Password = dr["password"].ToString(),
                        Nombre = dr["nombre"].ToString(),
                        Id_Rol = Convert.ToInt32(dr["id_rol"]),
                        Estado = Convert.ToBoolean(dr["estado"])
                    };
                }
            }
            return obj;
        }

        public static int Insertar(Usuarios obj)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", obj.Username);
                cmd.Parameters.AddWithValue("@password", obj.Password);
                cmd.Parameters.AddWithValue("@nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@id_rol", obj.Id_Rol);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static int Actualizar(Usuarios obj)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_usuario", obj.Id_Usuario);
                cmd.Parameters.AddWithValue("@username", obj.Username);
                cmd.Parameters.AddWithValue("@password", obj.Password);
                cmd.Parameters.AddWithValue("@nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@id_rol", obj.Id_Rol);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static int Eliminar(int id)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_usuario", id);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
