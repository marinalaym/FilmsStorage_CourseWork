namespace FilmsStorage.Forms.Films
{
    partial class CreateFilm
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
            btnAddFilmPhoto = new Button();
            pbFilmPhoto = new PictureBox();
            label3 = new Label();
            dtpPremiereDate = new DateTimePicker();
            label5 = new Label();
            tbRussianName = new TextBox();
            btnAddFilm = new Button();
            label1 = new Label();
            label2 = new Label();
            tbEnglishName = new TextBox();
            label4 = new Label();
            label6 = new Label();
            cbAgeRestriction = new ComboBox();
            label7 = new Label();
            tbDescription = new TextBox();
            label8 = new Label();
            numYearProduction = new NumericUpDown();
            numDuration = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pbFilmPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYearProduction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            SuspendLayout();
            // 
            // btnAddFilmPhoto
            // 
            btnAddFilmPhoto.Location = new Point(38, 348);
            btnAddFilmPhoto.Margin = new Padding(3, 4, 3, 4);
            btnAddFilmPhoto.Name = "btnAddFilmPhoto";
            btnAddFilmPhoto.Size = new Size(149, 39);
            btnAddFilmPhoto.TabIndex = 64;
            btnAddFilmPhoto.Text = "Добавить фото";
            btnAddFilmPhoto.UseVisualStyleBackColor = true;
            btnAddFilmPhoto.Click += btnAddFilmPhoto_Click;
            // 
            // pbFilmPhoto
            // 
            pbFilmPhoto.BorderStyle = BorderStyle.FixedSingle;
            pbFilmPhoto.Location = new Point(12, 113);
            pbFilmPhoto.Name = "pbFilmPhoto";
            pbFilmPhoto.Size = new Size(196, 223);
            pbFilmPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFilmPhoto.TabIndex = 63;
            pbFilmPhoto.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(251, 312);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 60;
            label3.Text = "Премьера";
            // 
            // dtpPremiereDate
            // 
            dtpPremiereDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpPremiereDate.Location = new Point(251, 348);
            dtpPremiereDate.Name = "dtpPremiereDate";
            dtpPremiereDate.Size = new Size(327, 27);
            dtpPremiereDate.TabIndex = 59;
            dtpPremiereDate.Value = new DateTime(2023, 12, 16, 20, 42, 33, 0);
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(251, 69);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 56;
            label5.Text = "Название";
            // 
            // tbRussianName
            // 
            tbRussianName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbRussianName.Location = new Point(251, 101);
            tbRussianName.Margin = new Padding(3, 4, 3, 4);
            tbRussianName.Name = "tbRussianName";
            tbRussianName.Size = new Size(327, 27);
            tbRussianName.TabIndex = 55;
            // 
            // btnAddFilm
            // 
            btnAddFilm.Anchor = AnchorStyles.Bottom;
            btnAddFilm.Location = new Point(227, 721);
            btnAddFilm.Margin = new Padding(3, 4, 3, 4);
            btnAddFilm.Name = "btnAddFilm";
            btnAddFilm.Size = new Size(149, 39);
            btnAddFilm.TabIndex = 54;
            btnAddFilm.Text = "Добавить";
            btnAddFilm.UseVisualStyleBackColor = true;
            btnAddFilm.Click += btnAddFilm_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(142, 9);
            label1.Name = "label1";
            label1.Size = new Size(247, 41);
            label1.TabIndex = 53;
            label1.Text = "Добавить фильм";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(251, 150);
            label2.Name = "label2";
            label2.Size = new Size(158, 28);
            label2.TabIndex = 66;
            label2.Text = "Название (англ)";
            // 
            // tbEnglishName
            // 
            tbEnglishName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbEnglishName.Location = new Point(251, 182);
            tbEnglishName.Margin = new Padding(3, 4, 3, 4);
            tbEnglishName.Name = "tbEnglishName";
            tbEnglishName.Size = new Size(327, 27);
            tbEnglishName.TabIndex = 65;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(251, 231);
            label4.Name = "label4";
            label4.Size = new Size(125, 28);
            label4.TabIndex = 68;
            label4.Text = "Год выпуска";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(251, 481);
            label6.Name = "label6";
            label6.Size = new Size(243, 28);
            label6.TabIndex = 70;
            label6.Text = "Возрастное ограничение";
            // 
            // cbAgeRestriction
            // 
            cbAgeRestriction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbAgeRestriction.FormattingEnabled = true;
            cbAgeRestriction.Location = new Point(251, 512);
            cbAgeRestriction.Name = "cbAgeRestriction";
            cbAgeRestriction.Size = new Size(327, 28);
            cbAgeRestriction.TabIndex = 69;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 543);
            label7.Name = "label7";
            label7.Size = new Size(104, 28);
            label7.TabIndex = 72;
            label7.Text = "Описание";
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbDescription.Location = new Point(12, 575);
            tbDescription.Margin = new Padding(3, 4, 3, 4);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.ScrollBars = ScrollBars.Vertical;
            tbDescription.Size = new Size(566, 134);
            tbDescription.TabIndex = 71;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(251, 400);
            label8.Name = "label8";
            label8.Size = new Size(201, 28);
            label8.TabIndex = 74;
            label8.Text = "Продолжительность";
            // 
            // numYearProduction
            // 
            numYearProduction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numYearProduction.Location = new Point(251, 262);
            numYearProduction.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numYearProduction.Minimum = new decimal(new int[] { 1800, 0, 0, 0 });
            numYearProduction.Name = "numYearProduction";
            numYearProduction.Size = new Size(327, 27);
            numYearProduction.TabIndex = 75;
            numYearProduction.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // numDuration
            // 
            numDuration.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numDuration.Location = new Point(251, 431);
            numDuration.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(327, 27);
            numDuration.TabIndex = 76;
            // 
            // CreateFilm
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
            Controls.Add(btnAddFilmPhoto);
            Controls.Add(pbFilmPhoto);
            Controls.Add(label3);
            Controls.Add(dtpPremiereDate);
            Controls.Add(label5);
            Controls.Add(tbRussianName);
            Controls.Add(btnAddFilm);
            Controls.Add(label1);
            Name = "CreateFilm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreateFilm";
            ((System.ComponentModel.ISupportInitialize)pbFilmPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYearProduction).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddFilmPhoto;
        private PictureBox pbFilmPhoto;
        private Label label3;
        private DateTimePicker dtpPremiereDate;
        private Label label5;
        private TextBox tbRussianName;
        private Button btnAddFilm;
        private Label label1;
        private Label label2;
        private TextBox tbEnglishName;
        private Label label4;
        private Label label6;
        private ComboBox cbAgeRestriction;
        private Label label7;
        private TextBox tbDescription;
        private Label label8;
        private NumericUpDown numYearProduction;
        private NumericUpDown numDuration;
    }
}