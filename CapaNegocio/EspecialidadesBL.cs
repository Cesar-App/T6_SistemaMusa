using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class EspecialidadesBL
    {
        public List<Especialidades> ObtenerTodos() => EspecialidadesDAL.ObtenerTodos();

        public int Insertar(Especialidades obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Nombre_Especialidad))
                throw new System.Exception("El nombre de la especialidad es obligatorio.");
            return EspecialidadesDAL.Insertar(obj);
        }

        public int Actualizar(Especialidades obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Nombre_Especialidad))
                throw new System.Exception("El nombre de la especialidad es obligatorio.");
            return EspecialidadesDAL.Actualizar(obj);
        }

        // Baja lógica: el SP hace UPDATE estado = 0
        public int Eliminar(int id) => EspecialidadesDAL.Eliminar(id);
    }
}
