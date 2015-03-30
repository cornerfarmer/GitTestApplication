namespace GitTestApplication
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.clickMeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clickMeBtn
            // 
            this.clickMeBtn.Location = new System.Drawing.Point(41, 52);
            this.clickMeBtn.Name = "clickMeBtn";
            this.clickMeBtn.Size = new System.Drawing.Size(208, 97);
            this.clickMeBtn.TabIndex = 0;
            this.clickMeBtn.Text = "click me";
            this.clickMeBtn.UseVisualStyleBackColor = true;
            this.clickMeBtn.Click += new System.EventHandler(this.clickMeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.clickMeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clickMeBtn;
    }
}

