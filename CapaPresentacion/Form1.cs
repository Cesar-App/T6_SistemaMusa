using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        private UsuariosBL usuariosBL = new UsuariosBL();
        private Usuarios loggedUser;
        private int failedAttempts = 0;

        public FrmLogin()
        {
            InitializeComponent();
            // suscribir evento del botón de login
            this.btnLogin.Click += btnLogin_Click;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CenterCard();
            txtPassword.UseSystemPasswordChar = false;
        }

        private void CenterCard()
        {
            // Center the cardPanel horizontally and place it slightly below the top panel
            int x = (this.ClientSize.Width - this.cardPanel.Width) / 2;
            int y = this.panel1.Height - 40;
            this.cardPanel.Location = new Point(Math.Max(20, x), Math.Max(80, y));
        }

        private void txtUser_GotFocus(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario o Cédula")
            {
                txtUser.Text = string.Empty;
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                txtUser.Text = "Usuario o Cédula";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_GotFocus(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = string.Empty;
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            picShow.Image = txtPassword.UseSystemPasswordChar ? Properties.Resources.eye_close : Properties.Resources.eye_open;
        }

        private void lblFooter_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = txtUser.Text?.Trim();
            var pass = txtPassword.Text ?? string.Empty;
            // si el usuario está en placeholder, tratar como vacío
            if (user == "Usuario o Cédula") user = string.Empty;
            if (pass == "Contraseña") pass = string.Empty;

            Usuarios u = null;
            try
            {
                u = usuariosBL.Login(user, pass);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (u == null)
            {
                failedAttempts++;
                int intentos = 3 - failedAttempts;
                if (intentos > 0)
                {
                    MessageBox.Show($"Usuario o contraseña inválidos. Intentos restantes: {intentos}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Text = string.Empty;
                    txtPassword.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Se ha superado el número de intentos. La aplicación se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                    return;
                }
            }

            // login exitoso
            loggedUser = u;
            // guardar usuario en sesión para acceder desde otros formularios
            Session.CurrentUser = u;
            var inicio = new FormInicio(loggedUser);
            this.Hide();
            inicio.ShowDialog();
            this.Close();
        }
    }
}
