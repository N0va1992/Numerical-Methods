namespace numericalMethods
{
    partial class ApproxMenuControl
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
            this.task11Btn = new System.Windows.Forms.Button();
            this.task12Btn = new System.Windows.Forms.Button();
            this.backBtn11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // approxTitle
            // 
            this.approxTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.approxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.approxTitle.Location = new System.Drawing.Point(0, 0);
            this.approxTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.approxTitle.Name = "approxTitle";
            this.approxTitle.Size = new System.Drawing.Size(592, 62);
            this.approxTitle.TabIndex = 0;
            this.approxTitle.Text = "Przybliżenia";
            this.approxTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // task11Btn
            // 
            this.task11Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.task11Btn.Location = new System.Drawing.Point(4, 199);
            this.task11Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.task11Btn.Name = "task11Btn";
            this.task11Btn.Size = new System.Drawing.Size(581, 28);
            this.task11Btn.TabIndex = 1;
            this.task11Btn.Text = "Zadanie 1";
            this.task11Btn.UseVisualStyleBackColor = true;
            this.task11Btn.Click += new System.EventHandler(this.Task11Button_Clicked);
            // 
            // task12Btn
            // 
            this.task12Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.task12Btn.Location = new System.Drawing.Point(4, 246);
            this.task12Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.task12Btn.Name = "task12Btn";
            this.task12Btn.Size = new System.Drawing.Size(581, 28);
            this.task12Btn.TabIndex = 2;
            this.task12Btn.Text = "Zadanie 2";
            this.task12Btn.UseVisualStyleBackColor = true;
            this.task12Btn.Click += new System.EventHandler(this.Task12Button_Clicked);
            // 
            // backBtn11
            // 
            this.backBtn11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backBtn11.Location = new System.Drawing.Point(0, 495);
            this.backBtn11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backBtn11.Name = "backBtn11";
            this.backBtn11.Size = new System.Drawing.Size(592, 28);
            this.backBtn11.TabIndex = 3;
            this.backBtn11.Text = "Powrót";
            this.backBtn11.UseVisualStyleBackColor = true;
            this.backBtn11.Click += new System.EventHandler(this.backBtn11_Click);
            // 
            // ApproxMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backBtn11);
            this.Controls.Add(this.task12Btn);
            this.Controls.Add(this.task11Btn);
            this.Controls.Add(this.approxTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ApproxMenuControl";
            this.Size = new System.Drawing.Size(592, 523);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label approxTitle;
        private System.Windows.Forms.Button task11Btn;
        private System.Windows.Forms.Button task12Btn;
        private System.Windows.Forms.Button backBtn11;
    }
}
