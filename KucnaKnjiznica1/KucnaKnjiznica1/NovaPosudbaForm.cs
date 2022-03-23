using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KucnaKnjiznicaLib;
namespace KucnaKnjiznica1
{
    public partial class NovaPosudbaForm : Form
    {
        public static string Osoba;
        public NovaPosudbaForm()
        {
            InitializeComponent();

        }
        public NovaPosudbaForm(Knjiga _knjiga)
        {
            InitializeComponent();
            isbnTextBox.Text = _knjiga.ISBN;
            naslovTextBox.Text = _knjiga.Naslov;
            Osoba = "";
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Osoba = osobaTextBox.Text;
            this.Close();
        }
    }
}
