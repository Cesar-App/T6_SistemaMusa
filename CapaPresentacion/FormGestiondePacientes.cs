using CapaEntidades;
using System;
using CapaNegocio;
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
    

    public partial class FormGestiondePacientes : Form
    {
        private void Pacientes()
        {
            PacientesBL pacienteBL = new PacientesBL();
            DataTable dtSexos = new DataTable();
        }

        private readonly PacientesBL pacienteBL;

        public FormGestiondePacientes()
        {
            InitializeComponent();
            pacienteBL = new PacientesBL();
        }

        void CargarSexo()
        {

            

        }


        private void MostrarPacientes()
        {
            dgvPacientes.DataSource = pacienteBL.ObtenerTodos();
            dgvPacientes.Columns[0].Visible = false;
        }


        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
            CargarSexo();
            comboBoxSexo.SelectedIndex = -1;
            MostrarPacientes();
            dgvPacientes.Columns["Estado"].Visible = false;
        }
        private void CargarPacientes()
        {
            
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var obj = new Pacientes();
            obj.Nombre = textBoxPaciente.Text;
            obj.Apellido = textBoxApellido.Text;
            obj.Telefono = textBoxTelefono.Text;
            obj.Cedula = textBoxCedula.Text;
            obj.Direccion = textBoxDireccion.Text;
            obj.Sexo = comboBoxSexo.Text;
            obj.Fecha_Nacimiento = dtpFecha_Nacimiento.Value;

            pacienteBL.Insertar(obj);

            MessageBox.Show("Paciente guardado correctamente");
            MostrarPacientes();
        }




        private void button3_Click(object sender, EventArgs e)


        {

            {


                DialogResult resultado = MessageBox.Show(
                    "¿Deseas eliminar este paciente?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    

                    MessageBox.Show("Paciente eliminado correctamente");

                    CargarPacientes();
                }
            }
        }



    


            

            

        

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            textBoxPaciente.Text = dgvPacientes.CurrentRow.Cells["Nombre"].Value.ToString();
            textBoxApellido.Text = dgvPacientes.CurrentRow.Cells["Apellido"].Value.ToString();
            textBoxCedula.Text = dgvPacientes.CurrentRow.Cells["Cedula"].Value.ToString();
            textBoxTelefono.Text = dgvPacientes.CurrentRow.Cells["Telefono"].Value.ToString();
            textBoxDireccion.Text = dgvPacientes.CurrentRow.Cells["Direccion"].Value.ToString();
            comboBoxSexo.Text = dgvPacientes.CurrentRow.Cells["sexo"].Value.ToString();
            dtpFecha_Nacimiento.Value =
            Convert.ToDateTime(dgvPacientes.CurrentRow.Cells["fecha_nacimiento"].Value);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pacientes obj = new Pacientes();

            

            obj.Nombre = textBoxPaciente.Text;
            obj.Apellido = textBoxApellido.Text;
            obj.Telefono = textBoxTelefono.Text;
            obj.Cedula = textBoxCedula.Text;
            obj.Direccion = textBoxDireccion.Text;
            obj.Sexo = comboBoxSexo.Text;
            obj.Fecha_Nacimiento = dtpFecha_Nacimiento.Value;

            pacienteBL.Actualizar(obj);

            MessageBox.Show("Paciente actualizado");

            MostrarPacientes();
        }

        private void comboBoxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        {
                // Limpiamos por si acaso y agregamos las opciones
            
        }
    }

        private void pbReiniciar_Click(object sender, EventArgs e)
        {
            {
                // Si tienes base de datos, aquí llamarías a tu método 'CargarDatos()'
                // Por ahora, lo usaremos para limpiar el formulario
                LimpiarCampos();
                MessageBox.Show("Actualizado.");
            }

        }   // Método auxiliar para no repetir código
        private void LimpiarCampos()
        {
            textBoxPaciente.Clear();
            textBoxApellido.Clear();
            textBoxCedula.Clear();
            textBoxTelefono.Clear();
            textBoxDireccion.Clear();
            comboBoxSexo.SelectedIndex = -1;
            dtpFecha_Nacimiento.Value = DateTime.Now;
        }

        private void FormGestiondePacientes_Load(object sender, EventArgs e)
        {
            comboBoxSexo.Items.Add("Masculino");
            comboBoxSexo.Items.Add("Femenino");
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            FormCitas formCitas = new FormCitas();
            formCitas.Show();
            this.Close();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormHistorialCitas formHistorial = new FormHistorialCitas();
            formHistorial.Show();
            this.Close();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            FormGestiondePacientes formPacientes = new FormGestiondePacientes();
            formPacientes.Show();
            this.Close();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            FormMedicos formMedicos = new FormMedicos();
            formMedicos.Show();
            this.Close();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            FormHorarios formHorarios = new FormHorarios();
            formHorarios.Show();
            this.Close();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            FormEspecialidades formEspecialidades = new FormEspecialidades();
            formEspecialidades.Show();
            this.Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormGestiondeUsuarios formUsuarios = new FormGestiondeUsuarios();
            formUsuarios.Show();
            this.Close();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            FormGestiondeRoles formRoles = new FormGestiondeRoles();
            formRoles.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmLogin formLogin = new FrmLogin();
            formLogin.Show();
            this.Close();
        }
    }
}


