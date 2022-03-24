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
    public partial class ProvediForm : Form
    {
        public ProvediForm()
        {
            InitializeComponent();
        }

        private void ProvediForm_Load(object sender, EventArgs e)
        {
            plateiteljTextBox.DataSource = Banka.DohvatiPopisRacuna();
            primateljTextBox.DataSource= Banka.DohvatiPopisRacuna();
            iznosTextBox.Text = "0";
            
        }
        
        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void provediButton_Click(object sender, EventArgs e)
        {
            Banka.ProvediTransakciju(plateiteljTextBox.SelectedItem as Racun,primateljTextBox.SelectedItem as Racun,Convert.ToDouble(iznosTextBox.Text));
            this.Close();
        }
    }
}
