using CapaEntidades;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PacientesBL
    {
        public List<Pacientes> ObtenerTodos() => PacientesDAL.ObtenerTodos();

        public int Insertar(Pacientes obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Nombre))
                throw new System.Exception("El nombre del paciente es obligatorio.");
            if (string.IsNullOrWhiteSpace(obj.Apellido))
                throw new System.Exception("El apellido del paciente es obligatorio.");
            if (string.IsNullOrWhiteSpace(obj.Cedula))
                throw new System.Exception("La cédula del paciente es obligatoria.");
            return PacientesDAL.Insertar(obj);
        }

        public int Actualizar(Pacientes obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Nombre))
                throw new System.Exception("El nombre del paciente es obligatorio.");
            if (string.IsNullOrWhiteSpace(obj.Apellido))
                throw new System.Exception("El apellido del paciente es obligatorio.");
            if (string.IsNullOrWhiteSpace(obj.Cedula))
                throw new System.Exception("La cédula del paciente es obligatoria.");
            return PacientesDAL.Actualizar(obj);
        }
        public int Eliminar(int id) => PacientesDAL.Eliminar(id);
    }
}
