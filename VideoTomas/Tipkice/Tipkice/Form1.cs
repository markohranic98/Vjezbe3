using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tipkice
{
    public partial class Form1 : Form
    {
        private Button trenutni = null;
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            pocetnaTipka.BackColor = Color.Green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pocetnaTipka.Click += UniverzalniKlik;
            pocetnaTipka.Tag = false;
        }

        private Point novaLokacija(Point pocetna)
        {
            Random rand = new Random();
            int minX = -100;
            int minY = -100;
            if (pocetna.Y < 100)
            {
                minY = 0;
            }
            if (pocetna.X < 100)
            {
                minX = 0;
            }
            return new Point(pocetna.X+rand.Next(minX,100), pocetna.Y+rand.Next(minY,100));
        }


        private void UniverzalniKlik(object sender, EventArgs e)
        {
            trenutni = (sender as Button);
            trenutni.BackColor= Color.Red;
            
            if ((bool)trenutni.Tag == false) 
            {
                for (int i = 0; i < rand.Next(1, 5); i++)
                {
                    Button novi = new Button();
                    novi.Tag = false;
                    novi.BackColor = Color.Green;
                    novi.Click += UniverzalniKlik;
                    novi.Text = "Stisni me!";
                    novi.Location = novaLokacija(trenutni.Location);
                    this.Controls.Add(novi);
                }
            }
            trenutni.Tag = true;
        }
    }
}
