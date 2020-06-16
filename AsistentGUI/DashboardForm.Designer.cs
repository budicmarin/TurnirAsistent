namespace AsistentGUI
{
    partial class DashboardForm
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
            this.labelTurnir = new System.Windows.Forms.Label();
            this.labelTurnirNaziv = new System.Windows.Forms.Label();
            this.labelRunde = new System.Windows.Forms.Label();
            this.comboBoxRunde = new System.Windows.Forms.ComboBox();
            this.checkBoxUnplayed = new System.Windows.Forms.CheckBox();
            this.listBoxMatchups = new System.Windows.Forms.ListBox();
            this.labelTim1 = new System.Windows.Forms.Label();
            this.labelTim2 = new System.Windows.Forms.Label();
            this.labelVS = new System.Windows.Forms.Label();
            this.textBoxRezultat2 = new System.Windows.Forms.TextBox();
            this.buttonScore = new System.Windows.Forms.Button();
            this.textBoxRezultat1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTurnir
            // 
            this.labelTurnir.AutoSize = true;
            this.labelTurnir.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurnir.Location = new System.Drawing.Point(13, 13);
            this.labelTurnir.Name = "labelTurnir";
            this.labelTurnir.Size = new System.Drawing.Size(102, 38);
            this.labelTurnir.TabIndex = 0;
            this.labelTurnir.Text = "Turnir";
            // 
            // labelTurnirNaziv
            // 
            this.labelTurnirNaziv.AutoSize = true;
            this.labelTurnirNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurnirNaziv.Location = new System.Drawing.Point(138, 13);
            this.labelTurnirNaziv.Name = "labelTurnirNaziv";
            this.labelTurnirNaziv.Size = new System.Drawing.Size(127, 38);
            this.labelTurnirNaziv.TabIndex = 1;
            this.labelTurnirNaziv.Text = "<none>";
            // 
            // labelRunde
            // 
            this.labelRunde.AutoSize = true;
            this.labelRunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRunde.Location = new System.Drawing.Point(14, 80);
            this.labelRunde.Name = "labelRunde";
            this.labelRunde.Size = new System.Drawing.Size(99, 32);
            this.labelRunde.TabIndex = 2;
            this.labelRunde.Text = "Runda";
            // 
            // comboBoxRunde
            // 
            this.comboBoxRunde.FormattingEnabled = true;
            this.comboBoxRunde.Location = new System.Drawing.Point(170, 80);
            this.comboBoxRunde.Name = "comboBoxRunde";
            this.comboBoxRunde.Size = new System.Drawing.Size(138, 24);
            this.comboBoxRunde.TabIndex = 3;
            this.comboBoxRunde.SelectedIndexChanged += new System.EventHandler(this.comboBoxRunde_SelectedIndexChanged);
            // 
            // checkBoxUnplayed
            // 
            this.checkBoxUnplayed.AutoSize = true;
            this.checkBoxUnplayed.Location = new System.Drawing.Point(170, 128);
            this.checkBoxUnplayed.Name = "checkBoxUnplayed";
            this.checkBoxUnplayed.Size = new System.Drawing.Size(145, 21);
            this.checkBoxUnplayed.TabIndex = 4;
            this.checkBoxUnplayed.Text = "Neodigrane runde";
            this.checkBoxUnplayed.UseVisualStyleBackColor = true;
            this.checkBoxUnplayed.CheckedChanged += new System.EventHandler(this.checkBoxUnplayed_CheckedChanged);
            // 
            // listBoxMatchups
            // 
            this.listBoxMatchups.FormattingEnabled = true;
            this.listBoxMatchups.ItemHeight = 16;
            this.listBoxMatchups.Location = new System.Drawing.Point(20, 168);
            this.listBoxMatchups.Name = "listBoxMatchups";
            this.listBoxMatchups.Size = new System.Drawing.Size(295, 260);
            this.listBoxMatchups.TabIndex = 6;
            this.listBoxMatchups.SelectedIndexChanged += new System.EventHandler(this.listBoxMatchups_SelectedIndexChanged);
            // 
            // labelTim1
            // 
            this.labelTim1.AutoSize = true;
            this.labelTim1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTim1.Location = new System.Drawing.Point(407, 168);
            this.labelTim1.Name = "labelTim1";
            this.labelTim1.Size = new System.Drawing.Size(117, 32);
            this.labelTim1.TabIndex = 7;
            this.labelTim1.Text = "<Tim 1>";
            this.labelTim1.Click += new System.EventHandler(this.labelTim1_Click);
            // 
            // labelTim2
            // 
            this.labelTim2.AutoSize = true;
            this.labelTim2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTim2.Location = new System.Drawing.Point(407, 396);
            this.labelTim2.Name = "labelTim2";
            this.labelTim2.Size = new System.Drawing.Size(110, 32);
            this.labelTim2.TabIndex = 8;
            this.labelTim2.Text = "<Tim2>";
            // 
            // labelVS
            // 
            this.labelVS.AutoSize = true;
            this.labelVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVS.Location = new System.Drawing.Point(448, 267);
            this.labelVS.Name = "labelVS";
            this.labelVS.Size = new System.Drawing.Size(53, 32);
            this.labelVS.TabIndex = 9;
            this.labelVS.Text = "VS";
            // 
            // textBoxRezultat2
            // 
            this.textBoxRezultat2.Location = new System.Drawing.Point(631, 396);
            this.textBoxRezultat2.Name = "textBoxRezultat2";
            this.textBoxRezultat2.Size = new System.Drawing.Size(121, 22);
            this.textBoxRezultat2.TabIndex = 11;
            // 
            // buttonScore
            // 
            this.buttonScore.Location = new System.Drawing.Point(709, 275);
            this.buttonScore.Name = "buttonScore";
            this.buttonScore.Size = new System.Drawing.Size(75, 23);
            this.buttonScore.TabIndex = 12;
            this.buttonScore.Text = "Rezultat";
            this.buttonScore.UseVisualStyleBackColor = true;
            this.buttonScore.Click += new System.EventHandler(this.buttonScore_Click);
            // 
            // textBoxRezultat1
            // 
            this.textBoxRezultat1.Location = new System.Drawing.Point(631, 168);
            this.textBoxRezultat1.Name = "textBoxRezultat1";
            this.textBoxRezultat1.Size = new System.Drawing.Size(121, 22);
            this.textBoxRezultat1.TabIndex = 13;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxRezultat1);
            this.Controls.Add(this.buttonScore);
            this.Controls.Add(this.textBoxRezultat2);
            this.Controls.Add(this.labelVS);
            this.Controls.Add(this.labelTim2);
            this.Controls.Add(this.labelTim1);
            this.Controls.Add(this.listBoxMatchups);
            this.Controls.Add(this.checkBoxUnplayed);
            this.Controls.Add(this.comboBoxRunde);
            this.Controls.Add(this.labelRunde);
            this.Controls.Add(this.labelTurnirNaziv);
            this.Controls.Add(this.labelTurnir);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTurnir;
        private System.Windows.Forms.Label labelTurnirNaziv;
        private System.Windows.Forms.Label labelRunde;
        private System.Windows.Forms.ComboBox comboBoxRunde;
        private System.Windows.Forms.CheckBox checkBoxUnplayed;
        private System.Windows.Forms.ListBox listBoxMatchups;
        private System.Windows.Forms.Label labelTim1;
        private System.Windows.Forms.Label labelTim2;
        private System.Windows.Forms.Label labelVS;
        private System.Windows.Forms.TextBox textBoxRezultat2;
        private System.Windows.Forms.Button buttonScore;
        private System.Windows.Forms.TextBox textBoxRezultat1;
    }
}