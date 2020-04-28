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
    public partial class budicMarinRichText : Form
    {
        public budicMarinRichText()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(@"C:Tempproba.rtf");
            MessageBox.Show("Tekst spremljen");
        }

        private void ButtonCitaj_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"C:Tempproba.rtf");
        }

        private void ButtonBrisi_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
