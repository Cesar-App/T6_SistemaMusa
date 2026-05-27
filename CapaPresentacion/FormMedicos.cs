using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormMedicos : Form
    {
        private MedicosBL medicosBL = new MedicosBL();
        private EspecialidadesBL especialidadesBL = new EspecialidadesBL();
        private int? selectedMedicoId = null;
        private List<Medicos> todosLosMedicos = new List<Medicos>();

        public FormMedicos()
        {
            InitializeComponent();
            this.Load += FormMedicos_Load;
            this.cmbfiltro.SelectedIndexChanged += cmbFiltro_SelectedIndexChanged;
            this.dgvMedicos.SelectionChanged += dgvMedicos_SelectionChanged;
            this.dgvMedicos.MouseDown += dgvMedicos_MouseDown;
            this.btnActualizar.Click += btnActualizar_Click;
        }

        // ===================== CARGA =====================

        private void FormMedicos_Load(object sender, EventArgs e)
        {
            // Cargar usuario de sesión en el sidebar
            if (Session.CurrentUser != null)
            {
                var lblNombre = this.Controls.Find("lbNombreUsuario", true).FirstOrDefault() as Label;
                var lblRol = this.Controls.Find("lbRolUsuario", true).FirstOrDefault() as Label;
                if (lblNombre != null) lblNombre.Text = Session.CurrentUser.Nombre;
                if (lblRol != null) lblRol.Text = Session.CurrentUser.Nombre_Rol;
            }

            PermisosHelper.AplicarPermisos(this);

            CargarCombos();
            CargarDatos();
        }

        private void CargarCombos()
        {
            // Especialidades en el combo
            var especialidades = especialidadesBL.ObtenerTodos();
            cbEspecialidad.DataSource = especialidades;
            cbEspecialidad.DisplayMember = "Nombre_Especialidad";
            cbEspecialidad.ValueMember = "Id_Especialidad";

            // Filtro por especialidad
            cmbfiltro.Items.Clear();
            cmbfiltro.Items.Add("Todos");
            foreach (var esp in especialidades)
                cmbfiltro.Items.Add(esp.Nombre_Especialidad);
            cmbfiltro.SelectedIndex = 0;
        }

        private void CargarDatos()
        {
            todosLosMedicos = medicosBL.ObtenerTodos() ?? new List<Medicos>();
            dgvMedicos.DataSource = null;
            dgvMedicos.DataSource = todosLosMedicos;

            // Ocultar columnas
            if (dgvMedicos.Columns["Id_Medico"] != null) dgvMedicos.Columns["Id_Medico"].Visible = false;
            if (dgvMedicos.Columns["Id_Especialidad"] != null) dgvMedicos.Columns["Id_Especialidad"].Visible = false;
            if (dgvMedicos.Columns["Estado"] != null) dgvMedicos.Columns["Estado"].Visible = false;

            // Renombrar encabezados
            if (dgvMedicos.Columns["Nombre"] != null) dgvMedicos.Columns["Nombre"].HeaderText = "Nombre";
            if (dgvMedicos.Columns["Apellido"] != null) dgvMedicos.Columns["Apellido"].HeaderText = "Apellido";
            if (dgvMedicos.Columns["Telefono"] != null) dgvMedicos.Columns["Telefono"].HeaderText = "Teléfono";
            if (dgvMedicos.Columns["Correo"] != null) dgvMedicos.Columns["Correo"].HeaderText = "Correo";
            if (dgvMedicos.Columns["Nombre_Especialidad"] != null) dgvMedicos.Columns["Nombre_Especialidad"].HeaderText = "Especialidad";
        }

        // ===================== FILTROS =====================

        private void AplicarFiltros()
        {
            var especialidad = cmbfiltro.SelectedIndex > 0 ? cmbfiltro.SelectedItem.ToString() : string.Empty;

            var filtrado = todosLosMedicos
                .Where(m =>
                    string.IsNullOrWhiteSpace(especialidad) ||
                    (m.Nombre_Especialidad ?? "").Equals(especialidad, StringComparison.OrdinalIgnoreCase)
                )
                .ToList();

            dgvMedicos.DataSource = null;
            dgvMedicos.DataSource = filtrado;
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e) => AplicarFiltros();

        // ===================== SELECCIÓN EN GRILLA =====================

        private void dgvMedicos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMedicos.SelectedRows.Count == 1)
            {
                var medico = dgvMedicos.SelectedRows[0].DataBoundItem as Medicos;
                if (medico != null)
                {
                    selectedMedicoId = medico.Id_Medico;

                    // Cargar datos en los campos
                    txtNombre.Text = medico.Nombre;
                    txtApellido.Text = medico.Apellido;
                    txtTelefono.Text = medico.Telefono;
                    txtCorreo.Text = medico.Correo;
                    cbEspecialidad.SelectedValue = medico.Id_Especialidad;

                    // Cambiar botón a modo eliminar
                    btnguardar.Text = "Eliminar";
                    btnguardar.BackColor = Color.FromArgb(220, 53, 69);
                    btnguardar.ForeColor = Color.White;
                    return;
                }
            }

            // Sin selección, volver a modo guardar
            selectedMedicoId = null;
            btnguardar.Text = "Guardar";
            btnguardar.BackColor = Color.FromArgb(3, 88, 118);
            btnguardar.ForeColor = Color.White;
        }

        private void dgvMedicos_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = dgvMedicos.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                dgvMedicos.ClearSelection();
                dgvMedicos.CurrentCell = null;
            }
        }

        // ===================== GUARDAR / ELIMINAR =====================

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Modo eliminar
            if (btnguardar.Text == "Eliminar" && selectedMedicoId.HasValue)
            {
                var confirm = MessageBox.Show("¿Está seguro de eliminar este médico? Esta acción no se puede deshacer.",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        medicosBL.Eliminar(selectedMedicoId.Value);
                        MessageBox.Show("Médico eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                        LimpiarControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Resetear botón
                selectedMedicoId = null;
                btnguardar.Text = "Guardar";
                btnguardar.BackColor = Color.FromArgb(3, 88, 118);
                btnguardar.ForeColor = Color.White;
                return;
            }

            // Modo guardar
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text)) throw new Exception("Ingrese el nombre del médico.");
                if (string.IsNullOrWhiteSpace(txtApellido.Text)) throw new Exception("Ingrese el apellido del médico.");
                if (cbEspecialidad.SelectedItem == null || cbEspecialidad.SelectedIndex < 0)
                    throw new Exception("Seleccione una especialidad.");

                var medico = new Medicos
                {
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Id_Especialidad = Convert.ToInt32(cbEspecialidad.SelectedValue),
                    Estado = true
                };

                medicosBL.Insertar(medico);
                MessageBox.Show("Médico guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ===================== ACTUALIZAR =====================

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!selectedMedicoId.HasValue) throw new Exception("Seleccione un médico de la tabla para actualizar.");
                if (string.IsNullOrWhiteSpace(txtNombre.Text)) throw new Exception("Ingrese el nombre del médico.");
                if (string.IsNullOrWhiteSpace(txtApellido.Text)) throw new Exception("Ingrese el apellido del médico.");
                if (cbEspecialidad.SelectedItem == null || cbEspecialidad.SelectedIndex < 0)
                    throw new Exception("Seleccione una especialidad.");

                var medico = new Medicos
                {
                    Id_Medico = selectedMedicoId.Value,
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Id_Especialidad = Convert.ToInt32(cbEspecialidad.SelectedValue)
                };

                medicosBL.Actualizar(medico);
                MessageBox.Show("Médico actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ===================== LIMPIAR =====================

        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            cbEspecialidad.SelectedIndex = 0;
            selectedMedicoId = null;
            dgvMedicos.ClearSelection();
            dgvMedicos.CurrentCell = null;

            // Restaurar botón a modo guardar
            btnguardar.Text = "Guardar";
            btnguardar.BackColor = Color.FromArgb(3, 88, 118);
            btnguardar.ForeColor = Color.White;
        }

        private void pbReiniciar_Click(object sender, EventArgs e) => LimpiarControles();

        // ===================== NAVEGACIÓN =====================

        private void btnCitas_Click(object sender, EventArgs e)
        {
            FormCitas formCitas = new FormCitas();
            formCitas.Show();
            this.Close();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            FormHorarios formHorarios = new FormHorarios();
            formHorarios.Show();
            this.Close();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
            formInicio.Show();
            this.Close();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            // Ya estás en Médicos, no hacer nada
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmLogin formLogin = new FrmLogin();
            formLogin.Show();
            this.Close();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormHistorialCitas formHistorial = new FormHistorialCitas();
            formHistorial.Show();
            this.Close();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            FormEspecialidades formEspecialidades = new FormEspecialidades();
            formEspecialidades.Show();
            this.Close();
        }

        private void btnHorarios_Click_1(object sender, EventArgs e)
        {
            FormHorarios formHorarios = new FormHorarios();
            formHorarios.Show();
            this.Close();
        }
    }
}