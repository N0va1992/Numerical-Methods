namespace numericalMethods
{
    partial class IntegrationsMenuControl
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
            this.trapezoidalMethodBtn = new System.Windows.Forms.Button();
            this.rectangleMethodBtn = new System.Windows.Forms.Button();
            this.integrationsTitle = new System.Windows.Forms.Label();
            this.parabolicMethodBtn = new System.Windows.Forms.Button();
            this.integrationsTask = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn11
            // 
            this.backBtn11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backBtn11.Location = new System.Drawing.Point(0, 347);
            this.backBtn11.Name = "backBtn11";
            this.backBtn11.Size = new System.Drawing.Size(431, 23);
            this.backBtn11.TabIndex = 11;
            this.backBtn11.Text = "Powrót";
            this.backBtn11.UseVisualStyleBackColor = true;
            this.backBtn11.Click += new System.EventHandler(this.backBtn11_Click);
            // 
            // trapezoidalMethodBtn
            // 
            this.trapezoidalMethodBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trapezoidalMethodBtn.Location = new System.Drawing.Point(3, 248);
            this.trapezoidalMethodBtn.Name = "trapezoidalMethodBtn";
            this.trapezoidalMethodBtn.Size = new System.Drawing.Size(423, 23);
            this.trapezoidalMethodBtn.TabIndex = 10;
            this.trapezoidalMethodBtn.Text = "Metoda trapezów";
            this.trapezoidalMethodBtn.UseVisualStyleBackColor = true;
            // 
            // rectangleMethodBtn
            // 
            this.rectangleMethodBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleMethodBtn.Location = new System.Drawing.Point(3, 219);
            this.rectangleMethodBtn.Name = "rectangleMethodBtn";
            this.rectangleMethodBtn.Size = new System.Drawing.Size(423, 23);
            this.rectangleMethodBtn.TabIndex = 9;
            this.rectangleMethodBtn.Text = "Metoda prostokątów";
            this.rectangleMethodBtn.UseVisualStyleBackColor = true;
            // 
            // integrationsTitle
            // 
            this.integrationsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.integrationsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.integrationsTitle.Location = new System.Drawing.Point(0, 0);
            this.integrationsTitle.Name = "integrationsTitle";
            this.integrationsTitle.Size = new System.Drawing.Size(431, 35);
            this.integrationsTitle.TabIndex = 8;
            this.integrationsTitle.Text = "Całkowanie";
            this.integrationsTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // parabolicMethodBtn
            // 
            this.parabolicMethodBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.parabolicMethodBtn.Location = new System.Drawing.Point(3, 277);
            this.parabolicMethodBtn.Name = "parabolicMethodBtn";
            this.parabolicMethodBtn.Size = new System.Drawing.Size(423, 23);
            this.parabolicMethodBtn.TabIndex = 12;
            this.parabolicMethodBtn.Text = "Metoda parabol";
            this.parabolicMethodBtn.UseVisualStyleBackColor = true;
            // 
            // integrationsTask
            // 
            this.integrationsTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.integrationsTask.Location = new System.Drawing.Point(3, 35);
            this.integrationsTask.Name = "integrationsTask";
            this.integrationsTask.Size = new System.Drawing.Size(425, 156);
            this.integrationsTask.TabIndex = 13;
            this.integrationsTask.Text = "task";
            this.integrationsTask.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IntegrationsMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.integrationsTask);
            this.Controls.Add(this.parabolicMethodBtn);
            this.Controls.Add(this.backBtn11);
            this.Controls.Add(this.trapezoidalMethodBtn);
            this.Controls.Add(this.rectangleMethodBtn);
            this.Controls.Add(this.integrationsTitle);
            this.Name = "IntegrationsMenuControl";
            this.Size = new System.Drawing.Size(431, 370);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn11;
        private System.Windows.Forms.Button trapezoidalMethodBtn;
        private System.Windows.Forms.Button rectangleMethodBtn;
        private System.Windows.Forms.Label integrationsTitle;
        private System.Windows.Forms.Button parabolicMethodBtn;
        private System.Windows.Forms.Label integrationsTask;
    }
}
