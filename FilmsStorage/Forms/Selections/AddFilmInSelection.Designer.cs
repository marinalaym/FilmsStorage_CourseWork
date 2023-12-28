namespace FilmsStorage.Forms.Selections
{
    partial class AddFilmInSelection
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
            btnAddFilmInSelection = new Button();
            dgvSelections = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            NameCol = new DataGridViewTextBoxColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSelections).BeginInit();
            SuspendLayout();
            // 
            // btnAddFilmInSelection
            // 
            btnAddFilmInSelection.Anchor = AnchorStyles.Bottom;
            btnAddFilmInSelection.Location = new Point(253, 536);
            btnAddFilmInSelection.Name = "btnAddFilmInSelection";
            btnAddFilmInSelection.Size = new Size(190, 46);
            btnAddFilmInSelection.TabIndex = 29;
            btnAddFilmInSelection.Text = "Добавить";
            btnAddFilmInSelection.UseVisualStyleBackColor = true;
            btnAddFilmInSelection.Click += btnAddFilmInSelection_Click;
            // 
            // dgvSelections
            // 
            dgvSelections.AllowUserToAddRows = false;
            dgvSelections.AllowUserToDeleteRows = false;
            dgvSelections.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSelections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSelections.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSelections.Columns.AddRange(new DataGridViewColumn[] { IdCol, NameCol });
            dgvSelections.Location = new Point(12, 99);
            dgvSelections.MultiSelect = false;
            dgvSelections.Name = "dgvSelections";
            dgvSelections.RowHeadersWidth = 51;
            dgvSelections.RowTemplate.Height = 29;
            dgvSelections.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSelections.Size = new Size(668, 410);
            dgvSelections.TabIndex = 28;
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(153, 25);
            label2.Name = "label2";
            label2.Size = new Size(413, 41);
            label2.TabIndex = 27;
            label2.Text = "Добавить фильм в подборку";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // AddFilmInSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 594);
            Controls.Add(btnAddFilmInSelection);
            Controls.Add(dgvSelections);
            Controls.Add(label2);
            Name = "AddFilmInSelection";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddFilmInSelection";
            ((System.ComponentModel.ISupportInitialize)dgvSelections).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddFilmInSelection;
        private DataGridView dgvSelections;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn NameCol;
        private Label label2;
    }
}