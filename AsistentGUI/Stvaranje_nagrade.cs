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
    public partial class Stvaranje_nagrade : Form
    {
        public Stvaranje_nagrade()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Ime_nagrade_Click(object sender, EventArgs e)
        {

        }

        private void BtnUnesiNagradu_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                NagradaModel model = new NagradaModel
                    (textBoxImeNagrade.Text, 
                    textBoxBrojNagrade.Text,
                    textBoxKolicina.Text,
                    textBoxPostotakNagrade.Text);
                
                GlobalConfig.Connection.CreatePrize(model);
                
                textBoxImeNagrade.Text = "";
                textBoxBrojNagrade.Text = "";
                textBoxKolicina.Text = "0";
                textBoxPostotakNagrade.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please chech it and try again! ");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool PlaceNumberValidNumber = int.TryParse(textBoxBrojNagrade.Text, out placeNumber);
            if (!PlaceNumberValidNumber)
            {
                output = false;
            }
            if (placeNumber<0)
            {
                output = false;
            }
            if (textBoxImeNagrade.Text.Length == 0)
            {
                output = false;
            }
            decimal prizeAmount = 0;
            double prizePercentage = 0;
            bool prizeAmountValid = decimal.TryParse(textBoxKolicina.Text,out prizeAmount);
            bool prizePercentageValid = double.TryParse(textBoxPostotakNagrade.Text, out prizePercentage);
            if(prizeAmountValid==false || prizePercentageValid==false)
            {
                output = false;
            }
            if (prizeAmount < 0 && prizePercentage < 0)
            {
                output = false;
            }
            if(prizePercentage<0 || prizePercentage>100)
            {
                output = false;
            }
            return output;
        }

        private void TextBoxBrojNagrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void Stvaranje_nagrade_Load(object sender, EventArgs e)
        {

        }
    }
}
