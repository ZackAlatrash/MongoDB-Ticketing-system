namespace Forms_UI
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            LoginTitleLbl = new Label();
            LicenseLbl = new Label();
            ProvidingLblTxt = new Label();
            ServiceDeskHeaderLbl = new Label();
            PasswordBox = new TextBox();
            Username = new Label();
            ForgotPassLbl = new Label();
            RememeberMeBox = new CheckBox();
            UsernameBox = new TextBox();
            label2 = new Label();
            LoginBtn = new Button();
            SuspendLayout();
            // 
            // LoginTitleLbl
            // 
            LoginTitleLbl.AutoSize = true;
            LoginTitleLbl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginTitleLbl.Location = new Point(764, 7);
            LoginTitleLbl.Name = "LoginTitleLbl";
            LoginTitleLbl.Size = new Size(117, 37);
            LoginTitleLbl.TabIndex = 8;
            LoginTitleLbl.Text = "NoDesk";
            // 
            // LicenseLbl
            // 
            LicenseLbl.AutoSize = true;
            LicenseLbl.Font = new Font("Segoe UI", 12F);
            LicenseLbl.Location = new Point(649, 50);
            LicenseLbl.Name = "LicenseLbl";
            LicenseLbl.Size = new Size(223, 21);
            LicenseLbl.TabIndex = 9;
            LicenseLbl.Text = "Licensed to: The Garden Group";
            // 
            // ProvidingLblTxt
            // 
            ProvidingLblTxt.AutoSize = true;
            ProvidingLblTxt.Location = new Point(262, 137);
            ProvidingLblTxt.Name = "ProvidingLblTxt";
            ProvidingLblTxt.Size = new Size(392, 15);
            ProvidingLblTxt.TabIndex = 18;
            ProvidingLblTxt.Text = "Please provide login credentials to login to NoDesk for The Garden Group";
            // 
            // ServiceDeskHeaderLbl
            // 
            ServiceDeskHeaderLbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ServiceDeskHeaderLbl.Location = new Point(429, 92);
            ServiceDeskHeaderLbl.Name = "ServiceDeskHeaderLbl";
            ServiceDeskHeaderLbl.Size = new Size(152, 31);
            ServiceDeskHeaderLbl.TabIndex = 17;
            ServiceDeskHeaderLbl.Text = "NoDesk: TGC";
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(347, 241);
            PasswordBox.Margin = new Padding(3, 2, 3, 2);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(279, 23);
            PasswordBox.TabIndex = 14;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(347, 175);
            Username.Name = "Username";
            Username.Size = new Size(60, 15);
            Username.TabIndex = 11;
            Username.Text = "Username";
            // 
            // ForgotPassLbl
            // 
            ForgotPassLbl.AutoSize = true;
            ForgotPassLbl.ForeColor = SystemColors.Highlight;
            ForgotPassLbl.Location = new Point(494, 270);
            ForgotPassLbl.Name = "ForgotPassLbl";
            ForgotPassLbl.Size = new Size(120, 15);
            ForgotPassLbl.TabIndex = 16;
            ForgotPassLbl.Text = "Forgot my password?";
            ForgotPassLbl.Click += ForgotPassLbl_Click;
            // 
            // RememeberMeBox
            // 
            RememeberMeBox.AutoSize = true;
            RememeberMeBox.Location = new Point(347, 270);
            RememeberMeBox.Margin = new Padding(3, 2, 3, 2);
            RememeberMeBox.Name = "RememeberMeBox";
            RememeberMeBox.Size = new Size(104, 19);
            RememeberMeBox.TabIndex = 15;
            RememeberMeBox.Text = "Remember Me";
            RememeberMeBox.UseVisualStyleBackColor = true;
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(347, 192);
            UsernameBox.Margin = new Padding(3, 2, 3, 2);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(279, 23);
            UsernameBox.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 224);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(376, 314);
            LoginBtn.Margin = new Padding(3, 2, 3, 2);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(226, 34);
            LoginBtn.TabIndex = 10;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 439);
            Controls.Add(ProvidingLblTxt);
            Controls.Add(ServiceDeskHeaderLbl);
            Controls.Add(PasswordBox);
            Controls.Add(Username);
            Controls.Add(ForgotPassLbl);
            Controls.Add(RememeberMeBox);
            Controls.Add(UsernameBox);
            Controls.Add(label2);
            Controls.Add(LoginBtn);
            Controls.Add(LicenseLbl);
            Controls.Add(LoginTitleLbl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private Label LoginTitleLbl;
        private Label LicenseLbl;
        private Label ProvidingLblTxt;
        private Label ServiceDeskHeaderLbl;
        private TextBox PasswordBox;
        private Label Username;
        private Label ForgotPassLbl;
        private CheckBox RememeberMeBox;
        private TextBox UsernameBox;
        private Label label2;
        private Button LoginBtn;
    }
}
