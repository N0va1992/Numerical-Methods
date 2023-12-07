namespace numericalMethods
{
    partial class ApproxFuncControl
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
            this.task12Btn = new System.Windows.Forms.Button();
            this.task11Btn = new System.Windows.Forms.Button();
            this.approxFuncTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn11
            // 
            this.backBtn11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backBtn11.Location = new System.Drawing.Point(0, 424);
            this.backBtn11.Name = "backBtn11";
            this.backBtn11.Size = new System.Drawing.Size(419, 23);
            this.backBtn11.TabIndex = 7;
            this.backBtn11.Text = "Powrót";
            this.backBtn11.UseVisualStyleBackColor = true;
            this.backBtn11.Click += new System.EventHandler(this.backBtn11_Click);
            // 
            // task12Btn
            // 
            this.task12Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.task12Btn.Location = new System.Drawing.Point(3, 198);
            this.task12Btn.Name = "task12Btn";
            this.task12Btn.Size = new System.Drawing.Size(413, 23);
            this.task12Btn.TabIndex = 6;
            this.task12Btn.Text = "Zadanie 2";
            this.task12Btn.UseVisualStyleBackColor = true;
            // 
            // task11Btn
            // 
            this.task11Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.task11Btn.Location = new System.Drawing.Point(3, 159);
            this.task11Btn.Name = "task11Btn";
            this.task11Btn.Size = new System.Drawing.Size(413, 23);
            this.task11Btn.TabIndex = 5;
            this.task11Btn.Text = "Zadanie 1";
            this.task11Btn.UseVisualStyleBackColor = true;
            this.task11Btn.Click += new System.EventHandler(this.task11Btn_Click);
            // 
            // approxFuncTitle
            // 
            this.approxFuncTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.approxFuncTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.approxFuncTitle.Location = new System.Drawing.Point(0, 0);
            this.approxFuncTitle.Name = "approxFuncTitle";
            this.approxFuncTitle.Size = new System.Drawing.Size(419, 50);
            this.approxFuncTitle.TabIndex = 4;
            this.approxFuncTitle.Text = "Aproksymacje";
            this.approxFuncTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ApproxFuncControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backBtn11);
            this.Controls.Add(this.task12Btn);
            this.Controls.Add(this.task11Btn);
            this.Controls.Add(this.approxFuncTitle);
            this.Name = "ApproxFuncControl";
            this.Size = new System.Drawing.Size(419, 447);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn11;
        private System.Windows.Forms.Button task12Btn;
        private System.Windows.Forms.Button task11Btn;
        private System.Windows.Forms.Label approxFuncTitle;
    }
}
