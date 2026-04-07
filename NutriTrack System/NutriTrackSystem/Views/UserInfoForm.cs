using NutriTrackSystem.Controllers;
using NutriTrackSystem.Interfaces;
using NutriTrackSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NutriTrackSystem.Views
{
    /// <summary>
    /// This class specify this is a windows forms
    /// </summary>
    public partial class UserInfoForm : Form
    {
        private User currentUser;

        /// <summary>
        /// Constructor for the disgner side
        /// </summary>
        public UserInfoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This constructor recibe the user From de HomeForm
        /// </summary>
        public UserInfoForm(User user)
        {
            InitializeComponent();
            currentUser = user;

            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            TxtWeight.Text = $"{currentUser.Weight}";
            TxtHeight.Text = $"{currentUser.Height}";
            ComboBoxActividadFisica.Text = currentUser.ActivityLevel;
            ComboBoxTipoDeDieta.Text = currentUser.DietaryPreferences;
            ComboBoxMeta.Text = currentUser.HealthGoals;
        }
        private void TxtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm(currentUser);
            home.Show();
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            IAuthService controller = new AuthController();

            double weight;
            double height;

            if (!double.TryParse(TxtWeight.Text, out weight))
            {
                MessageBox.Show("Peso inválido");
                return;
            }

            if (!double.TryParse(TxtHeight.Text, out height))
            {
                MessageBox.Show("Altura inválida");
                return;
            }

            if (string.IsNullOrWhiteSpace(ComboBoxActividadFisica.Text) ||
                string.IsNullOrWhiteSpace(ComboBoxTipoDeDieta.Text) ||
                string.IsNullOrWhiteSpace(ComboBoxMeta.Text))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            currentUser.Weight = weight;
            currentUser.Height = height;
            currentUser.ActivityLevel = ComboBoxActividadFisica.Text;
            currentUser.DietaryPreferences = ComboBoxTipoDeDieta.Text;
            currentUser.HealthGoals = ComboBoxMeta.Text;

            bool success = controller.UpdateUser(currentUser);

            if (success)
            {
                MessageBox.Show("Datos actualizados correctamente");
            }
            else
            {
                MessageBox.Show("Error al actualizar usuario");
            }
        }
    }
}
