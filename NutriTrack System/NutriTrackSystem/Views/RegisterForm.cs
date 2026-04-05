using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NutriTrackSystem.Models;
using NutriTrackSystem.Interfaces;
using NutriTrackSystem.Controllers;

namespace NutriTrackSystem.Views
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void LabelBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void TxtAlturaCM_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TxtAltura_Click(object sender, EventArgs e)
        {

        }

        private void LabelEscribaElNombreDeUsuario_Click(object sender, EventArgs e)
        {

        }

        private void LabelActividadFisica_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxMeta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BotonRegistro_Click(object sender, EventArgs e)
        {
            IAuthService controller = new AuthController();

            double weight;
            double height;

            if (string.IsNullOrEmpty(TxtUsuario.Text) || string.IsNullOrEmpty(TxtContraseña.Text) ||
                string.IsNullOrEmpty(TxtWeight.Text) || string.IsNullOrEmpty(TxtHeight.Text) ||
                string.IsNullOrEmpty(ComboBoxActividadFisica.Text) || string.IsNullOrEmpty(ComboBoxTipoDeDieta.Text) ||
                string.IsNullOrEmpty(ComboBoxMeta.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!double.TryParse(TxtWeight.Text, out weight))
            {
                MessageBox.Show("Peso Invalido");
            }

            if (!double.TryParse(TxtHeight.Text, out height))
            {
                MessageBox.Show("Altura Invalida");
            }

            User user = new User
            {
                Username = TxtUsuario.Text,
                Password = TxtContraseña.Text,
                Weight = weight,
                Height = height,
                ActivityLevel = ComboBoxActividadFisica.Text,
                DietaryPreferences = ComboBoxTipoDeDieta.Text,
                HealthGoals = ComboBoxMeta.Text

            };
            bool success = controller.Register(user);

            if (success)
            {
                MessageBox.Show("Registro Exitoso");

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario ya existe");
            }
        }
    }   
}
