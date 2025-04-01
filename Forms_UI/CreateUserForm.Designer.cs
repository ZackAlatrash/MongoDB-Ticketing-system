namespace Forms_UI
{
    partial class CreateUserForm
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
            label18 = new Label();
            firstNameTextBox = new TextBox();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            comboBoxTypeofUser = new ComboBox();
            lastNameTextBox = new TextBox();
            emailTextBox = new TextBox();
            cancelButton = new Button();
            addUserButton = new Button();
            pnlCreateUser = new Panel();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            passwordTextBox = new TextBox();
            label1 = new Label();
            pnlCreateUser.SuspendLayout();
            SuspendLayout();
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(0, -1);
            label18.Name = "label18";
            label18.Size = new Size(284, 46);
            label18.TabIndex = 0;
            label18.Text = "Create New User";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(174, 90);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(357, 27);
            firstNameTextBox.TabIndex = 1;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10F);
            label19.Location = new Point(17, 90);
            label19.Name = "label19";
            label19.Size = new Size(93, 23);
            label19.TabIndex = 2;
            label19.Text = "First name:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F);
            label20.Location = new Point(17, 140);
            label20.Name = "label20";
            label20.Size = new Size(92, 23);
            label20.TabIndex = 4;
            label20.Text = "Last name:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10F);
            label21.Location = new Point(17, 186);
            label21.Name = "label21";
            label21.Size = new Size(106, 23);
            label21.TabIndex = 5;
            label21.Text = "Type of user:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10F);
            label22.Location = new Point(17, 234);
            label22.Name = "label22";
            label22.Size = new Size(125, 23);
            label22.TabIndex = 6;
            label22.Text = "E-mail address:";
            // 
            // comboBoxTypeofUser
            // 
            comboBoxTypeofUser.FormattingEnabled = true;
            comboBoxTypeofUser.Location = new Point(174, 186);
            comboBoxTypeofUser.Name = "comboBoxTypeofUser";
            comboBoxTypeofUser.Size = new Size(357, 28);
            comboBoxTypeofUser.TabIndex = 9;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(174, 140);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(357, 27);
            lastNameTextBox.TabIndex = 10;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(174, 234);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(357, 27);
            emailTextBox.TabIndex = 11;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(174, 380);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(125, 41);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += btnCancelAddUser_Click;
            // 
            // addUserButton
            // 
            addUserButton.BackColor = Color.SkyBlue;
            addUserButton.Location = new Point(406, 380);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(125, 41);
            addUserButton.TabIndex = 14;
            addUserButton.Text = "Add User";
            addUserButton.UseVisualStyleBackColor = false;
            addUserButton.Click += btnAddUser_Click;
            // 
            // pnlCreateUser
            // 
            pnlCreateUser.Controls.Add(txtConfirmPassword);
            pnlCreateUser.Controls.Add(lblConfirmPassword);
            pnlCreateUser.Controls.Add(passwordTextBox);
            pnlCreateUser.Controls.Add(label1);
            pnlCreateUser.Controls.Add(addUserButton);
            pnlCreateUser.Controls.Add(cancelButton);
            pnlCreateUser.Controls.Add(emailTextBox);
            pnlCreateUser.Controls.Add(lastNameTextBox);
            pnlCreateUser.Controls.Add(comboBoxTypeofUser);
            pnlCreateUser.Controls.Add(label22);
            pnlCreateUser.Controls.Add(label21);
            pnlCreateUser.Controls.Add(label20);
            pnlCreateUser.Controls.Add(label19);
            pnlCreateUser.Controls.Add(firstNameTextBox);
            pnlCreateUser.Controls.Add(label18);
            pnlCreateUser.Location = new Point(12, 12);
            pnlCreateUser.Name = "pnlCreateUser";
            pnlCreateUser.Size = new Size(586, 452);
            pnlCreateUser.TabIndex = 18;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(174, 335);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(357, 27);
            txtConfirmPassword.TabIndex = 18;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 10F);
            lblConfirmPassword.Location = new Point(17, 335);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(151, 23);
            lblConfirmPassword.TabIndex = 17;
            lblConfirmPassword.Text = "Confirm password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(174, 284);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(357, 27);
            passwordTextBox.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(17, 284);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 15;
            label1.Text = "Password";
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 488);
            Controls.Add(pnlCreateUser);
            Name = "CreateUserForm";
            Text = "Create User";
            Load += Form1_Load;
            pnlCreateUser.ResumeLayout(false);
            pnlCreateUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label18;
        private TextBox firstNameTextBox;
        private Label label19;
        private ComboBox comboBoxLocation;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label24;
        private ComboBox comboBoxTypeofUser;
        private TextBox lastNameTextBox;
        private TextBox emailTextBox;
        private Button cancelButton;
        private Button btnCancelAddUser;
        private Button addUserButton;
        private Panel pnlCreateUser;
        private TextBox passwordTextBox;
        private Label label1;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
    }
}