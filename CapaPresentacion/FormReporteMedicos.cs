using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class FormReporteMedicos : Form
    {
        public FormReporteMedicos()
        {
            InitializeComponent();
        }

        private void FormReporteMedicos_Load(object sender, EventArgs e)
        {

            try
            {
                // Obtener datos
                var citas = new CitasBL().ObtenerTodos() ?? new List<Citas>();
                var pacientes = new PacientesBL().ObtenerTodos() ?? new List<Pacientes>();
                var medicos = new MedicosBL().ObtenerTodos() ?? new List<Medicos>();
                var especialidades = new EspecialidadesBL().ObtenerTodos() ?? new List<Especialidades>();
                var historialc = new Historial_CitasBL().ObtenerTodos() ?? new List<Historial_Citas>();

                // Proyectar a objetos con nombres que coincidan con los campos del .rdlc
                var listac = citas.Select(c => new
                {
                    id_cita = c.Id_Cita,
                    fecha_cita = c.Fecha_Cita.ToString("dd/MM/yyyy"),
                    hora_cita = c.Hora_Cita.ToString(),
                    motivo = c.Motivo,
                    estado_cita = c.Estado_Cita,
                    observacion = c.Observacion,
                    id_paciente = c.Id_Paciente,
                    id_medico = c.Id_Medico,
                    estado = c.Estado
                }).ToList();

                // Proyectar a objetos con nombres que coincidan con los campos del .rdlc
                var listap = pacientes.Select(p => new
                {
                    id_paciente = p.Id_Paciente,
                    nombre = p.Nombre,
                    apellido = p.Apellido,
                    fecha_nacimiento = p.Fecha_Nacimiento,
                    sexo = p.Sexo,
                    direccion = p.Direccion,
                    telefono = p.Telefono,
                    cedula = p.Cedula
                }).ToList();

                var listam = medicos.Select(m => new
                {
                    id_medico = m.Id_Medico,
                    nombre = m.Nombre,
                    apellido = m.Apellido,
                    especialidad = m.Nombre_Especialidad,
                    telefono = m.Telefono,
                    email = m.Correo.ToString()
                }).ToList();

                var listae = especialidades.Select(s => new
                {
                    id_especialidad = s.Id_Especialidad,
                    nombre = s.Nombre_Especialidad
                }).ToList();

                var listah = historialc.Select(h => new
                {
                    id_historial = h.Id_Historial,
                    accion = h.Accion,
                    fecha = h.Fecha.ToString("dd/MM/yyyy"),
                    usuario = h.Usuario,
                    id_cita = h.Id_Cita,
                    estado = h.Estado,
                    nombre_paciente_cita = h.Nombre_Paciente_Cita
                }).ToList();

                // Asignar origen de datos al ReportViewer
                this.rvMedicos.LocalReport.DataSources.Clear();
                var rds = new ReportDataSource("dsCitas", listac);
                var rdsM = new ReportDataSource("dsMedicos", listam);
                var rdsP = new ReportDataSource("dsPacientes", listap);
                var rdsE = new ReportDataSource("dsEspecialidades", listae);
                var rdsH = new ReportDataSource("dsHistorialCitas", listah);
                this.rvMedicos.LocalReport.DataSources.Add(rds);
                this.rvMedicos.LocalReport.DataSources.Add(rdsM);
                this.rvMedicos.LocalReport.DataSources.Add(rdsP);
                this.rvMedicos.LocalReport.DataSources.Add(rdsE);
                this.rvMedicos.LocalReport.DataSources.Add(rdsH);
                this.rvMedicos.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
