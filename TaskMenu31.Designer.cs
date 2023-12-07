namespace numericalMethods
{
    partial class TaskMenu31
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
            this.textBoxXi = new System.Windows.Forms.TextBox();
            this.textBoxYi = new System.Windows.Forms.TextBox();
            this.approxFuncTask1Task = new System.Windows.Forms.Label();
            this.xiLabel = new System.Windows.Forms.Label();
            this.yiLabel = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn11
            // 
            this.backBtn11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backBtn11.Location = new System.Drawing.Point(0, 362);
            this.backBtn11.Name = "backBtn11";
            this.backBtn11.Size = new System.Drawing.Size(314, 23);
            this.backBtn11.TabIndex = 8;
            this.backBtn11.Text = "Powrót";
            this.backBtn11.UseVisualStyleBackColor = true;
            this.backBtn11.Click += new System.EventHandler(this.backBtn11_Click);
            // 
            // textBoxXi
            // 
            this.textBoxXi.Location = new System.Drawing.Point(76, 141);
            this.textBoxXi.Name = "textBoxXi";
            this.textBoxXi.Size = new System.Drawing.Size(100, 20);
            this.textBoxXi.TabIndex = 9;
            // 
            // textBoxYi
            // 
            this.textBoxYi.Location = new System.Drawing.Point(76, 176);
            this.textBoxYi.Name = "textBoxYi";
            this.textBoxYi.Size = new System.Drawing.Size(100, 20);
            this.textBoxYi.TabIndex = 10;
            // 
            // approxFuncTask1Task
            // 
            this.approxFuncTask1Task.Dock = System.Windows.Forms.DockStyle.Top;
            this.approxFuncTask1Task.Location = new System.Drawing.Point(0, 0);
            this.approxFuncTask1Task.Name = "approxFuncTask1Task";
            this.approxFuncTask1Task.Size = new System.Drawing.Size(314, 138);
            this.approxFuncTask1Task.TabIndex = 11;
            this.approxFuncTask1Task.Text = "task";
            this.approxFuncTask1Task.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // xiLabel
            // 
            this.xiLabel.AutoSize = true;
            this.xiLabel.Location = new System.Drawing.Point(6, 144);
            this.xiLabel.Name = "xiLabel";
            this.xiLabel.Size = new System.Drawing.Size(19, 13);
            this.xiLabel.TabIndex = 12;
            this.xiLabel.Text = "Xi:";
            // 
            // yiLabel
            // 
            this.yiLabel.AutoSize = true;
            this.yiLabel.Location = new System.Drawing.Point(6, 179);
            this.yiLabel.Name = "yiLabel";
            this.yiLabel.Size = new System.Drawing.Size(19, 13);
            this.yiLabel.TabIndex = 13;
            this.yiLabel.Text = "Yi:";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(76, 216);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(100, 23);
            this.calculateBtn.TabIndex = 14;
            this.calculateBtn.Text = "Oblicz";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(73, 266);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(34, 13);
            this.resultLabel.TabIndex = 15;
            this.resultLabel.Text = "wynik";
            // 
            // resultTextLabel
            // 
            this.resultTextLabel.AutoSize = true;
            this.resultTextLabel.Location = new System.Drawing.Point(6, 266);
            this.resultTextLabel.Name = "resultTextLabel";
            this.resultTextLabel.Size = new System.Drawing.Size(35, 13);
            this.resultTextLabel.TabIndex = 16;
            this.resultTextLabel.Text = "label1";
            // 
            // TaskMenu31
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultTextLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.yiLabel);
            this.Controls.Add(this.xiLabel);
            this.Controls.Add(this.approxFuncTask1Task);
            this.Controls.Add(this.textBoxYi);
            this.Controls.Add(this.textBoxXi);
            this.Controls.Add(this.backBtn11);
            this.Name = "TaskMenu31";
            this.Size = new System.Drawing.Size(314, 385);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn11;
        private System.Windows.Forms.TextBox textBoxXi;
        private System.Windows.Forms.TextBox textBoxYi;
        private System.Windows.Forms.Label approxFuncTask1Task;
        private System.Windows.Forms.Label xiLabel;
        private System.Windows.Forms.Label yiLabel;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label resultTextLabel;
    }
}
