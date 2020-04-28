namespace AsistentGUI
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
            this.lista_Clanova = new System.Windows.Forms.TextBox();
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
            this.email_clana.Location = new System.Drawing.Point(12, 258);
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
            this.br_tl_clana.Location = new System.Drawing.Point(12, 209);
            this.br_tl_clana.Name = "br_tl_clana";
            this.br_tl_clana.Size = new System.Drawing.Size(267, 32);
            this.br_tl_clana.TabIndex = 3;
            this.br_tl_clana.Text = "Broj Telefona Člana";
            // 
            // prezime_clana
            // 
            this.prezime_clana.AutoSize = true;
            this.prezime_clana.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezime_clana.Location = new System.Drawing.Point(12, 164);
            this.prezime_clana.Name = "prezime_clana";
            this.prezime_clana.Size = new System.Drawing.Size(201, 32);
            this.prezime_clana.TabIndex = 4;
            this.prezime_clana.Text = "Prezime Člana";
            // 
            // Ime_clana
            // 
            this.Ime_clana.AutoSize = true;
            this.Ime_clana.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ime_clana.Location = new System.Drawing.Point(12, 116);
            this.Ime_clana.Name = "Ime_clana";
            this.Ime_clana.Size = new System.Drawing.Size(143, 32);
            this.Ime_clana.TabIndex = 5;
            this.Ime_clana.Text = "Ime Člana";
            // 
            // dodaj_clana
            // 
            this.dodaj_clana.Location = new System.Drawing.Point(60, 333);
            this.dodaj_clana.Name = "dodaj_clana";
            this.dodaj_clana.Size = new System.Drawing.Size(121, 23);
            this.dodaj_clana.TabIndex = 6;
            this.dodaj_clana.Text = "Dodaj Člana";
            this.dodaj_clana.UseVisualStyleBackColor = true;
            // 
            // Stvori_ekip
            // 
            this.Stvori_ekip.Location = new System.Drawing.Point(611, 380);
            this.Stvori_ekip.Name = "Stvori_ekip";
            this.Stvori_ekip.Size = new System.Drawing.Size(151, 23);
            this.Stvori_ekip.TabIndex = 7;
            this.Stvori_ekip.Text = "Stvori_Ekipu";
            this.Stvori_ekip.UseVisualStyleBackColor = true;
            // 
            // lista_Clanova
            // 
            this.lista_Clanova.Location = new System.Drawing.Point(450, 66);
            this.lista_Clanova.Multiline = true;
            this.lista_Clanova.Name = "lista_Clanova";
            this.lista_Clanova.Size = new System.Drawing.Size(312, 290);
            this.lista_Clanova.TabIndex = 8;
            // 
            // Stvaranje_ekipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lista_Clanova);
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
        private System.Windows.Forms.TextBox lista_Clanova;
    }
}