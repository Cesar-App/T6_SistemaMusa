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

                // C#
                var columnas = Enumerable.Range(0, dr.FieldCount)
                    .Select(i => dr.GetName(i))
                    .ToHashSet(StringComparer.OrdinalIgnoreCase);

                while (dr.Read())
                {
                    lista.Add(new Usuarios
                    {
                        Id_Usuario = columnas.Contains("id_usuario") ? Convert.ToInt32(dr["id_usuario"]) : 0,
                        Username   = columnas.Contains("username")   ? dr["username"].ToString() : null,
                        Password   = columnas.Contains("password")   ? dr["password"].ToString() : null,
                        Nombre     = columnas.Contains("nombre")     ? dr["nombre"].ToString() : null,
                        Id_Rol     = columnas.Contains("id_rol")     ? Convert.ToInt32(dr["id_rol"]) : 0,
                        Estado     = columnas.Contains("estado")     ? Convert.ToBoolean(dr["estado"]) : false,
                        Nombre_Rol = columnas.Contains("Nombre_Rol") ? dr["Nombre_Rol"].ToString() : null,
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
                SqlCommand cmd = new SqlCommand(
                    @"SELECT u.id_usuario, u.username, u.password, u.nombre, 
                     u.id_rol, u.estado, r.nombre AS nombre_rol
              FROM Usuarios u
              INNER JOIN Roles r ON u.id_rol = r.id_rol
              WHERE u.username = @user AND u.password = @pass AND u.estado = 1", con);

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
                        Estado = Convert.ToBoolean(dr["estado"]),
                        Nombre_Rol = dr["nombre_rol"].ToString() // ✅ Esto es lo que falta
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
