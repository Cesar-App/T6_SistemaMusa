using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuarios
    {
        public int Id_Usuario { get; set; }
        public string Username { get; set; }
        public string Nombre { get; set; }
        public int Id_Rol { get; set; }
        public bool Estado { get; set; }

       
    }
}
