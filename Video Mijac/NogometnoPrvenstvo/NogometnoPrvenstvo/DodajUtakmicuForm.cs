using PrvenstvoLib;
using System;
using System.Linq;
using System.Windows.Forms;
namespace NogometnoPrvenstvo
{
    public partial class DodajUtakmicuForm : Form
    {
        public DodajUtakmicuForm()
        {
            InitializeComponent();
        }

        private void DodajUtakmicuForm_Load(object sender, EventArgs e)
        {
            domacinComboBox.DataSource = Repozitorij.PopisReprezentacija.ToList();
            gostComboBox.DataSource = Repozitorij.PopisReprezentacija.ToList();

            brojZgoditakaDomacinaTextBox.Text = "0";
            zgodiciGostTextBox.Text = "0";
            datumTextBox.Text = DateTime.Now.Date.ToShortDateString();
            zakazanoRadioButton.Checked = true;
        }

        private void spremibutton_Click(object sender, EventArgs e)
        {
            Reprezentacija domacin = domacinComboBox.SelectedItem as Reprezentacija;
            Reprezentacija gost = gostComboBox.SelectedItem as Reprezentacija;

            if (domacin == gost)
            {
                MessageBox.Show("Domaćin i gost ne mogu biti ista reprezentacija");
                return;
            }

            int brojZgoditakaDomacina = int.Parse(brojZgoditakaDomacinaTextBox.Text);
            int brojZgoditakaGost = int.Parse(zgodiciGostTextBox.Text);

            if (brojZgoditakaDomacina < 0 && brojZgoditakaGost < 0)
            {
                MessageBox.Show("Broj zgoditaka ne moze bit manji od 0");
                return;
            }

            DateTime datumUtakmice = DohvatiDatumUtakmice(datumTextBox.Text);
            StatusUtakmice status = DohvatiStatusUtakmice();
            Utakmica utakmica = new Utakmica();
            utakmica.Status = status;
            utakmica.Domacin = domacin;
            utakmica.Gost = gost;
            utakmica.BrojZgoditakaDomacin = brojZgoditakaDomacina;
            utakmica.BrojZgoditakaGost = brojZgoditakaGost;
            utakmica.Datum = datumUtakmice;
            Repozitorij.Prvenstvo.DodajUtakmicu(utakmica);
            Close();
        }

        private StatusUtakmice DohvatiStatusUtakmice()
        {
            if (zakazanoRadioButton.Checked == true)
            {
                return StatusUtakmice.Zakazana;
            }
            else return StatusUtakmice.Odigrana;
        }

        private DateTime DohvatiDatumUtakmice(string datum)
        {
            string[] polje = datum.Split('.');
            int dan = int.Parse(polje[0]);
            int mjesec = int.Parse(polje[1]);
            int godina = int.Parse(polje[2]);
            return new DateTime(godina, mjesec, dan);
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
