using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class Historial_PacientesBL
    {
        public List<Historial_Pacientes> ObtenerTodos() => Historial_PacientesDAL.ObtenerTodos();

        public int Insertar(Historial_Pacientes obj)
        {
            if (obj.Id_Paciente <= 0)
                throw new Exception("Debe seleccionar un paciente válido.");
            // validaciones opcionales: longitudes, campos obligatorios
            return Historial_PacientesDAL.Insertar(obj);
        }

        public int Actualizar(Historial_Pacientes obj)
        {
            if (obj.Id_Historial <= 0)
                throw new Exception("Id de historial inválido.");
            if (obj.Id_Paciente <= 0)
                throw new Exception("Debe seleccionar un paciente válido.");
            return Historial_PacientesDAL.Actualizar(obj);
        }

        public int Eliminar(int id) => Historial_PacientesDAL.Eliminar(id);
    }
}
