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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ureduButton_Click(object sender, EventArgs e)
        {
            KolegijManager.DodajNovogStudenta(new Student(jmbagText.Text, imeText.Text, prezimeText.Text));
            this.Close();
        }
    }
}
