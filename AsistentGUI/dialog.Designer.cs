namespace budicMarinWindowsForm
{
    partial class dialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gumb = new System.Windows.Forms.Button();
            this.textBoxRezultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Gumb
            // 
            this.Gumb.Location = new System.Drawing.Point(12, 273);
            this.Gumb.Name = "Gumb";
            this.Gumb.Size = new System.Drawing.Size(258, 42);
            this.Gumb.TabIndex = 0;
            this.Gumb.Text = "Otvorite mesage box";
            this.Gumb.UseVisualStyleBackColor = true;
            this.Gumb.Click += new System.EventHandler(this.Gumb_Click);
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Location = new System.Drawing.Point(12, 36);
            this.textBoxRezultat.Multiline = true;
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.Size = new System.Drawing.Size(273, 207);
            this.textBoxRezultat.TabIndex = 1;
            // 
            // dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 327);
            this.Controls.Add(this.textBoxRezultat);
            this.Controls.Add(this.Gumb);
            this.Name = "dialog";
            this.Text = "dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Gumb;
        private System.Windows.Forms.TextBox textBoxRezultat;
    }
}