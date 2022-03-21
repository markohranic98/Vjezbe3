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
namespace AdministriranjeKorisnika
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UsersRepository usersRepository = new UsersRepository();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            Autentificator.LogIn(username, password);
            User user = new User();
            user = Autentificator.LoggedUser;


            if(user != null && user.UserType != UserType.Administrator)
            {
                LoginFail loginFail = new LoginFail(0);
                loginFail.ShowDialog();
            }
            else if(user == null)
            {
                LoginFail loginFail = new LoginFail(1);
                loginFail.ShowDialog();
            }
            else
            {
                this.Hide();
                AdminPanel adminPanel = new AdminPanel();
                
                adminPanel.FormClosed += (s,args) => this.Close();
                adminPanel.Show();
            }

        }
    }
}
