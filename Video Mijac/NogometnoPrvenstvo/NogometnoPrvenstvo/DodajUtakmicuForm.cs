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
            int brojZgoditakaDomacina = int.Parse(brojZgoditakaDomacinaTextBox.Text);
            int brojZgoditakaGost = int.Parse(zgodiciGostTextBox.Text);

            DateTime datumUtakmice = DohvatiDatumUtakmice(datumTextBox.Text);
        }

        private DateTime DohvatiDatumUtakmice(string datum)
        {
            
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
