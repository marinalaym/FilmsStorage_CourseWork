using FilmsStorage.Database;
using FilmsStorage.Models;
using FilmsStorage.Settings;

namespace FilmsStorage.Forms.Users
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text.Trim();
            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Поле Логин не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string password = tbPassword.Text.Trim();
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Поле Пароль не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User? user = UsersDB.Authorization(login, password);
            if (user is null)
            {
                MessageBox.Show("Логин или пароль введены неверно", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AppSettings.User = user;

            if (user.IsAdmin)
            {
                this.Hide();
                var adminInterface = new AdminInterface();
                adminInterface.Show();
            }
            else
            {
                this.Hide();
                var userInterface = new UserInterface();
                userInterface.Show();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registration = new Registration();
            registration.Show();
        }
    }
}
