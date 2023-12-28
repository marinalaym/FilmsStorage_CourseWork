using FilmsStorage.Database;
using FilmsStorage.Settings;

namespace FilmsStorage.Forms.Users
{
    public partial class UpdateProfile : Form
    {
        public UpdateProfile()
        {
            InitializeComponent();

            tbName.Text = AppSettings.User!.Name;
            tbLogin.Text = AppSettings.User!.Login;
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            var name = tbName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Поле Имя не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (name.Length < 2 || name.Length > 64)
            {
                MessageBox.Show("Имя должно содержать от 2 до 64 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var login = tbLogin.Text.Trim();
            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Поле Логин не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (login.Length < 4 || login.Length > 32)
            {
                MessageBox.Show("Логин должен содержать от 4 до 32 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (UsersDB.CheckExistsUserByLoginWithoutCurrentId(AppSettings.User!.Id, login))
            {
                MessageBox.Show("Данный логин уже используется!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AppSettings.User.Name = name;
            AppSettings.User.Login = login;

            UsersDB.UpdateUserNameAndLogin(AppSettings.User);

            this.Close();
        }
    }
}
