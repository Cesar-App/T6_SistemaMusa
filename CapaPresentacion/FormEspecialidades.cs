using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormEspecialidades : Form
    {
        private EspecialidadesBL especialidadesBL = new EspecialidadesBL();
        private int? selectedEspecialidadId = null;
        private List<Especialidades> todasLasEspecialidades = new List<Especialidades>();

        public FormEspecialidades()
        {
            InitializeComponent();
            this.Load += FormEspecialidades_Load;
            this.txtBuscar.TextChanged += txtBuscar_TextChanged;
            this.btnGuardar.Click += BtnGuardar_Click;
            this.dgvEspecialidades.SelectionChanged += dgvEspecialidades_SelectionChanged;
            this.dgvEspecialidades.MouseDown += dgvEspecialidades_MouseDown;
            this.btnActualizar.Click += btnActualizar_Click;
        }

        // ===================== CARGA =====================

        private void FormEspecialidades_Load(object sender, EventArgs e)
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

            CargarDatos();
        }

        private void CargarDatos()
        {
            todasLasEspecialidades = especialidadesBL.ObtenerTodos() ?? new List<Especialidades>();
            
            dgvEspecialidades.DataSource = null;
            dgvEspecialidades.DataSource = todasLasEspecialidades;

            // Ocultar columnas
            if (dgvEspecialidades.Columns["Id_Especialidad"] != null) dgvEspecialidades.Columns["Id_Especialidad"].Visible = false;
            if (dgvEspecialidades.Columns["Estado"] != null) dgvEspecialidades.Columns["Estado"].Visible = false;

            // Renombrar encabezados
            if (dgvEspecialidades.Columns["Nombre_Especialidad"] != null) dgvEspecialidades.Columns["Nombre_Especialidad"].HeaderText = "Especialidad";
            if (dgvEspecialidades.Columns["Descripcion"] != null) dgvEspecialidades.Columns["Descripcion"].HeaderText = "Descripción";

        }

        // ===================== FILTRO =====================

        private void AplicarFiltros()
        {
            var texto = txtBuscar.Text?.Trim() ?? string.Empty;

            var filtrado = todasLasEspecialidades
                .Where(e =>
                    string.IsNullOrWhiteSpace(texto) ||
                    (e.Nombre_Especialidad ?? "").IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    (e.Descripcion ?? "").IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0
                )
                .ToList();
            
            dgvEspecialidades.DataSource = null;
            dgvEspecialidades.DataSource = filtrado;
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) => AplicarFiltros();

        // ===================== SELECCIÓN EN GRILLA =====================

        private void dgvEspecialidades_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgvEspecialidades.SelectedRows.Count == 1)
            {
                var especialidad = dgvEspecialidades.SelectedRows[0].DataBoundItem as Especialidades;
                if (especialidad != null)
                {
                    selectedEspecialidadId = especialidad.Id_Especialidad;
                    
                    // Cargar datos en los campos
                    txtNombre.Text = especialidad.Nombre_Especialidad;
                    txtDescripcion.Text = especialidad.Descripcion;
                    
                    // Cambiar botón a modo eliminar
                    btnGuardar.Text = "Eliminar";
                    btnGuardar.BackColor = Color.FromArgb(220, 53, 69);
                    btnGuardar.ForeColor = Color.White;
                    return;
                }
            }
            

            // Sin selección, volver a modo guardar
            selectedEspecialidadId = null;
            btnGuardar.Text = "Guardar";
            btnGuardar.BackColor = Color.FromArgb(3, 88, 118);
            btnGuardar.ForeColor = Color.White;
        }

        private void dgvEspecialidades_MouseDown(object sender, MouseEventArgs e)
        {
            
            var hit = dgvEspecialidades.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                dgvEspecialidades.ClearSelection();
                dgvEspecialidades.CurrentCell = null;
            }
            
        }

        // ===================== GUARDAR / ELIMINAR =====================

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Modo eliminar
            if (btnGuardar.Text == "Eliminar" && selectedEspecialidadId.HasValue)
            {
                var confirm = MessageBox.Show("¿Está seguro de eliminar esta especialidad? Esta acción no se puede deshacer.",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        especialidadesBL.Eliminar(selectedEspecialidadId.Value);
                        MessageBox.Show("Especialidad eliminada correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                        LimpiarControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Resetear botón
                selectedEspecialidadId = null;
                btnGuardar.Text = "Guardar";
                btnGuardar.BackColor = Color.FromArgb(3, 88, 118);
                btnGuardar.ForeColor = Color.White;
                return;
            }

            // Modo guardar
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtNombre.Text)) throw new Exception("Ingrese el nombre de la especialidad.");

                var especialidad = new Especialidades
                {
                    Nombre_Especialidad = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    Estado = true
                };

                especialidadesBL.Insertar(especialidad);
                MessageBox.Show("Especialidad guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                
                if (!selectedEspecialidadId.HasValue) throw new Exception("Seleccione una especialidad de la tabla para actualizar.");
                if (string.IsNullOrWhiteSpace(txtNombre.Text)) throw new Exception("Ingrese el nombre de la especialidad.");

                var especialidad = new Especialidades
                {
                    Id_Especialidad = selectedEspecialidadId.Value,
                    Nombre_Especialidad = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim()
                };
                
                
                especialidadesBL.Actualizar(especialidad);
                
                MessageBox.Show("Especialidad actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtDescripcion.Clear();
            selectedEspecialidadId = null;
            dgvEspecialidades.ClearSelection();
            dgvEspecialidades.CurrentCell = null;
            

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

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            // Ya estás en Especialidades, no hacer nada
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmLogin formLogin = new FrmLogin();
            formLogin.Show();
            this.Close();
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e) => AplicarFiltros();

        private void pbReiniciar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            FormMedicos formMedicos = new FormMedicos();
            formMedicos.Show();
            this.Close();
        }

        private void btnHorarios_Click_1(object sender, EventArgs e)
        {
            FormHorarios formHorarios = new FormHorarios();
            formHorarios.Show();
            this.Close();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormHistorialCitas formHistorial = new FormHistorialCitas();
            formHistorial.Show();
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