namespace NutriTrackSystem.Views
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            labelTitulo = new Label();
            labelBienvenido = new Label();
            TxtNombreUsuario = new TextBox();
            TxtContraseña = new TextBox();
            labelPreguntaRegistro = new Label();
            BotonRegistro = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(232, 10);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(138, 20);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "NutriTrack System";
            labelTitulo.TextAlign = ContentAlignment.TopCenter;
            labelTitulo.Click += Label1_Click;
            // 
            // labelBienvenido
            // 
            labelBienvenido.AutoSize = true;
            labelBienvenido.Location = new Point(258, 40);
            labelBienvenido.Name = "labelBienvenido";
            labelBienvenido.Size = new Size(83, 20);
            labelBienvenido.TabIndex = 1;
            labelBienvenido.Text = "Bienvenido";
            labelBienvenido.Click += Label1_Click_1;
            // 
            // TxtNombreUsuario
            // 
            TxtNombreUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TxtNombreUsuario.Location = new Point(150, 74);
            TxtNombreUsuario.Name = "TxtNombreUsuario";
            TxtNombreUsuario.PlaceholderText = "Usuario";
            TxtNombreUsuario.Size = new Size(300, 27);
            TxtNombreUsuario.TabIndex = 2;
            TxtNombreUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtContraseña
            // 
            TxtContraseña.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TxtContraseña.Location = new Point(150, 125);
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.PlaceholderText = "Contraseña";
            TxtContraseña.Size = new Size(300, 27);
            TxtContraseña.TabIndex = 3;
            TxtContraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // labelPreguntaRegistro
            // 
            labelPreguntaRegistro.AutoSize = true;
            labelPreguntaRegistro.Location = new Point(168, 184);
            labelPreguntaRegistro.Name = "labelPreguntaRegistro";
            labelPreguntaRegistro.Size = new Size(264, 20);
            labelPreguntaRegistro.TabIndex = 4;
            labelPreguntaRegistro.Text = "¿Eres nuevo en NutriTrack? ¡Regístrate!";
            labelPreguntaRegistro.Click += Label1_Click_2;
            // 
            // BotonRegistro
            // 
            BotonRegistro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonRegistro.ForeColor = Color.Lime;
            BotonRegistro.Location = new Point(207, 238);
            BotonRegistro.Name = "BotonRegistro";
            BotonRegistro.Size = new Size(178, 34);
            BotonRegistro.TabIndex = 5;
            BotonRegistro.Text = "Registrarse";
            BotonRegistro.UseVisualStyleBackColor = true;
            BotonRegistro.Click += BotonRegistro_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(583, 462);
            Controls.Add(BotonRegistro);
            Controls.Add(labelPreguntaRegistro);
            Controls.Add(TxtContraseña);
            Controls.Add(TxtNombreUsuario);
            Controls.Add(labelBienvenido);
            Controls.Add(labelTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriTrack System";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelBienvenido;
        private TextBox TxtNombreUsuario;
        private TextBox TxtContraseña;
        private Label labelPreguntaRegistro;
        private Button BotonRegistro;
    }
}
