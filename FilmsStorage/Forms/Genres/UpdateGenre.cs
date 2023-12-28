using FilmsStorage.Database;
using FilmsStorage.Models;

namespace FilmsStorage.Forms.Genres
{
    public partial class UpdateGenre : Form
    {
        private Genre _genre;

        public UpdateGenre(int id)
        {
            InitializeComponent();

            _genre = GenresDB.GetGenreById(id)!;

            tbName.Text = _genre.Name;
        }

        private void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            _genre.Name = tbName.Text.Trim();
            if (string.IsNullOrEmpty(_genre.Name))
            {
                MessageBox.Show("Поле Название не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_genre.Name.Length < 2 || _genre.Name.Length > 32)
            {
                MessageBox.Show("Название должно содержать от 2 до 32 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (GenresDB.CheckExistsGenreByNameWithoutCurrentId(_genre.Id, _genre.Name))
            {
                MessageBox.Show("Данный жанр уже существует!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GenresDB.UpdateGenre(_genre);

            this.Close();
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот жанр?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                GenresDB.DeleteGenre(_genre.Id);
                this.Close();
            }
        }
    }
}
