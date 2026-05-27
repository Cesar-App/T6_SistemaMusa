using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Citas
    {
        public int Id_Cita { get; set; }
        public DateTime Fecha_Cita { get; set; }
        public TimeSpan Hora_Cita { get; set; }
        public string Motivo { get; set; }
        public string Estado_Cita { get; set; }
        public string Observacion { get; set; }
        public int Id_Paciente { get; set; }
        public int Id_Medico { get; set; }
        public bool Estado { get; set; }

        // Para mostrar en la grilla, no se mapean a la base
        public string Nombre_Paciente { get; set; }
        public string Nombre_Medico { get; set; }
    }
}
