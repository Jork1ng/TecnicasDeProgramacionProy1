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
    /// Representa un formulario de Windows Forms para la gestión de platillos, permitiendo a los usuarios ver, agregar,
    /// editar, eliminar y programar comidas, así como administrar los productos asociados a cada platillo.
    /// </summary>
    public partial class MealManagementForm : Form
    {
        private User currentUser;
        /// <summary>
        /// Initializes a new instance of the MealManagementForm class.
        public MealManagementForm()
        {
            InitializeComponent();
        }

        public MealManagementForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void MealManagementForm_Load(object sender, EventArgs e)
        {
            PanelMealInfo.Visible = true;
            PanelMeals.Visible = true;
            PanelScheduleMeal.Visible = false;
            PanelEditMeal.Visible = false;
            PanelAddMeal.Visible = false;
            LoadMeals();
            LoadProducts();
        }

        private void OcultarPaneles()
        {
            PanelScheduleMeal.Visible = false;
            PanelEditMeal.Visible = false;
            PanelAddMeal.Visible = false;
        }

        private void BtnEat_Click(object sender, EventArgs e)
        {

        }

        private void BtnSaveMeal_Click(object sender, EventArgs e)
        {
            IMealService controller = new MealController();

            if (string.IsNullOrWhiteSpace(TxtNameMeal.Text))
            {
                MessageBox.Show("Ingrese nombre del platillo");
                return;
            }

            if (string.IsNullOrWhiteSpace(BtnTimeMeal.Text))
            {
                MessageBox.Show("Seleccione tipo de comida");
                return;
            }

            Meal meal = new Meal
            {
                Name = TxtNameMeal.Text,
                MealType = BtnTimeMeal.Text,
                Username = currentUser.Username
            };

            controller.AddMeal(meal);

            MessageBox.Show("Platillo creado");

            CleanMealFields();
            LoadMeals();
            PanelAddMeal.Visible = false;
        }

        private void CleanMealFields()
        {
            TxtNameMeal.Text = string.Empty;
            BtnTimeMeal.Text = string.Empty;
        }
        private void LoadMeals()
        {
            IMealService controller = new MealController();

            var meals = controller.GetMeals()
                .Where(m => m.Username == currentUser.Username)
                .ToList();

            BtnMeals.DataSource = null;
            BtnMeals.DataSource = meals;
            BtnMeals.DisplayMember = "Name";
        }

        private void BtnMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMeal = (Meal)BtnMeals.SelectedItem;
            MostrarMealInfo(selectedMeal);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm(currentUser);
            home.Show();
            this.Close();
        }

        private void BtnSchedule_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            PanelScheduleMeal.Visible = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            PanelEditMeal.Visible = true;
        }

        private void BtnAddMeal_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            PanelAddMeal.Visible = true;
        }

        private void BtnDeleteMeal_Click(object sender, EventArgs e)
        {
            IMealService controller = new MealController();

            var selectedMeal = (Meal)BtnMeals.SelectedItem;

            if (selectedMeal == null)
            {
                MessageBox.Show("Seleccione un platillo");
                return;
            }

            var confirm = MessageBox.Show(
                "¿Seguro que desea eliminar este platillo?",
                "Confirmar",
                MessageBoxButtons.YesNo
            );

            if (confirm == DialogResult.No)
                return;

            controller.DeleteMeal(selectedMeal.Name, currentUser.Username);

            MessageBox.Show("Platillo eliminado");

            LoadMeals();
        }

        private void LoadProducts()
        {
            IProductService controller = new ProductController();

            var products = controller.GetProducts();

            BtnProduct.DataSource = null;
            BtnProduct.DataSource = products;
            BtnProduct.DisplayMember = "Name";
        }
        private void BtnProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            IMealService mealController = new MealController();

            var selectedMeal = (Meal)BtnMeals.SelectedItem;
            var selectedProduct = (Product)BtnProduct.SelectedItem;

            if (selectedMeal == null || selectedProduct == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            var existingProduct = selectedMeal.Products
                .FirstOrDefault(p => p.Name == selectedProduct.Name);

            if (existingProduct != null)
            {
                existingProduct.Quantity += 100;
            }
            else
            {
                selectedMeal.Products.Add(new MealProduct
                {
                    Name = selectedProduct.Name,
                    Protein = selectedProduct.Protein,
                    Carbs = selectedProduct.Carbs,
                    Fats = selectedProduct.Fats,
                    Quantity = 100
                });
            }

            mealController.UpdateMeal(selectedMeal);
            MessageBox.Show("Producto agregado al platillo");
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            IMealService mealController = new MealController();

            var selectedMeal = (Meal)BtnMeals.SelectedItem;
            var selectedProduct = (Product)BtnProduct.SelectedItem;

            if (selectedMeal == null || selectedProduct == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            var existingProduct = selectedMeal.Products
                .FirstOrDefault(p => p.Name == selectedProduct.Name);

            if (existingProduct == null)
            {
                MessageBox.Show("El producto no está en el platilo");
                return;
            }

            existingProduct.Quantity -= 100;

            if (existingProduct.Quantity <= 0)
            {
                selectedMeal.Products.Remove(existingProduct);
            }

            mealController.UpdateMeal(selectedMeal);

            MessageBox.Show("Producto actualizado");
        }
        private void MostrarMealInfo(Meal meal)
        {
            if (meal == null || meal.Products == null || meal.Products.Count == 0)
            {
                TxtMealInfo.Text = "No hay información del platllo.";
                return;
            }

            double totalProtein = 0;
            double totalCarbs = 0;
            double totalFats = 0;

            string info = $"{meal.MealType}\r\n";
            info += $"{meal.Name}\r\n\r\n";
            info += "Contenido:\r\n";

            foreach (var p in meal.Products)
            {
                double factor = p.Quantity / 100.0;

                double protein = p.Protein * factor;
                double carbs = p.Carbs * factor;
                double fats = p.Fats * factor;

                totalProtein += protein;
                totalCarbs += carbs;
                totalFats += fats;

                info += $"- {p.Name} ({p.Quantity}g)\r\n";
                info += $"  Proteína: {protein:F1}g | Carbos: {carbs:F1}g | Grasas: {fats:F1}g\r\n";
            }

            info += "\r\n=== TOTALES ===\r\n";
            info += $"Proteínas: {totalProtein:F1}g\r\n";
            info += $"Carbohidratos: {totalCarbs:F1}g\r\n";
            info += $"Grasas: {totalFats:F1}g\r\n";

            TxtMealInfo.Text = info;
        }
    }
}
