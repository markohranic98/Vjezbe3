using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KucnaKnjiznicaLib;
namespace KucnaKnjiznica1
{
    public partial class Knjige : Form
    {
        private Knjiga dostupnaSelected;
        private Knjiga posudenaSelected;
        private Knjiznica knjiznica = new Knjiznica();
        public Knjige()
        {
            InitializeComponent();
        }

        private void posudiButton_Click(object sender, EventArgs e)
        {
            NovaPosudbaForm posudba = new NovaPosudbaForm(dostupnaSelected);
            posudba.ShowDialog();
            if (NovaPosudbaForm.Osoba != "")
            {
                knjiznica.PosudiKnjigu(dostupnaSelected,NovaPosudbaForm.Osoba);
            }
            KnjigeLoader();
        }

        private void vratiButton_Click(object sender, EventArgs e)
        {
            knjiznica.VratiKnjigu(posudenaSelected);
            KnjigeLoader();
        }

        private void Knjige_Load(object sender, EventArgs e)
        {
            KnjigeLoader();
        }

        private void KnjigeLoader()
        {
            posudeneKnjigeDGV.DataSource = null;
            posudeneKnjigeDGV.DataSource = knjiznica.DohvatiKnjigeNaPosudbi();
            dostupneKnjigeDGV.DataSource = null;
            dostupneKnjigeDGV.DataSource = knjiznica.DohvatiDostupneKnjige();

        }

        private void dostupneKnjigeDGV_SelectionChanged(object sender, EventArgs e)
        {
            dostupnaSelected = dostupneKnjigeDGV.CurrentRow.DataBoundItem as Knjiga;
        }

        private void posudeneKnjigeDGV_SelectionChanged(object sender, EventArgs e)
        {
            posudenaSelected = posudeneKnjigeDGV.CurrentRow.DataBoundItem as Knjiga;
        }
    }
}
