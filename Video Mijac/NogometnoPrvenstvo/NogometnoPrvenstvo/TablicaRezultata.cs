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
    public partial class TablicaRezultata : Form
    {
        private Prvenstvo prvenstvo = Repozitorij.Prvenstvo;

        public TablicaRezultata()
        {
            InitializeComponent();

        }

        private void TablicaRezultata_Load(object sender, EventArgs e)
        {
            OsvjeziPopis();
        }

        private void OsvjeziPopis()
        {
            List<Utakmica> popisUtakmica = prvenstvo.DohvatiUtakmice();
            utakmiceDataGridView.DataSource = null;
            utakmiceDataGridView.DataSource = popisUtakmica;
        }

        private void obrisiButton_Click(object sender, EventArgs e)
        {
            DohvatiSelektiranuUtakmicu();
            prvenstvo.ObrisiUtakmicu(DohvatiSelektiranuUtakmicu());
            OsvjeziPopis();
        }

        private Utakmica DohvatiSelektiranuUtakmicu()
        {
            Utakmica utakmica = null;
            if(utakmiceDataGridView.CurrentRow != null)
            {
                utakmica = utakmiceDataGridView.CurrentRow.DataBoundItem as Utakmica;
            }
            return utakmica;
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            DodajUtakmicuForm form = new DodajUtakmicuForm();
            form.ShowDialog();
            OsvjeziPopis();
        }

        private void izmijeniButton_Click(object sender, EventArgs e)
        {
            
            IzmjeniUtakmicuForm uzakmicaIzmijeni = new IzmjeniUtakmicuForm(DohvatiSelektiranuUtakmicu());
            uzakmicaIzmijeni.ShowDialog();
            OsvjeziPopis();
        }
    }
}
