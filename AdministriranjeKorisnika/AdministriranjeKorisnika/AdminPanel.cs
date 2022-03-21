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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            List<User> users = UsersRepository.GetUsers();
            userDataGridView.DataSource = null;
            userDataGridView.DataSource = users;
        }

        private void activateButton_Click(object sender, EventArgs e)
        {
            User currentUser = userDataGridView.CurrentRow.DataBoundItem as User;
            UsersRepository.GetUser(currentUser.UserName).Status = UserStatus.Activated;
            activateButton.Enabled = false;
            deactivateButton.Enabled = true;
            Osvjezi();

        }

        private void deactivateButton_Click(object sender, EventArgs e)
        {
            User currentUser = userDataGridView.CurrentRow.DataBoundItem as User;
            UsersRepository.GetUser(currentUser.UserName).Status = UserStatus.Deactivated;
            activateButton.Enabled = true;
            deactivateButton.Enabled = false;
            Osvjezi();
        }

        private void userDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            User currentUser = userDataGridView.CurrentRow.DataBoundItem as User;
            if(currentUser.Status == UserStatus.Activated)
            {
                activateButton.Enabled = false;
                deactivateButton.Enabled = true;
            }
            else if(currentUser.Status == UserStatus.Deactivated)
            {
                activateButton.Enabled = true;
                deactivateButton.Enabled = false;
            }
        }
    }
}
