namespace FilmsStorage.Forms.Countries
{
    partial class UpdateCountry
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
            btnUpdateCountry = new Button();
            label1 = new Label();
            btnDeleteCountry = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 100);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 38;
            label5.Text = "Название";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbName.Location = new Point(12, 132);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(388, 27);
            tbName.TabIndex = 37;
            // 
            // btnUpdateCountry
            // 
            btnUpdateCountry.Anchor = AnchorStyles.Top;
            btnUpdateCountry.Location = new Point(33, 187);
            btnUpdateCountry.Margin = new Padding(3, 4, 3, 4);
            btnUpdateCountry.Name = "btnUpdateCountry";
            btnUpdateCountry.Size = new Size(149, 39);
            btnUpdateCountry.TabIndex = 36;
            btnUpdateCountry.Text = "Изменить";
            btnUpdateCountry.UseVisualStyleBackColor = true;
            btnUpdateCountry.Click += btnUpdateCountry_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 22);
            label1.Name = "label1";
            label1.Size = new Size(250, 41);
            label1.TabIndex = 35;
            label1.Text = "Изменить страну";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDeleteCountry
            // 
            btnDeleteCountry.Anchor = AnchorStyles.Top;
            btnDeleteCountry.Location = new Point(218, 187);
            btnDeleteCountry.Margin = new Padding(3, 4, 3, 4);
            btnDeleteCountry.Name = "btnDeleteCountry";
            btnDeleteCountry.Size = new Size(149, 39);
            btnDeleteCountry.TabIndex = 39;
            btnDeleteCountry.Text = "Удалить";
            btnDeleteCountry.UseVisualStyleBackColor = true;
            btnDeleteCountry.Click += btnDeleteCountry_Click;
            // 
            // UpdateCountry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 264);
            Controls.Add(btnDeleteCountry);
            Controls.Add(label5);
            Controls.Add(tbName);
            Controls.Add(btnUpdateCountry);
            Controls.Add(label1);
            Name = "UpdateCountry";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdateCountry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox tbName;
        private Button btnUpdateCountry;
        private Label label1;
        private Button btnDeleteCountry;
    }
}