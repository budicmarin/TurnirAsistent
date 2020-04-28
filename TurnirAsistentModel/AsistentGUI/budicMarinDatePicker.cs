using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budicMarinWindowsForm
{
    public partial class budicMarinDatePicker : Form
    {
        public budicMarinDatePicker()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRezervacija_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            DateTime dt1 = dateTimePickerDatum.Value;
            // objektu klase DateTime, dt1, dodjeljuje se vrijednost
            // koju je korisnik izabrao u kontroli za datum
            StringBuilder sb1 = new StringBuilder();
            // objekt klase StringBuilder, sb1, koristi se za
            // kreiranje stringa, koji ce se na kraju ispisati u richText // box-u
            sb1.Append("Vas datum leta je:\n");
            sb1.Append(dt1.ToShortDateString() + "\n");
            // objektu klase DateTime, dt2, dodjeljuje se vrijednost
            // koju je korisnik izabrao u kontroli za vrijeme
            DateTime dt2 = dateTimePickerVrijeme.Value;
            sb1.Append("Vase vrijeme polaska je:\n");
            sb1.Append(dt2.ToShortTimeString());
            // ispis kreiranog stringa u richText box-u
            richTextBox1.AppendText(sb1.ToString());

        }
    }
}
