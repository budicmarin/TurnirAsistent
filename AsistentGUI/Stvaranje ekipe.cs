using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurnirAsistentModel;

namespace AsistentGUI
{
    public partial class Stvaranje_ekipe : Form
    {
        public Stvaranje_ekipe()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Stvaranje_ekipe_Load(object sender, EventArgs e)
        {

        }

        private void Dodaj_clana_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                OsobaModel p = new OsobaModel();
                p.Ime = textBoxImeClana.Text;
                p.Prezime = textBoxPrezimeClana.Text;
                p.BrojMobitela = textBoxBrojTelClana.Text;
                p.EmailAdresa = textBoxEmailClana.Text;

                GlobalConfig.Connection.CreatePerson(p);

                textBoxImeClana.Text = " ";
                textBoxPrezimeClana.Text = "";
                textBoxBrojTelClana.Text = "";
                textBoxEmailClana.Text = "";
            }
            else
            {
                MessageBox.Show("Moraš popuniti sva polja");
            }
        }
        private bool ValidateForm()
        {
            if (textBoxImeClana.Text.Length == 0) return false;
            if (textBoxPrezimeClana.Text.Length == 0) return false;
            if (textBoxBrojTelClana.Text.Length == 0) return false;
            if (textBoxEmailClana.Text.Length == 0) return false;
            return true;
        }
    }
}
