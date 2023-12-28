using FilmsStorage.Database;
using FilmsStorage.Models;
using FilmsStorage.Settings;

namespace FilmsStorage.Forms.People
{
    public partial class CreatePerson : Form
    {
        public CreatePerson()
        {
            InitializeComponent();

            var countries = CountriesDB.GetAllCountries();
            cbCountries.Items.AddRange(countries.Select(c => c.Name).ToArray());
        }

        private void btnAddPersonPhoto_Click(object sender, EventArgs e)
        {
            var image = FileManager.LoadImage();
            if (image is not null)
            {
                pbPersonPhoto.Image = image;
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            var person = new Person();

            person.Name = tbName.Text.Trim();
            if (string.IsNullOrEmpty(person.Name))
            {
                MessageBox.Show("Поле Имя не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (person.Name.Length < 2 || person.Name.Length > 100)
            {
                MessageBox.Show("Имя должно содержать от 2 до 100 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            person.DateBirth = dtpDateBirth.Value;

            if (cbDateDeath.Checked)
            {
                person.DateDeath = null;
            }
            else
            {
                person.DateDeath = dtpDateDeath.Value;
            }


            var countryName = cbCountries.SelectedItem?.ToString();
            if (countryName is null)
            {
                MessageBox.Show("Выберите страну!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Country? country = CountriesDB.GetCountryByName(countryName);
            if (country is null) return;
            person.CountryId = country.Id;

            if (pbPersonPhoto.Image is not null)
            {
                person.PathPhoto = FileManager.SaveImage(pbPersonPhoto.Image);
            }

            PeopleDB.CreatePerson(person);

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
