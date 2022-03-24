using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProvedbaIspitaLib;
namespace ProvedbaIspita
{
    public partial class RezultatiIspita : Form
    {
        public RezultatiIspita()
        {
            InitializeComponent();
            dataGridView1.DataSource = IspitManager.DohvatiRezultate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
