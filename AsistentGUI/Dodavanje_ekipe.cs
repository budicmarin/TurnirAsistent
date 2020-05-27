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
    public partial class PregledTurnira : Form
    {
        List<EkipaModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<EkipaModel> selectedTeams = new List<EkipaModel>();
        List<NagradaModel> selectedPrizes = new List<NagradaModel>();


        public PregledTurnira()
        {
            InitializeComponent();
            WireUpList();
        }
        private void WireUpList()
        {
            comboBoxEkipa.DataSource = null;
            comboBoxEkipa.DataSource = availableTeams;
            comboBoxEkipa.DisplayMember = "TeamName";

            listBoxTeams.DataSource = null;
            listBoxTeams.DataSource = selectedTeams;
            listBoxTeams.DisplayMember = "TeamName";

            listBoxPrizes.DataSource = null;
            listBoxPrizes.DataSource = selectedPrizes;
            listBoxPrizes.DisplayMember = "NazivMjesta";
        }

        private void TextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PregledTurnira_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            EkipaModel t = (EkipaModel)comboBoxEkipa.SelectedItem;
            if(t!=null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);
                WireUpList();

            }
        }
    }
}
