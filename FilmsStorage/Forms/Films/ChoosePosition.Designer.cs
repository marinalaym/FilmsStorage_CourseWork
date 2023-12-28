namespace FilmsStorage.Forms.Films
{
    partial class ChoosePosition
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
            cbPosition = new ComboBox();
            btnChoosePosition = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(54, 24);
            label7.Name = "label7";
            label7.Size = new Size(319, 41);
            label7.TabIndex = 88;
            label7.Text = "Выберите профессию";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbPosition
            // 
            cbPosition.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbPosition.FormattingEnabled = true;
            cbPosition.Location = new Point(12, 92);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(388, 28);
            cbPosition.TabIndex = 86;
            // 
            // btnChoosePosition
            // 
            btnChoosePosition.Anchor = AnchorStyles.Top;
            btnChoosePosition.Location = new Point(135, 152);
            btnChoosePosition.Name = "btnChoosePosition";
            btnChoosePosition.Size = new Size(149, 39);
            btnChoosePosition.TabIndex = 78;
            btnChoosePosition.Text = "Выбрать";
            btnChoosePosition.UseVisualStyleBackColor = true;
            btnChoosePosition.Click += btnChoosePosition_Click;
            // 
            // ChoosePosition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 209);
            Controls.Add(label7);
            Controls.Add(cbPosition);
            Controls.Add(btnChoosePosition);
            Name = "ChoosePosition";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ChoosePosition";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private ComboBox cbPosition;
        private Button btnChoosePosition;
    }
}