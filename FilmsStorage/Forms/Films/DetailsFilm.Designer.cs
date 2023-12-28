namespace FilmsStorage.Forms.Films
{
    partial class DetailsFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsFilm));
            pbFilmPhoto = new PictureBox();
            btnUpdateFilm = new Button();
            lbRussianName = new Label();
            lbYearProduction = new Label();
            lbEnglishName = new Label();
            label9 = new Label();
            label11 = new Label();
            lbAgeRestriction = new Label();
            lbDuration = new Label();
            lbPremiereDate = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            btnDeleteFilm = new Button();
            lbCountry = new Label();
            label1 = new Label();
            btnUpdateFilmCountries = new Button();
            btnUpdateFilmPeople = new Button();
            dgvPeople = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            NameCol = new DataGridViewTextBoxColumn();
            PositionCol = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel1 = new Panel();
            lbCountPeople = new Label();
            panelAdmin = new Panel();
            btnUpdateFilmGenres = new Button();
            panelUser = new Panel();
            btnAddFilmInSelection = new Button();
            tbDescription = new TextBox();
            lbGenre = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbFilmPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            panel1.SuspendLayout();
            panelAdmin.SuspendLayout();
            panelUser.SuspendLayout();
            SuspendLayout();
            // 
            // pbFilmPhoto
            // 
            pbFilmPhoto.Image = (Image)resources.GetObject("pbFilmPhoto.Image");
            pbFilmPhoto.InitialImage = (Image)resources.GetObject("pbFilmPhoto.InitialImage");
            pbFilmPhoto.Location = new Point(23, 91);
            pbFilmPhoto.Name = "pbFilmPhoto";
            pbFilmPhoto.Size = new Size(196, 223);
            pbFilmPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFilmPhoto.TabIndex = 101;
            pbFilmPhoto.TabStop = false;
            // 
            // btnUpdateFilm
            // 
            btnUpdateFilm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdateFilm.Location = new Point(3, 4);
            btnUpdateFilm.Margin = new Padding(3, 4, 3, 4);
            btnUpdateFilm.Name = "btnUpdateFilm";
            btnUpdateFilm.Size = new Size(149, 39);
            btnUpdateFilm.TabIndex = 96;
            btnUpdateFilm.Text = "Изменить";
            btnUpdateFilm.UseVisualStyleBackColor = true;
            btnUpdateFilm.Click += btnUpdateFilm_Click;
            // 
            // lbRussianName
            // 
            lbRussianName.Anchor = AnchorStyles.Top;
            lbRussianName.AutoSize = true;
            lbRussianName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbRussianName.Location = new Point(552, 24);
            lbRussianName.Name = "lbRussianName";
            lbRussianName.Size = new Size(109, 41);
            lbRussianName.TabIndex = 95;
            lbRussianName.Text = "Фильм";
            lbRussianName.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbYearProduction
            // 
            lbYearProduction.AutoSize = true;
            lbYearProduction.Location = new Point(296, 503);
            lbYearProduction.Name = "lbYearProduction";
            lbYearProduction.Size = new Size(15, 20);
            lbYearProduction.TabIndex = 118;
            lbYearProduction.Text = "-";
            // 
            // lbEnglishName
            // 
            lbEnglishName.Location = new Point(296, 445);
            lbEnglishName.Name = "lbEnglishName";
            lbEnglishName.Size = new Size(286, 28);
            lbEnglishName.TabIndex = 117;
            lbEnglishName.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(23, 503);
            label9.Name = "label9";
            label9.Size = new Size(125, 28);
            label9.TabIndex = 115;
            label9.Text = "Год выпуска";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(23, 445);
            label11.Name = "label11";
            label11.Size = new Size(158, 28);
            label11.TabIndex = 113;
            label11.Text = "Название (англ)";
            // 
            // lbAgeRestriction
            // 
            lbAgeRestriction.AutoSize = true;
            lbAgeRestriction.Location = new Point(296, 678);
            lbAgeRestriction.Name = "lbAgeRestriction";
            lbAgeRestriction.Size = new Size(15, 20);
            lbAgeRestriction.TabIndex = 124;
            lbAgeRestriction.Text = "-";
            // 
            // lbDuration
            // 
            lbDuration.AutoSize = true;
            lbDuration.Location = new Point(296, 620);
            lbDuration.Name = "lbDuration";
            lbDuration.Size = new Size(15, 20);
            lbDuration.TabIndex = 123;
            lbDuration.Text = "-";
            // 
            // lbPremiereDate
            // 
            lbPremiereDate.AutoSize = true;
            lbPremiereDate.Location = new Point(296, 562);
            lbPremiereDate.Name = "lbPremiereDate";
            lbPremiereDate.Size = new Size(15, 20);
            lbPremiereDate.TabIndex = 122;
            lbPremiereDate.Text = "-";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(23, 678);
            label15.Name = "label15";
            label15.Size = new Size(243, 28);
            label15.TabIndex = 121;
            label15.Text = "Возрастное ограничение";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(23, 562);
            label16.Name = "label16";
            label16.Size = new Size(104, 28);
            label16.TabIndex = 120;
            label16.Text = "Премьера";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(23, 620);
            label17.Name = "label17";
            label17.Size = new Size(201, 28);
            label17.TabIndex = 119;
            label17.Text = "Продолжительность";
            // 
            // btnDeleteFilm
            // 
            btnDeleteFilm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteFilm.Location = new Point(657, 4);
            btnDeleteFilm.Margin = new Padding(3, 4, 3, 4);
            btnDeleteFilm.Name = "btnDeleteFilm";
            btnDeleteFilm.Size = new Size(149, 39);
            btnDeleteFilm.TabIndex = 127;
            btnDeleteFilm.Text = "Удалить";
            btnDeleteFilm.UseVisualStyleBackColor = true;
            btnDeleteFilm.Click += btnDeleteFilm_Click;
            // 
            // lbCountry
            // 
            lbCountry.Location = new Point(296, 340);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(286, 28);
            lbCountry.TabIndex = 129;
            lbCountry.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 340);
            label1.Name = "label1";
            label1.Size = new Size(76, 28);
            label1.TabIndex = 128;
            label1.Text = "Страна";
            // 
            // btnUpdateFilmCountries
            // 
            btnUpdateFilmCountries.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdateFilmCountries.Location = new Point(173, 4);
            btnUpdateFilmCountries.Margin = new Padding(3, 4, 3, 4);
            btnUpdateFilmCountries.Name = "btnUpdateFilmCountries";
            btnUpdateFilmCountries.Size = new Size(149, 39);
            btnUpdateFilmCountries.TabIndex = 130;
            btnUpdateFilmCountries.Text = "Изменить страны";
            btnUpdateFilmCountries.UseVisualStyleBackColor = true;
            btnUpdateFilmCountries.Click += btnUpdateFilmCountries_Click;
            // 
            // btnUpdateFilmPeople
            // 
            btnUpdateFilmPeople.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdateFilmPeople.Location = new Point(502, 4);
            btnUpdateFilmPeople.Margin = new Padding(3, 4, 3, 4);
            btnUpdateFilmPeople.Name = "btnUpdateFilmPeople";
            btnUpdateFilmPeople.Size = new Size(149, 39);
            btnUpdateFilmPeople.TabIndex = 131;
            btnUpdateFilmPeople.Text = "Изменить людей";
            btnUpdateFilmPeople.UseVisualStyleBackColor = true;
            btnUpdateFilmPeople.Click += btnUpdateFilmPeople_Click;
            // 
            // dgvPeople
            // 
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToDeleteRows = false;
            dgvPeople.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.Columns.AddRange(new DataGridViewColumn[] { IdCol, NameCol, PositionCol });
            dgvPeople.Location = new Point(3, 46);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.RowHeadersWidth = 51;
            dgvPeople.RowTemplate.Height = 29;
            dgvPeople.Size = new Size(594, 338);
            dgvPeople.TabIndex = 132;
            dgvPeople.CellDoubleClick += dgvPeople_CellDoubleClick;
            // 
            // IdCol
            // 
            IdCol.HeaderText = "Id";
            IdCol.MinimumWidth = 6;
            IdCol.Name = "IdCol";
            IdCol.ReadOnly = true;
            IdCol.Visible = false;
            // 
            // NameCol
            // 
            NameCol.HeaderText = "Имя";
            NameCol.MinimumWidth = 6;
            NameCol.Name = "NameCol";
            NameCol.ReadOnly = true;
            // 
            // PositionCol
            // 
            PositionCol.HeaderText = "Должность";
            PositionCol.MinimumWidth = 6;
            PositionCol.Name = "PositionCol";
            PositionCol.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 133;
            label2.Text = "Люди";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lbCountPeople);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dgvPeople);
            panel1.Location = new Point(588, 340);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 387);
            panel1.TabIndex = 134;
            // 
            // lbCountPeople
            // 
            lbCountPeople.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbCountPeople.AutoSize = true;
            lbCountPeople.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCountPeople.Location = new Point(432, 3);
            lbCountPeople.Name = "lbCountPeople";
            lbCountPeople.Size = new Size(165, 28);
            lbCountPeople.TabIndex = 134;
            lbCountPeople.Text = "(количество = 0)";
            // 
            // panelAdmin
            // 
            panelAdmin.Anchor = AnchorStyles.Bottom;
            panelAdmin.Controls.Add(btnUpdateFilmGenres);
            panelAdmin.Controls.Add(btnUpdateFilm);
            panelAdmin.Controls.Add(btnUpdateFilmCountries);
            panelAdmin.Controls.Add(btnUpdateFilmPeople);
            panelAdmin.Controls.Add(btnDeleteFilm);
            panelAdmin.Location = new Point(193, 746);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(809, 49);
            panelAdmin.TabIndex = 135;
            panelAdmin.Visible = false;
            // 
            // btnUpdateFilmGenres
            // 
            btnUpdateFilmGenres.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdateFilmGenres.Location = new Point(338, 4);
            btnUpdateFilmGenres.Margin = new Padding(3, 4, 3, 4);
            btnUpdateFilmGenres.Name = "btnUpdateFilmGenres";
            btnUpdateFilmGenres.Size = new Size(149, 39);
            btnUpdateFilmGenres.TabIndex = 132;
            btnUpdateFilmGenres.Text = "Изменить жанры";
            btnUpdateFilmGenres.UseVisualStyleBackColor = true;
            btnUpdateFilmGenres.Click += btnUpdateFilmGenres_Click;
            // 
            // panelUser
            // 
            panelUser.Anchor = AnchorStyles.Bottom;
            panelUser.Controls.Add(btnAddFilmInSelection);
            panelUser.Location = new Point(483, 733);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(245, 72);
            panelUser.TabIndex = 136;
            panelUser.Visible = false;
            // 
            // btnAddFilmInSelection
            // 
            btnAddFilmInSelection.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddFilmInSelection.Location = new Point(40, 17);
            btnAddFilmInSelection.Margin = new Padding(3, 4, 3, 4);
            btnAddFilmInSelection.Name = "btnAddFilmInSelection";
            btnAddFilmInSelection.Size = new Size(182, 39);
            btnAddFilmInSelection.TabIndex = 97;
            btnAddFilmInSelection.Text = "Добавить в подборку";
            btnAddFilmInSelection.UseVisualStyleBackColor = true;
            btnAddFilmInSelection.Click += btnAddFilmInSelection_Click;
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbDescription.Location = new Point(244, 91);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.ReadOnly = true;
            tbDescription.ScrollBars = ScrollBars.Vertical;
            tbDescription.Size = new Size(944, 223);
            tbDescription.TabIndex = 136;
            tbDescription.Text = "Описание";
            // 
            // lbGenre
            // 
            lbGenre.Location = new Point(296, 394);
            lbGenre.Name = "lbGenre";
            lbGenre.Size = new Size(286, 28);
            lbGenre.TabIndex = 138;
            lbGenre.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 394);
            label4.Name = "label4";
            label4.Size = new Size(63, 28);
            label4.TabIndex = 137;
            label4.Text = "Жанр";
            // 
            // DetailsFilm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 807);
            Controls.Add(lbGenre);
            Controls.Add(label4);
            Controls.Add(panelUser);
            Controls.Add(tbDescription);
            Controls.Add(panelAdmin);
            Controls.Add(panel1);
            Controls.Add(lbCountry);
            Controls.Add(label1);
            Controls.Add(lbAgeRestriction);
            Controls.Add(lbDuration);
            Controls.Add(lbPremiereDate);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(lbYearProduction);
            Controls.Add(lbEnglishName);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(pbFilmPhoto);
            Controls.Add(lbRussianName);
            Name = "DetailsFilm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DetailsFilm";
            ((System.ComponentModel.ISupportInitialize)pbFilmPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelAdmin.ResumeLayout(false);
            panelUser.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbFilmPhoto;
        private Button btnUpdateFilm;
        private Label lbYearProduction;
        private Label lbEnglishName;
        private Label lbRussianName;
        private Label label9;
        private Label label11;
        private Label lbAgeRestriction;
        private Label lbDuration;
        private Label lbPremiereDate;
        private Label label15;
        private Label label16;
        private Label label17;
        private Button btnDeleteFilm;
        private Label lbCountry;
        private Label label1;
        private Button btnUpdateFilmCountries;
        private Button btnUpdateFilmPeople;
        private DataGridView dgvPeople;
        private Label label2;
        private Panel panel1;
        private Panel panelAdmin;
        private Panel panelUser;
        private Button btnAddFilmInSelection;
        private Label lbCountPeople;
        private TextBox tbDescription;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn PositionCol;
        private Button btnUpdateFilmGenres;
        private Label lbGenre;
        private Label label4;
    }
}