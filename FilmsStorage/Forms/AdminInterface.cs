using FilmsStorage.Forms.Admins;
using FilmsStorage.Forms.Countries;
using FilmsStorage.Forms.Films;
using FilmsStorage.Forms.Genres;
using FilmsStorage.Forms.People;
using FilmsStorage.Forms.Positions;
using FilmsStorage.Forms.Users;

namespace FilmsStorage.Forms
{
    public partial class AdminInterface : Form
    {
        public AdminInterface()
        {
            InitializeComponent();

            AddControlForMainPanel(new FilmsControl());
        }

        private void filmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddControlForMainPanel(new FilmsControl());
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddControlForMainPanel(new PeopleControl());
        }

        private void countriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddControlForMainPanel(new CountriesControl());
        }

        private void genresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddControlForMainPanel(new GenresControl());
        }

        private void positionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddControlForMainPanel(new PositionsControl());
        }

        private void adminsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddControlForMainPanel(new AdminsControl());
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddControlForMainPanel(new ProfileControl(this));
        }

        private void AddControlForMainPanel(UserControl control)
        {
            control.Dock = DockStyle.Fill;

            if (mainPanel.Controls.Count > 0)
            {
                mainPanel.Controls.Clear();
            }

            mainPanel.Controls.Add(control);
        }
    }
}
