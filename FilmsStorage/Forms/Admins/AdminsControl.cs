using FilmsStorage.Database;
using FilmsStorage.Models;

namespace FilmsStorage.Forms.Admins
{
    public partial class AdminsControl : UserControl
    {
        public AdminsControl()
        {
            InitializeComponent();

            FillTableAllData();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            var addAdmin = new CreateAdmin();
            addAdmin.ShowDialog();

            FillTableAllData();
        }

        private void FillTableAllData()
        {
            FillTable(UsersDB.GetAllAdmins());
        }

        private void FillTable(IEnumerable<User> admins)
        {
            dgvAdmins.Rows.Clear();

            foreach (var admin in admins)
            {
                dgvAdmins.Rows.Add(new string[]
                {
                    admin.Id.ToString(),
                    admin.Name,
                    admin.Login,
                });
            }
        }
    }
}
