using FilmsStorage.Database;
using FilmsStorage.Models;

namespace FilmsStorage.Forms.Countries
{
    public partial class CreateCountry : Form
    {
        public CreateCountry()
        {
            InitializeComponent();
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            var country = new Country();

            country.Name = tbName.Text.Trim();
            if (string.IsNullOrEmpty(country.Name))
            {
                MessageBox.Show("Поле Название не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (country.Name.Length < 2 || country.Name.Length > 64)
            {
                MessageBox.Show("Название должно содержать от 2 до 64 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CountriesDB.CheckExistsCountryByName(country.Name))
            {
                MessageBox.Show("Данная страна уже существует!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CountriesDB.CreateCountry(country);

            this.Close();
        }
    }
}
