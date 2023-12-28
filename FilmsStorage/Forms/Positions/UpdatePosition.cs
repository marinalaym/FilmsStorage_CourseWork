using FilmsStorage.Database;
using FilmsStorage.Models;


namespace FilmsStorage.Forms.Positions
{
    public partial class UpdatePosition : Form
    {
        private Position _position;

        public UpdatePosition(int id)
        {
            InitializeComponent();

            _position = PositionsDB.GetPositionById(id)!;

            tbName.Text = _position.Name;
        }

        private void btnUpdatePosition_Click(object sender, EventArgs e)
        {
            _position.Name = tbName.Text.Trim();
            if (string.IsNullOrEmpty(_position.Name))
            {
                MessageBox.Show("Поле Название не заполнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_position.Name.Length < 2 || _position.Name.Length > 64)
            {
                //от 2?
                MessageBox.Show("Название должно содержать от 2 до 64 символов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PositionsDB.CheckExistsPositionByNameWithoutCurrentId(_position.Id, _position.Name))
            {
                MessageBox.Show("Данная должность уже существует!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PositionsDB.UpdatePosition(_position);

            this.Close();
        }

        private void btnDeletePosition_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту должность?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PositionsDB.DeletePosition(_position.Id);
                this.Close();
            }
        }
    }
}
