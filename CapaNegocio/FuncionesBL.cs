using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class FuncionesBL
    {
        public int ContarPacientesActivos() => FuncionesDAL.ContarPacientesActivos();
        public string NombreCompletoPaciente(int id) => FuncionesDAL.NombreCompletoPaciente(id);
        public int CantidadCitasMedico(int id) => FuncionesDAL.CantidadCitasMedico(id);
        public string EspecialidadMedico(int id) => FuncionesDAL.EspecialidadMedico(id);
        public int TotalUsuariosActivos() => FuncionesDAL.TotalUsuariosActivos();
        public int TotalCitasPendientes() => FuncionesDAL.TotalCitasPendientes();
    }
}
