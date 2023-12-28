namespace FilmsStorage.Forms.Films
{
    partial class UpdateFilmCountries
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvCountries = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            NameCol = new DataGridViewTextBoxColumn();
            dgvFilmCountries = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnDeleteCountry = new Button();
            btnAddCountry = new Button();
            label2 = new Label();
            btnUpdateFilmCountries = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCountries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFilmCountries).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.Controls.Add(dgvCountries, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvFilmCountries, 2, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Location = new Point(2, 73);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(781, 532);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvCountries
            // 
            dgvCountries.AllowUserToAddRows = false;
            dgvCountries.AllowUserToDeleteRows = false;
            dgvCountries.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCountries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCountries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCountries.Columns.AddRange(new DataGridViewColumn[] { IdCol, NameCol });
            dgvCountries.Location = new Point(3, 3);
            dgvCountries.MultiSelect = false;
            dgvCountries.Name = "dgvCountries";
            dgvCountries.RowHeadersWidth = 51;
            dgvCountries.RowTemplate.Height = 29;
            dgvCountries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCountries.Size = new Size(345, 526);
            dgvCountries.TabIndex = 20;
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
            // dgvFilmCountries
            // 
            dgvFilmCountries.AllowUserToAddRows = false;
            dgvFilmCountries.AllowUserToDeleteRows = false;
            dgvFilmCountries.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFilmCountries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFilmCountries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmCountries.Columns.AddRange(new DataGridViewColumn[] { IdColumn, NameColumn });
            dgvFilmCountries.Location = new Point(432, 3);
            dgvFilmCountries.MultiSelect = false;
            dgvFilmCountries.Name = "dgvFilmCountries";
            dgvFilmCountries.RowHeadersWidth = 51;
            dgvFilmCountries.RowTemplate.Height = 29;
            dgvFilmCountries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFilmCountries.Size = new Size(346, 526);
            dgvFilmCountries.TabIndex = 21;
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
            panel1.Controls.Add(btnDeleteCountry);
            panel1.Controls.Add(btnAddCountry);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(354, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(72, 526);
            panel1.TabIndex = 22;
            // 
            // btnDeleteCountry
            // 
            btnDeleteCountry.Anchor = AnchorStyles.None;
            btnDeleteCountry.Location = new Point(17, 263);
            btnDeleteCountry.Name = "btnDeleteCountry";
            btnDeleteCountry.Size = new Size(44, 55);
            btnDeleteCountry.TabIndex = 1;
            btnDeleteCountry.Text = "<-";
            btnDeleteCountry.UseVisualStyleBackColor = true;
            btnDeleteCountry.Click += btnDeleteCountry_Click;
            // 
            // btnAddCountry
            // 
            btnAddCountry.Anchor = AnchorStyles.None;
            btnAddCountry.Location = new Point(17, 193);
            btnAddCountry.Name = "btnAddCountry";
            btnAddCountry.Size = new Size(44, 54);
            btnAddCountry.TabIndex = 0;
            btnAddCountry.Text = "->";
            btnAddCountry.UseVisualStyleBackColor = true;
            btnAddCountry.Click += btnAddCountry_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(159, 9);
            label2.Name = "label2";
            label2.Size = new Size(478, 41);
            label2.TabIndex = 21;
            label2.Text = "Изменение связи фильма и стран";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnUpdateFilmCountries
            // 
            btnUpdateFilmCountries.Anchor = AnchorStyles.Bottom;
            btnUpdateFilmCountries.Location = new Point(314, 621);
            btnUpdateFilmCountries.Margin = new Padding(3, 4, 3, 4);
            btnUpdateFilmCountries.Name = "btnUpdateFilmCountries";
            btnUpdateFilmCountries.Size = new Size(149, 39);
            btnUpdateFilmCountries.TabIndex = 55;
            btnUpdateFilmCountries.Text = "Изменить";
            btnUpdateFilmCountries.UseVisualStyleBackColor = true;
            btnUpdateFilmCountries.Click += btnUpdateFilmCountries_Click;
            // 
            // UpdateFilmCountries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 673);
            Controls.Add(btnUpdateFilmCountries);
            Controls.Add(label2);
            Controls.Add(tableLayoutPanel1);
            Name = "UpdateFilmCountries";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdateFilmCountries";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCountries).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFilmCountries).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private DataGridView dgvCountries;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridView dgvFilmCountries;
        private Panel panel1;
        private Button btnDeleteCountry;
        private Button btnAddCountry;
        private Button btnUpdateFilmCountries;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn NameColumn;
    }
}