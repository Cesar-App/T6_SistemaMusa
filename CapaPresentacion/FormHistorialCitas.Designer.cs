namespace CapaPresentacion
{
    partial class FormHistorialCitas
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
        private System.Windows.Forms.Panel panelInsert;
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.btnEspecialidades = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.separator = new System.Windows.Forms.Panel();
            this.btnRoles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbRolUsuario = new System.Windows.Forms.Label();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelInsert = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCita = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAccion = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lbIngresoDatos = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelCard = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbReiniciar = new System.Windows.Forms.PictureBox();
            this.dgvHistorialCitas = new System.Windows.Forms.DataGridView();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.panelSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelContent.SuspendLayout();
            this.panelInsert.SuspendLayout();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReiniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCitas)).BeginInit();
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
            this.btnHorarios.Location = new System.Drawing.Point(22, 236);
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
            this.btnEspecialidades.Location = new System.Drawing.Point(22, 296);
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
            this.label5.Location = new System.Drawing.Point(15, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "Administracion";
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.Color.SteelBlue;
            this.separator.Location = new System.Drawing.Point(-3, 352);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(261, 10);
            this.separator.TabIndex = 11;
            // 
            // btnRoles
            // 
            this.btnRoles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRoles.Location = new System.Drawing.Point(22, 463);
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
            this.panel1.Controls.Add(this.lbRolUsuario);
            this.panel1.Controls.Add(this.lbNombreUsuario);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(-1, 541);
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
            // lbRolUsuario
            // 
            this.lbRolUsuario.AutoSize = true;
            this.lbRolUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRolUsuario.Location = new System.Drawing.Point(66, 34);
            this.lbRolUsuario.Name = "lbRolUsuario";
            this.lbRolUsuario.Size = new System.Drawing.Size(107, 28);
            this.lbRolUsuario.TabIndex = 9;
            this.lbRolUsuario.Text = "RolUsuario";
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbNombreUsuario.Location = new System.Drawing.Point(66, 6);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(161, 28);
            this.lbNombreUsuario.TabIndex = 8;
            this.lbNombreUsuario.Text = "NombreUsuario";
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
            this.btnUsuarios.Location = new System.Drawing.Point(22, 407);
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
            this.btnMedicos.Location = new System.Drawing.Point(22, 180);
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
            this.btnPacientes.Location = new System.Drawing.Point(22, 126);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(213, 38);
            this.btnPacientes.TabIndex = 6;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHistorial.Location = new System.Drawing.Point(22, 69);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(213, 38);
            this.btnHistorial.TabIndex = 5;
            this.btnHistorial.Text = "Historial de Citas";
            this.btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnCitas
            // 
            this.btnCitas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.Location = new System.Drawing.Point(22, 15);
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
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Controls.Add(this.txtBuscar);
            this.panelHeader.Controls.Add(this.btnNuevo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1465, 72);
            this.panelHeader.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.Musa1;
            this.pictureBox2.Location = new System.Drawing.Point(5, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(597, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(533, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión Historial Médicos de Citas";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.Location = new System.Drawing.Point(1903, 20);
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
            this.btnNuevo.Location = new System.Drawing.Point(2243, 18);
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
            this.panelContent.Size = new System.Drawing.Size(1465, 908);
            this.panelContent.TabIndex = 2;
            // 
            // panelInsert
            // 
            this.panelInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInsert.BackColor = System.Drawing.Color.White;
            this.panelInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInsert.Controls.Add(this.label4);
            this.panelInsert.Controls.Add(this.cmbCita);
            this.panelInsert.Controls.Add(this.dtpFecha);
            this.panelInsert.Controls.Add(this.txtUsuario);
            this.panelInsert.Controls.Add(this.label3);
            this.panelInsert.Controls.Add(this.label2);
            this.panelInsert.Controls.Add(this.label1);
            this.panelInsert.Controls.Add(this.cmbAccion);
            this.panelInsert.Controls.Add(this.btnActualizar);
            this.panelInsert.Controls.Add(this.lbIngresoDatos);
            this.panelInsert.Controls.Add(this.btnGuardar);
            this.panelInsert.Location = new System.Drawing.Point(396, 649);
            this.panelInsert.Name = "panelInsert";
            this.panelInsert.Size = new System.Drawing.Size(931, 247);
            this.panelInsert.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(409, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 30);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cita:";
            // 
            // cmbCita
            // 
            this.cmbCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCita.FormattingEnabled = true;
            this.cmbCita.Location = new System.Drawing.Point(484, 127);
            this.cmbCita.Name = "cmbCita";
            this.cmbCita.Size = new System.Drawing.Size(187, 28);
            this.cmbCita.TabIndex = 28;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(587, 74);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(110, 26);
            this.dtpFecha.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(149, 131);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(187, 26);
            this.txtUsuario.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 30);
            this.label3.TabIndex = 26;
            this.label3.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 30);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fecha Historial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Accion Cita:";
            // 
            // cmbAccion
            // 
            this.cmbAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccion.FormattingEnabled = true;
            this.cmbAccion.Location = new System.Drawing.Point(149, 72);
            this.cmbAccion.Name = "cmbAccion";
            this.cmbAccion.Size = new System.Drawing.Size(187, 28);
            this.cmbAccion.TabIndex = 20;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(374, 180);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 37);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // lbIngresoDatos
            // 
            this.lbIngresoDatos.AutoSize = true;
            this.lbIngresoDatos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngresoDatos.Location = new System.Drawing.Point(3, 14);
            this.lbIngresoDatos.Name = "lbIngresoDatos";
            this.lbIngresoDatos.Size = new System.Drawing.Size(247, 38);
            this.lbIngresoDatos.TabIndex = 7;
            this.lbIngresoDatos.Text = "Ingreso de Datos:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(232, 180);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 37);
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
            this.panelCard.Controls.Add(this.pictureBox1);
            this.panelCard.Controls.Add(this.pbReiniciar);
            this.panelCard.Controls.Add(this.dgvHistorialCitas);
            this.panelCard.Controls.Add(this.cmbFiltro);
            this.panelCard.Location = new System.Drawing.Point(294, 96);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(16);
            this.panelCard.Size = new System.Drawing.Size(1142, 321);
            this.panelCard.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Embudo;
            this.pictureBox1.Location = new System.Drawing.Point(17, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pbReiniciar
            // 
            this.pbReiniciar.BackColor = System.Drawing.Color.Transparent;
            this.pbReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbReiniciar.Image = global::CapaPresentacion.Properties.Resources.Reiniciar;
            this.pbReiniciar.Location = new System.Drawing.Point(231, 19);
            this.pbReiniciar.Name = "pbReiniciar";
            this.pbReiniciar.Size = new System.Drawing.Size(32, 28);
            this.pbReiniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReiniciar.TabIndex = 16;
            this.pbReiniciar.TabStop = false;
            // 
            // dgvHistorialCitas
            // 
            this.dgvHistorialCitas.AllowUserToAddRows = false;
            this.dgvHistorialCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorialCitas.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorialCitas.ColumnHeadersHeight = 34;
            this.dgvHistorialCitas.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvHistorialCitas.Location = new System.Drawing.Point(19, 76);
            this.dgvHistorialCitas.Name = "dgvHistorialCitas";
            this.dgvHistorialCitas.ReadOnly = true;
            this.dgvHistorialCitas.RowHeadersVisible = false;
            this.dgvHistorialCitas.RowHeadersWidth = 62;
            this.dgvHistorialCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialCitas.Size = new System.Drawing.Size(1089, 224);
            this.dgvHistorialCitas.TabIndex = 1;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(67, 19);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 28);
            this.cmbFiltro.TabIndex = 19;
            // 
            // FormHistorialCitas
            // 
            this.ClientSize = new System.Drawing.Size(1465, 908);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelContent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHistorialCitas";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHistorialCitas_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelInsert.ResumeLayout(false);
            this.panelInsert.PerformLayout();
            this.panelCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReiniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbIngresoDatos;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbRolUsuario;
        private System.Windows.Forms.Label lbNombreUsuario;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.PictureBox pbReiniciar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvHistorialCitas;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.ComboBox cmbAccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCita;
    }
}