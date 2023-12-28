using FilmsStorage.Database;

namespace FilmsStorage.Forms.Films
{
    public partial class FilterFilms : Form
    {
        public string Condition { get; set; } = string.Empty;

        public FilterFilms()
        {
            InitializeComponent();

            var ageRestriction = new string[] { "0+", "6+", "12+", "16+", "18+" };
            cbAgeRestriction.Items.AddRange(ageRestriction);

            var countries = CountriesDB.GetAllCountries();
            cbCountry.Items.AddRange(countries.Select(c => c.Name).ToArray());

            var genres = GenresDB.GetAllGenres();
            cbGenre.Items.AddRange(genres.Select(c => c.Name).ToArray());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var yearProductionStart = numYearProductionStart.Value.ToString();
            var yearProductionEnd = numYearProductionEnd.Value.ToString();

            Condition += $"YearProduction >= '{yearProductionStart}' AND YearProduction <= '{yearProductionEnd}'";

            var ageRestriction = cbAgeRestriction.SelectedItem?.ToString();
            if (ageRestriction is not null)
            {
                Condition += $"AND AgeRestriction = '{ageRestriction}'";
            }

            var genreName = cbGenre.SelectedItem?.ToString();
            if (genreName is not null)
            {
                Condition += $"AND Genres LIKE '%{genreName}%'";
            }

            var countryName = cbCountry.SelectedItem?.ToString();
            if (countryName is not null)
            {
                Condition += $"AND Countries LIKE '%{countryName}%'";
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
