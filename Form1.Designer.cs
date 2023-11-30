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
            this.title = new System.Windows.Forms.Label();
            this.approximationsBtn = new System.Windows.Forms.Button();
            this.interpolationsBtn = new System.Windows.Forms.Button();
            this.approxfuncBnt = new System.Windows.Forms.Button();
            this.integrationsBtn = new System.Windows.Forms.Button();
            this.differentiationBtn = new System.Windows.Forms.Button();
            this.languageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(399, 46);
            this.title.TabIndex = 0;
            this.title.Text = "tytuł";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // approximationsBtn
            // 
            this.approximationsBtn.Location = new System.Drawing.Point(17, 82);
            this.approximationsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.approximationsBtn.Name = "approximationsBtn";
            this.approximationsBtn.Size = new System.Drawing.Size(365, 28);
            this.approximationsBtn.TabIndex = 1;
            this.approximationsBtn.Text = "Przybliżenia";
            this.approximationsBtn.UseVisualStyleBackColor = true;
            // 
            // interpolationsBtn
            // 
            this.interpolationsBtn.Location = new System.Drawing.Point(17, 119);
            this.interpolationsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.interpolationsBtn.Name = "interpolationsBtn";
            this.interpolationsBtn.Size = new System.Drawing.Size(365, 28);
            this.interpolationsBtn.TabIndex = 2;
            this.interpolationsBtn.Text = "Interpolacje";
            this.interpolationsBtn.UseVisualStyleBackColor = true;
            // 
            // approxfuncBnt
            // 
            this.approxfuncBnt.Location = new System.Drawing.Point(17, 156);
            this.approxfuncBnt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.approxfuncBnt.Name = "approxfuncBnt";
            this.approxfuncBnt.Size = new System.Drawing.Size(365, 28);
            this.approxfuncBnt.TabIndex = 3;
            this.approxfuncBnt.Text = "Aproksymacje";
            this.approxfuncBnt.UseVisualStyleBackColor = true;
            // 
            // integrationsBtn
            // 
            this.integrationsBtn.Location = new System.Drawing.Point(17, 193);
            this.integrationsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.integrationsBtn.Name = "integrationsBtn";
            this.integrationsBtn.Size = new System.Drawing.Size(365, 28);
            this.integrationsBtn.TabIndex = 4;
            this.integrationsBtn.Text = "Całkowanie";
            this.integrationsBtn.UseVisualStyleBackColor = true;
            // 
            // differentiationBtn
            // 
            this.differentiationBtn.Location = new System.Drawing.Point(16, 229);
            this.differentiationBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.differentiationBtn.Name = "differentiationBtn";
            this.differentiationBtn.Size = new System.Drawing.Size(367, 28);
            this.differentiationBtn.TabIndex = 5;
            this.differentiationBtn.Text = "Różniczkowanie";
            this.differentiationBtn.UseVisualStyleBackColor = true;
            // 
            // languageBtn
            // 
            this.languageBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.languageBtn.Location = new System.Drawing.Point(145, 276);
            this.languageBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.languageBtn.Name = "languageBtn";
            this.languageBtn.Size = new System.Drawing.Size(100, 28);
            this.languageBtn.TabIndex = 6;
            this.languageBtn.Text = "Zmień język";
            this.languageBtn.UseVisualStyleBackColor = true;
            this.languageBtn.Click += new System.EventHandler(this.languageBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(399, 319);
            this.Controls.Add(this.languageBtn);
            this.Controls.Add(this.differentiationBtn);
            this.Controls.Add(this.integrationsBtn);
            this.Controls.Add(this.approxfuncBnt);
            this.Controls.Add(this.interpolationsBtn);
            this.Controls.Add(this.approximationsBtn);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "WdMN App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button approximationsBtn;
        private System.Windows.Forms.Button interpolationsBtn;
        private System.Windows.Forms.Button approxfuncBnt;
        private System.Windows.Forms.Button integrationsBtn;
        private System.Windows.Forms.Button differentiationBtn;
        private System.Windows.Forms.Button languageBtn;
    }
}

