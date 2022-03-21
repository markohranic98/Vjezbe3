using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib;

namespace AutobusniKolodvor1
{
    public partial class KreiranjeKarteForm : Form
    {
        public static Linija ProslijedenaLinija = null;
        public KreiranjeKarteForm()
        {
            InitializeComponent();
        }

        private void KreiranjeKarteForm_Load(object sender, EventArgs e)
        {
            this.regularnaKartaRadioButton.Checked = true;
        }

        private void odaberiLinijuButton_Click(object sender, EventArgs e)
        {
            PopisAutobusnihLinija popisAutobusnihLinija = new PopisAutobusnihLinija();
            popisAutobusnihLinija.ShowDialog();
            if(ProslijedenaLinija != null)
            {
                polazisteTextBox.Text = ProslijedenaLinija.Polaziste;
                odredisteTextBox.Text = ProslijedenaLinija.Odrediste;
                udaljenostTextBox.Text = ProslijedenaLinija.Udaljenost.ToString();
                autoprijevoznikTextBox.Text = ProslijedenaLinija.Autoprijevoznik.ToString();
            }
        }

        private void kreirajKartuButton_Click(object sender, EventArgs e)
        {
            if(ProslijedenaLinija != null)
            {
                Karta karta = null;
                VrstaKarte vrsta = VrstaKarte.Regularna;
                if (regularnaKartaRadioButton.Checked != true)
                {
                    vrsta = VrstaKarte.Studentska;
                }
                bool prtljaga = false;
                if(prtljagaCheckBox.Checked == true)
                {
                    prtljaga = true;
                }
                bool povratna = false;
                if(povratnaKartaCheckBox.Checked == true)
                {
                    povratna = true;
                }
                karta = AutobusniKolodvor.KreirajKartu(ProslijedenaLinija,vrsta,povratna,prtljaga);
                brojKarteTextBox.Text = karta.BrojKarte.ToString();
                cijenaKartaTextBox.Text = karta.Cijena.ToString();
            }
        }
    }
}
