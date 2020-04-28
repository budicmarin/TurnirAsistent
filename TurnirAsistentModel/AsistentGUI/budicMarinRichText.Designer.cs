namespace budicMarinWindowsForm
{
    partial class budicMarinRichText
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonCitaj = new System.Windows.Forms.Button();
            this.buttonBrisi = new System.Windows.Forms.Button();
            this.buttonSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(112, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(508, 344);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // buttonCitaj
            // 
            this.buttonCitaj.Location = new System.Drawing.Point(13, 13);
            this.buttonCitaj.Name = "buttonCitaj";
            this.buttonCitaj.Size = new System.Drawing.Size(75, 23);
            this.buttonCitaj.TabIndex = 1;
            this.buttonCitaj.Text = "Čitaj";
            this.buttonCitaj.UseVisualStyleBackColor = true;
            this.buttonCitaj.Click += new System.EventHandler(this.ButtonCitaj_Click);
            // 
            // buttonBrisi
            // 
            this.buttonBrisi.Location = new System.Drawing.Point(679, 13);
            this.buttonBrisi.Name = "buttonBrisi";
            this.buttonBrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonBrisi.TabIndex = 2;
            this.buttonBrisi.Text = "Briši";
            this.buttonBrisi.UseVisualStyleBackColor = true;
            this.buttonBrisi.Click += new System.EventHandler(this.ButtonBrisi_Click);
            // 
            // buttonSpremi
            // 
            this.buttonSpremi.Location = new System.Drawing.Point(13, 395);
            this.buttonSpremi.Name = "buttonSpremi";
            this.buttonSpremi.Size = new System.Drawing.Size(75, 23);
            this.buttonSpremi.TabIndex = 3;
            this.buttonSpremi.Text = "Spremi";
            this.buttonSpremi.UseVisualStyleBackColor = true;
            this.buttonSpremi.Click += new System.EventHandler(this.Button3_Click);
            // 
            // budicMarinRichText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSpremi);
            this.Controls.Add(this.buttonBrisi);
            this.Controls.Add(this.buttonCitaj);
            this.Controls.Add(this.richTextBox1);
            this.Name = "budicMarinRichText";
            this.Text = "budicMarinRichText";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonCitaj;
        private System.Windows.Forms.Button buttonBrisi;
        private System.Windows.Forms.Button buttonSpremi;
    }
}