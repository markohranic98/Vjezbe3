using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankaLib;
namespace RacuniITransakcije
{
    public partial class PopisTransakcija : Form
    {
        private Racun trenutniRacun;
        public PopisTransakcija()
        {
            InitializeComponent();
            
        }

        public PopisTransakcija(Racun _racun)
        {
            InitializeComponent();
            ibanTextBox.Text = _racun.IBAN;
            VlasnikTextBox.Text = _racun.Vlasnik;
            stanjeTextBox.Text = _racun.Stanje.ToString();
            dataGridView1.DataSource = _racun.DohvatiTransakcije();
            sveButton.Checked = true;
            trenutniRacun = _racun;
        }

        private void PopisTransakcija_Load(object sender, EventArgs e)
        {

        }

        private void primijeniButton_Click(object sender, EventArgs e)
        {
            if(sveButton.Checked == true)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = trenutniRacun.DohvatiTransakcije();
            }
            if(isplateButton.Checked == true)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = trenutniRacun.DohvatiIsplate();
            }
            if (uplateButton.Checked == true)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = trenutniRacun.DohvatiUplate();
            }
        }
    }
}
