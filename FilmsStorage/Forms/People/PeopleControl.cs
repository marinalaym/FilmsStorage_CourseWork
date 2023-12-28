using FilmsStorage.Database;
using FilmsStorage.Models;
using FilmsStorage.Settings;

namespace FilmsStorage.Forms.People
{
    public partial class PeopleControl : UserControl
    {
        public PeopleControl()
        {
            InitializeComponent();

            if (!AppSettings.User!.IsAdmin)
            {
                btnAddPerson.Visible = false;
                dgvPeople.Height += 60;
            }

            FillTableAllData();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            var addPerson = new CreatePerson();
            addPerson.ShowDialog();

            FillTableAllData();
        }

        private void dgvPeople_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvPeople.Rows[e.RowIndex];

            var idPerson = Convert.ToInt32(row.Cells["IdCol"].Value);

            var detailsPerson = new DetailsPerson(idPerson);
            detailsPerson.ShowDialog();

            FillTableAllData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var name = tbxSearch.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Заполните поисковые данные!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillTable(PeopleDB.SearchPeopleByName(name));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FillTableAllData();
        }

        private void FillTableAllData()
        {
            FillTable(PeopleDB.GetAllPeople());
        }

        private void FillTable(IEnumerable<Person> people)
        {
            dgvPeople.Rows.Clear();

            foreach (var person in people)
            {
                dgvPeople.Rows.Add(new string[]
                {
                    person.Id.ToString(),
                    person.Name,
                    person.DateBirth.ToShortDateString().ToString(),
                    person.DateDeath?.ToShortDateString().ToString() ?? "-",
                    person.Country!.Name
                });
            }

            lbCountPeople.Text = $"(количество = {people.Count()})";
        }
    }
}
