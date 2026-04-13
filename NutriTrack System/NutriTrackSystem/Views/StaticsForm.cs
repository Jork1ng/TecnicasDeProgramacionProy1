using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NutriTrackSystem.Models;
using NutriTrackSystem.Controllers;
using NutriTrackSystem.Interfaces;

namespace NutriTrackSystem.Views
{
    public partial class StaticsForm : Form
    {
        private User currentUser;
        public StaticsForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }
        public StaticsForm()
        {
            InitializeComponent();
        }

        private void StaticsForm_Load(object sender, EventArgs e)
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
