using FilmsStorage.Database;

namespace FilmsStorage.Forms.Selections
{
    public partial class AddFilmInSelection : Form
    {
        private int _filmId;

        public AddFilmInSelection(int filmId)
        {
            InitializeComponent();

            _filmId = filmId;

            FillTableSelections();
        }

        private void btnAddFilmInSelection_Click(object sender, EventArgs e)
        {
            if (dgvSelections.SelectedRows.Count == 0) return;

            var idSelection = Convert.ToInt32(dgvSelections.SelectedRows[0].Cells["IdCol"].Value);

            if (SelectionsDB.CheckExistsFilmSelection(_filmId, idSelection))
            {
                MessageBox.Show("Фильм уже добавлен в подборку!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SelectionsDB.AddFilmInSelection(_filmId, idSelection);

            MessageBox.Show("Фильм добавлен в подборку!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void FillTableSelections()
        {
            var selections = SelectionsDB.GetAllSelections();

            dgvSelections.Rows.Clear();

            foreach (var selection in selections)
            {
                dgvSelections.Rows.Add(new string[]
                {
                    selection.Id.ToString(),
                    selection.Name
                });
            }
        }
    }
}
