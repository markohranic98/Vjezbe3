using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentiTimoviLib;

namespace StudentiITimovi
{
    public partial class Form1 : Form
    {
        Tim tim;
        Student student;
        Student studentUTimu;
        public Form1()
        {
            InitializeComponent();
            timoviListBox.SelectedValueChanged += (a, s) => 
            { 
                tim = timoviListBox.SelectedItem as Tim;
                clanoviTimaListBox.DataSource = KolegijManager.DohvatiStudenteTima(tim);
            };
            nedodjeljenistudentiListBox.SelectedValueChanged += (sender, e) => student = nedodjeljenistudentiListBox.SelectedItem as Student;
            clanoviTimaListBox.SelectedValueChanged += (sender, e) => studentUTimu = clanoviTimaListBox.SelectedItem as Student;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            BindingSource bs = new BindingSource();
            BindingSource bs2 = new BindingSource();
            
            bs.DataSource = KolegijManager.DohvatiNedodijeljeneStudente();
            nedodjeljenistudentiListBox.DataSource = bs;
            bs2.DataSource = KolegijManager.DohvatiTimove();
            timoviListBox.DataSource = bs2;
            
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            KolegijManager.DodajUTim(student, tim);
            Osvjezi();
        }

        private void ukloniButton_Click(object sender, EventArgs e)
        {
            KolegijManager.UkloniIzTima(studentUTimu, tim);
            Osvjezi();
        }

        private void noviStudentButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Osvjezi();
        }
    }
}
