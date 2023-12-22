namespace numericalMethods
{
    partial class CreditsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backBtn11 = new System.Windows.Forms.Button();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.creditsTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn11
            // 
            this.backBtn11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backBtn11.Location = new System.Drawing.Point(0, 401);
            this.backBtn11.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn11.Name = "backBtn11";
            this.backBtn11.Size = new System.Drawing.Size(407, 28);
            this.backBtn11.TabIndex = 19;
            this.backBtn11.Text = "Powrót";
            this.backBtn11.UseVisualStyleBackColor = true;
            this.backBtn11.Click += new System.EventHandler(this.backBtn11_Click);
            // 
            // creditsLabel
            // 
            this.creditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.creditsLabel.Location = new System.Drawing.Point(3, 131);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(401, 166);
            this.creditsLabel.TabIndex = 20;
            this.creditsLabel.Text = "Akademia Łomżyńska\r\n\r\nPatryk Bekier\r\nInformatyka nst\r\nSemestr 3";
            this.creditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creditsTitle
            // 
            this.creditsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.creditsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.creditsTitle.Location = new System.Drawing.Point(0, 0);
            this.creditsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.creditsTitle.Name = "creditsTitle";
            this.creditsTitle.Size = new System.Drawing.Size(407, 43);
            this.creditsTitle.TabIndex = 34;
            this.creditsTitle.Text = "Twórca";
            this.creditsTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreditsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.creditsTitle);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.backBtn11);
            this.Name = "CreditsControl";
            this.Size = new System.Drawing.Size(407, 429);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn11;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Label creditsTitle;
    }
}
