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
    public partial class BankaForm : Form
    {
        public BankaForm()
        {
            InitializeComponent();
        }

        private void BankaForm_Load(object sender, EventArgs e)
        {
            racuniDataGridView.DataSource = Banka.DohvatiPopisRacuna();
        }

        private void prikaziButton_Click(object sender, EventArgs e)
        {
            PopisTransakcija popis = new PopisTransakcija(racuniDataGridView.CurrentRow.DataBoundItem as Racun);
            popis.ShowDialog();
        }
    }
}
