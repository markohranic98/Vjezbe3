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
namespace FiltriranjeTransakcija
{
    public partial class DetaljiForm : Form
    {
        public DetaljiForm()
        {
            InitializeComponent();
        }
        public DetaljiForm(Racun _racun)
        {
            InitializeComponent();
            vlasnikText.Text = _racun.Vlasnik;
            ibanText.Text = _racun.IBAN;
            stanjeText.Text = _racun.Stanje.ToString();
            ukupanPrometText.Text = _racun.IzracunajUkupanPromet().ToString();

        }

        private void DetaljiForm_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
