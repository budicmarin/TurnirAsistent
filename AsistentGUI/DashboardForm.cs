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
    public partial class DashboardForm : Form
    {
        TurnirModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<UtakmicaModel> selectedMatchups = new BindingList<UtakmicaModel>();

        
        public DashboardForm(TurnirModel tournamentModel)
        {
            InitializeComponent();
            tournament = tournamentModel;
            WireUpList();
            LoadFormData();
            LoadRounds();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadFormData()
        {
            labelTurnirNaziv.Text = tournament.TournamentName;
        }
        private void WireUpList()
        {
            //  comboBoxRunde.DataSource = null;
            
            comboBoxRunde.DataSource = rounds;
            listBoxMatchups.DataSource = selectedMatchups;
            listBoxMatchups.DisplayMember = "DisplayName";

        }
        
        private void LoadRounds()
        {
            
            rounds.Clear();
            rounds.Add(1);
            int currRound = 1;
            foreach (List<UtakmicaModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound>currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                    
                }

            }
            LoadMatchups(1);
            //WireUpRoundsList();
        }

        private void comboBoxRunde_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)comboBoxRunde.SelectedItem);
        }

        private void LoadMatchups(int round)
        {
            
            foreach (List<UtakmicaModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound ==round)
                {
                    selectedMatchups.Clear();
                    foreach (UtakmicaModel m in matchups)
                    {
                        selectedMatchups.Add(m);
                    }
                    //selectedMatchups =new BindingList<UtakmicaModel>( matchups);
                }

            }
            LoadMatchup(selectedMatchups.First());
            //WireUpMatchupsList();
        }

        private void labelTim1_Click(object sender, EventArgs e)
        {

        }
        private void LoadMatchup(UtakmicaModel m)
        {
            
            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i==0)
                {
                    if (m.Entries[0].TeamCompeting.TeamName!=null)
                    { 
                        labelTim1.Text = m.Entries[0].TeamCompeting.TeamName;
                        textBoxRezultat1.Text = m.Entries[0].Score.ToString();
                        labelTim2.Text = "<bye>";
                        textBoxRezultat2.Text = "0";
                    }
                    else
                    {
                        labelTim1.Text = "Not Yet Set";
                        textBoxRezultat1.Text = "";
                    }
                }
                if(i==1)
                {
                    if (m.Entries[1].TeamCompeting.TeamName != null)
                    {
                        labelTim2.Text = m.Entries[1].TeamCompeting.TeamName;
                        textBoxRezultat2.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        labelTim2.Text = "Not Yet Set";
                        textBoxRezultat2.Text = "";
                    }
                }
            }
        }
        private void listBoxMatchups_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup( (UtakmicaModel)listBoxMatchups.SelectedItem);
        }
    }
}
