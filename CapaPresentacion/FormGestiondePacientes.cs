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
    public partial class FormGestiondePacientes : Form
    {

        void CargarSexo()
        {

            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    SqlDataAdapter da = new SqlDataAdapter("sp_ObtenerSexos", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBoxSexo.DataSource = dt;
                    comboBoxSexo.DisplayMember = "sexo";
                    comboBoxSexo.ValueMember = "sexo";

                }
            }

        }


        public FormGestiondePacientes()
        {
            InitializeComponent();
        }

        private void MostrarPacientes()
        {
            dgvPacientes.DataSource =
            PacientesDAL.ObtenerTodos();

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
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_ObtenerPacientes", con);

                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPacientes.DataSource = dt;


            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarPaciente", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", textBoxPaciente.Text);
                cmd.Parameters.AddWithValue("@apellido", textBoxApellido.Text);
                cmd.Parameters.AddWithValue("@cedula", textBoxCedula.Text);
                cmd.Parameters.AddWithValue("@telefono", textBoxTelefono.Text);
                cmd.Parameters.AddWithValue("@direccion", textBoxDireccion.Text);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", dtpFecha_Nacimiento.Value);
                cmd.Parameters.AddWithValue("@sexo", comboBoxSexo.Text);

                SqlCommand validar = new SqlCommand("sp_ValidarCedula", con);

                validar.CommandType = CommandType.StoredProcedure;

                validar.Parameters.AddWithValue("@cedula", textBoxCedula.Text);

                con.Open();

                int existe = Convert.ToInt32(validar.ExecuteScalar());

                con.Close();

                if (existe > 0)
                {
                    MessageBox.Show("Guardado correctamente");
                    return;
                }

                cmd.ExecuteNonQuery();

            }


            MessageBox.Show("Paciente guardado correctamente");

            CargarPacientes();

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
                    using (SqlConnection con = Conexion.ObtenerConexion())
                    {
                        SqlCommand cmd = new SqlCommand("sp_EliminarPaciente", con);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_paciente",
                        dgvPacientes.CurrentRow.Cells["id_paciente"].Value);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }

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

            PacientesDAL.Actualizar(obj);

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
    }
    

    internal class con

    {
    }
}


