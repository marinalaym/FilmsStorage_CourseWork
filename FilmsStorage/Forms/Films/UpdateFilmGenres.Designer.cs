namespace FilmsStorage.Forms.Films
{
    partial class UpdateFilmGenres
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
            btnUpdateFilmGenres = new Button();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvGenres = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            NameCol = new DataGridViewTextBoxColumn();
            dgvFilmGenres = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnDeleteGenre = new Button();
            btnAddGenre = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGenres).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFilmGenres).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdateFilmGenres
            // 
            btnUpdateFilmGenres.Anchor = AnchorStyles.Bottom;
            btnUpdateFilmGenres.Location = new Point(313, 623);
            btnUpdateFilmGenres.Margin = new Padding(3, 4, 3, 4);
            btnUpdateFilmGenres.Name = "btnUpdateFilmGenres";
            btnUpdateFilmGenres.Size = new Size(149, 39);
            btnUpdateFilmGenres.TabIndex = 58;
            btnUpdateFilmGenres.Text = "Изменить";
            btnUpdateFilmGenres.UseVisualStyleBackColor = true;
            btnUpdateFilmGenres.Click += btnUpdateFilmGenres_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(158, 11);
            label2.Name = "label2";
            label2.Size = new Size(508, 41);
            label2.TabIndex = 57;
            label2.Text = "Изменение связи фильма и жанров";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.Controls.Add(dgvGenres, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvFilmGenres, 2, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Location = new Point(1, 75);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(781, 532);
            tableLayoutPanel1.TabIndex = 56;
            // 
            // dgvGenres
            // 
            dgvGenres.AllowUserToAddRows = false;
            dgvGenres.AllowUserToDeleteRows = false;
            dgvGenres.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGenres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGenres.Columns.AddRange(new DataGridViewColumn[] { IdCol, NameCol });
            dgvGenres.Location = new Point(3, 3);
            dgvGenres.MultiSelect = false;
            dgvGenres.Name = "dgvGenres";
            dgvGenres.RowHeadersWidth = 51;
            dgvGenres.RowTemplate.Height = 29;
            dgvGenres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGenres.Size = new Size(345, 526);
            dgvGenres.TabIndex = 20;
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
            NameCol.HeaderText = "Название";
            NameCol.MinimumWidth = 6;
            NameCol.Name = "NameCol";
            NameCol.ReadOnly = true;
            // 
            // dgvFilmGenres
            // 
            dgvFilmGenres.AllowUserToAddRows = false;
            dgvFilmGenres.AllowUserToDeleteRows = false;
            dgvFilmGenres.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFilmGenres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFilmGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmGenres.Columns.AddRange(new DataGridViewColumn[] { IdColumn, NameColumn });
            dgvFilmGenres.Location = new Point(432, 3);
            dgvFilmGenres.MultiSelect = false;
            dgvFilmGenres.Name = "dgvFilmGenres";
            dgvFilmGenres.RowHeadersWidth = 51;
            dgvFilmGenres.RowTemplate.Height = 29;
            dgvFilmGenres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFilmGenres.Size = new Size(346, 526);
            dgvFilmGenres.TabIndex = 21;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "Id";
            IdColumn.MinimumWidth = 6;
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            IdColumn.Visible = false;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Название";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDeleteGenre);
            panel1.Controls.Add(btnAddGenre);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(354, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(72, 526);
            panel1.TabIndex = 22;
            // 
            // btnDeleteGenre
            // 
            btnDeleteGenre.Anchor = AnchorStyles.None;
            btnDeleteGenre.Location = new Point(17, 263);
            btnDeleteGenre.Name = "btnDeleteGenre";
            btnDeleteGenre.Size = new Size(44, 55);
            btnDeleteGenre.TabIndex = 1;
            btnDeleteGenre.Text = "<-";
            btnDeleteGenre.UseVisualStyleBackColor = true;
            btnDeleteGenre.Click += btnDeleteGenre_Click;
            // 
            // btnAddGenre
            // 
            btnAddGenre.Anchor = AnchorStyles.None;
            btnAddGenre.Location = new Point(17, 193);
            btnAddGenre.Name = "btnAddGenre";
            btnAddGenre.Size = new Size(44, 54);
            btnAddGenre.TabIndex = 0;
            btnAddGenre.Text = "->";
            btnAddGenre.UseVisualStyleBackColor = true;
            btnAddGenre.Click += btnAddGenre_Click;
            // 
            // UpdateFilmGenres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 673);
            Controls.Add(btnUpdateFilmGenres);
            Controls.Add(label2);
            Controls.Add(tableLayoutPanel1);
            Name = "UpdateFilmGenres";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdateFilmGenres";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGenres).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFilmGenres).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdateFilmGenres;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvGenres;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridView dgvFilmGenres;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private Panel panel1;
        private Button btnDeleteGenre;
        private Button btnAddGenre;
    }
}