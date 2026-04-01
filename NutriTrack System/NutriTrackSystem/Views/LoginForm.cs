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
            RegisterForm registerForm = new ();
            registerForm.Show();

            this.Hide();
        }
    }
}
