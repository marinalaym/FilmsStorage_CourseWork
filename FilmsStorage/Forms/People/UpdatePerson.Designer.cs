namespace FilmsStorage.Forms.People
{
    partial class UpdatePerson
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
            cbDateDeath = new CheckBox();
            btnUpdatePersonPhoto = new Button();
            pbPersonPhoto = new PictureBox();
            label4 = new Label();
            cbCountries = new ComboBox();
            label3 = new Label();
            dtpDateDeath = new DateTimePicker();
            label2 = new Label();
            dtpDateBirth = new DateTimePicker();
            label5 = new Label();
            tbName = new TextBox();
            btnUpdatePerson = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPersonPhoto).BeginInit();
            SuspendLayout();
            // 
            // cbDateDeath
            // 
            cbDateDeath.AutoSize = true;
            cbDateDeath.Location = new Point(394, 249);
            cbDateDeath.Name = "cbDateDeath";
            cbDateDeath.Size = new Size(89, 24);
            cbDateDeath.TabIndex = 65;
            cbDateDeath.Text = "Не умер";
            cbDateDeath.UseVisualStyleBackColor = true;
            cbDateDeath.CheckedChanged += cbDateDeath_CheckedChanged;
            // 
            // btnUpdatePersonPhoto
            // 
            btnUpdatePersonPhoto.Location = new Point(38, 348);
            btnUpdatePersonPhoto.Margin = new Padding(3, 4, 3, 4);
            btnUpdatePersonPhoto.Name = "btnUpdatePersonPhoto";
            btnUpdatePersonPhoto.Size = new Size(149, 39);
            btnUpdatePersonPhoto.TabIndex = 64;
            btnUpdatePersonPhoto.Text = "Изменить фото";
            btnUpdatePersonPhoto.UseVisualStyleBackColor = true;
            btnUpdatePersonPhoto.Click += btnUpdatePersonPhoto_Click;
            // 
            // pbPersonPhoto
            // 
            pbPersonPhoto.BorderStyle = BorderStyle.FixedSingle;
            pbPersonPhoto.Location = new Point(12, 113);
            pbPersonPhoto.Name = "pbPersonPhoto";
            pbPersonPhoto.Size = new Size(196, 223);
            pbPersonPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonPhoto.TabIndex = 63;
            pbPersonPhoto.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(251, 328);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 62;
            label4.Text = "Страна";
            // 
            // cbCountries
            // 
            cbCountries.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbCountries.FormattingEnabled = true;
            cbCountries.Location = new Point(251, 359);
            cbCountries.Name = "cbCountries";
            cbCountries.Size = new Size(327, 28);
            cbCountries.TabIndex = 61;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(251, 243);
            label3.Name = "label3";
            label3.Size = new Size(124, 28);
            label3.TabIndex = 60;
            label3.Text = "Дата смерти";
            // 
            // dtpDateDeath
            // 
            dtpDateDeath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDateDeath.Location = new Point(251, 279);
            dtpDateDeath.Name = "dtpDateDeath";
            dtpDateDeath.Size = new Size(327, 27);
            dtpDateDeath.TabIndex = 59;
            dtpDateDeath.Value = new DateTime(2023, 12, 16, 20, 42, 33, 0);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(251, 156);
            label2.Name = "label2";
            label2.Size = new Size(153, 28);
            label2.TabIndex = 58;
            label2.Text = "Дата рождения";
            // 
            // dtpDateBirth
            // 
            dtpDateBirth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDateBirth.Location = new Point(251, 187);
            dtpDateBirth.Name = "dtpDateBirth";
            dtpDateBirth.Size = new Size(327, 27);
            dtpDateBirth.TabIndex = 57;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(251, 81);
            label5.Name = "label5";
            label5.Size = new Size(51, 28);
            label5.TabIndex = 56;
            label5.Text = "Имя";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbName.Location = new Point(251, 113);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(327, 27);
            tbName.TabIndex = 55;
            // 
            // btnUpdatePerson
            // 
            btnUpdatePerson.Anchor = AnchorStyles.Bottom;
            btnUpdatePerson.Location = new Point(206, 419);
            btnUpdatePerson.Margin = new Padding(3, 4, 3, 4);
            btnUpdatePerson.Name = "btnUpdatePerson";
            btnUpdatePerson.Size = new Size(149, 39);
            btnUpdatePerson.TabIndex = 54;
            btnUpdatePerson.Text = "Изменить";
            btnUpdatePerson.UseVisualStyleBackColor = true;
            btnUpdatePerson.Click += btnUpdatePerson_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(146, 21);
            label1.Name = "label1";
            label1.Size = new Size(288, 41);
            label1.TabIndex = 53;
            label1.Text = "Изменить человека";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // UpdatePerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 478);
            Controls.Add(cbDateDeath);
            Controls.Add(btnUpdatePersonPhoto);
            Controls.Add(pbPersonPhoto);
            Controls.Add(label4);
            Controls.Add(cbCountries);
            Controls.Add(label3);
            Controls.Add(dtpDateDeath);
            Controls.Add(label2);
            Controls.Add(dtpDateBirth);
            Controls.Add(label5);
            Controls.Add(tbName);
            Controls.Add(btnUpdatePerson);
            Controls.Add(label1);
            Name = "UpdatePerson";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdatePerson";
            ((System.ComponentModel.ISupportInitialize)pbPersonPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbDateDeath;
        private Button btnUpdatePersonPhoto;
        private PictureBox pbPersonPhoto;
        private Label label4;
        private ComboBox cbCountries;
        private Label label3;
        private DateTimePicker dtpDateDeath;
        private Label label2;
        private DateTimePicker dtpDateBirth;
        private Label label5;
        private TextBox tbName;
        private Button btnUpdatePerson;
        private Label label1;
    }
}