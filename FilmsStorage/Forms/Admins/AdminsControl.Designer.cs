namespace FilmsStorage.Forms.Admins
{
    partial class AdminsControl
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
            btnAddAdmin = new Button();
            label2 = new Label();
            dgvAdmins = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            NameCol = new DataGridViewTextBoxColumn();
            LoginCol = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).BeginInit();
            SuspendLayout();
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.Anchor = AnchorStyles.Bottom;
            btnAddAdmin.Location = new Point(286, 526);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(233, 45);
            btnAddAdmin.TabIndex = 27;
            btnAddAdmin.Text = "Добавить администратора";
            btnAddAdmin.UseVisualStyleBackColor = true;
            btnAddAdmin.Click += btnAddAdmin_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(266, 24);
            label2.Name = "label2";
            label2.Size = new Size(253, 41);
            label2.TabIndex = 26;
            label2.Text = "Администраторы";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvAdmins
            // 
            dgvAdmins.AllowUserToAddRows = false;
            dgvAdmins.AllowUserToDeleteRows = false;
            dgvAdmins.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAdmins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmins.Columns.AddRange(new DataGridViewColumn[] { IdCol, NameCol, LoginCol });
            dgvAdmins.Location = new Point(21, 85);
            dgvAdmins.Name = "dgvAdmins";
            dgvAdmins.RowHeadersWidth = 51;
            dgvAdmins.RowTemplate.Height = 29;
            dgvAdmins.Size = new Size(762, 417);
            dgvAdmins.TabIndex = 25;
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
            // LoginCol
            // 
            LoginCol.HeaderText = "Логин";
            LoginCol.MinimumWidth = 6;
            LoginCol.Name = "LoginCol";
            LoginCol.ReadOnly = true;
            // 
            // AdminsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddAdmin);
            Controls.Add(label2);
            Controls.Add(dgvAdmins);
            Name = "AdminsControl";
            Size = new Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddAdmin;
        private Label label2;
        private DataGridView dgvAdmins;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn LoginCol;
    }
}
