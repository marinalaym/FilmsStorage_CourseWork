namespace FilmsStorage.Forms
{
    partial class UserInterface
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
            mainPanel = new Panel();
            menuStrip1 = new MenuStrip();
            filmsToolStripMenuItem = new ToolStripMenuItem();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            selectionsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 30);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1006, 721);
            mainPanel.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { filmsToolStripMenuItem, peopleToolStripMenuItem, selectionsToolStripMenuItem, profileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1006, 30);
            menuStrip1.TabIndex = 2;
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
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(87, 24);
            profileToolStripMenuItem.Text = "Профиль";
            profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
            // 
            // selectionsToolStripMenuItem
            // 
            selectionsToolStripMenuItem.Name = "selectionsToolStripMenuItem";
            selectionsToolStripMenuItem.Size = new Size(94, 24);
            selectionsToolStripMenuItem.Text = "Подборки";
            selectionsToolStripMenuItem.Click += selectionsToolStripMenuItem_Click;
            // 
            // UserInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 751);
            Controls.Add(mainPanel);
            Controls.Add(menuStrip1);
            Name = "UserInterface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserInterface";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mainPanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem filmsToolStripMenuItem;
        private ToolStripMenuItem peopleToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem selectionsToolStripMenuItem;
    }
}