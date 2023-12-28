using FilmsStorage.Database;
using FilmsStorage.Models;

namespace FilmsStorage.Forms.Genres
{
    public partial class GenresControl : UserControl
    {
        public GenresControl()
        {
            InitializeComponent();

            FillTableAllData();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            var addGenre = new CreateGenre();
            addGenre.ShowDialog();

            FillTableAllData();
        }


        private void dgvGenres_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvGenres.Rows[e.RowIndex];

            var idGenre = Convert.ToInt32(row.Cells["IdCol"].Value);

            var updateGenre = new UpdateGenre(idGenre);
            updateGenre.ShowDialog();

            FillTableAllData();
        }

        private void FillTableAllData()
        {
            FillTable(GenresDB.GetAllGenres());
        }

        private void FillTable(IEnumerable<Genre> genres)
        {
            dgvGenres.Rows.Clear();

            foreach (var genre in genres)
            {
                dgvGenres.Rows.Add(new string[]
                {
                    genre.Id.ToString(),
                    genre.Name
                });
            }
        }
    }
}
