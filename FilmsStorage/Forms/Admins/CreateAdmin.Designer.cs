namespace FilmsStorage.Forms.Admins
{
    partial class CreateAdmin
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
            label4 = new Label();
            tbName = new TextBox();
            btnAddAdmin = new Button();
            label3 = new Label();
            label2 = new Label();
            tbPassword = new TextBox();
            tbLogin = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 341);
            label5.Name = "label5";
            label5.Size = new Size(183, 28);
            label5.TabIndex = 37;
            label5.Text = "Повторите пароль";
            // 
            // tbRepeatPassword
            // 
            tbRepeatPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbRepeatPassword.Location = new Point(12, 373);
            tbRepeatPassword.Margin = new Padding(3, 4, 3, 4);
            tbRepeatPassword.Name = "tbRepeatPassword";
            tbRepeatPassword.Size = new Size(428, 27);
            tbRepeatPassword.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 83);
            label4.Name = "label4";
            label4.Size = new Size(51, 28);
            label4.TabIndex = 35;
            label4.Text = "Имя";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbName.Location = new Point(12, 121);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(428, 27);
            tbName.TabIndex = 31;
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.Anchor = AnchorStyles.Top;
            btnAddAdmin.Location = new Point(154, 430);
            btnAddAdmin.Margin = new Padding(3, 4, 3, 4);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(149, 39);
            btnAddAdmin.TabIndex = 34;
            btnAddAdmin.Text = "Добавить";
            btnAddAdmin.UseVisualStyleBackColor = true;
            btnAddAdmin.Click += btnAddAdmin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 251);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 33;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 167);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 32;
            label2.Text = "Логин";
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPassword.Location = new Point(12, 283);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(428, 27);
            tbPassword.TabIndex = 30;
            // 
            // tbLogin
            // 
            tbLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbLogin.Location = new Point(12, 205);
            tbLogin.Margin = new Padding(3, 4, 3, 4);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(428, 27);
            tbLogin.TabIndex = 29;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(100, 24);
            label1.Name = "label1";
            label1.Size = new Size(258, 41);
            label1.TabIndex = 28;
            label1.Text = "Добавить админа";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // CreateAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 506);
            Controls.Add(label5);
            Controls.Add(tbRepeatPassword);
            Controls.Add(label4);
            Controls.Add(tbName);
            Controls.Add(btnAddAdmin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbPassword);
            Controls.Add(tbLogin);
            Controls.Add(label1);
            Name = "CreateAdmin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreateAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox tbRepeatPassword;
        private Label label4;
        private TextBox tbName;
        private Button btnAddAdmin;
        private Label label3;
        private Label label2;
        private TextBox tbPassword;
        private TextBox tbLogin;
        private Label label1;
    }
}