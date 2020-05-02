﻿using System;
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
            availableTeamMembers.Add(new OsobaModel {Ime="Tim" , Prezime="Corey"});
            availableTeamMembers.Add(new OsobaModel { Ime = "Marin", Prezime = "Budić" });

            selectedTeamMembers.Add(new OsobaModel { Ime="Edi",Prezime="Budić"});
            selectedTeamMembers.Add(new OsobaModel { Ime="Eda",Prezime="Maretić"});

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
                p.Ime = textBoxImeClana.Text;
                p.Prezime = textBoxPrezimeClana.Text;
                p.BrojMobitela = textBoxBrojTelClana.Text;
                p.EmailAdresa = textBoxEmailClana.Text;

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
    }
}
