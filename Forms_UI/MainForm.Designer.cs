namespace Forms_UI
{
    partial class MainForm
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
            label6 = new Label();
            label5 = new Label();
            tabControl = new TabControl();
            tabPageDashboard = new TabPage();
            btnShowList = new Button();
            pnlIncidentsPDeadline = new Panel();
            label7 = new Label();
            label3 = new Label();
            pnlUnresolvedIncidents = new Panel();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageIncidentManagement = new TabPage();
            sortComboBox = new ComboBox();
            lblSortByStatus = new Label();
            transferTicketsButton = new Button();
            btnDeleteIncident = new Button();
            btnUpdateIncident = new Button();
            ticketView = new ListView();
            title = new ColumnHeader();
            description = new ColumnHeader();
            username = new ColumnHeader();
            handler = new ColumnHeader();
            status = new ColumnHeader();
            priority = new ColumnHeader();
            Start_Date = new ColumnHeader();
            btnCreateIncident = new Button();
            txtFilterByEmailIncident = new TextBox();
            label9 = new Label();
            tabPageUserManagement = new TabPage();
            updateUserButton = new Button();
            deleteUserButton = new Button();
            usersList = new ListView();
            firstNameColunm = new ColumnHeader();
            lastNameColunm = new ColumnHeader();
            emailColunm = new ColumnHeader();
            roleColunm = new ColumnHeader();
            btnAddNewUser = new Button();
            txtFilterByEmail = new TextBox();
            label8 = new Label();
            tabControl.SuspendLayout();
            tabPageDashboard.SuspendLayout();
            pnlIncidentsPDeadline.SuspendLayout();
            pnlUnresolvedIncidents.SuspendLayout();
            tabPageIncidentManagement.SuspendLayout();
            tabPageUserManagement.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(707, 71);
            label6.Name = "label6";
            label6.Size = new Size(280, 28);
            label6.TabIndex = 12;
            label6.Text = "Licensed to: The Garden Group";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(838, 13);
            label5.Name = "label5";
            label5.Size = new Size(145, 46);
            label5.TabIndex = 11;
            label5.Text = "NoDesk";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageDashboard);
            tabControl.Controls.Add(tabPageIncidentManagement);
            tabControl.Controls.Add(tabPageUserManagement);
            tabControl.Location = new Point(52, 105);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(935, 646);
            tabControl.TabIndex = 10;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabPageDashboard
            // 
            tabPageDashboard.Controls.Add(btnShowList);
            tabPageDashboard.Controls.Add(pnlIncidentsPDeadline);
            tabPageDashboard.Controls.Add(pnlUnresolvedIncidents);
            tabPageDashboard.Controls.Add(label1);
            tabPageDashboard.Location = new Point(4, 29);
            tabPageDashboard.Name = "tabPageDashboard";
            tabPageDashboard.Padding = new Padding(3);
            tabPageDashboard.Size = new Size(927, 613);
            tabPageDashboard.TabIndex = 0;
            tabPageDashboard.Text = "Dashboard";
            tabPageDashboard.UseVisualStyleBackColor = true;
            tabPageDashboard.Click += tabPageDashboard_Click;
            // 
            // btnShowList
            // 
            btnShowList.BackColor = Color.SkyBlue;
            btnShowList.Location = new Point(770, 25);
            btnShowList.Name = "btnShowList";
            btnShowList.Size = new Size(141, 35);
            btnShowList.TabIndex = 3;
            btnShowList.Text = "Show List";
            btnShowList.UseVisualStyleBackColor = false;
            // 
            // pnlIncidentsPDeadline
            // 
            pnlIncidentsPDeadline.Controls.Add(label7);
            pnlIncidentsPDeadline.Controls.Add(label3);
            pnlIncidentsPDeadline.Location = new Point(506, 76);
            pnlIncidentsPDeadline.Name = "pnlIncidentsPDeadline";
            pnlIncidentsPDeadline.Size = new Size(405, 330);
            pnlIncidentsPDeadline.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 55);
            label7.Name = "label7";
            label7.Size = new Size(299, 20);
            label7.TabIndex = 1;
            label7.Text = "These tickets need your immidiate attention";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(109, 18);
            label3.Name = "label3";
            label3.Size = new Size(212, 28);
            label3.TabIndex = 0;
            label3.Text = "Incidents Past Deadline";
            // 
            // pnlUnresolvedIncidents
            // 
            pnlUnresolvedIncidents.Controls.Add(label4);
            pnlUnresolvedIncidents.Controls.Add(label2);
            pnlUnresolvedIncidents.Location = new Point(21, 76);
            pnlUnresolvedIncidents.Name = "pnlUnresolvedIncidents";
            pnlUnresolvedIncidents.Size = new Size(405, 330);
            pnlUnresolvedIncidents.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 55);
            label4.Name = "label4";
            label4.Size = new Size(172, 20);
            label4.TabIndex = 1;
            label4.Text = "All tickets currently open";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(103, 18);
            label2.Name = "label2";
            label2.Size = new Size(194, 28);
            label2.TabIndex = 0;
            label2.Text = "Unresolved Incidents";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(297, 46);
            label1.TabIndex = 0;
            label1.Text = "Current Incidents";
            // 
            // tabPageIncidentManagement
            // 
            tabPageIncidentManagement.Controls.Add(sortComboBox);
            tabPageIncidentManagement.Controls.Add(lblSortByStatus);
            tabPageIncidentManagement.Controls.Add(transferTicketsButton);
            tabPageIncidentManagement.Controls.Add(btnDeleteIncident);
            tabPageIncidentManagement.Controls.Add(btnUpdateIncident);
            tabPageIncidentManagement.Controls.Add(ticketView);
            tabPageIncidentManagement.Controls.Add(btnCreateIncident);
            tabPageIncidentManagement.Controls.Add(txtFilterByEmailIncident);
            tabPageIncidentManagement.Controls.Add(label9);
            tabPageIncidentManagement.Location = new Point(4, 29);
            tabPageIncidentManagement.Name = "tabPageIncidentManagement";
            tabPageIncidentManagement.Padding = new Padding(3);
            tabPageIncidentManagement.Size = new Size(927, 613);
            tabPageIncidentManagement.TabIndex = 1;
            tabPageIncidentManagement.Text = "Incident Management";
            tabPageIncidentManagement.UseVisualStyleBackColor = true;
            // 
            // sortComboBox
            // 
            sortComboBox.FormattingEnabled = true;
            sortComboBox.Location = new Point(133, 130);
            sortComboBox.Name = "sortComboBox";
            sortComboBox.Size = new Size(151, 28);
            sortComboBox.TabIndex = 6;
            sortComboBox.SelectedIndexChanged += sortComboBox_SelectedIndexChanged;
            // 
            // lblSortByStatus
            // 
            lblSortByStatus.AutoSize = true;
            lblSortByStatus.Location = new Point(26, 133);
            lblSortByStatus.Name = "lblSortByStatus";
            lblSortByStatus.Size = new Size(101, 20);
            lblSortByStatus.TabIndex = 5;
            lblSortByStatus.Text = "Sort by status:";
            // 
            // transferTicketsButton
            // 
            transferTicketsButton.BackColor = Color.SkyBlue;
            transferTicketsButton.Location = new Point(589, 71);
            transferTicketsButton.Name = "transferTicketsButton";
            transferTicketsButton.Size = new Size(147, 47);
            transferTicketsButton.TabIndex = 4;
            transferTicketsButton.Text = "Transfer Ticket";
            transferTicketsButton.UseVisualStyleBackColor = false;
            transferTicketsButton.Click += button1_Click;
            // 
            // btnDeleteIncident
            // 
            btnDeleteIncident.BackColor = Color.Salmon;
            btnDeleteIncident.Location = new Point(755, 550);
            btnDeleteIncident.Name = "btnDeleteIncident";
            btnDeleteIncident.Size = new Size(147, 47);
            btnDeleteIncident.TabIndex = 5;
            btnDeleteIncident.Text = "Delete Incident";
            btnDeleteIncident.UseVisualStyleBackColor = false;
            btnDeleteIncident.Click += btnDeleteIncident_Click;
            // 
            // btnUpdateIncident
            // 
            btnUpdateIncident.BackColor = Color.White;
            btnUpdateIncident.Location = new Point(755, 71);
            btnUpdateIncident.Name = "btnUpdateIncident";
            btnUpdateIncident.Size = new Size(147, 47);
            btnUpdateIncident.TabIndex = 4;
            btnUpdateIncident.Text = "Update Incident";
            btnUpdateIncident.UseVisualStyleBackColor = false;
            btnUpdateIncident.Click += btnUpdateIncident_Click;
            // 
            // ticketView
            // 
            ticketView.Columns.AddRange(new ColumnHeader[] { title, description, username, handler, status, priority, Start_Date });
            ticketView.FullRowSelect = true;
            ticketView.GridLines = true;
            ticketView.Location = new Point(27, 171);
            ticketView.MultiSelect = false;
            ticketView.Name = "ticketView";
            ticketView.Size = new Size(878, 367);
            ticketView.TabIndex = 3;
            ticketView.UseCompatibleStateImageBehavior = false;
            ticketView.View = View.Details;
            ticketView.SelectedIndexChanged += ticketView_SelectedIndexChanged;
            // 
            // title
            // 
            title.Text = "Title";
            title.Width = 140;
            // 
            // description
            // 
            description.Text = "Description";
            description.Width = 200;
            // 
            // username
            // 
            username.Text = "Username";
            username.Width = 100;
            // 
            // handler
            // 
            handler.Text = "Handler";
            handler.Width = 100;
            // 
            // status
            // 
            status.Text = "Status";
            status.Width = 70;
            // 
            // priority
            // 
            priority.Text = "Priority";
            priority.Width = 70;
            // 
            // Start_Date
            // 
            Start_Date.Text = "Start Date";
            Start_Date.Width = 200;
            // 
            // btnCreateIncident
            // 
            btnCreateIncident.BackColor = Color.SkyBlue;
            btnCreateIncident.Location = new Point(421, 71);
            btnCreateIncident.Name = "btnCreateIncident";
            btnCreateIncident.Size = new Size(147, 47);
            btnCreateIncident.TabIndex = 2;
            btnCreateIncident.Text = "Create Incident";
            btnCreateIncident.UseVisualStyleBackColor = false;
            btnCreateIncident.Click += btnCreateIncident_Click;
            // 
            // txtFilterByEmailIncident
            // 
            txtFilterByEmailIncident.Location = new Point(26, 71);
            txtFilterByEmailIncident.Multiline = true;
            txtFilterByEmailIncident.Name = "txtFilterByEmailIncident";
            txtFilterByEmailIncident.Size = new Size(325, 47);
            txtFilterByEmailIncident.TabIndex = 1;
            txtFilterByEmailIncident.TextChanged += txtFilterByEmailIncident_TextChanged;
            txtFilterByEmailIncident.KeyPress += txtFilterByEmailIncident_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label9.Location = new Point(3, 3);
            label9.Name = "label9";
            label9.Size = new Size(290, 46);
            label9.TabIndex = 0;
            label9.Text = "Overview Tickets";
            // 
            // tabPageUserManagement
            // 
            tabPageUserManagement.Controls.Add(updateUserButton);
            tabPageUserManagement.Controls.Add(deleteUserButton);
            tabPageUserManagement.Controls.Add(usersList);
            tabPageUserManagement.Controls.Add(btnAddNewUser);
            tabPageUserManagement.Controls.Add(txtFilterByEmail);
            tabPageUserManagement.Controls.Add(label8);
            tabPageUserManagement.Font = new Font("Segoe UI", 9F);
            tabPageUserManagement.Location = new Point(4, 29);
            tabPageUserManagement.Name = "tabPageUserManagement";
            tabPageUserManagement.Padding = new Padding(3);
            tabPageUserManagement.Size = new Size(927, 613);
            tabPageUserManagement.TabIndex = 2;
            tabPageUserManagement.Text = "User Management";
            tabPageUserManagement.UseVisualStyleBackColor = true;
            // 
            // updateUserButton
            // 
            updateUserButton.BackColor = Color.SkyBlue;
            updateUserButton.Location = new Point(552, 80);
            updateUserButton.Name = "updateUserButton";
            updateUserButton.Size = new Size(147, 47);
            updateUserButton.TabIndex = 7;
            updateUserButton.Text = "Update User";
            updateUserButton.UseVisualStyleBackColor = false;
            updateUserButton.Click += updateUserButton_Click;
            // 
            // deleteUserButton
            // 
            deleteUserButton.BackColor = Color.SkyBlue;
            deleteUserButton.Location = new Point(759, 553);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(147, 47);
            deleteUserButton.TabIndex = 6;
            deleteUserButton.Text = "Delete User";
            deleteUserButton.UseVisualStyleBackColor = false;
            deleteUserButton.Click += deleteUserButton_Click_1;
            // 
            // usersList
            // 
            usersList.Columns.AddRange(new ColumnHeader[] { firstNameColunm, lastNameColunm, emailColunm, roleColunm });
            usersList.FullRowSelect = true;
            usersList.GridLines = true;
            usersList.Location = new Point(24, 158);
            usersList.Name = "usersList";
            usersList.Size = new Size(878, 381);
            usersList.TabIndex = 3;
            usersList.UseCompatibleStateImageBehavior = false;
            usersList.View = View.Details;
            // 
            // firstNameColunm
            // 
            firstNameColunm.Text = "First Name";
            firstNameColunm.Width = 200;
            // 
            // lastNameColunm
            // 
            lastNameColunm.Text = "Last Name";
            lastNameColunm.Width = 200;
            // 
            // emailColunm
            // 
            emailColunm.Text = "Email";
            emailColunm.Width = 250;
            // 
            // roleColunm
            // 
            roleColunm.Text = "Role";
            roleColunm.Width = 200;
            // 
            // btnAddNewUser
            // 
            btnAddNewUser.BackColor = Color.SkyBlue;
            btnAddNewUser.Location = new Point(753, 80);
            btnAddNewUser.Name = "btnAddNewUser";
            btnAddNewUser.Size = new Size(147, 47);
            btnAddNewUser.TabIndex = 2;
            btnAddNewUser.Text = "+Add New User";
            btnAddNewUser.UseVisualStyleBackColor = false;
            btnAddNewUser.Click += btnAddNewUser_Click;
            // 
            // txtFilterByEmail
            // 
            txtFilterByEmail.Location = new Point(24, 80);
            txtFilterByEmail.Multiline = true;
            txtFilterByEmail.Name = "txtFilterByEmail";
            txtFilterByEmail.Size = new Size(325, 47);
            txtFilterByEmail.TabIndex = 1;
            txtFilterByEmail.Text = "Filter by mail";
            txtFilterByEmail.TextChanged += txtFilterByEmail_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(17, 26);
            label8.Name = "label8";
            label8.Size = new Size(313, 46);
            label8.TabIndex = 0;
            label8.Text = "User Management";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 783);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tabControl);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            tabControl.ResumeLayout(false);
            tabPageDashboard.ResumeLayout(false);
            tabPageDashboard.PerformLayout();
            pnlIncidentsPDeadline.ResumeLayout(false);
            pnlIncidentsPDeadline.PerformLayout();
            pnlUnresolvedIncidents.ResumeLayout(false);
            pnlUnresolvedIncidents.PerformLayout();
            tabPageIncidentManagement.ResumeLayout(false);
            tabPageIncidentManagement.PerformLayout();
            tabPageUserManagement.ResumeLayout(false);
            tabPageUserManagement.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private TabControl tabControl;
        private TabPage tabPageDashboard;
        private TabPage tabPageIncidentManagement;
        private TabPage tabPageUserManagement;
        private Label label1;
        private Panel pnlIncidentsPDeadline;
        private Panel pnlUnresolvedIncidents;
        private Label label7;
        private Label label3;
        private Label label4;
        private Label label2;
        private Button btnShowList;
        private Button btnAddNewUser;
        private TextBox txtFilterByEmail;
        private Label label8;
        private Label label9;
        private Button btnCreateIncident;
        private TextBox txtFilterByEmailIncident;
        private ListView ticketView;
        private ListView usersList;
        private ColumnHeader title;
        private ColumnHeader description;
        private ColumnHeader status;
        private ColumnHeader username;
        private ColumnHeader priority;
        private ColumnHeader firstNameColunm;
        private ColumnHeader lastNameColunm;
        private ColumnHeader emailColunm;
        private ColumnHeader roleColunm;
        private Button transferTicketsButton;
        private Button deleteUserButton;
        private Button updateUserButton;
        private ComboBox sortComboBox;
        private Label lblSortByStatus;
        private Button btnDeleteIncident;
        private Button btnUpdateIncident;
        private ColumnHeader handler;
        private ColumnHeader Start_Date;
    }
}