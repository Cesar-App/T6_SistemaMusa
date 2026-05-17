using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class FuncionesDAL
    {
        // fn_ContarPacientesActivos()
        public static int ContarPacientesActivos()
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT dbo.fn_ContarPacientesActivos()", con);
                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // fn_NombreCompletoPaciente(@id_paciente)
        public static string NombreCompletoPaciente(int id_paciente)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT dbo.fn_NombreCompletoPaciente(@id)", con);
                cmd.Parameters.AddWithValue("@id", id_paciente);
                con.Open();
                object resultado = cmd.ExecuteScalar();
                return resultado == DBNull.Value ? string.Empty : resultado.ToString();
            }
        }

        // fn_CantidadCitasMedico(@id_medico)
        public static int CantidadCitasMedico(int id_medico)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT dbo.fn_CantidadCitasMedico(@id)", con);
                cmd.Parameters.AddWithValue("@id", id_medico);
                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // fn_EspecialidadMedico(@id_medico)
        public static string EspecialidadMedico(int id_medico)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT dbo.fn_EspecialidadMedico(@id)", con);
                cmd.Parameters.AddWithValue("@id", id_medico);
                con.Open();
                object resultado = cmd.ExecuteScalar();
                return resultado == DBNull.Value ? string.Empty : resultado.ToString();
            }
        }

        // fn_TotalUsuariosActivos()
        public static int TotalUsuariosActivos()
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT dbo.fn_TotalUsuariosActivos()", con);
                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // fn_TotalCitasPendientes()
        public static int TotalCitasPendientes()
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT dbo.fn_TotalCitasPendientes()", con);
                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
