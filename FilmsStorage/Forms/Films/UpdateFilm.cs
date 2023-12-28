using FilmsStorage.Database;
using FilmsStorage.Models;
using FilmsStorage.Settings;

namespace FilmsStorage.Forms.Films
{
    public partial class UpdateFilm : Form
    {
        private Film _film;
        private bool _photoChanged = false;

        public UpdateFilm(int id)
        {
            InitializeComponent();

            _film = FilmsDB.GetFilmById(id)!;

            tbRussianName.Text = _film.RussianName;
            tbEnglishName.Text = _film.EnglishName;
            numYearProduction.Value = _film.YearProduction;
            dtpPremiereDate.Value = _film.PremiereDate;
            numDuration.Value = _film.Duration;
            tbDescription.Text = _film.Description;

            var ageRestriction = new string[] { "0+", "6+", "12+", "16+", "18+" };
            cbAgeRestriction.Items.AddRange(ageRestriction);
            cbAgeRestriction.SelectedItem = _film.AgeRestriction;

            if (_film.PathPhoto is not null)
            {
                pbFilmPhoto.Image = FileManager.GetImage(_film.PathPhoto);
            }
        }

        private void btnUpdateFilmPhoto_Click(object sender, EventArgs e)
        {
            var image = FileManager.LoadImage();
            if (image is not null)
            {
                pbFilmPhoto.Image = image;
                _photoChanged = true;
            }
        }

        private void btnUpdateFilm_Click(object sender, EventArgs e)
        {
            _film.RussianName = tbRussianName.Text.Trim();
            if (string.IsNullOrEmpty(_film.RussianName))
            {
                MessageBox.Show("Поле Название не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_film.RussianName.Length < 2 || _film.RussianName.Length > 100)
            {
                MessageBox.Show("Название должно содержать от 2 до 100 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _film.EnglishName = tbEnglishName.Text.Trim();
            if (!string.IsNullOrEmpty(_film.EnglishName))
            {
                if (_film.EnglishName.Length < 2 || _film.EnglishName.Length > 100)
                {
                    MessageBox.Show("Название (англ) должно содержать от 2 до 100 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                _film.EnglishName = null;
            }

            _film.YearProduction = (int)numYearProduction.Value;

            _film.PremiereDate = dtpPremiereDate.Value;

            _film.Duration = (int)numDuration.Value;

            var ageRestriction = cbAgeRestriction.SelectedItem?.ToString();
            if (ageRestriction is null)
            {
                MessageBox.Show("Выберите возрвстное ограничение!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _film.AgeRestriction = ageRestriction;

            _film.Description = tbDescription.Text.Trim();
            if (string.IsNullOrEmpty(_film.Description))
            {
                MessageBox.Show("Поле Описание не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_photoChanged)
            {
                _film.PathPhoto = FileManager.SaveImage(pbFilmPhoto.Image);
            }

            FilmsDB.UpdateFilm(_film);

            this.Close();
        }
    }
}
