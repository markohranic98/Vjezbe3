using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bodovi;

namespace BodoviIAktivnosti
{
    public partial class NoviBodoviForm : Form
    {
        
        private Student student;
        private Provjera provjera;
        public NoviBodoviForm()
        {
            InitializeComponent();
        }
        public NoviBodoviForm(Student _student, Provjera _provjera)
        {
            InitializeComponent();
            this.student = _student;
            this.provjera = _provjera;
            imePrezimeLabel.Text = student.ImePrezime;
            mabPointsLabel.Text = provjera.MoguciBodovi.ToString();
            vjezbaLabel.Text = provjera.Naziv;
            
            
        }
        private void prihvatiButton_Click(object sender, EventArgs e)
        {
          if(int.Parse(bodoviTextBox.Text) > -1 &&  int.Parse(bodoviTextBox.Text) <= provjera.MoguciBodovi &&
                student.BodoviNaProvjerama.Find(x=>x.Provjera.Naziv == provjera.Naziv) == null)
            {
                BodoviNaProvjeri bodoviNaProvjeri = new BodoviNaProvjeri();
                bodoviNaProvjeri.Provjera = provjera;
                bodoviNaProvjeri.Bodovi = int.Parse(bodoviTextBox.Text);
                BodoviStudenta.Studenti.Find(x => x.ImePrezime == student.ImePrezime).BodoviNaProvjerama.Add(bodoviNaProvjeri);
                this.Close();
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
