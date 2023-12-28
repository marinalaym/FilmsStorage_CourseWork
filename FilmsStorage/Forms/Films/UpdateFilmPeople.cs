using FilmsStorage.Database;
using FilmsStorage.Models;

namespace FilmsStorage.Forms.Films
{
    public partial class UpdateFilmPeople : Form
    {
        private int _filmId;

        public UpdateFilmPeople(int id)
        {
            InitializeComponent();

            _filmId = id;

            FillTablePeople();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            if (dgvPeople.SelectedRows.Count == 0) return;

            var choosePosition = new ChoosePosition();
            if (choosePosition.ShowDialog() != DialogResult.OK) return;

            var idPerson = dgvPeople.SelectedRows[0].Cells["IdCol"].Value.ToString()!;
            var namePerson = dgvPeople.SelectedRows[0].Cells["NameCol"].Value.ToString()!;

            dgvFilmPeople.Rows.Add(new string[]
            {
                idPerson,
                namePerson,
                choosePosition.Position!.Id.ToString(),
                choosePosition.Position.Name
            });

            dgvPeople.Rows.RemoveAt(dgvPeople.SelectedRows[0].Index);
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            if (dgvFilmPeople.SelectedRows.Count == 0) return;

            var idPerson = dgvFilmPeople.SelectedRows[0].Cells["IdPersonColumn"].Value.ToString()!;
            var namePerson = dgvFilmPeople.SelectedRows[0].Cells["NameColumn"].Value.ToString()!;

            dgvPeople.Rows.Add(new string[] { idPerson, namePerson });

            dgvFilmPeople.Rows.RemoveAt(dgvFilmPeople.SelectedRows[0].Index);
        }

        private void btnUpdateFilmPeople_Click(object sender, EventArgs e)
        {
            var filmPeoples = new List<FilmPerson>();
            foreach (DataGridViewRow row in dgvFilmPeople.Rows)
            {
                filmPeoples.Add(new FilmPerson()
                {
                    FilmId = _filmId,
                    PersonId = Convert.ToInt32(row.Cells["IdPersonColumn"].Value),
                    PositionId = Convert.ToInt32(row.Cells["IdPositionCol"].Value)
                });
            }

            FilmsDB.UpdateFilmPeople(_filmId, filmPeoples);

            this.Close();
        }

        private void FillTablePeople()
        {
            var people = PeopleDB.GetAllPeople();
            var filmPeople = FilmsDB.GetFilmPeopleById(_filmId);

            filmPeople.ForEach(fp => people.RemoveAll(p => p.Id == fp.PersonId));

            dgvPeople.Rows.Clear();
            dgvFilmPeople.Rows.Clear();

            foreach (var person in people)
            {
                dgvPeople.Rows.Add(new string[]
                {
                    person.Id.ToString(),
                    person.Name
                });
            }

            foreach (var person in filmPeople)
            {
                dgvFilmPeople.Rows.Add(new string[]
                {
                    person.PersonId.ToString(),
                    person.Person!.Name,
                    person.PositionId.ToString(),
                    person.Position!.Name
                });
            }
        }
    }
}
