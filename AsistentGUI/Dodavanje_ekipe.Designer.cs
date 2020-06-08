namespace AsistentGUI
{
    partial class StvaranjeTurniraForm
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
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stvaranje_turnira = new System.Windows.Forms.Label();
            this.ime_turnira = new System.Windows.Forms.Label();
            this.ime_turn = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxEkipa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelTeam = new System.Windows.Forms.Label();
            this.labelPrize = new System.Windows.Forms.Label();
            this.buttonIzbrisiTeam = new System.Windows.Forms.Button();
            this.buttonIzbrisi = new System.Windows.Forms.Button();
            this.labelNagrada = new System.Windows.Forms.Label();
            this.textBoxNagrada = new System.Windows.Forms.TextBox();
            this.linkLabelCreateTeam = new System.Windows.Forms.LinkLabel();
            this.buttonDodajNagrada = new System.Windows.Forms.Button();
            this.listBoxTeams = new System.Windows.Forms.ListBox();
            this.listBoxPrizes = new System.Windows.Forms.ListBox();
            this.buttonStvori_turnir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.TextToolStripMenuItem_Click);
            // 
            // stvaranje_turnira
            // 
            this.stvaranje_turnira.AutoSize = true;
            this.stvaranje_turnira.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stvaranje_turnira.Location = new System.Drawing.Point(13, 13);
            this.stvaranje_turnira.Name = "stvaranje_turnira";
            this.stvaranje_turnira.Size = new System.Drawing.Size(224, 32);
            this.stvaranje_turnira.TabIndex = 1;
            this.stvaranje_turnira.Text = "Stvaranje turnira";
            // 
            // ime_turnira
            // 
            this.ime_turnira.AutoSize = true;
            this.ime_turnira.Location = new System.Drawing.Point(13, 83);
            this.ime_turnira.Name = "ime_turnira";
            this.ime_turnira.Size = new System.Drawing.Size(75, 17);
            this.ime_turnira.TabIndex = 2;
            this.ime_turnira.Text = "Ime turnira";
            // 
            // ime_turn
            // 
            this.ime_turn.Location = new System.Drawing.Point(94, 83);
            this.ime_turn.Name = "ime_turn";
            this.ime_turn.Size = new System.Drawing.Size(165, 22);
            this.ime_turn.TabIndex = 3;
            // 
            // comboBoxEkipa
            // 
            this.comboBoxEkipa.FormattingEnabled = true;
            this.comboBoxEkipa.Location = new System.Drawing.Point(94, 144);
            this.comboBoxEkipa.Name = "comboBoxEkipa";
            this.comboBoxEkipa.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEkipa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ekipa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Dodaj ekipu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Location = new System.Drawing.Point(469, 49);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(95, 17);
            this.labelTeam.TabIndex = 10;
            this.labelTeam.Text = "Team/Players";
            // 
            // labelPrize
            // 
            this.labelPrize.AutoSize = true;
            this.labelPrize.Location = new System.Drawing.Point(469, 203);
            this.labelPrize.Name = "labelPrize";
            this.labelPrize.Size = new System.Drawing.Size(63, 17);
            this.labelPrize.TabIndex = 12;
            this.labelPrize.Text = "Nagrada";
            // 
            // buttonIzbrisiTeam
            // 
            this.buttonIzbrisiTeam.Location = new System.Drawing.Point(720, 109);
            this.buttonIzbrisiTeam.Name = "buttonIzbrisiTeam";
            this.buttonIzbrisiTeam.Size = new System.Drawing.Size(75, 23);
            this.buttonIzbrisiTeam.TabIndex = 13;
            this.buttonIzbrisiTeam.Text = "Izbrisi";
            this.buttonIzbrisiTeam.UseVisualStyleBackColor = true;
            this.buttonIzbrisiTeam.Click += new System.EventHandler(this.buttonIzbrisiTeam_Click);
            // 
            // buttonIzbrisi
            // 
            this.buttonIzbrisi.Location = new System.Drawing.Point(720, 270);
            this.buttonIzbrisi.Name = "buttonIzbrisi";
            this.buttonIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonIzbrisi.TabIndex = 14;
            this.buttonIzbrisi.Text = "Izbrisi";
            this.buttonIzbrisi.UseVisualStyleBackColor = true;
            this.buttonIzbrisi.Click += new System.EventHandler(this.buttonIzbrisi_Click);
            // 
            // labelNagrada
            // 
            this.labelNagrada.AutoSize = true;
            this.labelNagrada.Location = new System.Drawing.Point(16, 194);
            this.labelNagrada.Name = "labelNagrada";
            this.labelNagrada.Size = new System.Drawing.Size(63, 17);
            this.labelNagrada.TabIndex = 15;
            this.labelNagrada.Text = "Nagrada";
            // 
            // textBoxNagrada
            // 
            this.textBoxNagrada.Location = new System.Drawing.Point(94, 188);
            this.textBoxNagrada.Name = "textBoxNagrada";
            this.textBoxNagrada.Size = new System.Drawing.Size(121, 22);
            this.textBoxNagrada.TabIndex = 16;
            // 
            // linkLabelCreateTeam
            // 
            this.linkLabelCreateTeam.AutoSize = true;
            this.linkLabelCreateTeam.Location = new System.Drawing.Point(132, 124);
            this.linkLabelCreateTeam.Name = "linkLabelCreateTeam";
            this.linkLabelCreateTeam.Size = new System.Drawing.Size(83, 17);
            this.linkLabelCreateTeam.TabIndex = 17;
            this.linkLabelCreateTeam.TabStop = true;
            this.linkLabelCreateTeam.Text = "Stvori Ekipu";
            this.linkLabelCreateTeam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateTeam_LinkClicked);
            // 
            // buttonDodajNagrada
            // 
            this.buttonDodajNagrada.Location = new System.Drawing.Point(41, 216);
            this.buttonDodajNagrada.Name = "buttonDodajNagrada";
            this.buttonDodajNagrada.Size = new System.Drawing.Size(103, 44);
            this.buttonDodajNagrada.TabIndex = 18;
            this.buttonDodajNagrada.Text = "Stvori nagradu";
            this.buttonDodajNagrada.UseVisualStyleBackColor = true;
            this.buttonDodajNagrada.Click += new System.EventHandler(this.buttonDodajNagrada_Click);
            // 
            // listBoxTeams
            // 
            this.listBoxTeams.FormattingEnabled = true;
            this.listBoxTeams.ItemHeight = 16;
            this.listBoxTeams.Location = new System.Drawing.Point(472, 70);
            this.listBoxTeams.Name = "listBoxTeams";
            this.listBoxTeams.Size = new System.Drawing.Size(242, 132);
            this.listBoxTeams.TabIndex = 19;
            this.listBoxTeams.SelectedIndexChanged += new System.EventHandler(this.listBoxTeams_SelectedIndexChanged);
            // 
            // listBoxPrizes
            // 
            this.listBoxPrizes.FormattingEnabled = true;
            this.listBoxPrizes.ItemHeight = 16;
            this.listBoxPrizes.Location = new System.Drawing.Point(472, 254);
            this.listBoxPrizes.Name = "listBoxPrizes";
            this.listBoxPrizes.Size = new System.Drawing.Size(242, 116);
            this.listBoxPrizes.TabIndex = 20;
            // 
            // buttonStvori_turnir
            // 
            this.buttonStvori_turnir.Location = new System.Drawing.Point(41, 297);
            this.buttonStvori_turnir.Name = "buttonStvori_turnir";
            this.buttonStvori_turnir.Size = new System.Drawing.Size(267, 110);
            this.buttonStvori_turnir.TabIndex = 21;
            this.buttonStvori_turnir.Text = "Stvori turnir";
            this.buttonStvori_turnir.UseVisualStyleBackColor = true;
            this.buttonStvori_turnir.Click += new System.EventHandler(this.buttonStvori_turnir_Click);
            // 
            // StvaranjeTurniraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.buttonStvori_turnir);
            this.Controls.Add(this.listBoxPrizes);
            this.Controls.Add(this.listBoxTeams);
            this.Controls.Add(this.buttonDodajNagrada);
            this.Controls.Add(this.linkLabelCreateTeam);
            this.Controls.Add(this.textBoxNagrada);
            this.Controls.Add(this.labelNagrada);
            this.Controls.Add(this.buttonIzbrisi);
            this.Controls.Add(this.buttonIzbrisiTeam);
            this.Controls.Add(this.labelPrize);
            this.Controls.Add(this.labelTeam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEkipa);
            this.Controls.Add(this.ime_turn);
            this.Controls.Add(this.ime_turnira);
            this.Controls.Add(this.stvaranje_turnira);
            this.Name = "StvaranjeTurniraForm";
            this.Load += new System.EventHandler(this.PregledTurnira_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.Label stvaranje_turnira;
        private System.Windows.Forms.Label ime_turnira;
        private System.Windows.Forms.MaskedTextBox ime_turn;
        private System.Windows.Forms.ComboBox comboBoxEkipa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.Label labelPrize;
        private System.Windows.Forms.Button buttonIzbrisiTeam;
        private System.Windows.Forms.Button buttonIzbrisi;
        private System.Windows.Forms.Label labelNagrada;
        private System.Windows.Forms.TextBox textBoxNagrada;
        private System.Windows.Forms.LinkLabel linkLabelCreateTeam;
        private System.Windows.Forms.Button buttonDodajNagrada;
        private System.Windows.Forms.ListBox listBoxTeams;
        private System.Windows.Forms.ListBox listBoxPrizes;
        private System.Windows.Forms.Button buttonStvori_turnir;
    }
}

