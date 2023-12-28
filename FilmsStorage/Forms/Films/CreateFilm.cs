using FilmsStorage.Database;
using FilmsStorage.Models;
using FilmsStorage.Settings;

namespace FilmsStorage.Forms.Films
{
    public partial class CreateFilm : Form
    {
        public CreateFilm()
        {
            InitializeComponent();

            var ageRestriction = new string[] { "0+", "6+", "12+", "16+", "18+" };
            cbAgeRestriction.Items.AddRange(ageRestriction);
            cbAgeRestriction.SelectedItem = cbAgeRestriction.Items[0];

            numYearProduction.Value = DateTime.Now.Year;
        }

        private void btnAddFilmPhoto_Click(object sender, EventArgs e)
        {
            var image = FileManager.LoadImage();
            if (image is not null)
            {
                pbFilmPhoto.Image = image;
            }
        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            var film = new Film();

            film.RussianName = tbRussianName.Text.Trim();
            if (string.IsNullOrEmpty(film.RussianName))
            {
                MessageBox.Show("Поле Название не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (film.RussianName.Length < 2 || film.RussianName.Length > 100)
            {
                MessageBox.Show("Название должно содержать от 2 до 100 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            film.EnglishName = tbEnglishName.Text.Trim();
            if (!string.IsNullOrEmpty(film.EnglishName))
            {
                if (film.EnglishName.Length < 2 || film.EnglishName.Length > 100)
                {
                    MessageBox.Show("Название (англ) должно содержать от 2 до 100 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                film.EnglishName = null;
            }

            film.YearProduction = (int)numYearProduction.Value;

            film.PremiereDate = dtpPremiereDate.Value;

            film.Duration = (int)numDuration.Value;

            var ageRestriction = cbAgeRestriction.SelectedItem?.ToString();
            if (ageRestriction is null)
            {
                MessageBox.Show("Выберите возрвстное ограничение!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            film.AgeRestriction = ageRestriction;

            film.Description = tbDescription.Text.Trim();
            if (string.IsNullOrEmpty(film.Description))
            {
                MessageBox.Show("Поле Описание не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pbFilmPhoto.Image is not null)
            {
                film.PathPhoto = FileManager.SaveImage(pbFilmPhoto.Image);
            }

            FilmsDB.CreateFilm(film);

            this.Close();
        }
    }
}
