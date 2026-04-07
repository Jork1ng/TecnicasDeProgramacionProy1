namespace NutriTrackSystem.Views
{
    partial class UserInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfoForm));
            labelTitulo = new Label();
            labelProducts = new Label();
            BtnBack = new Button();
            TxtHeight = new TextBox();
            TxtWeight = new TextBox();
            LabelMeta = new Label();
            ComboBoxMeta = new ComboBox();
            ComboBoxTipoDeDieta = new ComboBox();
            LabelTipoDeDieta = new Label();
            ComboBoxActividadFisica = new ComboBox();
            LabelActividadFisica = new Label();
            TxtAltura = new Label();
            LabelIngreseSuPeso = new Label();
            TxtImc = new Label();
            TxtGoal = new Label();
            TxtFatResult = new Label();
            TxtCarboResult = new Label();
            TxtProteinResult = new Label();
            TxtFat = new Label();
            TxtCarbo = new Label();
            TxtProtein = new Label();
            TxtImcResult = new Label();
            BtnSave = new Button();
            TxtGoalResult = new Label();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(232, 10);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(138, 20);
            labelTitulo.TabIndex = 4;
            labelTitulo.Text = "NutriTrack System";
            labelTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelProducts
            // 
            labelProducts.AutoSize = true;
            labelProducts.Location = new Point(258, 40);
            labelProducts.Name = "labelProducts";
            labelProducts.Size = new Size(89, 20);
            labelProducts.TabIndex = 7;
            labelProducts.Text = "Informacion";
            // 
            // BtnBack
            // 
            BtnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBack.Location = new Point(450, 10);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(130, 36);
            BtnBack.TabIndex = 8;
            BtnBack.Text = "Volver";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // TxtHeight
            // 
            TxtHeight.Location = new Point(214, 133);
            TxtHeight.Name = "TxtHeight";
            TxtHeight.PlaceholderText = "Altura";
            TxtHeight.Size = new Size(178, 27);
            TxtHeight.TabIndex = 31;
            TxtHeight.TextAlign = HorizontalAlignment.Center;
            TxtHeight.TextChanged += TxtHeight_TextChanged;
            // 
            // TxtWeight
            // 
            TxtWeight.Location = new Point(214, 81);
            TxtWeight.Name = "TxtWeight";
            TxtWeight.PlaceholderText = "Peso";
            TxtWeight.Size = new Size(178, 27);
            TxtWeight.TabIndex = 30;
            TxtWeight.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelMeta
            // 
            LabelMeta.AutoSize = true;
            LabelMeta.Location = new Point(279, 164);
            LabelMeta.Name = "LabelMeta";
            LabelMeta.Size = new Size(43, 20);
            LabelMeta.TabIndex = 29;
            LabelMeta.Text = "Meta";
            // 
            // ComboBoxMeta
            // 
            ComboBoxMeta.FormattingEnabled = true;
            ComboBoxMeta.Items.AddRange(new object[] { "Mantener", "Perder grasa", "Ganar masa" });
            ComboBoxMeta.Location = new Point(215, 184);
            ComboBoxMeta.Name = "ComboBoxMeta";
            ComboBoxMeta.Size = new Size(176, 28);
            ComboBoxMeta.TabIndex = 28;
            // 
            // ComboBoxTipoDeDieta
            // 
            ComboBoxTipoDeDieta.FormattingEnabled = true;
            ComboBoxTipoDeDieta.Items.AddRange(new object[] { "Estandar", "Keto", "Vegetariana" });
            ComboBoxTipoDeDieta.Location = new Point(217, 287);
            ComboBoxTipoDeDieta.Name = "ComboBoxTipoDeDieta";
            ComboBoxTipoDeDieta.Size = new Size(176, 28);
            ComboBoxTipoDeDieta.TabIndex = 27;
            // 
            // LabelTipoDeDieta
            // 
            LabelTipoDeDieta.AutoSize = true;
            LabelTipoDeDieta.Location = new Point(248, 266);
            LabelTipoDeDieta.Name = "LabelTipoDeDieta";
            LabelTipoDeDieta.Size = new Size(100, 20);
            LabelTipoDeDieta.TabIndex = 26;
            LabelTipoDeDieta.Text = "Tipo de Dieta";
            // 
            // ComboBoxActividadFisica
            // 
            ComboBoxActividadFisica.FormattingEnabled = true;
            ComboBoxActividadFisica.Items.AddRange(new object[] { "Intensa", "Moderada", "Minima" });
            ComboBoxActividadFisica.Location = new Point(216, 235);
            ComboBoxActividadFisica.Name = "ComboBoxActividadFisica";
            ComboBoxActividadFisica.Size = new Size(176, 28);
            ComboBoxActividadFisica.TabIndex = 25;
            // 
            // LabelActividadFisica
            // 
            LabelActividadFisica.AutoSize = true;
            LabelActividadFisica.Location = new Point(248, 215);
            LabelActividadFisica.Name = "LabelActividadFisica";
            LabelActividadFisica.Size = new Size(112, 20);
            LabelActividadFisica.TabIndex = 24;
            LabelActividadFisica.Text = "Actividad Fisica";
            // 
            // TxtAltura
            // 
            TxtAltura.AutoSize = true;
            TxtAltura.Location = new Point(223, 111);
            TxtAltura.Name = "TxtAltura";
            TxtAltura.Size = new Size(163, 20);
            TxtAltura.TabIndex = 23;
            TxtAltura.Text = "Ingrese su altura en CM";
            // 
            // LabelIngreseSuPeso
            // 
            LabelIngreseSuPeso.AutoSize = true;
            LabelIngreseSuPeso.Location = new Point(232, 60);
            LabelIngreseSuPeso.Name = "LabelIngreseSuPeso";
            LabelIngreseSuPeso.Size = new Size(153, 20);
            LabelIngreseSuPeso.TabIndex = 22;
            LabelIngreseSuPeso.Text = "Ingrese su peso en KG";
            // 
            // TxtImc
            // 
            TxtImc.AutoSize = true;
            TxtImc.Location = new Point(197, 316);
            TxtImc.Name = "TxtImc";
            TxtImc.Size = new Size(38, 20);
            TxtImc.TabIndex = 32;
            TxtImc.Text = "IMC:";
            // 
            // TxtGoal
            // 
            TxtGoal.AutoSize = true;
            TxtGoal.Location = new Point(197, 336);
            TxtGoal.Name = "TxtGoal";
            TxtGoal.Size = new Size(170, 20);
            TxtGoal.TabIndex = 33;
            TxtGoal.Text = "Meta de calorias diarias:";
            // 
            // TxtFatResult
            // 
            TxtFatResult.AutoSize = true;
            TxtFatResult.Location = new Point(385, 400);
            TxtFatResult.Name = "TxtFatResult";
            TxtFatResult.Size = new Size(21, 20);
            TxtFatResult.TabIndex = 39;
            TxtFatResult.Text = "%";
            // 
            // TxtCarboResult
            // 
            TxtCarboResult.AutoSize = true;
            TxtCarboResult.Location = new Point(385, 376);
            TxtCarboResult.Name = "TxtCarboResult";
            TxtCarboResult.Size = new Size(21, 20);
            TxtCarboResult.TabIndex = 38;
            TxtCarboResult.Text = "%";
            // 
            // TxtProteinResult
            // 
            TxtProteinResult.AutoSize = true;
            TxtProteinResult.Location = new Point(385, 356);
            TxtProteinResult.Name = "TxtProteinResult";
            TxtProteinResult.Size = new Size(21, 20);
            TxtProteinResult.TabIndex = 37;
            TxtProteinResult.Text = "%";
            // 
            // TxtFat
            // 
            TxtFat.AutoSize = true;
            TxtFat.Location = new Point(197, 400);
            TxtFat.Name = "TxtFat";
            TxtFat.Size = new Size(52, 20);
            TxtFat.TabIndex = 36;
            TxtFat.Text = "Grasas";
            // 
            // TxtCarbo
            // 
            TxtCarbo.AutoSize = true;
            TxtCarbo.Location = new Point(197, 376);
            TxtCarbo.Name = "TxtCarbo";
            TxtCarbo.Size = new Size(103, 20);
            TxtCarbo.TabIndex = 35;
            TxtCarbo.Text = "Carbohidratos";
            // 
            // TxtProtein
            // 
            TxtProtein.AutoSize = true;
            TxtProtein.Location = new Point(197, 356);
            TxtProtein.Name = "TxtProtein";
            TxtProtein.Size = new Size(70, 20);
            TxtProtein.TabIndex = 34;
            TxtProtein.Text = "Proteinas";
            // 
            // TxtImcResult
            // 
            TxtImcResult.AutoSize = true;
            TxtImcResult.Location = new Point(384, 316);
            TxtImcResult.Name = "TxtImcResult";
            TxtImcResult.Size = new Size(21, 20);
            TxtImcResult.TabIndex = 40;
            TxtImcResult.Text = "%";
            // 
            // BtnSave
            // 
            BtnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSave.ForeColor = Color.Lime;
            BtnSave.Location = new Point(232, 421);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(130, 36);
            BtnSave.TabIndex = 41;
            BtnSave.Text = "Guardar";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // TxtGoalResult
            // 
            TxtGoalResult.AutoSize = true;
            TxtGoalResult.Location = new Point(385, 336);
            TxtGoalResult.Name = "TxtGoalResult";
            TxtGoalResult.Size = new Size(21, 20);
            TxtGoalResult.TabIndex = 42;
            TxtGoalResult.Text = "%";
            // 
            // UserInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 462);
            Controls.Add(TxtGoalResult);
            Controls.Add(BtnSave);
            Controls.Add(TxtImcResult);
            Controls.Add(TxtFatResult);
            Controls.Add(TxtCarboResult);
            Controls.Add(TxtProteinResult);
            Controls.Add(TxtFat);
            Controls.Add(TxtCarbo);
            Controls.Add(TxtProtein);
            Controls.Add(TxtGoal);
            Controls.Add(TxtImc);
            Controls.Add(TxtHeight);
            Controls.Add(TxtWeight);
            Controls.Add(LabelMeta);
            Controls.Add(ComboBoxMeta);
            Controls.Add(ComboBoxTipoDeDieta);
            Controls.Add(LabelTipoDeDieta);
            Controls.Add(ComboBoxActividadFisica);
            Controls.Add(LabelActividadFisica);
            Controls.Add(TxtAltura);
            Controls.Add(LabelIngreseSuPeso);
            Controls.Add(BtnBack);
            Controls.Add(labelProducts);
            Controls.Add(labelTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriTrack Systm";
            Load += UserInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelProducts;
        private Button BtnBack;
        private TextBox TxtHeight;
        private TextBox TxtWeight;
        private Label LabelMeta;
        private ComboBox ComboBoxMeta;
        private ComboBox ComboBoxTipoDeDieta;
        private Label LabelTipoDeDieta;
        private ComboBox ComboBoxActividadFisica;
        private Label LabelActividadFisica;
        private Label TxtAltura;
        private Label LabelIngreseSuPeso;
        private Label TxtImc;
        private Label TxtGoal;
        private Label TxtFatResult;
        private Label TxtCarboResult;
        private Label TxtProteinResult;
        private Label TxtFat;
        private Label TxtCarbo;
        private Label TxtProtein;
        private Label TxtImcResult;
        private Button BtnSave;
        private Label TxtGoalResult;
    }
}