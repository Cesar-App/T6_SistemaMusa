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

namespace CapaPresentacion
{
    public partial class FormGestiondeUsuarios : Form
    {
        UsuariosBL usuariosBL = new UsuariosBL();
        public FormGestiondeUsuarios()
        {
            InitializeComponent();
        }

        void CargarRoles()
        {
            
        }
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void MostrarUsuarios()
        {
            dgvUsuarios.DataSource = usuariosBL.ObtenerTodos();
            dgvUsuarios.Columns["estado"].Visible = false;
            dgvUsuarios.Columns["id_rol"].Visible = false;
            dgvUsuarios.Columns["id_usuario"].Visible = false;
        }
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        


           
        {
            
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                  
                    textBoxNombreUsuario.Text = fila.Cells[0].Value?.ToString();
                    textBoxContraseña.Text = fila.Cells[1].Value?.ToString();
                    textBoxNombreCompleto.Text = fila.Cells[2].Value?.ToString();
                }
            }
            catch
            {
               
            }
        }
            
        

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
            MostrarUsuarios();
        } 
        

        private void btnReiniciarRol_Click(object sender, EventArgs e)
        
            
        {
            LimpiarCampos();
        }

        
        private void LimpiarCampos()
        {
            textBoxNombreUsuario.Clear();
            textBoxContraseña.Clear();
            textBoxNombreCompleto.Clear();
            textBoxNombreUsuario.Focus(); 
        }
        

        private void btnGuardar_Click(object sender, EventArgs e)

            
        {
            try
            {
                
                DataTable dt = (DataTable)dgvUsuarios.DataSource;
                DataRow nuevaFila = dt.NewRow();

                nuevaFila["username"] = textBoxNombreUsuario.Text;
                nuevaFila["password"] = textBoxContraseña.Text;
                nuevaFila["nombre"] = textBoxNombreCompleto.Text;

                dt.Rows.Add(nuevaFila);
                LimpiarCampos();
            }
            catch (Exception)
            {
                
                try { dgvUsuarios.Rows.Add(textBoxNombreUsuario.Text, textBoxContraseña.Text, textBoxNombreCompleto.Text); }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }  
        
        
        

        private void button1_Click(object sender, EventArgs e)
         
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                dgvUsuarios.Rows.Remove(dgvUsuarios.CurrentRow);
                LimpiarCampos();
            }
        }
        
        

        private void button2_Click(object sender, EventArgs e)
        
            
        
            
        {
            try
            {
                if (dgvUsuarios.CurrentRow != null)
                {
                   
                    dgvUsuarios.CurrentRow.Cells[0].Value = textBoxNombreUsuario.Text;
                    dgvUsuarios.CurrentRow.Cells[1].Value = textBoxContraseña.Text;
                    dgvUsuarios.CurrentRow.Cells[2].Value = textBoxNombreCompleto.Text;

                    MessageBox.Show("Registro actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila primero.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo editar: " + ex.Message);
            }
        }
        

        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
    
}
