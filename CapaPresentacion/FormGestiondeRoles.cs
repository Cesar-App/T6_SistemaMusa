using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class FormGestiondeRoles : Form

    {
        int idRol = 0;

        private void Limpiar()
        {
            btnEditarRol.Text = "";

            idRol = 0;
        }
        public FormGestiondeRoles()
        {
            InitializeComponent();
        }


        private void MostrarRoles()
        {
            dgvRoles.DataSource = RolesDAL.ObtenerTodos();
            dgvRoles.Columns["Id_Rol"].Visible = false;
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
            MostrarRoles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        
          
        {
            try
            {
                Roles obj = new Roles();
                obj.Nombre = TextBoxRol.Text; // Asegúrate de que no estés escribiendo un nombre repetido

                int resultado = RolesDAL.Insertar(obj);
                if (resultado > 0)
                {
                    MessageBox.Show("Rol guardado con éxito");
                    // Aquí recargas tu DataGrid
                }
            }
            catch (SqlException ex)
            {
                // El número 2627 es el código de error para llaves duplicadas en SQL
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("Ese nombre de Rol ya existe. Escribe uno diferente.");
                }
                else
                {
                    MessageBox.Show("Error de base de datos: " + ex.Message);
                }
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Roles obj = new Roles();

            obj.Id_Rol = idRol;

            obj.Nombre = TextBoxRol.Text;

            RolesDAL.Actualizar(obj);

            MessageBox.Show("Rol editado");

            MostrarRoles();


        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idRol = Convert.ToInt32(
            dgvRoles.CurrentRow.Cells[0].Value);

            TextBoxRol.Text =
            dgvRoles.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        
            
        {
            try
            {
                int idSeleccionado = int.Parse(dgvRoles.CurrentRow.Cells[0].Value.ToString());

                int resultado = RolesDAL.Eliminar(idSeleccionado);
                if (resultado > 0)
                {
                    MessageBox.Show("Eliminado correctamente");
                }
            }
            catch (SqlException ex)
            {
                // El número 547 es el código de error de "Llave Foránea" (está siendo usado)
                if (ex.Number == 547)
                {
                    MessageBox.Show("No puedes eliminar este Rol porque hay usuarios asociados a él. " +
                                    "Primero cambia el rol de esos usuarios.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        



        private void btnReiniciarRol_Click(object sender, EventArgs e)

        {
            TextBoxRol.Text = "";

            idRol = 0;

        }


    }


}


