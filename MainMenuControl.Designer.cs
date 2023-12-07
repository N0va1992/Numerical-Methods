namespace metodyNumeryczne
{
    partial class MainMenuControl
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
            this.languageBtn = new System.Windows.Forms.Button();
            this.differentiationBtn = new System.Windows.Forms.Button();
            this.integrationsBtn = new System.Windows.Forms.Button();
            this.approxfuncBnt = new System.Windows.Forms.Button();
            this.interpolationsBtn = new System.Windows.Forms.Button();
            this.approximationsBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // languageBtn
            // 
            this.languageBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.languageBtn.Location = new System.Drawing.Point(117, 349);
            this.languageBtn.Margin = new System.Windows.Forms.Padding(4);
            this.languageBtn.Name = "languageBtn";
            this.languageBtn.Size = new System.Drawing.Size(159, 28);
            this.languageBtn.TabIndex = 13;
            this.languageBtn.Text = "Zmień język";
            this.languageBtn.UseVisualStyleBackColor = true;
            // 
            // differentiationBtn
            // 
            this.differentiationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.differentiationBtn.Location = new System.Drawing.Point(14, 267);
            this.differentiationBtn.Margin = new System.Windows.Forms.Padding(4);
            this.differentiationBtn.Name = "differentiationBtn";
            this.differentiationBtn.Size = new System.Drawing.Size(367, 28);
            this.differentiationBtn.TabIndex = 12;
            this.differentiationBtn.Text = "Różniczkowanie";
            this.differentiationBtn.UseVisualStyleBackColor = true;
            // 
            // integrationsBtn
            // 
            this.integrationsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.integrationsBtn.Location = new System.Drawing.Point(15, 231);
            this.integrationsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.integrationsBtn.Name = "integrationsBtn";
            this.integrationsBtn.Size = new System.Drawing.Size(365, 28);
            this.integrationsBtn.TabIndex = 11;
            this.integrationsBtn.Text = "Całkowanie";
            this.integrationsBtn.UseVisualStyleBackColor = true;
            // 
            // approxfuncBnt
            // 
            this.approxfuncBnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.approxfuncBnt.Location = new System.Drawing.Point(15, 194);
            this.approxfuncBnt.Margin = new System.Windows.Forms.Padding(4);
            this.approxfuncBnt.Name = "approxfuncBnt";
            this.approxfuncBnt.Size = new System.Drawing.Size(365, 28);
            this.approxfuncBnt.TabIndex = 10;
            this.approxfuncBnt.Text = "Aproksymacje";
            this.approxfuncBnt.UseVisualStyleBackColor = true;
            this.approxfuncBnt.Click += new System.EventHandler(this.approxfuncBnt_Click);
            // 
            // interpolationsBtn
            // 
            this.interpolationsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.interpolationsBtn.Location = new System.Drawing.Point(15, 157);
            this.interpolationsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.interpolationsBtn.Name = "interpolationsBtn";
            this.interpolationsBtn.Size = new System.Drawing.Size(365, 28);
            this.interpolationsBtn.TabIndex = 9;
            this.interpolationsBtn.Text = "Interpolacje";
            this.interpolationsBtn.UseVisualStyleBackColor = true;
            this.interpolationsBtn.Click += new System.EventHandler(this.interpolationsBtn_Click);
            // 
            // approximationsBtn
            // 
            this.approximationsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.approximationsBtn.Location = new System.Drawing.Point(15, 120);
            this.approximationsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.approximationsBtn.Name = "approximationsBtn";
            this.approximationsBtn.Size = new System.Drawing.Size(365, 28);
            this.approximationsBtn.TabIndex = 8;
            this.approximationsBtn.Text = "Przybliżenia";
            this.approximationsBtn.UseVisualStyleBackColor = true;
            this.approximationsBtn.Click += new System.EventHandler(this.approximationsBtn_Click);
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(393, 46);
            this.title.TabIndex = 7;
            this.title.Text = "tytuł";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainMenuControl
            // 
            this.Controls.Add(this.languageBtn);
            this.Controls.Add(this.differentiationBtn);
            this.Controls.Add(this.integrationsBtn);
            this.Controls.Add(this.approxfuncBnt);
            this.Controls.Add(this.interpolationsBtn);
            this.Controls.Add(this.approximationsBtn);
            this.Controls.Add(this.title);
            this.Name = "MainMenuControl";
            this.Size = new System.Drawing.Size(393, 381);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button languageBtn;
        private System.Windows.Forms.Button differentiationBtn;
        private System.Windows.Forms.Button integrationsBtn;
        private System.Windows.Forms.Button approxfuncBnt;
        private System.Windows.Forms.Button interpolationsBtn;
        private System.Windows.Forms.Button approximationsBtn;
        private System.Windows.Forms.Label title;
    }
}
