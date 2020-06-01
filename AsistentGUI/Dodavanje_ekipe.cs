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
    public partial class PregledTurnira : Form,IPrizeRequester, ITeamRequester
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

        private void buttonDodajNagrada_Click(object sender, EventArgs e)
        {
            Stvaranje_nagrade frm = new Stvaranje_nagrade(this);
            frm.Show();
        }

        public void PrizeComplete(NagradaModel model)
        {
            selectedPrizes.Add(model);
            WireUpList();
        }

        public void TeamComplete(EkipaModel model)
        {
            selectedTeams.Add(model);
            WireUpList();
        }

        private void linkLabelCreateTeam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Stvaranje_ekipe frm = new Stvaranje_ekipe(this);
            frm.Show();
        }

        private void buttonIzbrisiTeam_Click(object sender, EventArgs e)
        {
            EkipaModel t = (EkipaModel)listBoxTeams.SelectedItem;
            if(t!=null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpList();
            }
        }

        private void listBoxTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void buttonIzbrisi_Click(object sender, EventArgs e)
        {
            NagradaModel p = (NagradaModel)listBoxPrizes.SelectedItem;
            if(p!=null)
            {
                selectedPrizes.Remove(p);
                WireUpList();
            }
        }

        private void buttonStvori_turnir_Click(object sender, EventArgs e)
        {
            decimal fee;
            bool feeAcceptable=decimal.TryParse(textBoxNagrada.Text,out fee);
            if(!feeAcceptable)
            {
                MessageBox.Show("Moraš upisati pravilnu kotizaciju", "Netočna kotizacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TurnirModel tm = new TurnirModel();
            tm.TournamentName= ime_turnira.Text;
            tm.EntryFee = fee;

            foreach(NagradaModel prize in selectedPrizes)
            {
                tm.Prizes.Add(prize);
            }

            TournamentLogic.CreateRounds(tm);

            GlobalConfig.Connection.CreateTournament(tm);

        }
    }
}
