namespace FilmsStorage.Forms.Users
{
    partial class UpdateProfile
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
            btnUpdateProfile = new Button();
            label1 = new Label();
            label4 = new Label();
            tbName = new TextBox();
            label2 = new Label();
            tbLogin = new TextBox();
            SuspendLayout();
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.Anchor = AnchorStyles.Top;
            btnUpdateProfile.Location = new Point(99, 266);
            btnUpdateProfile.Margin = new Padding(3, 4, 3, 4);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(149, 39);
            btnUpdateProfile.TabIndex = 41;
            btnUpdateProfile.Text = "Изменить";
            btnUpdateProfile.UseVisualStyleBackColor = true;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 25);
            label1.Name = "label1";
            label1.Size = new Size(281, 41);
            label1.TabIndex = 40;
            label1.Text = "Изменить профиль";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 92);
            label4.Name = "label4";
            label4.Size = new Size(51, 28);
            label4.TabIndex = 46;
            label4.Text = "Имя";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbName.Location = new Point(12, 130);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(319, 27);
            tbName.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 176);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 45;
            label2.Text = "Логин";
            // 
            // tbLogin
            // 
            tbLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbLogin.Location = new Point(12, 214);
            tbLogin.Margin = new Padding(3, 4, 3, 4);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(319, 27);
            tbLogin.TabIndex = 43;
            // 
            // UpdateProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 342);
            Controls.Add(label4);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(tbLogin);
            Controls.Add(btnUpdateProfile);
            Controls.Add(label1);
            Name = "UpdateProfile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdateProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdateProfile;
        private Label label1;
        private Label label4;
        private TextBox tbName;
        private Label label2;
        private TextBox tbLogin;
    }
}