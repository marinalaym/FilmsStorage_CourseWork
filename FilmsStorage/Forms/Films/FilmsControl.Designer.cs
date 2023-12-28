namespace FilmsStorage.Forms.Films
{
    partial class FilmsControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            btnAddFilm = new Button();
            dgvFilms = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            NameCol = new DataGridViewTextBoxColumn();
            DateBirthCol = new DataGridViewTextBoxColumn();
            DateDeathCol = new DataGridViewTextBoxColumn();
            btnFilters = new Button();
            tbxSearch = new TextBox();
            btnSearch = new Button();
            panel1 = new Panel();
            btnReset = new Button();
            lbCountFilms = new Label();
            IdCol = new DataGridViewTextBoxColumn();
            RussianNameCol = new DataGridViewTextBoxColumn();
            EnglishNameCol = new DataGridViewTextBoxColumn();
            YearProductionCol = new DataGridViewTextBoxColumn();
            AgeRestrictionCol = new DataGridViewTextBoxColumn();
            GenreCol = new DataGridViewTextBoxColumn();
            CountryCol = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvFilms).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(391, 24);
            label2.Name = "label2";
            label2.Size = new Size(130, 41);
            label2.TabIndex = 17;
            label2.Text = "Фильмы";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAddFilm
            // 
            btnAddFilm.Anchor = AnchorStyles.Bottom;
            btnAddFilm.Location = new Point(363, 524);
            btnAddFilm.Name = "btnAddFilm";
            btnAddFilm.Size = new Size(190, 46);
            btnAddFilm.TabIndex = 18;
            btnAddFilm.Text = "Добавить фильм";
            btnAddFilm.UseVisualStyleBackColor = true;
            btnAddFilm.Click += btnAddFilm_Click;
            // 
            // dgvFilms
            // 
            dgvFilms.AllowUserToAddRows = false;
            dgvFilms.AllowUserToDeleteRows = false;
            dgvFilms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFilms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFilms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilms.Columns.AddRange(new DataGridViewColumn[] { IdCol, RussianNameCol, EnglishNameCol, YearProductionCol, AgeRestrictionCol, GenreCol, CountryCol });
            dgvFilms.Location = new Point(21, 152);
            dgvFilms.Name = "dgvFilms";
            dgvFilms.RowHeadersWidth = 51;
            dgvFilms.RowTemplate.Height = 29;
            dgvFilms.Size = new Size(877, 350);
            dgvFilms.TabIndex = 26;
            dgvFilms.CellDoubleClick += dgvFilms_CellDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // NameCol
            // 
            NameCol.MinimumWidth = 6;
            NameCol.Name = "NameCol";
            NameCol.Width = 125;
            // 
            // DateBirthCol
            // 
            DateBirthCol.MinimumWidth = 6;
            DateBirthCol.Name = "DateBirthCol";
            DateBirthCol.Width = 125;
            // 
            // DateDeathCol
            // 
            DateDeathCol.MinimumWidth = 6;
            DateDeathCol.Name = "DateDeathCol";
            DateDeathCol.Width = 125;
            // 
            // btnFilters
            // 
            btnFilters.Location = new Point(343, 9);
            btnFilters.Name = "btnFilters";
            btnFilters.Size = new Size(94, 29);
            btnFilters.TabIndex = 27;
            btnFilters.Text = "Фильтры";
            btnFilters.UseVisualStyleBackColor = true;
            btnFilters.Click += btnFilters_Click;
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(3, 11);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(234, 27);
            tbxSearch.TabIndex = 28;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(243, 9);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(78, 29);
            btnSearch.TabIndex = 29;
            btnSearch.Text = "Поиск";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnFilters);
            panel1.Controls.Add(tbxSearch);
            panel1.Location = new Point(345, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 52);
            panel1.TabIndex = 31;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(453, 9);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 30;
            btnReset.Text = "Сбросить";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lbCountFilms
            // 
            lbCountFilms.AutoSize = true;
            lbCountFilms.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCountFilms.Location = new Point(21, 87);
            lbCountFilms.Name = "lbCountFilms";
            lbCountFilms.Size = new Size(165, 28);
            lbCountFilms.TabIndex = 135;
            lbCountFilms.Text = "(количество = 0)";
            // 
            // IdCol
            // 
            IdCol.HeaderText = "Id";
            IdCol.MinimumWidth = 6;
            IdCol.Name = "IdCol";
            IdCol.ReadOnly = true;
            IdCol.Visible = false;
            // 
            // RussianNameCol
            // 
            RussianNameCol.HeaderText = "Название";
            RussianNameCol.MinimumWidth = 6;
            RussianNameCol.Name = "RussianNameCol";
            RussianNameCol.ReadOnly = true;
            // 
            // EnglishNameCol
            // 
            EnglishNameCol.HeaderText = "Название (англ)";
            EnglishNameCol.MinimumWidth = 6;
            EnglishNameCol.Name = "EnglishNameCol";
            EnglishNameCol.ReadOnly = true;
            // 
            // YearProductionCol
            // 
            YearProductionCol.HeaderText = "Год выпуска";
            YearProductionCol.MinimumWidth = 6;
            YearProductionCol.Name = "YearProductionCol";
            YearProductionCol.ReadOnly = true;
            // 
            // AgeRestrictionCol
            // 
            AgeRestrictionCol.HeaderText = "Ограничение";
            AgeRestrictionCol.MinimumWidth = 6;
            AgeRestrictionCol.Name = "AgeRestrictionCol";
            AgeRestrictionCol.ReadOnly = true;
            // 
            // GenreCol
            // 
            GenreCol.HeaderText = "Жанр";
            GenreCol.MinimumWidth = 6;
            GenreCol.Name = "GenreCol";
            GenreCol.ReadOnly = true;
            // 
            // CountryCol
            // 
            CountryCol.HeaderText = "Страна";
            CountryCol.MinimumWidth = 6;
            CountryCol.Name = "CountryCol";
            // 
            // FilmsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(lbCountFilms);
            Controls.Add(panel1);
            Controls.Add(dgvFilms);
            Controls.Add(btnAddFilm);
            Controls.Add(label2);
            Name = "FilmsControl";
            Size = new Size(915, 600);
            ((System.ComponentModel.ISupportInitialize)dgvFilms).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnAddFilm;
        private DataGridView dgvFilms;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn DateBirthCol;
        private DataGridViewTextBoxColumn DateDeathCol;
        private Button btnFilters;
        private TextBox tbxSearch;
        private Button btnSearch;
        private Panel panel1;
        private Button btnReset;
        private Label lbCountFilms;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn RussianNameCol;
        private DataGridViewTextBoxColumn EnglishNameCol;
        private DataGridViewTextBoxColumn YearProductionCol;
        private DataGridViewTextBoxColumn AgeRestrictionCol;
        private DataGridViewTextBoxColumn GenreCol;
        private DataGridViewTextBoxColumn CountryCol;
    }
}
