﻿namespace AsistentGUI
{
    partial class Stvaranje_ekipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stvaranje_ekipe));
            this.ime_ekip = new System.Windows.Forms.Label();
            this.email_clana = new System.Windows.Forms.Label();
            this.br_tl_clana = new System.Windows.Forms.Label();
            this.prezime_clana = new System.Windows.Forms.Label();
            this.Ime_clana = new System.Windows.Forms.Label();
            this.dodaj_clana = new System.Windows.Forms.Button();
            this.Stvori_ekip = new System.Windows.Forms.Button();
            this.textBoxImeEkipe = new System.Windows.Forms.TextBox();
            this.textBoxImeClana = new System.Windows.Forms.TextBox();
            this.textBoxPrezimeClana = new System.Windows.Forms.TextBox();
            this.textBoxBrojTelClana = new System.Windows.Forms.TextBox();
            this.textBoxEmailClana = new System.Windows.Forms.TextBox();
            this.labelSelectTeamMember = new System.Windows.Forms.Label();
            this.comboBoxOdaberiIgraca = new System.Windows.Forms.ComboBox();
            this.buttonDodajClana = new System.Windows.Forms.Button();
            this.listBoxTeamMembers = new System.Windows.Forms.ListBox();
            this.buttonizbrisi = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ime_ekip
            // 
            this.ime_ekip.AutoSize = true;
            this.ime_ekip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ime_ekip.Location = new System.Drawing.Point(12, 9);
            this.ime_ekip.Name = "ime_ekip";
            this.ime_ekip.Size = new System.Drawing.Size(140, 32);
            this.ime_ekip.TabIndex = 0;
            this.ime_ekip.Text = "Ime Ekipe";
            // 
            // email_clana
            // 
            this.email_clana.AutoSize = true;
            this.email_clana.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_clana.Location = new System.Drawing.Point(12, 324);
            this.email_clana.Name = "email_clana";
            this.email_clana.Size = new System.Drawing.Size(169, 32);
            this.email_clana.TabIndex = 2;
            this.email_clana.Text = "Email Člana";
            this.email_clana.Click += new System.EventHandler(this.Label3_Click);
            // 
            // br_tl_clana
            // 
            this.br_tl_clana.AutoSize = true;
            this.br_tl_clana.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.br_tl_clana.Location = new System.Drawing.Point(12, 282);
            this.br_tl_clana.Name = "br_tl_clana";
            this.br_tl_clana.Size = new System.Drawing.Size(267, 32);
            this.br_tl_clana.TabIndex = 3;
            this.br_tl_clana.Text = "Broj Telefona Člana";
            // 
            // prezime_clana
            // 
            this.prezime_clana.AutoSize = true;
            this.prezime_clana.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezime_clana.Location = new System.Drawing.Point(12, 237);
            this.prezime_clana.Name = "prezime_clana";
            this.prezime_clana.Size = new System.Drawing.Size(201, 32);
            this.prezime_clana.TabIndex = 4;
            this.prezime_clana.Text = "Prezime Člana";
            // 
            // Ime_clana
            // 
            this.Ime_clana.AutoSize = true;
            this.Ime_clana.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ime_clana.Location = new System.Drawing.Point(12, 189);
            this.Ime_clana.Name = "Ime_clana";
            this.Ime_clana.Size = new System.Drawing.Size(143, 32);
            this.Ime_clana.TabIndex = 5;
            this.Ime_clana.Text = "Ime Člana";
            // 
            // dodaj_clana
            // 
            this.dodaj_clana.Location = new System.Drawing.Point(60, 380);
            this.dodaj_clana.Name = "dodaj_clana";
            this.dodaj_clana.Size = new System.Drawing.Size(121, 23);
            this.dodaj_clana.TabIndex = 6;
            this.dodaj_clana.Text = "Svori Člana";
            this.dodaj_clana.UseVisualStyleBackColor = true;
            this.dodaj_clana.Click += new System.EventHandler(this.Dodaj_clana_Click);
            // 
            // Stvori_ekip
            // 
            this.Stvori_ekip.Location = new System.Drawing.Point(611, 380);
            this.Stvori_ekip.Name = "Stvori_ekip";
            this.Stvori_ekip.Size = new System.Drawing.Size(151, 23);
            this.Stvori_ekip.TabIndex = 7;
            this.Stvori_ekip.Text = "Stvori_Ekipu";
            this.Stvori_ekip.UseVisualStyleBackColor = true;
            this.Stvori_ekip.Click += new System.EventHandler(this.Stvori_ekip_Click);
            // 
            // textBoxImeEkipe
            // 
            this.textBoxImeEkipe.Location = new System.Drawing.Point(18, 45);
            this.textBoxImeEkipe.Name = "textBoxImeEkipe";
            this.textBoxImeEkipe.Size = new System.Drawing.Size(195, 22);
            this.textBoxImeEkipe.TabIndex = 9;
            // 
            // textBoxImeClana
            // 
            this.textBoxImeClana.Location = new System.Drawing.Point(287, 189);
            this.textBoxImeClana.Name = "textBoxImeClana";
            this.textBoxImeClana.Size = new System.Drawing.Size(157, 22);
            this.textBoxImeClana.TabIndex = 10;
            // 
            // textBoxPrezimeClana
            // 
            this.textBoxPrezimeClana.Location = new System.Drawing.Point(287, 237);
            this.textBoxPrezimeClana.Name = "textBoxPrezimeClana";
            this.textBoxPrezimeClana.Size = new System.Drawing.Size(157, 22);
            this.textBoxPrezimeClana.TabIndex = 11;
            // 
            // textBoxBrojTelClana
            // 
            this.textBoxBrojTelClana.Location = new System.Drawing.Point(287, 282);
            this.textBoxBrojTelClana.Name = "textBoxBrojTelClana";
            this.textBoxBrojTelClana.Size = new System.Drawing.Size(157, 22);
            this.textBoxBrojTelClana.TabIndex = 12;
            // 
            // textBoxEmailClana
            // 
            this.textBoxEmailClana.Location = new System.Drawing.Point(287, 324);
            this.textBoxEmailClana.Name = "textBoxEmailClana";
            this.textBoxEmailClana.Size = new System.Drawing.Size(157, 22);
            this.textBoxEmailClana.TabIndex = 13;
            // 
            // labelSelectTeamMember
            // 
            this.labelSelectTeamMember.AutoSize = true;
            this.labelSelectTeamMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectTeamMember.Location = new System.Drawing.Point(12, 79);
            this.labelSelectTeamMember.Name = "labelSelectTeamMember";
            this.labelSelectTeamMember.Size = new System.Drawing.Size(202, 32);
            this.labelSelectTeamMember.TabIndex = 14;
            this.labelSelectTeamMember.Text = "Odaberi Igrača";
            // 
            // comboBoxOdaberiIgraca
            // 
            this.comboBoxOdaberiIgraca.FormattingEnabled = true;
            this.comboBoxOdaberiIgraca.Location = new System.Drawing.Point(18, 115);
            this.comboBoxOdaberiIgraca.MaxDropDownItems = 20;
            this.comboBoxOdaberiIgraca.Name = "comboBoxOdaberiIgraca";
            this.comboBoxOdaberiIgraca.Size = new System.Drawing.Size(196, 24);
            this.comboBoxOdaberiIgraca.TabIndex = 15;
            this.comboBoxOdaberiIgraca.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOdaberiIgraca_SelectedIndexChanged);
            // 
            // buttonDodajClana
            // 
            this.buttonDodajClana.Location = new System.Drawing.Point(18, 145);
            this.buttonDodajClana.Name = "buttonDodajClana";
            this.buttonDodajClana.Size = new System.Drawing.Size(121, 23);
            this.buttonDodajClana.TabIndex = 16;
            this.buttonDodajClana.Text = "Dodaj Člana";
            this.buttonDodajClana.UseVisualStyleBackColor = true;
            this.buttonDodajClana.Click += new System.EventHandler(this.ButtonDodajClana_Click);
            // 
            // listBoxTeamMembers
            // 
            this.listBoxTeamMembers.FormattingEnabled = true;
            this.listBoxTeamMembers.ItemHeight = 16;
            this.listBoxTeamMembers.Location = new System.Drawing.Point(487, 45);
            this.listBoxTeamMembers.Name = "listBoxTeamMembers";
            this.listBoxTeamMembers.Size = new System.Drawing.Size(275, 308);
            this.listBoxTeamMembers.TabIndex = 17;
            this.listBoxTeamMembers.SelectedIndexChanged += new System.EventHandler(this.ListBoxTeamMembers_SelectedIndexChanged);
            // 
            // buttonizbrisi
            // 
            this.buttonizbrisi.Location = new System.Drawing.Point(782, 188);
            this.buttonizbrisi.Name = "buttonizbrisi";
            this.buttonizbrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonizbrisi.TabIndex = 18;
            this.buttonizbrisi.Text = "Izbriši";
            this.buttonizbrisi.UseVisualStyleBackColor = true;
            this.buttonizbrisi.Click += new System.EventHandler(this.Buttonizbrisi_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // Stvaranje_ekipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.buttonizbrisi);
            this.Controls.Add(this.listBoxTeamMembers);
            this.Controls.Add(this.buttonDodajClana);
            this.Controls.Add(this.comboBoxOdaberiIgraca);
            this.Controls.Add(this.labelSelectTeamMember);
            this.Controls.Add(this.textBoxEmailClana);
            this.Controls.Add(this.textBoxBrojTelClana);
            this.Controls.Add(this.textBoxPrezimeClana);
            this.Controls.Add(this.textBoxImeClana);
            this.Controls.Add(this.textBoxImeEkipe);
            this.Controls.Add(this.Stvori_ekip);
            this.Controls.Add(this.dodaj_clana);
            this.Controls.Add(this.Ime_clana);
            this.Controls.Add(this.prezime_clana);
            this.Controls.Add(this.br_tl_clana);
            this.Controls.Add(this.email_clana);
            this.Controls.Add(this.ime_ekip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stvaranje_ekipe";
            this.Text = "Stvaranje_ekipe";
            this.Load += new System.EventHandler(this.Stvaranje_ekipe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ime_ekip;
        private System.Windows.Forms.Label email_clana;
        private System.Windows.Forms.Label br_tl_clana;
        private System.Windows.Forms.Label prezime_clana;
        private System.Windows.Forms.Label Ime_clana;
        private System.Windows.Forms.Button dodaj_clana;
        private System.Windows.Forms.Button Stvori_ekip;
        private System.Windows.Forms.TextBox textBoxImeEkipe;
        private System.Windows.Forms.TextBox textBoxImeClana;
        private System.Windows.Forms.TextBox textBoxPrezimeClana;
        private System.Windows.Forms.TextBox textBoxBrojTelClana;
        private System.Windows.Forms.TextBox textBoxEmailClana;
        private System.Windows.Forms.Label labelSelectTeamMember;
        private System.Windows.Forms.ComboBox comboBoxOdaberiIgraca;
        private System.Windows.Forms.Button buttonDodajClana;
        private System.Windows.Forms.ListBox listBoxTeamMembers;
        private System.Windows.Forms.Button buttonizbrisi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}