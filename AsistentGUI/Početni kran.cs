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
    public partial class PrijavaTurnir : Form
    {
        List<TurnirModel> tournaments = GlobalConfig.Connection.GetTournament_All();
        public PrijavaTurnir()
        {
            InitializeComponent();
            WireUpList();
        }
        public void WireUpList()
        {
            Izaberi.DataSource = tournaments;
            Izaberi.DisplayMember = "TournamentName";
        }
        private void Ime_turnira_Click(object sender, EventArgs e)
        {

        }

        private void Turnir_Click(object sender, EventArgs e)
        {

        }

        private void PrijavaTurnir_Load(object sender, EventArgs e)
        {

        }

        private void Novi_Click(object sender, EventArgs e)
        {
            PregledTurnira frm = new PregledTurnira();
            frm.Show();
        }
    }
}
