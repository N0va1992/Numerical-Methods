namespace metodyNumeryczne
{
    partial class Form1
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
            this.tytuł = new System.Windows.Forms.Label();
            this.przyblizeniaBtn = new System.Windows.Forms.Button();
            this.interpolacjeBtn = new System.Windows.Forms.Button();
            this.aproksymacjeBnt = new System.Windows.Forms.Button();
            this.calkowanieBtn = new System.Windows.Forms.Button();
            this.rozniczkowanieBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tytuł
            // 
            this.tytuł.Dock = System.Windows.Forms.DockStyle.Top;
            this.tytuł.Location = new System.Drawing.Point(0, 0);
            this.tytuł.Name = "tytuł";
            this.tytuł.Size = new System.Drawing.Size(299, 37);
            this.tytuł.TabIndex = 0;
            this.tytuł.Text = "tytuł";
            this.tytuł.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // przyblizeniaBtn
            // 
            this.przyblizeniaBtn.Location = new System.Drawing.Point(13, 67);
            this.przyblizeniaBtn.Name = "przyblizeniaBtn";
            this.przyblizeniaBtn.Size = new System.Drawing.Size(94, 23);
            this.przyblizeniaBtn.TabIndex = 1;
            this.przyblizeniaBtn.Text = "Przybliżenia";
            this.przyblizeniaBtn.UseVisualStyleBackColor = true;
            // 
            // interpolacjeBtn
            // 
            this.interpolacjeBtn.Location = new System.Drawing.Point(13, 97);
            this.interpolacjeBtn.Name = "interpolacjeBtn";
            this.interpolacjeBtn.Size = new System.Drawing.Size(94, 23);
            this.interpolacjeBtn.TabIndex = 2;
            this.interpolacjeBtn.Text = "Interpolacje";
            this.interpolacjeBtn.UseVisualStyleBackColor = true;
            // 
            // aproksymacjeBnt
            // 
            this.aproksymacjeBnt.Location = new System.Drawing.Point(13, 127);
            this.aproksymacjeBnt.Name = "aproksymacjeBnt";
            this.aproksymacjeBnt.Size = new System.Drawing.Size(94, 23);
            this.aproksymacjeBnt.TabIndex = 3;
            this.aproksymacjeBnt.Text = "Aproksymacje";
            this.aproksymacjeBnt.UseVisualStyleBackColor = true;
            // 
            // calkowanieBtn
            // 
            this.calkowanieBtn.Location = new System.Drawing.Point(13, 157);
            this.calkowanieBtn.Name = "calkowanieBtn";
            this.calkowanieBtn.Size = new System.Drawing.Size(94, 23);
            this.calkowanieBtn.TabIndex = 4;
            this.calkowanieBtn.Text = "Całkowanie";
            this.calkowanieBtn.UseVisualStyleBackColor = true;
            // 
            // rozniczkowanieBtn
            // 
            this.rozniczkowanieBtn.Location = new System.Drawing.Point(13, 187);
            this.rozniczkowanieBtn.Name = "rozniczkowanieBtn";
            this.rozniczkowanieBtn.Size = new System.Drawing.Size(94, 23);
            this.rozniczkowanieBtn.TabIndex = 5;
            this.rozniczkowanieBtn.Text = "Różniczkowanie";
            this.rozniczkowanieBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(299, 236);
            this.Controls.Add(this.rozniczkowanieBtn);
            this.Controls.Add(this.calkowanieBtn);
            this.Controls.Add(this.aproksymacjeBnt);
            this.Controls.Add(this.interpolacjeBtn);
            this.Controls.Add(this.przyblizeniaBtn);
            this.Controls.Add(this.tytuł);
            this.Name = "Form1";
            this.Text = "WdMN App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tytuł;
        private System.Windows.Forms.Button przyblizeniaBtn;
        private System.Windows.Forms.Button interpolacjeBtn;
        private System.Windows.Forms.Button aproksymacjeBnt;
        private System.Windows.Forms.Button calkowanieBtn;
        private System.Windows.Forms.Button rozniczkowanieBtn;
    }
}

