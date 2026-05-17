using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class MedicosBL
    {
        public List<Medicos> ObtenerTodos() => MedicosDAL.ObtenerTodos();

        public int Insertar(Medicos obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Nombre))
                throw new System.Exception("El nombre del médico es obligatorio.");
            if (string.IsNullOrWhiteSpace(obj.Apellido))
                throw new System.Exception("El apellido del médico es obligatorio.");
            if (obj.Id_Especialidad <= 0)
                throw new System.Exception("Debe seleccionar una especialidad válida.");
            return MedicosDAL.Insertar(obj);
        }

        public int Actualizar(Medicos obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Nombre))
                throw new System.Exception("El nombre del médico es obligatorio.");
            if (string.IsNullOrWhiteSpace(obj.Apellido))
                throw new System.Exception("El apellido del médico es obligatorio.");
            if (obj.Id_Especialidad <= 0)
                throw new System.Exception("Debe seleccionar una especialidad válida.");
            return MedicosDAL.Actualizar(obj);
        }

        // Baja lógica: el SP hace UPDATE estado = 0
        public int Eliminar(int id) => MedicosDAL.Eliminar(id);
    }
}
