using FilmsStorage.Database;
using FilmsStorage.Models;
using FilmsStorage.Settings;

namespace FilmsStorage.Forms.People
{
    public partial class UpdatePerson : Form
    {
        private Person _person;
        private bool _photoChanged = false;

        public UpdatePerson(int id)
        {
            InitializeComponent();

            _person = PeopleDB.GetPersonById(id)!;

            tbName.Text = _person.Name;
            dtpDateBirth.Value = _person.DateBirth;

            if (_person.DateDeath is null)
            {
                cbDateDeath.Checked = true;
                dtpDateDeath.Visible = false;
            }
            else
            {
                dtpDateDeath.Value = _person.DateDeath.Value;
            }

            if (_person.PathPhoto is not null)
            {
                pbPersonPhoto.Image = FileManager.GetImage(_person.PathPhoto);
            }

            var countries = CountriesDB.GetAllCountries();
            cbCountries.Items.AddRange(countries.Select(c => c.Name).ToArray());
            cbCountries.SelectedItem = countries.First(c => c.Id == _person.CountryId).Name;
        }

        private void btnUpdatePersonPhoto_Click(object sender, EventArgs e)
        {
            var image = FileManager.LoadImage();
            if (image is not null)
            {
                pbPersonPhoto.Image = image;
                _photoChanged = true;
            }
        }

        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            _person.Name = tbName.Text.Trim();
            if (string.IsNullOrEmpty(_person.Name))
            {
                MessageBox.Show("Поле Имя не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_person.Name.Length < 2 || _person.Name.Length > 100)
            {
                MessageBox.Show("Имя должно содержать от 2 до 100 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _person.DateBirth = dtpDateBirth.Value;

            if (cbDateDeath.Checked)
            {
                _person.DateDeath = null;
            }
            else
            {
                _person.DateDeath = dtpDateDeath.Value;
            }


            var countryName = cbCountries.SelectedItem?.ToString();
            if (countryName is null)
            {
                MessageBox.Show("Выберите страну!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Country? country = CountriesDB.GetCountryByName(countryName);
            if (country is null) return;
            _person.CountryId = country.Id;

            if (_photoChanged)
            {
                _person.PathPhoto = FileManager.SaveImage(pbPersonPhoto.Image);
            }

            PeopleDB.UpdatePerson(_person);

            this.Close();
        }

        private void cbDateDeath_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDateDeath.Checked)
            {
                dtpDateDeath.Visible = false;
            }
            else
            {
                dtpDateDeath.Visible = true;
            }
        }
    }
}
