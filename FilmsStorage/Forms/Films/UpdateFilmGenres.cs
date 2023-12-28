using FilmsStorage.Database;

namespace FilmsStorage.Forms.Films
{
    public partial class UpdateFilmGenres : Form
    {
        private int _filmId;

        public UpdateFilmGenres(int id)
        {
            InitializeComponent();

            _filmId = id;

            FillTableGenres();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            if (dgvGenres.SelectedRows.Count == 0) return;

            var idGenre = dgvGenres.SelectedRows[0].Cells["IdCol"].Value.ToString()!;
            var nameGenre = dgvGenres.SelectedRows[0].Cells["NameCol"].Value.ToString()!;

            dgvFilmGenres.Rows.Add(new string[] { idGenre, nameGenre });

            dgvGenres.Rows.RemoveAt(dgvGenres.SelectedRows[0].Index);
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (dgvFilmGenres.SelectedRows.Count == 0) return;

            var idGenre = dgvFilmGenres.SelectedRows[0].Cells["IdColumn"].Value.ToString()!;
            var nameGenre = dgvFilmGenres.SelectedRows[0].Cells["NameColumn"].Value.ToString()!;

            dgvGenres.Rows.Add(new string[] { idGenre, nameGenre });

            dgvFilmGenres.Rows.RemoveAt(dgvFilmGenres.SelectedRows[0].Index);
        }

        private void btnUpdateFilmGenres_Click(object sender, EventArgs e)
        {
            var idGenres = new List<int>();
            foreach (DataGridViewRow row in dgvFilmGenres.Rows)
            {
                var idGenre = Convert.ToInt32(row.Cells["IdColumn"].Value);
                idGenres.Add(idGenre);
            }

            FilmsDB.UpdateFilmGenres(_filmId, idGenres);

            this.Close();
        }

        private void FillTableGenres()
        {
            var genres = GenresDB.GetAllGenres();
            var filmGenres = FilmsDB.GetFilmGenresById(_filmId);

            filmGenres.ForEach(fg => genres.RemoveAll(g => g.Id == fg.Id));

            dgvGenres.Rows.Clear();
            dgvFilmGenres.Rows.Clear();

            foreach (var genre in genres)
            {
                dgvGenres.Rows.Add(new string[]
                {
                    genre.Id.ToString(),
                    genre.Name
                });
            }

            foreach (var genre in filmGenres)
            {
                dgvFilmGenres.Rows.Add(new string[]
                {
                    genre.Id.ToString(),
                    genre.Name
                });
            }
        }
    }
}
