namespace numericalMethods
{
    partial class DifferentiationMenuControl
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
            this.differentiationTask = new System.Windows.Forms.Label();
            this.dividedBtn = new System.Windows.Forms.Button();
            this.backBtn11 = new System.Windows.Forms.Button();
            this.backwardBtn = new System.Windows.Forms.Button();
            this.progressiveBtn = new System.Windows.Forms.Button();
            this.differentiationTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // differentiationTask
            // 
            this.differentiationTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.differentiationTask.Location = new System.Drawing.Point(3, 35);
            this.differentiationTask.Name = "differentiationTask";
            this.differentiationTask.Size = new System.Drawing.Size(328, 132);
            this.differentiationTask.TabIndex = 19;
            this.differentiationTask.Text = "task";
            this.differentiationTask.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dividedBtn
            // 
            this.dividedBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dividedBtn.Location = new System.Drawing.Point(4, 244);
            this.dividedBtn.Name = "dividedBtn";
            this.dividedBtn.Size = new System.Drawing.Size(326, 23);
            this.dividedBtn.TabIndex = 18;
            this.dividedBtn.Text = "Ilorazy różnicowe";
            this.dividedBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn11
            // 
            this.backBtn11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backBtn11.Location = new System.Drawing.Point(0, 322);
            this.backBtn11.Name = "backBtn11";
            this.backBtn11.Size = new System.Drawing.Size(334, 23);
            this.backBtn11.TabIndex = 17;
            this.backBtn11.Text = "Powrót";
            this.backBtn11.UseVisualStyleBackColor = true;
            this.backBtn11.Click += new System.EventHandler(this.backBtn11_Click);
            // 
            // backwardBtn
            // 
            this.backwardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.backwardBtn.Location = new System.Drawing.Point(4, 214);
            this.backwardBtn.Name = "backwardBtn";
            this.backwardBtn.Size = new System.Drawing.Size(326, 23);
            this.backwardBtn.TabIndex = 16;
            this.backwardBtn.Text = "Różnice wsteczne";
            this.backwardBtn.UseVisualStyleBackColor = true;
            // 
            // progressiveBtn
            // 
            this.progressiveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressiveBtn.Location = new System.Drawing.Point(4, 185);
            this.progressiveBtn.Name = "progressiveBtn";
            this.progressiveBtn.Size = new System.Drawing.Size(326, 23);
            this.progressiveBtn.TabIndex = 15;
            this.progressiveBtn.Text = "Różnice progresywne";
            this.progressiveBtn.UseVisualStyleBackColor = true;
            this.progressiveBtn.Click += new System.EventHandler(this.progressiveBtn_Click);
            // 
            // differentiationTitle
            // 
            this.differentiationTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.differentiationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.differentiationTitle.Location = new System.Drawing.Point(0, 0);
            this.differentiationTitle.Name = "differentiationTitle";
            this.differentiationTitle.Size = new System.Drawing.Size(334, 35);
            this.differentiationTitle.TabIndex = 14;
            this.differentiationTitle.Text = "Różniczkowanie";
            this.differentiationTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DifferentiationMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.differentiationTask);
            this.Controls.Add(this.dividedBtn);
            this.Controls.Add(this.backBtn11);
            this.Controls.Add(this.backwardBtn);
            this.Controls.Add(this.progressiveBtn);
            this.Controls.Add(this.differentiationTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DifferentiationMenuControl";
            this.Size = new System.Drawing.Size(334, 345);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label differentiationTask;
        private System.Windows.Forms.Button dividedBtn;
        private System.Windows.Forms.Button backBtn11;
        private System.Windows.Forms.Button backwardBtn;
        private System.Windows.Forms.Button progressiveBtn;
        private System.Windows.Forms.Label differentiationTitle;
    }
}
