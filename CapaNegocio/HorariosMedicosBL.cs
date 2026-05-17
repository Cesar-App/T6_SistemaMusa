using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Horarios_MedicosBL
    {
        public List<Horarios_Medicos> ObtenerTodos() => Horarios_MedicosDAL.ObtenerTodos();

        public int Insertar(Horarios_Medicos obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Dia_Semana))
                throw new Exception("El día de la semana es obligatorio.");
            if (obj.Id_Medico <= 0)
                throw new Exception("Debe seleccionar un médico válido.");
            if (obj.Hora_Fin <= obj.Hora_Inicio)
                throw new Exception("La hora de fin debe ser mayor que la hora de inicio.");
            return Horarios_MedicosDAL.Insertar(obj);
        }

        public int Actualizar(Horarios_Medicos obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Dia_Semana))
                throw new Exception("El día de la semana es obligatorio.");
            if (obj.Id_Medico <= 0)
                throw new Exception("Debe seleccionar un médico válido.");
            if (obj.Hora_Fin <= obj.Hora_Inicio)
                throw new Exception("La hora de fin debe ser mayor que la hora de inicio.");
            return Horarios_MedicosDAL.Actualizar(obj);
        }

        // Baja lógica: el SP hace UPDATE estado = 0
        public int Eliminar(int id) => Horarios_MedicosDAL.Eliminar(id);
    }
}
