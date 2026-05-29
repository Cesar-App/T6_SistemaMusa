using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormCitas : Form
    {
        private PacientesBL pacientesBL = new PacientesBL();
        private MedicosBL medicosBL = new MedicosBL();
        private CitasBL citasBL = new CitasBL();
        private int? selectedCitaId = null;
        private List<Citas> todasLasCitas = new List<Citas>();

        public FormCitas()
        {
            InitializeComponent();
            this.Load += FormCitas_Load;
            this.txtBuscar.TextChanged += txtBuscar_TextChanged;
            this.cmbFiltro.SelectedIndexChanged += cmbFiltro_SelectedIndexChanged;
            this.dgvCitas.CellContentClick += dgvCitas_CellContentClick;
            this.dgvCitas.SelectionChanged += dgvCitas_SelectionChanged;
            this.dgvCitas.MouseDown += dgvCitas_MouseDown;
            this.btnGuardar.Click += BtnGuardar_Click;
            this.btnActualizar.Click += btnActualizar_Click;
        }

        // ===================== CARGA =====================

        private void FormCitas_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUser != null)
            {
                var lblNombre = this.Controls.Find("label3", true).FirstOrDefault() as Label;
                var lblRol = this.Controls.Find("label4", true).FirstOrDefault() as Label;
                if (lblNombre != null) lblNombre.Text = Session.CurrentUser.Nombre;
                if (lblRol != null) lblRol.Text = Session.CurrentUser.Nombre_Rol;
            }

            PermisosHelper.AplicarPermisos(this);
            CargarCombos();
            CargarDatos();
        }

        private void CargarCombos()
        {
            // Pacientes
            var pacientes = pacientesBL.ObtenerTodos();
            cboPaciente.DataSource = pacientes;
            cboPaciente.DisplayMember = "Nombre";
            cboPaciente.ValueMember = "Id_Paciente";

            // Médicos
            var medicos = medicosBL.ObtenerTodos();
            cboMedico.DataSource = medicos;
            cboMedico.DisplayMember = "Nombre";
            cboMedico.ValueMember = "Id_Medico";

            // Estado insertar
            cmbEstadoInsert.Items.Clear();
            cmbEstadoInsert.Items.AddRange(new object[] { "Seleccione...", "Pendiente", "Confirmada", "Atendida", "Cancelada" });
            cmbEstadoInsert.SelectedIndex = 0;

            // Filtro por estado
            cmbFiltro.Items.Clear();
            cmbFiltro.Items.AddRange(new object[] { "Todos", "Pendiente", "Confirmada", "Atendida", "Cancelada" });
            cmbFiltro.SelectedIndex = 0;
        }

        private void CargarDatos()
        {
            todasLasCitas = citasBL.ObtenerTodos() ?? new List<Citas>();
            dgvCitas.DataSource = null;
            dgvCitas.DataSource = todasLasCitas;

            // Ocultar columnas
            if (dgvCitas.Columns["Id_Paciente"] != null) dgvCitas.Columns["Id_Paciente"].Visible = false;
            if (dgvCitas.Columns["Id_Medico"] != null) dgvCitas.Columns["Id_Medico"].Visible = false;
            if (dgvCitas.Columns["Id_Cita"] != null) dgvCitas.Columns["Id_Cita"].Visible = false;
            if (dgvCitas.Columns["Estado"] != null) dgvCitas.Columns["Estado"].Visible = false;

            // Renombrar encabezados
            if (dgvCitas.Columns["Nombre_Paciente"] != null) dgvCitas.Columns["Nombre_Paciente"].HeaderText = "Paciente";
            if (dgvCitas.Columns["Nombre_Medico"] != null) dgvCitas.Columns["Nombre_Medico"].HeaderText = "Médico";
            if (dgvCitas.Columns["Fecha_Cita"] != null) dgvCitas.Columns["Fecha_Cita"].HeaderText = "Fecha";
            if (dgvCitas.Columns["Hora_Cita"] != null) dgvCitas.Columns["Hora_Cita"].HeaderText = "Hora";
            if (dgvCitas.Columns["Estado_Cita"] != null) dgvCitas.Columns["Estado_Cita"].HeaderText = "Estado";
            if (dgvCitas.Columns["Motivo"] != null) dgvCitas.Columns["Motivo"].HeaderText = "Motivo";
            if (dgvCitas.Columns["Observacion"] != null) dgvCitas.Columns["Observacion"].HeaderText = "Observación";
        }

        // ===================== FILTROS =====================

        private void AplicarFiltros()
        {
            var texto = txtBuscar.Text?.Trim() ?? string.Empty;
            var estado = cmbFiltro.SelectedIndex > 0 ? cmbFiltro.SelectedItem.ToString() : string.Empty;

            var filtrado = todasLasCitas
                .Where(c =>
                    (string.IsNullOrWhiteSpace(texto) ||
                        (c.Nombre_Paciente ?? "").IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0)
                    &&
                    (string.IsNullOrWhiteSpace(estado) ||
                        (c.Estado_Cita ?? "").Equals(estado, StringComparison.OrdinalIgnoreCase))
                )
                .ToList();

            dgvCitas.DataSource = null;
            dgvCitas.DataSource = filtrado;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) => AplicarFiltros();
        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e) => AplicarFiltros();

        // ===================== GRILLA =====================

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
        }

        private void dgvCitas_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = dgvCitas.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                dgvCitas.ClearSelection();
                dgvCitas.CurrentCell = null;
            }
        }

        // ===================== SELECCIÓN EN GRILLA =====================

        private void dgvCitas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count == 1)
            {
                var cita = dgvCitas.SelectedRows[0].DataBoundItem as Citas;
                if (cita != null)
                {
                    selectedCitaId = cita.Id_Cita;

                    // Cargar datos en los campos
                    dtpFecha.Value = cita.Fecha_Cita;
                    dtpHora.Value = DateTime.Today.Add(cita.Hora_Cita);
                    txtMotivoInsert.Text = cita.Motivo;
                    txtObservaciones.Text = cita.Observacion;
                    cmbEstadoInsert.SelectedItem = cita.Estado_Cita;
                    cboPaciente.SelectedValue = cita.Id_Paciente;
                    cboMedico.SelectedValue = cita.Id_Medico;

                    // Cambiar botón a modo eliminar
                    btnGuardar.Text = "Eliminar";
                    btnGuardar.BackColor = Color.FromArgb(220, 53, 69);
                    btnGuardar.ForeColor = Color.White;
                    return;
                }
            }

            // Sin selección, volver a modo guardar
            selectedCitaId = null;
            btnGuardar.Text = "Guardar";
            btnGuardar.BackColor = Color.FromArgb(3, 88, 118);
            btnGuardar.ForeColor = Color.White;
        }

        // ===================== GUARDAR / ELIMINAR =====================

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Modo eliminar
            if (btnGuardar.Text == "Eliminar" && selectedCitaId.HasValue)
            {
                var confirm = MessageBox.Show("¿Está seguro de eliminar esta cita? Esta acción no se puede deshacer.",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        citasBL.Eliminar(selectedCitaId.Value);
                        MessageBox.Show("Cita eliminada correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                        LimpiarControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                selectedCitaId = null;
                btnGuardar.Text = "Guardar";
                btnGuardar.BackColor = Color.FromArgb(3, 88, 118);
                btnGuardar.ForeColor = Color.White;
                return;
            }

            // Modo guardar
            try
            {
                if (cboPaciente.SelectedItem == null) throw new Exception("Seleccione un paciente.");
                if (cboMedico.SelectedItem == null) throw new Exception("Seleccione un médico.");
                if (string.IsNullOrWhiteSpace(txtMotivoInsert.Text)) throw new Exception("Ingrese el motivo.");
                if (cmbEstadoInsert.SelectedIndex <= 0) throw new Exception("Seleccione un estado.");

                var cita = new Citas
                {
                    Fecha_Cita = dtpFecha.Value.Date,
                    Hora_Cita = dtpHora.Value.TimeOfDay,
                    Motivo = txtMotivoInsert.Text.Trim(),
                    Estado_Cita = cmbEstadoInsert.SelectedItem.ToString(),
                    Observacion = txtObservaciones.Text.Trim(),
                    Id_Paciente = Convert.ToInt32(cboPaciente.SelectedValue),
                    Id_Medico = Convert.ToInt32(cboMedico.SelectedValue),
                    Estado = true
                };

                citasBL.Insertar(cita);
                MessageBox.Show("Cita guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!selectedCitaId.HasValue) throw new Exception("Seleccione una cita de la tabla para actualizar.");
                if (cboPaciente.SelectedItem == null) throw new Exception("Seleccione un paciente.");
                if (cboMedico.SelectedItem == null) throw new Exception("Seleccione un médico.");
                if (string.IsNullOrWhiteSpace(txtMotivoInsert.Text)) throw new Exception("Ingrese el motivo.");
                if (cmbEstadoInsert.SelectedIndex <= 0) throw new Exception("Seleccione un estado.");

                var cita = new Citas
                {
                    Id_Cita = selectedCitaId.Value,
                    Fecha_Cita = dtpFecha.Value.Date,
                    Hora_Cita = dtpHora.Value.TimeOfDay,
                    Motivo = txtMotivoInsert.Text.Trim(),
                    Observacion = txtObservaciones.Text.Trim(),
                    Id_Paciente = Convert.ToInt32(cboPaciente.SelectedValue),
                    Id_Medico = Convert.ToInt32(cboMedico.SelectedValue),
                    Estado_Cita = cmbEstadoInsert.SelectedItem.ToString()
                };

                citasBL.Actualizar(cita);
                MessageBox.Show("Cita actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ===================== ELIMINAR =====================

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!selectedCitaId.HasValue)
            {
                MessageBox.Show("Seleccione una cita de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("¿Está seguro de eliminar esta cita? Esta acción no se puede deshacer.",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    citasBL.Eliminar(selectedCitaId.Value);
                    MessageBox.Show("Cita eliminada correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                    LimpiarControles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ===================== LIMPIAR =====================

        private void LimpiarControles()
        {
            cboPaciente.SelectedIndex = 0;
            cboMedico.SelectedIndex = 0;
            txtMotivoInsert.Clear();
            txtObservaciones.Clear();
            cmbEstadoInsert.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            selectedCitaId = null;
            dgvCitas.ClearSelection();
            dgvCitas.CurrentCell = null;

            // Restaurar botón
            btnGuardar.Text = "Guardar";
            btnGuardar.BackColor = Color.FromArgb(3, 88, 118);
            btnGuardar.ForeColor = Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e) => LimpiarControles();

        // ===================== NAVEGACIÓN =====================

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

        private void btnCitas_Click(object sender, EventArgs e)
        {
            // Ya estás en Citas, no hacer nada
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmLogin formLogin = new FrmLogin();
            formLogin.Show();
            this.Close();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            FormEspecialidades formEspecialidades = new FormEspecialidades();
            formEspecialidades.Show();
            this.Close();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            FormMedicos formMedicos = new FormMedicos();
            formMedicos.Show();
            this.Close();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormHistorialCitas formHistorial = new FormHistorialCitas();
            formHistorial.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReporteCitas formReporteCitas = new FormReporteCitas();
            formReporteCitas.Show();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            FormGestiondeRoles formRoles = new FormGestiondeRoles();
            formRoles.Show();
            this.Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormGestiondeUsuarios formUsuarios = new FormGestiondeUsuarios();
            formUsuarios.Show();
            this.Close();
        }
    }
}