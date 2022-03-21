using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib2;

namespace AutobusniKolodvor2
{
    public partial class KupiKartuForm : Form
    {
        public KupiKartuForm()
        {
            InitializeComponent();
            vrstaKarteComboBox.Items.AddRange(new string[] {"Regualrna","Studentska"});
            vrstaKarteComboBox.SelectedIndex = 0;
        }

        private void ispisiKartuButton_Click(object sender, EventArgs e)
        {
            AutobusniKolodvor kolodvor = new AutobusniKolodvor();
            ispisTextBox.Text = "";
            VrstaKarte vrsta = VrstaKarte.Regularna;

            if (vrstaKarteComboBox.SelectedIndex == 1)
            {
                vrsta = VrstaKarte.Studentska;
            }
            bool povratna = false;
            if (povratnaCheckBox.Checked == true)
            {
                povratna = true;
            }
            bool prtljaga = false;
            if (prtljagaCheckBox.Checked == true)
            {
                prtljaga = true;
            }
            Karta karta = kolodvor.KupiKartu(AutobusneLinijeForm.ProslijedenaLinija, vrsta, povratna, prtljaga);
            
            ispisTextBox.Text += karta.BrojKarte.ToString() + "\r\n" + "Relacija: " + karta.Linija.Polaziste + "-" + karta.Linija.Odrediste +
               "\r\n" + "Udaljenost: " + karta.Linija.Udaljenost + "\r\n" + "Autoprijevoznik: " + karta.Linija.Autoprijevoznik + "\r\n" +
               "Vrsta karte: " + karta.Vrsta + "\r\n" + "Povratna karta: " + (povratna == true ? "da" : "ne") + "\r\n" + "Naplati prtljagu: " +
               (prtljaga == true ? "da" : "ne") + "\r\n" + "--------------------------" + "\r\n" + "Cijena karte = " + karta.Cijena + " kn";
        }
    }
}
