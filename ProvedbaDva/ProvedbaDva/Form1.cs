using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProvedbaIspitaLib2;

namespace ProvedbaDva
{
    public partial class Form1 : Form
    {
        Pitanje trenutnoPitanje = null;
        Odgovor[] trenutniOdgovori = null;
        IspitManager ispitManager = new IspitManager();
        public Form1()
        {
            InitializeComponent();
            drugiButton.Click += (s,e) => ispitManager.PotvrdiPitanje(trenutnoPitanje, trenutniOdgovori[1]);
            treciButton.Click += (s,e) => Oboji();
            treciButton.Click += (s,e) => ispitManager.PotvrdiPitanje(trenutnoPitanje, trenutniOdgovori[2]);
            cetvrtiButton.Click += (s,e) => ispitManager.PotvrdiPitanje(trenutnoPitanje, trenutniOdgovori[3]);
            cetvrtiButton.Click += (s, e) => Oboji(); ;
            drugiButton.Click += (s, e) => Oboji();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DohvatiPitanje();
        }

        private void DohvatiPitanje()
        {
            Pitanje pitanje = ispitManager.SljedecePitanje();
            Odgovor[] odgovori = ispitManager.DohvatiOdgovore(pitanje).ToArray();
            textBox1.Text = pitanje.Tekst;

            prviButton.Text = odgovori[0].Tekst;
            drugiButton.Text = odgovori[1].Tekst;
            treciButton.Text = odgovori[2].Tekst;
            cetvrtiButton.Text = odgovori[3].Tekst;
            trenutnoPitanje = pitanje;
            trenutniOdgovori = odgovori;
            Oboji();
        }

        private void prviButton_Click(object sender, EventArgs e)
        {
            ispitManager.PotvrdiPitanje(trenutnoPitanje, trenutniOdgovori[0]);
            Oboji();
        }

        private void prethodnoButton_Click(object sender, EventArgs e)
        {
            Pitanje pitanje = ispitManager.PrethodnoPitanje();
            Odgovor[] odgovori = ispitManager.DohvatiOdgovore(pitanje).ToArray();
            textBox1.Text = pitanje.Tekst;

            prviButton.Text = odgovori[0].Tekst;
            drugiButton.Text = odgovori[1].Tekst;
            treciButton.Text = odgovori[2].Tekst;
            cetvrtiButton.Text = odgovori[3].Tekst;
            trenutnoPitanje = pitanje;
            trenutniOdgovori = odgovori;

            Oboji();
            
        }

        private void Oboji()
        {
            if (trenutnoPitanje.Status == StatusPitanja.TocnoOdgovoreno)
            {
                textBox1.BackColor = Color.Green;
                prviButton.Enabled = false;
                drugiButton.Enabled = false;
                treciButton.Enabled = false;
                cetvrtiButton.Enabled = false;
            }
            else if (trenutnoPitanje.Status == StatusPitanja.NetocnoOdgovoreno)
            {
                textBox1.BackColor = Color.Red;
                prviButton.Enabled = false;
                drugiButton.Enabled = false;
                treciButton.Enabled = false;
                cetvrtiButton.Enabled = false;
            }
            else
            {
                prviButton.Enabled = true;
                drugiButton.Enabled = true;
                treciButton.Enabled = true;
                cetvrtiButton.Enabled = true;
                textBox1.BackColor = Color.Gray;

            }
        }

        private void sljedeceButton_Click(object sender, EventArgs e)
        {
            DohvatiPitanje();
        }
    }
}
