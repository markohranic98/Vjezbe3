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

namespace ProvedbaISortiranjeTransakcija
{
    public partial class PopisTransakcijaForm : Form
    {
        
        Transakcija trenutnaTransakcija;
        public PopisTransakcijaForm()
        {
            InitializeComponent();
            
           transakcijeDataGridView.SelectionChanged += (a,e)=> trenutnaTransakcija = transakcijeDataGridView.CurrentRow.DataBoundItem as Transakcija;
        }

        void Osvjezi()
        {
            transakcijeDataGridView.DataSource = null;
            transakcijeDataGridView.DataSource = Banka.DohvatiPopisTransakcija();
        }

        private void stornirajButton_Click(object sender, EventArgs e)
        {
                
                Banka.StornirajTransakciju(trenutnaTransakcija);
                Osvjezi();
            
        }

        private void PopisTransakcijaForm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void provediTransakciju_Click(object sender, EventArgs e)
        {
            ProvediForm provediForm = new ProvediForm();
            provediForm.ShowDialog(); // .Show();
            Osvjezi();
        }
    }
}
