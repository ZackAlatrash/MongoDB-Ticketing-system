namespace Forms_UI
{
    partial class UpdateUserForm
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
            pnlCreateUser = new Panel();
            emailTextBox = new TextBox();
            lblEmail = new Label();
            addUserButton = new Button();
            cancelButton = new Button();
            lastNameTextBox = new TextBox();
            comboBoxTypeofUser = new ComboBox();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            firstNameTextBox = new TextBox();
            label18 = new Label();
            pnlCreateUser.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCreateUser
            // 
            pnlCreateUser.Controls.Add(emailTextBox);
            pnlCreateUser.Controls.Add(lblEmail);
            pnlCreateUser.Controls.Add(addUserButton);
            pnlCreateUser.Controls.Add(cancelButton);
            pnlCreateUser.Controls.Add(lastNameTextBox);
            pnlCreateUser.Controls.Add(comboBoxTypeofUser);
            pnlCreateUser.Controls.Add(label21);
            pnlCreateUser.Controls.Add(label20);
            pnlCreateUser.Controls.Add(label19);
            pnlCreateUser.Controls.Add(firstNameTextBox);
            pnlCreateUser.Controls.Add(label18);
            pnlCreateUser.Location = new Point(12, 12);
            pnlCreateUser.Name = "pnlCreateUser";
            pnlCreateUser.Size = new Size(586, 417);
            pnlCreateUser.TabIndex = 19;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(174, 236);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(357, 27);
            emailTextBox.TabIndex = 16;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(17, 236);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(125, 23);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "E-mail address:";
            // 
            // addUserButton
            // 
            addUserButton.BackColor = Color.SkyBlue;
            addUserButton.Location = new Point(406, 285);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(125, 41);
            addUserButton.TabIndex = 14;
            addUserButton.Text = "Update User";
            addUserButton.UseVisualStyleBackColor = false;
            addUserButton.Click += addUserButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(174, 285);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(125, 41);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(174, 140);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(357, 27);
            lastNameTextBox.TabIndex = 10;
            // 
            // comboBoxTypeofUser
            // 
            comboBoxTypeofUser.FormattingEnabled = true;
            comboBoxTypeofUser.Location = new Point(174, 186);
            comboBoxTypeofUser.Name = "comboBoxTypeofUser";
            comboBoxTypeofUser.Size = new Size(357, 28);
            comboBoxTypeofUser.TabIndex = 9;
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
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(174, 90);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(357, 27);
            firstNameTextBox.TabIndex = 1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(0, -1);
            label18.Name = "label18";
            label18.Size = new Size(217, 46);
            label18.TabIndex = 0;
            label18.Text = "Update User";
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 456);
            Controls.Add(pnlCreateUser);
            Name = "UpdateUserForm";
            Text = "Update User";
            Load += UpdateUserForm_Load;
            pnlCreateUser.ResumeLayout(false);
            pnlCreateUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCreateUser;
        private Button addUserButton;
        private Button cancelButton;
        private TextBox lastNameTextBox;
        private ComboBox comboBoxTypeofUser;
        private Label label21;
        private Label label20;
        private Label label19;
        private TextBox firstNameTextBox;
        private Label label18;
        private TextBox emailTextBox;
        private Label lblEmail;
    }
}