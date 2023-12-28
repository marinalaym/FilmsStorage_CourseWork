namespace FilmsStorage.Forms.Selections
{
    partial class UpdateSelection
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
            label7 = new Label();
            tbDescription = new TextBox();
            label5 = new Label();
            tbName = new TextBox();
            btnUpdateSelection = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(10, 173);
            label7.Name = "label7";
            label7.Size = new Size(104, 28);
            label7.TabIndex = 80;
            label7.Text = "Описание";
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbDescription.Location = new Point(10, 205);
            tbDescription.Margin = new Padding(3, 4, 3, 4);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.ScrollBars = ScrollBars.Vertical;
            tbDescription.Size = new Size(387, 134);
            tbDescription.TabIndex = 79;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 99);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 78;
            label5.Text = "Название";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbName.Location = new Point(10, 131);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(388, 27);
            tbName.TabIndex = 77;
            // 
            // btnUpdateSelection
            // 
            btnUpdateSelection.Anchor = AnchorStyles.Top;
            btnUpdateSelection.Location = new Point(120, 358);
            btnUpdateSelection.Margin = new Padding(3, 4, 3, 4);
            btnUpdateSelection.Name = "btnUpdateSelection";
            btnUpdateSelection.Size = new Size(149, 39);
            btnUpdateSelection.TabIndex = 76;
            btnUpdateSelection.Text = "Изменить";
            btnUpdateSelection.UseVisualStyleBackColor = true;
            btnUpdateSelection.Click += btnUpdateSelection_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 21);
            label1.Name = "label1";
            label1.Size = new Size(293, 41);
            label1.TabIndex = 75;
            label1.Text = "Изменить подборку";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // UpdateSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 418);
            Controls.Add(label7);
            Controls.Add(tbDescription);
            Controls.Add(label5);
            Controls.Add(tbName);
            Controls.Add(btnUpdateSelection);
            Controls.Add(label1);
            Name = "UpdateSelection";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdateSelection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox tbDescription;
        private Label label5;
        private TextBox tbName;
        private Button btnUpdateSelection;
        private Label label1;
    }
}