namespace CapaPresentacion
{
    partial class FormMedicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelsidebar;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Panel panelcontent;
        private System.Windows.Forms.Panel panelcard;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.ComboBox cmbfiltro;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.Panel panelinsert;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label lblmedico;
        private System.Windows.Forms.Label lbldia;

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
            this.panelsidebar = new System.Windows.Forms.Panel();
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
            this.panelheader = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.panelcontent = new System.Windows.Forms.Panel();
            this.panelinsert = new System.Windows.Forms.Panel();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lbingresoDatos = new System.Windows.Forms.Label();
            this.lbldia = new System.Windows.Forms.Label();
            this.lblmedico = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.panelcard = new System.Windows.Forms.Panel();
            this.pbReiniciar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbfiltro = new System.Windows.Forms.ComboBox();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.btnReporte = new System.Windows.Forms.Button();
            this.panelsidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelcontent.SuspendLayout();
            this.panelinsert.SuspendLayout();
            this.panelcard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReiniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelsidebar
            // 
            this.panelsidebar.BackColor = System.Drawing.Color.White;
            this.panelsidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelsidebar.Controls.Add(this.btnHorarios);
            this.panelsidebar.Controls.Add(this.btnEspecialidades);
            this.panelsidebar.Controls.Add(this.label5);
            this.panelsidebar.Controls.Add(this.separator);
            this.panelsidebar.Controls.Add(this.btnRoles);
            this.panelsidebar.Controls.Add(this.panel1);
            this.panelsidebar.Controls.Add(this.btnUsuarios);
            this.panelsidebar.Controls.Add(this.btnMedicos);
            this.panelsidebar.Controls.Add(this.btnPacientes);
            this.panelsidebar.Controls.Add(this.btnHistorial);
            this.panelsidebar.Controls.Add(this.btnCitas);
            this.panelsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsidebar.Location = new System.Drawing.Point(0, 72);
            this.panelsidebar.Name = "panelsidebar";
            this.panelsidebar.Size = new System.Drawing.Size(260, 836);
            this.panelsidebar.TabIndex = 0;
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
            this.btnHorarios.Click += new System.EventHandler(this.btnHorarios_Click_1);
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
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
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
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.White;
            this.panelheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelheader.Controls.Add(this.pictureBox2);
            this.panelheader.Controls.Add(this.lbltitulo);
            this.panelheader.Controls.Add(this.txtbuscar);
            this.panelheader.Controls.Add(this.btnnuevo);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1465, 72);
            this.panelheader.TabIndex = 1;
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
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(730, 20);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(315, 45);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Gestión de Médicos";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbuscar.Location = new System.Drawing.Point(1903, 20);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(320, 31);
            this.txtbuscar.TabIndex = 1;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.ForeColor = System.Drawing.Color.White;
            this.btnnuevo.Location = new System.Drawing.Point(2243, 18);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(110, 32);
            this.btnnuevo.TabIndex = 2;
            this.btnnuevo.Text = "Nuevo Registro";
            this.btnnuevo.UseVisualStyleBackColor = false;
            // 
            // panelcontent
            // 
            this.panelcontent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.panelcontent.Controls.Add(this.panelinsert);
            this.panelcontent.Controls.Add(this.panelcard);
            this.panelcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontent.Location = new System.Drawing.Point(0, 0);
            this.panelcontent.Name = "panelcontent";
            this.panelcontent.Size = new System.Drawing.Size(1465, 908);
            this.panelcontent.TabIndex = 2;
            // 
            // panelinsert
            // 
            this.panelinsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelinsert.BackColor = System.Drawing.Color.White;
            this.panelinsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelinsert.Controls.Add(this.btnReporte);
            this.panelinsert.Controls.Add(this.cbEspecialidad);
            this.panelinsert.Controls.Add(this.label3);
            this.panelinsert.Controls.Add(this.txtCorreo);
            this.panelinsert.Controls.Add(this.label2);
            this.panelinsert.Controls.Add(this.txtTelefono);
            this.panelinsert.Controls.Add(this.label1);
            this.panelinsert.Controls.Add(this.txtApellido);
            this.panelinsert.Controls.Add(this.txtNombre);
            this.panelinsert.Controls.Add(this.btnActualizar);
            this.panelinsert.Controls.Add(this.lbingresoDatos);
            this.panelinsert.Controls.Add(this.lbldia);
            this.panelinsert.Controls.Add(this.lblmedico);
            this.panelinsert.Controls.Add(this.btnguardar);
            this.panelinsert.Location = new System.Drawing.Point(395, 662);
            this.panelinsert.Name = "panelinsert";
            this.panelinsert.Size = new System.Drawing.Size(931, 207);
            this.panelinsert.TabIndex = 2;
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(183, 168);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(164, 28);
            this.cbEspecialidad.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Especialidad:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(488, 117);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(151, 26);
            this.txtCorreo.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Correo Electronico:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(140, 121);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(151, 26);
            this.txtTelefono.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Telefono:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(450, 71);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(151, 26);
            this.txtApellido.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 26);
            this.txtNombre.TabIndex = 17;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(633, 161);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 37);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // lbingresoDatos
            // 
            this.lbingresoDatos.AutoSize = true;
            this.lbingresoDatos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbingresoDatos.Location = new System.Drawing.Point(3, 14);
            this.lbingresoDatos.Name = "lbingresoDatos";
            this.lbingresoDatos.Size = new System.Drawing.Size(247, 38);
            this.lbingresoDatos.TabIndex = 7;
            this.lbingresoDatos.Text = "Ingreso de Datos:";
            // 
            // lbldia
            // 
            this.lbldia.AutoSize = true;
            this.lbldia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldia.Location = new System.Drawing.Point(28, 67);
            this.lbldia.Name = "lbldia";
            this.lbldia.Size = new System.Drawing.Size(94, 28);
            this.lbldia.TabIndex = 8;
            this.lbldia.Text = "Nombre:";
            // 
            // lblmedico
            // 
            this.lblmedico.AutoSize = true;
            this.lblmedico.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblmedico.Location = new System.Drawing.Point(338, 67);
            this.lblmedico.Name = "lblmedico";
            this.lblmedico.Size = new System.Drawing.Size(96, 28);
            this.lblmedico.TabIndex = 10;
            this.lblmedico.Text = "Apellido:";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Location = new System.Drawing.Point(497, 161);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(104, 37);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            // 
            // panelcard
            // 
            this.panelcard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelcard.BackColor = System.Drawing.Color.White;
            this.panelcard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelcard.Controls.Add(this.pbReiniciar);
            this.panelcard.Controls.Add(this.pictureBox1);
            this.panelcard.Controls.Add(this.cmbfiltro);
            this.panelcard.Controls.Add(this.dgvMedicos);
            this.panelcard.Location = new System.Drawing.Point(294, 96);
            this.panelcard.Name = "panelcard";
            this.panelcard.Padding = new System.Windows.Forms.Padding(16);
            this.panelcard.Size = new System.Drawing.Size(1142, 321);
            this.panelcard.TabIndex = 0;
            // 
            // pbReiniciar
            // 
            this.pbReiniciar.BackColor = System.Drawing.Color.Transparent;
            this.pbReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbReiniciar.Image = global::CapaPresentacion.Properties.Resources.Reiniciar;
            this.pbReiniciar.Location = new System.Drawing.Point(284, 19);
            this.pbReiniciar.Name = "pbReiniciar";
            this.pbReiniciar.Size = new System.Drawing.Size(32, 28);
            this.pbReiniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReiniciar.TabIndex = 16;
            this.pbReiniciar.TabStop = false;
            this.pbReiniciar.Click += new System.EventHandler(this.pbReiniciar_Click);
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
            // cmbfiltro
            // 
            this.cmbfiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfiltro.Location = new System.Drawing.Point(54, 19);
            this.cmbfiltro.Name = "cmbfiltro";
            this.cmbfiltro.Size = new System.Drawing.Size(179, 28);
            this.cmbfiltro.TabIndex = 0;
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.AllowUserToAddRows = false;
            this.dgvMedicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicos.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedicos.ColumnHeadersHeight = 34;
            this.dgvMedicos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMedicos.Location = new System.Drawing.Point(19, 76);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.ReadOnly = true;
            this.dgvMedicos.RowHeadersVisible = false;
            this.dgvMedicos.RowHeadersWidth = 62;
            this.dgvMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicos.Size = new System.Drawing.Size(1089, 224);
            this.dgvMedicos.TabIndex = 1;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(497, 19);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(153, 37);
            this.btnReporte.TabIndex = 25;
            this.btnReporte.Text = "Ver Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // FormMedicos
            // 
            this.ClientSize = new System.Drawing.Size(1465, 908);
            this.Controls.Add(this.panelsidebar);
            this.Controls.Add(this.panelheader);
            this.Controls.Add(this.panelcontent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMedicos";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMedicos_Load);
            this.panelsidebar.ResumeLayout(false);
            this.panelsidebar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelcontent.ResumeLayout(false);
            this.panelinsert.ResumeLayout(false);
            this.panelinsert.PerformLayout();
            this.panelcard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbReiniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbingresoDatos;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReporte;
    }
}
