namespace AsistentGUI
{
    partial class Stvaranje_nagrade
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
            this.ime_nagrade = new System.Windows.Forms.Label();
            this.broj_mjesta = new System.Windows.Forms.Label();
            this.ime_mjesta = new System.Windows.Forms.Label();
            this.količina_nagrade = new System.Windows.Forms.Label();
            this.or = new System.Windows.Forms.Label();
            this.postotak_nagrade = new System.Windows.Forms.Label();
            this.textBoxBrojNagrade = new System.Windows.Forms.TextBox();
            this.textBoxImeNagrade = new System.Windows.Forms.TextBox();
            this.textBoxKolicina = new System.Windows.Forms.TextBox();
            this.textBoxPostotakNagrade = new System.Windows.Forms.TextBox();
            this.btnUnesiNagradu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ime_nagrade
            // 
            this.ime_nagrade.AutoSize = true;
            this.ime_nagrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ime_nagrade.Location = new System.Drawing.Point(12, 9);
            this.ime_nagrade.Name = "ime_nagrade";
            this.ime_nagrade.Size = new System.Drawing.Size(344, 46);
            this.ime_nagrade.TabIndex = 4;
            this.ime_nagrade.Text = "Stvaranje nagrade";
            this.ime_nagrade.Click += new System.EventHandler(this.Ime_nagrade_Click);
            // 
            // broj_mjesta
            // 
            this.broj_mjesta.AutoSize = true;
            this.broj_mjesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.broj_mjesta.Location = new System.Drawing.Point(26, 93);
            this.broj_mjesta.Name = "broj_mjesta";
            this.broj_mjesta.Size = new System.Drawing.Size(164, 32);
            this.broj_mjesta.TabIndex = 5;
            this.broj_mjesta.Text = "Broj Mijesta";
            // 
            // ime_mjesta
            // 
            this.ime_mjesta.AutoSize = true;
            this.ime_mjesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ime_mjesta.Location = new System.Drawing.Point(26, 141);
            this.ime_mjesta.Name = "ime_mjesta";
            this.ime_mjesta.Size = new System.Drawing.Size(152, 32);
            this.ime_mjesta.TabIndex = 6;
            this.ime_mjesta.Text = "Ime Mjesta";
            // 
            // količina_nagrade
            // 
            this.količina_nagrade.AutoSize = true;
            this.količina_nagrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.količina_nagrade.Location = new System.Drawing.Point(26, 192);
            this.količina_nagrade.Name = "količina_nagrade";
            this.količina_nagrade.Size = new System.Drawing.Size(233, 32);
            this.količina_nagrade.TabIndex = 7;
            this.količina_nagrade.Text = "Količina Nagrade";
            // 
            // or
            // 
            this.or.AutoSize = true;
            this.or.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.or.Location = new System.Drawing.Point(143, 249);
            this.or.Name = "or";
            this.or.Size = new System.Drawing.Size(47, 29);
            this.or.TabIndex = 8;
            this.or.Text = "-ili-";
            // 
            // postotak_nagrade
            // 
            this.postotak_nagrade.AutoSize = true;
            this.postotak_nagrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postotak_nagrade.Location = new System.Drawing.Point(29, 300);
            this.postotak_nagrade.Name = "postotak_nagrade";
            this.postotak_nagrade.Size = new System.Drawing.Size(242, 32);
            this.postotak_nagrade.TabIndex = 9;
            this.postotak_nagrade.Text = "Postotak Nagrade";
            // 
            // textBoxBrojNagrade
            // 
            this.textBoxBrojNagrade.Location = new System.Drawing.Point(289, 102);
            this.textBoxBrojNagrade.Name = "textBoxBrojNagrade";
            this.textBoxBrojNagrade.Size = new System.Drawing.Size(157, 22);
            this.textBoxBrojNagrade.TabIndex = 10;
            this.textBoxBrojNagrade.TextChanged += new System.EventHandler(this.TextBoxBrojNagrade_TextChanged);
            // 
            // textBoxImeNagrade
            // 
            this.textBoxImeNagrade.Location = new System.Drawing.Point(290, 141);
            this.textBoxImeNagrade.Name = "textBoxImeNagrade";
            this.textBoxImeNagrade.Size = new System.Drawing.Size(157, 22);
            this.textBoxImeNagrade.TabIndex = 11;
            // 
            // textBoxKolicina
            // 
            this.textBoxKolicina.Location = new System.Drawing.Point(290, 192);
            this.textBoxKolicina.Name = "textBoxKolicina";
            this.textBoxKolicina.Size = new System.Drawing.Size(157, 22);
            this.textBoxKolicina.TabIndex = 12;
            this.textBoxKolicina.Text = "0";
            // 
            // textBoxPostotakNagrade
            // 
            this.textBoxPostotakNagrade.Location = new System.Drawing.Point(290, 300);
            this.textBoxPostotakNagrade.Name = "textBoxPostotakNagrade";
            this.textBoxPostotakNagrade.Size = new System.Drawing.Size(158, 22);
            this.textBoxPostotakNagrade.TabIndex = 13;
            this.textBoxPostotakNagrade.Text = "0";
            // 
            // btnUnesiNagradu
            // 
            this.btnUnesiNagradu.Location = new System.Drawing.Point(182, 367);
            this.btnUnesiNagradu.Name = "btnUnesiNagradu";
            this.btnUnesiNagradu.Size = new System.Drawing.Size(184, 43);
            this.btnUnesiNagradu.TabIndex = 14;
            this.btnUnesiNagradu.Text = "Unesi nagradu";
            this.btnUnesiNagradu.UseVisualStyleBackColor = true;
            this.btnUnesiNagradu.Click += new System.EventHandler(this.BtnUnesiNagradu_Click);
            // 
            // Stvaranje_nagrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUnesiNagradu);
            this.Controls.Add(this.textBoxPostotakNagrade);
            this.Controls.Add(this.textBoxKolicina);
            this.Controls.Add(this.textBoxImeNagrade);
            this.Controls.Add(this.textBoxBrojNagrade);
            this.Controls.Add(this.postotak_nagrade);
            this.Controls.Add(this.or);
            this.Controls.Add(this.količina_nagrade);
            this.Controls.Add(this.ime_mjesta);
            this.Controls.Add(this.broj_mjesta);
            this.Controls.Add(this.ime_nagrade);
            this.Name = "Stvaranje_nagrade";
            this.Text = "Stvaranje_nagrade";
            this.Load += new System.EventHandler(this.Stvaranje_nagrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ime_nagrade;
        private System.Windows.Forms.Label broj_mjesta;
        private System.Windows.Forms.Label ime_mjesta;
        private System.Windows.Forms.Label količina_nagrade;
        private System.Windows.Forms.Label or;
        private System.Windows.Forms.Label postotak_nagrade;
        private System.Windows.Forms.TextBox textBoxBrojNagrade;
        private System.Windows.Forms.TextBox textBoxImeNagrade;
        private System.Windows.Forms.TextBox textBoxKolicina;
        private System.Windows.Forms.TextBox textBoxPostotakNagrade;
        private System.Windows.Forms.Button btnUnesiNagradu;
    }
}