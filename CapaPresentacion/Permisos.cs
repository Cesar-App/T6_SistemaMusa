using CapaEntidades;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public static class PermisosHelper
    {
        public static void AplicarPermisos(Form form)
        {
            if (Session.CurrentUser == null) return;

            string rol = Session.CurrentUser.Nombre_Rol?.ToLower() ?? "";

            switch (rol)
            {
                case "administrador":
                    // Ve todo, no ocultar nada
                    break;

                case "recepcionista":
                    OcultarBoton(form, "btnUsuarios");
                    OcultarBoton(form, "btnRoles");
                    OcultarBoton(form, "btnMedicos");
                    OcultarBoton(form, "btnEspecialidades");
                    OcultarBoton(form, "btnHorarios");
                    break;

                case "médico":
                case "medico":
                    OcultarBoton(form, "btnUsuarios");
                    OcultarBoton(form, "btnRoles");
                    OcultarBoton(form, "btnMedicos");
                    OcultarBoton(form, "btnEspecialidades");
                    OcultarBoton(form, "btnHorarios");
                    OcultarBoton(form, "btnPacientes");
                    break;
            }
        }

        private static void OcultarBoton(Form form, string nombreControl)
        {
            var control = form.Controls.Find(nombreControl, true).FirstOrDefault();
            if (control != null) control.Visible = false;
        }
    }
}