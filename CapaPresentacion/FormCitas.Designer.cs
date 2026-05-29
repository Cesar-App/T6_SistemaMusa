namespace CapaPresentacion
{
    partial class FormCitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.Panel panelInsert;
        private System.Windows.Forms.ComboBox cboPaciente;
        private System.Windows.Forms.ComboBox cboMedico;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.TextBox txtMotivoInsert;
        private System.Windows.Forms.ComboBox cmbEstadoInsert;
        private System.Windows.Forms.Button btnGuardar;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.btnEspecialidades = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.separator = new System.Windows.Forms.Panel();
            this.btnRoles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelInsert = new System.Windows.Forms.Panel();
            this.txtCita = new System.Windows.Forms.TextBox();
            this.lbCita = new System.Windows.Forms.Label();
            this.lbObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPaciente = new System.Windows.Forms.ComboBox();
            this.cboMedico = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.txtMotivoInsert = new System.Windows.Forms.TextBox();
            this.cmbEstadoInsert = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelCard = new System.Windows.Forms.Panel();
            this.pbReiniciar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.panelSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.panelContent.SuspendLayout();
            this.panelInsert.SuspendLayout();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReiniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.White;
            this.panelSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSidebar.Controls.Add(this.btnHorarios);
            this.panelSidebar.Controls.Add(this.btnEspecialidades);
            this.panelSidebar.Controls.Add(this.label5);
            this.panelSidebar.Controls.Add(this.separator);
            this.panelSidebar.Controls.Add(this.btnRoles);
            this.panelSidebar.Controls.Add(this.panel1);
            this.panelSidebar.Controls.Add(this.btnUsuarios);
            this.panelSidebar.Controls.Add(this.btnMedicos);
            this.panelSidebar.Controls.Add(this.btnPacientes);
            this.panelSidebar.Controls.Add(this.btnHistorial);
            this.panelSidebar.Controls.Add(this.btnCitas);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 72);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(260, 836);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnHorarios
            // 
            this.btnHorarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHorarios.Location = new System.Drawing.Point(24, 244);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Size = new System.Drawing.Size(213, 38);
            this.btnHorarios.TabIndex = 13;
            this.btnHorarios.Text = "Horarios";
            this.btnHorarios.UseVisualStyleBackColor = true;
            this.btnHorarios.Click += new System.EventHandler(this.btnHorarios_Click);
            // 
            // btnEspecialidades
            // 
            this.btnEspecialidades.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEspecialidades.Location = new System.Drawing.Point(24, 302);
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.Size = new System.Drawing.Size(213, 38);
            this.btnEspecialidades.TabIndex = 12;
            this.btnEspecialidades.Text = "Especialidades";
            this.btnEspecialidades.UseVisualStyleBackColor = true;
            this.btnEspecialidades.Click += new System.EventHandler(this.btnEspecialidades_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(17, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "Administracion";
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.Color.SteelBlue;
            this.separator.Location = new System.Drawing.Point(-1, 363);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(261, 10);
            this.separator.TabIndex = 11;
            // 
            // btnRoles
            // 
            this.btnRoles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRoles.Location = new System.Drawing.Point(24, 473);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(213, 38);
            this.btnRoles.TabIndex = 10;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(-1, 552);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 110);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::CapaPresentacion.Properties.Resources.Salir;
            this.pictureBox4.Location = new System.Drawing.Point(196, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "RolUsuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(66, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "NombreUsuario";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources._5540603_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(11, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.Location = new System.Drawing.Point(24, 418);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(213, 38);
            this.btnUsuarios.TabIndex = 8;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMedicos.Location = new System.Drawing.Point(24, 186);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(213, 38);
            this.btnMedicos.TabIndex = 7;
            this.btnMedicos.Text = "Medicos";
            this.btnMedicos.UseVisualStyleBackColor = true;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPacientes.Location = new System.Drawing.Point(24, 127);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(213, 38);
            this.btnPacientes.TabIndex = 6;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHistorial.Location = new System.Drawing.Point(24, 70);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(213, 38);
            this.btnHistorial.TabIndex = 5;
            this.btnHistorial.Text = "Historial de Citas";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCitas.Location = new System.Drawing.Point(24, 15);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(213, 38);
            this.btnCitas.TabIndex = 4;
            this.btnCitas.Text = "Citas Medicas";
            this.btnCitas.UseVisualStyleBackColor = true;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.pbHome);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Controls.Add(this.txtBuscar);
            this.panelHeader.Controls.Add(this.btnNuevo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1286, 72);
            this.panelHeader.TabIndex = 1;
            // 
            // pbHome
            // 
            this.pbHome.BackColor = System.Drawing.Color.Transparent;
            this.pbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHome.Image = global::CapaPresentacion.Properties.Resources.Musa1;
            this.pbHome.Location = new System.Drawing.Point(5, 3);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(256, 62);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 4;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(619, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(393, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Citas Médicas";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.Location = new System.Drawing.Point(1724, 20);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(320, 31);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(2064, 18);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 32);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo Registro";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.panelContent.Controls.Add(this.panelInsert);
            this.panelContent.Controls.Add(this.panelCard);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1286, 908);
            this.panelContent.TabIndex = 2;
            // 
            // panelInsert
            // 
            this.panelInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInsert.BackColor = System.Drawing.Color.White;
            this.panelInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInsert.Controls.Add(this.txtCita);
            this.panelInsert.Controls.Add(this.lbCita);
            this.panelInsert.Controls.Add(this.lbObservaciones);
            this.panelInsert.Controls.Add(this.txtObservaciones);
            this.panelInsert.Controls.Add(this.btnActualizar);
            this.panelInsert.Controls.Add(this.button1);
            this.panelInsert.Controls.Add(this.label10);
            this.panelInsert.Controls.Add(this.label9);
            this.panelInsert.Controls.Add(this.label8);
            this.panelInsert.Controls.Add(this.label7);
            this.panelInsert.Controls.Add(this.label6);
            this.panelInsert.Controls.Add(this.lblDia);
            this.panelInsert.Controls.Add(this.label1);
            this.panelInsert.Controls.Add(this.cboPaciente);
            this.panelInsert.Controls.Add(this.cboMedico);
            this.panelInsert.Controls.Add(this.dtpFecha);
            this.panelInsert.Controls.Add(this.dtpHora);
            this.panelInsert.Controls.Add(this.txtMotivoInsert);
            this.panelInsert.Controls.Add(this.cmbEstadoInsert);
            this.panelInsert.Controls.Add(this.btnGuardar);
            this.panelInsert.Location = new System.Drawing.Point(344, 611);
            this.panelInsert.Name = "panelInsert";
            this.panelInsert.Size = new System.Drawing.Size(871, 285);
            this.panelInsert.TabIndex = 2;
            // 
            // txtCita
            // 
            this.txtCita.Location = new System.Drawing.Point(488, 30);
            this.txtCita.Name = "txtCita";
            this.txtCita.ReadOnly = true;
            this.txtCita.Size = new System.Drawing.Size(80, 26);
            this.txtCita.TabIndex = 20;
            // 
            // lbCita
            // 
            this.lbCita.AutoSize = true;
            this.lbCita.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbCita.Location = new System.Drawing.Point(428, 28);
            this.lbCita.Name = "lbCita";
            this.lbCita.Size = new System.Drawing.Size(54, 28);
            this.lbCita.TabIndex = 19;
            this.lbCita.Text = "Cita:";
            // 
            // lbObservaciones
            // 
            this.lbObservaciones.AutoSize = true;
            this.lbObservaciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObservaciones.Location = new System.Drawing.Point(47, 252);
            this.lbObservaciones.Name = "lbObservaciones";
            this.lbObservaciones.Size = new System.Drawing.Size(155, 28);
            this.lbObservaciones.TabIndex = 18;
            this.lbObservaciones.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(183, 256);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(505, 26);
            this.txtObservaciones.TabIndex = 17;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(751, 89);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(92, 41);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(751, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ver Reporte";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(525, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 28);
            this.label10.TabIndex = 14;
            this.label10.Text = "Estado Cita:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(306, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 28);
            this.label9.TabIndex = 13;
            this.label9.Text = "Hora Cita:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fecha Cita:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "Motivo Cita:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(413, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Medico:";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(47, 79);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(98, 28);
            this.lblDia.TabIndex = 9;
            this.lblDia.Text = "Paciente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingreso de Datos:";
            // 
            // cboPaciente
            // 
            this.cboPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaciente.Location = new System.Drawing.Point(162, 79);
            this.cboPaciente.Name = "cboPaciente";
            this.cboPaciente.Size = new System.Drawing.Size(220, 28);
            this.cboPaciente.TabIndex = 0;
            // 
            // cboMedico
            // 
            this.cboMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedico.Location = new System.Drawing.Point(522, 79);
            this.cboMedico.Name = "cboMedico";
            this.cboMedico.Size = new System.Drawing.Size(220, 28);
            this.cboMedico.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(134, 141);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(110, 26);
            this.dtpFecha.TabIndex = 2;
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(390, 141);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(80, 26);
            this.dtpHora.TabIndex = 3;
            // 
            // txtMotivoInsert
            // 
            this.txtMotivoInsert.Location = new System.Drawing.Point(148, 201);
            this.txtMotivoInsert.Name = "txtMotivoInsert";
            this.txtMotivoInsert.Size = new System.Drawing.Size(540, 26);
            this.txtMotivoInsert.TabIndex = 4;
            // 
            // cmbEstadoInsert
            // 
            this.cmbEstadoInsert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoInsert.Location = new System.Drawing.Point(622, 139);
            this.cmbEstadoInsert.Name = "cmbEstadoInsert";
            this.cmbEstadoInsert.Size = new System.Drawing.Size(120, 28);
            this.cmbEstadoInsert.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(751, 194);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 41);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panelCard
            // 
            this.panelCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.pbReiniciar);
            this.panelCard.Controls.Add(this.pictureBox1);
            this.panelCard.Controls.Add(this.cmbFiltro);
            this.panelCard.Controls.Add(this.dgvCitas);
            this.panelCard.Location = new System.Drawing.Point(289, 98);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(16);
            this.panelCard.Size = new System.Drawing.Size(962, 293);
            this.panelCard.TabIndex = 0;
            // 
            // pbReiniciar
            // 
            this.pbReiniciar.BackColor = System.Drawing.Color.Transparent;
            this.pbReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbReiniciar.Image = global::CapaPresentacion.Properties.Resources.Reiniciar;
            this.pbReiniciar.Location = new System.Drawing.Point(281, 19);
            this.pbReiniciar.Name = "pbReiniciar";
            this.pbReiniciar.Size = new System.Drawing.Size(32, 28);
            this.pbReiniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReiniciar.TabIndex = 4;
            this.pbReiniciar.TabStop = false;
            this.pbReiniciar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Embudo;
            this.pictureBox1.Location = new System.Drawing.Point(19, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.Location = new System.Drawing.Point(54, 19);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(179, 28);
            this.cmbFiltro.TabIndex = 0;
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToAddRows = false;
            this.dgvCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCitas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCitas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCitas.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCitas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCitas.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvCitas.Location = new System.Drawing.Point(68, 60);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.RowHeadersVisible = false;
            this.dgvCitas.RowHeadersWidth = 62;
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.Size = new System.Drawing.Size(822, 212);
            this.dgvCitas.TabIndex = 1;
            this.dgvCitas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvCitas_MouseDown);
            // 
            // FormCitas
            // 
            this.ClientSize = new System.Drawing.Size(1286, 908);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelContent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCitas";
            this.ShowIcon = false;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCitas_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelInsert.ResumeLayout(false);
            this.panelInsert.PerformLayout();
            this.panelCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbReiniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbReiniciar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lbObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtCita;
        private System.Windows.Forms.Label lbCita;
    }
}
