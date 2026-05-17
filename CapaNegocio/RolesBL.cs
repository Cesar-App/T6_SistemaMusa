using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class RolesBL
    {
        public List<Roles> ObtenerTodos() => RolesDAL.ObtenerTodos();

        public int Insertar(Roles obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Nombre))
                throw new System.Exception("El nombre del rol es obligatorio.");
            return RolesDAL.Insertar(obj);
        }

        public int Actualizar(Roles obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Nombre))
                throw new System.Exception("El nombre del rol es obligatorio.");
            return RolesDAL.Actualizar(obj);
        }

        public int Eliminar(int id) => RolesDAL.Eliminar(id);
    }
}
