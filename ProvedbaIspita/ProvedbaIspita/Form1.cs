using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProvedbaIspitaLib;

namespace ProvedbaIspita
{
    public partial class Form1 : Form
    {
        Odgovor odgovor;
        Pitanje pitanje;
        public Form1()
        {
            InitializeComponent();
            odgovoriListBox.SelectedValueChanged += (sender,e) => odgovor = odgovoriListBox.SelectedItem as Odgovor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //sljedecePitanjeButton_Click(sender, e);
            pitanje = IspitManager.SljedecePitanje();
            potvrdenOdgovorTextBox.Text = String.Empty;
            pitanjeTextBox.Text = pitanje.Tekst;
            odgovoriListBox.DataSource = null;
            odgovoriListBox.DataSource = pitanje.DohvatiOdgovore().ToList();

        }

        private void sljedecePitanjeButton_Click(object sender, EventArgs e)
        {
            if(pitanje.KorisnikovOdgovor== null && pitanje!= null)
            {
                MessageBox.Show("WARNING");
            }
            else if (IspitManager.ImaJosPitanja() == true)
            {
                do
                {
                    pitanje = IspitManager.SljedecePitanje();
                } while (pitanje.KorisnikovOdgovor != null);

                potvrdenOdgovorTextBox.Text = String.Empty;
                pitanjeTextBox.Text = pitanje.Tekst;
                odgovoriListBox.DataSource = null;
                odgovoriListBox.DataSource = pitanje.DohvatiOdgovore().ToList();
            }
            else
            {
                RezultatiIspita rezultatiIspita = new RezultatiIspita();
                rezultatiIspita.ShowDialog();

            }
        }

        private void potvrdiOdgovorButton_Click(object sender, EventArgs e)
        {
            if(odgovor!= null && pitanje!= null)
            {
                pitanje.PotvrdiOdgovor(odgovor);
                potvrdenOdgovorTextBox.Text = odgovor.Tekst;
                pitanje.JeOdgovoreno();                
            }
        }

        
    }
}
