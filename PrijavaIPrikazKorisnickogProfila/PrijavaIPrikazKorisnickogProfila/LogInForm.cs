using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutentifikacijaLib;
namespace PrijavaIPrikazKorisnickogProfila
{
    public partial class LogInForm : Form
    {
       
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            Autentificator.LogIn(usernameTextBox.Text, passwordTextBox.Text);

            if (usernameTextBox.Text == string.Empty || usernameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Username and password must be entered!");
            }
            
            else if(Autentificator.LoggedUser == null)
            {
                MessageBox.Show("Entered credentials are not valid!");
            }

            else
            {
                usernameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
                this.Hide();

                UserProfileForm userProfileForm = new UserProfileForm(Autentificator.LoggedUser);
                userProfileForm.FormClosed += (args, s) => this.Show();
                userProfileForm.Show();

            }
        }
    }
}
