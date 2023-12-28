using FilmsStorage.Database;
using FilmsStorage.Settings;

namespace FilmsStorage.Forms.Users
{
    public partial class ProfileControl : UserControl
    {
        Form _parent;

        public ProfileControl(Form parent)
        {
            InitializeComponent();

            _parent = parent;
            FillData();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            var updateProfile = new UpdateProfile();
            updateProfile.ShowDialog();

            FillData();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            var updatePassword = new UpdatePassword();
            updatePassword.ShowDialog();
        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить профиль?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UsersDB.DeleteUser(AppSettings.User!.Id);
                AppSettings.User = null;

                var authorization = new Authorization();
                authorization.Show();
                _parent.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            AppSettings.User = null;

            var authorization = new Authorization();
            authorization.Show();
            _parent.Close();
        }

        private void FillData()
        {
            lbName.Text = AppSettings.User!.Name;
            lbLogin.Text = AppSettings.User!.Login;
            lbRole.Text = AppSettings.User!.IsAdmin ? "Админ" : "Пользователь";
        }
    }
}
