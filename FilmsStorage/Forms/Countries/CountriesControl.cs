using FilmsStorage.Database;
using FilmsStorage.Models;

namespace FilmsStorage.Forms.Countries
{
    public partial class CountriesControl : UserControl
    {
        public CountriesControl()
        {
            InitializeComponent();

            FillTableAllData();
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            var addCountry = new CreateCountry();
            addCountry.ShowDialog();

            FillTableAllData();
        }


        private void dgvCountries_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvCountries.Rows[e.RowIndex];

            var idCountry = Convert.ToInt32(row.Cells["IdCol"].Value);

            var updateCountry = new UpdateCountry(idCountry);
            updateCountry.ShowDialog();

            FillTableAllData();
        }

        private void FillTableAllData()
        {
            FillTable(CountriesDB.GetAllCountries());
        }

        private void FillTable(IEnumerable<Country> countries)
        {
            dgvCountries.Rows.Clear();

            foreach (var country in countries)
            {
                dgvCountries.Rows.Add(new string[]
                {
                    country.Id.ToString(),
                    country.Name
                });
            }
        }
    }
}
