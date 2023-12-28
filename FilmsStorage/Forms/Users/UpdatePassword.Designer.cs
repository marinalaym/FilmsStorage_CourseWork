namespace FilmsStorage.Forms.Users
{
    partial class UpdatePassword
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
            tbRepeatPassword = new TextBox();
            label3 = new Label();
            tbPassword = new TextBox();
            tbOldPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnUpdatePassword = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 250);
            label5.Name = "label5";
            label5.Size = new Size(183, 28);
            label5.TabIndex = 31;
            label5.Text = "Повторите пароль";
            // 
            // tbRepeatPassword
            // 
            tbRepeatPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbRepeatPassword.Location = new Point(12, 282);
            tbRepeatPassword.Margin = new Padding(3, 4, 3, 4);
            tbRepeatPassword.Name = "tbRepeatPassword";
            tbRepeatPassword.PasswordChar = '*';
            tbRepeatPassword.Size = new Size(333, 27);
            tbRepeatPassword.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 164);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 29;
            label3.Text = "Новый пароль";
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPassword.Location = new Point(12, 196);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(333, 27);
            tbPassword.TabIndex = 28;
            // 
            // tbOldPassword
            // 
            tbOldPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbOldPassword.Location = new Point(12, 120);
            tbOldPassword.Margin = new Padding(3, 4, 3, 4);
            tbOldPassword.Name = "tbOldPassword";
            tbOldPassword.PasswordChar = '*';
            tbOldPassword.Size = new Size(333, 27);
            tbOldPassword.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 33;
            label2.Text = "Старый пароль";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 21);
            label1.Name = "label1";
            label1.Size = new Size(258, 41);
            label1.TabIndex = 36;
            label1.Text = "Изменить пароль";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.Anchor = AnchorStyles.Top;
            btnUpdatePassword.Location = new Point(100, 339);
            btnUpdatePassword.Margin = new Padding(3, 4, 3, 4);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(149, 39);
            btnUpdatePassword.TabIndex = 37;
            btnUpdatePassword.Text = "Изменить";
            btnUpdatePassword.UseVisualStyleBackColor = true;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // UpdatePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 409);
            Controls.Add(btnUpdatePassword);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(tbOldPassword);
            Controls.Add(label5);
            Controls.Add(tbRepeatPassword);
            Controls.Add(label3);
            Controls.Add(tbPassword);
            Name = "UpdatePassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdatePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox tbRepeatPassword;
        private Label label3;
        private TextBox tbPassword;
        private TextBox tbOldPassword;
        private Label label2;
        private Label label1;
        private Button btnUpdatePassword;
    }
}