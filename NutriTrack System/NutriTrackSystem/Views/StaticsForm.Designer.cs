namespace NutriTrackSystem.Views
{
    partial class StaticsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaticsForm));
            labelTitulo = new Label();
            BtnBack = new Button();
            labelProducts = new Label();
            PanelCalc = new Panel();
            BtnCalc = new Button();
            TxtDateEnd = new Label();
            DataTimePickEnd = new DateTimePicker();
            TxtDateStart = new Label();
            DataTimePickStart = new DateTimePicker();
            PanelResult = new Panel();
            TxtDayCompliance = new Label();
            TxtDayComplianceResult = new Label();
            TxtDayCaloriesConsumeResult = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            PanelMacro = new Panel();
            TxtConsumedFat = new Label();
            TxtConsumedCarbo = new Label();
            TxtIdealFat = new Label();
            TxtConsumedProtein = new Label();
            TxtIdealCarbo = new Label();
            TxtIdealProtein = new Label();
            label15 = new Label();
            TxtFat = new Label();
            TxtCarbo = new Label();
            TxtProtein = new Label();
            label11 = new Label();
            label3 = new Label();
            PanelCalc.SuspendLayout();
            PanelResult.SuspendLayout();
            PanelMacro.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(232, 10);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(138, 20);
            labelTitulo.TabIndex = 3;
            labelTitulo.Text = "NutriTrack System";
            labelTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnBack
            // 
            BtnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBack.Location = new Point(450, 10);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(130, 36);
            BtnBack.TabIndex = 5;
            BtnBack.Text = "Volver";
            BtnBack.UseVisualStyleBackColor = true;
            // 
            // labelProducts
            // 
            labelProducts.AutoSize = true;
            labelProducts.Location = new Point(263, 40);
            labelProducts.Name = "labelProducts";
            labelProducts.Size = new Size(85, 20);
            labelProducts.TabIndex = 6;
            labelProducts.Text = "Estadisticas";
            // 
            // PanelCalc
            // 
            PanelCalc.BackColor = SystemColors.ButtonHighlight;
            PanelCalc.Controls.Add(BtnCalc);
            PanelCalc.Controls.Add(TxtDateEnd);
            PanelCalc.Controls.Add(DataTimePickEnd);
            PanelCalc.Controls.Add(TxtDateStart);
            PanelCalc.Controls.Add(DataTimePickStart);
            PanelCalc.Location = new Point(14, 68);
            PanelCalc.Name = "PanelCalc";
            PanelCalc.Size = new Size(554, 67);
            PanelCalc.TabIndex = 7;
            // 
            // BtnCalc
            // 
            BtnCalc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCalc.ForeColor = Color.Lime;
            BtnCalc.Location = new Point(363, 19);
            BtnCalc.Name = "BtnCalc";
            BtnCalc.Size = new Size(130, 36);
            BtnCalc.TabIndex = 6;
            BtnCalc.Text = "Calcular";
            BtnCalc.UseVisualStyleBackColor = true;
            // 
            // TxtDateEnd
            // 
            TxtDateEnd.AutoSize = true;
            TxtDateEnd.Location = new Point(171, 5);
            TxtDateEnd.Name = "TxtDateEnd";
            TxtDateEnd.Size = new Size(80, 20);
            TxtDateEnd.TabIndex = 3;
            TxtDateEnd.Text = "Fecha final";
            // 
            // DataTimePickEnd
            // 
            DataTimePickEnd.Format = DateTimePickerFormat.Short;
            DataTimePickEnd.Location = new Point(168, 28);
            DataTimePickEnd.Name = "DataTimePickEnd";
            DataTimePickEnd.Size = new Size(126, 27);
            DataTimePickEnd.TabIndex = 2;
            // 
            // TxtDateStart
            // 
            TxtDateStart.AutoSize = true;
            TxtDateStart.Location = new Point(23, 5);
            TxtDateStart.Name = "TxtDateStart";
            TxtDateStart.Size = new Size(108, 20);
            TxtDateStart.TabIndex = 1;
            TxtDateStart.Text = "Fecha de inicio";
            // 
            // DataTimePickStart
            // 
            DataTimePickStart.Format = DateTimePickerFormat.Short;
            DataTimePickStart.Location = new Point(20, 28);
            DataTimePickStart.Name = "DataTimePickStart";
            DataTimePickStart.Size = new Size(126, 27);
            DataTimePickStart.TabIndex = 0;
            // 
            // PanelResult
            // 
            PanelResult.BackColor = SystemColors.ButtonHighlight;
            PanelResult.Controls.Add(TxtDayCompliance);
            PanelResult.Controls.Add(TxtDayComplianceResult);
            PanelResult.Controls.Add(TxtDayCaloriesConsumeResult);
            PanelResult.Controls.Add(label7);
            PanelResult.Controls.Add(label6);
            PanelResult.Controls.Add(label5);
            PanelResult.Controls.Add(label4);
            PanelResult.Location = new Point(14, 151);
            PanelResult.Name = "PanelResult";
            PanelResult.Size = new Size(554, 143);
            PanelResult.TabIndex = 8;
            // 
            // TxtDayCompliance
            // 
            TxtDayCompliance.AutoSize = true;
            TxtDayCompliance.Location = new Point(350, 105);
            TxtDayCompliance.Name = "TxtDayCompliance";
            TxtDayCompliance.Size = new Size(21, 20);
            TxtDayCompliance.TabIndex = 7;
            TxtDayCompliance.Text = "%";
            // 
            // TxtDayComplianceResult
            // 
            TxtDayComplianceResult.AutoSize = true;
            TxtDayComplianceResult.Location = new Point(350, 74);
            TxtDayComplianceResult.Name = "TxtDayComplianceResult";
            TxtDayComplianceResult.Size = new Size(21, 20);
            TxtDayComplianceResult.TabIndex = 6;
            TxtDayComplianceResult.Text = "%";
            // 
            // TxtDayCaloriesConsumeResult
            // 
            TxtDayCaloriesConsumeResult.AutoSize = true;
            TxtDayCaloriesConsumeResult.Location = new Point(350, 42);
            TxtDayCaloriesConsumeResult.Name = "TxtDayCaloriesConsumeResult";
            TxtDayCaloriesConsumeResult.Size = new Size(21, 20);
            TxtDayCaloriesConsumeResult.TabIndex = 5;
            TxtDayCaloriesConsumeResult.Text = "%";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 105);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 4;
            label7.Text = "Dias cumplidos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 74);
            label6.Name = "label6";
            label6.Size = new Size(197, 20);
            label6.TabIndex = 3;
            label6.Text = "Tasa de cumplimiento diario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 42);
            label5.Name = "label5";
            label5.Size = new Size(190, 20);
            label5.TabIndex = 2;
            label5.Text = "Consumo diario de calorias";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 5);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 1;
            label4.Text = "Resultados";
            // 
            // PanelMacro
            // 
            PanelMacro.BackColor = SystemColors.ButtonHighlight;
            PanelMacro.Controls.Add(TxtConsumedFat);
            PanelMacro.Controls.Add(TxtConsumedCarbo);
            PanelMacro.Controls.Add(TxtIdealFat);
            PanelMacro.Controls.Add(TxtConsumedProtein);
            PanelMacro.Controls.Add(TxtIdealCarbo);
            PanelMacro.Controls.Add(TxtIdealProtein);
            PanelMacro.Controls.Add(label15);
            PanelMacro.Controls.Add(TxtFat);
            PanelMacro.Controls.Add(TxtCarbo);
            PanelMacro.Controls.Add(TxtProtein);
            PanelMacro.Controls.Add(label11);
            PanelMacro.Controls.Add(label3);
            PanelMacro.Location = new Point(14, 306);
            PanelMacro.Name = "PanelMacro";
            PanelMacro.Size = new Size(554, 143);
            PanelMacro.TabIndex = 9;
            // 
            // TxtConsumedFat
            // 
            TxtConsumedFat.AutoSize = true;
            TxtConsumedFat.Location = new Point(394, 103);
            TxtConsumedFat.Name = "TxtConsumedFat";
            TxtConsumedFat.Size = new Size(21, 20);
            TxtConsumedFat.TabIndex = 10;
            TxtConsumedFat.Text = "%";
            // 
            // TxtConsumedCarbo
            // 
            TxtConsumedCarbo.AutoSize = true;
            TxtConsumedCarbo.Location = new Point(394, 72);
            TxtConsumedCarbo.Name = "TxtConsumedCarbo";
            TxtConsumedCarbo.Size = new Size(21, 20);
            TxtConsumedCarbo.TabIndex = 9;
            TxtConsumedCarbo.Text = "%";
            // 
            // TxtIdealFat
            // 
            TxtIdealFat.AutoSize = true;
            TxtIdealFat.Location = new Point(171, 105);
            TxtIdealFat.Name = "TxtIdealFat";
            TxtIdealFat.Size = new Size(21, 20);
            TxtIdealFat.TabIndex = 14;
            TxtIdealFat.Text = "%";
            // 
            // TxtConsumedProtein
            // 
            TxtConsumedProtein.AutoSize = true;
            TxtConsumedProtein.Location = new Point(394, 40);
            TxtConsumedProtein.Name = "TxtConsumedProtein";
            TxtConsumedProtein.Size = new Size(21, 20);
            TxtConsumedProtein.TabIndex = 8;
            TxtConsumedProtein.Text = "%";
            // 
            // TxtIdealCarbo
            // 
            TxtIdealCarbo.AutoSize = true;
            TxtIdealCarbo.Location = new Point(171, 74);
            TxtIdealCarbo.Name = "TxtIdealCarbo";
            TxtIdealCarbo.Size = new Size(21, 20);
            TxtIdealCarbo.TabIndex = 13;
            TxtIdealCarbo.Text = "%";
            // 
            // TxtIdealProtein
            // 
            TxtIdealProtein.AutoSize = true;
            TxtIdealProtein.Location = new Point(171, 42);
            TxtIdealProtein.Name = "TxtIdealProtein";
            TxtIdealProtein.Size = new Size(21, 20);
            TxtIdealProtein.TabIndex = 12;
            TxtIdealProtein.Text = "%";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(363, 21);
            label15.Name = "label15";
            label15.Size = new Size(84, 20);
            label15.TabIndex = 11;
            label15.Text = "Consumido";
            // 
            // TxtFat
            // 
            TxtFat.AutoSize = true;
            TxtFat.Location = new Point(20, 105);
            TxtFat.Name = "TxtFat";
            TxtFat.Size = new Size(52, 20);
            TxtFat.TabIndex = 10;
            TxtFat.Text = "Grasas";
            // 
            // TxtCarbo
            // 
            TxtCarbo.AutoSize = true;
            TxtCarbo.Location = new Point(20, 74);
            TxtCarbo.Name = "TxtCarbo";
            TxtCarbo.Size = new Size(103, 20);
            TxtCarbo.TabIndex = 9;
            TxtCarbo.Text = "Carbohidratos";
            // 
            // TxtProtein
            // 
            TxtProtein.AutoSize = true;
            TxtProtein.Location = new Point(20, 42);
            TxtProtein.Name = "TxtProtein";
            TxtProtein.Size = new Size(70, 20);
            TxtProtein.TabIndex = 8;
            TxtProtein.Text = "Proteinas";
            TxtProtein.Click += label14_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(163, 21);
            label11.Name = "label11";
            label11.Size = new Size(42, 20);
            label11.TabIndex = 2;
            label11.Text = "Ideal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 5);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 1;
            label3.Text = "Macros";
            // 
            // StaticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 462);
            Controls.Add(PanelMacro);
            Controls.Add(PanelResult);
            Controls.Add(PanelCalc);
            Controls.Add(labelProducts);
            Controls.Add(BtnBack);
            Controls.Add(labelTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StaticsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriTrack System";
            PanelCalc.ResumeLayout(false);
            PanelCalc.PerformLayout();
            PanelResult.ResumeLayout(false);
            PanelResult.PerformLayout();
            PanelMacro.ResumeLayout(false);
            PanelMacro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Button BtnBack;
        private Label labelProducts;
        private Panel PanelCalc;
        private Label TxtDateStart;
        private DateTimePicker DataTimePickStart;
        private Button BtnCalc;
        private Label TxtDateEnd;
        private DateTimePicker DataTimePickEnd;
        private Panel PanelResult;
        private Label label5;
        private Label label4;
        private Panel PanelMacro;
        private Label label3;
        private Label TxtDayCompliance;
        private Label TxtDayComplianceResult;
        private Label TxtDayCaloriesConsumeResult;
        private Label label7;
        private Label label6;
        private Label TxtFat;
        private Label TxtCarbo;
        private Label TxtProtein;
        private Label label11;
        private Label label15;
        private Label TxtConsumedFat;
        private Label TxtConsumedCarbo;
        private Label TxtIdealFat;
        private Label TxtConsumedProtein;
        private Label TxtIdealCarbo;
        private Label TxtIdealProtein;
    }
}