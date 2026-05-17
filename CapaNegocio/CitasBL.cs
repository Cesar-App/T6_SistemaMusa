using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CitasBL
    {
        private static readonly string[] EstadosValidos =
            { "Pendiente", "Confirmada", "Atendida", "Cancelada" };

        public List<Citas> ObtenerTodos() => CitasDAL.ObtenerTodos();

        public int Insertar(Citas obj)
        {
            if (obj.Fecha_Cita == default)
                throw new Exception("La fecha de la cita es obligatoria.");
            if (obj.Id_Paciente <= 0)
                throw new Exception("Debe seleccionar un paciente válido.");
            if (obj.Id_Medico <= 0)
                throw new Exception("Debe seleccionar un médico válido.");
            if (!Array.Exists(EstadosValidos, e => e == obj.Estado_Cita))
                throw new Exception("Estado inválido. Use: Pendiente, Confirmada, Atendida o Cancelada.");
            return CitasDAL.Insertar(obj);
        }

        public int Actualizar(Citas obj)
        {
            if (obj.Fecha_Cita == default)
                throw new Exception("La fecha de la cita es obligatoria.");
            if (obj.Id_Paciente <= 0)
                throw new Exception("Debe seleccionar un paciente válido.");
            if (obj.Id_Medico <= 0)
                throw new Exception("Debe seleccionar un médico válido.");
            if (!Array.Exists(EstadosValidos, e => e == obj.Estado_Cita))
                throw new Exception("Estado inválido. Use: Pendiente, Confirmada, Atendida o Cancelada.");
            return CitasDAL.Actualizar(obj);
        }

        // Baja lógica: el SP hace UPDATE estado = 0
        public int Eliminar(int id) => CitasDAL.Eliminar(id);
    }
}
