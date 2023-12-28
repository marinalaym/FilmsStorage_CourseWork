using FilmsStorage.Database;
using FilmsStorage.Models;

namespace FilmsStorage.Forms.Selections
{
    public partial class CreateSelection : Form
    {
        public CreateSelection()
        {
            InitializeComponent();
        }

        private void btnAddSelection_Click(object sender, EventArgs e)
        {
            var selection = new Selection();

            selection.Name = tbName.Text.Trim();
            if (string.IsNullOrEmpty(selection.Name))
            {
                MessageBox.Show("Поле Название не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selection.Name.Length < 2 || selection.Name.Length > 100)
            {
                MessageBox.Show("Название должно содержать от 2 до 100 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selection.Description = tbDescription.Text.Trim();
            if (string.IsNullOrEmpty(selection.Description))
            {
                MessageBox.Show("Поле Описание не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SelectionsDB.CheckExistsSelectionByName(selection.Name))
            {
                MessageBox.Show("Данная подборка уже существует!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SelectionsDB.CreateSelection(selection);

            this.Close();
        }
    }
}
