using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NutriTrackSystem.Controllers;
using NutriTrackSystem.Interfaces;
using NutriTrackSystem.Models;

namespace NutriTrackSystem.Views
{
    public partial class ProductManagementForm : Form
    {
        private User currentUser;
        public ProductManagementForm()
        {
            InitializeComponent();
        }
        public ProductManagementForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            IProductService controller = new ProductController();

            double protein, carbs, fats;

            if (string.IsNullOrWhiteSpace(TxtProductName.Text))
            {
                MessageBox.Show("Ingrese un nombre");
                return;
            }

            if (!double.TryParse(TxtProtein.Text, out protein) ||
                !double.TryParse(TxtCarbo.Text, out carbs) ||
                !double.TryParse(TxtFat.Text, out fats))
            {
                MessageBox.Show("Valores nutricionales inválidos");
                return;
            }

            Product product = new Product
            {
                Name = TxtProductName.Text,
                Protein = protein,
                Carbs = carbs,
                Fats = fats
            };

            controller.AddProduct(product);

            MessageBox.Show("Producto guardado correctamente");
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            TxtProductName.Text = "";
            TxtProtein.Text = "";
            TxtFat.Text = "";
            TxtCarbo.Text = "";
        }
        private void ProductManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm(currentUser);
            home.Show();
            this.Close();
        }
    }
}
