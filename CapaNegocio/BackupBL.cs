using CapaDatos;

namespace CapaNegocio
{
    public class BackupBL
    {
        public void HacerBackup(string filePath, string tipoSQL)
        {
            BackupDAL.HacerBackup(filePath, tipoSQL);
        }

        public void RestaurarBackup(string filePath)
        {
            BackupDAL.RestaurarBackup(filePath);
        }
    }
}