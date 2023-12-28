using FilmsStorage.Database;
using FilmsStorage.Models;

namespace FilmsStorage.Forms.Films
{
    public partial class ChoosePosition : Form
    {
        public Position? Position { get; set; }
        
        private List<Position> _positions;

        public ChoosePosition()
        {
            InitializeComponent();

            _positions = PositionsDB.GetAllPositions();
            cbPosition.Items.AddRange(_positions.Select(c => c.Name).ToArray());
        }

        private void btnChoosePosition_Click(object sender, EventArgs e)
        {
            var positionName = cbPosition.SelectedItem?.ToString();
            if (positionName is null)
            {
                MessageBox.Show("Выберите профессию!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Position = _positions.First(p => p.Name == positionName);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
