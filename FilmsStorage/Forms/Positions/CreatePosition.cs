using FilmsStorage.Database;
using FilmsStorage.Models;

namespace FilmsStorage.Forms.Positions
{
    public partial class CreatePosition : Form
    {
        public CreatePosition()
        {
            InitializeComponent();
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            var position = new Position();

            position.Name = tbName.Text.Trim();
            if (string.IsNullOrEmpty(position.Name))
            {
                MessageBox.Show("Поле Название не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (position.Name.Length < 2 || position.Name.Length > 64)
            {
                //2
                MessageBox.Show("Название должно содержать от 2 до 64 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PositionsDB.CheckExistsPositionByName(position.Name))
            {
                MessageBox.Show("Данная должность уже существует!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PositionsDB.CreatePosition(position);

            this.Close();
        }
    }
}
