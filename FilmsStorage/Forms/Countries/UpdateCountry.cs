using FilmsStorage.Database;
using FilmsStorage.Models;

namespace FilmsStorage.Forms.Countries
{
    public partial class UpdateCountry : Form
    {
        private Country _country;

        public UpdateCountry(int id)
        {
            InitializeComponent();

            _country = CountriesDB.GetCountryById(id)!;

            tbName.Text = _country.Name;
        }

        private void btnUpdateCountry_Click(object sender, EventArgs e)
        {
            _country.Name = tbName.Text.Trim();
            if (string.IsNullOrEmpty(_country.Name))
            {
                MessageBox.Show("Поле Название не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_country.Name.Length < 2 || _country.Name.Length > 64)
            {
                MessageBox.Show("Название должно содержать от 2 до 64 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CountriesDB.CheckExistsCountryByNameWithoutCurrentId(_country.Id, _country.Name))
            {
                MessageBox.Show("Данная страна уже существует!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CountriesDB.UpdateCountry(_country);

            this.Close();
        }

        private void btnDeleteCountry_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту страну?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CountriesDB.DeleteCountry(_country.Id);
                this.Close();
            }
        }
    }
}
