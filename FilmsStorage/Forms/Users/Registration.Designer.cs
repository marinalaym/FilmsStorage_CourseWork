namespace FilmsStorage.Forms.Users
{
    partial class Registration
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
            btnRegister = new Button();
            label3 = new Label();
            label2 = new Label();
            tbPassword = new TextBox();
            tbLogin = new TextBox();
            label1 = new Label();
            label4 = new Label();
            tbName = new TextBox();
            label5 = new Label();
            tbRepeatPassword = new TextBox();
            label6 = new Label();
            btnAuthorization = new Button();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top;
            btnRegister.Location = new Point(122, 424);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(173, 45);
            btnRegister.TabIndex = 23;
            btnRegister.Text = "Зарегистрироваться";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 245);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 21;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 161);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 20;
            label2.Text = "Логин";
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPassword.Location = new Point(14, 277);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(388, 27);
            tbPassword.TabIndex = 18;
            // 
            // tbLogin
            // 
            tbLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbLogin.Location = new Point(14, 199);
            tbLogin.Margin = new Padding(3, 4, 3, 4);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(388, 27);
            tbLogin.TabIndex = 17;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(122, 25);
            label1.Name = "label1";
            label1.Size = new Size(188, 41);
            label1.TabIndex = 16;
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(14, 77);
            label4.Name = "label4";
            label4.Size = new Size(51, 28);
            label4.TabIndex = 24;
            label4.Text = "Имя";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbName.Location = new Point(14, 115);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(388, 27);
            tbName.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 335);
            label5.Name = "label5";
            label5.Size = new Size(183, 28);
            label5.TabIndex = 27;
            label5.Text = "Повторите пароль";
            // 
            // tbRepeatPassword
            // 
            tbRepeatPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbRepeatPassword.Location = new Point(14, 367);
            tbRepeatPassword.Margin = new Padding(3, 4, 3, 4);
            tbRepeatPassword.Name = "tbRepeatPassword";
            tbRepeatPassword.PasswordChar = '*';
            tbRepeatPassword.Size = new Size(388, 27);
            tbRepeatPassword.TabIndex = 26;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(311, 545);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 29;
            label6.Text = "Есть аккаунт?";
            // 
            // btnAuthorization
            // 
            btnAuthorization.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAuthorization.Location = new Point(234, 569);
            btnAuthorization.Margin = new Padding(3, 4, 3, 4);
            btnAuthorization.Name = "btnAuthorization";
            btnAuthorization.Size = new Size(168, 29);
            btnAuthorization.TabIndex = 28;
            btnAuthorization.Text = "Авторизация";
            btnAuthorization.UseVisualStyleBackColor = true;
            btnAuthorization.Click += btnAuthorization_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 618);
            Controls.Add(label6);
            Controls.Add(btnAuthorization);
            Controls.Add(label5);
            Controls.Add(tbRepeatPassword);
            Controls.Add(label4);
            Controls.Add(tbName);
            Controls.Add(btnRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbPassword);
            Controls.Add(tbLogin);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Label label3;
        private Label label2;
        private TextBox tbPassword;
        private TextBox tbLogin;
        private Label label1;
        private Label label4;
        private TextBox tbName;
        private Label label5;
        private TextBox tbRepeatPassword;
        private Label label6;
        private Button btnAuthorization;
    }
}