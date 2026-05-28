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
            if (string.IsNullOrWhiteSpace(obj.Cedula))
                throw new System.Exception("La Cedula del paciente es obligatorio.");
            if (string.IsNullOrWhiteSpace(obj.Telefono))
                throw new System.Exception("El Telefono del paciente es obligatoria.");
            if (obj.Fecha_Nacimiento == null)
                throw new System.Exception("La Fecha_Nacimiento del paciente es obligatoria.");
            if (string.IsNullOrWhiteSpace(obj.Sexo))
                throw new System.Exception("El Sexo del paciente es obligatoria.");
            return PacientesDAL.Insertar(obj);
        }

        public int Actualizar(Pacientes obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Nombre))
                throw new System.Exception("El nombre del paciente es obligatorio.");
            if (string.IsNullOrWhiteSpace(obj.Cedula))
                throw new System.Exception("La Cedula del paciente es obligatorio.");
            if (string.IsNullOrWhiteSpace(obj.Telefono))
                throw new System.Exception("El Telefono del paciente es obligatoria.");
            if (obj.Fecha_Nacimiento == null)
                throw new System.Exception("La Fecha_Nacimiento del paciente es obligatoria.");
            if (string.IsNullOrWhiteSpace(obj.Sexo))
                throw new System.Exception("el Sexo del paciente es obligatoria.");
            return PacientesDAL.Actualizar(obj);
        }
        public int Eliminar(int id) => PacientesDAL.Eliminar(id);
    }
}
