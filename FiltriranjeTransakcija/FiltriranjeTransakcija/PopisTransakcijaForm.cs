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
    public partial class PopisTransakcijaForm : Form
    {
        public static Racun selectedRacun;
        public PopisTransakcijaForm()
        {
            InitializeComponent();
        }

        private void PopisTransakcijaForm_Load(object sender, EventArgs e)
        {
            racunComboBox.Items.AddRange(Banka.DohvatiPopisRacuna().ToArray());
            sveRadioButton.Checked = true;
            detaljiRacunaButton.Enabled = false;
        }

        private void racunComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedRacun = racunComboBox.SelectedItem as Racun;
            if (selectedRacun == null)
            {
                detaljiRacunaButton.Enabled = false;
            }
            else
            {
                detaljiRacunaButton.Enabled = true;
            }
        }

        private void filtrirajButton_Click(object sender, EventArgs e)
        {
            
            if(sveRadioButton.Checked == true)
            {
                racunDataGridView.DataSource = selectedRacun.DohvatiTransakcije();
            }
            else if(isplateRadioButton.Checked == true)
            {
                racunDataGridView.DataSource=selectedRacun.DohvatiIsplate();
                
            }
            else if(uplateRadioButton.Checked == true)
            {
                racunDataGridView.DataSource = selectedRacun.DohvatiUplate();
            }


        }

        private void ocistiButton_Click(object sender, EventArgs e)
        {
            racunDataGridView.DataSource = null;
            sveRadioButton.Checked = true;
            racunComboBox.SelectedIndex  = 0;
        }

        private void detaljiRacunaButton_Click(object sender, EventArgs e)
        {
            DetaljiForm detaljiForm = new DetaljiForm(selectedRacun);
            detaljiForm.ShowDialog();
        }
    }
}
