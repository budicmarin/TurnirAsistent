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
       
        private List<OsobaModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<OsobaModel> selectedTeamMembers = new List<OsobaModel>();


        public Stvaranje_ekipe()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpList();
        }
       
        
        private void CreateSampleData()
        {
            availableTeamMembers.Add(new OsobaModel {FirstName="Tim" , LastName="Corey"});
            availableTeamMembers.Add(new OsobaModel { FirstName = "Marin", LastName = "Budić" });

            selectedTeamMembers.Add(new OsobaModel { FirstName = "Edi",LastName="Budić"});
            selectedTeamMembers.Add(new OsobaModel { FirstName = "Eda",LastName="Maretić"});

        }

        private void WireUpList()
        {
            comboBoxOdaberiIgraca.DataSource = null;

            
            comboBoxOdaberiIgraca.DataSource = availableTeamMembers;
            comboBoxOdaberiIgraca.DisplayMember = "FullName";

            listBoxTeamMembers.DataSource = null;

            listBoxTeamMembers.DataSource = selectedTeamMembers;
            listBoxTeamMembers.DisplayMember = "FullName";

            
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
                p.FirstName = textBoxImeClana.Text;
                p.LastName= textBoxPrezimeClana.Text;
                p.CellphoneNumber = textBoxBrojTelClana.Text;
                p.EmailAdress = textBoxEmailClana.Text;

                GlobalConfig.Connection.CreatePerson(p);
                WireUpList();
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

        private void ListBoxTeamMembers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxOdaberiIgraca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonDodajClana_Click(object sender, EventArgs e)
        {
            OsobaModel p = (OsobaModel)comboBoxOdaberiIgraca.SelectedItem;

            availableTeamMembers.Remove(p);
            selectedTeamMembers.Add(p);

            WireUpList();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Buttonizbrisi_Click(object sender, EventArgs e)
        {
            OsobaModel p = (OsobaModel)listBoxTeamMembers.SelectedItem;

            selectedTeamMembers.Remove(p);
            availableTeamMembers.Add(p);
            

            WireUpList();
        }

        private void Stvori_ekip_Click(object sender, EventArgs e)
        {
            EkipaModel t = new EkipaModel();
            t.TeamName= textBoxImeEkipe.Text;
            t.TeamMembers = selectedTeamMembers;
            t=GlobalConfig.Connection.CreateTeam(t);

            //TODO  - If we aren't closing this form after cration, reset this form
        }
    }
}
