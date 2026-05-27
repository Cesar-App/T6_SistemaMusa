using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Horarios_Medicos
    {
        public int Id_Horario { get; set; }
        public string Dia_Semana { get; set; }
        public TimeSpan Hora_Inicio { get; set; }
        public TimeSpan Hora_Fin { get; set; }
        public int Id_Medico { get; set; }
        public bool Estado { get; set; }

        // Propiedad para mostrar el nombre del médico en lugar del ID
        public string Nombre_Medico { get; set; }
    }
}
