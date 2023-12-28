namespace FilmsStorage.Forms.Positions
{
    partial class UpdatePosition
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
            btnDeletePosition = new Button();
            label5 = new Label();
            tbName = new TextBox();
            btnUpdatePosition = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDeletePosition
            // 
            btnDeletePosition.Anchor = AnchorStyles.Top;
            btnDeletePosition.Location = new Point(217, 196);
            btnDeletePosition.Margin = new Padding(3, 4, 3, 4);
            btnDeletePosition.Name = "btnDeletePosition";
            btnDeletePosition.Size = new Size(149, 39);
            btnDeletePosition.TabIndex = 44;
            btnDeletePosition.Text = "Удалить";
            btnDeletePosition.UseVisualStyleBackColor = true;
            btnDeletePosition.Click += btnDeletePosition_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(9, 97);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 43;
            label5.Text = "Название";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbName.Location = new Point(9, 129);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(388, 27);
            tbName.TabIndex = 42;
            // 
            // btnUpdatePosition
            // 
            btnUpdatePosition.Anchor = AnchorStyles.Top;
            btnUpdatePosition.Location = new Point(32, 196);
            btnUpdatePosition.Margin = new Padding(3, 4, 3, 4);
            btnUpdatePosition.Name = "btnUpdatePosition";
            btnUpdatePosition.Size = new Size(149, 39);
            btnUpdatePosition.TabIndex = 41;
            btnUpdatePosition.Text = "Изменить";
            btnUpdatePosition.UseVisualStyleBackColor = true;
            btnUpdatePosition.Click += btnUpdatePosition_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 30);
            label1.Name = "label1";
            label1.Size = new Size(307, 41);
            label1.TabIndex = 40;
            label1.Text = "Изменить должность";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // UpdatePosition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 264);
            Controls.Add(btnDeletePosition);
            Controls.Add(label5);
            Controls.Add(tbName);
            Controls.Add(btnUpdatePosition);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UpdatePosition";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdatePosition";
            Click += btnUpdatePosition_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeletePosition;
        private Label label5;
        private TextBox tbName;
        private Button btnUpdatePosition;
        private Label label1;
    }
}