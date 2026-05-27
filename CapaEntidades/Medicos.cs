using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Medicos
    {
        public int Id_Medico { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int Id_Especialidad { get; set; }
        public bool Estado { get; set; }

        // Propiedad para mostrar el nombre de la especialidad en lugar del ID
        public string Nombre_Especialidad { get; set; }
    }
}
