namespace AsistentGUI
{
    partial class Dodavanje_ekipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dodavanje_ekipe));
            this.ime_ekipe = new System.Windows.Forms.TextBox();
            this.Turnir = new System.Windows.Forms.Label();
            this.ime_turnira = new System.Windows.Forms.Label();
            this.runda = new System.Windows.Forms.Label();
            this.utakmica = new System.Windows.Forms.Label();
            this.tim_1 = new System.Windows.Forms.Label();
            this.tim2 = new System.Windows.Forms.Label();
            this.rezultat1 = new System.Windows.Forms.Button();
            this.rezultat2 = new System.Windows.Forms.Button();
            this.finalni_rezultat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ime_ekipe
            // 
            this.ime_ekipe.Location = new System.Drawing.Point(117, 105);
            this.ime_ekipe.Name = "ime_ekipe";
            this.ime_ekipe.Size = new System.Drawing.Size(244, 22);
            this.ime_ekipe.TabIndex = 0;
            this.ime_ekipe.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Turnir
            // 
            this.Turnir.AutoSize = true;
            this.Turnir.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turnir.Location = new System.Drawing.Point(13, 25);
            this.Turnir.Name = "Turnir";
            this.Turnir.Size = new System.Drawing.Size(111, 38);
            this.Turnir.TabIndex = 1;
            this.Turnir.Text = "Turnir:";
            // 
            // ime_turnira
            // 
            this.ime_turnira.AutoSize = true;
            this.ime_turnira.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ime_turnira.Location = new System.Drawing.Point(134, 25);
            this.ime_turnira.Name = "ime_turnira";
            this.ime_turnira.Size = new System.Drawing.Size(129, 38);
            this.ime_turnira.TabIndex = 2;
            this.ime_turnira.Text = "<turnir>";
            // 
            // runda
            // 
            this.runda.AutoSize = true;
            this.runda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runda.Location = new System.Drawing.Point(3, 105);
            this.runda.Name = "runda";
            this.runda.Size = new System.Drawing.Size(99, 32);
            this.runda.TabIndex = 3;
            this.runda.Text = "Runda";
            // 
            // utakmica
            // 
            this.utakmica.AutoSize = true;
            this.utakmica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utakmica.Location = new System.Drawing.Point(114, 278);
            this.utakmica.Name = "utakmica";
            this.utakmica.Size = new System.Drawing.Size(133, 32);
            this.utakmica.TabIndex = 4;
            this.utakmica.Text = "Utakmica";
            // 
            // tim_1
            // 
            this.tim_1.AutoSize = true;
            this.tim_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tim_1.Location = new System.Drawing.Point(348, 209);
            this.tim_1.Name = "tim_1";
            this.tim_1.Size = new System.Drawing.Size(69, 32);
            this.tim_1.TabIndex = 5;
            this.tim_1.Text = "tim1";
            // 
            // tim2
            // 
            this.tim2.AutoSize = true;
            this.tim2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tim2.Location = new System.Drawing.Point(348, 351);
            this.tim2.Name = "tim2";
            this.tim2.Size = new System.Drawing.Size(76, 32);
            this.tim2.TabIndex = 6;
            this.tim2.Text = "tim 2";
            // 
            // rezultat1
            // 
            this.rezultat1.Location = new System.Drawing.Point(508, 217);
            this.rezultat1.Name = "rezultat1";
            this.rezultat1.Size = new System.Drawing.Size(75, 23);
            this.rezultat1.TabIndex = 7;
            this.rezultat1.Text = "poen";
            this.rezultat1.UseVisualStyleBackColor = true;
            // 
            // rezultat2
            // 
            this.rezultat2.Location = new System.Drawing.Point(508, 361);
            this.rezultat2.Name = "rezultat2";
            this.rezultat2.Size = new System.Drawing.Size(75, 23);
            this.rezultat2.TabIndex = 8;
            this.rezultat2.Text = "poen";
            this.rezultat2.UseVisualStyleBackColor = true;
            // 
            // finalni_rezultat
            // 
            this.finalni_rezultat.Location = new System.Drawing.Point(659, 278);
            this.finalni_rezultat.Name = "finalni_rezultat";
            this.finalni_rezultat.Size = new System.Drawing.Size(75, 23);
            this.finalni_rezultat.TabIndex = 9;
            this.finalni_rezultat.Text = "đ";
            this.finalni_rezultat.UseVisualStyleBackColor = true;
            // 
            // Dodavanje_ekipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finalni_rezultat);
            this.Controls.Add(this.rezultat2);
            this.Controls.Add(this.rezultat1);
            this.Controls.Add(this.tim2);
            this.Controls.Add(this.tim_1);
            this.Controls.Add(this.utakmica);
            this.Controls.Add(this.runda);
            this.Controls.Add(this.ime_turnira);
            this.Controls.Add(this.Turnir);
            this.Controls.Add(this.ime_ekipe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dodavanje_ekipe";
            this.Text = "Dodavanje_ekipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ime_ekipe;
        private System.Windows.Forms.Label Turnir;
        private System.Windows.Forms.Label ime_turnira;
        private System.Windows.Forms.Label runda;
        private System.Windows.Forms.Label utakmica;
        private System.Windows.Forms.Label tim_1;
        private System.Windows.Forms.Label tim2;
        private System.Windows.Forms.Button rezultat1;
        private System.Windows.Forms.Button rezultat2;
        private System.Windows.Forms.Button finalni_rezultat;
    }
}