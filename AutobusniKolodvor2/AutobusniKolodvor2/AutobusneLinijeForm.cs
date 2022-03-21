using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib2;

namespace AutobusniKolodvor2
{
    public partial class AutobusneLinijeForm : Form
    {
        public static Linija ProslijedenaLinija;
        public AutobusneLinijeForm()
        {
            InitializeComponent();
        }

        private void AutobusneLinijeForm_Load(object sender, EventArgs e)
        {
            AutobusniKolodvor kolodvor = new AutobusniKolodvor();
            linijeDataGridView.DataSource = kolodvor.DohvatiLinije();
        }

        private void pronadiButton_Click(object sender, EventArgs e)
        {
            if(odredisteTextBox.Text != "")
            {
                AutobusniKolodvor kolodvor = new AutobusniKolodvor();
                linijeDataGridView.DataSource = null;
                linijeDataGridView.DataSource = kolodvor.DohvatiLinije(odredisteTextBox.Text);
            }
            else
            {
                AutobusniKolodvor kolodvor = new AutobusniKolodvor();
                linijeDataGridView.DataSource = null;
                linijeDataGridView.DataSource = kolodvor.DohvatiLinije();
            }
            
        }

        private void kupiKartuButton_Click(object sender, EventArgs e)
        {
            ProslijedenaLinija = linijeDataGridView.CurrentRow.DataBoundItem as Linija;
            this.Hide();
            KupiKartuForm kupiKartuForm = new KupiKartuForm();
            kupiKartuForm.FormClosed += (s, args) => this.Close();
            kupiKartuForm.Show();

        }
    }
}
