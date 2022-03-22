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
    public partial class BodoviStudenta : Form
    {
        public static List<Student> Studenti = new List<Student>();
        public static List<Provjera> Provjere = new List<Provjera>();
        private Student odabranStudent = null;
        private Provjera odabranaProvjera = null;

        public BodoviStudenta()
        {
            InitializeComponent();
        }

        private void BodoviStudenta_Load(object sender, EventArgs e)
        {
            ocjeniStudentaButton.Enabled = false;
        }

        private void OsvjeziDGV()
        {
            BindingSource bs = new BindingSource(Studenti, "");
            studentiDataGridView.DataSource = bs;
        }

        private void dodajStudentaButton_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                ImePrezime = imePrezimeStudentaTextBox.Text
            };
            Studenti.Add(student);
            imePrezimeStudentaTextBox.ResetText();
            OsvjeziDGV();
        }

        private void dodajProvjeruButton_Click(object sender, EventArgs e)
        {
            Provjera provjera = new Provjera
            {
                Naziv = nazivProvjereTextBox.Text,
                MoguciBodovi = int.Parse(bodoviTextBox.Text)
            };
            Provjere.Add(provjera);
            nazivProvjereTextBox.ResetText();
            bodoviTextBox.ResetText();
            popisProvjeraComboBox.Items.Clear();
            popisProvjeraComboBox.Items.AddRange(Provjere.ToArray());
        }

        private void studentiDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(studentiDataGridView.CurrentRow != null)
            {
                odabranStudent = studentiDataGridView.CurrentRow.DataBoundItem as Student;
            }
            if (odabranStudent != null && odabranaProvjera != null)
            {
                ocjeniStudentaButton.Enabled = true;
            }
            else
            {
                ocjeniStudentaButton.Enabled = false;
            }
        }

        private void ocjeniStudentaButton_Click(object sender, EventArgs e)
        {
            
            NoviBodoviForm noviBodoviForm = new NoviBodoviForm(odabranStudent, odabranaProvjera);
            noviBodoviForm.FormClosed += (s, args) => OsvjeziDGV();
            noviBodoviForm.ShowDialog();
        }

        private void popisProvjeraComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
            odabranaProvjera = popisProvjeraComboBox.SelectedItem as Provjera;
            if (odabranStudent != null && odabranaProvjera != null)
            {
                ocjeniStudentaButton.Enabled = true;
            }
            else
            {
                ocjeniStudentaButton.Enabled = false;
            }
        }
    }
}
