namespace FilmsStorage.Forms.People
{
    partial class CreatePerson
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
            label5 = new Label();
            tbName = new TextBox();
            btnAddPerson = new Button();
            label1 = new Label();
            dtpDateBirth = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dtpDateDeath = new DateTimePicker();
            cbCountries = new ComboBox();
            label4 = new Label();
            pbPersonPhoto = new PictureBox();
            btnAddPersonPhoto = new Button();
            cbDateDeath = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pbPersonPhoto).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(251, 88);
            label5.Name = "label5";
            label5.Size = new Size(51, 28);
            label5.TabIndex = 42;
            label5.Text = "Имя";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbName.Location = new Point(251, 120);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(327, 27);
            tbName.TabIndex = 41;
            // 
            // btnAddPerson
            // 
            btnAddPerson.Anchor = AnchorStyles.Bottom;
            btnAddPerson.Location = new Point(206, 426);
            btnAddPerson.Margin = new Padding(3, 4, 3, 4);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(149, 39);
            btnAddPerson.TabIndex = 40;
            btnAddPerson.Text = "Добавить";
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(146, 28);
            label1.Name = "label1";
            label1.Size = new Size(286, 41);
            label1.TabIndex = 39;
            label1.Text = "Добавить человека";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dtpDateBirth
            // 
            dtpDateBirth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDateBirth.Location = new Point(251, 194);
            dtpDateBirth.Name = "dtpDateBirth";
            dtpDateBirth.Size = new Size(327, 27);
            dtpDateBirth.TabIndex = 43;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(251, 163);
            label2.Name = "label2";
            label2.Size = new Size(153, 28);
            label2.TabIndex = 44;
            label2.Text = "Дата рождения";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(251, 250);
            label3.Name = "label3";
            label3.Size = new Size(124, 28);
            label3.TabIndex = 46;
            label3.Text = "Дата смерти";
            // 
            // dtpDateDeath
            // 
            dtpDateDeath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDateDeath.Location = new Point(251, 286);
            dtpDateDeath.Name = "dtpDateDeath";
            dtpDateDeath.Size = new Size(327, 27);
            dtpDateDeath.TabIndex = 45;
            dtpDateDeath.Value = new DateTime(2023, 12, 16, 20, 42, 33, 0);
            // 
            // cbCountries
            // 
            cbCountries.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbCountries.FormattingEnabled = true;
            cbCountries.Location = new Point(251, 366);
            cbCountries.Name = "cbCountries";
            cbCountries.Size = new Size(327, 28);
            cbCountries.TabIndex = 47;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(251, 335);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 48;
            label4.Text = "Страна";
            // 
            // pbPersonPhoto
            // 
            pbPersonPhoto.BorderStyle = BorderStyle.FixedSingle;
            pbPersonPhoto.Location = new Point(12, 120);
            pbPersonPhoto.Name = "pbPersonPhoto";
            pbPersonPhoto.Size = new Size(196, 223);
            pbPersonPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonPhoto.TabIndex = 49;
            pbPersonPhoto.TabStop = false;
            // 
            // btnAddPersonPhoto
            // 
            btnAddPersonPhoto.Location = new Point(38, 355);
            btnAddPersonPhoto.Margin = new Padding(3, 4, 3, 4);
            btnAddPersonPhoto.Name = "btnAddPersonPhoto";
            btnAddPersonPhoto.Size = new Size(149, 39);
            btnAddPersonPhoto.TabIndex = 50;
            btnAddPersonPhoto.Text = "Добавить фото";
            btnAddPersonPhoto.UseVisualStyleBackColor = true;
            btnAddPersonPhoto.Click += btnAddPersonPhoto_Click;
            // 
            // cbDateDeath
            // 
            cbDateDeath.AutoSize = true;
            cbDateDeath.Location = new Point(394, 256);
            cbDateDeath.Name = "cbDateDeath";
            cbDateDeath.Size = new Size(89, 24);
            cbDateDeath.TabIndex = 52;
            cbDateDeath.Text = "Не умер";
            cbDateDeath.UseVisualStyleBackColor = true;
            cbDateDeath.CheckedChanged += cbDateDeath_CheckedChanged;
            // 
            // CreatePerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 478);
            Controls.Add(cbDateDeath);
            Controls.Add(btnAddPersonPhoto);
            Controls.Add(pbPersonPhoto);
            Controls.Add(label4);
            Controls.Add(cbCountries);
            Controls.Add(label3);
            Controls.Add(dtpDateDeath);
            Controls.Add(label2);
            Controls.Add(dtpDateBirth);
            Controls.Add(label5);
            Controls.Add(tbName);
            Controls.Add(btnAddPerson);
            Controls.Add(label1);
            Name = "CreatePerson";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreatePerson";
            ((System.ComponentModel.ISupportInitialize)pbPersonPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox tbName;
        private Button btnAddPerson;
        private Label label1;
        private DateTimePicker dtpDateBirth;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpDateDeath;
        private ComboBox cbCountries;
        private Label label4;
        private PictureBox pbPersonPhoto;
        private Button btnAddPersonPhoto;
        private CheckBox cbDateDeath;
    }
}