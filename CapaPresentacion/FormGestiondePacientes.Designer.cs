namespace CapaPresentacion
{
    partial class FormGestiondePacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.dtpFecha_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnEliliminarPaciente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.textBoxPaciente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarPacientes = new System.Windows.Forms.Button();
            this.panelCard = new System.Windows.Forms.Panel();
            this.pbReiniciar = new System.Windows.Forms.PictureBox();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
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
            this.panelSidebar.Size = new System.Drawing.Size(260, 745);
            this.panelSidebar.TabIndex = 3;
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
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
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
            this.panelHeader.Size = new System.Drawing.Size(1720, 72);
            this.panelHeader.TabIndex = 4;
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
            this.lblTitulo.Location = new System.Drawing.Point(312, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(337, 135);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Pacientes \r\n\r\n\r\n";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.Location = new System.Drawing.Point(2158, 20);
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
            this.btnNuevo.Location = new System.Drawing.Point(2498, 18);
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
            this.panelContent.Size = new System.Drawing.Size(1720, 817);
            this.panelContent.TabIndex = 5;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // panelInsert
            // 
            this.panelInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInsert.BackColor = System.Drawing.Color.White;
            this.panelInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInsert.Controls.Add(this.textBoxDireccion);
            this.panelInsert.Controls.Add(this.label11);
            this.panelInsert.Controls.Add(this.textBoxApellido);
            this.panelInsert.Controls.Add(this.label10);
            this.panelInsert.Controls.Add(this.comboBoxSexo);
            this.panelInsert.Controls.Add(this.dtpFecha_Nacimiento);
            this.panelInsert.Controls.Add(this.btnEliliminarPaciente);
            this.panelInsert.Controls.Add(this.button2);
            this.panelInsert.Controls.Add(this.textBoxTelefono);
            this.panelInsert.Controls.Add(this.textBoxCedula);
            this.panelInsert.Controls.Add(this.textBoxPaciente);
            this.panelInsert.Controls.Add(this.label9);
            this.panelInsert.Controls.Add(this.label8);
            this.panelInsert.Controls.Add(this.label7);
            this.panelInsert.Controls.Add(this.label6);
            this.panelInsert.Controls.Add(this.lblPacientes);
            this.panelInsert.Controls.Add(this.label1);
            this.panelInsert.Controls.Add(this.btnGuardarPacientes);
            this.panelInsert.Location = new System.Drawing.Point(342, 534);
            this.panelInsert.Name = "panelInsert";
            this.panelInsert.Size = new System.Drawing.Size(1355, 261);
            this.panelInsert.TabIndex = 2;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(834, 88);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(189, 26);
            this.textBoxDireccion.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(719, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 28);
            this.label11.TabIndex = 28;
            this.label11.Text = "Direccion:";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(516, 83);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(189, 26);
            this.textBoxApellido.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(401, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 28);
            this.label10.TabIndex = 26;
            this.label10.Text = "Apellido:";
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexo.Location = new System.Drawing.Point(115, 201);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(184, 28);
            this.comboBoxSexo.TabIndex = 25;
            this.comboBoxSexo.SelectedIndexChanged += new System.EventHandler(this.comboBoxSexo_SelectedIndexChanged);
            // 
            // dtpFecha_Nacimiento
            // 
            this.dtpFecha_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Nacimiento.Location = new System.Drawing.Point(608, 201);
            this.dtpFecha_Nacimiento.Name = "dtpFecha_Nacimiento";
            this.dtpFecha_Nacimiento.Size = new System.Drawing.Size(108, 26);
            this.dtpFecha_Nacimiento.TabIndex = 21;
            // 
            // btnEliliminarPaciente
            // 
            this.btnEliliminarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.btnEliliminarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliliminarPaciente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliliminarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnEliliminarPaciente.Location = new System.Drawing.Point(1133, 201);
            this.btnEliliminarPaciente.Name = "btnEliliminarPaciente";
            this.btnEliliminarPaciente.Size = new System.Drawing.Size(92, 41);
            this.btnEliliminarPaciente.TabIndex = 20;
            this.btnEliliminarPaciente.Text = "Eliminar";
            this.btnEliliminarPaciente.UseVisualStyleBackColor = false;
            this.btnEliliminarPaciente.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1133, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 41);
            this.button2.TabIndex = 19;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(162, 142);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(189, 26);
            this.textBoxTelefono.TabIndex = 18;
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(504, 146);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(189, 26);
            this.textBoxCedula.TabIndex = 17;
            // 
            // textBoxPaciente
            // 
            this.textBoxPaciente.Location = new System.Drawing.Point(162, 83);
            this.textBoxPaciente.Name = "textBoxPaciente";
            this.textBoxPaciente.Size = new System.Drawing.Size(189, 26);
            this.textBoxPaciente.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(369, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 28);
            this.label9.TabIndex = 13;
            this.label9.Text = "Fecha de Nacimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(402, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cedula:";
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacientes.Location = new System.Drawing.Point(47, 79);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(98, 28);
            this.lblPacientes.TabIndex = 9;
            this.lblPacientes.Text = "Paciente:";
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
            // btnGuardarPacientes
            // 
            this.btnGuardarPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(118)))));
            this.btnGuardarPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPacientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPacientes.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPacientes.Location = new System.Drawing.Point(1133, 84);
            this.btnGuardarPacientes.Name = "btnGuardarPacientes";
            this.btnGuardarPacientes.Size = new System.Drawing.Size(92, 41);
            this.btnGuardarPacientes.TabIndex = 6;
            this.btnGuardarPacientes.Text = "Guardar";
            this.btnGuardarPacientes.UseVisualStyleBackColor = false;
            this.btnGuardarPacientes.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panelCard
            // 
            this.panelCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.pbReiniciar);
            this.panelCard.Controls.Add(this.dgvPacientes);
            this.panelCard.Location = new System.Drawing.Point(288, 108);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(16);
            this.panelCard.Size = new System.Drawing.Size(1396, 293);
            this.panelCard.TabIndex = 0;
            // 
            // pbReiniciar
            // 
            this.pbReiniciar.BackColor = System.Drawing.Color.Transparent;
            this.pbReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbReiniciar.Image = global::CapaPresentacion.Properties.Resources.Reiniciar;
            this.pbReiniciar.Location = new System.Drawing.Point(73, 19);
            this.pbReiniciar.Name = "pbReiniciar";
            this.pbReiniciar.Size = new System.Drawing.Size(32, 28);
            this.pbReiniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReiniciar.TabIndex = 4;
            this.pbReiniciar.TabStop = false;
            this.pbReiniciar.Click += new System.EventHandler(this.pbReiniciar_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPacientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvPacientes.ColumnHeadersHeight = 34;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPacientes.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPacientes.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPacientes.Location = new System.Drawing.Point(68, 60);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.RowHeadersWidth = 62;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(1256, 212);
            this.dgvPacientes.TabIndex = 1;
            this.dgvPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellContentClick);
            // 
            // FormGestiondePacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 817);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelContent);
            this.Name = "FormGestiondePacientes";
            this.Text = "FormGestiondePaciente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGestiondePacientes_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelInsert;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarPacientes;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.PictureBox pbReiniciar;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.TextBox textBoxPaciente;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Button btnEliliminarPaciente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpFecha_Nacimiento;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label10;
    }
}