using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Historial_Citas
    {
        public int Id_Historial { get; set; }
        public string Accion { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public int Id_Cita { get; set; }
        public bool Estado { get; set; }

        // Propiedad para mostrar el nombre del usuario en lugar del ID
        public string Nombre_Paciente_Cita { get; set; }
    }
}
