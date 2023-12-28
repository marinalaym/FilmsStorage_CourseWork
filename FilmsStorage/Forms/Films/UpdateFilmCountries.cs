using FilmsStorage.Database;

namespace FilmsStorage.Forms.Films
{
    public partial class UpdateFilmCountries : Form
    {
        private int _filmId;

        public UpdateFilmCountries(int id)
        {
            InitializeComponent();

            _filmId = id;

            FillTableCountries();
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            if (dgvCountries.SelectedRows.Count == 0) return;

            var idCountry = dgvCountries.SelectedRows[0].Cells["IdCol"].Value.ToString()!;
            var nameCountry = dgvCountries.SelectedRows[0].Cells["NameCol"].Value.ToString()!;

            dgvFilmCountries.Rows.Add(new string[] { idCountry, nameCountry });

            dgvCountries.Rows.RemoveAt(dgvCountries.SelectedRows[0].Index);
        }

        private void btnDeleteCountry_Click(object sender, EventArgs e)
        {
            if (dgvFilmCountries.SelectedRows.Count == 0) return;

            var idCountry = dgvFilmCountries.SelectedRows[0].Cells["IdColumn"].Value.ToString()!;
            var nameCountry = dgvFilmCountries.SelectedRows[0].Cells["NameColumn"].Value.ToString()!;

            dgvCountries.Rows.Add(new string[] { idCountry, nameCountry });

            dgvFilmCountries.Rows.RemoveAt(dgvFilmCountries.SelectedRows[0].Index);
        }

        private void btnUpdateFilmCountries_Click(object sender, EventArgs e)
        {
            var idCountries = new List<int>();
            foreach (DataGridViewRow row in dgvFilmCountries.Rows)
            {
                var idCountry = Convert.ToInt32(row.Cells["IdColumn"].Value);
                idCountries.Add(idCountry);
            }

            FilmsDB.UpdateFilmCountries(_filmId, idCountries);

            this.Close();
        }

        private void FillTableCountries()
        {
            var countries = CountriesDB.GetAllCountries();
            var filmCountries = FilmsDB.GetFilmCountriesById(_filmId);

            filmCountries.ForEach(fc => countries.RemoveAll(c => c.Id == fc.Id));

            dgvCountries.Rows.Clear();
            dgvFilmCountries.Rows.Clear();

            foreach (var country in countries)
            {
                dgvCountries.Rows.Add(new string[]
                {
                    country.Id.ToString(),
                    country.Name
                });
            }

            foreach (var country in filmCountries)
            {
                dgvFilmCountries.Rows.Add(new string[]
                {
                    country.Id.ToString(),
                    country.Name
                });
            }
        }
    }
}
