using FilmsStorage.Database;
using FilmsStorage.Forms.People;
using FilmsStorage.Forms.Selections;
using FilmsStorage.Models;
using FilmsStorage.Settings;

namespace FilmsStorage.Forms.Films
{
    public partial class DetailsFilm : Form
    {
        private Film _film;

        public DetailsFilm(int id)
        {
            InitializeComponent();

            if (AppSettings.User!.IsAdmin)
            {
                panelAdmin.Visible = true;
            }
            else
            {
                panelUser.Visible = true;
            }

            FillData(id);
        }

        private void btnUpdateFilm_Click(object sender, EventArgs e)
        {
            var updateFilm = new UpdateFilm(_film.Id);
            updateFilm.ShowDialog();

            FillData(_film.Id);
        }

        private void btnUpdateFilmCountries_Click(object sender, EventArgs e)
        {
            var updateFilmCountries = new UpdateFilmCountries(_film.Id);
            updateFilmCountries.ShowDialog();

            FillData(_film.Id);
        }

        private void btnUpdateFilmGenres_Click(object sender, EventArgs e)
        {
            var updateFilmGenres = new UpdateFilmGenres(_film.Id);
            updateFilmGenres.ShowDialog();

            FillData(_film.Id);
        }

        private void btnUpdateFilmPeople_Click(object sender, EventArgs e)
        {
            var updateFilmPeople = new UpdateFilmPeople(_film.Id);
            updateFilmPeople.ShowDialog();

            FillData(_film.Id);
        }

        private void btnDeleteFilm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить фильм?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                FilmsDB.DeleteFilm(_film.Id);
                this.Close();
            }
        }

        private void btnAddFilmInSelection_Click(object sender, EventArgs e)
        {
            var addFilmInSelection = new AddFilmInSelection(_film.Id);
            addFilmInSelection.ShowDialog();
        }

        private void dgvPeople_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvPeople.Rows[e.RowIndex];

            var idPerson = Convert.ToInt32(row.Cells["IdCol"].Value);

            var detailsPerson = new DetailsPerson(idPerson);
            detailsPerson.ShowDialog();

            FillData(_film.Id);
        }

        private void FillData(int id)
        {
            _film = FilmsDB.GetFilmById(id)!;
            _film.GenresList = FilmsDB.GetFilmGenresById(id);
            _film.CountriesList = FilmsDB.GetFilmCountriesById(id);
            _film.FilmPeople = FilmsDB.GetFilmPeopleById(id);

            lbRussianName.Text = _film.RussianName;
            lbEnglishName.Text = _film.EnglishName ?? "-";
            lbYearProduction.Text = _film.YearProduction.ToString();
            lbPremiereDate.Text = _film.PremiereDate.ToShortDateString();
            lbDuration.Text = _film.Duration.ToString();
            lbAgeRestriction.Text = _film.AgeRestriction;
            tbDescription.Text = _film.Description;

            if (_film.PathPhoto is not null)
            {
                pbFilmPhoto.Image = FileManager.GetImage(_film.PathPhoto);
            }

            lbGenre.Text = _film.GenresList.Count == 0 ? "-" : string.Join(", ", _film.GenresList.Select(c => c.Name));
            lbCountry.Text = _film.CountriesList.Count == 0 ? "-" : string.Join(", ", _film.CountriesList.Select(c => c.Name));

            FillTablePeople(_film.FilmPeople);
        }

        private void FillTablePeople(IEnumerable<FilmPerson> filmPeople)
        {
            dgvPeople.Rows.Clear();

            foreach (var filmPerson in filmPeople)
            {
                dgvPeople.Rows.Add(new string[]
                {
                    filmPerson.PersonId.ToString(),
                    filmPerson.Person!.Name,
                    filmPerson.Position!.Name
                });
            }

            lbCountPeople.Text = $"(количество = {_film.FilmPeople.Count})";
        }
    }
}
