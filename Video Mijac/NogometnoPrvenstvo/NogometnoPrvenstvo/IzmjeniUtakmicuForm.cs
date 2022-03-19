using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrvenstvoLib;
namespace NogometnoPrvenstvo
{
    public partial class IzmjeniUtakmicuForm : Form
    {
        private Utakmica postojecaUtakmica;
        public IzmjeniUtakmicuForm(Utakmica utakmica)
        {
            InitializeComponent();
            postojecaUtakmica = utakmica;
        }

        private void IzmjeniUtakmicuForm_Load(object sender, EventArgs e)
        {
            domacinComboBox.DataSource = Repozitorij.PopisReprezentacija.ToList();
            domacinComboBox.SelectedItem = postojecaUtakmica.Domacin;
            gostComboBox.DataSource = Repozitorij.PopisReprezentacija.ToList();
            gostComboBox.SelectedItem = postojecaUtakmica.Gost;

            zgodiciGostTextBox.Text = postojecaUtakmica.BrojZgoditakaGost.ToString();
            brojZgoditakaDomacinaTextBox.Text = postojecaUtakmica.BrojZgoditakaDomacin.ToString();

            datumTextBox.Text = postojecaUtakmica.Datum.ToShortDateString();
            if(postojecaUtakmica.Status == StatusUtakmice.Zakazana)
            {
                zakazanoRadioButton.Checked = true;
            }
            else
            {
                odigranaRadioButton.Checked = true;
            }
        }

        private void spremibutton_Click(object sender, EventArgs e)
        {
            Reprezentacija domacin = domacinComboBox.SelectedItem as Reprezentacija;
            Reprezentacija gost = gostComboBox.SelectedItem as Reprezentacija;

            int brojZgoditakaDomacina = int.Parse(brojZgoditakaDomacinaTextBox.Text);
            int brojZgoditakaGost = int.Parse(zgodiciGostTextBox.Text);

            
            DateTime datumUtakmice = DohvatiDatumUtakmice(datumTextBox.Text);
            StatusUtakmice status = DohvatiStatusUtakmice();

            

            postojecaUtakmica.Status = status;
            postojecaUtakmica.Domacin = domacin;
            postojecaUtakmica.Gost = gost;
            postojecaUtakmica.BrojZgoditakaDomacin = brojZgoditakaDomacina;
            postojecaUtakmica.BrojZgoditakaGost = brojZgoditakaGost;
            postojecaUtakmica.Datum = datumUtakmice;
            
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
