namespace Forms_UI
{
    partial class IncidentCreatorModal
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
            pnlCreateNewIncident = new Panel();
            comboBoxStatus = new ComboBox();
            label2 = new Label();
            comboBoxHandler = new ComboBox();
            label1 = new Label();
            dateTimeDeadline = new DateTimePicker();
            dateTimeReportTime = new DateTimePicker();
            btnSubmitIncident = new Button();
            btnCancelIncidentSubmission = new Button();
            textBoxDescription = new TextBox();
            label17 = new Label();
            comboBoxPriority = new ComboBox();
            comboBoxUsername = new ComboBox();
            txtBoxSubjectofIncident = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label12 = new Label();
            label11 = new Label();
            TopLabel = new Label();
            pnlCreateNewIncident.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCreateNewIncident
            // 
            pnlCreateNewIncident.Controls.Add(comboBoxStatus);
            pnlCreateNewIncident.Controls.Add(label2);
            pnlCreateNewIncident.Controls.Add(comboBoxHandler);
            pnlCreateNewIncident.Controls.Add(label1);
            pnlCreateNewIncident.Controls.Add(dateTimeDeadline);
            pnlCreateNewIncident.Controls.Add(dateTimeReportTime);
            pnlCreateNewIncident.Controls.Add(btnSubmitIncident);
            pnlCreateNewIncident.Controls.Add(btnCancelIncidentSubmission);
            pnlCreateNewIncident.Controls.Add(textBoxDescription);
            pnlCreateNewIncident.Controls.Add(label17);
            pnlCreateNewIncident.Controls.Add(comboBoxPriority);
            pnlCreateNewIncident.Controls.Add(comboBoxUsername);
            pnlCreateNewIncident.Controls.Add(txtBoxSubjectofIncident);
            pnlCreateNewIncident.Controls.Add(label16);
            pnlCreateNewIncident.Controls.Add(label15);
            pnlCreateNewIncident.Controls.Add(label14);
            pnlCreateNewIncident.Controls.Add(label12);
            pnlCreateNewIncident.Controls.Add(label11);
            pnlCreateNewIncident.Controls.Add(TopLabel);
            pnlCreateNewIncident.Location = new Point(0, 0);
            pnlCreateNewIncident.Name = "pnlCreateNewIncident";
            pnlCreateNewIncident.Size = new Size(578, 616);
            pnlCreateNewIncident.TabIndex = 5;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Open", "Solved", "Closed" });
            comboBoxStatus.Location = new Point(195, 314);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(319, 28);
            comboBoxStatus.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(21, 270);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 21;
            label2.Text = "Priority:";
            // 
            // comboBoxHandler
            // 
            comboBoxHandler.FormattingEnabled = true;
            comboBoxHandler.Location = new Point(195, 223);
            comboBoxHandler.Name = "comboBoxHandler";
            comboBoxHandler.Size = new Size(319, 28);
            comboBoxHandler.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(21, 223);
            label1.Name = "label1";
            label1.Size = new Size(138, 23);
            label1.TabIndex = 19;
            label1.Text = "Handled by user:";
            // 
            // dateTimeDeadline
            // 
            dateTimeDeadline.Location = new Point(197, 360);
            dateTimeDeadline.Name = "dateTimeDeadline";
            dateTimeDeadline.Size = new Size(317, 27);
            dateTimeDeadline.TabIndex = 18;
            // 
            // dateTimeReportTime
            // 
            dateTimeReportTime.Location = new Point(197, 95);
            dateTimeReportTime.Name = "dateTimeReportTime";
            dateTimeReportTime.Size = new Size(317, 27);
            dateTimeReportTime.TabIndex = 17;
            // 
            // btnSubmitIncident
            // 
            btnSubmitIncident.BackColor = Color.SkyBlue;
            btnSubmitIncident.Location = new Point(389, 548);
            btnSubmitIncident.Name = "btnSubmitIncident";
            btnSubmitIncident.Size = new Size(125, 41);
            btnSubmitIncident.TabIndex = 16;
            btnSubmitIncident.Text = "Submit Incident";
            btnSubmitIncident.UseVisualStyleBackColor = false;
            btnSubmitIncident.Click += btnSubmitIncident_Click;
            // 
            // btnCancelIncidentSubmission
            // 
            btnCancelIncidentSubmission.Location = new Point(195, 548);
            btnCancelIncidentSubmission.Name = "btnCancelIncidentSubmission";
            btnCancelIncidentSubmission.Size = new Size(125, 41);
            btnCancelIncidentSubmission.TabIndex = 15;
            btnCancelIncidentSubmission.Text = "Cancel";
            btnCancelIncidentSubmission.UseVisualStyleBackColor = true;
            btnCancelIncidentSubmission.Click += btnCancelIncidentSubmission_Click;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(197, 404);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(319, 138);
            textBoxDescription.TabIndex = 14;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(23, 407);
            label17.Name = "label17";
            label17.Size = new Size(88, 20);
            label17.TabIndex = 13;
            label17.Text = "Description:";
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.FormattingEnabled = true;
            comboBoxPriority.Items.AddRange(new object[] { "Low", "Medium", "High" });
            comboBoxPriority.Location = new Point(197, 269);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(319, 28);
            comboBoxPriority.TabIndex = 11;
            // 
            // comboBoxUsername
            // 
            comboBoxUsername.FormattingEnabled = true;
            comboBoxUsername.Location = new Point(195, 179);
            comboBoxUsername.Name = "comboBoxUsername";
            comboBoxUsername.Size = new Size(319, 28);
            comboBoxUsername.TabIndex = 10;
            // 
            // txtBoxSubjectofIncident
            // 
            txtBoxSubjectofIncident.Location = new Point(195, 136);
            txtBoxSubjectofIncident.Name = "txtBoxSubjectofIncident";
            txtBoxSubjectofIncident.Size = new Size(319, 27);
            txtBoxSubjectofIncident.TabIndex = 8;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F);
            label16.Location = new Point(23, 360);
            label16.Name = "label16";
            label16.Size = new Size(161, 23);
            label16.TabIndex = 6;
            label16.Text = "Deadline/Follow up:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F);
            label15.Location = new Point(23, 315);
            label15.Name = "label15";
            label15.Size = new Size(60, 23);
            label15.TabIndex = 5;
            label15.Text = "Status:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F);
            label14.Location = new Point(21, 179);
            label14.Name = "label14";
            label14.Size = new Size(144, 23);
            label14.TabIndex = 4;
            label14.Text = "Reported by user:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.Location = new Point(21, 136);
            label12.Name = "label12";
            label12.Size = new Size(156, 23);
            label12.TabIndex = 2;
            label12.Text = "Subject of incident:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(21, 95);
            label11.Name = "label11";
            label11.Size = new Size(165, 23);
            label11.TabIndex = 1;
            label11.Text = "Date/Time reported:";
            // 
            // TopLabel
            // 
            TopLabel.AutoSize = true;
            TopLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TopLabel.Location = new Point(3, -1);
            TopLabel.Name = "TopLabel";
            TopLabel.Size = new Size(343, 46);
            TopLabel.TabIndex = 0;
            TopLabel.Text = "Create New Incident";
            // 
            // IncidentCreatorModal
            // 
            AcceptButton = btnSubmitIncident;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelIncidentSubmission;
            ClientSize = new Size(578, 606);
            Controls.Add(pnlCreateNewIncident);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "IncidentCreatorModal";
            Text = "IncidentCreatorModal";
            pnlCreateNewIncident.ResumeLayout(false);
            pnlCreateNewIncident.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCreateNewIncident;
        private Button btnSubmitIncident;
        private Button btnCancelIncidentSubmission;
        private TextBox textBoxDescription;
        private Label label17;
        private ComboBox comboBoxPriority;
        private ComboBox comboBoxUsername;
        private TextBox txtBoxSubjectofIncident;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label12;
        private Label label11;
        private Label TopLabel;
        private DateTimePicker dateTimeReportTime;
        private DateTimePicker dateTimeDeadline;
        private ComboBox comboBoxHandler;
        private Label label1;
        private ComboBox comboBoxStatus;
        private Label label2;
    }
}