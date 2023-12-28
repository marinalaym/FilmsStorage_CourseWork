namespace FilmsStorage.Forms.People
{
    partial class DetailsPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsPerson));
            lbDateBirth = new Label();
            label4 = new Label();
            lbDateDeath = new Label();
            label9 = new Label();
            label11 = new Label();
            pbPersonPhoto = new PictureBox();
            lbName = new Label();
            panel1 = new Panel();
            dgvFilms = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            RussianNameCol = new DataGridViewTextBoxColumn();
            EnglishNameCol = new DataGridViewTextBoxColumn();
            YearProductionCol = new DataGridViewTextBoxColumn();
            PositionCol = new DataGridViewTextBoxColumn();
            lbCountFilms = new Label();
            label2 = new Label();
            panelAdmin = new Panel();
            btnDeletePerson = new Button();
            btnUpdatePerson = new Button();
            lbCountry = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPersonPhoto).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFilms).BeginInit();
            panelAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // lbDateBirth
            // 
            lbDateBirth.Location = new Point(521, 122);
            lbDateBirth.Name = "lbDateBirth";
            lbDateBirth.Size = new Size(350, 28);
            lbDateBirth.TabIndex = 158;
            lbDateBirth.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(248, 122);
            label4.Name = "label4";
            label4.Size = new Size(153, 28);
            label4.TabIndex = 157;
            label4.Text = "Дата рождения";
            // 
            // lbDateDeath
            // 
            lbDateDeath.Location = new Point(521, 173);
            lbDateDeath.Name = "lbDateDeath";
            lbDateDeath.Size = new Size(350, 28);
            lbDateDeath.TabIndex = 143;
            lbDateDeath.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(248, 231);
            label9.Name = "label9";
            label9.Size = new Size(76, 28);
            label9.TabIndex = 142;
            label9.Text = "Страна";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(248, 173);
            label11.Name = "label11";
            label11.Size = new Size(124, 28);
            label11.TabIndex = 141;
            label11.Text = "Дата смерти";
            // 
            // pbPersonPhoto
            // 
            pbPersonPhoto.Image = (Image)resources.GetObject("pbPersonPhoto.Image");
            pbPersonPhoto.InitialImage = (Image)resources.GetObject("pbPersonPhoto.InitialImage");
            pbPersonPhoto.Location = new Point(22, 80);
            pbPersonPhoto.Name = "pbPersonPhoto";
            pbPersonPhoto.Size = new Size(196, 223);
            pbPersonPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonPhoto.TabIndex = 140;
            pbPersonPhoto.TabStop = false;
            // 
            // lbName
            // 
            lbName.Anchor = AnchorStyles.Top;
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.Location = new Point(388, 13);
            lbName.Name = "lbName";
            lbName.Size = new Size(135, 41);
            lbName.TabIndex = 139;
            lbName.Text = "Человек";
            lbName.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dgvFilms);
            panel1.Controls.Add(lbCountFilms);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 336);
            panel1.Name = "panel1";
            panel1.Size = new Size(859, 462);
            panel1.TabIndex = 159;
            // 
            // dgvFilms
            // 
            dgvFilms.AllowUserToAddRows = false;
            dgvFilms.AllowUserToDeleteRows = false;
            dgvFilms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFilms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFilms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilms.Columns.AddRange(new DataGridViewColumn[] { IdCol, RussianNameCol, EnglishNameCol, YearProductionCol, PositionCol });
            dgvFilms.Location = new Point(3, 67);
            dgvFilms.Name = "dgvFilms";
            dgvFilms.RowHeadersWidth = 51;
            dgvFilms.RowTemplate.Height = 29;
            dgvFilms.Size = new Size(851, 390);
            dgvFilms.TabIndex = 161;
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
            // PositionCol
            // 
            PositionCol.HeaderText = "Должность";
            PositionCol.MinimumWidth = 6;
            PositionCol.Name = "PositionCol";
            PositionCol.ReadOnly = true;
            // 
            // lbCountFilms
            // 
            lbCountFilms.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbCountFilms.AutoSize = true;
            lbCountFilms.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCountFilms.Location = new Point(689, 3);
            lbCountFilms.Name = "lbCountFilms";
            lbCountFilms.Size = new Size(165, 28);
            lbCountFilms.TabIndex = 134;
            lbCountFilms.Text = "(количество = 0)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 133;
            label2.Text = "Фильмы";
            // 
            // panelAdmin
            // 
            panelAdmin.Anchor = AnchorStyles.Bottom;
            panelAdmin.Controls.Add(btnDeletePerson);
            panelAdmin.Controls.Add(btnUpdatePerson);
            panelAdmin.Location = new Point(248, 804);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(365, 49);
            panelAdmin.TabIndex = 160;
            panelAdmin.Visible = false;
            // 
            // btnDeletePerson
            // 
            btnDeletePerson.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeletePerson.Location = new Point(203, 6);
            btnDeletePerson.Margin = new Padding(3, 4, 3, 4);
            btnDeletePerson.Name = "btnDeletePerson";
            btnDeletePerson.Size = new Size(149, 39);
            btnDeletePerson.TabIndex = 128;
            btnDeletePerson.Text = "Удалить";
            btnDeletePerson.UseVisualStyleBackColor = true;
            btnDeletePerson.Click += btnDeletePerson_Click;
            // 
            // btnUpdatePerson
            // 
            btnUpdatePerson.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdatePerson.Location = new Point(22, 6);
            btnUpdatePerson.Margin = new Padding(3, 4, 3, 4);
            btnUpdatePerson.Name = "btnUpdatePerson";
            btnUpdatePerson.Size = new Size(149, 39);
            btnUpdatePerson.TabIndex = 97;
            btnUpdatePerson.Text = "Изменить";
            btnUpdatePerson.UseVisualStyleBackColor = true;
            btnUpdatePerson.Click += btnUpdatePerson_Click;
            // 
            // lbCountry
            // 
            lbCountry.Location = new Point(521, 231);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(350, 28);
            lbCountry.TabIndex = 161;
            lbCountry.Text = "-";
            // 
            // DetailsPerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 856);
            Controls.Add(lbCountry);
            Controls.Add(panelAdmin);
            Controls.Add(panel1);
            Controls.Add(lbDateBirth);
            Controls.Add(label4);
            Controls.Add(lbDateDeath);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(pbPersonPhoto);
            Controls.Add(lbName);
            Name = "DetailsPerson";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DetailsPerson";
            ((System.ComponentModel.ISupportInitialize)pbPersonPhoto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFilms).EndInit();
            panelAdmin.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDateBirth;
        private Label label4;
        private Label lbName;
        private Label label1;
        private Label lbDateDeath;
        private Label label9;
        private Label label11;
        private PictureBox pbPersonPhoto;
        private Label lbRussianName;
        private Panel panel1;
        private Label lbCountFilms;
        private Label label2;
        private Panel panelAdmin;
        private Button btnUpdatePerson;
        private Button btnDeletePerson;
        private DataGridView dgvFilms;
        private Label lbCountry;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn RussianNameCol;
        private DataGridViewTextBoxColumn EnglishNameCol;
        private DataGridViewTextBoxColumn YearProductionCol;
        private DataGridViewTextBoxColumn PositionCol;
    }
}