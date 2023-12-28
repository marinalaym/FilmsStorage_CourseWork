using FilmsStorage.Database;
using FilmsStorage.Models;

namespace FilmsStorage.Forms.Selections
{
    public partial class SelectionsControl : UserControl
    {
        public SelectionsControl()
        {
            InitializeComponent();

            FillTableAllData();
        }

        private void btnAddSelection_Click(object sender, EventArgs e)
        {
            var addSelection = new CreateSelection();
            addSelection.ShowDialog();

            FillTableAllData();
        }

        private void dgvSelections_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvSelections.Rows[e.RowIndex];

            var idSelection = Convert.ToInt32(row.Cells["IdCol"].Value);

            var detailsSelection = new DetailsSelection(idSelection);
            detailsSelection.ShowDialog();

            FillTableAllData();
        }

        private void FillTableAllData()
        {
            FillTable(SelectionsDB.GetAllSelections());
        }

        private void FillTable(IEnumerable<Selection> selections)
        {
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
