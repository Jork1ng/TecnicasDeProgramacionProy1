namespace NutriTrackSystem.Views
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            labelTitulo = new Label();
            labelBienvenido = new Label();
            LableUser = new Label();
            BtnLogOut = new Button();
            ButtonInfo = new Button();
            ButtonMenu = new Button();
            ButtonProduct = new Button();
            ButtonStatics = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(232, 10);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(138, 20);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "NutriTrack System";
            labelTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelBienvenido
            // 
            labelBienvenido.AutoSize = true;
            labelBienvenido.Location = new Point(258, 40);
            labelBienvenido.Name = "labelBienvenido";
            labelBienvenido.Size = new Size(86, 20);
            labelBienvenido.TabIndex = 2;
            labelBienvenido.Text = "Bienvenido,";
            // 
            // LableUser
            // 
            LableUser.AutoSize = true;
            LableUser.Location = new Point(270, 60);
            LableUser.Name = "LableUser";
            LableUser.Size = new Size(59, 20);
            LableUser.TabIndex = 3;
            LableUser.Text = "Usuario";
            LableUser.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnLogOut
            // 
            BtnLogOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogOut.ForeColor = Color.Red;
            BtnLogOut.Location = new Point(208, 362);
            BtnLogOut.Name = "BtnLogOut";
            BtnLogOut.Size = new Size(178, 34);
            BtnLogOut.TabIndex = 7;
            BtnLogOut.Text = "Cerrar Sesion";
            BtnLogOut.UseVisualStyleBackColor = true;
            // 
            // ButtonInfo
            // 
            ButtonInfo.Location = new Point(175, 113);
            ButtonInfo.Name = "ButtonInfo";
            ButtonInfo.Size = new Size(242, 44);
            ButtonInfo.TabIndex = 8;
            ButtonInfo.Text = "Ver informacion";
            ButtonInfo.UseVisualStyleBackColor = true;
            ButtonInfo.Click += ButtonInfo_Click;
            // 
            // ButtonMenu
            // 
            ButtonMenu.Location = new Point(175, 173);
            ButtonMenu.Name = "ButtonMenu";
            ButtonMenu.Size = new Size(242, 44);
            ButtonMenu.TabIndex = 9;
            ButtonMenu.Text = "Gestionar menus";
            ButtonMenu.UseVisualStyleBackColor = true;
            // 
            // ButtonProduct
            // 
            ButtonProduct.Location = new Point(175, 234);
            ButtonProduct.Name = "ButtonProduct";
            ButtonProduct.Size = new Size(242, 44);
            ButtonProduct.TabIndex = 10;
            ButtonProduct.Text = "Gestionar productos";
            ButtonProduct.UseVisualStyleBackColor = true;
            ButtonProduct.Click += ButtonProduct_Click;
            // 
            // ButtonStatics
            // 
            ButtonStatics.Location = new Point(175, 296);
            ButtonStatics.Name = "ButtonStatics";
            ButtonStatics.Size = new Size(242, 44);
            ButtonStatics.TabIndex = 11;
            ButtonStatics.Text = "Estadisticas";
            ButtonStatics.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 462);
            Controls.Add(ButtonStatics);
            Controls.Add(ButtonProduct);
            Controls.Add(ButtonMenu);
            Controls.Add(ButtonInfo);
            Controls.Add(BtnLogOut);
            Controls.Add(LableUser);
            Controls.Add(labelBienvenido);
            Controls.Add(labelTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriTrack System";
            Load += HomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelBienvenido;
        private Label LableUser;
        private Button BtnLogOut;
        private Button ButtonInfo;
        private Button ButtonMenu;
        private Button ButtonProduct;
        private Button ButtonStatics;
    }
}