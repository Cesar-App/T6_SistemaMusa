using System;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class BackupDAL
    {
        private const string DATABASE_NAME = "SistemaConsultasMedicasMusa";

        public static void HacerBackup(string filePath, string tipoSQL)
        {
            string query;

            if (tipoSQL == "LOG")
                query = $"BACKUP LOG [{DATABASE_NAME}] TO DISK = '{filePath}' WITH INIT, STATS = 10";
            else if (tipoSQL == "DIFFERENTIAL")
                query = $"BACKUP DATABASE [{DATABASE_NAME}] TO DISK = '{filePath}' WITH DIFFERENTIAL, INIT, STATS = 10";
            else
                query = $"BACKUP DATABASE [{DATABASE_NAME}] TO DISK = '{filePath}' WITH INIT, STATS = 10";

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandTimeout = 300;
                cmd.ExecuteNonQuery();
            }
        }

        public static void RestaurarBackup(string filePath)
        {
            // ✅ Conexión a master en vez de la BD principal
            string connectionString = Conexion.ObtenerConexion().ConnectionString
                .Replace("SistemaConsultasMedicasMusa", "master");

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Paso 1: Poner en modo single user para cerrar todas las conexiones
                SqlCommand cmdSingle = new SqlCommand(
                    $"ALTER DATABASE [{DATABASE_NAME}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", con);
                cmdSingle.CommandTimeout = 60;
                cmdSingle.ExecuteNonQuery();

                // Paso 2: Restaurar
                SqlCommand cmdRestore = new SqlCommand(
                    $"RESTORE DATABASE [{DATABASE_NAME}] FROM DISK = '{filePath}' WITH REPLACE", con);
                cmdRestore.CommandTimeout = 300;
                cmdRestore.ExecuteNonQuery();

                // Paso 3: Volver a modo multi user
                SqlCommand cmdMulti = new SqlCommand(
                    $"ALTER DATABASE [{DATABASE_NAME}] SET MULTI_USER", con);
                cmdMulti.CommandTimeout = 60;
                cmdMulti.ExecuteNonQuery();
            }
        }
    }
}