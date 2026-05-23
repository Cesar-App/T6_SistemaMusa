using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Historial_Pacientes
    {
        public int Id_Historial { get; set; }
        public int Id_Paciente { get; set; }
        public string Alergias { get; set; }
        public string Enfermedades { get; set; }
        public string Medicamentos { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Observaciones { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public bool Estado { get; set; }
    }
}
