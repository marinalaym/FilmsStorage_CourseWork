using FilmsStorage.Database;
using FilmsStorage.Models;

namespace FilmsStorage.Forms.Users
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.IsAdmin = false;

            user.Name = tbName.Text.Trim();
            if (string.IsNullOrEmpty(user.Name))
            {
                MessageBox.Show("Поле Имя не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (user.Name.Length < 2 || user.Name.Length > 64)
            {
                MessageBox.Show("Имя должно содержать от 2 до 64 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            user.Login = tbLogin.Text.Trim();
            if (string.IsNullOrEmpty(user.Login))
            {
                MessageBox.Show("Поле Логин не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (user.Login.Length < 4 || user.Login.Length > 32)
            {
                MessageBox.Show("Логин должен содержать от 4 до 32 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            user.Password = tbPassword.Text.Trim();
            if (string.IsNullOrEmpty(user.Password))
            {
                MessageBox.Show("Поле Пароль не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (user.Password.Length < 4 || user.Password.Length > 32)
            {
                MessageBox.Show("Пароль должен содержать от 4 до 32 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string repeatPassword = tbRepeatPassword.Text.Trim();
            if (string.IsNullOrEmpty(repeatPassword))
            {
                MessageBox.Show("Повторите пароль!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (user.Password != repeatPassword)
            {
                MessageBox.Show("Пароли не совпадают!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (UsersDB.CheckExistsUserByLogin(user.Login))
            {
                MessageBox.Show("Данный логин уже используется!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UsersDB.Registration(user);
            MessageBox.Show("Регисрация прошла успешно!\nПожалуйста авторизуйтесь.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var authorization = new Authorization();
            authorization.Show();
            this.Close();
        }

        private void btnAuthorization_Click(object sender, EventArgs e)
        {
            var authorization = new Authorization();
            authorization.Show();
            this.Close();
        }
    }
}
