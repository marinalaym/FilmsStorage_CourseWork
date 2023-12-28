namespace FilmsStorage.Forms.Positions
{
    partial class PositionsControl
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
            btnAddPosition = new Button();
            label2 = new Label();
            dgvPositions = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            NameCol = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPositions).BeginInit();
            SuspendLayout();
            // 
            // btnAddPosition
            // 
            btnAddPosition.Anchor = AnchorStyles.Bottom;
            btnAddPosition.Location = new Point(305, 528);
            btnAddPosition.Name = "btnAddPosition";
            btnAddPosition.Size = new Size(190, 45);
            btnAddPosition.TabIndex = 24;
            btnAddPosition.Text = "Добавить должность";
            btnAddPosition.UseVisualStyleBackColor = true;
            btnAddPosition.Click += btnAddPosition_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(305, 28);
            label2.Name = "label2";
            label2.Size = new Size(173, 41);
            label2.TabIndex = 23;
            label2.Text = "Должности";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvPositions
            // 
            dgvPositions.AllowUserToAddRows = false;
            dgvPositions.AllowUserToDeleteRows = false;
            dgvPositions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPositions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPositions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPositions.Columns.AddRange(new DataGridViewColumn[] { IdCol, NameCol });
            dgvPositions.Location = new Point(19, 89);
            dgvPositions.Name = "dgvPositions";
            dgvPositions.RowHeadersWidth = 51;
            dgvPositions.RowTemplate.Height = 29;
            dgvPositions.Size = new Size(762, 417);
            dgvPositions.TabIndex = 22;
            dgvPositions.CellDoubleClick += dgvPositions_CellDoubleClick;
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
            // PositionsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddPosition);
            Controls.Add(label2);
            Controls.Add(dgvPositions);
            Name = "PositionsControl";
            Size = new Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)dgvPositions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddPosition;
        private Label label2;
        private DataGridView dgvPositions;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn NameCol;
    }
}
