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
            CargarNutricion();
        }
        private void CargarDatosUsuario()
        {
            TxtWeight.Text = $"{currentUser.Weight}";
            TxtHeight.Text = $"{currentUser.Height}";
            ComboBoxActividadFisica.Text = currentUser.ActivityLevel;
            ComboBoxTipoDeDieta.Text = currentUser.DietaryPreferences;
            ComboBoxMeta.Text = currentUser.HealthGoals;
        }

        private void CargarNutricion()
        {
            if (currentUser == null)
                return;

            TxtImc.Text = $"IMC: {currentUser.BMI:F1}";
            TxtGoal.Text = $"Calorías Diarias: {currentUser.DailyCalories:F0} kcal";
            TxtProtein.Text = $"Proteínas: {currentUser.ProteinGrams:F0} g";
            TxtCarbo.Text = $"Carbohidratos: {currentUser.CarbsGrams:F0} g";
            TxtFat.Text = $"Grasas: {currentUser.FatGrams:F0} g";
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

            var nutrition = new NutritionController();

            currentUser.BMI = nutrition.CalculateIMC(currentUser);
            currentUser.DailyCalories = nutrition.CalculateCalories(currentUser);

            var macros = nutrition.CalculateMacros(currentUser);

            currentUser.ProteinGrams = macros.protein;
            currentUser.CarbsGrams = macros.carbs;
            currentUser.FatGrams = macros.fats;

            bool success = controller.UpdateUser(currentUser);

            if (success)
            {
                MessageBox.Show("Datos actualizados correctamente");
            }
            else
            {
                MessageBox.Show("Error al actualizar usuario");
            }
            CargarNutricion();
        }
    }
}
