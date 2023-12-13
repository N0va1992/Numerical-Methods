namespace numericalMethods
{
    partial class ParabolicMethodControl
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
            this.resultTxt = new System.Windows.Forms.Label();
            this.accuracyLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.coefficientsLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.accuracyTextBox = new System.Windows.Forms.TextBox();
            this.coefficientsTextBox = new System.Windows.Forms.TextBox();
            this.parabolicTitle = new System.Windows.Forms.Label();
            this.backBtn11 = new System.Windows.Forms.Button();
            this.iterationsTxt = new System.Windows.Forms.Label();
            this.iterationsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultTxt
            // 
            this.resultTxt.AutoSize = true;
            this.resultTxt.Location = new System.Drawing.Point(4, 243);
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.Size = new System.Drawing.Size(77, 13);
            this.resultTxt.TabIndex = 37;
            this.resultTxt.Text = "Wartość całki:";
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.AutoSize = true;
            this.accuracyLabel.Location = new System.Drawing.Point(165, 64);
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(69, 13);
            this.accuracyLabel.TabIndex = 36;
            this.accuracyLabel.Text = "Dokładność:";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(165, 118);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(17, 13);
            this.bLabel.TabIndex = 35;
            this.bLabel.Text = "B:";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(40, 118);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(17, 13);
            this.aLabel.TabIndex = 34;
            this.aLabel.Text = "A:";
            // 
            // coefficientsLabel
            // 
            this.coefficientsLabel.AutoSize = true;
            this.coefficientsLabel.Location = new System.Drawing.Point(34, 64);
            this.coefficientsLabel.Name = "coefficientsLabel";
            this.coefficientsLabel.Size = new System.Drawing.Size(80, 13);
            this.coefficientsLabel.TabIndex = 33;
            this.coefficientsLabel.Text = "Współczynniki:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(102, 243);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(35, 13);
            this.resultLabel.TabIndex = 32;
            this.resultLabel.Text = "label1";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(102, 180);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(100, 23);
            this.calculateBtn.TabIndex = 31;
            this.calculateBtn.Text = "Oblicz";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(167, 134);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(100, 20);
            this.bTextBox.TabIndex = 30;
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(37, 134);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(100, 20);
            this.aTextBox.TabIndex = 29;
            // 
            // accuracyTextBox
            // 
            this.accuracyTextBox.Location = new System.Drawing.Point(167, 80);
            this.accuracyTextBox.Name = "accuracyTextBox";
            this.accuracyTextBox.Size = new System.Drawing.Size(100, 20);
            this.accuracyTextBox.TabIndex = 28;
            // 
            // coefficientsTextBox
            // 
            this.coefficientsTextBox.Location = new System.Drawing.Point(37, 80);
            this.coefficientsTextBox.Name = "coefficientsTextBox";
            this.coefficientsTextBox.Size = new System.Drawing.Size(100, 20);
            this.coefficientsTextBox.TabIndex = 27;
            // 
            // parabolicTitle
            // 
            this.parabolicTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.parabolicTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parabolicTitle.Location = new System.Drawing.Point(0, 0);
            this.parabolicTitle.Name = "parabolicTitle";
            this.parabolicTitle.Size = new System.Drawing.Size(322, 37);
            this.parabolicTitle.TabIndex = 26;
            this.parabolicTitle.Text = "tytuł";
            this.parabolicTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backBtn11
            // 
            this.backBtn11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backBtn11.Location = new System.Drawing.Point(0, 374);
            this.backBtn11.Name = "backBtn11";
            this.backBtn11.Size = new System.Drawing.Size(322, 23);
            this.backBtn11.TabIndex = 25;
            this.backBtn11.Text = "Powrót";
            this.backBtn11.UseVisualStyleBackColor = true;
            this.backBtn11.Click += new System.EventHandler(this.backBtn11_Click);
            // 
            // iterationsTxt
            // 
            this.iterationsTxt.AutoSize = true;
            this.iterationsTxt.Location = new System.Drawing.Point(4, 267);
            this.iterationsTxt.Name = "iterationsTxt";
            this.iterationsTxt.Size = new System.Drawing.Size(74, 13);
            this.iterationsTxt.TabIndex = 38;
            this.iterationsTxt.Text = "Liczba iteracji:";
            // 
            // iterationsLabel
            // 
            this.iterationsLabel.AutoSize = true;
            this.iterationsLabel.Location = new System.Drawing.Point(102, 267);
            this.iterationsLabel.Name = "iterationsLabel";
            this.iterationsLabel.Size = new System.Drawing.Size(35, 13);
            this.iterationsLabel.TabIndex = 39;
            this.iterationsLabel.Text = "label1";
            // 
            // ParabolicMethodControl
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
            this.Controls.Add(this.parabolicTitle);
            this.Controls.Add(this.backBtn11);
            this.Name = "ParabolicMethodControl";
            this.Size = new System.Drawing.Size(322, 397);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultTxt;
        private System.Windows.Forms.Label accuracyLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label coefficientsLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.TextBox accuracyTextBox;
        private System.Windows.Forms.TextBox coefficientsTextBox;
        private System.Windows.Forms.Label parabolicTitle;
        private System.Windows.Forms.Button backBtn11;
        private System.Windows.Forms.Label iterationsTxt;
        private System.Windows.Forms.Label iterationsLabel;
    }
}
