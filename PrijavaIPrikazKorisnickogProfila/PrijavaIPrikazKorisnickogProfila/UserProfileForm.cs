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
    public partial class UserProfileForm : Form
    {
        public UserProfileForm()
        {
            InitializeComponent();
        }

        public UserProfileForm(User user)
        {
            InitializeComponent();
            
            userNameTextBox.Text = user.UserName;
            passwordTextBox.Text = user.Password;
            firstnameTextBox.Text = user.FirstName;
            lastNameTextBox.Text = user.LastName;
            if(user.UserType == UserType.Guest)
            {
                passwordTextBox.ReadOnly = true;
                guestRadioButton.Checked = true;
            }
            else if(user.UserType == UserType.Employee)
            {
                passwordTextBox.ReadOnly = true;
                employeeRadioButton.Checked = true;
            }
            else
            {
                administratorRadioButton.Checked = true;
            }
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Autentificator.LoggedUser.Password = passwordTextBox.Text;
            Autentificator.LogOut();
            this.Close();
        }
    }
}
