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
            // InterpolationMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.interpolationTitle);
            this.Name = "InterpolationMenuControl";
            this.Size = new System.Drawing.Size(317, 360);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label interpolationTitle;
        private System.Windows.Forms.Button backBtn;
    }
}
