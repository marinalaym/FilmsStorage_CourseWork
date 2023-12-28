using FilmsStorage.Database;
using FilmsStorage.Models;

namespace FilmsStorage.Forms.Positions
{
    public partial class PositionsControl : UserControl
    {
        public PositionsControl()
        {
            InitializeComponent();

            FillTableAllData();
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            var position = new CreatePosition();
            position.ShowDialog();

            FillTableAllData();
        }


        private void dgvPositions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvPositions.Rows[e.RowIndex];

            var idPosition = Convert.ToInt32(row.Cells["IdCol"].Value);

            var updatePosition = new UpdatePosition(idPosition);
            updatePosition.ShowDialog();

            FillTableAllData();
        }

        private void FillTableAllData()
        {
            FillTable(PositionsDB.GetAllPositions());
        }

        private void FillTable(IEnumerable<Position> positions)
        {
            dgvPositions.Rows.Clear();

            foreach (var country in positions)
            {
                dgvPositions.Rows.Add(new string[]
                {
                    country.Id.ToString(),
                    country.Name
                });
            }
        }

    }
}
