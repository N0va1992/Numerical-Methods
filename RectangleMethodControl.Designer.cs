namespace numericalMethods
{
    partial class RectangleMethodControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.backBtn11 = new System.Windows.Forms.Button();
            this.rectangleTitle = new System.Windows.Forms.Label();
            this.coefficientsTextBox = new System.Windows.Forms.TextBox();
            this.accuracyTextBox = new System.Windows.Forms.TextBox();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.coefficientsLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.accuracyLabel = new System.Windows.Forms.Label();
            this.resultTxt = new System.Windows.Forms.Label();
            this.iterationsLabel = new System.Windows.Forms.Label();
            this.iterationsTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn11
            // 
            this.backBtn11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backBtn11.Location = new System.Drawing.Point(0, 402);
            this.backBtn11.Name = "backBtn11";
            this.backBtn11.Size = new System.Drawing.Size(334, 23);
            this.backBtn11.TabIndex = 12;
            this.backBtn11.Text = "Powrót";
            this.backBtn11.UseVisualStyleBackColor = true;
            this.backBtn11.Click += new System.EventHandler(this.backBtn11_Click);
            // 
            // rectangleTitle
            // 
            this.rectangleTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.rectangleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rectangleTitle.Location = new System.Drawing.Point(0, 0);
            this.rectangleTitle.Name = "rectangleTitle";
            this.rectangleTitle.Size = new System.Drawing.Size(334, 37);
            this.rectangleTitle.TabIndex = 13;
            this.rectangleTitle.Text = "tytuł";
            this.rectangleTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // coefficientsTextBox
            // 
            this.coefficientsTextBox.Location = new System.Drawing.Point(36, 75);
            this.coefficientsTextBox.Name = "coefficientsTextBox";
            this.coefficientsTextBox.Size = new System.Drawing.Size(100, 20);
            this.coefficientsTextBox.TabIndex = 14;
            // 
            // accuracyTextBox
            // 
            this.accuracyTextBox.Location = new System.Drawing.Point(166, 75);
            this.accuracyTextBox.Name = "accuracyTextBox";
            this.accuracyTextBox.Size = new System.Drawing.Size(100, 20);
            this.accuracyTextBox.TabIndex = 15;
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(36, 129);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(100, 20);
            this.aTextBox.TabIndex = 16;
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(166, 129);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(100, 20);
            this.bTextBox.TabIndex = 17;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(101, 175);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(100, 23);
            this.calculateBtn.TabIndex = 18;
            this.calculateBtn.Text = "Oblicz";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(101, 238);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(35, 13);
            this.resultLabel.TabIndex = 19;
            this.resultLabel.Text = "label1";
            // 
            // coefficientsLabel
            // 
            this.coefficientsLabel.AutoSize = true;
            this.coefficientsLabel.Location = new System.Drawing.Point(33, 59);
            this.coefficientsLabel.Name = "coefficientsLabel";
            this.coefficientsLabel.Size = new System.Drawing.Size(80, 13);
            this.coefficientsLabel.TabIndex = 20;
            this.coefficientsLabel.Text = "Współczynniki:";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(39, 113);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(17, 13);
            this.aLabel.TabIndex = 21;
            this.aLabel.Text = "A:";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(164, 113);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(17, 13);
            this.bLabel.TabIndex = 22;
            this.bLabel.Text = "B:";
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.AutoSize = true;
            this.accuracyLabel.Location = new System.Drawing.Point(164, 59);
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(69, 13);
            this.accuracyLabel.TabIndex = 23;
            this.accuracyLabel.Text = "Dokładność:";
            // 
            // resultTxt
            // 
            this.resultTxt.AutoSize = true;
            this.resultTxt.Location = new System.Drawing.Point(3, 238);
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.Size = new System.Drawing.Size(77, 13);
            this.resultTxt.TabIndex = 24;
            this.resultTxt.Text = "Wartość całki:";
            // 
            // iterationsLabel
            // 
            this.iterationsLabel.AutoSize = true;
            this.iterationsLabel.Location = new System.Drawing.Point(101, 261);
            this.iterationsLabel.Name = "iterationsLabel";
            this.iterationsLabel.Size = new System.Drawing.Size(35, 13);
            this.iterationsLabel.TabIndex = 41;
            this.iterationsLabel.Text = "label1";
            // 
            // iterationsTxt
            // 
            this.iterationsTxt.AutoSize = true;
            this.iterationsTxt.Location = new System.Drawing.Point(3, 261);
            this.iterationsTxt.Name = "iterationsTxt";
            this.iterationsTxt.Size = new System.Drawing.Size(74, 13);
            this.iterationsTxt.TabIndex = 40;
            this.iterationsTxt.Text = "Liczba iteracji:";
            // 
            // RectangleMethodControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iterationsLabel);
            this.Controls.Add(this.iterationsTxt);
            this.Controls.Add(this.resultTxt);
            this.Controls.Add(this.accuracyLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.coefficientsLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.accuracyTextBox);
            this.Controls.Add(this.coefficientsTextBox);
            this.Controls.Add(this.rectangleTitle);
            this.Controls.Add(this.backBtn11);
            this.Name = "RectangleMethodControl";
            this.Size = new System.Drawing.Size(334, 425);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn11;
        private System.Windows.Forms.Label rectangleTitle;
        private System.Windows.Forms.TextBox coefficientsTextBox;
        private System.Windows.Forms.TextBox accuracyTextBox;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label coefficientsLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label accuracyLabel;
        private System.Windows.Forms.Label resultTxt;
        private System.Windows.Forms.Label iterationsLabel;
        private System.Windows.Forms.Label iterationsTxt;
    }
}
