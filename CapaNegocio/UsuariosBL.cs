using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class UsuariosBL
    {
        public List<Usuarios> ObtenerTodos() => UsuariosDAL.ObtenerTodos();

        public Usuarios Login(string username, string password)
        {
            // validaciones simples: si faltan credenciales devolvemos null
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return null;

            // delegar la verificación al DAL
            return UsuariosDAL.Login(username.Trim(), password);
        }

        public int Insertar(Usuarios obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Nombre))
                throw new System.Exception("El nombre del usuario es obligatorio.");
            return UsuariosDAL.Insertar(obj);
        }

        public int Actualizar(Usuarios obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Nombre))
                throw new System.Exception("El nombre del usuario es obligatorio.");
            return UsuariosDAL.Actualizar(obj);
        }

        public int Eliminar(int id) => UsuariosDAL.Eliminar(id);
    }
}
