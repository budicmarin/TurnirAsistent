namespace budicMarinWindowsForm
{
    partial class budicMarinMonthCalendar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.buttonOdaberiTermin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(136, 18);
            this.monthCalendar1.MaxSelectionCount = 10;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // buttonOdaberiTermin
            // 
            this.buttonOdaberiTermin.Location = new System.Drawing.Point(193, 238);
            this.buttonOdaberiTermin.Name = "buttonOdaberiTermin";
            this.buttonOdaberiTermin.Size = new System.Drawing.Size(141, 23);
            this.buttonOdaberiTermin.TabIndex = 1;
            this.buttonOdaberiTermin.Text = "Odaberi Termin";
            this.buttonOdaberiTermin.UseVisualStyleBackColor = true;
            this.buttonOdaberiTermin.Click += new System.EventHandler(this.ButtonOdaberiTermin_Click);
            // 
            // budicMarinMonthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 302);
            this.Controls.Add(this.buttonOdaberiTermin);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "budicMarinMonthCalendar";
            this.Text = "budicMarinMonthCalendar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button buttonOdaberiTermin;
    }
}