namespace FilmsStorage.Forms
{
    partial class AdminInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            filmsToolStripMenuItem = new ToolStripMenuItem();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            countriesToolStripMenuItem = new ToolStripMenuItem();
            genresToolStripMenuItem = new ToolStripMenuItem();
            positionsToolStripMenuItem = new ToolStripMenuItem();
            adminsToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            mainPanel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { filmsToolStripMenuItem, peopleToolStripMenuItem, справочникиToolStripMenuItem, adminsToolStripMenuItem, profileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1006, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // filmsToolStripMenuItem
            // 
            filmsToolStripMenuItem.Name = "filmsToolStripMenuItem";
            filmsToolStripMenuItem.Size = new Size(81, 24);
            filmsToolStripMenuItem.Text = "Фильмы";
            filmsToolStripMenuItem.Click += filmsToolStripMenuItem_Click;
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(62, 24);
            peopleToolStripMenuItem.Text = "Люди";
            peopleToolStripMenuItem.Click += peopleToolStripMenuItem_Click;
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { countriesToolStripMenuItem, genresToolStripMenuItem, positionsToolStripMenuItem });
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(117, 24);
            справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // countriesToolStripMenuItem
            // 
            countriesToolStripMenuItem.Name = "countriesToolStripMenuItem";
            countriesToolStripMenuItem.Size = new Size(170, 26);
            countriesToolStripMenuItem.Text = "Страны";
            countriesToolStripMenuItem.Click += countriesToolStripMenuItem_Click;
            // 
            // genresToolStripMenuItem
            // 
            genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            genresToolStripMenuItem.Size = new Size(170, 26);
            genresToolStripMenuItem.Text = "Жанры";
            genresToolStripMenuItem.Click += genresToolStripMenuItem_Click;
            // 
            // positionsToolStripMenuItem
            // 
            positionsToolStripMenuItem.Name = "positionsToolStripMenuItem";
            positionsToolStripMenuItem.Size = new Size(170, 26);
            positionsToolStripMenuItem.Text = "Должности";
            positionsToolStripMenuItem.Click += positionsToolStripMenuItem_Click;
            // 
            // adminsToolStripMenuItem
            // 
            adminsToolStripMenuItem.Name = "adminsToolStripMenuItem";
            adminsToolStripMenuItem.Size = new Size(144, 24);
            adminsToolStripMenuItem.Text = "Администраторы";
            adminsToolStripMenuItem.Click += adminsToolStripMenuItem_Click;
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(87, 24);
            profileToolStripMenuItem.Text = "Профиль";
            profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 30);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1006, 691);
            mainPanel.TabIndex = 1;
            // 
            // AdminInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(mainPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminInterface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminInterface";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem filmsToolStripMenuItem;
        private ToolStripMenuItem peopleToolStripMenuItem;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem countriesToolStripMenuItem;
        private ToolStripMenuItem genresToolStripMenuItem;
        private ToolStripMenuItem positionsToolStripMenuItem;
        private ToolStripMenuItem adminsToolStripMenuItem;
        private Panel mainPanel;
        private ToolStripMenuItem profileToolStripMenuItem;
    }
}