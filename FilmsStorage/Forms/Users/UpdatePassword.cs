using FilmsStorage.Database;
using FilmsStorage.Settings;

namespace FilmsStorage.Forms.Users
{
    public partial class UpdatePassword : Form
    {
        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            var oldPassword = tbOldPassword.Text.Trim();
            if (string.IsNullOrEmpty(oldPassword))
            {
                MessageBox.Show("Поле Старый пароль не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (AppSettings.GetHash(oldPassword) != AppSettings.User!.Password)
            {
                MessageBox.Show("Старый пароль введён неверно!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var password = tbPassword.Text.Trim();
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Поле Пароль не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password.Length < 4 || password.Length > 32)
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
            if (password != repeatPassword)
            {
                MessageBox.Show("Пароли не совпадают!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UsersDB.UpdateUserPassword(AppSettings.User!.Id, password);
            AppSettings.User!.Password = AppSettings.GetHash(password);

            MessageBox.Show("Пароль изменён!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
