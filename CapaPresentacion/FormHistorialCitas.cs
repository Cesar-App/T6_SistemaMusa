using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormHistorialCitas : Form
    {
        private Historial_CitasBL historialBL = new Historial_CitasBL();
        private int? selectedHistorialId = null;
        private CitasBL citasBL = new CitasBL();
        private List<Historial_Citas> todosLosHistoriales = new List<Historial_Citas>();

        public FormHistorialCitas()
        {
            InitializeComponent();
            this.Load += FormHistorialCitas_Load;
            this.cmbFiltro.SelectedIndexChanged += cmbFiltro_SelectedIndexChanged;
            this.dgvHistorialCitas.SelectionChanged += dgvHistorialCitas_SelectionChanged;
            this.dgvHistorialCitas.MouseDown += dgvHistorialCitas_MouseDown;
            this.btnGuardar.Click += BtnGuardar_Click;
            this.btnActualizar.Click += btnActualizar_Click;

            // Opciones del combo Acción
            cmbAccion.Items.Clear();
            cmbAccion.Items.AddRange(new object[]
            {
                "Seleccione...",
                "Cita registrada",
                "Cita actualizada",
                "Cita cancelada",
                "Cita confirmada",
                "Atencion completada",
                "Horario modificado",
                "Nueva observación",
                "Seguimiento paciente",
                "Consulta realizada",
                "Paciente ausente"
            });
            cmbAccion.SelectedIndex = 0;
        }

        // ===================== CARGA =====================

        private void FormHistorialCitas_Load(object sender, EventArgs e)
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

            // ✅ Cargar usuario de sesión automáticamente
            if (Session.CurrentUser != null)
            {
                txtUsuario.Text = Session.CurrentUser.Nombre;
                txtUsuario.ReadOnly = true; // No se puede editar
            }
        }

        private void CargarCombos()
        {
            // Filtro por acción
            cmbFiltro.Items.Clear();
            cmbFiltro.Items.AddRange(new object[]
            {
                "Todos",
                "Cita registrada",
                "Cita actualizada",
                "Cita cancelada",
                "Cita confirmada",
                "Atencion completada",
                "Horario modificado",
                "Nueva observación",
                "Seguimiento paciente",
                "Consulta realizada",
                "Paciente ausente"
            });
            cmbFiltro.SelectedIndex = 0;

            // Cargar citas en el combo mostrando nombre del paciente
            var citas = citasBL.ObtenerTodos();
            cmbCita.DataSource = citas;
            cmbCita.DisplayMember = "Nombre_Paciente"; // Nombre del paciente
            cmbCita.ValueMember = "Id_Cita";
        }

        private void CargarDatos()
        {
            todosLosHistoriales = historialBL.ObtenerTodos() ?? new List<Historial_Citas>();
            dgvHistorialCitas.DataSource = null;
            dgvHistorialCitas.DataSource = todosLosHistoriales;

            // Ocultar columnas
            if (dgvHistorialCitas.Columns["Id_Historial"] != null) dgvHistorialCitas.Columns["Id_Historial"].Visible = false;
            if (dgvHistorialCitas.Columns["Estado"] != null) dgvHistorialCitas.Columns["Estado"].Visible = false;

            // Renombrar encabezados
            if (dgvHistorialCitas.Columns["Accion"] != null) dgvHistorialCitas.Columns["Accion"].HeaderText = "Acción";
            if (dgvHistorialCitas.Columns["Fecha"] != null) dgvHistorialCitas.Columns["Fecha"].HeaderText = "Fecha";
            if (dgvHistorialCitas.Columns["Usuario"] != null) dgvHistorialCitas.Columns["Usuario"].HeaderText = "Usuario";
            if (dgvHistorialCitas.Columns["Nombre_Paciente_Cita"] != null) dgvHistorialCitas.Columns["Nombre_Paciente_Cita"].HeaderText = "Paciente";
        }

        // ===================== FILTROS =====================

        private void AplicarFiltros()
        {
            var accion = cmbFiltro.SelectedIndex > 0 ? cmbFiltro.SelectedItem.ToString() : string.Empty;

            var filtrado = todosLosHistoriales
                .Where(h =>
                    string.IsNullOrWhiteSpace(accion) ||
                    (h.Accion ?? "").Equals(accion, StringComparison.OrdinalIgnoreCase)
                )
                .ToList();

            dgvHistorialCitas.DataSource = null;
            dgvHistorialCitas.DataSource = filtrado;
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e) => AplicarFiltros();

        // ===================== SELECCIÓN EN GRILLA =====================

        private void dgvHistorialCitas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHistorialCitas.SelectedRows.Count == 1)
            {
                var historial = dgvHistorialCitas.SelectedRows[0].DataBoundItem as Historial_Citas;
                if (historial != null)
                {
                    selectedHistorialId = historial.Id_Historial;

                    // Cargar datos en los campos
                    cmbAccion.SelectedItem = historial.Accion;
                    dtpFecha.Value = historial.Fecha;
                    txtUsuario.Text = historial.Usuario;

                    // Cambiar botón a modo eliminar
                    btnGuardar.Text = "Eliminar";
                    btnGuardar.BackColor = Color.FromArgb(220, 53, 69);
                    btnGuardar.ForeColor = Color.White;
                    return;
                }
            }

            // Sin selección, volver a modo guardar
            selectedHistorialId = null;
            btnGuardar.Text = "Guardar";
            btnGuardar.BackColor = Color.FromArgb(3, 88, 118);
            btnGuardar.ForeColor = Color.White;
        }

        private void dgvHistorialCitas_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = dgvHistorialCitas.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                dgvHistorialCitas.ClearSelection();
                dgvHistorialCitas.CurrentCell = null;
            }
        }

        // ===================== GUARDAR / ELIMINAR =====================

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Modo eliminar
            if (btnGuardar.Text == "Eliminar" && selectedHistorialId.HasValue)
            {
                var confirm = MessageBox.Show("¿Está seguro de eliminar este historial? Esta acción no se puede deshacer.",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        historialBL.Eliminar(selectedHistorialId.Value);
                        MessageBox.Show("Historial eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                        LimpiarControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Resetear botón
                selectedHistorialId = null;
                btnGuardar.Text = "Guardar";
                btnGuardar.BackColor = Color.FromArgb(3, 88, 118);
                btnGuardar.ForeColor = Color.White;
                return;
            }

            // Modo guardar
            try
            {
                if (cmbAccion.SelectedIndex <= 0) throw new Exception("Seleccione una acción.");
                if (string.IsNullOrWhiteSpace(txtUsuario.Text)) throw new Exception("El usuario es obligatorio.");

                var historial = new Historial_Citas
                {
                    Accion = cmbAccion.SelectedItem.ToString(),
                    Fecha = dtpFecha.Value,
                    Usuario = txtUsuario.Text.Trim(),
                    Id_Cita = Convert.ToInt32(cmbCita.SelectedValue), // ✅
                    Estado = true
                };

                historialBL.Insertar(historial);
                MessageBox.Show("Historial guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!selectedHistorialId.HasValue) throw new Exception("Seleccione un historial de la tabla para actualizar.");
                if (cmbAccion.SelectedIndex <= 0) throw new Exception("Seleccione una acción.");
                if (string.IsNullOrWhiteSpace(txtUsuario.Text)) throw new Exception("El usuario es obligatorio.");
                if (cmbCita.SelectedItem == null) throw new Exception("Seleccione una cita válida.");

                var historial = new Historial_Citas
                {
                    Id_Historial = selectedHistorialId.Value,
                    Accion = cmbAccion.SelectedItem.ToString(),
                    Fecha = dtpFecha.Value,
                    Usuario = txtUsuario.Text.Trim(),
                    Id_Cita = Convert.ToInt32(cmbCita.SelectedValue) // ✅ Faltaba esto
                };

                historialBL.Actualizar(historial);
                MessageBox.Show("Historial actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            cmbAccion.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now;
            txtUsuario.Clear();
            selectedHistorialId = null;
            dgvHistorialCitas.ClearSelection();
            dgvHistorialCitas.CurrentCell = null;

            // Restaurar botón a modo guardar
            btnGuardar.Text = "Guardar";
            btnGuardar.BackColor = Color.FromArgb(3, 88, 118);
            btnGuardar.ForeColor = Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e) => LimpiarControles();

        // ===================== NAVEGACIÓN =====================

        private void btnCitas_Click(object sender, EventArgs e)
        {
            FormCitas formCitas = new FormCitas();
            formCitas.Show();
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
            FormMedicos formMedicos = new FormMedicos();
            formMedicos.Show();
            this.Close();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            FormEspecialidades formEspecialidades = new FormEspecialidades();
            formEspecialidades.Show();
            this.Close();
        }

        private void btnHistorialCitas_Click(object sender, EventArgs e)
        {
            // Ya estás en Historial de Citas, no hacer nada
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmLogin formLogin = new FrmLogin();
            formLogin.Show();
            this.Close();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            FormHorarios formHorarios = new FormHorarios();
            formHorarios.Show();
            this.Close();
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