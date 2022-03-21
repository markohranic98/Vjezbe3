using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministriranjeKorisnika
{
    public partial class LoginFail : Form
    {
        public LoginFail()
        {
            InitializeComponent();
            this.label1.Visible = false;
            this.label2.Visible = false;
        }

        public LoginFail(int mode)
        {
            InitializeComponent();
            if(mode == 0) //user found not admin
            {
                label1.Visible = true;
            }
            else if (mode == 1)
            {
                label2.Visible = true;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            label2.Visible=false;
            label1.Visible=false;
            this.Close();
        }

        private void LoginFail_Load(object sender, EventArgs e)
        {

        }
    }
}
