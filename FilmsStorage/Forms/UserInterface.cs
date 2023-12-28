using FilmsStorage.Forms.Films;
using FilmsStorage.Forms.People;
using FilmsStorage.Forms.Selections;
using FilmsStorage.Forms.Users;

namespace FilmsStorage.Forms
{
    public partial class UserInterface : Form
    {
        public UserInterface()
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

        private void selectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddControlForMainPanel(new SelectionsControl());
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
