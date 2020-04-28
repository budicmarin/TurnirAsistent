﻿using System;
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
    public partial class budicMarinMonthCalendar : Form
    {
        public budicMarinMonthCalendar()
        {
            InitializeComponent();
        }

        private void ButtonOdaberiTermin_Click(object sender, EventArgs e)
        {
            TimeSpan ts = monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart;
            // u slučaju da korisnik nije izabrao termin, pokreće se message box
            // sa odgovarajucom porukom
            if (ts.Days < 1)
            {
                MessageBox.Show("Korištenjem tipke SHIFT odaberite opseg datuma.");
                return;
            }
            // poruka o izabranom broju dana
            MessageBox.Show("Rezervirali ste usluge u trajanju od " + ts.Days.ToString() + "dana.", "Rezervacija");
            // poruka o izabranim datumima pocetka i kraja rezervacije
            MessageBox.Show("Vasa rezervacija počinje " + monthCalendar1.SelectionStart.ToShortDateString() + " a završava se " + monthCalendar1.SelectionEnd.ToShortDateString());




        }
    }
}
