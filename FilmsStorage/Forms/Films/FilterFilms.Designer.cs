namespace FilmsStorage.Forms.Films
{
    partial class FilterFilms
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
            btnOk = new Button();
            label4 = new Label();
            cbCountry = new ComboBox();
            label1 = new Label();
            cbGenre = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            cbAgeRestriction = new ComboBox();
            label7 = new Label();
            numYearProductionStart = new NumericUpDown();
            numYearProductionEnd = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numYearProductionStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYearProductionEnd).BeginInit();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom;
            btnOk.Location = new Point(135, 480);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(149, 39);
            btnOk.TabIndex = 0;
            btnOk.Text = "Применить";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 385);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 50;
            label4.Text = "Страна";
            // 
            // cbCountry
            // 
            cbCountry.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(12, 416);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(388, 28);
            cbCountry.TabIndex = 49;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 304);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 52;
            label1.Text = "Жанр";
            // 
            // cbGenre
            // 
            cbGenre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbGenre.FormattingEnabled = true;
            cbGenre.Location = new Point(12, 335);
            cbGenre.Name = "cbGenre";
            cbGenre.Size = new Size(388, 28);
            cbGenre.TabIndex = 51;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(125, 28);
            label2.TabIndex = 53;
            label2.Text = "Год выпуска";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 54;
            label3.Text = "От";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 181);
            label5.Name = "label5";
            label5.Size = new Size(28, 20);
            label5.TabIndex = 56;
            label5.Text = "До";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 228);
            label6.Name = "label6";
            label6.Size = new Size(136, 28);
            label6.TabIndex = 58;
            label6.Text = "Ограничение";
            // 
            // cbAgeRestriction
            // 
            cbAgeRestriction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbAgeRestriction.FormattingEnabled = true;
            cbAgeRestriction.Location = new Point(12, 259);
            cbAgeRestriction.Name = "cbAgeRestriction";
            cbAgeRestriction.Size = new Size(388, 28);
            cbAgeRestriction.TabIndex = 57;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(146, 24);
            label7.Name = "label7";
            label7.Size = new Size(118, 41);
            label7.TabIndex = 59;
            label7.Text = "Фильтр";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // numYearProductionStart
            // 
            numYearProductionStart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numYearProductionStart.Location = new Point(54, 126);
            numYearProductionStart.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numYearProductionStart.Name = "numYearProductionStart";
            numYearProductionStart.Size = new Size(346, 27);
            numYearProductionStart.TabIndex = 76;
            // 
            // numYearProductionEnd
            // 
            numYearProductionEnd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numYearProductionEnd.Location = new Point(54, 174);
            numYearProductionEnd.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numYearProductionEnd.Name = "numYearProductionEnd";
            numYearProductionEnd.Size = new Size(346, 27);
            numYearProductionEnd.TabIndex = 77;
            numYearProductionEnd.Value = new decimal(new int[] { 3000, 0, 0, 0 });
            // 
            // FilterFilms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 531);
            Controls.Add(numYearProductionEnd);
            Controls.Add(numYearProductionStart);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cbAgeRestriction);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbGenre);
            Controls.Add(label4);
            Controls.Add(cbCountry);
            Controls.Add(btnOk);
            Name = "FilterFilms";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FilterFilmsDialog";
            ((System.ComponentModel.ISupportInitialize)numYearProductionStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYearProductionEnd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Label label4;
        private ComboBox cbCountry;
        private Label label1;
        private ComboBox cbGenre;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private ComboBox cbAgeRestriction;
        private Label label7;
        private NumericUpDown numYearProductionStart;
        private NumericUpDown numYearProductionEnd;
    }
}