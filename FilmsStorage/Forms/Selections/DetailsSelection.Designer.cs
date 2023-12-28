namespace FilmsStorage.Forms.Selections
{
    partial class DetailsSelection
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
            tbDescription = new TextBox();
            panel1 = new Panel();
            lbCountFilms = new Label();
            dgvFilms = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            RussianNameCol = new DataGridViewTextBoxColumn();
            EnglishNameCol = new DataGridViewTextBoxColumn();
            YearProductionCol = new DataGridViewTextBoxColumn();
            AgeRestrictionCol = new DataGridViewTextBoxColumn();
            CountryCol = new DataGridViewTextBoxColumn();
            label2 = new Label();
            lbName = new Label();
            btnDeleteSelection = new Button();
            btnUpdateSelection = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFilms).BeginInit();
            SuspendLayout();
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbDescription.Location = new Point(12, 84);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.ReadOnly = true;
            tbDescription.ScrollBars = ScrollBars.Vertical;
            tbDescription.Size = new Size(1052, 75);
            tbDescription.TabIndex = 153;
            tbDescription.Text = "Описание";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lbCountFilms);
            panel1.Controls.Add(dgvFilms);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 224);
            panel1.Name = "panel1";
            panel1.Size = new Size(1052, 416);
            panel1.TabIndex = 151;
            // 
            // lbCountFilms
            // 
            lbCountFilms.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbCountFilms.AutoSize = true;
            lbCountFilms.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCountFilms.Location = new Point(882, 3);
            lbCountFilms.Name = "lbCountFilms";
            lbCountFilms.Size = new Size(165, 28);
            lbCountFilms.TabIndex = 136;
            lbCountFilms.Text = "(количество = 0)";
            // 
            // dgvFilms
            // 
            dgvFilms.AllowUserToAddRows = false;
            dgvFilms.AllowUserToDeleteRows = false;
            dgvFilms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFilms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFilms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilms.Columns.AddRange(new DataGridViewColumn[] { IdCol, RussianNameCol, EnglishNameCol, YearProductionCol, AgeRestrictionCol, CountryCol });
            dgvFilms.Location = new Point(9, 49);
            dgvFilms.Name = "dgvFilms";
            dgvFilms.RowHeadersWidth = 51;
            dgvFilms.RowTemplate.Height = 29;
            dgvFilms.Size = new Size(1032, 347);
            dgvFilms.TabIndex = 135;
            dgvFilms.CellDoubleClick += dgvFilms_CellDoubleClick;
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
            // CountryCol
            // 
            CountryCol.HeaderText = "Страна";
            CountryCol.MinimumWidth = 6;
            CountryCol.Name = "CountryCol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 3);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 133;
            label2.Text = "Фильмы";
            // 
            // lbName
            // 
            lbName.Anchor = AnchorStyles.Top;
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.Location = new Point(440, 19);
            lbName.Name = "lbName";
            lbName.Size = new Size(156, 41);
            lbName.TabIndex = 137;
            lbName.Text = "Подборка";
            lbName.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDeleteSelection
            // 
            btnDeleteSelection.Anchor = AnchorStyles.Bottom;
            btnDeleteSelection.Location = new Point(548, 666);
            btnDeleteSelection.Margin = new Padding(3, 4, 3, 4);
            btnDeleteSelection.Name = "btnDeleteSelection";
            btnDeleteSelection.Size = new Size(149, 39);
            btnDeleteSelection.TabIndex = 157;
            btnDeleteSelection.Text = "Удалить";
            btnDeleteSelection.UseVisualStyleBackColor = true;
            btnDeleteSelection.Click += btnDeleteSelection_Click;
            // 
            // btnUpdateSelection
            // 
            btnUpdateSelection.Anchor = AnchorStyles.Bottom;
            btnUpdateSelection.Location = new Point(363, 666);
            btnUpdateSelection.Margin = new Padding(3, 4, 3, 4);
            btnUpdateSelection.Name = "btnUpdateSelection";
            btnUpdateSelection.Size = new Size(149, 39);
            btnUpdateSelection.TabIndex = 156;
            btnUpdateSelection.Text = "Изменить";
            btnUpdateSelection.UseVisualStyleBackColor = true;
            btnUpdateSelection.Click += btnUpdateSelection_Click;
            // 
            // DetailsSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 727);
            Controls.Add(panel1);
            Controls.Add(btnDeleteSelection);
            Controls.Add(tbDescription);
            Controls.Add(btnUpdateSelection);
            Controls.Add(lbName);
            Name = "DetailsSelection";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DetailsSelection";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFilms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDescription;
        private Panel panel1;
        private Label lbCountPeople;
        private Label label2;
        private Label lbName;
        private DataGridView dgvFilms;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn RussianNameCol;
        private DataGridViewTextBoxColumn EnglishNameCol;
        private DataGridViewTextBoxColumn YearProductionCol;
        private DataGridViewTextBoxColumn AgeRestrictionCol;
        private DataGridViewTextBoxColumn CountryCol;
        private Button btnDeleteSelection;
        private Button btnUpdateSelection;
        private Label lbCountFilms;
    }
}