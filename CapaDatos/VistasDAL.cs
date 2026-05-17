using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class VwPacientesActivos
    {
        public int Id_Paciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }

    public class VwMedicosEspecialidades
    {
        public int Id_Medico { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nombre_Especialidad { get; set; }
    }

    public class VwCitasCompletas
    {
        public int Id_Cita { get; set; }
        public string Paciente { get; set; }
        public string Medico { get; set; }
        public string Nombre_Especialidad { get; set; }
        public DateTime Fecha_Cita { get; set; }
        public TimeSpan Hora_Cita { get; set; }
        public string Estado_Cita { get; set; }
    }

    public class VwUsuariosRoles
    {
        public int Id_Usuario { get; set; }
        public string Username { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }
    }

    public class VwHorariosMedicos
    {
        public int Id_Horario { get; set; }
        public string Medico { get; set; }
        public string Dia_Semana { get; set; }
        public TimeSpan Hora_Inicio { get; set; }
        public TimeSpan Hora_Fin { get; set; }
    }

    public class VwHistorialCitas
    {
        public int Id_Historial { get; set; }
        public string Accion { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public string Estado_Cita { get; set; }
    }

    // -------------------------------------------------------
    // Clase DAL que consume todas las vistas
    // -------------------------------------------------------
    public class VistasDAL
    {
        public static List<VwPacientesActivos> ObtenerPacientesActivos()
        {
            List<VwPacientesActivos> lista = new List<VwPacientesActivos>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM vw_PacientesActivos", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new VwPacientesActivos
                    {
                        Id_Paciente = Convert.ToInt32(dr["id_paciente"]),
                        Nombre = dr["nombre"].ToString(),
                        Apellido = dr["apellido"].ToString(),
                        Cedula = dr["cedula"].ToString(),
                        Telefono = dr["telefono"].ToString(),
                        Direccion = dr["direccion"].ToString()
                    });
                }
            }
            return lista;
        }

        public static List<VwMedicosEspecialidades> ObtenerMedicosEspecialidades()
        {
            List<VwMedicosEspecialidades> lista = new List<VwMedicosEspecialidades>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM vw_MedicosEspecialidades", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new VwMedicosEspecialidades
                    {
                        Id_Medico = Convert.ToInt32(dr["id_medico"]),
                        Nombre = dr["nombre"].ToString(),
                        Apellido = dr["apellido"].ToString(),
                        Nombre_Especialidad = dr["nombre_especialidad"].ToString()
                    });
                }
            }
            return lista;
        }

        public static List<VwCitasCompletas> ObtenerCitasCompletas()
        {
            List<VwCitasCompletas> lista = new List<VwCitasCompletas>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM vw_CitasCompletas", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new VwCitasCompletas
                    {
                        Id_Cita = Convert.ToInt32(dr["id_cita"]),
                        Paciente = dr["paciente"].ToString(),
                        Medico = dr["medico"].ToString(),
                        Nombre_Especialidad = dr["nombre_especialidad"].ToString(),
                        Fecha_Cita = Convert.ToDateTime(dr["fecha_cita"]),
                        Hora_Cita = (TimeSpan)dr["hora_cita"],
                        Estado_Cita = dr["estado_cita"].ToString()
                    });
                }
            }
            return lista;
        }

        public static List<VwUsuariosRoles> ObtenerUsuariosRoles()
        {
            List<VwUsuariosRoles> lista = new List<VwUsuariosRoles>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM vw_UsuariosRoles", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new VwUsuariosRoles
                    {
                        Id_Usuario = Convert.ToInt32(dr["id_usuario"]),
                        Username = dr["username"].ToString(),
                        Nombre = dr["nombre"].ToString(),
                        Rol = dr["rol"].ToString()
                    });
                }
            }
            return lista;
        }

        public static List<VwHorariosMedicos> ObtenerHorariosMedicos()
        {
            List<VwHorariosMedicos> lista = new List<VwHorariosMedicos>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM vw_HorariosMedicos", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new VwHorariosMedicos
                    {
                        Id_Horario = Convert.ToInt32(dr["id_horario"]),
                        Medico = dr["medico"].ToString(),
                        Dia_Semana = dr["dia_semana"].ToString(),
                        Hora_Inicio = (TimeSpan)dr["hora_inicio"],
                        Hora_Fin = (TimeSpan)dr["hora_fin"]
                    });
                }
            }
            return lista;
        }

        public static List<VwHistorialCitas> ObtenerHistorialCitas()
        {
            List<VwHistorialCitas> lista = new List<VwHistorialCitas>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM vw_HistorialCitas", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new VwHistorialCitas
                    {
                        Id_Historial = Convert.ToInt32(dr["id_historial"]),
                        Accion = dr["accion"].ToString(),
                        Fecha = Convert.ToDateTime(dr["fecha"]),
                        Usuario = dr["usuario"].ToString(),
                        Estado_Cita = dr["estado_cita"].ToString()
                    });
                }
            }
            return lista;
        }
    }
}
