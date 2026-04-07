namespace NutriTrackSystem.Views
{
    partial class ProductManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagementForm));
            labelTitulo = new Label();
            labelProducts = new Label();
            BtnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtCarbo = new TextBox();
            label4 = new Label();
            TxtFat = new TextBox();
            TxtProtein = new TextBox();
            TxtProductName = new TextBox();
            BtnSave = new Button();
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
            // labelProducts
            // 
            labelProducts.AutoSize = true;
            labelProducts.Location = new Point(226, 40);
            labelProducts.Name = "labelProducts";
            labelProducts.Size = new Size(150, 20);
            labelProducts.TabIndex = 2;
            labelProducts.Text = "Ingreso de productos";
            // 
            // BtnBack
            // 
            BtnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBack.Location = new Point(450, 10);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(130, 36);
            BtnBack.TabIndex = 3;
            BtnBack.Text = "Volver";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 74);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre del producto";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 137);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 6;
            label2.Text = "Proteina por cada 100g";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 204);
            label3.Name = "label3";
            label3.Size = new Size(152, 20);
            label3.TabIndex = 8;
            label3.Text = "Grasas por cada 100g";
            // 
            // TxtCarbo
            // 
            TxtCarbo.Location = new Point(199, 295);
            TxtCarbo.Name = "TxtCarbo";
            TxtCarbo.Size = new Size(203, 27);
            TxtCarbo.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(199, 272);
            label4.Name = "label4";
            label4.Size = new Size(203, 20);
            label4.TabIndex = 10;
            label4.Text = "Carbohidratos por cada 100g";
            // 
            // TxtFat
            // 
            TxtFat.Location = new Point(199, 227);
            TxtFat.Name = "TxtFat";
            TxtFat.Size = new Size(203, 27);
            TxtFat.TabIndex = 12;
            // 
            // TxtProtein
            // 
            TxtProtein.Location = new Point(199, 160);
            TxtProtein.Name = "TxtProtein";
            TxtProtein.Size = new Size(203, 27);
            TxtProtein.TabIndex = 13;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(199, 97);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(203, 27);
            TxtProductName.TabIndex = 14;
            // 
            // BtnSave
            // 
            BtnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSave.ForeColor = Color.Lime;
            BtnSave.Location = new Point(232, 344);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(130, 36);
            BtnSave.TabIndex = 15;
            BtnSave.Text = "Guardar";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 462);
            Controls.Add(BtnSave);
            Controls.Add(TxtProductName);
            Controls.Add(TxtProtein);
            Controls.Add(TxtFat);
            Controls.Add(TxtCarbo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnBack);
            Controls.Add(labelProducts);
            Controls.Add(labelTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProductManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriTrack System";
            Load += ProductManagementForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelProducts;
        private Button BtnBack;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtCarbo;
        private Label label4;
        private TextBox TxtFat;
        private TextBox TxtProtein;
        private TextBox TxtProductName;
        private Button BtnSave;
    }
}