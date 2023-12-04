namespace numericalMethods
{
    partial class TaskMenu11
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
            this.task11Task = new System.Windows.Forms.Label();
            this.backBtn111 = new System.Windows.Forms.Button();
            this.exactTextBox = new System.Windows.Forms.TextBox();
            this.approximateTextBox = new System.Windows.Forms.TextBox();
            this.exNumber = new System.Windows.Forms.Label();
            this.appNumber = new System.Windows.Forms.Label();
            this.calculateBtn11 = new System.Windows.Forms.Button();
            this.relativeErrorLabel = new System.Windows.Forms.Label();
            this.absoluteErrorLabel = new System.Windows.Forms.Label();
            this.relResult = new System.Windows.Forms.Label();
            this.absResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // task11Task
            // 
            this.task11Task.Dock = System.Windows.Forms.DockStyle.Top;
            this.task11Task.Location = new System.Drawing.Point(0, 0);
            this.task11Task.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.task11Task.Name = "task11Task";
            this.task11Task.Size = new System.Drawing.Size(528, 76);
            this.task11Task.TabIndex = 0;
            this.task11Task.Text = "text";
            this.task11Task.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backBtn111
            // 
            this.backBtn111.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backBtn111.Location = new System.Drawing.Point(0, 526);
            this.backBtn111.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backBtn111.Name = "backBtn111";
            this.backBtn111.Size = new System.Drawing.Size(528, 28);
            this.backBtn111.TabIndex = 1;
            this.backBtn111.Text = "Powrót";
            this.backBtn111.UseVisualStyleBackColor = true;
            this.backBtn111.Click += new System.EventHandler(this.backBtn111_Click);
            // 
            // exactTextBox
            // 
            this.exactTextBox.Location = new System.Drawing.Point(151, 132);
            this.exactTextBox.Name = "exactTextBox";
            this.exactTextBox.Size = new System.Drawing.Size(100, 22);
            this.exactTextBox.TabIndex = 2;
            // 
            // approximateTextBox
            // 
            this.approximateTextBox.Location = new System.Drawing.Point(151, 172);
            this.approximateTextBox.Name = "approximateTextBox";
            this.approximateTextBox.Size = new System.Drawing.Size(100, 22);
            this.approximateTextBox.TabIndex = 3;
            // 
            // exNumber
            // 
            this.exNumber.AutoSize = true;
            this.exNumber.Location = new System.Drawing.Point(3, 135);
            this.exNumber.Name = "exNumber";
            this.exNumber.Size = new System.Drawing.Size(112, 16);
            this.exNumber.TabIndex = 4;
            this.exNumber.Text = "Liczba dokładna:";
            // 
            // appNumber
            // 
            this.appNumber.AutoSize = true;
            this.appNumber.Location = new System.Drawing.Point(3, 175);
            this.appNumber.Name = "appNumber";
            this.appNumber.Size = new System.Drawing.Size(120, 16);
            this.appNumber.TabIndex = 5;
            this.appNumber.Text = "Liczba przybliżona:";
            // 
            // calculateBtn11
            // 
            this.calculateBtn11.Location = new System.Drawing.Point(151, 212);
            this.calculateBtn11.Name = "calculateBtn11";
            this.calculateBtn11.Size = new System.Drawing.Size(100, 23);
            this.calculateBtn11.TabIndex = 6;
            this.calculateBtn11.Text = "Oblicz";
            this.calculateBtn11.UseVisualStyleBackColor = true;
            this.calculateBtn11.Click += new System.EventHandler(this.calculateBtn11_Click);
            // 
            // relativeErrorLabel
            // 
            this.relativeErrorLabel.AutoSize = true;
            this.relativeErrorLabel.Location = new System.Drawing.Point(46, 299);
            this.relativeErrorLabel.Name = "relativeErrorLabel";
            this.relativeErrorLabel.Size = new System.Drawing.Size(100, 16);
            this.relativeErrorLabel.TabIndex = 7;
            this.relativeErrorLabel.Text = "Błąd względny:";
            // 
            // absoluteErrorLabel
            // 
            this.absoluteErrorLabel.AutoSize = true;
            this.absoluteErrorLabel.Location = new System.Drawing.Point(46, 262);
            this.absoluteErrorLabel.Name = "absoluteErrorLabel";
            this.absoluteErrorLabel.Size = new System.Drawing.Size(122, 16);
            this.absoluteErrorLabel.TabIndex = 9;
            this.absoluteErrorLabel.Text = "Błąd bezwzględny:";
            // 
            // relResult
            // 
            this.relResult.AutoSize = true;
            this.relResult.Location = new System.Drawing.Point(201, 299);
            this.relResult.Name = "relResult";
            this.relResult.Size = new System.Drawing.Size(40, 16);
            this.relResult.TabIndex = 10;
            this.relResult.Text = "wynik";
            // 
            // absResult
            // 
            this.absResult.AutoSize = true;
            this.absResult.Location = new System.Drawing.Point(201, 262);
            this.absResult.Name = "absResult";
            this.absResult.Size = new System.Drawing.Size(40, 16);
            this.absResult.TabIndex = 11;
            this.absResult.Text = "wynik";
            // 
            // TaskMenu11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.absResult);
            this.Controls.Add(this.relResult);
            this.Controls.Add(this.absoluteErrorLabel);
            this.Controls.Add(this.relativeErrorLabel);
            this.Controls.Add(this.calculateBtn11);
            this.Controls.Add(this.appNumber);
            this.Controls.Add(this.exNumber);
            this.Controls.Add(this.approximateTextBox);
            this.Controls.Add(this.exactTextBox);
            this.Controls.Add(this.backBtn111);
            this.Controls.Add(this.task11Task);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TaskMenu11";
            this.Size = new System.Drawing.Size(528, 554);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label task11Task;
        private System.Windows.Forms.Button backBtn111;
        private System.Windows.Forms.TextBox exactTextBox;
        private System.Windows.Forms.TextBox approximateTextBox;
        private System.Windows.Forms.Label exNumber;
        private System.Windows.Forms.Label appNumber;
        private System.Windows.Forms.Button calculateBtn11;
        private System.Windows.Forms.Label relativeErrorLabel;
        private System.Windows.Forms.Label absoluteErrorLabel;
        private System.Windows.Forms.Label relResult;
        private System.Windows.Forms.Label absResult;
    }
}
