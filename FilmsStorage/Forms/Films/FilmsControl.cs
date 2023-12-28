using FilmsStorage.Database;
using FilmsStorage.Models;
using FilmsStorage.Settings;

namespace FilmsStorage.Forms.Films
{
    public partial class FilmsControl : UserControl
    {
        public FilmsControl()
        {
            InitializeComponent();

            if (!AppSettings.User!.IsAdmin)
            {
                btnAddFilm.Visible = false;
                dgvFilms.Height += 60;
            }

            FillTableAllData();
        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            var addFilm = new CreateFilm();
            addFilm.ShowDialog();

            FillTableAllData();
        }

        private void dgvFilms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvFilms.Rows[e.RowIndex];

            var idFilm = Convert.ToInt32(row.Cells["IdCol"].Value);

            var detailsFilm = new DetailsFilm(idFilm);
            detailsFilm.ShowDialog();

            FillTableAllData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var name = tbxSearch.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Заполните поисковые данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillTable(FilmsDB.SearchFilmsByName(name));
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            var filmFilters = new FilterFilms();
            if (filmFilters.ShowDialog() == DialogResult.OK)
            {
                var films = FilmsDB.GetFiltredFilms(filmFilters.Condition);
                FillTable(films);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FillTableAllData();
        }

        private void FillTableAllData()
        {
            FillTable(FilmsDB.GetAllFilms());
        }

        private void FillTable(IEnumerable<Film> films)
        {
            dgvFilms.Rows.Clear();

            foreach (var film in films)
            {
                dgvFilms.Rows.Add(new string[]
                {
                    film.Id.ToString(),
                    film.RussianName,
                    film.EnglishName ?? "-",
                    film.YearProduction.ToString(),
                    film.AgeRestriction,
                    film.Genres ?? "-",
                    film.Countries ?? "-",
                });
            }

            lbCountFilms.Text = $"(количество = {films.Count()})";
        }
    }
}
