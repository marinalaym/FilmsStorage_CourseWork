namespace FilmsStorage.Forms.Users
{
    partial class ProfileControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnDeleteProfile = new Button();
            btnUpdateProfile = new Button();
            btnUpdatePassword = new Button();
            btnExit = new Button();
            lbName = new Label();
            lbLogin = new Label();
            lbRole = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(310, 22);
            label2.Name = "label2";
            label2.Size = new Size(144, 41);
            label2.TabIndex = 21;
            label2.Text = "Профиль";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 109);
            label4.Name = "label4";
            label4.Size = new Size(51, 28);
            label4.TabIndex = 29;
            label4.Text = "Имя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 167);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 27;
            label1.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 225);
            label3.Name = "label3";
            label3.Size = new Size(56, 28);
            label3.TabIndex = 30;
            label3.Text = "Роль";
            // 
            // btnDeleteProfile
            // 
            btnDeleteProfile.Location = new Point(18, 359);
            btnDeleteProfile.Margin = new Padding(3, 4, 3, 4);
            btnDeleteProfile.Name = "btnDeleteProfile";
            btnDeleteProfile.Size = new Size(200, 39);
            btnDeleteProfile.TabIndex = 41;
            btnDeleteProfile.Text = "Удалить аккаунт";
            btnDeleteProfile.UseVisualStyleBackColor = true;
            btnDeleteProfile.Click += btnDeleteProfile_Click;
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.Location = new Point(18, 293);
            btnUpdateProfile.Margin = new Padding(3, 4, 3, 4);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(200, 39);
            btnUpdateProfile.TabIndex = 40;
            btnUpdateProfile.Text = "Изменить профиль";
            btnUpdateProfile.UseVisualStyleBackColor = true;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.Location = new Point(236, 293);
            btnUpdatePassword.Margin = new Padding(3, 4, 3, 4);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(200, 39);
            btnUpdatePassword.TabIndex = 42;
            btnUpdatePassword.Text = "Изменить пароль";
            btnUpdatePassword.UseVisualStyleBackColor = true;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(236, 359);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 39);
            btnExit.TabIndex = 43;
            btnExit.Text = "Выйти из аккаунта";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(134, 116);
            lbName.Name = "lbName";
            lbName.Size = new Size(15, 20);
            lbName.TabIndex = 44;
            lbName.Text = "-";
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(134, 175);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(15, 20);
            lbLogin.TabIndex = 45;
            lbLogin.Text = "-";
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Location = new Point(134, 232);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(15, 20);
            lbRole.TabIndex = 46;
            lbRole.Text = "-";
            // 
            // ProfileControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbRole);
            Controls.Add(lbLogin);
            Controls.Add(lbName);
            Controls.Add(btnExit);
            Controls.Add(btnUpdatePassword);
            Controls.Add(btnDeleteProfile);
            Controls.Add(btnUpdateProfile);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "ProfileControl";
            Size = new Size(800, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label4;
        private Label label1;
        private Label label3;
        private Button btnDeleteProfile;
        private Button btnUpdateProfile;
        private Button btnUpdatePassword;
        private Button btnExit;
        private Label lbName;
        private Label lbLogin;
        private Label lbRole;
    }
}
