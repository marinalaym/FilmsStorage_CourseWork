using FilmsStorage.Database;
using FilmsStorage.Models;

namespace FilmsStorage.Forms.Selections
{
    public partial class UpdateSelection : Form
    {
        private Selection _selection;

        public UpdateSelection(int id)
        {
            InitializeComponent();

            _selection = SelectionsDB.GetSelectionById(id)!;

            tbName.Text = _selection.Name;
            tbDescription.Text = _selection.Description;
        }

        private void btnUpdateSelection_Click(object sender, EventArgs e)
        {
            _selection.Name = tbName.Text.Trim();
            if (string.IsNullOrEmpty(_selection.Name))
            {
                MessageBox.Show("Поле Название не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_selection.Name.Length < 2 || _selection.Name.Length > 100)
            {
                MessageBox.Show("Название должно содержать от 2 до 100 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _selection.Description = tbDescription.Text.Trim();
            if (string.IsNullOrEmpty(_selection.Description))
            {
                MessageBox.Show("Поле Описание не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SelectionsDB.CheckExistsSelectionByNameWithoutCurrentId(_selection.Id, _selection.Name))
            {
                MessageBox.Show("Данная подборка уже существует!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SelectionsDB.UpdateSelection(_selection);

            this.Close();
        }
    }
}
