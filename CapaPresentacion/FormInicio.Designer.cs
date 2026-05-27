namespace CapaPresentacion
{
    partial class FormInicio
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbFecha = new System.Windows.Forms.PictureBox();
            this.pbHora = new System.Windows.Forms.PictureBox();
            this.lbHora = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelCard = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.cmbTipoBackup = new System.Windows.Forms.ComboBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbBienvenida = new System.Windows.Forms.Label();
            this.ofdBackup = new System.Windows.Forms.OpenFileDialog();
            this.panelSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.panelContent.SuspendLayout();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panelHeader.Controls.Add(this.pbFecha);
            this.panelHeader.Controls.Add(this.pbHora);
            this.panelHeader.Controls.Add(this.lbHora);
            this.panelHeader.Controls.Add(this.lbFecha);
            this.panelHeader.Controls.Add(this.pbHome);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Controls.Add(this.txtBuscar);
            this.panelHeader.Controls.Add(this.btnNuevo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1542, 72);
            this.panelHeader.TabIndex = 1;
            // 
            // pbFecha
            // 
            this.pbFecha.Image = global::CapaPresentacion.Properties.Resources.Fecha;
            this.pbFecha.Location = new System.Drawing.Point(859, 20);
            this.pbFecha.Name = "pbFecha";
            this.pbFecha.Size = new System.Drawing.Size(44, 36);
            this.pbFecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFecha.TabIndex = 9;
            this.pbFecha.TabStop = false;
            // 
            // pbHora
            // 
            this.pbHora.Image = global::CapaPresentacion.Properties.Resources.Hora;
            this.pbHora.Location = new System.Drawing.Point(1135, 20);
            this.pbHora.Name = "pbHora";
            this.pbHora.Size = new System.Drawing.Size(44, 36);
            this.pbHora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHora.TabIndex = 8;
            this.pbHora.TabStop = false;
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbHora.Location = new System.Drawing.Point(1175, 22);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(77, 38);
            this.lbHora.TabIndex = 7;
            this.lbHora.Text = "Hora";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(898, 22);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(89, 38);
            this.lbFecha.TabIndex = 6;
            this.lbFecha.Text = "Fecha";
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
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(312, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(609, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Inicio Sistema Gestion de Citas Medicas";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.Location = new System.Drawing.Point(1980, 20);
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
            this.btnNuevo.Location = new System.Drawing.Point(2320, 18);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 32);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo Registro";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.panelContent.Controls.Add(this.panelCard);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1542, 908);
            this.panelContent.TabIndex = 2;
            // 
            // panelCard
            // 
            this.panelCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo1;
            this.panelCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCard.Controls.Add(this.btnRestaurar);
            this.panelCard.Controls.Add(this.cmbTipoBackup);
            this.panelCard.Controls.Add(this.btnBackup);
            this.panelCard.Controls.Add(this.label6);
            this.panelCard.Controls.Add(this.pictureBox2);
            this.panelCard.Controls.Add(this.label1);
            this.panelCard.Controls.Add(this.pictureBox1);
            this.panelCard.Controls.Add(this.lbBienvenida);
            this.panelCard.Location = new System.Drawing.Point(297, 96);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(16);
            this.panelCard.Size = new System.Drawing.Size(1208, 555);
            this.panelCard.TabIndex = 0;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.Location = new System.Drawing.Point(714, 485);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(169, 38);
            this.btnRestaurar.TabIndex = 16;
            this.btnRestaurar.Text = "Restaurar Backup";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click_1);
            // 
            // cmbTipoBackup
            // 
            this.cmbTipoBackup.FormattingEnabled = true;
            this.cmbTipoBackup.Location = new System.Drawing.Point(279, 495);
            this.cmbTipoBackup.Name = "cmbTipoBackup";
            this.cmbTipoBackup.Size = new System.Drawing.Size(158, 28);
            this.cmbTipoBackup.TabIndex = 15;
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(93, 489);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(140, 38);
            this.btnBackup.TabIndex = 14;
            this.btnBackup.Text = "Hacer Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(643, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 48);
            this.label6.TabIndex = 13;
            this.label6.Text = "Restaurar Backup";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.Backup;
            this.pictureBox2.Location = new System.Drawing.Point(630, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(337, 301);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(127, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 48);
            this.label1.TabIndex = 11;
            this.label1.Text = "Guardar Backup";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Backup;
            this.pictureBox1.Location = new System.Drawing.Point(100, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbBienvenida
            // 
            this.lbBienvenida.AutoSize = true;
            this.lbBienvenida.BackColor = System.Drawing.Color.White;
            this.lbBienvenida.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbBienvenida.Location = new System.Drawing.Point(317, 36);
            this.lbBienvenida.Name = "lbBienvenida";
            this.lbBienvenida.Size = new System.Drawing.Size(219, 48);
            this.lbBienvenida.TabIndex = 6;
            this.lbBienvenida.Text = "Bienvenido ";
            // 
            // ofdBackup
            // 
            this.ofdBackup.FileName = "openBackup";
            // 
            // FormInicio
            // 
            this.ClientSize = new System.Drawing.Size(1542, 908);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelContent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInicio";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label lbBienvenida;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.PictureBox pbFecha;
        private System.Windows.Forms.PictureBox pbHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmbTipoBackup;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.OpenFileDialog ofdBackup;
    }
}
