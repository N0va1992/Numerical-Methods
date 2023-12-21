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
            this.backwardTitle = new System.Windows.Forms.Label();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.pointsListBox = new System.Windows.Forms.ListBox();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
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
            // backwardTitle
            // 
            this.backwardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.backwardTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backwardTitle.Location = new System.Drawing.Point(0, 0);
            this.backwardTitle.Name = "backwardTitle";
            this.backwardTitle.Size = new System.Drawing.Size(325, 35);
            this.backwardTitle.TabIndex = 20;
            this.backwardTitle.Text = "Różnice wsteczne";
            this.backwardTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(49, 62);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 20);
            this.xTextBox.TabIndex = 21;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(188, 62);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(100, 20);
            this.yTextBox.TabIndex = 22;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(49, 88);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 23);
            this.addBtn.TabIndex = 24;
            this.addBtn.Text = "Dodaj";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(188, 88);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(100, 23);
            this.calculateBtn.TabIndex = 25;
            this.calculateBtn.Text = "Oblicz";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(158, 130);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(130, 160);
            this.resultListBox.TabIndex = 26;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(28, 65);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(15, 13);
            this.xLabel.TabIndex = 27;
            this.xLabel.Text = "x:";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(155, 65);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(27, 13);
            this.yLabel.TabIndex = 28;
            this.yLabel.Text = "F(x):";
            // 
            // pointsListBox
            // 
            this.pointsListBox.FormattingEnabled = true;
            this.pointsListBox.Location = new System.Drawing.Point(19, 130);
            this.pointsListBox.Name = "pointsListBox";
            this.pointsListBox.Size = new System.Drawing.Size(130, 160);
            this.pointsListBox.TabIndex = 30;
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(60, 114);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(40, 13);
            this.pointsLabel.TabIndex = 31;
            this.pointsLabel.Text = "Punkty";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(201, 114);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 32;
            this.resultLabel.Text = "Wynik";
            // 
            // BackwardMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.pointsListBox);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.backwardTitle);
            this.Controls.Add(this.backBtn11);
            this.Name = "BackwardMenuControl";
            this.Size = new System.Drawing.Size(325, 415);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn11;
        private System.Windows.Forms.Label backwardTitle;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.ListBox pointsListBox;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}
