namespace FilmsStorage.Forms.Countries
{
    partial class CountriesControl
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
            btnAddCountry = new Button();
            label2 = new Label();
            dgvCountries = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            NameCol = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCountries).BeginInit();
            SuspendLayout();
            // 
            // btnAddCountry
            // 
            btnAddCountry.Anchor = AnchorStyles.Bottom;
            btnAddCountry.Location = new Point(306, 524);
            btnAddCountry.Name = "btnAddCountry";
            btnAddCountry.Size = new Size(190, 46);
            btnAddCountry.TabIndex = 21;
            btnAddCountry.Text = "Добавить страну";
            btnAddCountry.UseVisualStyleBackColor = true;
            btnAddCountry.Click += btnAddCountry_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(334, 24);
            label2.Name = "label2";
            label2.Size = new Size(120, 41);
            label2.TabIndex = 20;
            label2.Text = "Страны";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvCountries
            // 
            dgvCountries.AllowUserToAddRows = false;
            dgvCountries.AllowUserToDeleteRows = false;
            dgvCountries.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCountries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCountries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCountries.Columns.AddRange(new DataGridViewColumn[] { IdCol, NameCol });
            dgvCountries.Location = new Point(21, 85);
            dgvCountries.Name = "dgvCountries";
            dgvCountries.RowHeadersWidth = 51;
            dgvCountries.RowTemplate.Height = 29;
            dgvCountries.Size = new Size(762, 417);
            dgvCountries.TabIndex = 19;
            dgvCountries.CellDoubleClick += dgvCountries_CellDoubleClick;
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
            // CountriesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddCountry);
            Controls.Add(label2);
            Controls.Add(dgvCountries);
            Name = "CountriesControl";
            Size = new Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)dgvCountries).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddCountry;
        private Label label2;
        private DataGridView dgvCountries;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn NameCol;
    }
}
