using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KucnaKnjiznicaLib2;
namespace Knjiznica2
{
    public partial class KnjiznicaForm : Form
    {
        private Knjiznica knjiznica = new Knjiznica();
        public KnjiznicaForm()
        {
            InitializeComponent();
            trenutneRadioButton.CheckedChanged += (sender,e) => Osvjezi();
            knjigeDGV.SelectionChanged += (sender,e) => RestrictButton();
            vratiButton.Click += (sender, e) => Vrati();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Osvjezi();

        }

        private void Osvjezi()
        {
            if(svePosudbeRadio.Checked == true)
            {
                knjigeDGV.DataSource = knjiznica.DohvatiSvePosudbe();
            }
            else if(trenutneRadioButton.Checked == true)
            {
                knjigeDGV.DataSource = knjiznica.DohvatiTrenutnePosudbe();
            }
            else if (prosleRadioButton.Checked == true)
            {
                knjigeDGV.DataSource = knjiznica.DohvatiProslePosudbe();
            }
            Obojaj();
        }

        private void Obojaj()
        {
            foreach (DataGridViewRow row in knjigeDGV.Rows)
            {
                if(Convert.ToBoolean(row.Cells[4].Value) == true)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void RestrictButton()
        {
            if (Convert.ToBoolean(knjigeDGV.CurrentRow.Cells[4].Value) == true)
            {
                vratiButton.Enabled = false;
            }
            else
            {
                vratiButton.Enabled = true;
            }
        }

        private void Vrati()
        {
            if (Convert.ToBoolean(knjigeDGV.CurrentRow.Cells[4].Value) == false)
            {
                knjiznica.VratiKnjigu(knjigeDGV.CurrentRow.DataBoundItem as Posudba);
            }
            Osvjezi();
        }
	}
}

