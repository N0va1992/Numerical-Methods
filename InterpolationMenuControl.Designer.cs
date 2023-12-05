namespace numericalMethods
{
    partial class InterpolationMenuControl
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
            this.interpolationTitle = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.xLabel = new System.Windows.Forms.Label();
            this.fxLabel = new System.Windows.Forms.Label();
            this.interLabel = new System.Windows.Forms.Label();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.fxTextBox = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.interTaskText = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // interpolationTitle
            // 
            this.interpolationTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.interpolationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.interpolationTitle.Location = new System.Drawing.Point(0, 0);
            this.interpolationTitle.Name = "interpolationTitle";
            this.interpolationTitle.Size = new System.Drawing.Size(317, 36);
            this.interpolationTitle.TabIndex = 0;
            this.interpolationTitle.Text = "Interpolacje";
            this.interpolationTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backBtn
            // 
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backBtn.Location = new System.Drawing.Point(0, 337);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(317, 23);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Powrót";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(3, 140);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(15, 13);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "x:";
            // 
            // fxLabel
            // 
            this.fxLabel.AutoSize = true;
            this.fxLabel.Location = new System.Drawing.Point(2, 178);
            this.fxLabel.Name = "fxLabel";
            this.fxLabel.Size = new System.Drawing.Size(24, 13);
            this.fxLabel.TabIndex = 3;
            this.fxLabel.Text = "f(x):";
            // 
            // interLabel
            // 
            this.interLabel.AutoSize = true;
            this.interLabel.Location = new System.Drawing.Point(2, 245);
            this.interLabel.Name = "interLabel";
            this.interLabel.Size = new System.Drawing.Size(126, 13);
            this.interLabel.TabIndex = 4;
            this.interLabel.Text = "Wielomian interpolacyjny:";
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(97, 137);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 20);
            this.xTextBox.TabIndex = 5;
            // 
            // fxTextBox
            // 
            this.fxTextBox.Location = new System.Drawing.Point(97, 175);
            this.fxTextBox.Name = "fxTextBox";
            this.fxTextBox.Size = new System.Drawing.Size(100, 20);
            this.fxTextBox.TabIndex = 6;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(97, 219);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(100, 23);
            this.calculateBtn.TabIndex = 7;
            this.calculateBtn.Text = "Oblicz";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // interTaskText
            // 
            this.interTaskText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.interTaskText.Location = new System.Drawing.Point(3, 36);
            this.interTaskText.Name = "interTaskText";
            this.interTaskText.Size = new System.Drawing.Size(311, 98);
            this.interTaskText.TabIndex = 8;
            this.interTaskText.Text = "task";
            this.interTaskText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(3, 267);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(34, 13);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.Text = "wynik";
            // 
            // InterpolationMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.interTaskText);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.fxTextBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.interLabel);
            this.Controls.Add(this.fxLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.interpolationTitle);
            this.Name = "InterpolationMenuControl";
            this.Size = new System.Drawing.Size(317, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label interpolationTitle;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label fxLabel;
        private System.Windows.Forms.Label interLabel;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox fxTextBox;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label interTaskText;
        private System.Windows.Forms.Label resultLabel;
    }
}
