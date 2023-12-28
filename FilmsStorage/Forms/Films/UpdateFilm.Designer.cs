namespace FilmsStorage.Forms.Films
{
    partial class UpdateFilm
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
            numDuration = new NumericUpDown();
            numYearProduction = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            tbDescription = new TextBox();
            label6 = new Label();
            cbAgeRestriction = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            tbEnglishName = new TextBox();
            btnUpdateFilmPhoto = new Button();
            pbFilmPhoto = new PictureBox();
            label3 = new Label();
            dtpPremiereDate = new DateTimePicker();
            label5 = new Label();
            tbRussianName = new TextBox();
            btnUpdateFilm = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYearProduction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFilmPhoto).BeginInit();
            SuspendLayout();
            // 
            // numDuration
            // 
            numDuration.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numDuration.Location = new Point(251, 433);
            numDuration.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(327, 27);
            numDuration.TabIndex = 94;
            // 
            // numYearProduction
            // 
            numYearProduction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numYearProduction.Location = new Point(251, 264);
            numYearProduction.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numYearProduction.Minimum = new decimal(new int[] { 1800, 0, 0, 0 });
            numYearProduction.Name = "numYearProduction";
            numYearProduction.Size = new Size(327, 27);
            numYearProduction.TabIndex = 93;
            numYearProduction.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(251, 402);
            label8.Name = "label8";
            label8.Size = new Size(201, 28);
            label8.TabIndex = 92;
            label8.Text = "Продолжительность";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 545);
            label7.Name = "label7";
            label7.Size = new Size(104, 28);
            label7.TabIndex = 91;
            label7.Text = "Описание";
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbDescription.Location = new Point(12, 577);
            tbDescription.Margin = new Padding(3, 4, 3, 4);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.ScrollBars = ScrollBars.Vertical;
            tbDescription.Size = new Size(566, 134);
            tbDescription.TabIndex = 90;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(251, 483);
            label6.Name = "label6";
            label6.Size = new Size(243, 28);
            label6.TabIndex = 89;
            label6.Text = "Возрастное ограничение";
            // 
            // cbAgeRestriction
            // 
            cbAgeRestriction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbAgeRestriction.FormattingEnabled = true;
            cbAgeRestriction.Location = new Point(251, 514);
            cbAgeRestriction.Name = "cbAgeRestriction";
            cbAgeRestriction.Size = new Size(327, 28);
            cbAgeRestriction.TabIndex = 88;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(251, 233);
            label4.Name = "label4";
            label4.Size = new Size(125, 28);
            label4.TabIndex = 87;
            label4.Text = "Год выпуска";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(251, 152);
            label2.Name = "label2";
            label2.Size = new Size(158, 28);
            label2.TabIndex = 86;
            label2.Text = "Название (англ)";
            // 
            // tbEnglishName
            // 
            tbEnglishName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbEnglishName.Location = new Point(251, 184);
            tbEnglishName.Margin = new Padding(3, 4, 3, 4);
            tbEnglishName.Name = "tbEnglishName";
            tbEnglishName.Size = new Size(327, 27);
            tbEnglishName.TabIndex = 85;
            // 
            // btnUpdateFilmPhoto
            // 
            btnUpdateFilmPhoto.Location = new Point(38, 350);
            btnUpdateFilmPhoto.Margin = new Padding(3, 4, 3, 4);
            btnUpdateFilmPhoto.Name = "btnUpdateFilmPhoto";
            btnUpdateFilmPhoto.Size = new Size(149, 39);
            btnUpdateFilmPhoto.TabIndex = 84;
            btnUpdateFilmPhoto.Text = "Изменить фото";
            btnUpdateFilmPhoto.UseVisualStyleBackColor = true;
            btnUpdateFilmPhoto.Click += btnUpdateFilmPhoto_Click;
            // 
            // pbFilmPhoto
            // 
            pbFilmPhoto.BorderStyle = BorderStyle.FixedSingle;
            pbFilmPhoto.Location = new Point(12, 115);
            pbFilmPhoto.Name = "pbFilmPhoto";
            pbFilmPhoto.Size = new Size(196, 223);
            pbFilmPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFilmPhoto.TabIndex = 83;
            pbFilmPhoto.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(251, 314);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 82;
            label3.Text = "Премьера";
            // 
            // dtpPremiereDate
            // 
            dtpPremiereDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpPremiereDate.Location = new Point(251, 350);
            dtpPremiereDate.Name = "dtpPremiereDate";
            dtpPremiereDate.Size = new Size(327, 27);
            dtpPremiereDate.TabIndex = 81;
            dtpPremiereDate.Value = new DateTime(2023, 12, 16, 20, 42, 33, 0);
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(251, 71);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 80;
            label5.Text = "Название";
            // 
            // tbRussianName
            // 
            tbRussianName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbRussianName.Location = new Point(251, 103);
            tbRussianName.Margin = new Padding(3, 4, 3, 4);
            tbRussianName.Name = "tbRussianName";
            tbRussianName.Size = new Size(327, 27);
            tbRussianName.TabIndex = 79;
            // 
            // btnUpdateFilm
            // 
            btnUpdateFilm.Anchor = AnchorStyles.Bottom;
            btnUpdateFilm.Location = new Point(227, 721);
            btnUpdateFilm.Margin = new Padding(3, 4, 3, 4);
            btnUpdateFilm.Name = "btnUpdateFilm";
            btnUpdateFilm.Size = new Size(149, 39);
            btnUpdateFilm.TabIndex = 78;
            btnUpdateFilm.Text = "Изменить";
            btnUpdateFilm.UseVisualStyleBackColor = true;
            btnUpdateFilm.Click += btnUpdateFilm_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(160, 9);
            label1.Name = "label1";
            label1.Size = new Size(249, 41);
            label1.TabIndex = 77;
            label1.Text = "Изменить фильм";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // UpdateFilm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 773);
            Controls.Add(numDuration);
            Controls.Add(numYearProduction);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(tbDescription);
            Controls.Add(label6);
            Controls.Add(cbAgeRestriction);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(tbEnglishName);
            Controls.Add(btnUpdateFilmPhoto);
            Controls.Add(pbFilmPhoto);
            Controls.Add(label3);
            Controls.Add(dtpPremiereDate);
            Controls.Add(label5);
            Controls.Add(tbRussianName);
            Controls.Add(btnUpdateFilm);
            Controls.Add(label1);
            Name = "UpdateFilm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdateFilm";
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYearProduction).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFilmPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numDuration;
        private NumericUpDown numYearProduction;
        private Label label8;
        private Label label7;
        private TextBox tbDescription;
        private Label label6;
        private ComboBox cbAgeRestriction;
        private Label label4;
        private Label label2;
        private TextBox tbEnglishName;
        private Button btnUpdateFilmPhoto;
        private PictureBox pbFilmPhoto;
        private Label label3;
        private DateTimePicker dtpPremiereDate;
        private Label label5;
        private TextBox tbRussianName;
        private Button btnUpdateFilm;
        private Label label1;
    }
}