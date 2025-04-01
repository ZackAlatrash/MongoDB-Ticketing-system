namespace Forms_UI
{
    partial class TransferingTicketsForm
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
            selectedTicketLabel = new Label();
            usersComboBox = new ComboBox();
            transferButton = new Button();
            SuspendLayout();
            // 
            // selectedTicketLabel
            // 
            selectedTicketLabel.AutoSize = true;
            selectedTicketLabel.Location = new Point(54, 46);
            selectedTicketLabel.Name = "selectedTicketLabel";
            selectedTicketLabel.Size = new Size(50, 20);
            selectedTicketLabel.TabIndex = 0;
            selectedTicketLabel.Text = "label1";
            // 
            // usersComboBox
            // 
            usersComboBox.FormattingEnabled = true;
            usersComboBox.Location = new Point(54, 117);
            usersComboBox.Name = "usersComboBox";
            usersComboBox.Size = new Size(301, 28);
            usersComboBox.TabIndex = 1;
            // 
            // transferButton
            // 
            transferButton.Location = new Point(152, 196);
            transferButton.Name = "transferButton";
            transferButton.Size = new Size(94, 29);
            transferButton.TabIndex = 2;
            transferButton.Text = "Transfer";
            transferButton.UseVisualStyleBackColor = true;
            transferButton.Click += transferButton_Click;
            // 
            // TransferingTicketsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 269);
            Controls.Add(transferButton);
            Controls.Add(usersComboBox);
            Controls.Add(selectedTicketLabel);
            Name = "TransferingTicketsForm";
            Text = "TransferingTicketsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label selectedTicketLabel;
        private ComboBox usersComboBox;
        private Button transferButton;
    }
}