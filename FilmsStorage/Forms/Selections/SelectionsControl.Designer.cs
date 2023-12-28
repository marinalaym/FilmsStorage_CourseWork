namespace FilmsStorage.Forms.Selections
{
    partial class SelectionsControl
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
            btnAddSelection = new Button();
            dgvSelections = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            NameCol = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSelections).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(304, 31);
            label2.Name = "label2";
            label2.Size = new Size(158, 41);
            label2.TabIndex = 24;
            label2.Text = "Подборки";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAddSelection
            // 
            btnAddSelection.Anchor = AnchorStyles.Bottom;
            btnAddSelection.Location = new Point(307, 533);
            btnAddSelection.Name = "btnAddSelection";
            btnAddSelection.Size = new Size(190, 46);
            btnAddSelection.TabIndex = 26;
            btnAddSelection.Text = "Добавить подборку";
            btnAddSelection.UseVisualStyleBackColor = true;
            btnAddSelection.Click += btnAddSelection_Click;
            // 
            // dgvSelections
            // 
            dgvSelections.AllowUserToAddRows = false;
            dgvSelections.AllowUserToDeleteRows = false;
            dgvSelections.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSelections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSelections.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSelections.Columns.AddRange(new DataGridViewColumn[] { IdCol, NameCol });
            dgvSelections.Location = new Point(22, 94);
            dgvSelections.Name = "dgvSelections";
            dgvSelections.RowHeadersWidth = 51;
            dgvSelections.RowTemplate.Height = 29;
            dgvSelections.Size = new Size(762, 417);
            dgvSelections.TabIndex = 25;
            dgvSelections.CellDoubleClick += dgvSelections_CellDoubleClick;
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
            // SelectionsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddSelection);
            Controls.Add(dgvSelections);
            Controls.Add(label2);
            Name = "SelectionsControl";
            Size = new Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)dgvSelections).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnAddSelection;
        private DataGridView dgvSelections;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn NameCol;
    }
}
