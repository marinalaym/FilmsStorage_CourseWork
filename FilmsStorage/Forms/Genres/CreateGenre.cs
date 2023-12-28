using FilmsStorage.Database;
using FilmsStorage.Models;

namespace FilmsStorage.Forms.Genres
{
    public partial class CreateGenre : Form
    {
        public CreateGenre()
        {
            InitializeComponent();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            var genre = new Genre();

            genre.Name = tbName.Text.Trim();
            if (string.IsNullOrEmpty(genre.Name))
            {
                MessageBox.Show("Поле Название не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (genre.Name.Length < 2 || genre.Name.Length > 32)
            {
                MessageBox.Show("Название должно содержать от 2 до 32 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (GenresDB.CheckExistsGenreByName(genre.Name))
            {
                MessageBox.Show("Данный жанр уже существует!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GenresDB.CreateGenre(genre);

            this.Close();
        }
    }
}
