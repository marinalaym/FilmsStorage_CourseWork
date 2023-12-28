namespace FilmsStorage.Forms.People
{
    partial class PeopleControl
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
            btnAddPerson = new Button();
            label2 = new Label();
            dgvPeople = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            NameCol = new DataGridViewTextBoxColumn();
            DateBirthCol = new DataGridViewTextBoxColumn();
            DateDeathCol = new DataGridViewTextBoxColumn();
            CountryCol = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnReset = new Button();
            btnSearch = new Button();
            tbxSearch = new TextBox();
            lbCountPeople = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddPerson
            // 
            btnAddPerson.Anchor = AnchorStyles.Bottom;
            btnAddPerson.Location = new Point(306, 524);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(190, 45);
            btnAddPerson.TabIndex = 27;
            btnAddPerson.Text = "Добавить человека";
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(334, 24);
            label2.Name = "label2";
            label2.Size = new Size(95, 41);
            label2.TabIndex = 26;
            label2.Text = "Люди";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvPeople
            // 
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToDeleteRows = false;
            dgvPeople.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.Columns.AddRange(new DataGridViewColumn[] { IdCol, NameCol, DateBirthCol, DateDeathCol, CountryCol });
            dgvPeople.Location = new Point(21, 139);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.RowHeadersWidth = 51;
            dgvPeople.RowTemplate.Height = 29;
            dgvPeople.Size = new Size(762, 363);
            dgvPeople.TabIndex = 25;
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
            // DateBirthCol
            // 
            DateBirthCol.HeaderText = "Дата рождения";
            DateBirthCol.MinimumWidth = 6;
            DateBirthCol.Name = "DateBirthCol";
            DateBirthCol.ReadOnly = true;
            // 
            // DateDeathCol
            // 
            DateDeathCol.HeaderText = "Дата смерти";
            DateDeathCol.MinimumWidth = 6;
            DateDeathCol.Name = "DateDeathCol";
            DateDeathCol.ReadOnly = true;
            // 
            // CountryCol
            // 
            CountryCol.HeaderText = "Страна";
            CountryCol.MinimumWidth = 6;
            CountryCol.Name = "CountryCol";
            CountryCol.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(tbxSearch);
            panel1.Location = new Point(334, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 52);
            panel1.TabIndex = 32;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(340, 10);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 30;
            btnReset.Text = "Сбросить";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
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
            // tbxSearch
            // 
            tbxSearch.Location = new Point(3, 11);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(234, 27);
            tbxSearch.TabIndex = 28;
            // 
            // lbCountPeople
            // 
            lbCountPeople.AutoSize = true;
            lbCountPeople.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCountPeople.Location = new Point(21, 78);
            lbCountPeople.Name = "lbCountPeople";
            lbCountPeople.Size = new Size(165, 28);
            lbCountPeople.TabIndex = 136;
            lbCountPeople.Text = "(количество = 0)";
            // 
            // PeopleControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbCountPeople);
            Controls.Add(panel1);
            Controls.Add(btnAddPerson);
            Controls.Add(label2);
            Controls.Add(dgvPeople);
            Name = "PeopleControl";
            Size = new Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddPerson;
        private Label label2;
        private DataGridView dgvPeople;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn DateBirthCol;
        private DataGridViewTextBoxColumn DateDeathCol;
        private DataGridViewTextBoxColumn CountryCol;
        private Panel panel1;
        private Button btnReset;
        private Button btnSearch;
        private TextBox tbxSearch;
        private Label lbCountPeople;
    }
}
