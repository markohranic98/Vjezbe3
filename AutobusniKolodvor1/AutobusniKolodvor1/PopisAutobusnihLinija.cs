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
    public partial class PopisAutobusnihLinija : Form
    {
        public PopisAutobusnihLinija()
        {
            InitializeComponent();
        }

        private void PopisAutobusnihLinija_Load(object sender, EventArgs e)
        {
            List<Linija> linijaList = AutobusniKolodvor.DohvatiLinije();
            popisLinijaDataGridView.DataSource = linijaList;
        }

        private void izlazButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void odaberiButton_Click(object sender, EventArgs e)
        {
            Linija linija = popisLinijaDataGridView.CurrentRow.DataBoundItem as Linija;
            KreiranjeKarteForm.ProslijedenaLinija = linija;
            Close();
        }

    }
}
