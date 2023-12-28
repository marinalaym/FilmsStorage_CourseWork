namespace FilmsStorage.Forms.Countries
{
    partial class CreateCountry
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
            btnAddCountry = new Button();
            label1 = new Label();
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
            label5.TabIndex = 34;
            label5.Text = "Название";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbName.Location = new Point(12, 132);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(388, 27);
            tbName.TabIndex = 33;
            // 
            // btnAddCountry
            // 
            btnAddCountry.Anchor = AnchorStyles.Top;
            btnAddCountry.Location = new Point(125, 190);
            btnAddCountry.Margin = new Padding(3, 4, 3, 4);
            btnAddCountry.Name = "btnAddCountry";
            btnAddCountry.Size = new Size(149, 39);
            btnAddCountry.TabIndex = 32;
            btnAddCountry.Text = "Добавить";
            btnAddCountry.UseVisualStyleBackColor = true;
            btnAddCountry.Click += btnAddCountry_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 22);
            label1.Name = "label1";
            label1.Size = new Size(248, 41);
            label1.TabIndex = 31;
            label1.Text = "Добавить страну";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // AddCountry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 264);
            Controls.Add(label5);
            Controls.Add(tbName);
            Controls.Add(btnAddCountry);
            Controls.Add(label1);
            Name = "AddCountry";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddCountry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox tbName;
        private Button btnAddCountry;
        private Label label1;
    }
}