using NutriTrackSystem.Controllers;
using NutriTrackSystem.Interfaces;
using NutriTrackSystem.Models;

namespace NutriTrackSystem.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        private void BotonRegistro_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new();
            registerForm.Show();

            this.Hide();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            IAuthService controller = new AuthController();
            string username = TxtNombreUsuario.Text;
            string password = TxtContraseña.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario y contraseña.");
                return;
            }
            var user = controller.Login(username, password);
            if (user != null)
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                HomeForm home = new HomeForm(user);
                home.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }
    }
}
