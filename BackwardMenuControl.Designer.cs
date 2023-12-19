namespace numericalMethods
{
    partial class BackwardMenuControl
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
            this.SuspendLayout();
            // 
            // backBtn11
            // 
            this.backBtn11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backBtn11.Location = new System.Drawing.Point(0, 392);
            this.backBtn11.Name = "backBtn11";
            this.backBtn11.Size = new System.Drawing.Size(325, 23);
            this.backBtn11.TabIndex = 19;
            this.backBtn11.Text = "Powrót";
            this.backBtn11.UseVisualStyleBackColor = true;
            this.backBtn11.Click += new System.EventHandler(this.backBtn11_Click);
            // 
            // BackwardMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backBtn11);
            this.Name = "BackwardMenuControl";
            this.Size = new System.Drawing.Size(325, 415);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn11;
    }
}
