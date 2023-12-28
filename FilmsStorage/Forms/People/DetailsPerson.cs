using FilmsStorage.Database;
using FilmsStorage.Forms.Films;
using FilmsStorage.Models;
using FilmsStorage.Settings;

namespace FilmsStorage.Forms.People
{
    public partial class DetailsPerson : Form
    {
        private Person _person;

        public DetailsPerson(int id)
        {
            InitializeComponent();

            if (AppSettings.User!.IsAdmin)
            {
                panelAdmin.Visible = true;
            }

            FillData(id);
        }

        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            var updatePerson = new UpdatePerson(_person.Id);
            updatePerson.ShowDialog();

            FillData(_person.Id);
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этого человека?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                PeopleDB.DeletePerson(_person.Id);
                this.Close();
            }
        }

        private void dgvFilms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvFilms.Rows[e.RowIndex];

            var idFilm = Convert.ToInt32(row.Cells["IdCol"].Value);

            var detailsFilm = new DetailsFilm(idFilm);
            detailsFilm.ShowDialog();

            FillData(_person.Id);
        }

        private void FillData(int id)
        {
            _person = PeopleDB.GetPersonById(id)!;
            _person.Films = PeopleDB.GetPersonFilmsById(id);

            lbName.Text = _person.Name;
            lbDateBirth.Text = _person.DateBirth.ToShortDateString();
            lbDateDeath.Text = _person.DateDeath?.ToShortDateString() ?? "-";
            lbCountry.Text = _person.Country!.Name;

            if (_person.PathPhoto is not null)
            {
                pbPersonPhoto.Image = FileManager.GetImage(_person.PathPhoto);
            }

            FillTableFilms(_person.Films);
        }

        private void FillTableFilms(IEnumerable<Film> films)
        {
            dgvFilms.Rows.Clear();

            foreach (var film in films)
            {
                dgvFilms.Rows.Add(new string[]
                {
                    film.Id.ToString(),
                    film.RussianName,
                    film.EnglishName?.ToString() ?? "-",
                    film.YearProduction.ToString(),
                    film.FilmPeople.First().Position!.Name,
                });
            }

            lbCountFilms.Text = $"(количество = {films.Count()})";
        }
    }
}
