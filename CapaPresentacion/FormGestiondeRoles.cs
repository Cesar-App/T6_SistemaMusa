using CapaEntidades;
using CapaNegocio;
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
        RolesBL rolbL = new RolesBL();
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
            dgvRoles.DataSource = rolbL.ObtenerTodos();
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

                int resultado = rolbL.Insertar(obj);
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

            rolbL.Actualizar(obj);

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
                if (dgvRoles.CurrentRow == null || dgvRoles.CurrentRow.Cells.Count == 0)
                {
                    MessageBox.Show("Seleccione un rol antes de eliminar.");
                    return;
                }

                var cellValue = dgvRoles.CurrentRow.Cells[0].Value;
                if (cellValue == null || !int.TryParse(cellValue.ToString(), out int idSeleccionado))
                {
                    MessageBox.Show("Id de rol inválido.");
                    return;
                }

                int resultado = rolbL.Eliminar(idSeleccionado);
                if (resultado > 0)
                {
                    MessageBox.Show("Eliminado correctamente");
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("No puedes eliminar este Rol porque hay usuarios asociados a él. Primero cambia el rol de esos usuarios.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }

        



        private void btnReiniciarRol_Click(object sender, EventArgs e)

        {
            TextBoxRol.Text = "";

            idRol = 0;

        }

        private void FormGestiondeRoles_Load(object sender, EventArgs e)
        {

        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            FormCitas formCitas = new FormCitas();
            formCitas.ShowDialog();

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormHistorialCitas formHistorial = new FormHistorialCitas();
            formHistorial.ShowDialog();
            this.Close();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            FormMedicos formMedicos = new FormMedicos();
            formMedicos.ShowDialog();
            this.Close();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            FormHorarios formHorarios = new FormHorarios();
            formHorarios.ShowDialog();
            this.Close();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            FormEspecialidades formEspecialidades = new FormEspecialidades();
            formEspecialidades.ShowDialog();
            this.Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormGestiondeUsuarios formUsuarios = new FormGestiondeUsuarios();
            formUsuarios.ShowDialog();
            this.Close();
        }
    }
}


