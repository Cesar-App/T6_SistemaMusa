using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class VistasBL
    {
        public List<VwPacientesActivos> ObtenerPacientesActivos() => VistasDAL.ObtenerPacientesActivos();
        public List<VwMedicosEspecialidades> ObtenerMedicosEspecialidades() => VistasDAL.ObtenerMedicosEspecialidades();
        public List<VwCitasCompletas> ObtenerCitasCompletas() => VistasDAL.ObtenerCitasCompletas();
        public List<VwUsuariosRoles> ObtenerUsuariosRoles() => VistasDAL.ObtenerUsuariosRoles();
        public List<VwHorariosMedicos> ObtenerHorariosMedicos() => VistasDAL.ObtenerHorariosMedicos();
        public List<VwHistorialCitas> ObtenerHistorialCitas() => VistasDAL.ObtenerHistorialCitas();
    }
}
