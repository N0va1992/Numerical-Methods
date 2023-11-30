namespace numericalMethods
{
    partial class ApproximationsViewControl
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
            this.approxTitle = new System.Windows.Forms.Label();
            this.task12 = new System.Windows.Forms.Button();
            this.task11 = new System.Windows.Forms.Button();
            this.backBtn11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // approxTitle
            // 
            this.approxTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.approxTitle.Location = new System.Drawing.Point(0, 0);
            this.approxTitle.Name = "approxTitle";
            this.approxTitle.Size = new System.Drawing.Size(299, 23);
            this.approxTitle.TabIndex = 0;
            this.approxTitle.Text = "Przybliżenia";
            this.approxTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // task12
            // 
            this.task12.Location = new System.Drawing.Point(12, 107);
            this.task12.Name = "task12";
            this.task12.Size = new System.Drawing.Size(274, 23);
            this.task12.TabIndex = 4;
            this.task12.Text = "Wartość przybliżona i błąd bezwzględny";
            this.task12.UseVisualStyleBackColor = true;
            // 
            // task11
            // 
            this.task11.Location = new System.Drawing.Point(12, 77);
            this.task11.Name = "task11";
            this.task11.Size = new System.Drawing.Size(274, 23);
            this.task11.TabIndex = 3;
            this.task11.Text = "Błąd względny i bezwzględny";
            this.task11.UseVisualStyleBackColor = true;
            // 
            // backBtn11
            // 
            this.backBtn11.Location = new System.Drawing.Point(109, 216);
            this.backBtn11.Name = "backBtn11";
            this.backBtn11.Size = new System.Drawing.Size(75, 23);
            this.backBtn11.TabIndex = 5;
            this.backBtn11.Text = "Powrót";
            this.backBtn11.UseVisualStyleBackColor = true;
            this.backBtn11.Click += new System.EventHandler(this.backBtn11_Click);
            // 
            // ApproximationsViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backBtn11);
            this.Controls.Add(this.task12);
            this.Controls.Add(this.task11);
            this.Controls.Add(this.approxTitle);
            this.Name = "ApproximationsViewControl";
            this.Size = new System.Drawing.Size(299, 259);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label approxTitle;
        private System.Windows.Forms.Button task12;
        private System.Windows.Forms.Button task11;
        private System.Windows.Forms.Button backBtn11;
    }
}
