namespace NutriTrackSystem.Views
{
    partial class MealManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealManagementForm));
            labelTitulo = new Label();
            BtnBack = new Button();
            labelProducts = new Label();
            PanelMeals = new Panel();
            BtnAddMeal = new Button();
            label3 = new Label();
            BtnSchedule = new Button();
            BtnDeleteMeal = new Button();
            BtnEdit = new Button();
            BtnMeals = new ComboBox();
            label1 = new Label();
            PanelMealInfo = new Panel();
            TxtMealInfo = new Label();
            PanelScheduleMeal = new Panel();
            BtnEat = new Button();
            DateTimePickerMeal = new DateTimePicker();
            label4 = new Label();
            PanelAddMeal = new Panel();
            BtnSaveMeal = new Button();
            BtnTimeMeal = new ComboBox();
            label7 = new Label();
            TxtNameMeal = new TextBox();
            label6 = new Label();
            label5 = new Label();
            PanelEditMeal = new Panel();
            BtnProduct = new ComboBox();
            BtnAddProduct = new Button();
            BtnDeleteProduct = new Button();
            label8 = new Label();
            PanelMeals.SuspendLayout();
            PanelMealInfo.SuspendLayout();
            PanelScheduleMeal.SuspendLayout();
            PanelAddMeal.SuspendLayout();
            PanelEditMeal.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(232, 10);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(138, 20);
            labelTitulo.TabIndex = 2;
            labelTitulo.Text = "NutriTrack System";
            labelTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnBack
            // 
            BtnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBack.Location = new Point(450, 10);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(130, 36);
            BtnBack.TabIndex = 4;
            BtnBack.Text = "Volver";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // labelProducts
            // 
            labelProducts.AutoSize = true;
            labelProducts.Location = new Point(276, 40);
            labelProducts.Name = "labelProducts";
            labelProducts.Size = new Size(52, 20);
            labelProducts.TabIndex = 5;
            labelProducts.Text = "Menus";
            // 
            // PanelMeals
            // 
            PanelMeals.BackColor = SystemColors.ButtonHighlight;
            PanelMeals.Controls.Add(BtnAddMeal);
            PanelMeals.Controls.Add(label3);
            PanelMeals.Controls.Add(BtnSchedule);
            PanelMeals.Controls.Add(BtnDeleteMeal);
            PanelMeals.Controls.Add(BtnEdit);
            PanelMeals.Controls.Add(BtnMeals);
            PanelMeals.Controls.Add(label1);
            PanelMeals.Location = new Point(5, 61);
            PanelMeals.Name = "PanelMeals";
            PanelMeals.Size = new Size(403, 156);
            PanelMeals.TabIndex = 6;
            // 
            // BtnAddMeal
            // 
            BtnAddMeal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAddMeal.ForeColor = Color.Blue;
            BtnAddMeal.Location = new Point(136, 117);
            BtnAddMeal.Name = "BtnAddMeal";
            BtnAddMeal.Size = new Size(130, 36);
            BtnAddMeal.TabIndex = 10;
            BtnAddMeal.Text = "Agregar";
            BtnAddMeal.UseVisualStyleBackColor = true;
            BtnAddMeal.Click += BtnAddMeal_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 96);
            label3.Name = "label3";
            label3.Size = new Size(263, 20);
            label3.TabIndex = 9;
            label3.Text = "¿No encontraste tu platillo? ¡Crea uno!";
            // 
            // BtnSchedule
            // 
            BtnSchedule.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSchedule.ForeColor = Color.Lime;
            BtnSchedule.Location = new Point(4, 59);
            BtnSchedule.Name = "BtnSchedule";
            BtnSchedule.Size = new Size(130, 36);
            BtnSchedule.TabIndex = 8;
            BtnSchedule.Text = "Agendar";
            BtnSchedule.UseVisualStyleBackColor = true;
            BtnSchedule.Click += BtnSchedule_Click;
            // 
            // BtnDeleteMeal
            // 
            BtnDeleteMeal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDeleteMeal.ForeColor = Color.Red;
            BtnDeleteMeal.Location = new Point(269, 59);
            BtnDeleteMeal.Name = "BtnDeleteMeal";
            BtnDeleteMeal.Size = new Size(130, 36);
            BtnDeleteMeal.TabIndex = 8;
            BtnDeleteMeal.Text = "Eliminar";
            BtnDeleteMeal.UseVisualStyleBackColor = true;
            BtnDeleteMeal.Click += BtnDeleteMeal_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEdit.ForeColor = Color.Gold;
            BtnEdit.Location = new Point(136, 59);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(130, 36);
            BtnEdit.TabIndex = 5;
            BtnEdit.Text = "Editar";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnMeals
            // 
            BtnMeals.FormattingEnabled = true;
            BtnMeals.Location = new Point(54, 26);
            BtnMeals.Name = "BtnMeals";
            BtnMeals.Size = new Size(289, 28);
            BtnMeals.TabIndex = 1;
            BtnMeals.SelectedIndexChanged += BtnMeals_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 4);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar platillos";
            // 
            // PanelMealInfo
            // 
            PanelMealInfo.BackColor = SystemColors.ButtonHighlight;
            PanelMealInfo.Controls.Add(TxtMealInfo);
            PanelMealInfo.Location = new Point(413, 61);
            PanelMealInfo.Name = "PanelMealInfo";
            PanelMealInfo.Size = new Size(166, 398);
            PanelMealInfo.TabIndex = 7;
            // 
            // TxtMealInfo
            // 
            TxtMealInfo.AutoSize = true;
            TxtMealInfo.Location = new Point(26, 26);
            TxtMealInfo.MaximumSize = new Size(150, 500);
            TxtMealInfo.Name = "TxtMealInfo";
            TxtMealInfo.Size = new Size(114, 40);
            TxtMealInfo.TabIndex = 0;
            TxtMealInfo.Text = "Informacion del platillo";
            TxtMealInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelScheduleMeal
            // 
            PanelScheduleMeal.BackColor = SystemColors.ButtonHighlight;
            PanelScheduleMeal.Controls.Add(BtnEat);
            PanelScheduleMeal.Controls.Add(DateTimePickerMeal);
            PanelScheduleMeal.Controls.Add(label4);
            PanelScheduleMeal.Location = new Point(5, 219);
            PanelScheduleMeal.Name = "PanelScheduleMeal";
            PanelScheduleMeal.Size = new Size(403, 58);
            PanelScheduleMeal.TabIndex = 8;
            // 
            // BtnEat
            // 
            BtnEat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEat.ForeColor = Color.Lime;
            BtnEat.Location = new Point(216, 25);
            BtnEat.Name = "BtnEat";
            BtnEat.Size = new Size(143, 28);
            BtnEat.TabIndex = 9;
            BtnEat.Text = "Comer";
            BtnEat.UseVisualStyleBackColor = true;
            BtnEat.Click += BtnEat_Click;
            // 
            // DateTimePickerMeal
            // 
            DateTimePickerMeal.Format = DateTimePickerFormat.Short;
            DateTimePickerMeal.Location = new Point(84, 25);
            DateTimePickerMeal.Name = "DateTimePickerMeal";
            DateTimePickerMeal.Size = new Size(124, 27);
            DateTimePickerMeal.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 4);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 1;
            label4.Text = "Agendar platillo";
            // 
            // PanelAddMeal
            // 
            PanelAddMeal.BackColor = SystemColors.ButtonHighlight;
            PanelAddMeal.Controls.Add(BtnSaveMeal);
            PanelAddMeal.Controls.Add(BtnTimeMeal);
            PanelAddMeal.Controls.Add(label7);
            PanelAddMeal.Controls.Add(TxtNameMeal);
            PanelAddMeal.Controls.Add(label6);
            PanelAddMeal.Controls.Add(label5);
            PanelAddMeal.Location = new Point(5, 279);
            PanelAddMeal.Name = "PanelAddMeal";
            PanelAddMeal.Size = new Size(403, 113);
            PanelAddMeal.TabIndex = 9;
            // 
            // BtnSaveMeal
            // 
            BtnSaveMeal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSaveMeal.ForeColor = Color.Blue;
            BtnSaveMeal.Location = new Point(136, 75);
            BtnSaveMeal.Name = "BtnSaveMeal";
            BtnSaveMeal.Size = new Size(130, 36);
            BtnSaveMeal.TabIndex = 11;
            BtnSaveMeal.Text = "Agregar";
            BtnSaveMeal.UseVisualStyleBackColor = true;
            BtnSaveMeal.Click += BtnSaveMeal_Click;
            // 
            // BtnTimeMeal
            // 
            BtnTimeMeal.FormattingEnabled = true;
            BtnTimeMeal.Items.AddRange(new object[] { "Desayuno", "Almuerzo", "Cena" });
            BtnTimeMeal.Location = new Point(203, 45);
            BtnTimeMeal.Name = "BtnTimeMeal";
            BtnTimeMeal.Size = new Size(189, 28);
            BtnTimeMeal.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(230, 23);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 4;
            label7.Text = "Tiempo de comida";
            // 
            // TxtNameMeal
            // 
            TxtNameMeal.Location = new Point(10, 46);
            TxtNameMeal.Name = "TxtNameMeal";
            TxtNameMeal.Size = new Size(183, 27);
            TxtNameMeal.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 23);
            label6.Name = "label6";
            label6.Size = new Size(186, 20);
            label6.TabIndex = 2;
            label6.Text = "Definir nombre del platillo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(156, 3);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 1;
            label5.Text = "Agregar platillo";
            // 
            // PanelEditMeal
            // 
            PanelEditMeal.BackColor = SystemColors.ButtonHighlight;
            PanelEditMeal.Controls.Add(BtnProduct);
            PanelEditMeal.Controls.Add(BtnAddProduct);
            PanelEditMeal.Controls.Add(BtnDeleteProduct);
            PanelEditMeal.Controls.Add(label8);
            PanelEditMeal.Location = new Point(5, 394);
            PanelEditMeal.Name = "PanelEditMeal";
            PanelEditMeal.Size = new Size(403, 65);
            PanelEditMeal.TabIndex = 10;
            // 
            // BtnProduct
            // 
            BtnProduct.FormattingEnabled = true;
            BtnProduct.Location = new Point(7, 25);
            BtnProduct.Name = "BtnProduct";
            BtnProduct.Size = new Size(124, 28);
            BtnProduct.TabIndex = 13;
            BtnProduct.Text = "Productos";
            BtnProduct.SelectedIndexChanged += BtnProduct_SelectedIndexChanged;
            // 
            // BtnAddProduct
            // 
            BtnAddProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAddProduct.ForeColor = Color.Blue;
            BtnAddProduct.Location = new Point(136, 22);
            BtnAddProduct.Name = "BtnAddProduct";
            BtnAddProduct.Size = new Size(130, 36);
            BtnAddProduct.TabIndex = 12;
            BtnAddProduct.Text = "Agregar";
            BtnAddProduct.UseVisualStyleBackColor = true;
            BtnAddProduct.Click += BtnAddProduct_Click;
            // 
            // BtnDeleteProduct
            // 
            BtnDeleteProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDeleteProduct.ForeColor = Color.Red;
            BtnDeleteProduct.Location = new Point(267, 22);
            BtnDeleteProduct.Name = "BtnDeleteProduct";
            BtnDeleteProduct.Size = new Size(130, 36);
            BtnDeleteProduct.TabIndex = 9;
            BtnDeleteProduct.Text = "Eliminar";
            BtnDeleteProduct.UseVisualStyleBackColor = true;
            BtnDeleteProduct.Click += BtnDeleteProduct_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(108, 2);
            label8.Name = "label8";
            label8.Size = new Size(195, 20);
            label8.TabIndex = 1;
            label8.Text = "Editar productos del platillo";
            // 
            // MealManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 462);
            Controls.Add(PanelEditMeal);
            Controls.Add(PanelAddMeal);
            Controls.Add(PanelScheduleMeal);
            Controls.Add(PanelMealInfo);
            Controls.Add(PanelMeals);
            Controls.Add(labelProducts);
            Controls.Add(BtnBack);
            Controls.Add(labelTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MealManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriTrack System";
            Load += MealManagementForm_Load;
            PanelMeals.ResumeLayout(false);
            PanelMeals.PerformLayout();
            PanelMealInfo.ResumeLayout(false);
            PanelMealInfo.PerformLayout();
            PanelScheduleMeal.ResumeLayout(false);
            PanelScheduleMeal.PerformLayout();
            PanelAddMeal.ResumeLayout(false);
            PanelAddMeal.PerformLayout();
            PanelEditMeal.ResumeLayout(false);
            PanelEditMeal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Button BtnBack;
        private Label labelProducts;
        private Panel PanelMeals;
        private Label label1;
        private Panel PanelMealInfo;
        private Label TxtMealInfo;
        private Button BtnDeleteMeal;
        private Button BtnEdit;
        private ComboBox BtnMeals;
        private Button BtnSchedule;
        private Button BtnAddMeal;
        private Label label3;
        private Panel PanelScheduleMeal;
        private Label label4;
        private Button BtnEat;
        private DateTimePicker DateTimePickerMeal;
        private Panel PanelAddMeal;
        private TextBox TxtNameMeal;
        private Label label6;
        private Label label5;
        private ComboBox BtnTimeMeal;
        private Label label7;
        private Button BtnSaveMeal;
        private Panel PanelEditMeal;
        private Button BtnAddProduct;
        private Button BtnDeleteProduct;
        private Label label8;
        private ComboBox BtnProduct;
    }
}