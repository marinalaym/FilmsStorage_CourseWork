using FilmsStorage.Database;
using FilmsStorage.Forms.Films;
using FilmsStorage.Models;

namespace FilmsStorage.Forms.Selections
{
    public partial class DetailsSelection : Form
    {
        private Selection _selection;

        public DetailsSelection(int id)
        {
            InitializeComponent();

            FillData(id);
        }

        private void btnUpdateSelection_Click(object sender, EventArgs e)
        {
            var updateSelection = new UpdateSelection(_selection.Id);
            updateSelection.ShowDialog();

            FillData(_selection.Id);
        }

        private void btnDeleteSelection_Click(object sender, EventArgs e)
        {
            SelectionsDB.DeleteSelection(_selection.Id);

            this.Close();
        }

        private void dgvFilms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvFilms.Rows[e.RowIndex];

            var idFilm = Convert.ToInt32(row.Cells["IdCol"].Value);

            var detailsFilm = new DetailsFilm(idFilm);
            detailsFilm.ShowDialog();

            FillData(_selection.Id);
        }

        private void FillData(int id)
        {
            _selection = SelectionsDB.GetSelectionById(id)!;
            _selection.Films = SelectionsDB.GetSelectionFilmsById(id);

            lbName.Text = _selection.Name;
            tbDescription.Text = _selection.Description;

            FillTableFilms(_selection.Films);
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
                    film.EnglishName ?? "-",
                    film.YearProduction.ToString(),
                    film.AgeRestriction,
                    film.Countries ?? "-",
                });
            }

            lbCountFilms.Text = $"(количество = {films.Count()})";
        }
    }
}
