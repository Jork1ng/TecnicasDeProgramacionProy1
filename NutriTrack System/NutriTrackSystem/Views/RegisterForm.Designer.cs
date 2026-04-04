namespace NutriTrackSystem.Views
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            LabelNombreDeUsuario = new Label();
            labelTitulo = new Label();
            LabelEscribaElNombreDeUsuario = new Label();
            LabelCreaUnaContraseña = new Label();
            TxtUsuario = new TextBox();
            TxtContraseña = new TextBox();
            LabelIngreseSuPeso = new Label();
            TxtAltura = new Label();
            LabelActividadFisica = new Label();
            ComboBoxActividadFisica = new ComboBox();
            LabelTipoDeDieta = new Label();
            ComboBoxTipoDeDieta = new ComboBox();
            ComboBoxMeta = new ComboBox();
            LabelMeta = new Label();
            BotonRegistro = new Button();
            TxtWeight = new TextBox();
            TxtHeight = new TextBox();
            SuspendLayout();
            // 
            // LabelNombreDeUsuario
            // 
            LabelNombreDeUsuario.AutoSize = true;
            LabelNombreDeUsuario.Location = new Point(183, 30);
            LabelNombreDeUsuario.Name = "LabelNombreDeUsuario";
            LabelNombreDeUsuario.Size = new Size(240, 20);
            LabelNombreDeUsuario.TabIndex = 3;
            LabelNombreDeUsuario.Text = "Bienvenido a la sección de registro";
            LabelNombreDeUsuario.Click += LabelBienvenido_Click;
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
            // LabelEscribaElNombreDeUsuario
            // 
            LabelEscribaElNombreDeUsuario.AutoSize = true;
            LabelEscribaElNombreDeUsuario.Location = new Point(203, 65);
            LabelEscribaElNombreDeUsuario.Name = "LabelEscribaElNombreDeUsuario";
            LabelEscribaElNombreDeUsuario.Size = new Size(201, 20);
            LabelEscribaElNombreDeUsuario.TabIndex = 4;
            LabelEscribaElNombreDeUsuario.Text = "Escriba el nombre de usuario";
            LabelEscribaElNombreDeUsuario.Click += LabelEscribaElNombreDeUsuario_Click;
            // 
            // LabelCreaUnaContraseña
            // 
            LabelCreaUnaContraseña.AutoSize = true;
            LabelCreaUnaContraseña.Location = new Point(229, 127);
            LabelCreaUnaContraseña.Name = "LabelCreaUnaContraseña";
            LabelCreaUnaContraseña.Size = new Size(143, 20);
            LabelCreaUnaContraseña.TabIndex = 5;
            LabelCreaUnaContraseña.Text = "Crea una contraseña";
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(215, 88);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.PlaceholderText = "Nombre de Usuario";
            TxtUsuario.Size = new Size(176, 27);
            TxtUsuario.TabIndex = 6;
            TxtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtContraseña
            // 
            TxtContraseña.Location = new Point(215, 150);
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.PlaceholderText = "Contraseña";
            TxtContraseña.Size = new Size(176, 27);
            TxtContraseña.TabIndex = 7;
            TxtContraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelIngreseSuPeso
            // 
            LabelIngreseSuPeso.AutoSize = true;
            LabelIngreseSuPeso.Location = new Point(229, 196);
            LabelIngreseSuPeso.Name = "LabelIngreseSuPeso";
            LabelIngreseSuPeso.Size = new Size(153, 20);
            LabelIngreseSuPeso.TabIndex = 8;
            LabelIngreseSuPeso.Text = "Ingrese su peso en KG";
            // 
            // TxtAltura
            // 
            TxtAltura.AutoSize = true;
            TxtAltura.Location = new Point(220, 265);
            TxtAltura.Name = "TxtAltura";
            TxtAltura.Size = new Size(163, 20);
            TxtAltura.TabIndex = 11;
            TxtAltura.Text = "Ingrese su altura en CM";
            TxtAltura.Click += TxtAltura_Click;
            // 
            // LabelActividadFisica
            // 
            LabelActividadFisica.AutoSize = true;
            LabelActividadFisica.Location = new Point(247, 333);
            LabelActividadFisica.Name = "LabelActividadFisica";
            LabelActividadFisica.Size = new Size(112, 20);
            LabelActividadFisica.TabIndex = 13;
            LabelActividadFisica.Text = "Actividad Fisica";
            LabelActividadFisica.Click += LabelActividadFisica_Click;
            // 
            // ComboBoxActividadFisica
            // 
            ComboBoxActividadFisica.FormattingEnabled = true;
            ComboBoxActividadFisica.Items.AddRange(new object[] { "Intensa", "Moderada", "Minima" });
            ComboBoxActividadFisica.Location = new Point(215, 356);
            ComboBoxActividadFisica.Name = "ComboBoxActividadFisica";
            ComboBoxActividadFisica.Size = new Size(176, 28);
            ComboBoxActividadFisica.TabIndex = 14;
            // 
            // LabelTipoDeDieta
            // 
            LabelTipoDeDieta.AutoSize = true;
            LabelTipoDeDieta.Location = new Point(432, 333);
            LabelTipoDeDieta.Name = "LabelTipoDeDieta";
            LabelTipoDeDieta.Size = new Size(100, 20);
            LabelTipoDeDieta.TabIndex = 15;
            LabelTipoDeDieta.Text = "Tipo de Dieta";
            // 
            // ComboBoxTipoDeDieta
            // 
            ComboBoxTipoDeDieta.FormattingEnabled = true;
            ComboBoxTipoDeDieta.Items.AddRange(new object[] { "Estandar", "Keto", "Vegetariana" });
            ComboBoxTipoDeDieta.Location = new Point(397, 356);
            ComboBoxTipoDeDieta.Name = "ComboBoxTipoDeDieta";
            ComboBoxTipoDeDieta.Size = new Size(176, 28);
            ComboBoxTipoDeDieta.TabIndex = 16;
            // 
            // ComboBoxMeta
            // 
            ComboBoxMeta.FormattingEnabled = true;
            ComboBoxMeta.Items.AddRange(new object[] { "Mantener", "Perder grasa", "Ganar masa" });
            ComboBoxMeta.Location = new Point(33, 356);
            ComboBoxMeta.Name = "ComboBoxMeta";
            ComboBoxMeta.Size = new Size(176, 28);
            ComboBoxMeta.TabIndex = 17;
            ComboBoxMeta.SelectedIndexChanged += ComboBoxMeta_SelectedIndexChanged;
            // 
            // LabelMeta
            // 
            LabelMeta.AutoSize = true;
            LabelMeta.Location = new Point(97, 333);
            LabelMeta.Name = "LabelMeta";
            LabelMeta.Size = new Size(43, 20);
            LabelMeta.TabIndex = 18;
            LabelMeta.Text = "Meta";
            // 
            // BotonRegistro
            // 
            BotonRegistro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonRegistro.ForeColor = Color.Lime;
            BotonRegistro.Location = new Point(214, 399);
            BotonRegistro.Name = "BotonRegistro";
            BotonRegistro.Size = new Size(178, 34);
            BotonRegistro.TabIndex = 19;
            BotonRegistro.Text = "Registrarse";
            BotonRegistro.UseVisualStyleBackColor = true;
            BotonRegistro.Click += BotonRegistro_Click;
            // 
            // TxtWeight
            // 
            TxtWeight.Location = new Point(211, 219);
            TxtWeight.Name = "TxtWeight";
            TxtWeight.PlaceholderText = "Peso";
            TxtWeight.Size = new Size(178, 27);
            TxtWeight.TabIndex = 20;
            TxtWeight.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtHeight
            // 
            TxtHeight.Location = new Point(211, 288);
            TxtHeight.Name = "TxtHeight";
            TxtHeight.PlaceholderText = "Altura";
            TxtHeight.Size = new Size(178, 27);
            TxtHeight.TabIndex = 21;
            TxtHeight.TextAlign = HorizontalAlignment.Center;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 462);
            Controls.Add(TxtHeight);
            Controls.Add(TxtWeight);
            Controls.Add(BotonRegistro);
            Controls.Add(LabelMeta);
            Controls.Add(ComboBoxMeta);
            Controls.Add(ComboBoxTipoDeDieta);
            Controls.Add(LabelTipoDeDieta);
            Controls.Add(ComboBoxActividadFisica);
            Controls.Add(LabelActividadFisica);
            Controls.Add(TxtAltura);
            Controls.Add(LabelIngreseSuPeso);
            Controls.Add(TxtContraseña);
            Controls.Add(TxtUsuario);
            Controls.Add(LabelCreaUnaContraseña);
            Controls.Add(LabelEscribaElNombreDeUsuario);
            Controls.Add(LabelNombreDeUsuario);
            Controls.Add(labelTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriTrack System";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNombreDeUsuario;
        private Label labelTitulo;
        private Label LabelEscribaElNombreDeUsuario;
        private Label LabelCreaUnaContraseña;
        private TextBox TxtUsuario;
        private TextBox TxtContraseña;
        private Label LabelIngreseSuPeso;
        private Label TxtAltura;
        private Label LabelActividadFisica;
        private ComboBox ComboBoxActividadFisica;
        private Label LabelTipoDeDieta;
        private ComboBox ComboBoxTipoDeDieta;
        private ComboBox ComboBoxMeta;
        private Label LabelMeta;
        private Button BotonRegistro;
        private TextBox TxtWeight;
        private TextBox TxtHeight;
    }
}