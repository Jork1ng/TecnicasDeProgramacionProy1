using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NutriTrackSystem.Models;

namespace NutriTrackSystem.Views
{
    /// <summary>
    /// Constructor for the HomeForm class.
    /// </summary>
    public partial class HomeForm : Form
    {
        private User currentUser;
        public HomeForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// /Initializes the HomeForm with the logged-in user's information and updates the welcome message to include the username.
        /// </summary>
        /// <param name="user"></param>
        public HomeForm(User user)
        {
            InitializeComponent();
            currentUser = user;

            LableUser.Text = $"{currentUser.Username}!";
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            UserInfoForm form = new UserInfoForm(currentUser);
            form.Show();
            this.Hide();

        }

        private void ButtonProduct_Click(object sender, EventArgs e)
        {
            ProductManagementForm form = new ProductManagementForm(currentUser);
            form.Show();
            this.Hide();
        }
    }
}
