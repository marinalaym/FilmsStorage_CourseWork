namespace FilmsStorage.Forms.Selections
{
    partial class CreateSelection
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
            btnAddSelection = new Button();
            label1 = new Label();
            label7 = new Label();
            tbDescription = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 107);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 38;
            label5.Text = "Название";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbName.Location = new Point(10, 139);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(388, 27);
            tbName.TabIndex = 37;
            // 
            // btnAddSelection
            // 
            btnAddSelection.Anchor = AnchorStyles.Top;
            btnAddSelection.Location = new Point(120, 366);
            btnAddSelection.Margin = new Padding(3, 4, 3, 4);
            btnAddSelection.Name = "btnAddSelection";
            btnAddSelection.Size = new Size(149, 39);
            btnAddSelection.TabIndex = 36;
            btnAddSelection.Text = "Добавить";
            btnAddSelection.UseVisualStyleBackColor = true;
            btnAddSelection.Click += btnAddSelection_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 29);
            label1.Name = "label1";
            label1.Size = new Size(291, 41);
            label1.TabIndex = 35;
            label1.Text = "Добавить подборку";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(10, 181);
            label7.Name = "label7";
            label7.Size = new Size(104, 28);
            label7.TabIndex = 74;
            label7.Text = "Описание";
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbDescription.Location = new Point(10, 213);
            tbDescription.Margin = new Padding(3, 4, 3, 4);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.ScrollBars = ScrollBars.Vertical;
            tbDescription.Size = new Size(387, 134);
            tbDescription.TabIndex = 73;
            // 
            // CreateSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 418);
            Controls.Add(label7);
            Controls.Add(tbDescription);
            Controls.Add(label5);
            Controls.Add(tbName);
            Controls.Add(btnAddSelection);
            Controls.Add(label1);
            Name = "CreateSelection";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreateSelection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox tbName;
        private Button btnAddSelection;
        private Label label1;
        private Label label7;
        private TextBox tbDescription;
    }
}