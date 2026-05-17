using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Historial_CitasBL
    {
        public List<Historial_Citas> ObtenerTodos() => Historial_CitasDAL.ObtenerTodos();

        public int Insertar(Historial_Citas obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Accion))
                throw new Exception("La acción del historial es obligatoria.");
            if (string.IsNullOrWhiteSpace(obj.Usuario))
                throw new Exception("El usuario que realiza la acción es obligatorio.");
            if (obj.Id_Cita <= 0)
                throw new Exception("Debe asociar el historial a una cita válida.");
            return Historial_CitasDAL.Insertar(obj);
        }

        public int Actualizar(Historial_Citas obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Accion))
                throw new Exception("La acción del historial es obligatoria.");
            if (string.IsNullOrWhiteSpace(obj.Usuario))
                throw new Exception("El usuario que realiza la acción es obligatorio.");
            if (obj.Id_Cita <= 0)
                throw new Exception("Debe asociar el historial a una cita válida.");
            return Historial_CitasDAL.Actualizar(obj);
        }

        // Baja lógica: el SP hace UPDATE estado = 0
        public int Eliminar(int id) => Historial_CitasDAL.Eliminar(id);
    }
}
