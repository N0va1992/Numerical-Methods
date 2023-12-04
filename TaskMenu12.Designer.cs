namespace numericalMethods
{
    partial class TaskMenu12
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
            this.task12Task = new System.Windows.Forms.Label();
            this.backBtn112 = new System.Windows.Forms.Button();
            this.appValue1 = new System.Windows.Forms.Label();
            this.absError1 = new System.Windows.Forms.Label();
            this.approxValueTextBox = new System.Windows.Forms.TextBox();
            this.absoluteValueTextBox = new System.Windows.Forms.TextBox();
            this.calculateBtn12 = new System.Windows.Forms.Button();
            this.underestimationText = new System.Windows.Forms.Label();
            this.overestimationText = new System.Windows.Forms.Label();
            this.deficiencyResult = new System.Windows.Forms.Label();
            this.surplusResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // task12Task
            // 
            this.task12Task.Dock = System.Windows.Forms.DockStyle.Top;
            this.task12Task.Location = new System.Drawing.Point(0, 0);
            this.task12Task.Name = "task12Task";
            this.task12Task.Size = new System.Drawing.Size(379, 114);
            this.task12Task.TabIndex = 0;
            this.task12Task.Text = "zadanie";
            this.task12Task.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backBtn112
            // 
            this.backBtn112.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backBtn112.Location = new System.Drawing.Point(0, 403);
            this.backBtn112.Name = "backBtn112";
            this.backBtn112.Size = new System.Drawing.Size(379, 23);
            this.backBtn112.TabIndex = 1;
            this.backBtn112.Text = "Powrót";
            this.backBtn112.UseVisualStyleBackColor = true;
            this.backBtn112.Click += new System.EventHandler(this.backBtn112_Click);
            // 
            // appValue1
            // 
            this.appValue1.AutoSize = true;
            this.appValue1.Location = new System.Drawing.Point(4, 137);
            this.appValue1.Name = "appValue1";
            this.appValue1.Size = new System.Drawing.Size(131, 16);
            this.appValue1.TabIndex = 2;
            this.appValue1.Text = "Wartość przybliżona:";
            // 
            // absError1
            // 
            this.absError1.AutoSize = true;
            this.absError1.Location = new System.Drawing.Point(7, 172);
            this.absError1.Name = "absError1";
            this.absError1.Size = new System.Drawing.Size(122, 16);
            this.absError1.TabIndex = 3;
            this.absError1.Text = "Błąd bezwzględny:";
            // 
            // approxValueTextBox
            // 
            this.approxValueTextBox.Location = new System.Drawing.Point(151, 131);
            this.approxValueTextBox.Name = "approxValueTextBox";
            this.approxValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.approxValueTextBox.TabIndex = 4;
            // 
            // absoluteValueTextBox
            // 
            this.absoluteValueTextBox.Location = new System.Drawing.Point(151, 166);
            this.absoluteValueTextBox.Name = "absoluteValueTextBox";
            this.absoluteValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.absoluteValueTextBox.TabIndex = 5;
            // 
            // calculateBtn12
            // 
            this.calculateBtn12.Location = new System.Drawing.Point(151, 212);
            this.calculateBtn12.Name = "calculateBtn12";
            this.calculateBtn12.Size = new System.Drawing.Size(100, 23);
            this.calculateBtn12.TabIndex = 6;
            this.calculateBtn12.Text = "Oblicz";
            this.calculateBtn12.UseVisualStyleBackColor = true;
            this.calculateBtn12.Click += new System.EventHandler(this.calculateBtn12_Click);
            // 
            // underestimationText
            // 
            this.underestimationText.AutoSize = true;
            this.underestimationText.Location = new System.Drawing.Point(10, 245);
            this.underestimationText.Name = "underestimationText";
            this.underestimationText.Size = new System.Drawing.Size(173, 16);
            this.underestimationText.TabIndex = 7;
            this.underestimationText.Text = "Przybliżenie z niedomiarem:";
            // 
            // overestimationText
            // 
            this.overestimationText.AutoSize = true;
            this.overestimationText.Location = new System.Drawing.Point(13, 280);
            this.overestimationText.Name = "overestimationText";
            this.overestimationText.Size = new System.Drawing.Size(162, 16);
            this.overestimationText.TabIndex = 8;
            this.overestimationText.Text = "Przyblizenie z nadmiarem:";
            // 
            // deficiencyResult
            // 
            this.deficiencyResult.AutoSize = true;
            this.deficiencyResult.Location = new System.Drawing.Point(210, 245);
            this.deficiencyResult.Name = "deficiencyResult";
            this.deficiencyResult.Size = new System.Drawing.Size(40, 16);
            this.deficiencyResult.TabIndex = 9;
            this.deficiencyResult.Text = "wynik";
            // 
            // surplusResult
            // 
            this.surplusResult.AutoSize = true;
            this.surplusResult.Location = new System.Drawing.Point(210, 280);
            this.surplusResult.Name = "surplusResult";
            this.surplusResult.Size = new System.Drawing.Size(40, 16);
            this.surplusResult.TabIndex = 10;
            this.surplusResult.Text = "wynik";
            // 
            // TaskMenu12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.surplusResult);
            this.Controls.Add(this.deficiencyResult);
            this.Controls.Add(this.overestimationText);
            this.Controls.Add(this.underestimationText);
            this.Controls.Add(this.calculateBtn12);
            this.Controls.Add(this.absoluteValueTextBox);
            this.Controls.Add(this.approxValueTextBox);
            this.Controls.Add(this.absError1);
            this.Controls.Add(this.appValue1);
            this.Controls.Add(this.backBtn112);
            this.Controls.Add(this.task12Task);
            this.Name = "TaskMenu12";
            this.Size = new System.Drawing.Size(379, 426);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label task12Task;
        private System.Windows.Forms.Button backBtn112;
        private System.Windows.Forms.Label appValue1;
        private System.Windows.Forms.Label absError1;
        private System.Windows.Forms.TextBox approxValueTextBox;
        private System.Windows.Forms.TextBox absoluteValueTextBox;
        private System.Windows.Forms.Button calculateBtn12;
        private System.Windows.Forms.Label underestimationText;
        private System.Windows.Forms.Label overestimationText;
        private System.Windows.Forms.Label deficiencyResult;
        private System.Windows.Forms.Label surplusResult;
    }
}
