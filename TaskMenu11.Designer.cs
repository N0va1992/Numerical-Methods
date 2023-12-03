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
            this.SuspendLayout();
            // 
            // task11Task
            // 
            this.task11Task.Dock = System.Windows.Forms.DockStyle.Top;
            this.task11Task.Location = new System.Drawing.Point(0, 0);
            this.task11Task.Name = "task11Task";
            this.task11Task.Size = new System.Drawing.Size(396, 36);
            this.task11Task.TabIndex = 0;
            this.task11Task.Text = "text";
            this.task11Task.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backBtn111
            // 
            this.backBtn111.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backBtn111.Location = new System.Drawing.Point(0, 427);
            this.backBtn111.Name = "backBtn111";
            this.backBtn111.Size = new System.Drawing.Size(396, 23);
            this.backBtn111.TabIndex = 1;
            this.backBtn111.Text = "Powrót";
            this.backBtn111.UseVisualStyleBackColor = true;
            this.backBtn111.Click += new System.EventHandler(this.backBtn111_Click);
            // 
            // TaskMenu11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backBtn111);
            this.Controls.Add(this.task11Task);
            this.Name = "TaskMenu11";
            this.Size = new System.Drawing.Size(396, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label task11Task;
        private System.Windows.Forms.Button backBtn111;
    }
}
