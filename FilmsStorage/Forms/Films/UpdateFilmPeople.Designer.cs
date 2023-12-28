namespace FilmsStorage.Forms.Films
{
    partial class UpdateFilmPeople
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
            btnUpdateFilmPeople = new Button();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvPeople = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            NameCol = new DataGridViewTextBoxColumn();
            dgvFilmPeople = new DataGridView();
            panel1 = new Panel();
            btnDeletePerson = new Button();
            btnAddPerson = new Button();
            IdPersonColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            IdPositionCol = new DataGridViewTextBoxColumn();
            PositionCol = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFilmPeople).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdateFilmPeople
            // 
            btnUpdateFilmPeople.Anchor = AnchorStyles.Bottom;
            btnUpdateFilmPeople.Location = new Point(313, 623);
            btnUpdateFilmPeople.Margin = new Padding(3, 4, 3, 4);
            btnUpdateFilmPeople.Name = "btnUpdateFilmPeople";
            btnUpdateFilmPeople.Size = new Size(149, 39);
            btnUpdateFilmPeople.TabIndex = 61;
            btnUpdateFilmPeople.Text = "Изменить";
            btnUpdateFilmPeople.UseVisualStyleBackColor = true;
            btnUpdateFilmPeople.Click += btnUpdateFilmPeople_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(158, 11);
            label2.Name = "label2";
            label2.Size = new Size(491, 41);
            label2.TabIndex = 60;
            label2.Text = "Изменение связи фильма и людей";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.Controls.Add(dgvPeople, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvFilmPeople, 2, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Location = new Point(1, 75);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(781, 532);
            tableLayoutPanel1.TabIndex = 59;
            // 
            // dgvPeople
            // 
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToDeleteRows = false;
            dgvPeople.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.Columns.AddRange(new DataGridViewColumn[] { IdCol, NameCol });
            dgvPeople.Location = new Point(3, 3);
            dgvPeople.MultiSelect = false;
            dgvPeople.Name = "dgvPeople";
            dgvPeople.RowHeadersWidth = 51;
            dgvPeople.RowTemplate.Height = 29;
            dgvPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeople.Size = new Size(267, 526);
            dgvPeople.TabIndex = 20;
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
            // dgvFilmPeople
            // 
            dgvFilmPeople.AllowUserToAddRows = false;
            dgvFilmPeople.AllowUserToDeleteRows = false;
            dgvFilmPeople.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFilmPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFilmPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmPeople.Columns.AddRange(new DataGridViewColumn[] { IdPersonColumn, NameColumn, IdPositionCol, PositionCol });
            dgvFilmPeople.Location = new Point(354, 3);
            dgvFilmPeople.MultiSelect = false;
            dgvFilmPeople.Name = "dgvFilmPeople";
            dgvFilmPeople.RowHeadersWidth = 51;
            dgvFilmPeople.RowTemplate.Height = 29;
            dgvFilmPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFilmPeople.Size = new Size(424, 526);
            dgvFilmPeople.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDeletePerson);
            panel1.Controls.Add(btnAddPerson);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(276, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(72, 526);
            panel1.TabIndex = 22;
            // 
            // btnDeletePerson
            // 
            btnDeletePerson.Anchor = AnchorStyles.None;
            btnDeletePerson.Location = new Point(17, 263);
            btnDeletePerson.Name = "btnDeletePerson";
            btnDeletePerson.Size = new Size(44, 55);
            btnDeletePerson.TabIndex = 1;
            btnDeletePerson.Text = "<-";
            btnDeletePerson.UseVisualStyleBackColor = true;
            btnDeletePerson.Click += btnDeletePerson_Click;
            // 
            // btnAddPerson
            // 
            btnAddPerson.Anchor = AnchorStyles.None;
            btnAddPerson.Location = new Point(17, 193);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(44, 54);
            btnAddPerson.TabIndex = 0;
            btnAddPerson.Text = "->";
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // IdPersonColumn
            // 
            IdPersonColumn.HeaderText = "IdPerson";
            IdPersonColumn.MinimumWidth = 6;
            IdPersonColumn.Name = "IdPersonColumn";
            IdPersonColumn.ReadOnly = true;
            IdPersonColumn.Visible = false;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Имя";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            // 
            // IdPositionCol
            // 
            IdPositionCol.HeaderText = "IdPosition";
            IdPositionCol.MinimumWidth = 6;
            IdPositionCol.Name = "IdPositionCol";
            IdPositionCol.ReadOnly = true;
            IdPositionCol.Visible = false;
            // 
            // PositionCol
            // 
            PositionCol.HeaderText = "Должность";
            PositionCol.MinimumWidth = 6;
            PositionCol.Name = "PositionCol";
            PositionCol.ReadOnly = true;
            // 
            // UpdateFilmPeople
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 673);
            Controls.Add(btnUpdateFilmPeople);
            Controls.Add(label2);
            Controls.Add(tableLayoutPanel1);
            Name = "UpdateFilmPeople";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdateFilmPeople";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFilmPeople).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdateFilmPeople;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvPeople;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridView dgvFilmPeople;
        private Panel panel1;
        private Button btnDeletePerson;
        private Button btnAddPerson;
        private DataGridViewTextBoxColumn IdPersonColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn IdPositionCol;
        private DataGridViewTextBoxColumn PositionCol;
    }
}