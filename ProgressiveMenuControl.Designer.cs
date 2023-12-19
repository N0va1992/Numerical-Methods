namespace numericalMethods
{
    partial class ProgressiveMenuControl
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
            this.progressiveTitle = new System.Windows.Forms.Label();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.fxTextBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.fxLabel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn11
            // 
            this.backBtn11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backBtn11.Location = new System.Drawing.Point(0, 398);
            this.backBtn11.Name = "backBtn11";
            this.backBtn11.Size = new System.Drawing.Size(336, 23);
            this.backBtn11.TabIndex = 18;
            this.backBtn11.Text = "Powrót";
            this.backBtn11.UseVisualStyleBackColor = true;
            this.backBtn11.Click += new System.EventHandler(this.backBtn11_Click);
            // 
            // progressiveTitle
            // 
            this.progressiveTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressiveTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.progressiveTitle.Location = new System.Drawing.Point(0, 0);
            this.progressiveTitle.Name = "progressiveTitle";
            this.progressiveTitle.Size = new System.Drawing.Size(336, 35);
            this.progressiveTitle.TabIndex = 19;
            this.progressiveTitle.Text = "Różnice progresywne";
            this.progressiveTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(37, 80);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 20);
            this.xTextBox.TabIndex = 20;
            // 
            // fxTextBox
            // 
            this.fxTextBox.Location = new System.Drawing.Point(178, 80);
            this.fxTextBox.Name = "fxTextBox";
            this.fxTextBox.Size = new System.Drawing.Size(100, 20);
            this.fxTextBox.TabIndex = 21;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(14, 83);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(17, 13);
            this.xLabel.TabIndex = 22;
            this.xLabel.Text = "X:";
            // 
            // fxLabel
            // 
            this.fxLabel.AutoSize = true;
            this.fxLabel.Location = new System.Drawing.Point(145, 83);
            this.fxLabel.Name = "fxLabel";
            this.fxLabel.Size = new System.Drawing.Size(27, 13);
            this.fxLabel.TabIndex = 23;
            this.fxLabel.Text = "F(x):";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(38, 115);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 23);
            this.addBtn.TabIndex = 24;
            this.addBtn.Text = "Dodaj";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(178, 115);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(100, 23);
            this.calculateBtn.TabIndex = 25;
            this.calculateBtn.Text = "Oblicz";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 141);
            this.dataGridView1.TabIndex = 26;
            // 
            // ProgressiveMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.fxLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.fxTextBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.progressiveTitle);
            this.Controls.Add(this.backBtn11);
            this.Name = "ProgressiveMenuControl";
            this.Size = new System.Drawing.Size(336, 421);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn11;
        private System.Windows.Forms.Label progressiveTitle;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox fxTextBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label fxLabel;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
