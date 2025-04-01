namespace Forms_UI
{
    partial class ResetPasswordForm
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
            PasswordLbl = new Label();
            ConfirPassLbl = new Label();
            PassTxtBox = new TextBox();
            ConfPassTxtBox = new TextBox();
            ChangePasBtn = new Button();
            SuspendLayout();
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.Location = new Point(58, 51);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(87, 15);
            PasswordLbl.TabIndex = 0;
            PasswordLbl.Text = "New password:";
            // 
            // ConfirPassLbl
            // 
            ConfirPassLbl.AutoSize = true;
            ConfirPassLbl.Location = new Point(38, 100);
            ConfirPassLbl.Name = "ConfirPassLbl";
            ConfirPassLbl.Size = new Size(107, 15);
            ConfirPassLbl.TabIndex = 1;
            ConfirPassLbl.Text = "Confirm password:";
            // 
            // PassTxtBox
            // 
            PassTxtBox.Location = new Point(170, 48);
            PassTxtBox.Name = "PassTxtBox";
            PassTxtBox.Size = new Size(151, 23);
            PassTxtBox.TabIndex = 2;
            // 
            // ConfPassTxtBox
            // 
            ConfPassTxtBox.Location = new Point(170, 97);
            ConfPassTxtBox.Name = "ConfPassTxtBox";
            ConfPassTxtBox.Size = new Size(151, 23);
            ConfPassTxtBox.TabIndex = 3;
            // 
            // ChangePasBtn
            // 
            ChangePasBtn.Location = new Point(140, 163);
            ChangePasBtn.Name = "ChangePasBtn";
            ChangePasBtn.Size = new Size(117, 23);
            ChangePasBtn.TabIndex = 4;
            ChangePasBtn.Text = "Change password";
            ChangePasBtn.UseVisualStyleBackColor = true;
            ChangePasBtn.Click += ChangePasBtn_Click;
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 211);
            Controls.Add(ChangePasBtn);
            Controls.Add(ConfPassTxtBox);
            Controls.Add(PassTxtBox);
            Controls.Add(ConfirPassLbl);
            Controls.Add(PasswordLbl);
            Name = "ResetPasswordForm";
            Text = "ResetPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PasswordLbl;
        private Label ConfirPassLbl;
        private TextBox PassTxtBox;
        private TextBox ConfPassTxtBox;
        private Button ChangePasBtn;
    }
}